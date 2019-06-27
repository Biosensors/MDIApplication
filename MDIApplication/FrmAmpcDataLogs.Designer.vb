<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAmpcDataLogs
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
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtBatchNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNoAmpcCoating = New System.Windows.Forms.TextBox
        Me.txtInvalidStentSerials = New System.Windows.Forms.TextBox
        Me.txtDuplicateStentSerials = New System.Windows.Forms.TextBox
        Me.gbworkorder = New System.Windows.Forms.GroupBox
        Me.btnDuplicateStentSerials = New System.Windows.Forms.Button
        Me.btnInvalidStentSerials = New System.Windows.Forms.Button
        Me.btnNoAmpcCoating = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.gbworkorder.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(204, 231)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 25)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(275, 17)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 24)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        '
        'txtBatchNo
        '
        Me.txtBatchNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBatchNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatchNo.Location = New System.Drawing.Point(111, 18)
        Me.txtBatchNo.MaxLength = 16
        Me.txtBatchNo.Name = "txtBatchNo"
        Me.txtBatchNo.Size = New System.Drawing.Size(158, 23)
        Me.txtBatchNo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(26, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 17)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "No AMPC Coating"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 17)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Invalid Stent Serials"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(28, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Duplicate Stent Serials"
        '
        'txtNoAmpcCoating
        '
        Me.txtNoAmpcCoating.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoAmpcCoating.Location = New System.Drawing.Point(210, 34)
        Me.txtNoAmpcCoating.MaxLength = 16
        Me.txtNoAmpcCoating.Name = "txtNoAmpcCoating"
        Me.txtNoAmpcCoating.ReadOnly = True
        Me.txtNoAmpcCoating.Size = New System.Drawing.Size(111, 23)
        Me.txtNoAmpcCoating.TabIndex = 45
        '
        'txtInvalidStentSerials
        '
        Me.txtInvalidStentSerials.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvalidStentSerials.Location = New System.Drawing.Point(210, 76)
        Me.txtInvalidStentSerials.MaxLength = 16
        Me.txtInvalidStentSerials.Name = "txtInvalidStentSerials"
        Me.txtInvalidStentSerials.ReadOnly = True
        Me.txtInvalidStentSerials.Size = New System.Drawing.Size(111, 23)
        Me.txtInvalidStentSerials.TabIndex = 46
        '
        'txtDuplicateStentSerials
        '
        Me.txtDuplicateStentSerials.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuplicateStentSerials.Location = New System.Drawing.Point(210, 117)
        Me.txtDuplicateStentSerials.MaxLength = 16
        Me.txtDuplicateStentSerials.Name = "txtDuplicateStentSerials"
        Me.txtDuplicateStentSerials.ReadOnly = True
        Me.txtDuplicateStentSerials.Size = New System.Drawing.Size(111, 23)
        Me.txtDuplicateStentSerials.TabIndex = 47
        '
        'gbworkorder
        '
        Me.gbworkorder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbworkorder.Controls.Add(Me.btnDuplicateStentSerials)
        Me.gbworkorder.Controls.Add(Me.btnInvalidStentSerials)
        Me.gbworkorder.Controls.Add(Me.btnNoAmpcCoating)
        Me.gbworkorder.Controls.Add(Me.Label1)
        Me.gbworkorder.Controls.Add(Me.txtDuplicateStentSerials)
        Me.gbworkorder.Controls.Add(Me.Label2)
        Me.gbworkorder.Controls.Add(Me.txtInvalidStentSerials)
        Me.gbworkorder.Controls.Add(Me.Label3)
        Me.gbworkorder.Controls.Add(Me.txtNoAmpcCoating)
        Me.gbworkorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbworkorder.ForeColor = System.Drawing.Color.Black
        Me.gbworkorder.Location = New System.Drawing.Point(23, 59)
        Me.gbworkorder.Name = "gbworkorder"
        Me.gbworkorder.Size = New System.Drawing.Size(462, 162)
        Me.gbworkorder.TabIndex = 62
        Me.gbworkorder.TabStop = False
        Me.gbworkorder.Text = "Total Numbers"
        '
        'btnDuplicateStentSerials
        '
        Me.btnDuplicateStentSerials.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDuplicateStentSerials.Location = New System.Drawing.Point(340, 117)
        Me.btnDuplicateStentSerials.Name = "btnDuplicateStentSerials"
        Me.btnDuplicateStentSerials.Size = New System.Drawing.Size(90, 24)
        Me.btnDuplicateStentSerials.TabIndex = 65
        Me.btnDuplicateStentSerials.Text = "View"
        '
        'btnInvalidStentSerials
        '
        Me.btnInvalidStentSerials.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvalidStentSerials.Location = New System.Drawing.Point(340, 76)
        Me.btnInvalidStentSerials.Name = "btnInvalidStentSerials"
        Me.btnInvalidStentSerials.Size = New System.Drawing.Size(90, 24)
        Me.btnInvalidStentSerials.TabIndex = 64
        Me.btnInvalidStentSerials.Text = "View"
        '
        'btnNoAmpcCoating
        '
        Me.btnNoAmpcCoating.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNoAmpcCoating.Location = New System.Drawing.Point(340, 33)
        Me.btnNoAmpcCoating.Name = "btnNoAmpcCoating"
        Me.btnNoAmpcCoating.Size = New System.Drawing.Size(90, 24)
        Me.btnNoAmpcCoating.TabIndex = 63
        Me.btnNoAmpcCoating.Text = "View"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(29, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Batch No"
        '
        'FrmAmpcDataLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 264)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbworkorder)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtBatchNo)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmAmpcDataLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AMPC Electronic Sheet Logs"
        Me.gbworkorder.ResumeLayout(False)
        Me.gbworkorder.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtBatchNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNoAmpcCoating As System.Windows.Forms.TextBox
    Friend WithEvents txtInvalidStentSerials As System.Windows.Forms.TextBox
    Friend WithEvents txtDuplicateStentSerials As System.Windows.Forms.TextBox
    Friend WithEvents gbworkorder As System.Windows.Forms.GroupBox
    Friend WithEvents btnDuplicateStentSerials As System.Windows.Forms.Button
    Friend WithEvents btnInvalidStentSerials As System.Windows.Forms.Button
    Friend WithEvents btnNoAmpcCoating As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
