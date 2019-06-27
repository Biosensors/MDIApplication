<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OprnByStatus
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
        Me.btnclose = New System.Windows.Forms.Button
        Me.lblProgress = New System.Windows.Forms.Label
        Me.dgSerial = New System.Windows.Forms.DataGridView
        Me.lblStatus = New System.Windows.Forms.Label
        Me.lblIC = New System.Windows.Forms.Label
        Me.lblBN = New System.Windows.Forms.Label
        Me.lblWO = New System.Windows.Forms.Label
        Me.cmbOperation = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtstatus = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtEnter = New System.Windows.Forms.TextBox
        Me.lblserialNo = New System.Windows.Forms.Label
        Me.lblItemcode = New System.Windows.Forms.Label
        Me.lblBatchNo = New System.Windows.Forms.Label
        Me.lblWono = New System.Windows.Forms.Label
        CType(Me.dgSerial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnclose.Location = New System.Drawing.Point(304, 472)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(125, 25)
        Me.btnclose.TabIndex = 10
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'lblProgress
        '
        Me.lblProgress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblProgress.ForeColor = System.Drawing.Color.Red
        Me.lblProgress.Location = New System.Drawing.Point(43, 474)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(234, 17)
        Me.lblProgress.TabIndex = 26
        Me.lblProgress.Text = "Retrieving Data in Progress....."
        Me.lblProgress.Visible = False
        '
        'dgSerial
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.dgSerial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSerial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgSerial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSerial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgSerial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSerial.Location = New System.Drawing.Point(26, 152)
        Me.dgSerial.Name = "dgSerial"
        Me.dgSerial.Size = New System.Drawing.Size(649, 300)
        Me.dgSerial.TabIndex = 153
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(401, 29)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 18)
        Me.lblStatus.TabIndex = 143
        '
        'lblIC
        '
        Me.lblIC.AutoSize = True
        Me.lblIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIC.Location = New System.Drawing.Point(166, 83)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(0, 18)
        Me.lblIC.TabIndex = 142
        '
        'lblBN
        '
        Me.lblBN.AutoSize = True
        Me.lblBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBN.Location = New System.Drawing.Point(166, 56)
        Me.lblBN.Name = "lblBN"
        Me.lblBN.Size = New System.Drawing.Size(0, 18)
        Me.lblBN.TabIndex = 141
        '
        'lblWO
        '
        Me.lblWO.AutoSize = True
        Me.lblWO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWO.Location = New System.Drawing.Point(166, 27)
        Me.lblWO.Name = "lblWO"
        Me.lblWO.Size = New System.Drawing.Size(0, 18)
        Me.lblWO.TabIndex = 140
        '
        'cmbOperation
        '
        Me.cmbOperation.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperation.FormattingEnabled = True
        Me.cmbOperation.Location = New System.Drawing.Point(162, 109)
        Me.cmbOperation.Name = "cmbOperation"
        Me.cmbOperation.Size = New System.Drawing.Size(128, 24)
        Me.cmbOperation.TabIndex = 145
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Operation"
        '
        'txtstatus
        '
        Me.txtstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstatus.Location = New System.Drawing.Point(334, 79)
        Me.txtstatus.MaxLength = 5
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(67, 22)
        Me.txtstatus.TabIndex = 144
        Me.txtstatus.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(533, 109)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(125, 25)
        Me.btnSearch.TabIndex = 147
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtEnter
        '
        Me.txtEnter.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnter.Location = New System.Drawing.Point(399, 110)
        Me.txtEnter.MaxLength = 20
        Me.txtEnter.Name = "txtEnter"
        Me.txtEnter.Size = New System.Drawing.Size(120, 22)
        Me.txtEnter.TabIndex = 146
        '
        'lblserialNo
        '
        Me.lblserialNo.AutoSize = True
        Me.lblserialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblserialNo.Location = New System.Drawing.Point(318, 112)
        Me.lblserialNo.Name = "lblserialNo"
        Me.lblserialNo.Size = New System.Drawing.Size(78, 18)
        Me.lblserialNo.TabIndex = 152
        Me.lblserialNo.Text = "Serial No"
        '
        'lblItemcode
        '
        Me.lblItemcode.AutoSize = True
        Me.lblItemcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemcode.Location = New System.Drawing.Point(67, 83)
        Me.lblItemcode.Name = "lblItemcode"
        Me.lblItemcode.Size = New System.Drawing.Size(85, 18)
        Me.lblItemcode.TabIndex = 150
        Me.lblItemcode.Text = "Item Code"
        '
        'lblBatchNo
        '
        Me.lblBatchNo.AutoSize = True
        Me.lblBatchNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatchNo.Location = New System.Drawing.Point(73, 54)
        Me.lblBatchNo.Name = "lblBatchNo"
        Me.lblBatchNo.Size = New System.Drawing.Size(78, 18)
        Me.lblBatchNo.TabIndex = 149
        Me.lblBatchNo.Text = "Batch No"
        '
        'lblWono
        '
        Me.lblWono.AutoSize = True
        Me.lblWono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWono.Location = New System.Drawing.Point(33, 25)
        Me.lblWono.Name = "lblWono"
        Me.lblWono.Size = New System.Drawing.Size(119, 18)
        Me.lblWono.TabIndex = 148
        Me.lblWono.Text = "WorkOrder No"
        '
        'OprnByStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 516)
        Me.Controls.Add(Me.dgSerial)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblIC)
        Me.Controls.Add(Me.lblBN)
        Me.Controls.Add(Me.lblWO)
        Me.Controls.Add(Me.cmbOperation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtEnter)
        Me.Controls.Add(Me.lblserialNo)
        Me.Controls.Add(Me.lblItemcode)
        Me.Controls.Add(Me.lblBatchNo)
        Me.Controls.Add(Me.lblWono)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.btnclose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "OprnByStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operation By Work Order "
        CType(Me.dgSerial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents dgSerial As System.Windows.Forms.DataGridView
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblIC As System.Windows.Forms.Label
    Friend WithEvents lblBN As System.Windows.Forms.Label
    Friend WithEvents lblWO As System.Windows.Forms.Label
    Friend WithEvents cmbOperation As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtEnter As System.Windows.Forms.TextBox
    Friend WithEvents lblserialNo As System.Windows.Forms.Label
    Friend WithEvents lblItemcode As System.Windows.Forms.Label
    Friend WithEvents lblBatchNo As System.Windows.Forms.Label
    Friend WithEvents lblWono As System.Windows.Forms.Label
End Class
