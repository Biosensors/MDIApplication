Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmEditMachine
    Inherits System.Windows.Forms.Form

    Public strMachineID As String
    Dim Status As Integer

    Private Sub FrmEditMachine_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            If txtMachineName.Text.Trim = "" Then
                MsgBox("Enter Machine Name")
                txtMachineName.Focus()

            ElseIf txtAutoLogoff.Text.Trim = "" Then
                MsgBox("Enter Auto LogOff Mins")
                txtAutoLogoff.Focus()

            ElseIf Not IsNumeric(txtAutoLogoff.Text.Trim) Then
                MsgBox("Auto Logoff minutes must be numeric")
                txtAutoLogoff.Text = ""
                txtAutoLogoff.Focus()

            Else
                If chkActiveStatus.Checked = True Then
                    Status = 1
                Else
                    Status = 0
                End If

                Sql = "update machines set machineid = '" & txtMachineID.Text.Trim & "', name='" & txtMachineName.Text.Trim & "', autologoffmins=" & txtAutoLogoff.Text.Trim & ", status= " & Status & " where machineid='" & strMachineID & "'"
                If db.updateQuery(Sql) Then
                    Me.Close()
                End If

            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class