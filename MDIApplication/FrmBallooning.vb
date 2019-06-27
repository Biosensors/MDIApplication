Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmBallooning

    Private Sub FrmBalooning_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDim1.Enabled = False
        txtDim2.Enabled = False
        txtDim3.Enabled = False
    End Sub

    Private Sub btnPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPass.Click
        txtDim1.Enabled = True
        txtDim2.Enabled = True
        txtDim3.Enabled = True
        'Include shortcut key F5 
    End Sub

    Private Sub btnFail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFail.Click

        'Include shortcut key F6
    End Sub

    Private Sub btnPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnPass.KeyDown
        If e.KeyCode = 116 Then
            Call btnPass_Click(btnPass, e)
        End If
    End Sub

    Private Sub btnFail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnFail.KeyDown
        If e.KeyCode = 117 Then
            Call btnFail_Click(btnFail, e)
        End If
    End Sub
End Class