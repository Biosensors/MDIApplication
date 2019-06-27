Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmAmpcData
    Inherits System.Windows.Forms.Form

    Dim bWorkOrderFound As Boolean
    Dim dt As New DataTable
    Dim strWONo As String
    Dim sql1 As String
    Dim ds1 As DataSet
    Dim CoatType As Integer

    Private Sub FrmAmpcData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        rbtnPostDry.Checked = True
        rbtn15Mins.Checked = False
        CoatType = 3
    End Sub

    Public Sub FillGrid()
        Try
            Dim sql As String
            Dim ds As New DataSet

            'bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtWONo.Text))
            ds.Clear()

            sql = "select WONo as 'Work Order No', FormnConc as 'Formulation Concentration', FormnDrugRatio as 'Formulation Drug Ratio' from ElectronicSheetH where CoatType = " & CoatType & " and wono like '%" & txtWONo.Text.ToString().Trim & "%' order by wono"
            ds = db.selectQuery(sql)
            dt = ds.Tables(0)
            dgAMPCData.DataSource = dt

            FormatGrid()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgAMPCData.Columns.Count - 1
            dgAMPCData.Columns(i).ReadOnly = True
            dgAMPCData.Columns(i).Width = 200
        Next
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FillGrid()
    End Sub

    Private Sub txtWONo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWONo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            FillGrid()
        End If
    End Sub

    Private Sub ClearControls()
        txtWONo.Text = ""
        ds.Clear()
    End Sub

    Private Sub dgAMPCData_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgAMPCData.DoubleClick
        Try
            Dim frmViewData As New FrmAmpcViewData
            If dgAMPCData.CurrentRow.Index < dt.Rows.Count Then

                If dgAMPCData.CurrentRow.Index >= 0 Then
                    If UCase(e.ToString) = "SYSTEM.WINDOWS.FORMS.MOUSEEVENTARGS" Then

                        strWONo = Trim(dgAMPCData.CurrentRow.Cells("Work Order No").Value.ToString())

                        Sql = "select FormnConc, FormnDrugRatio,AboveNominalTarget, AboveNominalUSL, AboveNominalLSL  from ElectronicSheetH where CoatType = " & CoatType & " and WONo = '" & strWONo & "'"
                        ds = db.selectQuery(Sql)

                        If ds.Tables(0).Rows.Count > 0 Then
                            FrmAmpcDataDetails.ClearControls()
                            FrmAmpcDataDetails.txtWONo.Text = strWONo
                            FrmAmpcDataDetails.txtWONo.ReadOnly = True

                            FrmAmpcDataDetails.AboveNominalTarget = ds.Tables(0).Rows(0).Item("AboveNominalTarget")
                            FrmAmpcDataDetails.AboveNominalUSL = ds.Tables(0).Rows(0).Item("AboveNominalUSL")
                            FrmAmpcDataDetails.AboveNominalLSL = ds.Tables(0).Rows(0).Item("AboveNominalLSL")

                            ds1 = New DataSet
                            sql1 = "select status from ElectronicSheetH where CoatType = " & CoatType & " and WONo = '" & strWONo & "'"
                            ds1 = db.selectQuery(sql1)

                            If ds1.Tables(0).Rows(0).Item("status") = "C" Then
                                FrmAmpcDataDetails.txtFormulationConc.ReadOnly = True
                                FrmAmpcDataDetails.txtFormulationDrugRatio.ReadOnly = True
                                FrmAmpcDataDetails.txtTargetAboveNominal.ReadOnly = True
                                FrmAmpcDataDetails.txtTargetDocNo.ReadOnly = True
                                FrmAmpcDataDetails.btnSave.Enabled = False
                                FrmAmpcDataDetails.btnConfirm.Enabled = False
                            Else
                                FrmAmpcDataDetails.txtFormulationConc.ReadOnly = False
                                FrmAmpcDataDetails.txtFormulationDrugRatio.ReadOnly = False
                                FrmAmpcDataDetails.txtTargetAboveNominal.ReadOnly = False
                                FrmAmpcDataDetails.txtTargetDocNo.ReadOnly = False
                                FrmAmpcDataDetails.btnSave.Enabled = True
                                FrmAmpcDataDetails.btnConfirm.Enabled = True
                            End If

                            FrmAmpcDataDetails.CoatType = CoatType
                            FrmAmpcDataDetails.ShowDialog()
                            FillGrid()
                        End If

                    End If
                End If
            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        FrmAmpcDataDetails.ClearControls()
        FrmAmpcDataDetails.txtWONo.ReadOnly = False
        FrmAmpcDataDetails.txtFormulationConc.ReadOnly = False
        FrmAmpcDataDetails.txtFormulationDrugRatio.ReadOnly = False
        FrmAmpcDataDetails.btnSave.Enabled = True
        FrmAmpcDataDetails.btnConfirm.Enabled = False
        FrmAmpcDataDetails.txtWONo.Select()
        FrmAmpcDataDetails.CoatType = CoatType
        FrmAmpcDataDetails.ShowDialog()
        FillGrid()
    End Sub

    Private Sub btnViewCoatingData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewCoatingData.Click
        If dgAMPCData.CurrentRow.Index < dt.Rows.Count Then
            If dgAMPCData.CurrentRow.Index >= 0 Then
                FrmAmpcDataReview.txtStentWONo.Text = Trim(dgAMPCData.CurrentRow.Cells("Work Order No").Value.ToString())
                FrmAmpcDataReview.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub rbtnPostDry_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnPostDry.CheckedChanged
        If rbtnPostDry.Checked = True Then
            rbtn15Mins.Checked = False
            CoatType = 3
        End If
        FillGrid()
    End Sub

    Private Sub rbtn15Mins_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn15Mins.CheckedChanged
        If rbtn15Mins.Checked = True Then
            rbtnPostDry.Checked = False
            CoatType = 2
        End If
        FillGrid()
    End Sub
    
End Class