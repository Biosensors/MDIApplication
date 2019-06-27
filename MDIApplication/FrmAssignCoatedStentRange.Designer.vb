<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAssignCoatedStentRange
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnAssign = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtFGWoNo = New System.Windows.Forms.TextBox
        Me.lblItem = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblQty = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblBatch = New System.Windows.Forms.Label
        Me.lblItemDesc = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCoatedStentWO = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkSelectAll = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtAvailableQty = New System.Windows.Forms.TextBox
        Me.lblStentTotalQty = New System.Windows.Forms.Label
        Me.lblStentItem = New System.Windows.Forms.Label
        Me.lblStentBatch = New System.Windows.Forms.Label
        Me.txtInitialSerialNo = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.dgStentSerials = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgStentSerials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAssign
        '
        Me.btnAssign.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAssign.BackColor = System.Drawing.SystemColors.Control
        Me.btnAssign.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAssign.ForeColor = System.Drawing.Color.Black
        Me.btnAssign.Location = New System.Drawing.Point(189, 804)
        Me.btnAssign.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(133, 31)
        Me.btnAssign.TabIndex = 14
        Me.btnAssign.Text = "Assign"
        Me.btnAssign.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(345, 804)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(133, 31)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.txtFGWoNo)
        Me.GroupBox1.Controls.Add(Me.lblItem)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblQty)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblBatch)
        Me.GroupBox1.Controls.Add(Me.lblItemDesc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(28, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(588, 251)
        Me.GroupBox1.TabIndex = 132
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FG Work Order "
        '
        'txtFGWoNo
        '
        Me.txtFGWoNo.Location = New System.Drawing.Point(229, 36)
        Me.txtFGWoNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFGWoNo.MaxLength = 12
        Me.txtFGWoNo.Name = "txtFGWoNo"
        Me.txtFGWoNo.ReadOnly = True
        Me.txtFGWoNo.Size = New System.Drawing.Size(207, 26)
        Me.txtFGWoNo.TabIndex = 1
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Enabled = False
        Me.lblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblItem.Location = New System.Drawing.Point(235, 74)
        Me.lblItem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(0, 20)
        Me.lblItem.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(108, 39)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "FG WO No"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Enabled = False
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblQty.Location = New System.Drawing.Point(236, 174)
        Me.lblQty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(0, 20)
        Me.lblQty.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(113, 172)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Actual Qty"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(168, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Item"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(155, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Batch"
        '
        'lblBatch
        '
        Me.lblBatch.AutoSize = True
        Me.lblBatch.Enabled = False
        Me.lblBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatch.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblBatch.Location = New System.Drawing.Point(236, 139)
        Me.lblBatch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBatch.Name = "lblBatch"
        Me.lblBatch.Size = New System.Drawing.Size(0, 20)
        Me.lblBatch.TabIndex = 4
        '
        'lblItemDesc
        '
        Me.lblItemDesc.AutoSize = True
        Me.lblItemDesc.Enabled = False
        Me.lblItemDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemDesc.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblItemDesc.Location = New System.Drawing.Point(235, 107)
        Me.lblItemDesc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItemDesc.Name = "lblItemDesc"
        Me.lblItemDesc.Size = New System.Drawing.Size(0, 20)
        Me.lblItemDesc.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(115, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Item Desc"
        '
        'txtCoatedStentWO
        '
        Me.txtCoatedStentWO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCoatedStentWO.Location = New System.Drawing.Point(362, 29)
        Me.txtCoatedStentWO.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCoatedStentWO.MaxLength = 12
        Me.txtCoatedStentWO.Name = "txtCoatedStentWO"
        Me.txtCoatedStentWO.ReadOnly = True
        Me.txtCoatedStentWO.Size = New System.Drawing.Size(154, 26)
        Me.txtCoatedStentWO.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(209, 20)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Initial Serial # / Batch #"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(414, 60)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(102, 31)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Refresh"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQuantity.Location = New System.Drawing.Point(227, 62)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.MaxLength = 4
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(72, 26)
        Me.txtQuantity.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(48, 66)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 20)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Qty to be Assigned"
        '
        'chkSelectAll
        '
        Me.chkSelectAll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelectAll.Location = New System.Drawing.Point(475, 455)
        Me.chkSelectAll.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(112, 24)
        Me.chkSelectAll.TabIndex = 12
        Me.chkSelectAll.Text = "Select All"
        Me.chkSelectAll.UseVisualStyleBackColor = True
        Me.chkSelectAll.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.txtAvailableQty)
        Me.GroupBox3.Controls.Add(Me.lblStentTotalQty)
        Me.GroupBox3.Controls.Add(Me.lblStentItem)
        Me.GroupBox3.Controls.Add(Me.lblStentBatch)
        Me.GroupBox3.Controls.Add(Me.txtInitialSerialNo)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtQuantity)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtCoatedStentWO)
        Me.GroupBox3.Controls.Add(Me.btnSearch)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(28, 239)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(588, 207)
        Me.GroupBox3.TabIndex = 136
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Coated Stent Work Order"
        '
        'txtAvailableQty
        '
        Me.txtAvailableQty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAvailableQty.Location = New System.Drawing.Point(307, 62)
        Me.txtAvailableQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAvailableQty.MaxLength = 12
        Me.txtAvailableQty.Name = "txtAvailableQty"
        Me.txtAvailableQty.ReadOnly = True
        Me.txtAvailableQty.Size = New System.Drawing.Size(78, 26)
        Me.txtAvailableQty.TabIndex = 137
        '
        'lblStentTotalQty
        '
        Me.lblStentTotalQty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStentTotalQty.AutoSize = True
        Me.lblStentTotalQty.Enabled = False
        Me.lblStentTotalQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStentTotalQty.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblStentTotalQty.Location = New System.Drawing.Point(234, 173)
        Me.lblStentTotalQty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStentTotalQty.Name = "lblStentTotalQty"
        Me.lblStentTotalQty.Size = New System.Drawing.Size(0, 20)
        Me.lblStentTotalQty.TabIndex = 10
        '
        'lblStentItem
        '
        Me.lblStentItem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStentItem.AutoSize = True
        Me.lblStentItem.Enabled = False
        Me.lblStentItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStentItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblStentItem.Location = New System.Drawing.Point(233, 106)
        Me.lblStentItem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStentItem.Name = "lblStentItem"
        Me.lblStentItem.Size = New System.Drawing.Size(0, 20)
        Me.lblStentItem.TabIndex = 8
        '
        'lblStentBatch
        '
        Me.lblStentBatch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStentBatch.AutoSize = True
        Me.lblStentBatch.Enabled = False
        Me.lblStentBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStentBatch.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblStentBatch.Location = New System.Drawing.Point(232, 139)
        Me.lblStentBatch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStentBatch.Name = "lblStentBatch"
        Me.lblStentBatch.Size = New System.Drawing.Size(0, 20)
        Me.lblStentBatch.TabIndex = 9
        '
        'txtInitialSerialNo
        '
        Me.txtInitialSerialNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtInitialSerialNo.HideSelection = False
        Me.txtInitialSerialNo.Location = New System.Drawing.Point(227, 28)
        Me.txtInitialSerialNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInitialSerialNo.MaxLength = 12
        Me.txtInitialSerialNo.Name = "txtInitialSerialNo"
        Me.txtInitialSerialNo.Size = New System.Drawing.Size(127, 26)
        Me.txtInitialSerialNo.TabIndex = 136
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(104, 170)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 20)
        Me.Label13.TabIndex = 123
        Me.Label13.Text = "Total Qty"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(145, 103)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 20)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "Item"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(132, 138)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 20)
        Me.Label10.TabIndex = 127
        Me.Label10.Text = "Batch"
        '
        'dgStentSerials
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.dgStentSerials.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgStentSerials.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgStentSerials.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgStentSerials.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgStentSerials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStentSerials.Location = New System.Drawing.Point(28, 482)
        Me.dgStentSerials.Margin = New System.Windows.Forms.Padding(4)
        Me.dgStentSerials.Name = "dgStentSerials"
        Me.dgStentSerials.RowTemplate.Height = 24
        Me.dgStentSerials.Size = New System.Drawing.Size(588, 309)
        Me.dgStentSerials.TabIndex = 136
        '
        'FrmAssignCoatedStentRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 843)
        Me.Controls.Add(Me.dgStentSerials)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.chkSelectAll)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAssign)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmAssignCoatedStentRange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign Coated Stents"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgStentSerials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAssign As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFGWoNo As System.Windows.Forms.TextBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblBatch As System.Windows.Forms.Label
    Friend WithEvents lblItemDesc As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCoatedStentWO As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStentItem As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblStentBatch As System.Windows.Forms.Label
    Friend WithEvents lblStentTotalQty As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dgStentSerials As System.Windows.Forms.DataGridView
    Friend WithEvents txtInitialSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailableQty As System.Windows.Forms.TextBox
End Class
