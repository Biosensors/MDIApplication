Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Configuration
Imports System.DirectoryServices
Imports System.Text
Imports System.Text.StringBuilder
Imports MDIApplication.BioTrackMain
Imports MDIApplication.IniFileFunctions
Imports System.Text.RegularExpressions

Public Class FrmAddSerial
    Inherits System.Windows.Forms.Form

    Public uid As String = sLogonUser
    Public strWONo As String
    Public ActualQty, DummyQty As Integer
    Public LastSrNo, LastDummySrNo As String
    Public GeneratedSerial As String
    Dim NoOfGenerated As Integer
    Dim objUtil As New ClsUtil()
    Dim SerialYear As String
    Dim SerialMonth As String
    Public BatchNo As String
    Dim bWorkOrderFound As Boolean
    Dim FormattedSerialYear, FormattedSerialMonth As String
    Public StentType As String

    Private Sub FrmAddSerial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SerialYear = objUtil.GetServerYear(Date.Today)
        SerialMonth = objUtil.GetServerMonth(Date.Today)
        FormattedSerialYear = objUtil.GetServerFormattedYear(Date.Today)
        FormattedSerialMonth = objUtil.GetServerMonth(Date.Today)

        'lblNoOfSerials.ReadOnly = True
        txtstwrkordno.Select()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtstwrkordno.Text))

        Try
            If txtstwrkordno.Text.Trim = "" Then
                MsgBox("Enter Work Order Number")
                txtstwrkordno.Focus()
            Else
                If Not (bWorkOrderFound) Then
                    MsgBox("Invalid Work Order")
                    Exit Sub
                Else

                    If stWODetails.sItemClass = "CS" Then
                        'If lblNoOfSerials.Text.Trim = "" Then
                        '    MsgBox("Enter Actual Quantity")
                        '    lblNoOfSerials.Focus()

                        'Else
                        'If Not IsNumeric(lblNoOfSerials.Text.Trim) Then
                        '    MsgBox("Actual Quantity must be numeric")
                        '    lblNoOfSerials.Text = ""
                        '    lblNoOfSerials.Focus()

                        'ElseIf CInt(lblPlanQty.Text.Trim) < CInt(lblNoOfSerials.Text.Trim) Then
                        '    MsgBox("Actual Quantity must be less than Plan Quantity")
                        '    lblNoOfSerials.Text = ""
                        '    lblNoOfSerials.Focus()

                        'Else
                        strWONo = Trim(txtstwrkordno.Text)

                        If txtstwrkordno.ReadOnly = True Then

                            If strQuery = "ActualSerials" Then
                                GenerateActualStentSerials(strWONo, stWODetails.sBatchNo)
                                Me.Close()
                            ElseIf strQuery = "DummySerials" Then
                                GenerateDummySerials(strWONo, stWODetails.sBatchNo)
                                Me.Close()
                            End If

                        ElseIf txtstwrkordno.ReadOnly = False Then

                            If strQuery = "ActualSerials" Then
                                Sql = "select stwono from StentsWOMaster where stwono='" & txtstwrkordno.Text.Trim & "'"
                                ds = db.selectQuery(Sql)

                                If ds.Tables(0).Rows.Count > 0 Then
                                    MsgBox("Serial numbers already generated for this work order number")
                                    ClearControls()
                                Else
                                    Sql = "insert into StentsWOMaster(stwono,planqty,actualqty,modifiedby,modifieddate) values ('" & txtstwrkordno.Text.Trim & "','" & lblPlanQty.Text.Trim & "','" & lblNoOfSerials.Text.Trim & "','" & uid & "', getdate()) "
                                    db.insertQuery(Sql)

                                    GenerateActualStentSerials(strWONo, stWODetails.sBatchNo)

                                    Me.Close()
                                End If

                            ElseIf strQuery = "DummySerials" Then
                                GenerateDummySerials(strWONo, stWODetails.sBatchNo)
                                Me.Close()
                            End If
                        End If
                    Else
                        MsgBox("Serials cannot be generated for this work order number")
                    End If
                    'End If
                End If
            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub GenerateActualStentSerials(ByVal strWONo As String, ByVal BatchNo As String)

        Sql = "select count(stntserial) from StentSerials where stwono='" & strWONo & "' and status=1 and stenttype=1"
        ds = db.selectQuery(Sql)
        NoOfGenerated = ds.Tables(0).Rows(0).Item(0)

        If Trim(lblNoOfSerials.Text) < NoOfGenerated Then
            MsgBox("Actual Quantity is less than No of generated serials")

        ElseIf Trim(lblNoOfSerials.Text) = NoOfGenerated Then

            If strQuery = "ActualSerials" Then
                Sql = "update StentsWOMaster set actualqty='" & lblNoOfSerials.Text.Trim & "',modifiedby='" & uid & "', modifieddate=getdate() where stwono='" & txtstwrkordno.Text.Trim & "'"
                db.updateQuery(Sql)
            End If
            Me.Close()

        Else
            Dim Ans As Integer

            Ans = MsgBox("Do you want to generate " & Trim(lblNoOfSerials.Text) - NoOfGenerated & " actual serial numbers for this Work Order?", vbYesNo + vbExclamation, "Generate Serial Numbers")
            If Ans = vbYes Then

                Sql = "update StentsWOMaster set actualqty='" & lblNoOfSerials.Text.Trim & "',modifiedby='" & uid & "', modifieddate=getdate() where stwono='" & txtstwrkordno.Text.Trim & "'"
                db.updateQuery(Sql)

                ActualQty = CInt(lblNoOfSerials.Text)

                'Generate serials for Actual Stents
                Sql = "select lastsrno from serialcount where year=" & SerialYear & " and month= " & SerialMonth & ""
                ds = db.selectQuery(Sql)

                If ds.Tables(0).Rows.Count = 0 Then
                    LastSrNo = 0
                Else
                    LastSrNo = ds.Tables(0).Rows(0).Item(0)
                End If

                LastSrNo = LastSrNo + 1
                LastSrNo = objUtil.StuffWithZeros(LastSrNo, 5)

                Dim count As Integer
                For count = LastSrNo To (LastSrNo + ((ActualQty - NoOfGenerated) - 1))
                    GeneratedSerial = stWODetails.sSerialPrefix & String.Concat(FormattedSerialYear, FormattedSerialMonth, LastSrNo) & stWODetails.sSerialSuffix

                    LastSrNo = CInt(LastSrNo) + 1
                    LastSrNo = objUtil.StuffWithZeros(LastSrNo, 5)
                    Sql = "insert into StentSerials(stntserial,status,stwono,stbatch,stenttype,createdby,createddate,modifiedby,modifieddate,pcount) values ('" & GeneratedSerial & "',1,'" & strWONo & "','" & BatchNo & "',1,'" & uid & "', getdate(),'" & uid & "', getdate(), '0') "
                    db.insertQuery(Sql)

                Next count

                Sql = "select year, month from serialcount where year= " & SerialYear & " and month=" & SerialMonth & ""
                ds = db.selectQuery(Sql)
                If ds.Tables(0).Rows.Count() = 0 Then
                    Sql = "insert into serialcount(year,month,lastsrno,dmysrno,lastupdatedby,lastupdateddate) values('" & SerialYear & "', '" & SerialMonth & "','" & LastSrNo - 1 & "',0,'" & uid & "',getdate())"
                    ds = db.selectQuery(Sql)
                Else
                    Sql = "update SerialCount set lastsrno = '" & LastSrNo - 1 & "',lastupdatedby='" & uid & "',lastupdateddate=getdate() where year='" & SerialYear & "' and month='" & SerialMonth & "'"
                    db.updateQuery(Sql)
                End If
                GenerateDummySerials(strWONo, BatchNo)
                If INIRead(INIFilePath, sServerName, "EnableLabelData") = 1 Then
                    'Write Normal Serials
                    clspm.WriteStentSerials(strWONo, "N")
                End If

                MsgBox("Serial numbers generated successfully")
            End If
        End If
    End Sub

    Private Sub GenerateDummySerials(ByVal strWONo As String, ByVal BatchNo As String)

        Dim Ans2 As Integer

        'If strQuery = "ActualSerials" Then
        'Else
        '    'lblNoOfSerials.Text = TxtDmySerials.Text
        'End If

        DummyQty = 15      'CInt(TxtDmySerials.Text)

        If DummyQty > 0 Then
            Ans2 = vbYes  ' No Questions asked. Generate 15 Nos automatically
            'MsgBox("Do you want to generate " & Trim(DummyQty) & " dummy serial numbers for this Work Order?", vbYesNo + vbExclamation, "Generate Serial Numbers")
            If Ans2 = vbYes Then

                LastDummySrNo = 0

                'Generate serials for Dummy Stents
                ' Commented by Ali, 14 Sep, 2011. Always generate 01-15 Dummy Serials. No year & month is required 
                'Sql = "select dmysrno from serialcount where year=" & SerialYear & " and month= " & SerialMonth & ""
                'ds = db.selectQuery(Sql)

                'If ds.Tables(0).Rows.Count = 0 Then
                '    LastDummySrNo = 0
                'Else
                '    LastDummySrNo = ds.Tables(0).Rows(0).Item(0)
                'End If
                ' End of Comments, 14 Sep, 2011.... Ali

                LastDummySrNo = LastDummySrNo + 1

                LastDummySrNo = objUtil.StuffWithZeros(LastDummySrNo, 2)

                Sql = "select count(stntserial) from StentSerials where stwono='" & strWONo & "' and status=1 and stenttype=2"
                ds = db.selectQuery(Sql)
                NoOfGenerated = ds.Tables(0).Rows(0).Item(0)

                Dim count As Integer
                For count = LastDummySrNo To (LastDummySrNo + DummyQty - 1)
                    GeneratedSerial = String.Concat(BatchNo, "-", LastDummySrNo)
                    LastDummySrNo = CInt(LastDummySrNo) + 1
                    LastDummySrNo = objUtil.StuffWithZeros(LastDummySrNo, 2)

                    Sql = "insert into StentSerials(stntserial,status,stwono,stbatch,stenttype,createdby,createddate,modifiedby,modifieddate,pcount) values ('" & GeneratedSerial & "',1,'" & strWONo & "','" & BatchNo & "',2,'" & uid & "', getdate(),'" & uid & "', getdate(), '0') "
                    db.insertQuery(Sql)
                Next count

                Sql = "select year, month from serialcount where year= " & SerialYear & " and month=" & SerialMonth & ""
                ds = db.selectQuery(Sql)
                If ds.Tables(0).Rows.Count() = 0 Then
                    Sql = "insert into serialcount(year,month,lastsrno,dmysrno,lastupdatedby,lastupdateddate) values('" & SerialYear & "', '" & SerialMonth & "',0,'" & LastDummySrNo - 1 & "','" & uid & "',getdate())"
                    ds = db.selectQuery(Sql)
                Else
                    Sql = "update SerialCount set dmysrno = '" & LastDummySrNo - 1 & "',lastupdatedby='" & uid & "',lastupdateddate=getdate() where year='" & SerialYear & "' and month='" & SerialMonth & "'"
                    db.updateQuery(Sql)
                End If

                If INIRead(INIFilePath, sServerName, "EnableLabelData") = 1 Then
                    'Write Dummy Serials
                    clspm.WriteStentSerials(strWONo, "D")
                End If

                'MsgBox("Dummy serial numbers generated successfully")
            End If
        Else
            MsgBox(" Enter Value for No. of Dummy Serials")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtstwrkordno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstwrkordno.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then

            If txtstwrkordno.Text.Trim <> "" Then
                bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtstwrkordno.Text))

                Try
                    If Not (bWorkOrderFound) Then
                        MsgBox("Invalid Work Order")
                        ClearControls()
                        Exit Sub
                    End If
                    If Len(Trim(stWODetails.sBatchNo)) = 0 Then
                        MsgBox("Batch # not assigned for this Work Order, Can not proceed !!!")
                        ClearControls()
                        Exit Sub
                    End If

                    lblItemCode.Text = stWODetails.sItemCode
                    lblItemDesc.Text = stWODetails.sItemDescription
                    lblBatchNo.Text = stWODetails.sBatchNo
                    lblSerialPrefix.Text = stWODetails.sSerialPrefix
                    ' Ashruf Ali, 4, July 2011. Get Year & Month from the actual Work Order's Date, instead of Current year & month
                    ' lblSerialYYMM.Text = FormattedSerialYear & SerialMonth

                    SerialYear = objUtil.GetServerYear(stWODetails.dWorkOrderDate)
                    SerialMonth = objUtil.GetServerMonth(stWODetails.dWorkOrderDate)

                    FormattedSerialYear = objUtil.GetServerFormattedYear(stWODetails.dWorkOrderDate)
                    FormattedSerialMonth = objUtil.GetServerMonth(stWODetails.dWorkOrderDate)

                    'FormattedSerialYear = Year(stWODetails.dWorkOrderDate)
                    'FormattedSerialYear = Mid(stWODetails.sBatchNo, 2, 2)
                    'FormattedSerialMonth = Mid(stWODetails.sBatchNo, 4, 2)
                    
                    'SerialYear = Val(FormattedSerialYear)
                    ' SerialMonth = Val(FormattedSerialMonth)

                    lblSerialYYMM.Text = FormattedSerialYear & FormattedSerialMonth
                    lblSerialNo.Text = "#####"
                    lblSerialSuffix.Text = stWODetails.sSerialSuffix
                    lblPlanQty.Text = stWODetails.nActualQty
                    lblNoOfSerials.Text = stWODetails.nActualQty 'Just for showing the Plan Qty
                    BatchNo = stWODetails.sBatchNo
                    If strQuery = "DummySerials" Then
                        TxtDmySerials.Visible = True
                        TxtDmySerials.Text = 0
                        lbldummy.Visible = True
                        TxtDmySerials.Focus()
                    Else
                        TxtDmySerials.Visible = False
                        lbldummy.Visible = False
                        lblNoOfSerials.Focus()
                    End If
                    'lblNoOfSerials.Focus()

                Catch ex As System.Exception
                    MsgBox(ex.Message)
                End Try
            End If

        End If
    End Sub

    Private Sub ClearControls()
        txtstwrkordno.Text = ""
        lblItemCode.Text = ""
        lblItemDesc.Text = ""
        lblBatchNo.Text = ""
        lblSerialPrefix.Text = ""
        lblSerialSuffix.Text = ""
        lblSerialYYMM.Text = ""
        lblSerialNo.Text = ""
        lblPlanQty.Text = ""
        lblNoOfSerials.Text = ""
        txtstwrkordno.Focus()
    End Sub

End Class