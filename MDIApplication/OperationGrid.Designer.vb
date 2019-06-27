<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OperationGrid
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
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dgaccpt = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.dgrej = New System.Windows.Forms.DataGrid
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.dgBIT = New System.Windows.Forms.DataGrid
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.dgBESA = New System.Windows.Forms.DataGrid
        Me.lblProgress = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblUserName = New System.Windows.Forms.Label
        Me.tbOperationGrid = New System.Windows.Forms.TabControl
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.dgAccepted = New System.Windows.Forms.DataGridView
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.dgRejected = New System.Windows.Forms.DataGridView
        Me.btnDetails = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtEnter = New System.Windows.Forms.TextBox
        Me.TabPage1.SuspendLayout()
        CType(Me.dgaccpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgrej, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgBIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgBESA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbOperationGrid.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.dgAccepted, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        CType(Me.dgRejected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.PaleGreen
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.dgaccpt)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.Green
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(664, 283)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Accepted"
        '
        'dgaccpt
        '
        Me.dgaccpt.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgaccpt.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgaccpt.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgaccpt.CaptionForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgaccpt.CaptionText = "Accepted  "
        Me.dgaccpt.DataMember = ""
        Me.dgaccpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgaccpt.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgaccpt.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgaccpt.Location = New System.Drawing.Point(8, 8)
        Me.dgaccpt.Name = "dgaccpt"
        Me.dgaccpt.PreferredColumnWidth = 216
        Me.dgaccpt.ReadOnly = True
        Me.dgaccpt.Size = New System.Drawing.Size(648, 262)
        Me.dgaccpt.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Coral
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.dgrej)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.ForeColor = System.Drawing.Color.Snow
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(664, 283)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rejected"
        '
        'dgrej
        '
        Me.dgrej.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgrej.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgrej.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrej.CaptionForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgrej.CaptionText = "Rejected  "
        Me.dgrej.DataMember = ""
        Me.dgrej.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrej.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrej.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgrej.Location = New System.Drawing.Point(8, 8)
        Me.dgrej.Name = "dgrej"
        Me.dgrej.PreferredColumnWidth = 129
        Me.dgrej.ReadOnly = True
        Me.dgrej.Size = New System.Drawing.Size(648, 262)
        Me.dgrej.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.PaleGreen
        Me.TabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage5.Controls.Add(Me.DataGrid1)
        Me.TabPage5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage5.ForeColor = System.Drawing.Color.Green
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(664, 283)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Accepted"
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGrid1.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.CaptionForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGrid1.CaptionText = "Accepted  "
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 216
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(648, 262)
        Me.DataGrid1.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.Coral
        Me.TabPage6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage6.Controls.Add(Me.DataGrid2)
        Me.TabPage6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage6.ForeColor = System.Drawing.Color.Snow
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(664, 283)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Rejected"
        '
        'DataGrid2
        '
        Me.DataGrid2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGrid2.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGrid2.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid2.CaptionForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGrid2.CaptionText = "Rejected  "
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid2.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.PreferredColumnWidth = 129
        Me.DataGrid2.ReadOnly = True
        Me.DataGrid2.Size = New System.Drawing.Size(648, 262)
        Me.DataGrid2.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.PaleGreen
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage3.Controls.Add(Me.dgBIT)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.ForeColor = System.Drawing.Color.Green
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(670, 283)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "BIT"
        '
        'dgBIT
        '
        Me.dgBIT.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgBIT.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgBIT.CaptionForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgBIT.CaptionText = "BIT"
        Me.dgBIT.DataMember = ""
        Me.dgBIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.dgBIT.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dgBIT.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgBIT.Location = New System.Drawing.Point(9, 9)
        Me.dgBIT.Name = "dgBIT"
        Me.dgBIT.PreferredColumnWidth = 90
        Me.dgBIT.ReadOnly = True
        Me.dgBIT.Size = New System.Drawing.Size(649, 261)
        Me.dgBIT.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Coral
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage4.Controls.Add(Me.dgBESA)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.ForeColor = System.Drawing.Color.Snow
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(670, 283)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "BESA"
        '
        'dgBESA
        '
        Me.dgBESA.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgBESA.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgBESA.CaptionForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgBESA.CaptionText = "BESA"
        Me.dgBESA.DataMember = ""
        Me.dgBESA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.dgBESA.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dgBESA.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgBESA.Location = New System.Drawing.Point(8, 8)
        Me.dgBESA.Name = "dgBESA"
        Me.dgBESA.PreferredColumnWidth = 90
        Me.dgBESA.ReadOnly = True
        Me.dgBESA.Size = New System.Drawing.Size(648, 263)
        Me.dgBESA.TabIndex = 1
        '
        'lblProgress
        '
        Me.lblProgress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblProgress.ForeColor = System.Drawing.Color.Red
        Me.lblProgress.Location = New System.Drawing.Point(179, 387)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(234, 17)
        Me.lblProgress.TabIndex = 77
        Me.lblProgress.Text = "Retrieving Data in Progress....."
        Me.lblProgress.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Location = New System.Drawing.Point(454, 384)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(125, 25)
        Me.btnClose.TabIndex = 78
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblUserName
        '
        Me.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblUserName.Location = New System.Drawing.Point(35, 25)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(111, 16)
        Me.lblUserName.TabIndex = 85
        Me.lblUserName.Text = "Work Order No"
        '
        'tbOperationGrid
        '
        Me.tbOperationGrid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbOperationGrid.Controls.Add(Me.TabPage7)
        Me.tbOperationGrid.Controls.Add(Me.TabPage8)
        Me.tbOperationGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOperationGrid.Location = New System.Drawing.Point(22, 63)
        Me.tbOperationGrid.Name = "tbOperationGrid"
        Me.tbOperationGrid.SelectedIndex = 0
        Me.tbOperationGrid.Size = New System.Drawing.Size(977, 307)
        Me.tbOperationGrid.TabIndex = 84
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.PaleGreen
        Me.TabPage7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage7.Controls.Add(Me.dgAccepted)
        Me.TabPage7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage7.ForeColor = System.Drawing.Color.Black
        Me.TabPage7.ImageIndex = CType(configurationAppSettings.GetValue("TabPage1.ImageIndex", GetType(Integer)), Integer)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(969, 278)
        Me.TabPage7.TabIndex = 0
        Me.TabPage7.Text = "Accepted"
        '
        'dgAccepted
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.dgAccepted.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgAccepted.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgAccepted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgAccepted.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgAccepted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAccepted.Location = New System.Drawing.Point(7, 8)
        Me.dgAccepted.Name = "dgAccepted"
        Me.dgAccepted.Size = New System.Drawing.Size(953, 260)
        Me.dgAccepted.TabIndex = 139
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.Coral
        Me.TabPage8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage8.Controls.Add(Me.dgRejected)
        Me.TabPage8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage8.ForeColor = System.Drawing.Color.Black
        Me.TabPage8.Location = New System.Drawing.Point(4, 25)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(969, 278)
        Me.TabPage8.TabIndex = 1
        Me.TabPage8.Text = "Rejected"
        '
        'dgRejected
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan
        Me.dgRejected.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgRejected.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgRejected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRejected.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgRejected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRejected.Location = New System.Drawing.Point(7, 8)
        Me.dgRejected.Name = "dgRejected"
        Me.dgRejected.Size = New System.Drawing.Size(953, 260)
        Me.dgRejected.TabIndex = 140
        '
        'btnDetails
        '
        Me.btnDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetails.Location = New System.Drawing.Point(874, 21)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(125, 25)
        Me.btnDetails.TabIndex = 83
        Me.btnDetails.Text = "Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(342, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(125, 25)
        Me.btnSearch.TabIndex = 82
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtEnter
        '
        Me.txtEnter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnter.Location = New System.Drawing.Point(150, 22)
        Me.txtEnter.MaxLength = 12
        Me.txtEnter.Name = "txtEnter"
        Me.txtEnter.Size = New System.Drawing.Size(179, 22)
        Me.txtEnter.TabIndex = 81
        '
        'OperationGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1018, 423)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.tbOperationGrid)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtEnter)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblProgress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "OperationGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary By Work Order No"
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgaccpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgrej, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgBIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgBESA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbOperationGrid.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        CType(Me.dgAccepted, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        CType(Me.dgRejected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgaccpt As System.Windows.Forms.DataGrid
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgrej As System.Windows.Forms.DataGrid
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgBIT As System.Windows.Forms.DataGrid
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dgBESA As System.Windows.Forms.DataGrid
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents tbOperationGrid As System.Windows.Forms.TabControl
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents btnDetails As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtEnter As System.Windows.Forms.TextBox
    Friend WithEvents dgAccepted As System.Windows.Forms.DataGridView
    Friend WithEvents dgRejected As System.Windows.Forms.DataGridView
End Class
