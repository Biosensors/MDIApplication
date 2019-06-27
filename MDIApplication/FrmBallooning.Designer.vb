<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBallooning
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
        Me.txtActualQty = New System.Windows.Forms.TextBox
        Me.txtPlanQty = New System.Windows.Forms.TextBox
        Me.txtBatch = New System.Windows.Forms.TextBox
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtwrkordno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtOperator = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtMachineID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnPass = New System.Windows.Forms.Button
        Me.btnFail = New System.Windows.Forms.Button
        Me.lbldim3 = New System.Windows.Forms.Label
        Me.lbldim2 = New System.Windows.Forms.Label
        Me.lbldim1 = New System.Windows.Forms.Label
        Me.txtDim3 = New System.Windows.Forms.TextBox
        Me.txtDim2 = New System.Windows.Forms.TextBox
        Me.txtDim1 = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtTotalFail = New System.Windows.Forms.TextBox
        Me.txtTotalPass = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.txtActualQty)
        Me.GroupBox1.Controls.Add(Me.txtPlanQty)
        Me.GroupBox1.Controls.Add(Me.txtBatch)
        Me.GroupBox1.Controls.Add(Me.txtItem)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtwrkordno)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(28, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 198)
        Me.GroupBox1.TabIndex = 110
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Work Order Details"
        '
        'txtActualQty
        '
        Me.txtActualQty.Location = New System.Drawing.Point(131, 162)
        Me.txtActualQty.Name = "txtActualQty"
        Me.txtActualQty.ReadOnly = True
        Me.txtActualQty.Size = New System.Drawing.Size(156, 23)
        Me.txtActualQty.TabIndex = 5
        '
        'txtPlanQty
        '
        Me.txtPlanQty.Location = New System.Drawing.Point(131, 129)
        Me.txtPlanQty.Name = "txtPlanQty"
        Me.txtPlanQty.ReadOnly = True
        Me.txtPlanQty.Size = New System.Drawing.Size(156, 23)
        Me.txtPlanQty.TabIndex = 4
        '
        'txtBatch
        '
        Me.txtBatch.Location = New System.Drawing.Point(131, 95)
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.ReadOnly = True
        Me.txtBatch.Size = New System.Drawing.Size(156, 23)
        Me.txtBatch.TabIndex = 3
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(131, 62)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(156, 23)
        Me.txtItem.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(59, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Plan Qty"
        '
        'txtwrkordno
        '
        Me.txtwrkordno.Location = New System.Drawing.Point(131, 29)
        Me.txtwrkordno.MaxLength = 12
        Me.txtwrkordno.Name = "txtwrkordno"
        Me.txtwrkordno.Size = New System.Drawing.Size(156, 23)
        Me.txtwrkordno.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Work Order No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(49, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "Actual Qty"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(90, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Item"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(80, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = "Batch"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.txtOperator)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtMachineID)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(28, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 111)
        Me.GroupBox2.TabIndex = 111
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Machine Details"
        '
        'txtOperator
        '
        Me.txtOperator.Location = New System.Drawing.Point(129, 71)
        Me.txtOperator.MaxLength = 20
        Me.txtOperator.Name = "txtOperator"
        Me.txtOperator.Size = New System.Drawing.Size(156, 23)
        Me.txtOperator.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(54, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Operator"
        '
        'txtMachineID
        '
        Me.txtMachineID.Location = New System.Drawing.Point(129, 30)
        Me.txtMachineID.MaxLength = 20
        Me.txtMachineID.Name = "txtMachineID"
        Me.txtMachineID.Size = New System.Drawing.Size(156, 23)
        Me.txtMachineID.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(40, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Machine ID"
        '
        'btnPass
        '
        Me.btnPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPass.BackColor = System.Drawing.Color.LimeGreen
        Me.btnPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPass.Location = New System.Drawing.Point(368, 33)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(190, 70)
        Me.btnPass.TabIndex = 8
        Me.btnPass.Text = "PASS"
        Me.btnPass.UseVisualStyleBackColor = False
        '
        'btnFail
        '
        Me.btnFail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFail.BackColor = System.Drawing.Color.OrangeRed
        Me.btnFail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFail.Location = New System.Drawing.Point(591, 33)
        Me.btnFail.Name = "btnFail"
        Me.btnFail.Size = New System.Drawing.Size(190, 70)
        Me.btnFail.TabIndex = 9
        Me.btnFail.Text = "FAIL"
        Me.btnFail.UseVisualStyleBackColor = False
        '
        'lbldim3
        '
        Me.lbldim3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbldim3.AutoSize = True
        Me.lbldim3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldim3.ForeColor = System.Drawing.Color.Red
        Me.lbldim3.Location = New System.Drawing.Point(649, 135)
        Me.lbldim3.Name = "lbldim3"
        Me.lbldim3.Size = New System.Drawing.Size(107, 16)
        Me.lbldim3.TabIndex = 211
        Me.lbldim3.Text = "3rd Dimension"
        '
        'lbldim2
        '
        Me.lbldim2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbldim2.AutoSize = True
        Me.lbldim2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldim2.ForeColor = System.Drawing.Color.Red
        Me.lbldim2.Location = New System.Drawing.Point(507, 135)
        Me.lbldim2.Name = "lbldim2"
        Me.lbldim2.Size = New System.Drawing.Size(114, 16)
        Me.lbldim2.TabIndex = 201
        Me.lbldim2.Text = "2nd  Dimension"
        '
        'lbldim1
        '
        Me.lbldim1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbldim1.AutoSize = True
        Me.lbldim1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldim1.ForeColor = System.Drawing.Color.Red
        Me.lbldim1.Location = New System.Drawing.Point(365, 135)
        Me.lbldim1.Name = "lbldim1"
        Me.lbldim1.Size = New System.Drawing.Size(105, 16)
        Me.lbldim1.TabIndex = 191
        Me.lbldim1.Text = "1st Dimension"
        '
        'txtDim3
        '
        Me.txtDim3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDim3.BackColor = System.Drawing.SystemColors.Window
        Me.txtDim3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtDim3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtDim3.Location = New System.Drawing.Point(652, 155)
        Me.txtDim3.MaxLength = 18
        Me.txtDim3.Name = "txtDim3"
        Me.txtDim3.Size = New System.Drawing.Size(130, 29)
        Me.txtDim3.TabIndex = 12
        Me.txtDim3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDim2
        '
        Me.txtDim2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDim2.BackColor = System.Drawing.SystemColors.Window
        Me.txtDim2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtDim2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtDim2.Location = New System.Drawing.Point(510, 155)
        Me.txtDim2.MaxLength = 18
        Me.txtDim2.Name = "txtDim2"
        Me.txtDim2.Size = New System.Drawing.Size(130, 29)
        Me.txtDim2.TabIndex = 11
        Me.txtDim2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDim1
        '
        Me.txtDim1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDim1.BackColor = System.Drawing.SystemColors.Window
        Me.txtDim1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtDim1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtDim1.Location = New System.Drawing.Point(368, 155)
        Me.txtDim1.MaxLength = 18
        Me.txtDim1.Name = "txtDim1"
        Me.txtDim1.Size = New System.Drawing.Size(130, 29)
        Me.txtDim1.TabIndex = 10
        Me.txtDim1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.txtTotalFail)
        Me.GroupBox3.Controls.Add(Me.txtTotalPass)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(368, 221)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(263, 124)
        Me.GroupBox3.TabIndex = 221
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totals"
        '
        'txtTotalFail
        '
        Me.txtTotalFail.Location = New System.Drawing.Point(74, 82)
        Me.txtTotalFail.Name = "txtTotalFail"
        Me.txtTotalFail.ReadOnly = True
        Me.txtTotalFail.Size = New System.Drawing.Size(156, 23)
        Me.txtTotalFail.TabIndex = 14
        '
        'txtTotalPass
        '
        Me.txtTotalPass.Location = New System.Drawing.Point(74, 36)
        Me.txtTotalPass.Name = "txtTotalPass"
        Me.txtTotalPass.ReadOnly = True
        Me.txtTotalPass.Size = New System.Drawing.Size(156, 23)
        Me.txtTotalPass.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(26, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 16)
        Me.Label9.TabIndex = 151
        Me.Label9.Text = "Fail"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(26, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "Pass"
        '
        'FrmBalooning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 370)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lbldim3)
        Me.Controls.Add(Me.lbldim2)
        Me.Controls.Add(Me.lbldim1)
        Me.Controls.Add(Me.txtDim3)
        Me.Controls.Add(Me.txtDim2)
        Me.Controls.Add(Me.txtDim1)
        Me.Controls.Add(Me.btnFail)
        Me.Controls.Add(Me.btnPass)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBalooning"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balooning"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtwrkordno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtActualQty As System.Windows.Forms.TextBox
    Friend WithEvents txtPlanQty As System.Windows.Forms.TextBox
    Friend WithEvents txtBatch As System.Windows.Forms.TextBox
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOperator As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMachineID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPass As System.Windows.Forms.Button
    Friend WithEvents btnFail As System.Windows.Forms.Button
    Friend WithEvents lbldim3 As System.Windows.Forms.Label
    Friend WithEvents lbldim2 As System.Windows.Forms.Label
    Friend WithEvents lbldim1 As System.Windows.Forms.Label
    Friend WithEvents txtDim3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDim2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDim1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalFail As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPass As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
