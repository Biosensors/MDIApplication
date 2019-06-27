<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStentInspection
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
        Me.btnPass = New System.Windows.Forms.Button
        Me.btnFail = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblFailPercent = New System.Windows.Forms.Label
        Me.lblPassPercent = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTotalFail = New System.Windows.Forms.TextBox
        Me.txtTotalPass = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtStentSerialNo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtStentQty = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtWOQty = New System.Windows.Forms.TextBox
        Me.txtBatch = New System.Windows.Forms.TextBox
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.txtStentWO = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtOperator = New System.Windows.Forms.TextBox
        Me.btnNextStentWO = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPass
        '
        Me.btnPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPass.BackColor = System.Drawing.Color.LimeGreen
        Me.btnPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPass.Location = New System.Drawing.Point(59, 59)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(180, 80)
        Me.btnPass.TabIndex = 10
        Me.btnPass.Text = "PASS"
        Me.btnPass.UseVisualStyleBackColor = False
        '
        'btnFail
        '
        Me.btnFail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFail.BackColor = System.Drawing.Color.OrangeRed
        Me.btnFail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFail.Location = New System.Drawing.Point(59, 183)
        Me.btnFail.Name = "btnFail"
        Me.btnFail.Size = New System.Drawing.Size(180, 80)
        Me.btnFail.TabIndex = 11
        Me.btnFail.Text = "FAIL"
        Me.btnFail.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.lblFailPercent)
        Me.GroupBox3.Controls.Add(Me.lblPassPercent)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtTotalFail)
        Me.GroupBox3.Controls.Add(Me.txtTotalPass)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(20, 275)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(329, 112)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totals"
        '
        'lblFailPercent
        '
        Me.lblFailPercent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFailPercent.AutoSize = True
        Me.lblFailPercent.Location = New System.Drawing.Point(249, 71)
        Me.lblFailPercent.Name = "lblFailPercent"
        Me.lblFailPercent.Size = New System.Drawing.Size(40, 17)
        Me.lblFailPercent.TabIndex = 101
        Me.lblFailPercent.Text = "0.00"
        '
        'lblPassPercent
        '
        Me.lblPassPercent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPassPercent.AutoSize = True
        Me.lblPassPercent.Location = New System.Drawing.Point(249, 32)
        Me.lblPassPercent.Name = "lblPassPercent"
        Me.lblPassPercent.Size = New System.Drawing.Size(40, 17)
        Me.lblPassPercent.TabIndex = 81
        Me.lblPassPercent.Text = "0.00"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(287, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "%"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(287, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "%"
        '
        'txtTotalFail
        '
        Me.txtTotalFail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotalFail.Location = New System.Drawing.Point(87, 68)
        Me.txtTotalFail.Name = "txtTotalFail"
        Me.txtTotalFail.ReadOnly = True
        Me.txtTotalFail.Size = New System.Drawing.Size(98, 23)
        Me.txtTotalFail.TabIndex = 9
        Me.txtTotalFail.TabStop = False
        '
        'txtTotalPass
        '
        Me.txtTotalPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotalPass.Location = New System.Drawing.Point(87, 29)
        Me.txtTotalPass.Name = "txtTotalPass"
        Me.txtTotalPass.ReadOnly = True
        Me.txtTotalPass.Size = New System.Drawing.Size(98, 23)
        Me.txtTotalPass.TabIndex = 8
        Me.txtTotalPass.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(39, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 16)
        Me.Label9.TabIndex = 151
        Me.Label9.Text = "Fail"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(39, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "Pass"
        '
        'txtStentSerialNo
        '
        Me.txtStentSerialNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStentSerialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStentSerialNo.Location = New System.Drawing.Point(507, 24)
        Me.txtStentSerialNo.MaxLength = 16
        Me.txtStentSerialNo.Name = "txtStentSerialNo"
        Me.txtStentSerialNo.Size = New System.Drawing.Size(160, 23)
        Me.txtStentSerialNo.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(382, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 17)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Stent Serial No"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.txtStentQty)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtWOQty)
        Me.GroupBox1.Controls.Add(Me.txtBatch)
        Me.GroupBox1.Controls.Add(Me.txtItem)
        Me.GroupBox1.Controls.Add(Me.txtStentWO)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(23, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 189)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stent Work Order Details"
        '
        'txtStentQty
        '
        Me.txtStentQty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStentQty.Location = New System.Drawing.Point(148, 153)
        Me.txtStentQty.Name = "txtStentQty"
        Me.txtStentQty.ReadOnly = True
        Me.txtStentQty.Size = New System.Drawing.Size(156, 23)
        Me.txtStentQty.TabIndex = 7
        Me.txtStentQty.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(71, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Stent Qty"
        '
        'txtWOQty
        '
        Me.txtWOQty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtWOQty.Location = New System.Drawing.Point(148, 123)
        Me.txtWOQty.Name = "txtWOQty"
        Me.txtWOQty.ReadOnly = True
        Me.txtWOQty.Size = New System.Drawing.Size(156, 23)
        Me.txtWOQty.TabIndex = 6
        Me.txtWOQty.TabStop = False
        '
        'txtBatch
        '
        Me.txtBatch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBatch.Location = New System.Drawing.Point(149, 92)
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.ReadOnly = True
        Me.txtBatch.Size = New System.Drawing.Size(156, 23)
        Me.txtBatch.TabIndex = 5
        Me.txtBatch.TabStop = False
        '
        'txtItem
        '
        Me.txtItem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItem.Location = New System.Drawing.Point(149, 61)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(156, 23)
        Me.txtItem.TabIndex = 4
        Me.txtItem.TabStop = False
        '
        'txtStentWO
        '
        Me.txtStentWO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStentWO.Location = New System.Drawing.Point(149, 31)
        Me.txtStentWO.MaxLength = 12
        Me.txtStentWO.Name = "txtStentWO"
        Me.txtStentWO.Size = New System.Drawing.Size(156, 23)
        Me.txtStentWO.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Stent Work Order"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(81, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "WO Qty"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(105, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Item"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(95, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = "Batch"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(38, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Operator"
        '
        'txtOperator
        '
        Me.txtOperator.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperator.Location = New System.Drawing.Point(117, 24)
        Me.txtOperator.MaxLength = 50
        Me.txtOperator.Name = "txtOperator"
        Me.txtOperator.ReadOnly = True
        Me.txtOperator.Size = New System.Drawing.Size(211, 23)
        Me.txtOperator.TabIndex = 1
        Me.txtOperator.TabStop = False
        '
        'btnNextStentWO
        '
        Me.btnNextStentWO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNextStentWO.BackColor = System.Drawing.SystemColors.Control
        Me.btnNextStentWO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnNextStentWO.ForeColor = System.Drawing.Color.Black
        Me.btnNextStentWO.Location = New System.Drawing.Point(202, 17)
        Me.btnNextStentWO.Name = "btnNextStentWO"
        Me.btnNextStentWO.Size = New System.Drawing.Size(125, 25)
        Me.btnNextStentWO.TabIndex = 14
        Me.btnNextStentWO.Text = "Next Stent WO"
        Me.btnNextStentWO.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(341, 17)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(125, 25)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnNextStentWO)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 394)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(647, 48)
        Me.GroupBox2.TabIndex = 111
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.Controls.Add(Me.btnFail)
        Me.GroupBox4.Controls.Add(Me.btnPass)
        Me.GroupBox4.Location = New System.Drawing.Point(373, 68)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(294, 319)
        Me.GroupBox4.TabIndex = 112
        Me.GroupBox4.TabStop = False
        '
        'FrmStentInspection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 453)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtOperator)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtStentSerialNo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmStentInspection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stent Inspection"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPass As System.Windows.Forms.Button
    Friend WithEvents btnFail As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalFail As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPass As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtStentSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtWOQty As System.Windows.Forms.TextBox
    Friend WithEvents txtBatch As System.Windows.Forms.TextBox
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents txtStentWO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtOperator As System.Windows.Forms.TextBox
    Friend WithEvents btnNextStentWO As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStentQty As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblFailPercent As System.Windows.Forms.Label
    Friend WithEvents lblPassPercent As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
