<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNode
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rtbQuery = New System.Windows.Forms.RichTextBox
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.lblType = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtParentNode = New System.Windows.Forms.TextBox
        Me.lblFormName = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtChildNode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFormName = New System.Windows.Forms.TextBox
        Me.rbMenuName = New System.Windows.Forms.RadioButton
        Me.rbFormName = New System.Windows.Forms.RadioButton
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.rtbQuery)
        Me.GroupBox1.Controls.Add(Me.cmbType)
        Me.GroupBox1.Controls.Add(Me.lblType)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtParentNode)
        Me.GroupBox1.Controls.Add(Me.lblFormName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtChildNode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFormName)
        Me.GroupBox1.Controls.Add(Me.rbMenuName)
        Me.GroupBox1.Controls.Add(Me.rbFormName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(541, 291)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        '
        'rtbQuery
        '
        Me.rtbQuery.BackColor = System.Drawing.SystemColors.Window
        Me.rtbQuery.Location = New System.Drawing.Point(118, 198)
        Me.rtbQuery.MaxLength = 50
        Me.rtbQuery.Name = "rtbQuery"
        Me.rtbQuery.Size = New System.Drawing.Size(394, 77)
        Me.rtbQuery.TabIndex = 7
        Me.rtbQuery.Text = ""
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(118, 158)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(108, 24)
        Me.cmbType.TabIndex = 6
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(16, 162)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(98, 16)
        Me.lblType.TabIndex = 121
        Me.lblType.Text = "Type / Name"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(121, 96)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Add as Root"
        '
        'txtParentNode
        '
        Me.txtParentNode.Location = New System.Drawing.Point(121, 19)
        Me.txtParentNode.MaxLength = 50
        Me.txtParentNode.Name = "txtParentNode"
        Me.txtParentNode.Size = New System.Drawing.Size(173, 22)
        Me.txtParentNode.TabIndex = 1
        '
        'lblFormName
        '
        Me.lblFormName.AutoSize = True
        Me.lblFormName.Location = New System.Drawing.Point(27, 201)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(88, 16)
        Me.lblFormName.TabIndex = 81
        Me.lblFormName.Text = "Form Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Type"
        '
        'txtChildNode
        '
        Me.txtChildNode.Location = New System.Drawing.Point(121, 56)
        Me.txtChildNode.MaxLength = 3
        Me.txtChildNode.Name = "txtChildNode"
        Me.txtChildNode.Size = New System.Drawing.Size(173, 22)
        Me.txtChildNode.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(68, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Node"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(62, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Parent"
        '
        'txtFormName
        '
        Me.txtFormName.Location = New System.Drawing.Point(127, 205)
        Me.txtFormName.Name = "txtFormName"
        Me.txtFormName.Size = New System.Drawing.Size(173, 22)
        Me.txtFormName.TabIndex = 3
        '
        'rbMenuName
        '
        Me.rbMenuName.AutoSize = True
        Me.rbMenuName.Checked = True
        Me.rbMenuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbMenuName.Location = New System.Drawing.Point(206, 124)
        Me.rbMenuName.Name = "rbMenuName"
        Me.rbMenuName.Size = New System.Drawing.Size(63, 20)
        Me.rbMenuName.TabIndex = 5
        Me.rbMenuName.TabStop = True
        Me.rbMenuName.Text = "Menu"
        Me.rbMenuName.UseVisualStyleBackColor = True
        '
        'rbFormName
        '
        Me.rbFormName.AutoSize = True
        Me.rbFormName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbFormName.Location = New System.Drawing.Point(121, 124)
        Me.rbFormName.Name = "rbFormName"
        Me.rbFormName.Size = New System.Drawing.Size(61, 20)
        Me.rbFormName.TabIndex = 4
        Me.rbFormName.Text = "Form"
        Me.rbFormName.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Location = New System.Drawing.Point(226, 321)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.Location = New System.Drawing.Point(315, 321)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FrmNode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 361)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmNode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nodes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtFormName As System.Windows.Forms.TextBox
    Friend WithEvents rbMenuName As System.Windows.Forms.RadioButton
    Friend WithEvents rbFormName As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtChildNode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFormName As System.Windows.Forms.Label
    Friend WithEvents txtParentNode As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents rtbQuery As System.Windows.Forms.RichTextBox
End Class
