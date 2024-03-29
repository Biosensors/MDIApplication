Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Configuration
Imports System.DirectoryServices
Imports System.Text
Imports System.Text.StringBuilder
Imports MDIApplication.BioTrackMain
Imports MDIApplication.IniFileFunctions

Public Class WorkOrder
    Inherits System.Windows.Forms.Form
    Public uid As String = sLogonUser
    Public wstatus As Integer
    Public st As String
    Private sstatus As String
    Public nme As String
    Public sOprn As String
    Public sOprnDsca As String
    Public rType As String
    Public nCurOprn As Integer
    Public sTObeRejectSrNo As String
    Public sTobeUndoSrNo As String
    Public dtAccepted, dtRejected As DataTable

    ' Public w As New workorder
    ' Public o As New Operations
    Public db As New Class1
    Friend WithEvents txtOprn As System.Windows.Forms.TextBox
    Friend WithEvents btnreject As System.Windows.Forms.Button
    Friend WithEvents grbxQty As System.Windows.Forms.GroupBox
    Friend WithEvents txtbal As System.Windows.Forms.TextBox
    Friend WithEvents txtreject As System.Windows.Forms.TextBox
    Friend WithEvents txtaccept As System.Windows.Forms.TextBox
    Friend WithEvents lblaccept As System.Windows.Forms.Label
    Friend WithEvents lblbal As System.Windows.Forms.Label
    Friend WithEvents lblreject As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnundo As System.Windows.Forms.Button
    Friend WithEvents txtwoqty As System.Windows.Forms.TextBox
    Friend WithEvents dgaccpt As System.Windows.Forms.DataGridView
    Friend WithEvents dgrej As System.Windows.Forms.DataGridView
    Private Gstatus As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbworkorder As System.Windows.Forms.GroupBox
    Friend WithEvents txtwrkordno As System.Windows.Forms.TextBox
    Friend WithEvents txtitmcode As System.Windows.Forms.TextBox
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtqnty As System.Windows.Forms.TextBox
    Friend WithEvents tbcathet As System.Windows.Forms.TabControl
    Friend WithEvents txtsrno1 As System.Windows.Forms.TextBox
    Friend WithEvents txtsrno2 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txterror As System.Windows.Forms.Button
    Friend WithEvents btnscan As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnuser As System.Windows.Forms.Button
    Friend WithEvents btnrej As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnChpass As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorkOrder))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.gbworkorder = New System.Windows.Forms.GroupBox
        Me.txtwoqty = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtOprn = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtdesc = New System.Windows.Forms.TextBox
        Me.txtitmcode = New System.Windows.Forms.TextBox
        Me.grbxQty = New System.Windows.Forms.GroupBox
        Me.lblbal = New System.Windows.Forms.Label
        Me.lblreject = New System.Windows.Forms.Label
        Me.lblaccept = New System.Windows.Forms.Label
        Me.txtbal = New System.Windows.Forms.TextBox
        Me.txtreject = New System.Windows.Forms.TextBox
        Me.txtaccept = New System.Windows.Forms.TextBox
        Me.txtqnty = New System.Windows.Forms.TextBox
        Me.txtwrkordno = New System.Windows.Forms.TextBox
        Me.tbcathet = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dgaccpt = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.dgrej = New System.Windows.Forms.DataGridView
        Me.txtsrno1 = New System.Windows.Forms.TextBox
        Me.txtsrno2 = New System.Windows.Forms.TextBox
        Me.btnuser = New System.Windows.Forms.Button
        Me.btnrej = New System.Windows.Forms.Button
        Me.txterror = New System.Windows.Forms.Button
        Me.btnscan = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnChpass = New System.Windows.Forms.Button
        Me.btnreject = New System.Windows.Forms.Button
        Me.btnundo = New System.Windows.Forms.Button
        Me.gbworkorder.SuspendLayout()
        Me.grbxQty.SuspendLayout()
        Me.tbcathet.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgaccpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgrej, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Work Order"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Item Code"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Description"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Total"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbworkorder
        '
        Me.gbworkorder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbworkorder.Controls.Add(Me.txtwoqty)
        Me.gbworkorder.Controls.Add(Me.Label6)
        Me.gbworkorder.Controls.Add(Me.txtOprn)
        Me.gbworkorder.Controls.Add(Me.Label5)
        Me.gbworkorder.Controls.Add(Me.Label1)
        Me.gbworkorder.Controls.Add(Me.Label2)
        Me.gbworkorder.Controls.Add(Me.Label3)
        Me.gbworkorder.Controls.Add(Me.txtdesc)
        Me.gbworkorder.Controls.Add(Me.txtitmcode)
        Me.gbworkorder.Controls.Add(Me.grbxQty)
        Me.gbworkorder.Controls.Add(Me.txtwrkordno)
        Me.gbworkorder.Location = New System.Drawing.Point(22, 17)
        Me.gbworkorder.Name = "gbworkorder"
        Me.gbworkorder.Size = New System.Drawing.Size(517, 215)
        Me.gbworkorder.TabIndex = 100
        Me.gbworkorder.TabStop = False
        '
        'txtwoqty
        '
        Me.txtwoqty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtwoqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwoqty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtwoqty.Location = New System.Drawing.Point(292, 48)
        Me.txtwoqty.Name = "txtwoqty"
        Me.txtwoqty.ReadOnly = True
        Me.txtwoqty.Size = New System.Drawing.Size(76, 22)
        Me.txtwoqty.TabIndex = 3
        Me.txtwoqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 23)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Quantity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOprn
        '
        Me.txtOprn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOprn.ForeColor = System.Drawing.Color.Blue
        Me.txtOprn.Location = New System.Drawing.Point(112, 110)
        Me.txtOprn.Name = "txtOprn"
        Me.txtOprn.ReadOnly = True
        Me.txtOprn.Size = New System.Drawing.Size(256, 26)
        Me.txtOprn.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Operation"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtdesc
        '
        Me.txtdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(112, 79)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.ReadOnly = True
        Me.txtdesc.Size = New System.Drawing.Size(256, 22)
        Me.txtdesc.TabIndex = 4
        '
        'txtitmcode
        '
        Me.txtitmcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitmcode.Location = New System.Drawing.Point(112, 48)
        Me.txtitmcode.Name = "txtitmcode"
        Me.txtitmcode.ReadOnly = True
        Me.txtitmcode.Size = New System.Drawing.Size(174, 22)
        Me.txtitmcode.TabIndex = 2
        '
        'grbxQty
        '
        Me.grbxQty.Controls.Add(Me.lblbal)
        Me.grbxQty.Controls.Add(Me.lblreject)
        Me.grbxQty.Controls.Add(Me.lblaccept)
        Me.grbxQty.Controls.Add(Me.txtbal)
        Me.grbxQty.Controls.Add(Me.txtreject)
        Me.grbxQty.Controls.Add(Me.txtaccept)
        Me.grbxQty.Controls.Add(Me.txtqnty)
        Me.grbxQty.Controls.Add(Me.Label4)
        Me.grbxQty.Location = New System.Drawing.Point(113, 139)
        Me.grbxQty.Name = "grbxQty"
        Me.grbxQty.Size = New System.Drawing.Size(394, 65)
        Me.grbxQty.TabIndex = 102
        Me.grbxQty.TabStop = False
        Me.grbxQty.Tag = ""
        '
        'lblbal
        '
        Me.lblbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblbal.Location = New System.Drawing.Point(291, 11)
        Me.lblbal.Name = "lblbal"
        Me.lblbal.Size = New System.Drawing.Size(71, 23)
        Me.lblbal.TabIndex = 93
        Me.lblbal.Text = "Balance"
        Me.lblbal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblreject
        '
        Me.lblreject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblreject.Location = New System.Drawing.Point(193, 10)
        Me.lblreject.Name = "lblreject"
        Me.lblreject.Size = New System.Drawing.Size(83, 23)
        Me.lblreject.TabIndex = 92
        Me.lblreject.Text = "Rejected"
        Me.lblreject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblaccept
        '
        Me.lblaccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblaccept.Location = New System.Drawing.Point(105, 10)
        Me.lblaccept.Name = "lblaccept"
        Me.lblaccept.Size = New System.Drawing.Size(83, 23)
        Me.lblaccept.TabIndex = 91
        Me.lblaccept.Text = "Accepted"
        Me.lblaccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbal
        '
        Me.txtbal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtbal.Location = New System.Drawing.Point(297, 35)
        Me.txtbal.Name = "txtbal"
        Me.txtbal.ReadOnly = True
        Me.txtbal.Size = New System.Drawing.Size(80, 22)
        Me.txtbal.TabIndex = 9
        Me.txtbal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtreject
        '
        Me.txtreject.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtreject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtreject.Location = New System.Drawing.Point(202, 35)
        Me.txtreject.Name = "txtreject"
        Me.txtreject.ReadOnly = True
        Me.txtreject.Size = New System.Drawing.Size(80, 22)
        Me.txtreject.TabIndex = 8
        Me.txtreject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtaccept
        '
        Me.txtaccept.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaccept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtaccept.Location = New System.Drawing.Point(110, 35)
        Me.txtaccept.Name = "txtaccept"
        Me.txtaccept.ReadOnly = True
        Me.txtaccept.Size = New System.Drawing.Size(80, 22)
        Me.txtaccept.TabIndex = 7
        Me.txtaccept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtqnty
        '
        Me.txtqnty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqnty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtqnty.Location = New System.Drawing.Point(17, 35)
        Me.txtqnty.Name = "txtqnty"
        Me.txtqnty.ReadOnly = True
        Me.txtqnty.Size = New System.Drawing.Size(80, 22)
        Me.txtqnty.TabIndex = 6
        Me.txtqnty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtwrkordno
        '
        Me.txtwrkordno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtwrkordno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtwrkordno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwrkordno.Location = New System.Drawing.Point(112, 19)
        Me.txtwrkordno.MaxLength = 12
        Me.txtwrkordno.Name = "txtwrkordno"
        Me.txtwrkordno.Size = New System.Drawing.Size(174, 22)
        Me.txtwrkordno.TabIndex = 1
        '
        'tbcathet
        '
        Me.tbcathet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbcathet.Controls.Add(Me.TabPage1)
        Me.tbcathet.Controls.Add(Me.TabPage2)
        Me.tbcathet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbcathet.Location = New System.Drawing.Point(22, 242)
        Me.tbcathet.Name = "tbcathet"
        Me.tbcathet.SelectedIndex = 0
        Me.tbcathet.Size = New System.Drawing.Size(720, 309)
        Me.tbcathet.TabIndex = 73
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.PaleGreen
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.dgaccpt)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.ImageIndex = CType(configurationAppSettings.GetValue("TabPage1.ImageIndex", GetType(Integer)), Integer)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(712, 280)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Accepted"
        '
        'dgaccpt
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.dgaccpt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgaccpt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgaccpt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgaccpt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgaccpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgaccpt.Location = New System.Drawing.Point(9, 8)
        Me.dgaccpt.Name = "dgaccpt"
        Me.dgaccpt.Size = New System.Drawing.Size(693, 262)
        Me.dgaccpt.TabIndex = 139
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Coral
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.dgrej)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.ForeColor = System.Drawing.Color.Black
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(712, 280)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rejected"
        '
        'dgrej
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan
        Me.dgrej.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgrej.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgrej.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrej.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgrej.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrej.Location = New System.Drawing.Point(8, 8)
        Me.dgrej.Name = "dgrej"
        Me.dgrej.Size = New System.Drawing.Size(693, 262)
        Me.dgrej.TabIndex = 140
        '
        'txtsrno1
        '
        Me.txtsrno1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsrno1.BackColor = System.Drawing.SystemColors.Window
        Me.txtsrno1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsrno1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtsrno1.Location = New System.Drawing.Point(143, 563)
        Me.txtsrno1.MaxLength = 20
        Me.txtsrno1.Name = "txtsrno1"
        Me.txtsrno1.Size = New System.Drawing.Size(216, 29)
        Me.txtsrno1.TabIndex = 19
        Me.txtsrno1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsrno2
        '
        Me.txtsrno2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsrno2.BackColor = System.Drawing.SystemColors.Window
        Me.txtsrno2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsrno2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtsrno2.Location = New System.Drawing.Point(371, 563)
        Me.txtsrno2.MaxLength = 20
        Me.txtsrno2.Name = "txtsrno2"
        Me.txtsrno2.Size = New System.Drawing.Size(216, 29)
        Me.txtsrno2.TabIndex = 20
        Me.txtsrno2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnuser
        '
        Me.btnuser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuser.Location = New System.Drawing.Point(555, 53)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(128, 23)
        Me.btnuser.TabIndex = 11
        Me.btnuser.Text = "&User"
        Me.btnuser.Visible = False
        '
        'btnrej
        '
        Me.btnrej.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnrej.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrej.Location = New System.Drawing.Point(555, 83)
        Me.btnrej.Name = "btnrej"
        Me.btnrej.Size = New System.Drawing.Size(128, 23)
        Me.btnrej.TabIndex = 12
        Me.btnrej.Text = "Reason  &Code"
        Me.btnrej.Visible = False
        '
        'txterror
        '
        Me.txterror.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txterror.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txterror.ForeColor = System.Drawing.Color.Red
        Me.txterror.Location = New System.Drawing.Point(30, 604)
        Me.txterror.Name = "txterror"
        Me.txterror.Size = New System.Drawing.Size(664, 23)
        Me.txterror.TabIndex = 21
        '
        'btnscan
        '
        Me.btnscan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnscan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnscan.ForeColor = System.Drawing.Color.Red
        Me.btnscan.Location = New System.Drawing.Point(555, 143)
        Me.btnscan.Name = "btnscan"
        Me.btnscan.Size = New System.Drawing.Size(128, 23)
        Me.btnscan.TabIndex = 14
        Me.btnscan.Text = "Scan(F1)"
        '
        'btnexit
        '
        Me.btnexit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(555, 113)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(128, 23)
        Me.btnexit.TabIndex = 13
        Me.btnexit.Text = "E&xit(Esc)"
        '
        'btnChpass
        '
        Me.btnChpass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnChpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChpass.Location = New System.Drawing.Point(555, 23)
        Me.btnChpass.Name = "btnChpass"
        Me.btnChpass.Size = New System.Drawing.Size(128, 23)
        Me.btnChpass.TabIndex = 10
        Me.btnChpass.Text = "&Change Password"
        Me.btnChpass.Visible = False
        '
        'btnreject
        '
        Me.btnreject.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnreject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreject.ForeColor = System.Drawing.Color.Red
        Me.btnreject.Location = New System.Drawing.Point(555, 173)
        Me.btnreject.Name = "btnreject"
        Me.btnreject.Size = New System.Drawing.Size(128, 25)
        Me.btnreject.TabIndex = 15
        Me.btnreject.Text = "&Reject (F5)"
        '
        'btnundo
        '
        Me.btnundo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnundo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnundo.ForeColor = System.Drawing.Color.Red
        Me.btnundo.Location = New System.Drawing.Point(555, 205)
        Me.btnundo.Name = "btnundo"
        Me.btnundo.Size = New System.Drawing.Size(128, 25)
        Me.btnundo.TabIndex = 16
        Me.btnundo.Text = "&Undo Reject"
        '
        'WorkOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(765, 637)
        Me.Controls.Add(Me.btnundo)
        Me.Controls.Add(Me.btnreject)
        Me.Controls.Add(Me.btnChpass)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnscan)
        Me.Controls.Add(Me.txterror)
        Me.Controls.Add(Me.btnrej)
        Me.Controls.Add(Me.btnuser)
        Me.Controls.Add(Me.txtsrno2)
        Me.Controls.Add(Me.txtsrno1)
        Me.Controls.Add(Me.tbcathet)
        Me.Controls.Add(Me.gbworkorder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "WorkOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BioTrack - Scan Serial Nos"
        Me.gbworkorder.ResumeLayout(False)
        Me.gbworkorder.PerformLayout()
        Me.grbxQty.ResumeLayout(False)
        Me.grbxQty.PerformLayout()
        Me.tbcathet.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgaccpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgrej, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub workorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnuser.Visible = False
        btnrej.Enabled = True
        btnChpass.Visible = False
        btnexit.Enabled = True
        txtsrno1.Enabled = False
        txtsrno2.Enabled = False
        ' rdbcrimping.Checked = True
        txterror.Text = "Press F1 to Scan"

        ' txterror.Hide()
        If Trim(txtsrno1.Text) = "" Then
            txtsrno1.Text = "Catheter"
        End If
        If Trim(txtsrno2.Text) = "" Then
            txtsrno2.Text = "Stent"
        End If
        tbcathet.SelectedIndex = 0
        txtOprn.Text = sOprnDsca
        Gstatus = "A"
        uid = sLogonUser

        Sql = "select rtype from Operations where oprnid = '" & sOprn & "'"
        ds = db.selectQuery(Sql)
        rType = ds.Tables(0).Rows(0).Item(0).ToString

    End Sub

    'Private Sub dgaccpt_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)
    '    MsgBox("Navigate")
    'End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnscan.Click

        Sql = "select rtype from Operations where oprnid = '" & sOprn & "'"
        ds = db.selectQuery(Sql)
        rType = ds.Tables(0).Rows(0).Item(0).ToString

        'tbcathet.SelectedIndex = 0
        If tbcathet.SelectedIndex = 0 Then
            Gstatus = "A"
        Else
            Gstatus = "R"
        End If
        If btnscan.Text = "Scan(F1)" Then
            scan()
        ElseIf btnscan.Text = "Stop(F4)" Then
            stopscan()
        End If

    End Sub

    Private Function scan()

        If ValidateWorkOrder() Then
            txtwrkordno.Enabled = False
            txtsrno1.Enabled = True
            txtsrno2.Enabled = True
            btnscan.Text = "Stop(F4)"
            txterror.Text = "Press F4 to Stop Scanning"
            btnuser.Enabled = False
            btnrej.Enabled = False
            btnChpass.Enabled = False
            btnexit.Enabled = False
            txtsrno1.Focus()
        Else
            If (txtwrkordno.Text = "") Then
                MsgBox("Work Order No  Should Not Be Empty")
            End If
            txtwrkordno.Focus()
        End If

    End Function

    Private Function stopscan()
        btnuser.Enabled = True
        btnrej.Enabled = True
        btnChpass.Enabled = True
        btnexit.Enabled = True
        If Not txtwrkordno.Text = "" Then
            ValidateWorkOrder()
        End If
        'If btnscan.Text = "Stop(F4)" Then

        txtwrkordno.Enabled = True
        ' rdbcrimping.Enabled = True
        ' rdbsealing.Enabled = True
        ' rdbboxing.Enabled = True
        txtsrno1.Enabled = False
        txtsrno2.Enabled = False
        btnuser.Enabled = True
        btnrej.Enabled = True
        btnChpass.Enabled = True
        btnexit.Enabled = True
        txtsrno1.Clear()
        txtsrno2.Clear()
        txtsrno1.Text = "Catheter"
        txtsrno1.ForeColor = Color.Gray
        txtsrno2.Text = "Stent"
        txtsrno2.ForeColor = Color.Gray
        btnscan.Text = "Scan(F1)"
        txterror.Text = "Press F1 to Scan"
        'End If
        txtwrkordno.Focus()
        'txtsrno1.Focus()

        ' txterror.Hide()
    End Function

    Private Sub txtsrno1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsrno1.GotFocus
        If txtsrno1.Text = "Catheter" Then
            txtsrno1.Clear()
            'txtsrno1.TextAlign = HorizontalAlignment.Center
        End If
        txtsrno1.ForeColor = Color.Black
    End Sub

    Private Sub txtsrno2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsrno2.GotFocus

        'Dim db As New Class1
        Dim ds As New DataSet
        If tbcathet.SelectedIndex = 0 Then
            Gstatus = "A"
        Else
            Gstatus = "R"
        End If

        'nCurOprn = Mid(sOprnDsca, 1, 4)
        If Not (txtsrno1.Text = "" Or txtsrno1.Text = "Catheter") Then
            txterror.Text = "Press F4 to Stop Scanning"
        End If
    End Sub

    Private Sub txtsrno1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsrno1.LostFocus
        If txtsrno1.Text = "" Then
            'txtsrno1.ForeColor = Color.Gray
            'txtsrno1.Text = "Catheter"
        Else
            If ValidateSerialNos() Then
                txtsrno2.Focus()
            Else
                txtsrno1.Focus()
            End If
        End If
    End Sub

    Private Sub txtsrno2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsrno2.LostFocus
        If txtsrno2.Text = "" Then
            txtsrno2.ForeColor = Color.Gray
            txtsrno2.Text = "Stent"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrej.Click

        Sql = "select rtype from Operations where oprnid = '" & sOprn & "'"
        ds = db.selectQuery(Sql)
        rType = ds.Tables(0).Rows(0).Item(0).ToString

        RejectionCode.LoadReasonTypes()
        RejectionCode.cmbReasonTypes.SelectedValue = rType
        RejectionCode.Tag = "S"
        RejectionCode.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim r As New Rejection
        r.Show()
    End Sub

    Private Sub txtsrno1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsrno1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txterror.Text = "Press F4 to Stop Scanning"
            If Not txtsrno1.Text = "" Then
                txtsrno2.Focus()
            End If
        ElseIf e.KeyChar = Chr(Keys.F4) Then
            stopscan()
            e.Handled = True
            txterror.Text = "Press F4 to Stop Scanning"
        End If
    End Sub

    Private Sub txtsrno2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsrno2.KeyPress
        Dim sql As String
        ' Dim db As New Class1
        Dim ds As New DataSet
        Dim cnt As Integer
        Dim bUpdateOk As Boolean

        Dim ds1 As New DataSet
        bUpdateOk = False
        If e.KeyChar = Chr(Keys.Enter) Then
            If Gstatus = "A" Then
                'sql = "select  getdate()"
                'ds = db.selectQuery(sql)
                'Dim dr As DataRow
                'For Each dr In ds.Tables(0).Rows
                'now = ds.Tables(0).Rows(0).Item(0).ToString

                If wstatus = 1 Then
                    If Not txtsrno1.Text = txtsrno2.Text Then
                        bUpdateOk = False
                        'db.PlayWav("E")
                        MsgBox("Serial Numbers Do Not Match !!!", MsgBoxStyle.Critical)
                        insertScanLog(1)
                        txterror.Text = "Serial Numbers Do Not Match"
                        txterror.Show()
                        txtsrno1.Clear()
                        txtsrno2.Clear()
                        'txtsrno1.Text = "Catheter"
                        'txtsrno1.ForeColor = color.gray
                        txtsrno2.Text = "Stent"
                        txtsrno2.ForeColor = Color.Gray
                        txtsrno1.Focus()
                    Else
                        If Not ValidateWorkOrder() Then
                            txtsrno1.Clear()
                            txtsrno2.Clear()
                            txtsrno2.Text = "Stent"
                            txtsrno2.ForeColor = Color.Gray
                            txtsrno1.Focus()
                            bUpdateOk = False
                        Else
                            If ValidateSerialForFG() Then
                                bUpdateOk = True
                            Else
                                MsgBox("Invalid Stent Serial No", MsgBoxStyle.Critical)
                                txtsrno1.Clear()
                                txtsrno2.Clear()
                                txtsrno2.Text = "Stent"
                                txtsrno2.ForeColor = Color.Gray
                                txtsrno1.Focus()
                                bUpdateOk = False
                            End If

                            'bUpdateOk = True
                        End If
                    End If
                End If
                If bUpdateOk Then
                    Try
                        sql = "select count(wono) from OperationLogs where oprn ='" & sOprn & "'  and wono='" & txtwrkordno.Text & "'"
                        ds = db.selectQuery(sql)
                        cnt = ds.Tables(0).Rows(0).Item(0)

                        If txtqnty.Text > cnt Then
                            sql = "insert into OperationLogs(wono,srlno1,srlno2,oprn,status,crby,crdt) values ('" & txtwrkordno.Text & "','" & txtsrno1.Text & "','" & txtsrno2.Text & "','" & sOprn & "',1,'" & uid & "', getdate()) "
                            db.insertQuery(sql)
                        Else
                            MsgBox("Exceeds Total Item quantity")
                            txtsrno1.Clear()
                            txtsrno2.Clear()
                            txtsrno1.Text = "Catheter"
                            txtsrno1.ForeColor = Color.Gray
                            txtsrno2.Text = "Stent"
                            txtsrno2.ForeColor = Color.Gray
                        End If

                    Catch ex As System.Exception
                        MsgBox(ex.Message)
                    End Try
                    Adgrid()
                    Rdgrid()
                    txtsrno1.Clear()
                    txtsrno2.Clear()
                    txtsrno2.Text = "Stent"
                    txtsrno2.ForeColor = Color.Gray
                    txtsrno1.Focus()
                End If
            ElseIf Gstatus = "R" Then
                Dim r As New Rejection
                r.Istatus = "R"
                If Not txtsrno1.Text = txtsrno2.Text Then
                    ' db.PlayWav("E")
                    MsgBox(" Serial Nos. do not Match !!!", MsgBoxStyle.Critical)
                    insertScanLog(1)
                    txterror.Text = "Serial Numbers Do Not Match"
                    txterror.Show()
                    txtsrno1.Clear()
                    txtsrno2.Clear()
                    'txtsrno1.Text = "Catheter"
                    'txtsrno1.ForeColor = color.gray
                    txtsrno2.Text = "Stent"
                    txtsrno2.ForeColor = Color.Gray
                    txtsrno1.Focus()
                Else
                    r.rstatus = sOprn
                    r.txtcath.Text = txtsrno1.Text
                    r.txtst.Text = txtsrno2.Text
                    r.word = txtwrkordno.Text
                    r.txtuid.Text = uid
                    txtsrno1.Clear()
                    txtsrno2.Clear()
                    txtsrno2.Text = "Stent"
                    'txtsrno2.ForeColor = color.gray
                    'txtsrno2.Text = "Catheter"
                    txtsrno2.ForeColor = Color.Gray
                    r.ShowDialog()
                    Adgrid()
                    Rdgrid()
                    txtsrno1.Focus()
                End If
            End If
            e.Handled = True
        End If
    End Sub

    Private Function ValidateSerialForFG() As Boolean
        Sql = "select stntserial from StentsByFG where stntserial = '" & Trim(txtsrno1.Text) & "' and fgwono = '" & Trim(txtwrkordno.Text) & "'"
        ds = db.selectQuery(Sql)
        If ds.Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function Adgrid()
        Try
            Dim sql As String

            ' Dim db As New Class1
            Dim ds As New DataSet
            'If rdbcrimping.Checked = True Then

            sql = "select a.srlno1 as [Serial No], "
            sql = sql & " b.userid as [Scanned By],convert(varchar,a.crdt) as [Scanned Date]"
            sql = sql & " from OperationLogs  a left outer join Users b on a.crby=b.userid"
            sql = sql & " where a.status = 1 and a.oprn= '" & Trim(sOprn) & "' and a.wono='" & txtwrkordno.Text & "'"
            sql = sql & " order by a.crdt desc "
            ds = db.selectQuery(sql)
            dtAccepted = ds.Tables(0)
            dgaccpt.DataSource = dtAccepted

            FormatAcceptedGrid()

            'dgaccpt.DataSource = ds.Tables(0).DefaultView
            'ds = db.selectQuery(sql)
            'dgaccpt.DataSource = ds.Tables(0).DefaultView
            countSrlPrvOprn()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub countSrlPrvOprn()
        Dim PrevOprn As String
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "select top 1 oprnid,opseq from Operations where opseq < (select a.opseq from Operations a where a.oprnid = '" & sOprn & "')"
            sql = sql & " order by opseq desc"

            ds = db.selectQuery(sql)

            If (ds.Tables(0).Rows.Count > 0) Then
                'If (ds.Tables(0).Rows(0).Item("opseq") = 0) Then
                ' txtqnty.Text = GetActualStentQty(txtwrkordno.Text)      'txtwoqty.Text.ToString()
                'Else
                PrevOprn = ds.Tables(0).Rows(0).Item("oprnid").ToString()

                sql = "select count(srlno1) as srlno_qty "
                sql = sql & " from OperationLogs  where status = 1 and oprn= '" & Trim(PrevOprn) & "'"
                sql = sql & "and wono='" & txtwrkordno.Text & "'"

                ds = db.selectQuery(sql)
                If (ds.Tables(0).Rows.Count > 0) Then
                    txtqnty.Text = ds.Tables(0).Rows(0).Item("srlno_qty")
                Else
                    'txtqnty.Text = GetActualStentQty(txtwrkordno.Text)
                    txtqnty.Text = 0
                End If
                'End If
            Else
                txtqnty.Text = GetActualStentQty(txtwrkordno.Text)
                'txtqnty.Text = 0
            End If

        Catch ex As System.Exception

        End Try
    End Sub

    Private Function GetActualStentQty(ByVal sWrkOrder As String) As Double
        GetActualStentQty = 0
        Dim sql As String
        Dim ds As New DataSet
        sql = "select stqty from StentWORef where fgwono = '" & Trim(sWrkOrder) & "'"
        ds = db.selectQuery(sql)

        If (ds.Tables(0).Rows.Count > 0) Then
            GetActualStentQty = (ds.Tables(0).Rows(0).Item("stqty"))
        Else
            GetActualStentQty = 0
        End If
        Return GetActualStentQty
    End Function

    Private Function Rdgrid()
        Dim nTotRec As Integer

        Try
            Dim sql As String
            ' Dim db As New Class1
            Dim ds As New DataSet
            '            If rdbcrimping.Checked = True Then

            sql = "select a.srlno1 as [Serial No], "
            sql = sql & " b.userid as [Rejected By],a.reascd1 as [Reason Code], c.dsca as [Description ],convert(varchar,a.mddt) as [Rejected On]"
            sql = sql & " from OperationLogs  a left outer join Users b on a.mdby=b.userid left outer join Reasons c on  c.rejcd = a.reascd1 "
            sql = sql & " where a.status=0 and a.oprn= '" & Trim(sOprn) & "'  and a.wono='" & txtwrkordno.Text & "'"
            sql = sql & " order by a.mddt desc "

            ds = db.selectQuery(sql)
            dtRejected = ds.Tables(0)
            dgrej.DataSource = dtRejected

            FormatRejectedGrid()

            'dgrej.DataSource = ds.Tables(0).DefaultView
            'ds = db.selectQuery(sql)
            'dgrej.DataSource = ds.Tables(0).DefaultView

            sql = "Select status , count(srlno1) as TotPcs from OperationLogs "
            sql = sql & " where  oprn= '" & Trim(sOprn) & "'  and  wono='" & txtwrkordno.Text & "'"
            sql = sql & " group by status order by status"
            ds = db.selectQuery(sql)
            nTotRec = 1
            txtaccept.Text = 0
            txtreject.Text = 0
            While nTotRec <= ds.Tables(0).Rows.Count
                If ds.Tables(0).Rows(nTotRec - 1).Item("status") = 0 Then
                    txtreject.Text = ds.Tables(0).Rows(nTotRec - 1).Item("TotPcs")
                ElseIf ds.Tables(0).Rows(nTotRec - 1).Item("status") = 1 Then
                    txtaccept.Text = ds.Tables(0).Rows(nTotRec - 1).Item("TotPcs")
                End If
                nTotRec = nTotRec + 1
            End While
            countSrlPrvOprn()
            txtbal.Text = Val(txtqnty.Text) - Val(txtaccept.Text) - Val(txtreject.Text)

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub btnscan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnscan.KeyPress
        If btnscan.Text = "Scan(F1)" Then
            scan()
        ElseIf btnscan.Text = "Stop(F4)" Then
            stopscan()
        End If
    End Sub

    Private Sub txtwrkordno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtwrkordno.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            tbcathet.SelectedIndex = 0
            Gstatus = "A"
            btnscan.Focus()
            'Adgrid()
            'Rdgrid()

            'rdbcrimping.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub tbcathet_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcathet.SelectedIndexChanged
        If tbcathet.SelectedIndex = 0 Then
            Gstatus = "A"
        ElseIf tbcathet.SelectedIndex = 1 Then
            Gstatus = "R"
            btnreject.Enabled = False
        End If
    End Sub

    Private Sub tbcathet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbcathet.KeyPress
        If e.KeyChar = Chr(Keys.F1) Then
            scan()
            e.Handled = True
        ElseIf e.KeyChar = Chr(Keys.F4) Then
            stopscan()
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Escape) Then

            ActiveForm.Close()
            'Operations.Show()

            e.Handled = True
        End If
    End Sub

    Private Sub gbworkorder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gbworkorder.KeyDown
        If e.KeyValue = Keys.F1 Then
            scan()
            e.Handled = True
        ElseIf e.KeyValue = Keys.F4 Then
            stopscan()
            e.Handled = True
        End If
        If e.KeyValue = Keys.Escape Then

            ActiveForm.Close()
            'Operations.Show()

            e.Handled = True
        End If
    End Sub

    Private Sub Button1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnuser.KeyDown
        If e.KeyValue = Keys.F1 Then
            scan()
            e.Handled = True
        ElseIf e.KeyValue = Keys.F4 Then
            stopscan()
            e.Handled = True
        End If
        If e.KeyValue = Keys.Escape Then
            ActiveForm.Close()
            'Operations.Show()

            e.Handled = True
        End If
    End Sub

    Private Sub Button2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnrej.KeyDown
        If e.KeyValue = Keys.F1 Then
            scan()
            e.Handled = True
        ElseIf e.KeyValue = Keys.F4 Then
            stopscan()
            e.Handled = True
        End If
        If e.KeyValue = Keys.Escape Then

            ActiveForm.Close()
            'Operations.Show()

            e.Handled = True
        End If
    End Sub

    Private Sub btnscan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnscan.KeyDown
        If e.KeyValue = Keys.F1 Then
            scan()
            e.Handled = True
        ElseIf e.KeyValue = Keys.F4 Then
            stopscan()
            e.Handled = True
        End If
        If e.KeyValue = Keys.Escape Then

            ActiveForm.Close()
            ' Operations.Show()

            e.Handled = True
        End If
    End Sub

    Private Sub tbcathet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbcathet.KeyDown
        If e.KeyValue = Keys.F1 Then
            scan()
            e.Handled = True
        ElseIf e.KeyValue = Keys.F4 Then
            stopscan()
            e.Handled = True
        End If
        If e.KeyValue = Keys.Escape Then
            ActiveForm.Close()
            'Operations.Show()

            e.Handled = True
        End If
    End Sub

    Private Function Rejection()

        If wstatus = 1 Then

            Try
                Dim sql As String
                Dim r As New Rejection
                ' Dim db As New Class1
                Dim ds As New DataSet
                Dim inc As Integer
                Dim srno As String
                inc = dgaccpt.CurrentRow.Index
                inc = dgaccpt.CurrentRow.Index
                srno = dgaccpt.Item(0, inc).Value

                r.rstatus = sOprn
                sql = "select srlno1 as [Serial No], "
                sql = sql & " srlno2,wono"
                sql = sql & " from OperationLogs where srlno1='" & srno & "'and wono='" & txtwrkordno.Text & "'"
                'dgaccpt.DataSource = ds.Tables(0).DefaultView
                'End If
                ds = db.selectQuery(sql)
                r.txtcath.Text = ds.Tables(0).Rows(0).Item(0)
                r.txtst.Text = ds.Tables(0).Rows(0).Item(1)
                r.wono = ds.Tables(0).Rows(0).Item(2)
                r.txtuid.Text = uid
                r.word = txtwrkordno.Text
                r.status = wstatus
                r.ShowDialog()
                Adgrid()
                Rdgrid()
            Catch ex As System.Exception
                MsgBox(ex.Message)

            End Try
        Else
            MsgBox("User Is Not Active")
        End If

    End Function

    Private Function URejection()

        If wstatus = 1 Then

            Try
                Dim sql As String
                Dim r As New Rejection
                ' Dim db As New Class1
                Dim ds As New DataSet
                Dim inc As Integer

                Dim srno As String
                inc = dgrej.CurrentRow.Index
                inc = dgrej.CurrentRow.Index
                srno = dgrej.Item(0, inc).Value
                r.rstatus = sOprn
                sql = "select srlno1 as [Serial No], "
                sql = sql & " srlno2,wono"
                sql = sql & " from OperationLogs where srlno1='" & srno & "' and wono='" & txtwrkordno.Text & "'"
                ds = db.selectQuery(sql)

                r.txtcath.Text = ds.Tables(0).Rows(0).Item(0)
                r.txtst.Text = ds.Tables(0).Rows(0).Item(1)
                r.wono = ds.Tables(0).Rows(0).Item(2)
                r.word = txtwrkordno.Text
                r.txtuid.Text = uid
                r.status = wstatus
                r.ShowDialog()
                Adgrid()
                Rdgrid()
            Catch ex As System.Exception
                MsgBox(ex.Message)

            End Try
        Else
            MsgBox("User Is Not Active")
        End If
    End Function

    Private Sub txtsrno2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsrno2.KeyDown
        If e.KeyValue = Keys.F1 Then
            scan()
            e.Handled = True
        ElseIf e.KeyValue = Keys.F4 Then
            stopscan()
            e.Handled = True
        End If
        If e.KeyValue = Keys.Escape Then

            ActiveForm.Close()
            ' Operations.Show()

            e.Handled = True
        End If
    End Sub

    Private Sub txtwrkordno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtwrkordno.LostFocus

        If txtwrkordno.Text <> "" Then
            If Not ValidateWorkOrder() Then
                txtwrkordno.Text = ""
                txtwrkordno.Focus()
            End If
        End If

    End Sub

    Private Sub workorder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(Keys.F1) Then
            scan()
            e.Handled = True
        ElseIf e.KeyChar = Chr(Keys.F4) Then
            stopscan()
            e.Handled = True
        ElseIf e.KeyChar = Chr(Keys.Enter) Then
            'if ValidateWorkOrder()then
            btnscan.Focus()
        End If
        If e.KeyChar = Chr(Keys.Escape) Then

            ActiveForm.Close()
            '  Operations.Show()

            e.Handled = True
        End If
    End Sub

    Private Sub txtitmcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtitmcode.KeyPress
        If e.KeyChar = Chr(Keys.F1) Then
            scan()
            e.Handled = True
        ElseIf e.KeyChar = Chr(Keys.F4) Then
            stopscan()
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Escape) Then
            ActiveForm.Close()
            'Operations.Show()

            e.Handled = True
        End If
    End Sub

    Private Sub txtdesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdesc.KeyPress
        If e.KeyChar = Chr(Keys.F1) Then
            scan()
            e.Handled = True
        ElseIf e.KeyChar = Chr(Keys.F4) Then
            stopscan()
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Escape) Then

            ActiveForm.Close()
            ' Operations.Show()

            e.Handled = True
        End If
    End Sub

    Private Sub txtqnty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqnty.KeyPress
        If e.KeyChar = Chr(Keys.F1) Then
            scan()
            e.Handled = True
        ElseIf e.KeyChar = Chr(Keys.F4) Then
            stopscan()
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Escape) Then

            ActiveForm.Close()
            ' Operations.Show()

            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        ActiveForm.Close()
        ' Operations.Show()
    End Sub

    Private Sub btnChpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChpass.Click
        'Dim w As New User
        'w.txtuid.Hide()
        'w.txtname.Hide()
        'w.lblname.Text = nme
        'w.lbluid.Text = uid
        'w.pstatus = "u"
        'w.txtuid.Enabled = False
        'w.txtname.Enabled = False
        'w.Label5.Hide()
        'w.chbstat.Hide()
        ''w.txtpasswd.Focus()
        'w.ShowDialog()

    End Sub

    Private Function ValidateWorkOrder() As Boolean
        Dim sql As String
        Dim code As String
        Dim ds As New DataSet
        ' Dim db As New Class1
        ValidateWorkOrder = False
        If Not txtwrkordno.Text = "" Then
            Try
                sql = " select * from WorkOrders"
                sql = sql & " where project = '" & txtwrkordno.Text & "'"
                ds = db.selectQuery(sql)
                If ds.Tables(0).Rows.Count() > 0 Then
                    code = ds.Tables(0).Rows(0).Item("ItemCode")
                    txtitmcode.Text = code
                    'txtdesc.Text = ds.Tables(0).Rows(0).Item("ItemDesc")
                    txtwoqty.Text = ds.Tables(0).Rows(0).Item("Quantity")
                    txtqnty.Text = GetActualStentQty(txtwrkordno.Text)
                    'txtqnty.Text = ds.Tables(0).Rows(0).Item("Quantity")
                    Adgrid()
                    Rdgrid()
                    txterror.Text = "Press F4 to Stop Scanning"
                    'btnuser.Enabled = False
                    'btnrej.Enabled = False
                    'btnChpass.Enabled = False
                    'btnexit.Enabled = False
                    ValidateWorkOrder = True
                Else
                    MsgBox("Invalid Work Order No")
                    st = "invalid"
                    Adgrid()
                    Rdgrid()
                    txtitmcode.Clear()
                    txtqnty.Clear()
                    txtdesc.Clear()
                    txtwrkordno.Text = ""
                    ValidateWorkOrder = False
                    txtwrkordno.Focus()
                End If
            Catch ex As System.Exception
                MsgBox("Invalid Work Order No")
                st = "invalid"
                txtitmcode.Clear()
                txtqnty.Clear()
                txtdesc.Clear()
                txtwrkordno.Text = ""
                Adgrid()
                Rdgrid()
                ValidateWorkOrder = False
                txtwrkordno.Focus()
            End Try
        Else
            ValidateWorkOrder = False
        End If
    End Function

    Private Function ValidateSerialNos() As Boolean

        Dim sql As String
        'Dim db As New Class1
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim ky As String
        Dim srcheck As String
        ValidateSerialNos = False
        If Not txtsrno1.Text = "" Then
            txterror.Text = "Press F4 to Stop Scanning"
            'If Gstatus = "A" Then
            'sql = "select srlno1,wono from OperationLogs where oprn='" & sOprn & "' and wono='" & txtwrkordno.Text & "' and srlno1='" & txtsrno1.Text & "'"
            sql = "select srlno1,wono from OperationLogs where oprn='" & sOprn & "' and srlno1='" & txtsrno1.Text & "'"
            ds1 = db.selectQuery(sql)
            Try
                If ds1.Tables(0).Rows.Count > 0 Then
                    srcheck = ds1.Tables(0).Rows(0).Item("srlno1")
                    txterror.Text = "Already Scanned for this Operation"
                    MsgBox(txterror.Text, MsgBoxStyle.Critical)
                    ' db.PlayWav("E")
                    txtsrno1.Text = ""
                    ValidateSerialNos = False
                    Return ValidateSerialNos
                Else
                    ValidateSerialNos = True
                End If
            Catch ex As System.Exception
                If InStr(ex.Message, "There is no row at position 0.", CompareMethod.Binary) > 0 Then
                    ValidateSerialNos = True
                End If
            End Try

            If nCurOprn > 0 Then
                sql = "select srlno1,status from OperationLogs where oprn in ( select  oprnid from Operations where opseq < " & nCurOprn & ")  and wono='" & txtwrkordno.Text & "' and srlno1 = '" & Trim(txtsrno1.Text) & "' order by oprn desc "
                ds = db.selectQuery(sql)

                If ds.Tables(0).Rows.Count = 0 Then
                    ' db.PlayWav("E")
                    txterror.Text = "Previous Process is not Completed !!!"
                    txterror.Show()
                    MsgBox(txterror.Text, MsgBoxStyle.Critical)
                    txtsrno1.Clear()
                    txtsrno2.Clear()
                    txtsrno2.Text = "Stent"
                    txtsrno2.ForeColor = Color.Gray
                    ValidateSerialNos = False
                    Return ValidateSerialNos
                Else
                    If ds.Tables(0).Rows(0).Item("status") = 1 Then
                        ValidateSerialNos = True
                    Else
                        ' db.PlayWav("E")
                        txterror.Text = "Serial No " & txtsrno1.Text & " was rejected in Previous Operation"
                        txterror.Show()
                        MsgBox(txterror.Text, MsgBoxStyle.Critical)
                        insertScanLog(2)
                        txtsrno1.Clear()
                        txtsrno2.Clear()
                        'txtsrno2.Text = "Stent"
                        'txtsrno2.ForeColor = Color.Gray
                        ValidateSerialNos = False
                        Return ValidateSerialNos
                    End If
                End If
            End If
        Else
            txterror.Text = "Serial No is Empty"
            ValidateSerialNos = False
            Return ValidateSerialNos
            'txtsrno1.Focus()
            'txtsrno1.Clear()
        End If
        Return ValidateSerialNos
        'If (Gstatus = "A" And ky = "C") Or (Gstatus = "R") Then
        '    txtsrno2.Focus()
        '    txtsrno2.Clear()
        '    txtsrno2.ForeColor = Color.Black
        'End If
    End Function

    Private Sub btnreject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreject.Click
        If Not sTObeRejectSrNo = "" Then
            Rejection()
        Else
            btnreject.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaccept.TextChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblbal.Click

    End Sub

    Private Sub btnundo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnundo.Click
        If Not sTobeUndoSrNo = "" Then
            If MsgBox("Are you Sure to Undo Rejection of the Serial No : " & sTobeUndoSrNo & "  ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                UnDoRejection()
            Else
                'btnreject.Enabled = False
            End If
        End If
    End Sub

    Private Function UnDoRejection() As Boolean

        Try
            Dim sql As String
            Dim r As New Rejection
            ' Dim db As New Class1
            Dim ds As New DataSet
            Dim inc As Integer
            Dim srno As String

            inc = dgrej.CurrentRow.Index
            srno = sTobeUndoSrNo                   'dgrej.Item(inc, 0)

            r.rstatus = sOprn

            sql = "Update OperationLogs set status = 1, reascd1 = '', reascd2 = '', mdby = '" & "" & "', mddt = getdate() "
            sql = sql & " where srlno1='" & srno & "'and wono='" & txtwrkordno.Text & "' and oprn = '" & sOprn & "'"
            'MsgBox(sql)
            'sql = "select srlno1 as [Serial No], "
            'sql = sql & " srlno2,wono"
            'sql = sql & " from OperationLogs where srlno1='" & srno & "'and wono='" & txtwrkordno.Text & "'"

            'dgaccpt.DataSource = ds.Tables(0).DefaultView
            'End If
            db.updateQuery(sql)
            'r.txtcath.Text = ds.Tables(0).Rows(0).Item(0)
            'r.txtst.Text = ds.Tables(0).Rows(0).Item(1)
            'r.wono = ds.Tables(0).Rows(0).Item(2)
            'r.txtuid.Text = uid
            'r.word = txtwrkordno.Text
            'r.status = wstatus
            'r.ShowDialog()
            Adgrid()
            Rdgrid()
        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try

    End Function

    Private Sub txterror_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txterror.Click
        Adgrid()
        Rdgrid()
    End Sub

    Public Function BetterIsNumeric(ByVal pstrValue As String) As Boolean
        Dim blnReturn As Boolean

        blnReturn = Not pstrValue Like "*[!0-9.]*"

        If blnReturn Then
            blnReturn = IsNumeric(pstrValue)
        End If

        BetterIsNumeric = blnReturn

    End Function

    Private Sub txtsrno2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsrno2.Leave

    End Sub

    Private Sub insertScanLog(ByVal status As Integer)
        Sql = "insert into FailedScanLogs(wono,oprn,srlno1,srlno2,status,crby,crdt) values ('" & txtwrkordno.Text & "','" & sOprn & "','" & txtsrno1.Text & "','" & txtsrno2.Text & "'," & status & ",'" & uid & "', getdate()) "
        db.insertQuery(Sql)
    End Sub

    Private Sub dgaccpt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgaccpt.GotFocus
        sTObeRejectSrNo = ""
    End Sub

    Private Sub dgaccpt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgaccpt.KeyPress
        If e.KeyChar = Chr(Keys.F1) Then
            scan()
            e.Handled = True
        ElseIf e.KeyChar = Chr(Keys.F4) Then
            stopscan()
            e.Handled = True
        ElseIf e.KeyChar = Chr(Keys.F5) Then
            Rejection()
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Escape) Then

            ActiveForm.Close()
            'Operations.Show()

            e.Handled = True
        End If
    End Sub

    Private Sub dgaccpt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgaccpt.LostFocus
        'btnreject.Enabled = False 
        If sTObeRejectSrNo = "" Then
            btnreject.Enabled = False
        Else
            btnreject.Enabled = True
        End If
    End Sub

    Private Sub dgaccpt_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgaccpt.MouseClick
        If dgaccpt.CurrentRow.Index >= 0 Then
            If UCase(e.Button.ToString) = "LEFT" Then
                If dgaccpt.CurrentRow.Index < dtAccepted.Rows.Count Then
                    sTObeRejectSrNo = dgaccpt.Item(0, dgaccpt.CurrentRow.Index).Value
                Else
                    sTObeRejectSrNo = ""
                End If
            Else
                sTObeRejectSrNo = ""
            End If
            If sTObeRejectSrNo = "" Then
                btnreject.Enabled = False
            Else
                btnreject.Enabled = True
            End If
            btnundo.Enabled = False
        End If
    End Sub

    Private Sub dgrej_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrej.DoubleClick
        If dgrej.CurrentRow.Index >= 0 Then
            If dgrej.CurrentRow.Index < dtRejected.Rows.Count Then
                URejection()
            End If
        End If
    End Sub

    Private Sub dgrej_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrej.GotFocus
        btnreject.Enabled = False
    End Sub

    Private Sub dgrej_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrej.KeyDown
        'If e.KeyValue = Keys.F5 Then
        '    URejection()
        '    e.Handled = True
        'End If
        If e.KeyValue = Keys.F1 Then
            scan()
            e.Handled = True
        ElseIf e.KeyValue = Keys.F4 Then
            stopscan()
            e.Handled = True
        End If
        If e.KeyValue = Keys.Escape Then

            ActiveForm.Close()
            ' Operations.Show()

            e.Handled = True
        End If
    End Sub

    Private Sub dgrej_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgrej.KeyPress
        If e.KeyChar = Chr(Keys.F5) Then
            URejection()

            e.Handled = True
        End If
    End Sub

    Private Sub dgrej_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrej.KeyUp
        If e.KeyValue = Keys.F5 Then
            URejection()
            e.Handled = True
        End If
    End Sub

    Private Sub dgrej_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgrej.MouseClick
        If dgrej.CurrentRow.Index >= 0 Then
            If UCase(e.Button.ToString) = "LEFT" Then
                If dgrej.CurrentRow.Index < dtRejected.Rows.Count Then
                    sTobeUndoSrNo = dgrej.Item(0, dgrej.CurrentRow.Index).Value
                Else
                    sTobeUndoSrNo = ""
                End If
            Else
                sTobeUndoSrNo = ""
            End If
            If sTobeUndoSrNo = "" Then
                btnundo.Enabled = False
            Else
                btnundo.Enabled = True
            End If
            'btnundo.Enabled = False
        End If
    End Sub

    Private Sub FormatAcceptedGrid()
        Dim i As Integer
        For i = 0 To dgaccpt.Columns.Count - 1
            dgaccpt.Columns(i).ReadOnly = True
            dgaccpt.Columns(i).Width = 130
        Next
    End Sub

    Private Sub FormatRejectedGrid()
        Dim i As Integer
        For i = 0 To dgrej.Columns.Count - 1
            dgrej.Columns(i).ReadOnly = True
            dgrej.Columns(i).Width = 130
        Next
    End Sub

End Class
