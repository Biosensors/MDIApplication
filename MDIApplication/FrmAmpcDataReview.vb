Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmAmpcDataReview
    Inherits System.Windows.Forms.Form

    Dim bWorkOrderFound As Boolean
    Dim dt As New DataTable
    Dim strStentBatchNo, strStentSerialNo As String

    Private Sub FrmAmpcDataReview_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillGrid()
    End Sub

    Public Sub FillGrid()
        Try
            Dim sql As String
            Dim ds As New DataSet

            'bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtStentWONo.Text))
            ds.Clear()
            sql = "select cast(case when (select count(stntserial) from stentserials where stntserial = stentid) > 0 then 1 else 0 end as bit) as 'Valid ?', shoporderid as 'Stent Batch No', formulationLotId as 'Formln Batch No', stentid as 'Stent Serial', operatorid as 'Operator ID', systemid as 'System ID' from AmpcData A left join ZWoList Z on A.shopOrderId = Z.Facode  where Z.Project = '" & txtStentWONo.Text.ToString().Trim & "' order by 'Valid ?', 'Stent Serial'"

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
            dgAMPCData.Columns(i).Width = 132
        Next

        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("Valid ?") = False Then
                dgAMPCData.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FillGrid()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtStentWONo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStentWONo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            FillGrid()
        End If
    End Sub

    Private Sub ClearControls()
        txtStentWONo.Text = ""
        ds.Clear()
    End Sub

    Private Sub dgAMPCData_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgAMPCData.DoubleClick
        Try
            Dim frmViewData As New FrmAmpcViewData
            If dgAMPCData.CurrentRow.Index < dt.Rows.Count Then

                If dgAMPCData.CurrentRow.Index >= 0 Then
                    If UCase(e.ToString) = "SYSTEM.WINDOWS.FORMS.MOUSEEVENTARGS" Then

                        strStentBatchNo = Trim(dgAMPCData.CurrentRow.Cells("Stent Batch No").Value.ToString())
                        strStentSerialNo = Trim(dgAMPCData.CurrentRow.Cells("Stent Serial").Value.ToString())

                        frmViewData.sBatchNo = strStentBatchNo
                        frmViewData.sStentID = strStentSerialNo

                        If dt.Rows(dgAMPCData.CurrentRow.Index).Item("Valid ?") = False Then
                            frmViewData.txtStentSerialNo.ReadOnly = False
                            frmViewData.btnSave.Enabled = True
                        Else
                            frmViewData.txtStentSerialNo.ReadOnly = True
                            frmViewData.btnSave.Enabled = False
                        End If

                        Sql = "select actualDUTravel_mm, dose_mm, dose_ug, dose_ul, drugConcentration_ug1ul, drugName, drugTargetDose_ug, "
                        Sql = Sql & "formulationLotId, formulationVialId, syringeId, syringeModel, syringePitch_mm1ul, DUInitPrestart_ms, DUSkipPrestart_ms, "
                        Sql = Sql & "DUSkipPrestop_ms, contourSpeedup, contourWideR, contourWideX, contourWideX0, contourWideXJ, extraBandTurn, linkSpeedRatio, "
                        Sql = Sql & "needleElevation_um, needleElevation_um_inc1pass, passCount, processVersion, rSpreadMargin_mm, rSpreadMultiplier, "
                        Sql = Sql & "rSpreadPower, skipTime_ms, speed_mm1s, len_mm, modelName, thinnerSpeedup, operatorId, shopOrderId, "
                        Sql = Sql & "systemId, bandCount, doseDefiningLen_mm, linkStride, measuredLen_mm, modelName, nominalLen_mm, stentId, filename "
                        Sql = Sql & "from AmpcData where stentId = '" & strStentSerialNo & "'"

                        ds = db.selectQuery(Sql)

                        frmViewData.txtFileName.Text = ds.Tables(0).Rows(0).Item("filename")
                        frmViewData.txtStentBatchNo.Text = strStentBatchNo
                        frmViewData.txtStentSerialNo.Text = strStentSerialNo
                        frmViewData.txtActualDUTravel.Text = ds.Tables(0).Rows(0).Item("actualDUTravel_mm")
                        frmViewData.txtDose_mm.Text = ds.Tables(0).Rows(0).Item("dose_mm")
                        frmViewData.txtDose_ug.Text = ds.Tables(0).Rows(0).Item("dose_ug")
                        frmViewData.txtDose_ul.Text = ds.Tables(0).Rows(0).Item("dose_ul")
                        frmViewData.txtDrugConcentration.Text = ds.Tables(0).Rows(0).Item("drugConcentration_ug1ul")
                        frmViewData.txtDrugName.Text = ds.Tables(0).Rows(0).Item("drugName")
                        frmViewData.txtDrugTargetDose.Text = ds.Tables(0).Rows(0).Item("drugTargetDose_ug")
                        frmViewData.txtFormulationBatchNo.Text = ds.Tables(0).Rows(0).Item("formulationLotId")
                        frmViewData.txtFormulationVialID.Text = ds.Tables(0).Rows(0).Item("formulationVialId")
                        frmViewData.txtSyringeID.Text = ds.Tables(0).Rows(0).Item("syringeId")
                        frmViewData.txtSyringeModel.Text = ds.Tables(0).Rows(0).Item("syringeModel")
                        frmViewData.txtSyringePitch.Text = ds.Tables(0).Rows(0).Item("syringePitch_mm1ul")
                        frmViewData.txtDUInitPrestart.Text = ds.Tables(0).Rows(0).Item("DUInitPrestart_ms")
                        frmViewData.txtDUSkipPrestart.Text = ds.Tables(0).Rows(0).Item("DUSkipPrestart_ms")
                        frmViewData.txtDUSkipPrestop.Text = ds.Tables(0).Rows(0).Item("DUSkipPrestop_ms")
                        frmViewData.txtContourSpeedup.Text = ds.Tables(0).Rows(0).Item("contourSpeedup")
                        frmViewData.txtContourWideR.Text = ds.Tables(0).Rows(0).Item("contourWideR")
                        frmViewData.txtContourWideX.Text = ds.Tables(0).Rows(0).Item("contourWideX")
                        frmViewData.txtContourWideX0.Text = ds.Tables(0).Rows(0).Item("contourWideX0")
                        frmViewData.txtContourWideXJ.Text = ds.Tables(0).Rows(0).Item("contourWideXJ")
                        frmViewData.txtExtraBandTurn.Text = ds.Tables(0).Rows(0).Item("extraBandTurn")
                        frmViewData.txtLinkSpeedRatio.Text = ds.Tables(0).Rows(0).Item("linkSpeedRatio")
                        frmViewData.txtNeedleElevation.Text = ds.Tables(0).Rows(0).Item("needleElevation_um")
                        frmViewData.txtNeedleElevationInc1Pass.Text = ds.Tables(0).Rows(0).Item("needleElevation_um_inc1pass")
                        frmViewData.txtPassCount.Text = ds.Tables(0).Rows(0).Item("passCount")
                        frmViewData.txtProcessVersion.Text = ds.Tables(0).Rows(0).Item("processVersion")
                        frmViewData.txtRSpreadMargin.Text = ds.Tables(0).Rows(0).Item("rSpreadMargin_mm")
                        frmViewData.txtRSpreadMultiplier.Text = ds.Tables(0).Rows(0).Item("rSpreadMultiplier")
                        frmViewData.txtRSpreadPower.Text = ds.Tables(0).Rows(0).Item("rSpreadPower")
                        frmViewData.txtSkipTime.Text = ds.Tables(0).Rows(0).Item("skipTime_ms")
                        frmViewData.txtSpeed.Text = ds.Tables(0).Rows(0).Item("speed_mm1s")
                        frmViewData.txtLen.Text = ds.Tables(0).Rows(0).Item("len_mm")
                        frmViewData.txtModelName.Text = ds.Tables(0).Rows(0).Item("modelName")
                        frmViewData.txtThinnerSpeedup.Text = ds.Tables(0).Rows(0).Item("thinnerSpeedup")
                        frmViewData.txtOperatorID.Text = ds.Tables(0).Rows(0).Item("operatorId")
                        frmViewData.txtSystemID.Text = ds.Tables(0).Rows(0).Item("systemId")
                        frmViewData.txtBandCount.Text = ds.Tables(0).Rows(0).Item("bandCount")
                        frmViewData.txtDoseDefiningLen.Text = ds.Tables(0).Rows(0).Item("doseDefiningLen_mm")
                        frmViewData.txtLinkStride.Text = ds.Tables(0).Rows(0).Item("linkStride")
                        frmViewData.txtMeasuredLen.Text = ds.Tables(0).Rows(0).Item("measuredLen_mm")
                        frmViewData.txtModelName.Text = ds.Tables(0).Rows(0).Item("modelName")
                        frmViewData.txtNominalLen.Text = ds.Tables(0).Rows(0).Item("nominalLen_mm")

                        frmViewData.ShowDialog()
                        FillGrid()

                    Else
                        strStentBatchNo = ""
                    End If
                End If
            End If
        Catch ex As System.Exception

        End Try
    End Sub

End Class