<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shipment
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
        Me.txtsrno1 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtQASample = New System.Windows.Forms.TextBox
        Me.lblQaSample = New System.Windows.Forms.Label
        Me.txtBESA = New System.Windows.Forms.TextBox
        Me.txtBIT = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtWono = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbShipment = New System.Windows.Forms.TabControl
        Me.tabBIT = New System.Windows.Forms.TabPage
        Me.dgBIT = New System.Windows.Forms.DataGrid
        Me.tabQA = New System.Windows.Forms.TabPage
        Me.dgQA = New System.Windows.Forms.DataGrid
        Me.tabBesa = New System.Windows.Forms.TabPage
        Me.dgBESA = New System.Windows.Forms.DataGrid
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.tbShipment.SuspendLayout()
        Me.tabBIT.SuspendLayout()
        CType(Me.dgBIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabQA.SuspendLayout()
        CType(Me.dgQA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBesa.SuspendLayout()
        CType(Me.dgBESA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsrno1
        '
        Me.txtsrno1.BackColor = System.Drawing.SystemColors.Window
        Me.txtsrno1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsrno1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsrno1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtsrno1.Location = New System.Drawing.Point(76, 446)
        Me.txtsrno1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsrno1.Name = "txtsrno1"
        Me.txtsrno1.Size = New System.Drawing.Size(784, 34)
        Me.txtsrno1.TabIndex = 76
        Me.txtsrno1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.txtQASample)
        Me.GroupBox1.Controls.Add(Me.lblQaSample)
        Me.GroupBox1.Controls.Add(Me.txtBESA)
        Me.GroupBox1.Controls.Add(Me.txtBIT)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtWono)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbShipment)
        Me.GroupBox1.Controls.Add(Me.txtsrno1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(935, 495)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        '
        'txtQASample
        '
        Me.txtQASample.BackColor = System.Drawing.SystemColors.Control
        Me.txtQASample.Location = New System.Drawing.Point(639, 17)
        Me.txtQASample.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQASample.Name = "txtQASample"
        Me.txtQASample.ReadOnly = True
        Me.txtQASample.Size = New System.Drawing.Size(97, 26)
        Me.txtQASample.TabIndex = 85
        '
        'lblQaSample
        '
        Me.lblQaSample.AutoSize = True
        Me.lblQaSample.Location = New System.Drawing.Point(528, 23)
        Me.lblQaSample.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQaSample.Name = "lblQaSample"
        Me.lblQaSample.Size = New System.Drawing.Size(103, 20)
        Me.lblQaSample.TabIndex = 84
        Me.lblQaSample.Text = "QA Sample"
        '
        'txtBESA
        '
        Me.txtBESA.BackColor = System.Drawing.SystemColors.Control
        Me.txtBESA.Location = New System.Drawing.Point(819, 17)
        Me.txtBESA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBESA.Name = "txtBESA"
        Me.txtBESA.ReadOnly = True
        Me.txtBESA.Size = New System.Drawing.Size(97, 26)
        Me.txtBESA.TabIndex = 83
        '
        'txtBIT
        '
        Me.txtBIT.BackColor = System.Drawing.SystemColors.Control
        Me.txtBIT.Location = New System.Drawing.Point(423, 17)
        Me.txtBIT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBIT.Name = "txtBIT"
        Me.txtBIT.ReadOnly = True
        Me.txtBIT.Size = New System.Drawing.Size(97, 26)
        Me.txtBIT.TabIndex = 82
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(375, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 20)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "BIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(749, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "BESA"
        '
        'txtWono
        '
        Me.txtWono.BackColor = System.Drawing.SystemColors.Control
        Me.txtWono.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWono.Location = New System.Drawing.Point(171, 18)
        Me.txtWono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWono.Name = "txtWono"
        Me.txtWono.ReadOnly = True
        Me.txtWono.Size = New System.Drawing.Size(188, 26)
        Me.txtWono.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "SubCon PO No"
        '
        'tbShipment
        '
        Me.tbShipment.Controls.Add(Me.tabBIT)
        Me.tbShipment.Controls.Add(Me.tabQA)
        Me.tbShipment.Controls.Add(Me.tabBesa)
        Me.tbShipment.Location = New System.Drawing.Point(16, 52)
        Me.tbShipment.Margin = New System.Windows.Forms.Padding(4)
        Me.tbShipment.Name = "tbShipment"
        Me.tbShipment.SelectedIndex = 0
        Me.tbShipment.Size = New System.Drawing.Size(904, 386)
        Me.tbShipment.TabIndex = 77
        '
        'tabBIT
        '
        Me.tabBIT.BackColor = System.Drawing.Color.PaleGreen
        Me.tabBIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabBIT.Controls.Add(Me.dgBIT)
        Me.tabBIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBIT.ForeColor = System.Drawing.Color.Green
        Me.tabBIT.ImageIndex = CType(configurationAppSettings.GetValue("TabPage1.ImageIndex", GetType(Integer)), Integer)
        Me.tabBIT.Location = New System.Drawing.Point(4, 29)
        Me.tabBIT.Margin = New System.Windows.Forms.Padding(4)
        Me.tabBIT.Name = "tabBIT"
        Me.tabBIT.Size = New System.Drawing.Size(896, 353)
        Me.tabBIT.TabIndex = 0
        Me.tabBIT.Text = "BIT"
        Me.tabBIT.UseVisualStyleBackColor = True
        '
        'dgBIT
        '
        Me.dgBIT.AlternatingBackColor = System.Drawing.Color.LightCyan
        Me.dgBIT.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgBIT.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgBIT.CaptionForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgBIT.CaptionText = "BIT"
        Me.dgBIT.DataMember = ""
        Me.dgBIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgBIT.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgBIT.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgBIT.Location = New System.Drawing.Point(12, 11)
        Me.dgBIT.Margin = New System.Windows.Forms.Padding(4)
        Me.dgBIT.Name = "dgBIT"
        Me.dgBIT.PreferredColumnWidth = 90
        Me.dgBIT.ReadOnly = True
        Me.dgBIT.Size = New System.Drawing.Size(865, 321)
        Me.dgBIT.TabIndex = 0
        '
        'tabQA
        '
        Me.tabQA.Controls.Add(Me.dgQA)
        Me.tabQA.Location = New System.Drawing.Point(4, 29)
        Me.tabQA.Name = "tabQA"
        Me.tabQA.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQA.Size = New System.Drawing.Size(896, 353)
        Me.tabQA.TabIndex = 2
        Me.tabQA.Text = "QA Sample"
        Me.tabQA.UseVisualStyleBackColor = True
        '
        'dgQA
        '
        Me.dgQA.AlternatingBackColor = System.Drawing.Color.LightCyan
        Me.dgQA.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgQA.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgQA.CaptionForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgQA.CaptionText = "QA Sample"
        Me.dgQA.DataMember = ""
        Me.dgQA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgQA.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgQA.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgQA.Location = New System.Drawing.Point(12, 10)
        Me.dgQA.Margin = New System.Windows.Forms.Padding(4)
        Me.dgQA.Name = "dgQA"
        Me.dgQA.PreferredColumnWidth = 90
        Me.dgQA.ReadOnly = True
        Me.dgQA.Size = New System.Drawing.Size(864, 324)
        Me.dgQA.TabIndex = 2
        '
        'tabBesa
        '
        Me.tabBesa.BackColor = System.Drawing.Color.Coral
        Me.tabBesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabBesa.Controls.Add(Me.dgBESA)
        Me.tabBesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBesa.ForeColor = System.Drawing.Color.Snow
        Me.tabBesa.Location = New System.Drawing.Point(4, 29)
        Me.tabBesa.Margin = New System.Windows.Forms.Padding(4)
        Me.tabBesa.Name = "tabBesa"
        Me.tabBesa.Size = New System.Drawing.Size(896, 353)
        Me.tabBesa.TabIndex = 1
        Me.tabBesa.Text = "BESA"
        Me.tabBesa.UseVisualStyleBackColor = True
        '
        'dgBESA
        '
        Me.dgBESA.AlternatingBackColor = System.Drawing.Color.LightCyan
        Me.dgBESA.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgBESA.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgBESA.CaptionForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgBESA.CaptionText = "BESA"
        Me.dgBESA.DataMember = ""
        Me.dgBESA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgBESA.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgBESA.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgBESA.Location = New System.Drawing.Point(12, 10)
        Me.dgBESA.Margin = New System.Windows.Forms.Padding(4)
        Me.dgBESA.Name = "dgBESA"
        Me.dgBESA.PreferredColumnWidth = 90
        Me.dgBESA.ReadOnly = True
        Me.dgBESA.Size = New System.Drawing.Size(864, 324)
        Me.dgBESA.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Location = New System.Drawing.Point(457, 521)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 28)
        Me.btnClose.TabIndex = 78
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Shipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 561)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Shipment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipment Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbShipment.ResumeLayout(False)
        Me.tabBIT.ResumeLayout(False)
        CType(Me.dgBIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabQA.ResumeLayout(False)
        CType(Me.dgQA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBesa.ResumeLayout(False)
        CType(Me.dgBESA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtsrno1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbShipment As System.Windows.Forms.TabControl
    Friend WithEvents tabBIT As System.Windows.Forms.TabPage
    Friend WithEvents dgBIT As System.Windows.Forms.DataGrid
    Friend WithEvents tabBesa As System.Windows.Forms.TabPage
    Friend WithEvents dgBESA As System.Windows.Forms.DataGrid
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtBESA As System.Windows.Forms.TextBox
    Friend WithEvents txtBIT As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWono As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabQA As System.Windows.Forms.TabPage
    Friend WithEvents dgQA As System.Windows.Forms.DataGrid
    Friend WithEvents lblQaSample As System.Windows.Forms.Label
    Friend WithEvents txtQASample As System.Windows.Forms.TextBox
End Class
