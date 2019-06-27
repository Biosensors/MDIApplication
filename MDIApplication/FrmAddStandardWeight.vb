Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmAddStandardWeight
    Inherits System.Windows.Forms.Form

    Dim AddEditStatus As String

    Private Sub FrmAddStandardWeight_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If txtStentID.ReadOnly = True Then
                AddEditStatus = "Edit"
            Else
                AddEditStatus = "Add"
            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtStentID.Text.Trim = "" Then
                MsgBox("Enter Stent ID")
                txtStentID.Focus()

            ElseIf txtWeight.Text.Trim = "" Then
                MsgBox("Enter Weight")
                txtWeight.Focus()

            ElseIf txtMinWeightLimit.Text.Trim = "" Then
                MsgBox("Enter Min Tolerance")
                txtMinWeightLimit.Focus()

            ElseIf txtMaxWeightLimit.Text.Trim = "" Then
                MsgBox("Enter Max Tolerance")
                txtMaxWeightLimit.Focus()

            ElseIf Not IsNumeric(txtWeight.Text.Trim) Then
                MsgBox("Weight must be numeric")
                txtWeight.Text = ""
                txtWeight.Focus()

            ElseIf Not IsNumeric(txtMinWeightLimit.Text.Trim) Then
                MsgBox("Minimum Tolerance must be numeric")
                txtMinWeightLimit.Text = ""
                txtMinWeightLimit.Focus()

            ElseIf Not IsNumeric(txtMaxWeightLimit.Text.Trim) Then
                MsgBox("Maximum Tolerance must be numeric")
                txtMaxWeightLimit.Text = ""
                txtMaxWeightLimit.Focus()

            ElseIf Val(Trim(txtMinWeightLimit.Text)) >= Val(Trim(txtMaxWeightLimit.Text)) Then
                MsgBox("Minimum Weight Limit should be less than Maximum Weight")
                txtMinWeightLimit.Text = ""
                txtMinWeightLimit.Focus()

            Else
                If AddEditStatus = "Add" Then
                    Sql = "insert into stdweight(stentid,stdweight,mintolerance,maxtolerance) values('" & txtStentID.Text.Trim & "', '" & txtWeight.Text.Trim & "', '" & txtMinWeightLimit.Text.Trim & "', '" & txtMaxWeightLimit.Text.Trim & "')"

                    If db.insertQuery(Sql) Then
                        Me.Close()
                    Else
                        MsgBox("Standard Weight not added")
                    End If

                ElseIf AddEditStatus = "Edit" Then
                    Sql = "update stdweight set stentid = '" & txtStentID.Text.Trim & "', stdweight='" & txtWeight.Text.Trim & "', mintolerance=" & txtMinWeightLimit.Text.Trim & ", maxtolerance= " & txtMaxWeightLimit.Text.Trim & " where stentid='" & Trim(txtStentID.Text) & "'"
                    If db.updateQuery(Sql) Then
                        Me.Close()
                    Else
                        MsgBox("Standard Weight not updated")
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
            Sql = "delete from stdweight where stentid = '" & txtStentID.Text.Trim & "'"
            If db.deleteQuery(Sql) Then
                Me.Close()
            Else
                MsgBox("Standard Weight not deleted")
            End If
        End If

    End Sub
End Class