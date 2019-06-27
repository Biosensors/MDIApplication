Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports MDIApplication.BioTrackMain
Imports MDIApplication.ClsUtil
Public Class Shipment
    Public Gstatus As String
    Public sql As String
    Public sOprn As String = "BOX"
    Public tabSelected As String
    Public db As New Class1
    Public clspm As New clsPublic_Methods
    Public ds As New DataSet
    Public tabName As String
    Public nCurOprn As Integer
    Public ds1 As New DataSet
    Public shipTo As New Integer
    Public srcheck1 As String
    Public srcheck As String
    Public srwono As String
    Public sShip2Target As String

    Private Sub Shipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtsrno1.Visible = True
        txtWono.Text = Trim(sShipmentWorkOrderNO)
        ' tabSelected = 'BIT'
        showBITGrid()
    End Sub

    Private Sub txtsrno1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsrno1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then

            txtsrno1.Focus()
            ' if serial number is valid

            If ValidateSerialNo() Then

                If (tbShipment.SelectedIndex = 0) Then
                    tabSelected = "BIT"
                    sShip2Target = "SGW"
                    txtsrno1.Visible = True
                    showBITGrid()
                ElseIf (tbShipment.SelectedIndex = 2) Then
                    tabSelected = "BESA"
                    sShip2Target = "CHW"
                    txtsrno1.Visible = False
                    showBESAGrid()
                ElseIf (tbShipment.SelectedIndex = 1) Then
                    tabSelected = "QA"
                    sShip2Target = "SGQ"
                    txtsrno1.Visible = True
                    showQAGrid()
                End If
            End If
            txtsrno1.Text = ""
        End If
    End Sub

    Private Function ShipToReturn(ByVal ds As DataSet) As Boolean
        If ds.Tables(0).Rows.Count > 0 Then
            If (Not IsDBNull(ds.Tables(0).Rows(0).Item("srlno1"))) Then
                ShipToReturn = True
            Else
                ShipToReturn = False
            End If
        Else
            ShipToReturn = False
        End If
        Return ShipToReturn
    End Function
    Private Function ValidateSerialNo() As Boolean

        ValidateSerialNo = False
        If Not txtsrno1.Text = "" Then
            sql = "EXECUTE [dbo].[SPCreateSubConIssues] '"
            sql = sql & txtsrno1.Text & "','"
            sql = sql & sShip2Target & "','"
            sql = sql & sShipmentWorkOrderNO & "','"
            sql = sql & sLogonUser & "'"

            ' sql = "select srlno1,wono,shipto from OperationLogs where oprn='" & sOprn & "' and srlno1='" & txtsrno1.Text & "' and status = 1"
            ds = db.selectQuery(sql)
            ' srwono = ds.Tables(0).Rows(0).Item("wono")
            Try

                If (ds.Tables(0).Rows.Count > 0) Then
                    If ds.Tables(0).Rows(0).Item("ErrorCount") > 0 Then
                        MsgBox(ds.Tables(0).Rows(0).Item("ErrorMessages") & ": " & ds.Tables(0).Rows(0).Item("SerialNo"), MsgBoxStyle.Critical)
                        txtsrno1.Text = ""
                    End If
                    '  txtWono.Text = srwono
  
                    'Else
                    '    MsgBox(txtsrno1.Text & " Is Invalid Serial Number")
                    '    txtsrno1.Text = ""
                End If
                txtsrno1.Text = ""

            Catch ex As System.Exception
                If InStr(ex.Message, "There is no row at position 0.", CompareMethod.Binary) > 0 Then
                    ValidateSerialNo = False
                End If


                Return ValidateSerialNo
            End Try
            'sShipmentWorkOrderNO = ""

        End If
    End Function

    Private Sub updateShipTo()
        Try
            ' If (ValidateSerialNo()) Then
            If (Gstatus = "A") Then ' For BIT 
                sql = " update OperationLogs set  shipto = 1, mdby = '" & sLogonUser & "', mddt = getdate() where srlno1 = '" & Trim(txtsrno1.Text) & "' and oprn ='" & sOprn & "'"
                db.updateQuery(sql)
                'Dim cmd As New SqlCommand(sql, conn)
                ' conn.Open()
                ' cmd.ExecuteNonQuery()
                ' conn.Close()

            End If
        Catch ex As System.Exception

        End Try
    End Sub

    

    Private Sub showBITGrid()
        Dim ds As New DataSet
        'If shipto = 1 and Gstatus = "A"  ie., BIT = 1
        'show serial number only in datagrid 
        Try
            sql = "EXEC SpGetSubConIssuedSerialNos '" & Trim(sShipmentWorkOrderNO) & "','" & Trim(sShip2Target) & "'"
            ds = db.selectQuery(sql)
            dgBIT.DataSource = ds.Tables(0).DefaultView
            countBITandBESA()

        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub showQAGrid()
        Dim ds As New DataSet
        'If shipto = 1 and Gstatus = "A"  ie., BIT = 1
        'show serial number only in datagrid 
        Try

            sql = "EXEC SpGetSubConIssuedSerialNos '" & Trim(sShipmentWorkOrderNO) & "','" & Trim(sShip2Target) & "'"
            ds = db.selectQuery(sql)
            dgQA.DataSource = ds.Tables(0).DefaultView
            countBITandBESA()

        Catch ex As System.Exception

        End Try
    End Sub


    Private Sub showBESAGrid()
        Dim ds As New DataSet
        'If shipto = 1 and Gstatus = "A"  ie., BESA = 1
        'show serial number only in datagrid 
        Try

            sql = "EXEC SpGetSubConIssuedSerialNos '" & Trim(sShipmentWorkOrderNO) & "','" & Trim(sShip2Target) & "'"

            'sql = " select srlno1 as [Serial No.], isnull(crby,mdby) as ScannedBy, CONVERT(varchar, crdt) AS [Scanned Date] from OperationLogs "
            'sql = sql & " where shipto = 0 and wono = '" & Trim(sShipmentWorkOrderNO) & "' and oprn = '" & Trim(sOprn) & "'"
            'sql = sql & " order by srlno1"

            ds1 = db.selectQuery(sql)
            dgBESA.DataSource = ds1.Tables(0).DefaultView
            countBITandBESA()
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub tbShimpment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbShipment.SelectedIndexChanged
        If (tbShipment.SelectedIndex = 0) Then
            ' tabSelected = "BESA"
            ' showBESAGrid()
            tabSelected = "BIT"
            sShip2Target = "SGW"
            txtsrno1.Visible = True
            showBITGrid()
        ElseIf (tbShipment.SelectedIndex = 2) Then
            ' tabSelected = "BIT"
            'showBITGrid()
            tabSelected = "BESA"
            sShip2Target = "CHW"
            txtsrno1.Visible = False
            showBESAGrid()
        ElseIf (tbShipment.SelectedIndex = 1) Then
            ' tabSelected = "BIT"
            'showBITGrid()
            tabSelected = "QA"
            sShip2Target = "SGQ"
            txtsrno1.Visible = True
            showQAGrid()
        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'Private Sub dgBIT_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgBIT.MouseClick
    '    Dim inc As Integer
    '    inc = dgBIT.CurrentRowIndex
    '    If UCase(e.Button.ToString) = "LEFT" Then
    '        sShipmentWorkOrderNO = dgBIT.Item(inc, 1)
    '    Else
    '        sShipmentWorkOrderNO = ""
    '    End If
    '    FrmShipment.ShowDialog()
    'End Sub

   


    'Private Sub dgBESA_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgBESA.MouseClick
    '    Dim inc As Integer

    '    If UCase(e.Button.ToString) = "LEFT" Then
    '        sShipmentWorkOrderNO = dgBIT.Item(inc, 1)
    '    Else
    '        sShipmentWorkOrderNO = ""
    '    End If
    '    FrmShipment.ShowDialog()
    'End Sub

    Private Sub countBITandBESA()
        sql = ""

        sql = " exec SPGetShippedSerialsCount '" & Trim(sShipmentWorkOrderNO) & "' "
        'sql = sql & "SELECT COUNT(CASE WHEN s.oprn ='" & sOprn & "' AND s.shipTo = 1 THEN s.srlno1 END) AS BIT, "
        'sql = sql & " COUNT(CASE WHEN s.oprn = '" & sOprn & "' AND s.shipTo = 0 THEN s.srlno1 END) AS BESA"
        'sql = sql & " From OperationLogs AS s "
        'sql = sql & " where s.oprn ='" & sOprn & "' and s.wono = '" & Trim(sShipmentWorkOrderNO) & "'"

        ds = db.selectQuery(sql)
        txtBIT.Text = ds.Tables(0).Rows(0).Item("BITCount").ToString()
        txtBESA.Text = ds.Tables(0).Rows(0).Item("BESACount").ToString()
        txtQASample.Text = ds.Tables(0).Rows(0).Item("QACount").ToString()
        txtWono.Text = sShipmentWorkOrderNO.ToString()
    End Sub

    Private Sub txtsrno1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsrno1.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblQaSample.Click

    End Sub
End Class



