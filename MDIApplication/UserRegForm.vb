Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Reflection
Imports MDIApplication.BioTrackMain

Public Class FrmUser
    Public pstatus As String

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.Tag = "U" Then
            Me.txtuid.ReadOnly = True
        Else
            Me.txtuid.Text = ""
            Me.txtname.Text = ""
            Me.txtuid.ReadOnly = False
        End If
        txtuid.Select()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim sql As String
        Dim db As New Class1

        If Trim(txtuid.Text) = "" Then
            MsgBox("Enter UserID")
            txtuid.Focus()

        ElseIf Trim(txtname.Text) = "" Then
            MsgBox("Enter Username")
            txtname.Focus()

        ElseIf Trim(txtPassword.Text) = "" Then
            MsgBox("Enter Password")
            txtPassword.Focus()
        Else

            If Me.Tag = "I" Then
                If chbstat.Checked = True Then
                    sql = "insert into Users(uname,userid,passwd,stat) values ('" & Trim(txtname.Text) & "','" & Trim(txtuid.Text) & "','" & Trim(txtPassword.Text) & "',1)"
                Else
                    sql = "insert into Users(uname,userid,passwd,stat) values ('" & Trim(txtname.Text) & "','" & Trim(txtuid.Text) & "','" & Trim(txtPassword.Text) & "',0)"
                End If
                If db.insertQuery(sql) Then
                    Me.Tag = "U"

                    'MsgBox("User added successfully", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MsgBox("User already exists")
                    txtname.Text = ""
                    txtPassword.Text = ""
                    txtuid.Text = ""
                    chbstat.Checked = False
                    txtuid.Focus()
                End If

            ElseIf Me.Tag = "U" Then
                If chbstat.Checked = True Then
                    sql = "update Users set stat=1, uname='" & Trim(txtname.Text) & "', passwd='" & Trim(txtPassword.Text) & "' where userid='" & Trim(txtuid.Text) & "'"
                Else
                    sql = "update Users set stat=0, uname='" & Trim(txtname.Text) & "', passwd='" & Trim(txtPassword.Text) & "' where userid='" & Trim(txtuid.Text) & "'"
                End If

                db.updateQuery(sql)
                Me.Tag = "U"

                'MsgBox("User updated successfully", MsgBoxStyle.Information)
                Me.Close()
            End If
            End If

    End Sub

    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtuid.Focus()
    End Sub

    Private Sub btnsave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnsave.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtname.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txtuid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(Keys.Enter) Then
            txtname.Focus()
            e.Handled = True
        End If
    End Sub

End Class