<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStentWeight
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
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtStentSerialNo = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.chkPreCoat = New System.Windows.Forms.CheckBox
        Me.chkPostCoat = New System.Windows.Forms.CheckBox
        Me.chk15MinsCheck = New System.Windows.Forms.CheckBox
        Me.dgStentWeights = New System.Windows.Forms.DataGridView
        CType(Me.dgStentWeights, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(709, 23)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(125, 25)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 24)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "WO No / Stent Serial No"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStentSerialNo
        '
        Me.txtStentSerialNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStentSerialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStentSerialNo.Location = New System.Drawing.Point(196, 24)
        Me.txtStentSerialNo.MaxLength = 16
        Me.txtStentSerialNo.Name = "txtStentSerialNo"
        Me.txtStentSerialNo.Size = New System.Drawing.Size(153, 22)
        Me.txtStentSerialNo.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(498, 343)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(125, 25)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(356, 343)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(125, 25)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        '
        'chkPreCoat
        '
        Me.chkPreCoat.AutoSize = True
        Me.chkPreCoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPreCoat.Location = New System.Drawing.Point(370, 26)
        Me.chkPreCoat.Name = "chkPreCoat"
        Me.chkPreCoat.Size = New System.Drawing.Size(90, 21)
        Me.chkPreCoat.TabIndex = 2
        Me.chkPreCoat.Text = "Pre Coat"
        Me.chkPreCoat.UseVisualStyleBackColor = True
        '
        'chkPostCoat
        '
        Me.chkPostCoat.AutoSize = True
        Me.chkPostCoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPostCoat.Location = New System.Drawing.Point(604, 26)
        Me.chkPostCoat.Name = "chkPostCoat"
        Me.chkPostCoat.Size = New System.Drawing.Size(97, 21)
        Me.chkPostCoat.TabIndex = 4
        Me.chkPostCoat.Text = "Post Coat"
        Me.chkPostCoat.UseVisualStyleBackColor = True
        '
        'chk15MinsCheck
        '
        Me.chk15MinsCheck.AutoSize = True
        Me.chk15MinsCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk15MinsCheck.Location = New System.Drawing.Point(466, 26)
        Me.chk15MinsCheck.Name = "chk15MinsCheck"
        Me.chk15MinsCheck.Size = New System.Drawing.Size(132, 21)
        Me.chk15MinsCheck.TabIndex = 3
        Me.chk15MinsCheck.Text = "15 Mins Check"
        Me.chk15MinsCheck.UseVisualStyleBackColor = True
        '
        'dgStentWeights
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan
        Me.dgStentWeights.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgStentWeights.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgStentWeights.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgStentWeights.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgStentWeights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStentWeights.Location = New System.Drawing.Point(17, 60)
        Me.dgStentWeights.Name = "dgStentWeights"
        Me.dgStentWeights.Size = New System.Drawing.Size(894, 271)
        Me.dgStentWeights.TabIndex = 139
        '
        'FrmStentWeight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 381)
        Me.Controls.Add(Me.dgStentWeights)
        Me.Controls.Add(Me.chk15MinsCheck)
        Me.Controls.Add(Me.chkPostCoat)
        Me.Controls.Add(Me.chkPreCoat)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtStentSerialNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmStentWeight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stent Weights"
        CType(Me.dgStentWeights, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStentSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents chkPreCoat As System.Windows.Forms.CheckBox
    Friend WithEvents chkPostCoat As System.Windows.Forms.CheckBox
    Friend WithEvents chk15MinsCheck As System.Windows.Forms.CheckBox
    Friend WithEvents dgStentWeights As System.Windows.Forms.DataGridView
End Class
