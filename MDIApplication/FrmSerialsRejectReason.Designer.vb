<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSerialRejectReason
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
        Me.lboxReasons = New System.Windows.Forms.ListBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnReject = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtStentSerial = New System.Windows.Forms.TextBox
        Me.lblRejectionType = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lboxReasons
        '
        Me.lboxReasons.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lboxReasons.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxReasons.FormattingEnabled = True
        Me.lboxReasons.ItemHeight = 20
        Me.lboxReasons.Location = New System.Drawing.Point(27, 64)
        Me.lboxReasons.Name = "lboxReasons"
        Me.lboxReasons.Size = New System.Drawing.Size(262, 164)
        Me.lboxReasons.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(190, 284)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 25)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        '
        'btnReject
        '
        Me.btnReject.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReject.Location = New System.Drawing.Point(102, 284)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(75, 25)
        Me.btnReject.TabIndex = 3
        Me.btnReject.Text = "Reject"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lboxReasons)
        Me.GroupBox1.Controls.Add(Me.txtStentSerial)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 250)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 24)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Stent Serial"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStentSerial
        '
        Me.txtStentSerial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStentSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStentSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStentSerial.Location = New System.Drawing.Point(121, 26)
        Me.txtStentSerial.MaxLength = 12
        Me.txtStentSerial.Name = "txtStentSerial"
        Me.txtStentSerial.ReadOnly = True
        Me.txtStentSerial.Size = New System.Drawing.Size(168, 22)
        Me.txtStentSerial.TabIndex = 1
        '
        'lblRejectionType
        '
        Me.lblRejectionType.AutoSize = True
        Me.lblRejectionType.Location = New System.Drawing.Point(274, 290)
        Me.lblRejectionType.Name = "lblRejectionType"
        Me.lblRejectionType.Size = New System.Drawing.Size(86, 13)
        Me.lblRejectionType.TabIndex = 106
        Me.lblRejectionType.Text = "lblRejectionType"
        Me.lblRejectionType.Visible = False
        '
        'FrmSerialRejectReason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 328)
        Me.Controls.Add(Me.lblRejectionType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReject)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmSerialRejectReason"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serial Reject Reason"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lboxReasons As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnReject As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStentSerial As System.Windows.Forms.TextBox
    Friend WithEvents lblRejectionType As System.Windows.Forms.Label
End Class
