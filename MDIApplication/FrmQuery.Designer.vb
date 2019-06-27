<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuery
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnClose = New System.Windows.Forms.Button
        Me.chbxAll = New System.Windows.Forms.CheckBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.chkbNotAuthorised = New System.Windows.Forms.CheckBox
        Me.chkbAuthorised = New System.Windows.Forms.CheckBox
        Me.lblStatus = New System.Windows.Forms.Label
        Me.txtResource = New System.Windows.Forms.TextBox
        Me.lblResource = New System.Windows.Forms.Label
        Me.cmbWarehouse = New System.Windows.Forms.ComboBox
        Me.lblWarehouse = New System.Windows.Forms.Label
        Me.txtRef = New System.Windows.Forms.TextBox
        Me.lblRef = New System.Windows.Forms.Label
        Me.lblTo = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.lblDate = New System.Windows.Forms.Label
        Me.lblItem = New System.Windows.Forms.Label
        Me.dgQuery = New System.Windows.Forms.DataGridView
        CType(Me.dgQuery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.Location = New System.Drawing.Point(317, 554)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 25)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chbxAll
        '
        Me.chbxAll.AutoSize = True
        Me.chbxAll.Location = New System.Drawing.Point(423, 99)
        Me.chbxAll.Name = "chbxAll"
        Me.chbxAll.Size = New System.Drawing.Size(45, 20)
        Me.chbxAll.TabIndex = 146
        Me.chbxAll.Text = "All"
        Me.chbxAll.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(291, 97)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(121, 22)
        Me.DateTimePicker2.TabIndex = 145
        '
        'chkbNotAuthorised
        '
        Me.chkbNotAuthorised.AutoSize = True
        Me.chkbNotAuthorised.Location = New System.Drawing.Point(251, 201)
        Me.chkbNotAuthorised.Name = "chkbNotAuthorised"
        Me.chkbNotAuthorised.Size = New System.Drawing.Size(129, 20)
        Me.chkbNotAuthorised.TabIndex = 151
        Me.chkbNotAuthorised.Text = "Not Authorised"
        Me.chkbNotAuthorised.UseVisualStyleBackColor = True
        '
        'chkbAuthorised
        '
        Me.chkbAuthorised.AutoSize = True
        Me.chkbAuthorised.Location = New System.Drawing.Point(125, 202)
        Me.chkbAuthorised.Name = "chkbAuthorised"
        Me.chkbAuthorised.Size = New System.Drawing.Size(101, 20)
        Me.chkbAuthorised.TabIndex = 150
        Me.chkbAuthorised.Text = "Authorised"
        Me.chkbAuthorised.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(68, 203)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(51, 16)
        Me.lblStatus.TabIndex = 158
        Me.lblStatus.Text = "Status"
        '
        'txtResource
        '
        Me.txtResource.Location = New System.Drawing.Point(125, 168)
        Me.txtResource.MaxLength = 100
        Me.txtResource.Name = "txtResource"
        Me.txtResource.Size = New System.Drawing.Size(121, 22)
        Me.txtResource.TabIndex = 149
        '
        'lblResource
        '
        Me.lblResource.AutoSize = True
        Me.lblResource.Location = New System.Drawing.Point(44, 168)
        Me.lblResource.Name = "lblResource"
        Me.lblResource.Size = New System.Drawing.Size(75, 16)
        Me.lblResource.TabIndex = 156
        Me.lblResource.Text = "Resource"
        '
        'cmbWarehouse
        '
        Me.cmbWarehouse.FormattingEnabled = True
        Me.cmbWarehouse.Location = New System.Drawing.Point(125, 20)
        Me.cmbWarehouse.Name = "cmbWarehouse"
        Me.cmbWarehouse.Size = New System.Drawing.Size(121, 24)
        Me.cmbWarehouse.TabIndex = 142
        '
        'lblWarehouse
        '
        Me.lblWarehouse.AutoSize = True
        Me.lblWarehouse.Location = New System.Drawing.Point(32, 24)
        Me.lblWarehouse.Name = "lblWarehouse"
        Me.lblWarehouse.Size = New System.Drawing.Size(87, 16)
        Me.lblWarehouse.TabIndex = 155
        Me.lblWarehouse.Text = "Warehouse"
        '
        'txtRef
        '
        Me.txtRef.Location = New System.Drawing.Point(125, 133)
        Me.txtRef.MaxLength = 100
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(121, 22)
        Me.txtRef.TabIndex = 148
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Location = New System.Drawing.Point(39, 136)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(80, 16)
        Me.lblRef.TabIndex = 154
        Me.lblRef.Text = "Reference"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(261, 100)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(27, 16)
        Me.lblTo.TabIndex = 147
        Me.lblTo.Text = "To"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(125, 96)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 22)
        Me.DateTimePicker1.TabIndex = 144
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(125, 59)
        Me.txtItem.MaxLength = 50
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(121, 22)
        Me.txtItem.TabIndex = 143
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(78, 97)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(41, 16)
        Me.lblDate.TabIndex = 153
        Me.lblDate.Text = "Date"
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(78, 59)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(41, 16)
        Me.lblItem.TabIndex = 157
        Me.lblItem.Text = "Item "
        '
        'dgQuery
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan
        Me.dgQuery.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgQuery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgQuery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgQuery.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgQuery.Location = New System.Drawing.Point(26, 234)
        Me.dgQuery.Name = "dgQuery"
        Me.dgQuery.Size = New System.Drawing.Size(648, 310)
        Me.dgQuery.TabIndex = 159
        '
        'FrmQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 589)
        Me.Controls.Add(Me.dgQuery)
        Me.Controls.Add(Me.chbxAll)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.chkbNotAuthorised)
        Me.Controls.Add(Me.chkbAuthorised)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtResource)
        Me.Controls.Add(Me.lblResource)
        Me.Controls.Add(Me.cmbWarehouse)
        Me.Controls.Add(Me.lblWarehouse)
        Me.Controls.Add(Me.txtRef)
        Me.Controls.Add(Me.lblRef)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmQuery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Query Form"
        CType(Me.dgQuery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents chbxAll As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkbNotAuthorised As System.Windows.Forms.CheckBox
    Friend WithEvents chkbAuthorised As System.Windows.Forms.CheckBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtResource As System.Windows.Forms.TextBox
    Friend WithEvents lblResource As System.Windows.Forms.Label
    Friend WithEvents cmbWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents lblWarehouse As System.Windows.Forms.Label
    Friend WithEvents txtRef As System.Windows.Forms.TextBox
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents dgQuery As System.Windows.Forms.DataGridView
End Class
