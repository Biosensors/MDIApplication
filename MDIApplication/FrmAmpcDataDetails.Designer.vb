<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAmpcDataDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAmpcDataDetails))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtNomTotalWeight = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtNomPLAWeight = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtNomDoseSpec = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFormulationLotNo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtFormulationDrugRatio = New System.Windows.Forms.TextBox
        Me.txtStentLength = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFormulationConc = New System.Windows.Forms.TextBox
        Me.txtProductDesc = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtAMPCNos = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTotalStents = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBatchNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtWONo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.dgAMPCData = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtTargetDocNo = New System.Windows.Forms.TextBox
        Me.txtTargetAboveNominal = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.lblLSLDose = New System.Windows.Forms.Label
        Me.lblUSLDose = New System.Windows.Forms.Label
        Me.lblTargetDose = New System.Windows.Forms.Label
        Me.lblLSLDryWt = New System.Windows.Forms.Label
        Me.lblUSLDryWt = New System.Windows.Forms.Label
        Me.lblTargetDryWt = New System.Windows.Forms.Label
        Me.lblLSLAboveNominal = New System.Windows.Forms.Label
        Me.lblUSLAboveNominal = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.lblRelativeStdDeviation = New System.Windows.Forms.Label
        Me.lblMedianCoatingWeight = New System.Windows.Forms.Label
        Me.lblYield = New System.Windows.Forms.Label
        Me.lblTotalStentsWeighed = New System.Windows.Forms.Label
        Me.lblRejected = New System.Windows.Forms.Label
        Me.lblAccepted = New System.Windows.Forms.Label
        Me.lblLowestWeight = New System.Windows.Forms.Label
        Me.lblHighestWeight = New System.Windows.Forms.Label
        Me.lblBelowTarget = New System.Windows.Forms.Label
        Me.lblAboveTarget = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgAMPCData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Tag = "I"
        '
        'btnClose
        '
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.Name = "btnClose"
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Controls.Add(Me.txtNomTotalWeight)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtNomPLAWeight)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtNomDoseSpec)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtFormulationLotNo)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtFormulationDrugRatio)
        Me.GroupBox2.Controls.Add(Me.txtStentLength)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtFormulationConc)
        Me.GroupBox2.Controls.Add(Me.txtProductDesc)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtAMPCNos)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtTotalStents)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtBatchNo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtItem)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtWONo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'txtNomTotalWeight
        '
        resources.ApplyResources(Me.txtNomTotalWeight, "txtNomTotalWeight")
        Me.txtNomTotalWeight.Name = "txtNomTotalWeight"
        Me.txtNomTotalWeight.ReadOnly = True
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'txtNomPLAWeight
        '
        resources.ApplyResources(Me.txtNomPLAWeight, "txtNomPLAWeight")
        Me.txtNomPLAWeight.Name = "txtNomPLAWeight"
        Me.txtNomPLAWeight.ReadOnly = True
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'txtNomDoseSpec
        '
        resources.ApplyResources(Me.txtNomDoseSpec, "txtNomDoseSpec")
        Me.txtNomDoseSpec.Name = "txtNomDoseSpec"
        Me.txtNomDoseSpec.ReadOnly = True
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtFormulationLotNo
        '
        resources.ApplyResources(Me.txtFormulationLotNo, "txtFormulationLotNo")
        Me.txtFormulationLotNo.Name = "txtFormulationLotNo"
        Me.txtFormulationLotNo.ReadOnly = True
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'txtFormulationDrugRatio
        '
        resources.ApplyResources(Me.txtFormulationDrugRatio, "txtFormulationDrugRatio")
        Me.txtFormulationDrugRatio.Name = "txtFormulationDrugRatio"
        '
        'txtStentLength
        '
        resources.ApplyResources(Me.txtStentLength, "txtStentLength")
        Me.txtStentLength.Name = "txtStentLength"
        Me.txtStentLength.ReadOnly = True
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'txtFormulationConc
        '
        resources.ApplyResources(Me.txtFormulationConc, "txtFormulationConc")
        Me.txtFormulationConc.Name = "txtFormulationConc"
        '
        'txtProductDesc
        '
        resources.ApplyResources(Me.txtProductDesc, "txtProductDesc")
        Me.txtProductDesc.Name = "txtProductDesc"
        Me.txtProductDesc.ReadOnly = True
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'txtAMPCNos
        '
        resources.ApplyResources(Me.txtAMPCNos, "txtAMPCNos")
        Me.txtAMPCNos.Name = "txtAMPCNos"
        Me.txtAMPCNos.ReadOnly = True
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'txtTotalStents
        '
        resources.ApplyResources(Me.txtTotalStents, "txtTotalStents")
        Me.txtTotalStents.Name = "txtTotalStents"
        Me.txtTotalStents.ReadOnly = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txtBatchNo
        '
        resources.ApplyResources(Me.txtBatchNo, "txtBatchNo")
        Me.txtBatchNo.Name = "txtBatchNo"
        Me.txtBatchNo.ReadOnly = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtItem
        '
        resources.ApplyResources(Me.txtItem, "txtItem")
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtWONo
        '
        resources.ApplyResources(Me.txtWONo, "txtWONo")
        Me.txtWONo.Name = "txtWONo"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'btnConfirm
        '
        resources.ApplyResources(Me.btnConfirm, "btnConfirm")
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Tag = "I"
        '
        'dgAMPCData
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan
        Me.dgAMPCData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        resources.ApplyResources(Me.dgAMPCData, "dgAMPCData")
        Me.dgAMPCData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgAMPCData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgAMPCData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAMPCData.Name = "dgAMPCData"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.txtTargetDocNo)
        Me.GroupBox1.Controls.Add(Me.txtTargetAboveNominal)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.lblLSLDose)
        Me.GroupBox1.Controls.Add(Me.lblUSLDose)
        Me.GroupBox1.Controls.Add(Me.lblTargetDose)
        Me.GroupBox1.Controls.Add(Me.lblLSLDryWt)
        Me.GroupBox1.Controls.Add(Me.lblUSLDryWt)
        Me.GroupBox1.Controls.Add(Me.lblTargetDryWt)
        Me.GroupBox1.Controls.Add(Me.lblLSLAboveNominal)
        Me.GroupBox1.Controls.Add(Me.lblUSLAboveNominal)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label35
        '
        resources.ApplyResources(Me.Label35, "Label35")
        Me.Label35.Name = "Label35"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label27)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'Label25
        '
        resources.ApplyResources(Me.Label25, "Label25")
        Me.Label25.Name = "Label25"
        '
        'Label24
        '
        resources.ApplyResources(Me.Label24, "Label24")
        Me.Label24.Name = "Label24"
        '
        'Label26
        '
        resources.ApplyResources(Me.Label26, "Label26")
        Me.Label26.Name = "Label26"
        '
        'Label27
        '
        resources.ApplyResources(Me.Label27, "Label27")
        Me.Label27.Name = "Label27"
        '
        'txtTargetDocNo
        '
        resources.ApplyResources(Me.txtTargetDocNo, "txtTargetDocNo")
        Me.txtTargetDocNo.Name = "txtTargetDocNo"
        '
        'txtTargetAboveNominal
        '
        resources.ApplyResources(Me.txtTargetAboveNominal, "txtTargetAboveNominal")
        Me.txtTargetAboveNominal.Name = "txtTargetAboveNominal"
        '
        'Label34
        '
        resources.ApplyResources(Me.Label34, "Label34")
        Me.Label34.Name = "Label34"
        '
        'Label33
        '
        resources.ApplyResources(Me.Label33, "Label33")
        Me.Label33.Name = "Label33"
        '
        'Label32
        '
        resources.ApplyResources(Me.Label32, "Label32")
        Me.Label32.Name = "Label32"
        '
        'lblLSLDose
        '
        resources.ApplyResources(Me.lblLSLDose, "lblLSLDose")
        Me.lblLSLDose.Name = "lblLSLDose"
        '
        'lblUSLDose
        '
        resources.ApplyResources(Me.lblUSLDose, "lblUSLDose")
        Me.lblUSLDose.Name = "lblUSLDose"
        '
        'lblTargetDose
        '
        resources.ApplyResources(Me.lblTargetDose, "lblTargetDose")
        Me.lblTargetDose.Name = "lblTargetDose"
        '
        'lblLSLDryWt
        '
        resources.ApplyResources(Me.lblLSLDryWt, "lblLSLDryWt")
        Me.lblLSLDryWt.Name = "lblLSLDryWt"
        '
        'lblUSLDryWt
        '
        resources.ApplyResources(Me.lblUSLDryWt, "lblUSLDryWt")
        Me.lblUSLDryWt.Name = "lblUSLDryWt"
        '
        'lblTargetDryWt
        '
        resources.ApplyResources(Me.lblTargetDryWt, "lblTargetDryWt")
        Me.lblTargetDryWt.Name = "lblTargetDryWt"
        '
        'lblLSLAboveNominal
        '
        resources.ApplyResources(Me.lblLSLAboveNominal, "lblLSLAboveNominal")
        Me.lblLSLAboveNominal.Name = "lblLSLAboveNominal"
        '
        'lblUSLAboveNominal
        '
        resources.ApplyResources(Me.lblUSLAboveNominal, "lblUSLAboveNominal")
        Me.lblUSLAboveNominal.Name = "lblUSLAboveNominal"
        '
        'Label30
        '
        resources.ApplyResources(Me.Label30, "Label30")
        Me.Label30.Name = "Label30"
        '
        'Label29
        '
        resources.ApplyResources(Me.Label29, "Label29")
        Me.Label29.Name = "Label29"
        '
        'Label28
        '
        resources.ApplyResources(Me.Label28, "Label28")
        Me.Label28.Name = "Label28"
        '
        'GroupBox3
        '
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.lblRelativeStdDeviation)
        Me.GroupBox3.Controls.Add(Me.lblMedianCoatingWeight)
        Me.GroupBox3.Controls.Add(Me.lblYield)
        Me.GroupBox3.Controls.Add(Me.lblTotalStentsWeighed)
        Me.GroupBox3.Controls.Add(Me.lblRejected)
        Me.GroupBox3.Controls.Add(Me.lblAccepted)
        Me.GroupBox3.Controls.Add(Me.lblLowestWeight)
        Me.GroupBox3.Controls.Add(Me.lblHighestWeight)
        Me.GroupBox3.Controls.Add(Me.lblBelowTarget)
        Me.GroupBox3.Controls.Add(Me.lblAboveTarget)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'Label31
        '
        resources.ApplyResources(Me.Label31, "Label31")
        Me.Label31.Name = "Label31"
        '
        'lblRelativeStdDeviation
        '
        resources.ApplyResources(Me.lblRelativeStdDeviation, "lblRelativeStdDeviation")
        Me.lblRelativeStdDeviation.Name = "lblRelativeStdDeviation"
        '
        'lblMedianCoatingWeight
        '
        resources.ApplyResources(Me.lblMedianCoatingWeight, "lblMedianCoatingWeight")
        Me.lblMedianCoatingWeight.Name = "lblMedianCoatingWeight"
        '
        'lblYield
        '
        resources.ApplyResources(Me.lblYield, "lblYield")
        Me.lblYield.Name = "lblYield"
        '
        'lblTotalStentsWeighed
        '
        resources.ApplyResources(Me.lblTotalStentsWeighed, "lblTotalStentsWeighed")
        Me.lblTotalStentsWeighed.Name = "lblTotalStentsWeighed"
        '
        'lblRejected
        '
        resources.ApplyResources(Me.lblRejected, "lblRejected")
        Me.lblRejected.Name = "lblRejected"
        '
        'lblAccepted
        '
        resources.ApplyResources(Me.lblAccepted, "lblAccepted")
        Me.lblAccepted.Name = "lblAccepted"
        '
        'lblLowestWeight
        '
        resources.ApplyResources(Me.lblLowestWeight, "lblLowestWeight")
        Me.lblLowestWeight.Name = "lblLowestWeight"
        '
        'lblHighestWeight
        '
        resources.ApplyResources(Me.lblHighestWeight, "lblHighestWeight")
        Me.lblHighestWeight.Name = "lblHighestWeight"
        '
        'lblBelowTarget
        '
        resources.ApplyResources(Me.lblBelowTarget, "lblBelowTarget")
        Me.lblBelowTarget.Name = "lblBelowTarget"
        '
        'lblAboveTarget
        '
        resources.ApplyResources(Me.lblAboveTarget, "lblAboveTarget")
        Me.lblAboveTarget.Name = "lblAboveTarget"
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.Name = "Label20"
        '
        'Label21
        '
        resources.ApplyResources(Me.Label21, "Label21")
        Me.Label21.Name = "Label21"
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.Name = "Label22"
        '
        'Label23
        '
        resources.ApplyResources(Me.Label23, "Label23")
        Me.Label23.Name = "Label23"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'FrmAmpcDataDetails
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgAMPCData)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmAmpcDataDetails"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgAMPCData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFormulationDrugRatio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFormulationConc As System.Windows.Forms.TextBox
    Friend WithEvents txtWONo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents txtTotalStents As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBatchNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomTotalWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNomPLAWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNomDoseSpec As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFormulationLotNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtStentLength As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtProductDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAMPCNos As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgAMPCData As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblRelativeStdDeviation As System.Windows.Forms.Label
    Friend WithEvents lblMedianCoatingWeight As System.Windows.Forms.Label
    Friend WithEvents lblYield As System.Windows.Forms.Label
    Friend WithEvents lblTotalStentsWeighed As System.Windows.Forms.Label
    Friend WithEvents lblRejected As System.Windows.Forms.Label
    Friend WithEvents lblAccepted As System.Windows.Forms.Label
    Friend WithEvents lblLowestWeight As System.Windows.Forms.Label
    Friend WithEvents lblHighestWeight As System.Windows.Forms.Label
    Friend WithEvents lblBelowTarget As System.Windows.Forms.Label
    Friend WithEvents lblAboveTarget As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblLSLAboveNominal As System.Windows.Forms.Label
    Friend WithEvents lblUSLAboveNominal As System.Windows.Forms.Label
    Friend WithEvents lblLSLDryWt As System.Windows.Forms.Label
    Friend WithEvents lblUSLDryWt As System.Windows.Forms.Label
    Friend WithEvents lblTargetDryWt As System.Windows.Forms.Label
    Friend WithEvents lblLSLDose As System.Windows.Forms.Label
    Friend WithEvents lblUSLDose As System.Windows.Forms.Label
    Friend WithEvents lblTargetDose As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtTargetAboveNominal As System.Windows.Forms.TextBox
    Friend WithEvents txtTargetDocNo As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
