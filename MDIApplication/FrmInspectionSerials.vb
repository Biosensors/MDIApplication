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

Public Class FrmInspectionSerials

    Inherits System.Windows.Forms.Form
    Public strWONo As String
    Dim objUtil As New ClsUtil()

    Public db As New Class1
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtWONo As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dgInspection As System.Windows.Forms.DataGridView
    Public dt As DataTable
  
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInspectionSerials))
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtWONo = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.dgInspection = New System.Windows.Forms.DataGridView
        CType(Me.dgInspection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 24)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "WO No / Batch No"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWONo
        '
        Me.txtWONo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtWONo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWONo.Location = New System.Drawing.Point(169, 22)
        Me.txtWONo.MaxLength = 12
        Me.txtWONo.Name = "txtWONo"
        Me.txtWONo.Size = New System.Drawing.Size(184, 22)
        Me.txtWONo.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(363, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(125, 25)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(402, 349)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(125, 25)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        '
        'dgInspection
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.dgInspection.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgInspection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgInspection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInspection.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgInspection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInspection.Location = New System.Drawing.Point(18, 59)
        Me.dgInspection.Name = "dgInspection"
        Me.dgInspection.Size = New System.Drawing.Size(862, 280)
        Me.dgInspection.TabIndex = 139
        '
        'FrmInspectionSerials
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(897, 382)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgInspection)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtWONo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInspectionSerials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stent Serial Inspection"
        CType(Me.dgInspection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FrmStentSerialInspection_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtWONo.Select()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Me.Cursor = Cursors.WaitCursor
        FillGrid(strQuery)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FillGrid(ByVal strQuery As String)
        Try
            Dim sql As String = ""
            Dim ds As New DataSet

            sql = "select z.project as 'Work Order No', z.Itemcode as 'Item Code', z.Facode as 'Batch No', z.Totalgood as 'Accepted Qty', z.Totalbad as 'Rejected Qty', (convert(decimal(10,2),(z.totalgood / CAST((z.totalgood + z.totalbad) AS decimal))))*100 as 'Accepted %', (convert(decimal(10,2),(z.totalbad / CAST((z.totalgood + z.totalbad) AS decimal))))*100 as 'Rejected %' from zwolist z left join stentserials s on s.stwono = z.project where (z.Itemcode like '%" & txtWONo.Text & "%' or z.project like '%" & txtWONo.Text & "%') and s.inspnstatus <> -1 group by z.project, z.Itemcode, z.Facode, z.Totalgood, z.Totalbad"
            ds = db.selectQuery(sql)
            dt = ds.Tables(0)
            dgInspection.DataSource = dt

            FormatGrid()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgInspection.Columns.Count - 1
            dgInspection.Columns(i).ReadOnly = True
            dgInspection.Columns(i).Width = 117
        Next
    End Sub

    Private Sub txtwrkordno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWONo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            FillGrid(strQuery)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgInspection_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgInspection.DoubleClick
        Try
            If dgInspection.CurrentRow.Index < dt.Rows.Count Then

                If dgInspection.CurrentRow.Index >= 0 Then
                    If UCase(e.ToString) = "SYSTEM.WINDOWS.FORMS.MOUSEEVENTARGS" Then
                        strWONo = Trim(dgInspection.CurrentRow.Cells(0).Value.ToString())

                        FrmViewInspectionSerials.txtWONo.Text = strWONo
                        clspm.GetWorkOrderDetails(strWONo)
                        FrmViewInspectionSerials.lblItem.Text = stWODetails.sItemCode
                        FrmViewInspectionSerials.lblItemDesc.Text = stWODetails.sItemDescription
                        FrmViewInspectionSerials.lblBatch.Text = stWODetails.sBatchNo

                        FrmViewInspectionSerials.ShowDialog()
                        FillGrid(strQuery)
                    Else
                        strWONo = ""
                    End If
                End If
            End If
        Catch ex As System.Exception

        End Try
    End Sub

End Class
