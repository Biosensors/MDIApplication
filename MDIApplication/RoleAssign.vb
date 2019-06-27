Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Reflection
Imports MDIApplication.BioTrackMain

Public Class RoleAssign
    Public pstatus As String

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' sConnectionServer = getConnectionString("TEST Server")
        If Me.Tag = "U" Then
            Me.txtRoleId.ReadOnly = True
        Else
            Me.txtRoleId.Text = ""
            Me.txtRoleName.Text = ""
        End If
        txtRoleId.Select()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim sql As String

        ' Dim inc As Integer
        'Dim ustatus As String
        'inc = 0
        Dim db As New Class1

        If Trim(txtRoleId.Text) = "" Then
            MsgBox("Enter Role ID")
            txtRoleId.Focus()

        ElseIf Trim(txtRoleName.Text) = "" Then
            MsgBox("Enter Role Name")
            txtRoleName.Focus()

        Else
            If Me.Tag = "I" Then

                sql = "insert into BioRoles(roleid, rolename) values ('" & txtRoleId.Text & "','" & txtRoleName.Text & "')"

                If db.insertQuery(sql) Then
                    Me.Tag = "U"

                    MsgBox("Data Updated ", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MsgBox("Role already exists")
                    txtRoleId.Text = ""
                    txtRoleName.Text = ""
                    txtRoleId.Focus()
                End If
                

            ElseIf Me.Tag = "U" Then
                sql = "update BioRoles set rolename='" & txtRoleName.Text & "' where roleid='" & txtRoleId.Text & "'"

                db.updateQuery(sql)
                Me.Tag = "U"

                MsgBox("Data Updated", MsgBoxStyle.Information)
                Me.Close()
            End If
        End If

    End Sub

    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRoleId.Focus()
        txtRoleName.Focus()
    End Sub

    Private Sub btnsave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnsave.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then

            txtRoleName.Focus()

            e.Handled = True
        End If
    End Sub

    Private Sub txtRoleId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(Keys.Enter) Then

            txtRoleName.Focus()
            e.Handled = True
        End If
    End Sub

End Class