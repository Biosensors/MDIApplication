Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Reflection
Imports MDIApplication.BioTrackMain

Public Class FrmAmpcDataDetails

    Public pstatus As String
    Dim bWorkOrderFound As Boolean
    Dim dt As DataTable
    Dim NomPLAWt, NomTotalWt, FormnConc, DummyAverageDose, FormnDrugRatio, NomDoseSpec As Double
    Public AboveNominalTarget, AboveNominalUSL, AboveNominalLSL As Double
    Public CoatType As Integer

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Clear()
        txtWONo.Select()

        If txtWONo.ReadOnly = True Then
            CheckAndFillDetailsFromTable()
        Else
            ds.Clear()
            FillGrid()
        End If
    End Sub

    Private Sub txtWONo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWONo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            If txtWONo.ReadOnly = False Then
                CheckAndFillDetailsFromView()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        UpdateData("Save")
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        UpdateData("Confirm")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CheckAndFillDetailsFromView()
        If Trim(txtWONo.Text) <> "" Then

            bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtWONo.Text))

            If bWorkOrderFound = True Then
                FillHeaderDetails()
                FillGrid()
                FillInProcessSpecs()
                FillPostProcessStatistics()
            Else
                MsgBox("Invalid Work Order")
                ClearControls()
                ds.Clear()
                FillGrid()
                txtWONo.Text = ""
                txtWONo.Focus()
            End If
        Else
            FillGrid()
        End If
    End Sub

    Private Sub CheckAndFillDetailsFromTable()

        bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtWONo.Text))

        If bWorkOrderFound = True Then
            FillGeneralHeaderDetails()

            Sql = "select WONo,AMPCNos,CONVERT(decimal(10,2),StentLen) as StentLen,FormnLotNo,CONVERT(decimal(10,2),FormnConc) as FormnConc,isnull(CONVERT(decimal(10,2),DummyAverageDose),0) as DummyAverageDose,CONVERT(decimal(10,3),FormnDrugRatio) as FormnDrugRatio,CONVERT(decimal(10,0),NomDoseSpec) as NomDoseSpec,CONVERT(decimal(10,0),NomPLAWt) as NomPLAWt,CONVERT(decimal(10,0),NomTotalWt) as NomTotalWt,CONVERT(decimal(10,2),AboveNominalTarget) as AboveNominalTarget,isnull(TargetDocNo,'') as TargetDocNo,CONVERT(decimal(10,2),AboveNominalUSL) as AboveNominalUSL,CONVERT(decimal(10,2),AboveNominalLSL) as AboveNominalLSL,CONVERT(decimal(10,0),DryWtTarget) as DryWtTarget,CONVERT(decimal(10,0),DryWtUSL) as DryWtUSL,CONVERT(decimal(10,0),DryWtLSL) as DryWtLSL,CONVERT(decimal(10,0),DoseTarget) as DoseTarget,CONVERT(decimal(10,0),DoseUSL) as DoseUSL,CONVERT(decimal(10,0),DoseLSL) as DoseLSL,AboveTargetNos,BelowTargetNos,CONVERT(decimal(10,2),HighestWt) as HighestWt,CONVERT(decimal(10,2),LowestWt) as LowestWt,AcceptedNos,RejectedNos,TotalStentsWeighed,CONVERT(decimal(10,2),Yield) as Yield,CONVERT(decimal(10,2),MedianCoatingWt) as MedianCoatingWt,CONVERT(decimal(10,2),RelStdDeviation) as RelStdDeviation from ElectronicSheetH where CoatType = " & CoatType & " and WONo = '" & Trim(txtWONo.Text) & "'"
            ds = db.selectQuery(Sql)

            If ds.Tables(0).Rows.Count > 0 Then

                txtAMPCNos.Text = ds.Tables(0).Rows(0).Item("AMPCNos")
                txtStentLength.Text = ds.Tables(0).Rows(0).Item("StentLen")
                txtFormulationConc.Text = ds.Tables(0).Rows(0).Item("FormnConc")
                txtFormulationDrugRatio.Text = ds.Tables(0).Rows(0).Item("FormnDrugRatio")
                txtNomDoseSpec.Text = ds.Tables(0).Rows(0).Item("NomDoseSpec")
                txtNomPLAWeight.Text = ds.Tables(0).Rows(0).Item("NomPLAWt")
                txtNomTotalWeight.Text = ds.Tables(0).Rows(0).Item("NomTotalWt")

                txtTargetAboveNominal.Text = ds.Tables(0).Rows(0).Item("AboveNominalTarget")
                txtTargetDocNo.Text = ds.Tables(0).Rows(0).Item("TargetDocNo")
                lblUSLAboveNominal.Text = ds.Tables(0).Rows(0).Item("AboveNominalUSL")
                lblLSLAboveNominal.Text = ds.Tables(0).Rows(0).Item("AboveNominalLSL")
                lblTargetDryWt.Text = ds.Tables(0).Rows(0).Item("DryWtTarget")
                lblUSLDryWt.Text = ds.Tables(0).Rows(0).Item("DryWtUSL")
                lblLSLDryWt.Text = ds.Tables(0).Rows(0).Item("DryWtLSL")
                lblTargetDose.Text = ds.Tables(0).Rows(0).Item("DoseTarget")
                lblUSLDose.Text = ds.Tables(0).Rows(0).Item("DoseUSL")
                lblLSLDose.Text = ds.Tables(0).Rows(0).Item("DoseLSL")

                lblAboveTarget.Text = ds.Tables(0).Rows(0).Item("AboveTargetNos")
                lblBelowTarget.Text = ds.Tables(0).Rows(0).Item("BelowTargetNos")
                lblHighestWeight.Text = ds.Tables(0).Rows(0).Item("HighestWt")
                lblLowestWeight.Text = ds.Tables(0).Rows(0).Item("LowestWt")
                lblAccepted.Text = ds.Tables(0).Rows(0).Item("AcceptedNos")
                lblRejected.Text = ds.Tables(0).Rows(0).Item("RejectedNos")
                lblTotalStentsWeighed.Text = ds.Tables(0).Rows(0).Item("TotalStentsWeighed")
                lblYield.Text = ds.Tables(0).Rows(0).Item("Yield")
                lblMedianCoatingWeight.Text = ds.Tables(0).Rows(0).Item("MedianCoatingWt")
                lblRelativeStdDeviation.Text = ds.Tables(0).Rows(0).Item("RelStdDeviation")

                'For 15 Mins Dry
                DummyAverageDose = ds.Tables(0).Rows(0).Item("DummyAverageDose")

                FillGrid()

            End If
        End If
    End Sub

    Private Sub FillHeaderDetails()

        FillGeneralHeaderDetails()

        txtStentLength.Text = stWODetails.nStentLength
        txtFormulationConc.Text = stWODetails.nFormConcentration

        If CoatType = 3 Then
            txtFormulationDrugRatio.Text = stWODetails.nFormDrugRatioPostWt
            txtNomPLAWeight.Text = stWODetails.nNomPLAPostWt
            txtNomTotalWeight.Text = stWODetails.nNomTotalPostWt
        ElseIf CoatType = 2 Then
            txtFormulationDrugRatio.Text = stWODetails.nFormDrugRatioFifteenWt
            txtNomPLAWeight.Text = stWODetails.nNomPLAFifteenWt
            txtNomTotalWeight.Text = stWODetails.nNomTotalFifteenWt
        End If

        txtNomDoseSpec.Text = stWODetails.nNormDose
        DummyAverageDose = stWODetails.nDummyAverageDose

        'To get AMPC Nos from Stored Procedure
        Dim ds1 As DataSet
        'ds1 = New DataSet
        'Dim conn As New SqlConnection(sConnectionServer)
        'Dim da As New SqlDataAdapter(Sql, conn)
        'da.SelectCommand.CommandText = "Exec sp_DisplayAllAMPCs" & "'" & Trim(txtWONo.Text) & "'"
        'da.Fill(ds1)

        Sql = "DECLARE @ampc VARCHAR(500) SELECT @ampc =  ISNULL(@ampc + ',', '') + cast(cast(a.ampc as int) as varchar(3)) FROM ( Select distinct top 100 cast(ampc as int) as ampc from VwElectronicForm  where  stwono='" & Trim(txtWONo.Text) & "' and ampc <> 99999 order by cast(ampc as int)) a	order by ampc SELECT  ampcresult = @ampc"
        ds1 = db.selectQuery(Sql)

        txtAMPCNos.Text = ds1.Tables(0).Rows(0).Item(0).ToString()

        FillNomDetails()

    End Sub

    Private Sub FillGeneralHeaderDetails()
        txtItem.Text = stWODetails.sItemCode
        txtBatchNo.Text = stWODetails.sBatchNo
        txtTotalStents.Text = stWODetails.nActualQty
        txtProductDesc.Text = stWODetails.sItemDescription
        txtFormulationLotNo.Text = stWODetails.sFormulationBatch
    End Sub

    Private Sub FillNomDetails()
        FormnConc = CDbl(Trim(txtFormulationConc.Text))
        FormnDrugRatio = CDbl(Trim(txtFormulationDrugRatio.Text))
        NomDoseSpec = CDbl(Trim(txtNomDoseSpec.Text))

        If FormnDrugRatio = 0 Then
            NomPLAWt = 0
        Else
            NomPLAWt = CDbl(Trim(txtNomDoseSpec.Text)) * (1 - CDbl(Trim(txtFormulationDrugRatio.Text))) / CDbl(Trim(txtFormulationDrugRatio.Text))
        End If

        If NomPLAWt = 0 Then
            NomTotalWt = 0
        Else
            NomTotalWt = CDbl(Trim(txtNomDoseSpec.Text)) + (CDbl(Trim(txtNomDoseSpec.Text)) * (1 - CDbl(Trim(txtFormulationDrugRatio.Text))) / CDbl(Trim(txtFormulationDrugRatio.Text)))
        End If
    End Sub

    Private Sub FillGrid()

        If txtNomTotalWeight.Text <> "" Then
            If txtNomTotalWeight.Text <> 0 Then

                'If CoatType = 3 Then
                '    Sql = "select StntSerial as 'Stent Serial', PreWt as 'Pre Weight', PostWt as 'Post Weight', (PostWt - PreWt) * 1000 as 'Net Coating Wt',  case ((PostWt - PreWt) * 1000) when 0 then 0 else ((((PostWt - PreWt) * 1000) / " & txtNomTotalWeight.Text & ") -1 ) * 100 end as 'Diff From Nom Wt', InspnCode as 'Inspection Code', cast(Ampc as integer) as 'AMPC No', VialNo as 'Syringe No', StentBatch as 'Parylene Stent Batch No' from VwElectronicForm where stwono='" & Trim(txtWONo.Text) & "' order by StntSerial"
                'ElseIf CoatType = 2 Then
                '    Sql = "select StntSerial as 'Stent Serial', PreWt as 'Pre Weight', FifteenWt as '15 Mins Weight', (FifteenWt - PreWt) * 1000 as 'Net Coating Wt',  case ((FifteenWt - PreWt) * 1000) when 0 then 0 else ((((FifteenWt - PreWt) * 1000) / " & txtNomTotalWeight.Text & ") -1 ) * 100 end as 'Diff From Nom Wt', case (FifteenWt - PreWt) * 1000 when 0 then 0 else UVDose / ((FifteenWt - PreWt) * 1000) end as DrugRatio, InspnCode as 'Inspection Code', VialNo as 'Syringe No' from VwElectronicForm where stwono='" & Trim(txtWONo.Text) & "' order by StntSerial"
                'End If

                If CoatType = 3 Then
                    Sql = "select StntSerial as 'Stent Serial', cast(PreWt as numeric(10,3)) as 'Pre Weight', cast(PostWt as numeric(10,3)) as 'Post Weight', cast(((PostWt - PreWt) * 1000) as integer) as 'Net Coating Wt',  cast(round((case ((PostWt - PreWt) * 1000) when 0 then 0 else ((((PostWt - PreWt) * 1000) / " & txtNomTotalWeight.Text & ") -1 ) * 100 end), 2) as numeric(10,2)) as 'Diff From Nom Wt', InspnCode as 'Inspection Code', cast(Ampc as integer) as 'AMPC No', cast(VialNo as integer) as 'Syringe No', StentBatch as 'Parylene Stent Batch No' from VwElectronicForm where stwono='" & Trim(txtWONo.Text) & "' order by StntSerial"
                ElseIf CoatType = 2 Then
                    Sql = "select StntSerial as 'Stent Serial', cast(PreWt as numeric(10,3)) as 'Pre Weight', cast(FifteenWt as numeric(10,3)) as '15 Mins Weight', cast((FifteenWt - PreWt) * 1000 as integer) as 'Net Coating Wt', case category when -1 then uvdose else (((FifteenWt - PreWt) * 1000) * " & DummyAverageDose & ") end as 'UV Dose 15 Mins', cast(round((case ((FifteenWt - PreWt) * 1000) when 0 then 0 else ((((FifteenWt - PreWt) * 1000) / " & txtNomDoseSpec.Text & ") -1 ) * 100 end), 2) as numeric(10,2)) as 'Diff From Nom Wt', cast(round((case (FifteenWt - PreWt) * 1000 when 0 then 0 else UVDose / ((FifteenWt - PreWt) * 1000) end), 2) as numeric(10,2)) as DrugRatio, InspnCode as 'Inspection Code', cast(VialNo as integer) as 'Syringe No' from VwElectronicForm where stwono='" & Trim(txtWONo.Text) & "' order by StntSerial"
                End If

                ds = db.selectQuery(Sql)

                dt = ds.Tables(0)
                dgAMPCData.DataSource = dt

                FormatGrid()

            Else
                ds.Clear()
                dgAMPCData.DataSource = ds
            End If
        Else
            ds.Clear()
            dgAMPCData.DataSource = ds
        End If

    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgAMPCData.Columns.Count - 1
            dgAMPCData.Columns(i).ReadOnly = True
            dgAMPCData.Columns(i).Width = 125
        Next
    End Sub

    Private Sub FillInProcessSpecs()

        If txtTargetAboveNominal.Text <> "" Then
            AboveNominalTarget = txtTargetAboveNominal.Text
        Else
            txtTargetAboveNominal.Text = AboveNominalTarget
        End If

        lblTargetDryWt.Text = Math.Round(NomTotalWt * (1 + (AboveNominalTarget / 100)), 0)
        lblTargetDose.Text = Math.Round(NomDoseSpec * (1 + (AboveNominalTarget / 100)), 0)

        lblUSLAboveNominal.Text = AboveNominalUSL
        lblUSLDryWt.Text = Math.Round(NomTotalWt * (1 + (AboveNominalUSL / 100)), 0)
        lblUSLDose.Text = Math.Round(NomDoseSpec * (1 + (AboveNominalUSL / 100)), 0)

        lblLSLAboveNominal.Text = AboveNominalLSL
        lblLSLDryWt.Text = Math.Round(NomTotalWt * (1 + (AboveNominalLSL / 100)), 0)
        lblLSLDose.Text = Math.Round(NomDoseSpec * (1 + (AboveNominalLSL / 100)), 0)

    End Sub

    Private Sub FillPostProcessStatistics()

        If NomTotalWt = 0 Then
            lblAboveTarget.Text = 0
            lblBelowTarget.Text = 0
        Else
            ' To get No of Above Targets
            If CoatType = 3 Then
                Sql = "select count(stntserial) as 'TotalAboveTarget' from VwElectronicForm where stwono='" & Trim(txtWONo.Text) & "' and ((((PostWt - PreWt) * 1000) / " & NomTotalWt & ") -1 ) * 100 > " & AboveNominalTarget & " and ((PostWt - PreWt) * 1000) <> 0"
            ElseIf CoatType = 2 Then
                Sql = "select count(stntserial) as 'TotalAboveTarget' from VwElectronicForm where stwono='" & Trim(txtWONo.Text) & "' and ((((FifteenWt - PreWt) * 1000) / " & NomTotalWt & ") -1 ) * 100 > " & AboveNominalTarget & " and ((FifteenWt - PreWt) * 1000) <> 0"
            End If
            ds = db.selectQuery(Sql)
            lblAboveTarget.Text = ds.Tables(0).Rows(0).Item("TotalAboveTarget")

            ' To get No of Below Targets
            If CoatType = 3 Then
                Sql = "select count(stntserial) as 'TotalBelowTarget' from VwElectronicForm where stwono='" & Trim(txtWONo.Text) & "' and ((((PostWt - PreWt) * 1000) / " & NomTotalWt & ") -1 ) * 100 < " & AboveNominalTarget & " and ((PostWt - PreWt) * 1000) <> 0"
            ElseIf CoatType = 2 Then
                Sql = "select count(stntserial) as 'TotalBelowTarget' from VwElectronicForm where stwono='" & Trim(txtWONo.Text) & "' and ((((FifteenWt - PreWt) * 1000) / " & NomTotalWt & ") -1 ) * 100 < " & AboveNominalTarget & " and ((FifteenWt - PreWt) * 1000) <> 0"
            End If
            ds = db.selectQuery(Sql)
            lblBelowTarget.Text = ds.Tables(0).Rows(0).Item("TotalBelowTarget")
            End If

            If CoatType = 3 Then
                lblHighestWeight.Text = stWODetails.nMaximumPostWt
                lblLowestWeight.Text = stWODetails.nMinimumPostWt
                lblTotalStentsWeighed.Text = stWODetails.nTotalStentsWeighedPostWt

                If stWODetails.nTotalStentsWeighedPostWt = 0 Then
                    lblYield.Text = 0
                Else
                    lblYield.Text = Math.Round(((stWODetails.nTotalGood / stWODetails.nTotalStentsWeighedPostWt) * 100), 2)
                End If

                lblMedianCoatingWeight.Text = stWODetails.nMedianCoatingPostWt
                lblRelativeStdDeviation.Text = stWODetails.nRelativeStdDeviationPostWt

            ElseIf CoatType = 2 Then
                lblHighestWeight.Text = stWODetails.nMaximumFifteenWt
                lblLowestWeight.Text = stWODetails.nMinimumFifteenWt
                lblTotalStentsWeighed.Text = stWODetails.nTotalStentsWeighedFifteenWt

                If stWODetails.nTotalStentsWeighedFifteenWt = 0 Then
                    lblYield.Text = 0
                Else
                    lblYield.Text = Math.Round(((stWODetails.nTotalGood / stWODetails.nTotalStentsWeighedFifteenWt) * 100), 2)
            End If

                lblMedianCoatingWeight.Text = stWODetails.nMedianCoatingFifteenWt
                lblRelativeStdDeviation.Text = stWODetails.nRelativeStdDeviationFifteenWt

            End If

            lblAccepted.Text = stWODetails.nTotalGood
            lblRejected.Text = stWODetails.nTotalBad

    End Sub

    Private Sub UpdateData(ByVal sAction As String)
        Dim sql As String

        If Trim(txtWONo.Text) = "" Then
            MsgBox("Enter Work Order")
            txtWONo.Focus()

        ElseIf Trim(txtFormulationConc.Text) = "" Then
            MsgBox("Enter Formulation Concentration")
            txtFormulationConc.Focus()

        ElseIf Trim(txtFormulationDrugRatio.Text) = "" Then
            MsgBox("Enter Formulation Drug Ratio")
            txtFormulationDrugRatio.Focus()

        ElseIf Not IsNumeric(Trim(txtFormulationConc.Text)) Then
            MsgBox("Invalid Formulation Concentration")
            txtFormulationConc.Text = ""
            txtFormulationConc.Focus()

        ElseIf Not IsNumeric(Trim(txtFormulationDrugRatio.Text)) Then
            MsgBox("Invalid Formulation Drug Ratio")
            txtFormulationDrugRatio.Text = ""
            txtFormulationDrugRatio.Focus()

        ElseIf Trim(txtFormulationConc.Text) = 0 Then
            MsgBox("Invalid Formulation Concentration")
            txtFormulationConc.Text = ""
            txtFormulationConc.Focus()

        ElseIf Trim(txtFormulationDrugRatio.Text) = 0 Then
            MsgBox("Invalid Formulation Drug Ratio")
            txtFormulationDrugRatio.Text = ""
            txtFormulationDrugRatio.Focus()

        ElseIf Trim(txtTargetAboveNominal.Text) = "" Then
            MsgBox("Enter Above Nominal Percentage")
            txtTargetAboveNominal.Text = ""
            txtTargetAboveNominal.Focus()

        ElseIf Not IsNumeric(Trim(txtTargetAboveNominal.Text)) Then
            MsgBox("Invalid Above Nominal Percentage")
            txtTargetAboveNominal.Text = ""
            txtTargetAboveNominal.Focus()

        ElseIf Trim(txtTargetAboveNominal.Text) = 0 Then
            MsgBox("Invalid Above Nominal Percentage")
            txtTargetAboveNominal.Text = ""
            txtTargetAboveNominal.Focus()

        Else

            bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtWONo.Text))

            If bWorkOrderFound = True Then

                sql = "select count(shoporderid) as TotalCount from ampcdata where shoporderid = '" & stWODetails.sBatchNo & "'"
                ds = db.selectQuery(sql)

                If ds.Tables(0).Rows(0).Item("TotalCount") > 0 Then

                    ReCalculateAllValues()

                    If sAction = "Confirm" Then

                        sql = "update ElectronicSheetH set FormnConc = " & FormnConc & ", FormnDrugRatio = " & FormnDrugRatio & ", NomDoseSpec = " & NomDoseSpec & ", NomPLAWt = " & NomPLAWt & ", NomTotalWt = " & NomTotalWt & ", AboveNominalTarget = " & txtTargetAboveNominal.Text & ", TargetDocNo='" & txtTargetDocNo.Text & "', DryWtTarget = " & lblTargetDryWt.Text & ", DryWtUSL = " & lblUSLDryWt.Text & ", DryWtLSL = " & lblLSLDryWt.Text & ", DoseTarget = " & lblTargetDose.Text & ", DoseUSL = " & lblUSLDose.Text & ", DoseLSL = " & lblLSLDose.Text & ", AboveTargetNos = " & lblAboveTarget.Text & ", BelowTargetNos = " & lblBelowTarget.Text & ", HighestWt = " & lblHighestWeight.Text & ", LowestWt = " & lblLowestWeight.Text & ", AcceptedNos = " & lblAccepted.Text & ", RejectedNos = " & lblRejected.Text & ", TotalStentsWeighed = " & lblTotalStentsWeighed.Text & ", Yield = " & lblYield.Text & ", MedianCoatingWt = " & lblMedianCoatingWeight.Text & ", RelStdDeviation = " & lblRelativeStdDeviation.Text & ", Status = 'C', ApprovedBy = '" & sLogonUser & "', ApprovedOn = getdate() where CoatType = " & CoatType & " and wono = '" & Trim(txtWONo.Text) & "'"
                        db.updateQuery(sql)
                        CheckAndFillDetailsFromTable()
                        txtFormulationConc.ReadOnly = True
                        txtFormulationDrugRatio.ReadOnly = True
                        txtTargetAboveNominal.ReadOnly = True
                        txtTargetDocNo.ReadOnly = True
                        btnSave.Enabled = False
                        btnConfirm.Enabled = False

                    ElseIf sAction = "Save" Then

                        If txtWONo.ReadOnly = True Then
                            sql = "update ElectronicSheetH set FormnConc = " & FormnConc & ", FormnDrugRatio = " & FormnDrugRatio & ", NomDoseSpec = " & NomDoseSpec & ", NomPLAWt = " & NomPLAWt & ", NomTotalWt = " & NomTotalWt & ", AboveNominalTarget = " & txtTargetAboveNominal.Text & ", TargetDocNo='" & txtTargetDocNo.Text & "', DryWtTarget = " & lblTargetDryWt.Text & ", DryWtUSL = " & lblUSLDryWt.Text & ", DryWtLSL = " & lblLSLDryWt.Text & ", DoseTarget = " & lblTargetDose.Text & ", DoseUSL = " & lblUSLDose.Text & ", DoseLSL = " & lblLSLDose.Text & ", AboveTargetNos = " & lblAboveTarget.Text & ", BelowTargetNos = " & lblBelowTarget.Text & ", HighestWt = " & lblHighestWeight.Text & ", LowestWt = " & lblLowestWeight.Text & ", AcceptedNos = " & lblAccepted.Text & ", RejectedNos = " & lblRejected.Text & ", TotalStentsWeighed = " & lblTotalStentsWeighed.Text & ", Yield = " & lblYield.Text & ", MedianCoatingWt = " & lblMedianCoatingWeight.Text & ", RelStdDeviation = " & lblRelativeStdDeviation.Text & " where CoatType = " & CoatType & " and wono = '" & Trim(txtWONo.Text) & "'"
                            db.updateQuery(sql)
                            CheckAndFillDetailsFromTable()

                        Else
                            sql = "insert into ElectronicSheetH(WONo,CoatType,AMPCNos,StentLen,FormnLotNo,FormnConc,DummyAverageDose,FormnDrugRatio,NomDoseSpec,NomPLAWt,NomTotalWt,AboveNominalTarget,TargetDocNo,DryWtTarget,DryWtUSL,DryWtLSL,DoseTarget,DoseUSL,DoseLSL,AboveTargetNos,BelowTargetNos,HighestWt,LowestWt,AcceptedNos,RejectedNos,TotalStentsWeighed,Yield,MedianCoatingWt,RelStdDeviation,CreatedBy,CreatedOn) values('" & Trim(txtWONo.Text) & "', '" & CoatType & "', '" & Trim(txtAMPCNos.Text) & "'," & Trim(txtStentLength.Text) & ", '" & Trim(txtFormulationLotNo.Text) & "', " & FormnConc & "," & DummyAverageDose & "," & FormnDrugRatio & ", " & NomDoseSpec & ", " & NomPLAWt & ", " & NomTotalWt & ", " & txtTargetAboveNominal.Text & ", '" & txtTargetDocNo.Text & "', " & lblTargetDryWt.Text & ", " & lblUSLDryWt.Text & ", " & lblLSLDryWt.Text & ", " & lblTargetDose.Text & ", " & lblUSLDose.Text & ", " & lblLSLDose.Text & ", " & lblAboveTarget.Text & ", " & lblBelowTarget.Text & ", " & lblHighestWeight.Text & ", " & lblLowestWeight.Text & ", " & lblAccepted.Text & ", " & lblRejected.Text & ", " & lblTotalStentsWeighed.Text & ", " & lblYield.Text & ", " & lblMedianCoatingWeight.Text & ", " & lblRelativeStdDeviation.Text & ", '" & sLogonUser & "', getdate())"
                            If Not db.insertQuery(sql) Then
                                MsgBox("Work Order already exists")
                                ClearControls()
                                ds.Clear()
                                FillGrid()
                            Else
                                CheckAndFillDetailsFromTable()
                            End If
                        End If
                    End If
                Else
                    MsgBox("AMPC Coating Data not available for this Work Order")
                    ClearControls()
                    txtWONo.Focus()
                End If
            Else
                MsgBox("Invalid Work Order")
                ClearControls()
                ds.Clear()
                FillGrid()
                txtWONo.Focus()
            End If
        End If
    End Sub

    Private Sub ReCalculateAllValues()
        FillGeneralHeaderDetails()
        FillNomDetails()
        FillGrid()
        FillInProcessSpecs()
        FillPostProcessStatistics()
    End Sub

    Public Sub ClearControls()
        txtWONo.Clear()
        txtItem.Clear()
        txtBatchNo.Clear()
        txtTotalStents.Clear()
        txtAMPCNos.Clear()
        txtProductDesc.Clear()
        txtStentLength.Clear()
        txtFormulationLotNo.Clear()
        txtFormulationConc.Clear()
        txtFormulationDrugRatio.Clear()
        txtNomDoseSpec.Clear()
        txtNomPLAWeight.Clear()
        txtNomTotalWeight.Clear()

        txtTargetAboveNominal.Text = ""
        lblTargetDryWt.Text = ""
        lblTargetDose.Text = ""
        txtTargetDocNo.Text = ""
        lblUSLAboveNominal.Text = ""
        lblUSLDryWt.Text = ""
        lblUSLDose.Text = ""
        lblLSLAboveNominal.Text = ""
        lblLSLDryWt.Text = ""
        lblLSLDose.Text = ""

        lblAboveTarget.Text = ""
        lblBelowTarget.Text = ""
        lblHighestWeight.Text = ""
        lblLowestWeight.Text = ""
        lblAccepted.Text = ""
        lblRejected.Text = ""
        lblTotalStentsWeighed.Text = ""
        lblYield.Text = ""
        lblMedianCoatingWeight.Text = ""
        lblRelativeStdDeviation.Text = ""

        txtWONo.Focus()

    End Sub

End Class