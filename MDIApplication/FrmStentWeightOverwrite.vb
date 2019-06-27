Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmStentWeightOverwrite

    Private Sub btnOverwrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverwrite.Click

        Dim Ans As Integer
        Ans = MsgBox("Are you sure want to overwrite the stent weights?", vbYesNo + vbExclamation)

        If Ans = vbYes Then

            Sql = "update stentfinalweights set step1wt = " & Val(txtAdminWt1.Text) & " , step2wt = " & Val(txtAdminWt2.Text) & ", step3wt = " & Val(txtAdminWt3.Text) & ", finalwt = " & Val(txtAdminFinalWt.Text) & ", datamode = 2, modifiedby = '" & sLogonUser & "', modifiedon = getdate() where stntkey = " & lblStentKeyOperatorWt.Text & ""
            If db.updateQuery(Sql) Then
                Sql = "update stentweightschecks set overwritten = 1 where stntkey = " & lblStentKeyAdminWt.Text & ""
                If db.updateQuery(Sql) Then
                    Me.Close()
                End If
            Else
                MsgBox("Weights not Overwritten")
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class