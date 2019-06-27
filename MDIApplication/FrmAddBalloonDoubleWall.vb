Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmAddBalloonDoubleWall
    Inherits System.Windows.Forms.Form

    Dim AddEditStatus As String

    Private Sub FrmAddBalloonDoubleWall_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If txtBalloonPartNo.ReadOnly = True Then
                AddEditStatus = "Edit"
            Else
                AddEditStatus = "Add"
            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtBalloonPartNo.Text.Trim = "" Then
                MsgBox("Enter Stent ID")
                txtBalloonPartNo.Focus()

            ElseIf txtDoubleWallMinValue.Text.Trim = "" Then
                MsgBox("Enter Double Wall Min Value")
                txtDoubleWallMinValue.Focus()

            ElseIf txtDoubleWallMaxValue.Text.Trim = "" Then
                MsgBox("Enter Double Wall Max Value")
                txtDoubleWallMaxValue.Focus()

            ElseIf txtDistalIDMinValue.Text.Trim = "" Then
                MsgBox("Enter Distal ID Min Value")
                txtDistalIDMinValue.Focus()

            ElseIf txtDistalIDMaxValue.Text.Trim = "" Then
                MsgBox("Enter Distal ID Max Value")
                txtDistalIDMaxValue.Focus()

            ElseIf Not IsNumeric(txtDoubleWallMinValue.Text.Trim) Then
                MsgBox("Double Wall Minimum Value must be numeric")
                txtDoubleWallMinValue.Text = ""
                txtDoubleWallMinValue.Focus()

            ElseIf Not IsNumeric(txtDoubleWallMaxValue.Text.Trim) Then
                MsgBox("Double Wall Maximum Value must be numeric")
                txtDoubleWallMaxValue.Text = ""
                txtDoubleWallMaxValue.Focus()

            ElseIf Not IsNumeric(txtDistalIDMinValue.Text.Trim) Then
                MsgBox("Distal ID Minimum Value must be numeric")
                txtDistalIDMinValue.Text = ""
                txtDistalIDMinValue.Focus()

            ElseIf Not IsNumeric(txtDistalIDMaxValue.Text.Trim) Then
                MsgBox("Distal ID Maximum Value must be numeric")
                txtDistalIDMaxValue.Text = ""
                txtDistalIDMaxValue.Focus()

            ElseIf Val(Trim(txtDoubleWallMinValue.Text)) >= Val(Trim(txtDoubleWallMaxValue.Text)) Then
                MsgBox("Double Wall Minimum Value should be less than Double Wall Maximum Value")
                txtDoubleWallMinValue.Text = ""
                txtDoubleWallMinValue.Focus()

            ElseIf Val(Trim(txtDistalIDMinValue.Text)) >= Val(Trim(txtDistalIDMaxValue.Text)) Then
                MsgBox("Distal ID Minimum Value should be less than Distal ID Maximum Value")
                txtDistalIDMinValue.Text = ""
                txtDistalIDMinValue.Focus()

            Else
                If AddEditStatus = "Add" Then
                    Sql = "insert into blndoublewalldata(blnpartno,dwmin,dwmax,distalidmin,distalidmax) values('" & txtBalloonPartNo.Text.Trim & "', '" & txtDoubleWallMinValue.Text.Trim & "', '" & txtDoubleWallMaxValue.Text.Trim & "','" & txtDistalIDMinValue.Text.Trim & "', '" & txtDistalIDMaxValue.Text.Trim & "')"

                    If db.insertQuery(Sql) Then
                        Me.Close()
                    Else
                        MsgBox("Data not added")
                    End If

                ElseIf AddEditStatus = "Edit" Then
                    Sql = "update blndoublewalldata set blnpartno = '" & txtBalloonPartNo.Text.Trim & "', dwmin=" & txtDoubleWallMinValue.Text.Trim & ", dwmax= " & txtDoubleWallMaxValue.Text.Trim & ", distalidmin=" & txtDistalIDMinValue.Text.Trim & ", distalidmax= " & txtDistalIDMaxValue.Text.Trim & " where blnpartno='" & Trim(txtBalloonPartNo.Text) & "'"
                    If db.updateQuery(Sql) Then
                        Me.Close()
                    Else
                        MsgBox("Data not updated")
                    End If
                End If
            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim Ans As Integer
        Ans = MsgBox("Are you sure want to delete?", vbYesNo + vbExclamation)

        If Ans = vbYes Then
            Sql = "delete from blndoublewalldata where blnpartno = '" & txtBalloonPartNo.Text.Trim & "'"
            If db.deleteQuery(Sql) Then
                Me.Close()
            Else
                MsgBox("Data not deleted")
            End If
        End If

    End Sub

End Class