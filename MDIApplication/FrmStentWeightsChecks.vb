Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.ComponentModel.Container
Imports System.Drawing

Public Class FrmStentWeightsAdminChecks
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim strSerialNo As String
    Dim StentKey As Integer
    Dim iCoating As Integer

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FillGrid()
    End Sub

    Public Sub FillGrid()
        Try
            Dim sql As String
            sql = "select stntkey, stntserial as 'Stent Serial', CONVERT(numeric(18,4),finalwt) as Weight, 'Coating' = case coating when 1 then 'Pre Coating' when 3 then 'Post Coating' end, machine as Machine, weightedby as 'Operator', convert(varchar(12), weightedon, 106) as 'Weighed On' from stentweightschecks where stntserial like '%" & txtStentSerialNo.Text.ToString().Trim & "%' and overwritten = 0"
            sql = sql & "order by stntserial"
            ds = db.selectQuery(sql)

            ds.Tables(0).Columns("stntkey").ColumnMapping = MappingType.Hidden
            dt = ds.Tables(0)
            dgStentWeights.DataSource = dt

            FormatGrid()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgStentWeights.Columns.Count - 1
            dgStentWeights.Columns(i).ReadOnly = True
            dgStentWeights.Columns(i).Width = 125
        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dt.Rows.Count <= 0 Then
            MsgBox("No record is selected")
        Else
            Dim Ans As Integer
            Ans = MsgBox("Are you sure want to delete?", vbYesNo + vbExclamation)

            If Ans = vbYes Then
                If dgStentWeights.CurrentRow.Index >= 0 Then
                    If UCase(e.ToString) = "SYSTEM.WINDOWS.FORMS.MOUSEEVENTARGS" Then
                        StentKey = dt.Rows(dgStentWeights.CurrentRow.Index).Item(0).ToString()
                        Sql = "delete from stentweightschecks where stntkey=" & StentKey & ""
                        If db.deleteQuery(Sql) Then
                            'MsgBox("Weight deleted")
                        Else
                            MsgBox("Weight not deleted")
                        End If
                    End If
                End If
            End If

            FillGrid()
        End If
    End Sub

    Private Sub txtStentSerialNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStentSerialNo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            FillGrid()
        End If
    End Sub

    Private Sub btnOverwrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverwrite.Click

        Dim Sql1 As String
        ClearTextBoxes()

        If dt.Rows.Count <= 0 Then
            MsgBox("No record is selected")
        Else

            If dgStentWeights.CurrentRow.Index >= 0 Then
                If UCase(e.ToString) = "SYSTEM.WINDOWS.FORMS.MOUSEEVENTARGS" Then
                    StentKey = dt.Rows(dgStentWeights.CurrentRow.Index).Item(0).ToString()

                    'Display Admin Weights
                    Sql = "select stntkey, stntserial, coating, CONVERT(numeric(18,4),step1wt) as step1wt, CONVERT(numeric(18,4),step2wt) as step2wt, CONVERT(numeric(18,4),step3wt) as step3wt, CONVERT(numeric(18,4),finalwt) as finalwt from stentweightschecks where stntkey=" & StentKey & ""
                    ds = db.selectQuery(Sql)

                    If ds.Tables(0).Rows.Count > 0 Then
                        strSerialNo = ds.Tables(0).Rows(0).Item("stntserial")
                        iCoating = ds.Tables(0).Rows(0).Item("coating")

                        FrmStentWeightOverwrite.txtAdminWt1.Text = ds.Tables(0).Rows(0).Item("step1wt")
                        FrmStentWeightOverwrite.txtAdminWt2.Text = ds.Tables(0).Rows(0).Item("step2wt")
                        FrmStentWeightOverwrite.txtAdminWt3.Text = ds.Tables(0).Rows(0).Item("step3wt")
                        FrmStentWeightOverwrite.txtAdminFinalWt.Text = ds.Tables(0).Rows(0).Item("finalwt")
                        FrmStentWeightOverwrite.lblStentKeyAdminWt.Text = ds.Tables(0).Rows(0).Item("stntkey")
                    End If

                    'Display Operator Weights
                    Sql1 = "select stntkey, stntserial, coating, CONVERT(numeric(18,4),step1wt) as step1wt, CONVERT(numeric(18,4),step2wt) as step2wt, CONVERT(numeric(18,4),step3wt) as step3wt, CONVERT(numeric(18,4),finalwt) as finalwt from stentfinalweights where stntserial = '" & strSerialNo & "' and coating = " & iCoating & ""
                    ds = db.selectQuery(Sql1)

                    If ds.Tables(0).Rows.Count > 0 Then
                        FrmStentWeightOverwrite.txtOperatorWt1.Text = ds.Tables(0).Rows(0).Item("step1wt")
                        FrmStentWeightOverwrite.txtOperatorWt2.Text = ds.Tables(0).Rows(0).Item("step2wt")
                        FrmStentWeightOverwrite.txtOperatorWt3.Text = ds.Tables(0).Rows(0).Item("step3wt")
                        FrmStentWeightOverwrite.txtOperatorFinalWt.Text = ds.Tables(0).Rows(0).Item("finalwt")
                        FrmStentWeightOverwrite.lblStentKeyOperatorWt.Text = ds.Tables(0).Rows(0).Item("stntkey")
                        FrmStentWeightOverwrite.ShowDialog()
                    Else
                        MsgBox("Operator weights donot exist. Weights cannot be overwritten.")
                    End If

                    FillGrid()
                End If
            End If
        End If
    End Sub

    Private Sub ClearTextBoxes()
        FrmStentWeightOverwrite.txtAdminWt1.Text = ""
        FrmStentWeightOverwrite.txtAdminWt2.Text = ""
        FrmStentWeightOverwrite.txtAdminWt3.Text = ""
        FrmStentWeightOverwrite.txtAdminFinalWt.Text = ""
        FrmStentWeightOverwrite.txtOperatorWt1.Text = ""
        FrmStentWeightOverwrite.txtOperatorWt1.Text = ""
        FrmStentWeightOverwrite.txtOperatorWt1.Text = ""
        FrmStentWeightOverwrite.txtOperatorFinalWt.Text = ""
    End Sub

End Class