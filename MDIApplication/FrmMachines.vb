Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmMachines
    Inherits System.Windows.Forms.Form

    Private strMachineID As String
    Dim dt As DataTable

    Private Sub FrmMachines_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtMachine.Text = ""
    End Sub

    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FillGrid()
    End Sub

    Public Sub FillGrid()
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "select machineid as 'Machine ID', name as 'Machine Name', CAST(autologoffmins AS varchar(3)) + ' mins' as 'Auto Logoff', Status = case status when 1 then 'Active' else 'Inactive' end, useby as 'Use By Operator' from machines where machineid like '%" & txtMachine.Text.ToString().Trim & "%' or name like '%" & txtMachine.Text.ToString().Trim & "%'"
            ds = db.selectQuery(sql)
            dgMachines.DataSource = ds.Tables(0).DefaultView
            FormatGrid()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgMachines.Columns.Count - 1
            dgMachines.Columns(i).ReadOnly = True
            dgMachines.Columns(i).Width = 150
        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtMachine_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMachine.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            FillGrid()
        End If
    End Sub

    Private Sub dgMachines_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMachines.DoubleClick
        Try
            If dgMachines.CurrentRow.Index >= 0 Then
                If UCase(e.ToString) = "SYSTEM.WINDOWS.FORMS.MOUSEEVENTARGS" Then
                    strMachineID = Trim(dgMachines.CurrentRow.Cells(0).Value.ToString())

                    Sql = "select name,serialno,autologoffmins,status,hostname, CAST(baudrate AS nvarchar(10)) + ' / ' + CAST(timeout AS nvarchar(10)) + ' / ' + CAST(portno AS nvarchar(10)) as BTP from machines where machineid='" & strMachineID & "'"
                    ds = db.selectQuery(Sql)

                    FrmEditMachine.txtMachineID.Text = strMachineID
                    FrmEditMachine.strMachineID = strMachineID
                    FrmEditMachine.txtMachineName.Text = ds.Tables(0).Rows(0).Item("name")
                    FrmEditMachine.txtSerialNo.Text = ds.Tables(0).Rows(0).Item("serialno")
                    FrmEditMachine.txtAutoLogoff.Text = ds.Tables(0).Rows(0).Item("autologoffmins")
                    FrmEditMachine.txtHostName.Text = ds.Tables(0).Rows(0).Item("hostname")
                    FrmEditMachine.txtBTP.Text = ds.Tables(0).Rows(0).Item("BTP")

                    If ds.Tables(0).Rows(0).Item("status") = 1 Then
                        FrmEditMachine.chkActiveStatus.Checked = True
                    Else
                        FrmEditMachine.chkActiveStatus.Checked = False
                    End If
                    FrmEditMachine.ShowDialog()
                    FillGrid()
                End If
            End If
        Catch ex As System.Exception

        End Try
    End Sub

End Class