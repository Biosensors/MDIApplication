<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDrugFormulation
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ddlFormulationBatch = New System.Windows.Forms.ComboBox
        Me.txtStentLength = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBatch = New System.Windows.Forms.TextBox
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.txtWoNo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtVialNo = New System.Windows.Forms.TextBox
        Me.ddlAMPC = New System.Windows.Forms.ComboBox
        Me.txtFormulationVolume = New System.Windows.Forms.TextBox
        Me.txtUVDose = New System.Windows.Forms.TextBox
        Me.txtStentSerial = New System.Windows.Forms.TextBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.dgDrugFormulation = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgDrugFormulation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(375, 16)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 25)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ddlFormulationBatch)
        Me.GroupBox1.Controls.Add(Me.txtStentLength)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBatch)
        Me.GroupBox1.Controls.Add(Me.txtItem)
        Me.GroupBox1.Controls.Add(Me.txtWoNo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(20, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 215)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Work Order Details"
        '
        'ddlFormulationBatch
        '
        Me.ddlFormulationBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlFormulationBatch.FormattingEnabled = True
        Me.ddlFormulationBatch.Location = New System.Drawing.Point(154, 140)
        Me.ddlFormulationBatch.Name = "ddlFormulationBatch"
        Me.ddlFormulationBatch.Size = New System.Drawing.Size(207, 24)
        Me.ddlFormulationBatch.TabIndex = 222
        '
        'txtStentLength
        '
        Me.txtStentLength.Location = New System.Drawing.Point(154, 175)
        Me.txtStentLength.MaxLength = 7
        Me.txtStentLength.Name = "txtStentLength"
        Me.txtStentLength.Size = New System.Drawing.Size(207, 23)
        Me.txtStentLength.TabIndex = 5
        Me.txtStentLength.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(55, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 221
        Me.Label2.Text = "Stent Length"
        '
        'txtBatch
        '
        Me.txtBatch.Location = New System.Drawing.Point(155, 103)
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.ReadOnly = True
        Me.txtBatch.Size = New System.Drawing.Size(206, 23)
        Me.txtBatch.TabIndex = 3
        Me.txtBatch.TabStop = False
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(155, 67)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(206, 23)
        Me.txtItem.TabIndex = 2
        Me.txtItem.TabStop = False
        '
        'txtWoNo
        '
        Me.txtWoNo.Location = New System.Drawing.Point(155, 31)
        Me.txtWoNo.MaxLength = 12
        Me.txtWoNo.Name = "txtWoNo"
        Me.txtWoNo.Size = New System.Drawing.Size(206, 23)
        Me.txtWoNo.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(61, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 201
        Me.Label5.Text = "Work Order"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 16)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "Formulation Batch"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(111, 70)
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
        Me.Label3.Location = New System.Drawing.Point(101, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = "Batch"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnNew)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 512)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(641, 49)
        Me.GroupBox2.TabIndex = 108
        Me.GroupBox2.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(283, 16)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(191, 16)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 25)
        Me.btnNew.TabIndex = 14
        Me.btnNew.Text = "New"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox3.Controls.Add(Me.txtVialNo)
        Me.GroupBox3.Controls.Add(Me.ddlAMPC)
        Me.GroupBox3.Controls.Add(Me.txtFormulationVolume)
        Me.GroupBox3.Controls.Add(Me.txtUVDose)
        Me.GroupBox3.Controls.Add(Me.txtStentSerial)
        Me.GroupBox3.Controls.Add(Me.btnDelete)
        Me.GroupBox3.Controls.Add(Me.btnUpdate)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 464)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(641, 42)
        Me.GroupBox3.TabIndex = 115
        Me.GroupBox3.TabStop = False
        '
        'txtVialNo
        '
        Me.txtVialNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtVialNo.Location = New System.Drawing.Point(237, 14)
        Me.txtVialNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVialNo.MaxLength = 6
        Me.txtVialNo.Name = "txtVialNo"
        Me.txtVialNo.Size = New System.Drawing.Size(70, 20)
        Me.txtVialNo.TabIndex = 9
        '
        'ddlAMPC
        '
        Me.ddlAMPC.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ddlAMPC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlAMPC.FormattingEnabled = True
        Me.ddlAMPC.Location = New System.Drawing.Point(137, 14)
        Me.ddlAMPC.Name = "ddlAMPC"
        Me.ddlAMPC.Size = New System.Drawing.Size(70, 21)
        Me.ddlAMPC.TabIndex = 8
        '
        'txtFormulationVolume
        '
        Me.txtFormulationVolume.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtFormulationVolume.Location = New System.Drawing.Point(434, 14)
        Me.txtFormulationVolume.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFormulationVolume.MaxLength = 7
        Me.txtFormulationVolume.Name = "txtFormulationVolume"
        Me.txtFormulationVolume.Size = New System.Drawing.Size(70, 20)
        Me.txtFormulationVolume.TabIndex = 11
        '
        'txtUVDose
        '
        Me.txtUVDose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtUVDose.Location = New System.Drawing.Point(337, 14)
        Me.txtUVDose.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUVDose.MaxLength = 7
        Me.txtUVDose.Name = "txtUVDose"
        Me.txtUVDose.Size = New System.Drawing.Size(70, 20)
        Me.txtUVDose.TabIndex = 10
        '
        'txtStentSerial
        '
        Me.txtStentSerial.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtStentSerial.Location = New System.Drawing.Point(36, 14)
        Me.txtStentSerial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStentSerial.MaxLength = 16
        Me.txtStentSerial.Name = "txtStentSerial"
        Me.txtStentSerial.Size = New System.Drawing.Size(70, 20)
        Me.txtStentSerial.TabIndex = 7
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(572, 13)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(67, 23)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(505, 13)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(67, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        '
        'dgDrugFormulation
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan
        Me.dgDrugFormulation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgDrugFormulation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDrugFormulation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDrugFormulation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgDrugFormulation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDrugFormulation.Location = New System.Drawing.Point(20, 234)
        Me.dgDrugFormulation.Name = "dgDrugFormulation"
        Me.dgDrugFormulation.Size = New System.Drawing.Size(643, 228)
        Me.dgDrugFormulation.TabIndex = 138
        '
        'FrmDrugFormulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 572)
        Me.Controls.Add(Me.dgDrugFormulation)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDrugFormulation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Drug Formulation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgDrugFormulation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBatch As System.Windows.Forms.TextBox
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents txtWoNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents txtStentLength As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtVialNo As System.Windows.Forms.TextBox
    Friend WithEvents ddlAMPC As System.Windows.Forms.ComboBox
    Friend WithEvents txtFormulationVolume As System.Windows.Forms.TextBox
    Friend WithEvents txtUVDose As System.Windows.Forms.TextBox
    Friend WithEvents txtStentSerial As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents ddlFormulationBatch As System.Windows.Forms.ComboBox
    Friend WithEvents dgDrugFormulation As System.Windows.Forms.DataGridView
End Class
