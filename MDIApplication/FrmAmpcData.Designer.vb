<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAmpcData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAmpcData))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtWONo = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnViewCoatingData = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.rbtnPostDry = New System.Windows.Forms.RadioButton
        Me.rbtn15Mins = New System.Windows.Forms.RadioButton
        Me.dgAMPCData = New System.Windows.Forms.DataGridView
        CType(Me.dgAMPCData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtWONo
        '
        resources.ApplyResources(Me.txtWONo, "txtWONo")
        Me.txtWONo.Name = "txtWONo"
        '
        'btnSearch
        '
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.Name = "btnSearch"
        '
        'btnClose
        '
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.Name = "btnClose"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'btnViewCoatingData
        '
        resources.ApplyResources(Me.btnViewCoatingData, "btnViewCoatingData")
        Me.btnViewCoatingData.Name = "btnViewCoatingData"
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.Name = "btnAdd"
        '
        'rbtnPostDry
        '
        resources.ApplyResources(Me.rbtnPostDry, "rbtnPostDry")
        Me.rbtnPostDry.Name = "rbtnPostDry"
        Me.rbtnPostDry.TabStop = True
        Me.rbtnPostDry.UseVisualStyleBackColor = True
        '
        'rbtn15Mins
        '
        resources.ApplyResources(Me.rbtn15Mins, "rbtn15Mins")
        Me.rbtn15Mins.Name = "rbtn15Mins"
        Me.rbtn15Mins.TabStop = True
        Me.rbtn15Mins.UseVisualStyleBackColor = True
        '
        'dgAMPCData
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.dgAMPCData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.dgAMPCData, "dgAMPCData")
        Me.dgAMPCData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgAMPCData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgAMPCData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAMPCData.Name = "dgAMPCData"
        '
        'FrmAmpcData
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rbtn15Mins)
        Me.Controls.Add(Me.rbtnPostDry)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnViewCoatingData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgAMPCData)
        Me.Controls.Add(Me.txtWONo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAmpcData"
        CType(Me.dgAMPCData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtWONo As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnViewCoatingData As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents rbtnPostDry As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn15Mins As System.Windows.Forms.RadioButton
    Friend WithEvents dgAMPCData As System.Windows.Forms.DataGridView
End Class
