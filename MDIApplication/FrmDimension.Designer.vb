<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDimension
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
        Me.txtDim3 = New System.Windows.Forms.TextBox
        Me.txtDim2 = New System.Windows.Forms.TextBox
        Me.txtDim1 = New System.Windows.Forms.TextBox
        Me.lblError = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtsrlno = New System.Windows.Forms.TextBox
        Me.lblSerial = New System.Windows.Forms.Label
        Me.lbldim1 = New System.Windows.Forms.Label
        Me.lbldim2 = New System.Windows.Forms.Label
        Me.lbldim3 = New System.Windows.Forms.Label
        Me.lblProgress = New System.Windows.Forms.Label
        Me.btnDetails = New System.Windows.Forms.Button
        Me.cmbColumns = New System.Windows.Forms.ComboBox
        Me.txtEnter = New System.Windows.Forms.TextBox
        Me.lblStartDate = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.lblEndDate = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.dgDimension = New System.Windows.Forms.DataGridView
        CType(Me.dgDimension, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDim3
        '
        Me.txtDim3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDim3.BackColor = System.Drawing.SystemColors.Window
        Me.txtDim3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtDim3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtDim3.Location = New System.Drawing.Point(647, 460)
        Me.txtDim3.MaxLength = 18
        Me.txtDim3.Name = "txtDim3"
        Me.txtDim3.Size = New System.Drawing.Size(162, 29)
        Me.txtDim3.TabIndex = 10
        Me.txtDim3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDim2
        '
        Me.txtDim2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDim2.BackColor = System.Drawing.SystemColors.Window
        Me.txtDim2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtDim2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtDim2.Location = New System.Drawing.Point(479, 460)
        Me.txtDim2.MaxLength = 18
        Me.txtDim2.Name = "txtDim2"
        Me.txtDim2.Size = New System.Drawing.Size(162, 29)
        Me.txtDim2.TabIndex = 9
        Me.txtDim2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDim1
        '
        Me.txtDim1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDim1.BackColor = System.Drawing.SystemColors.Window
        Me.txtDim1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtDim1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtDim1.Location = New System.Drawing.Point(311, 460)
        Me.txtDim1.MaxLength = 18
        Me.txtDim1.Name = "txtDim1"
        Me.txtDim1.Size = New System.Drawing.Size(162, 29)
        Me.txtDim1.TabIndex = 8
        Me.txtDim1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(57, 522)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(459, 504)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 25)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtsrlno
        '
        Me.txtsrlno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsrlno.BackColor = System.Drawing.SystemColors.Window
        Me.txtsrlno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtsrlno.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtsrlno.Location = New System.Drawing.Point(143, 460)
        Me.txtsrlno.MaxLength = 16
        Me.txtsrlno.Name = "txtsrlno"
        Me.txtsrlno.Size = New System.Drawing.Size(162, 29)
        Me.txtsrlno.TabIndex = 7
        Me.txtsrlno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSerial
        '
        Me.lblSerial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSerial.AutoSize = True
        Me.lblSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerial.ForeColor = System.Drawing.Color.Red
        Me.lblSerial.Location = New System.Drawing.Point(184, 441)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(73, 16)
        Me.lblSerial.TabIndex = 42
        Me.lblSerial.Text = "Serial No"
        '
        'lbldim1
        '
        Me.lbldim1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbldim1.AutoSize = True
        Me.lbldim1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldim1.ForeColor = System.Drawing.Color.Red
        Me.lbldim1.Location = New System.Drawing.Point(343, 441)
        Me.lbldim1.Name = "lbldim1"
        Me.lbldim1.Size = New System.Drawing.Size(105, 16)
        Me.lbldim1.TabIndex = 43
        Me.lbldim1.Text = "1st Dimension"
        '
        'lbldim2
        '
        Me.lbldim2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbldim2.AutoSize = True
        Me.lbldim2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldim2.ForeColor = System.Drawing.Color.Red
        Me.lbldim2.Location = New System.Drawing.Point(508, 441)
        Me.lbldim2.Name = "lbldim2"
        Me.lbldim2.Size = New System.Drawing.Size(114, 16)
        Me.lbldim2.TabIndex = 44
        Me.lbldim2.Text = "2nd  Dimension"
        '
        'lbldim3
        '
        Me.lbldim3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbldim3.AutoSize = True
        Me.lbldim3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldim3.ForeColor = System.Drawing.Color.Red
        Me.lbldim3.Location = New System.Drawing.Point(668, 441)
        Me.lbldim3.Name = "lbldim3"
        Me.lbldim3.Size = New System.Drawing.Size(107, 16)
        Me.lbldim3.TabIndex = 45
        Me.lbldim3.Text = "3rd Dimension"
        '
        'lblProgress
        '
        Me.lblProgress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblProgress.ForeColor = System.Drawing.Color.Red
        Me.lblProgress.Location = New System.Drawing.Point(168, 504)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(234, 17)
        Me.lblProgress.TabIndex = 46
        Me.lblProgress.Text = "Retrieving Data in Progress....."
        Me.lblProgress.Visible = False
        '
        'btnDetails
        '
        Me.btnDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetails.Location = New System.Drawing.Point(816, 50)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(125, 25)
        Me.btnDetails.TabIndex = 53
        Me.btnDetails.Text = "Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'cmbColumns
        '
        Me.cmbColumns.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbColumns.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbColumns.FormattingEnabled = True
        Me.cmbColumns.Location = New System.Drawing.Point(16, 52)
        Me.cmbColumns.Name = "cmbColumns"
        Me.cmbColumns.Size = New System.Drawing.Size(140, 24)
        Me.cmbColumns.TabIndex = 50
        '
        'txtEnter
        '
        Me.txtEnter.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnter.Location = New System.Drawing.Point(167, 53)
        Me.txtEnter.MaxLength = 50
        Me.txtEnter.Name = "txtEnter"
        Me.txtEnter.Size = New System.Drawing.Size(187, 22)
        Me.txtEnter.TabIndex = 51
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblStartDate.Location = New System.Drawing.Point(20, 20)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(141, 16)
        Me.lblStartDate.TabIndex = 54
        Me.lblStartDate.Text = "ScannedDate From"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.Location = New System.Drawing.Point(363, 52)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(125, 25)
        Me.btnSearch.TabIndex = 52
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblEndDate.Location = New System.Drawing.Point(285, 20)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(27, 16)
        Me.lblEndDate.TabIndex = 55
        Me.lblEndDate.Text = "To"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(316, 17)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(113, 22)
        Me.DateTimePicker2.TabIndex = 49
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(163, 17)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 22)
        Me.DateTimePicker1.TabIndex = 48
        '
        'dgDimension
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.dgDimension.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgDimension.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgDimension.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDimension.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgDimension.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDimension.Location = New System.Drawing.Point(16, 104)
        Me.dgDimension.Name = "dgDimension"
        Me.dgDimension.Size = New System.Drawing.Size(925, 334)
        Me.dgDimension.TabIndex = 139
        '
        'FrmDimension
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(959, 539)
        Me.Controls.Add(Me.dgDimension)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.cmbColumns)
        Me.Controls.Add(Me.txtEnter)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.lbldim3)
        Me.Controls.Add(Me.lbldim2)
        Me.Controls.Add(Me.lbldim1)
        Me.Controls.Add(Me.lblSerial)
        Me.Controls.Add(Me.txtsrlno)
        Me.Controls.Add(Me.txtDim3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDim2)
        Me.Controls.Add(Me.txtDim1)
        Me.Controls.Add(Me.lblError)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmDimension"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stent Profile"
        CType(Me.dgDimension, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDim3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDim2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDim1 As System.Windows.Forms.TextBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtsrlno As System.Windows.Forms.TextBox
    Friend WithEvents lblSerial As System.Windows.Forms.Label
    Friend WithEvents lbldim1 As System.Windows.Forms.Label
    Friend WithEvents lbldim2 As System.Windows.Forms.Label
    Friend WithEvents lbldim3 As System.Windows.Forms.Label
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents btnDetails As System.Windows.Forms.Button
    Friend WithEvents cmbColumns As System.Windows.Forms.ComboBox
    Friend WithEvents txtEnter As System.Windows.Forms.TextBox
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgDimension As System.Windows.Forms.DataGridView
End Class
