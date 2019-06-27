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
Public Class FrmShipment
    Public db As New Class1
    Public clspm As New clsPublic_Methods
    Public sOprn As String = "BOX"
    Dim datRow As DataRow
    Public Sql As String
    Public strvalue1 As Boolean
    Private Sub FrmShipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  FillShipmentDetails()
    End Sub

    ' CheckIfSubConPOExist

    Private Function CheckIfSubConPOExist() As Boolean
        Try
            Dim sErrorMessage As String
            Dim nErrorcount As Integer
            Dim nCurrentPONumer As String

            CheckIfSubConPOExist = False

            If Trim(txtEnter.Text) <> "" Then
                Sql = ""
                Sql = Sql & "[SP_CheckAndCreateSubConPO] '" & Trim(txtEnter.Text) & "','" & sLogonUser & "','X' "
                ds = db.selectQuery(Sql)
                If (ds.Tables(0).Rows.Count > 0) Then
                    sErrorMessage = ds.Tables(0).Rows(0).Item("ErrorMessages").ToString
                    nErrorcount = ds.Tables(0).Rows(0).Item("ErrorCount")
                    nCurrentPONumer = ds.Tables(0).Rows(0).Item("PONumber").ToString
                    If nErrorcount > 0 Then
                        MsgBox(sErrorMessage)
                        If MsgBox("Would you like to Create this SubCon PO Number ?", MsgBoxStyle.OkCancel, "Confirm to Create SubCon PO") = MsgBoxResult.Ok Then
                            Sql = ""
                            Sql = Sql & "[SP_CheckAndCreateSubConPO] '" & Trim(txtEnter.Text) & "','" & sLogonUser & "','' "
                            ds = db.selectQuery(Sql)
                            If (ds.Tables(0).Rows.Count > 0) Then
                                MsgBox(ds.Tables(0).Rows(0).Item("ErrorMessages"))
                                CheckIfSubConPOExist = False
                            Else
                                CheckIfSubConPOExist = True
                            End If
                        End If
                    End If
                End If
                CheckIfSubConPOExist = True
            End If
        Catch ex As System.Exception
            errMsgBox(Sql)
            errMsgBox("Error:  " & ex.Message.ToString())
        End Try
    End Function



    Private Sub FillShipmentDetails()
        Try
            If Trim(txtEnter.Text) <> "" Then
                Sql = ""
                Sql = Sql & "EXEC [SPGetShippedSerialsCount] '" & Trim(txtEnter.Text) & "' "
            End If

            ds = db.selectQuery(Sql)
            dgShipment.DataSource = ds.Tables(0).DefaultView

        Catch ex As System.Exception
            errMsgBox(Sql)
            errMsgBox("Error:  " & ex.Message.ToString())
        End Try
    End Sub
   
    Public Sub errMsgBox(ByVal msg As String)
        Dim lbl As New Label()

        lbl.Text = "<script language='javascript'>" & Environment.NewLine & _
               "window.alert('" + msg + "')</script>"
        Me.Controls.Add(lbl)

    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
    Private Sub btnScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScan.Click
        If dgShipment.RowCount <> 0 Then
            sShipmentWorkOrderNO = dgShipment.Item(0, dgShipment.CurrentRow.Index).Value
            Shipment.ShowDialog()
        End If
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        lblProgress.Visible = True
        Me.Cursor = Cursors.WaitCursor
        Me.Refresh()
        If CheckIfSubConPOExist() Then
            FillShipmentDetails()
            lblProgress.Visible = False
            Me.Cursor = Cursors.Arrow
        End If
        Me.Cursor = Cursors.Arrow
        Me.Refresh()
    End Sub
    'Private Sub dgShipment_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgShipment.MouseClick
    '    If UCase(e.Button.ToString) = "LEFT" Then
    '        sShipmentWorkOrderNO = dgShipment.Item(1, dgShipment.CurrentRow.Index).Value
    '    Else
    '        sShipmentWorkOrderNO = ""
    '    End If
    '    Shipment.ShowDialog()
    'End Sub

    'Private Sub dgShipment_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgShipment.MouseClick
    '    If UCase(e.Button.ToString) = "LEFT" Then
    '        sShipmentWorkOrderNO = dgShipment.Item(0, dgShipment.CurrentRow.Index).Value
    '    Else
    '        sShipmentWorkOrderNO = ""
    '    End If
    '    If sShipmentWorkOrderNO = "" Then
    '        btnScan.Enabled = False
    '    Else
    '        btnScan.Enabled = True
    '    End If
    '    ' Shipment.ShowDialog()
    'End Sub

    
    Private Sub txtEnter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEnter.TextChanged

    End Sub
End Class
