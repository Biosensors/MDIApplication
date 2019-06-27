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

Public Class FrmSerials

    Inherits System.Windows.Forms.Form
    Public uid As String = sLogonUser
    Public strWONo As String
    Public ActualQty, GeneratedQty As Integer
    Dim objUtil As New ClsUtil()

    Public db As New Class1
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStentWO As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnViewSerials As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgSerials As System.Windows.Forms.DataGridView
    Private Gstatus As String
    Public dt As DataTable
    Dim SerialYear As String
    Dim SerialMonth As String
    Dim FormattedSerialYear As String

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSerials))
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtStentWO = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnViewSerials = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgSerials = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgSerials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 24)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Stent Work Order"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStentWO
        '
        Me.txtStentWO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStentWO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStentWO.Location = New System.Drawing.Point(159, 22)
        Me.txtStentWO.MaxLength = 12
        Me.txtStentWO.Name = "txtStentWO"
        Me.txtStentWO.Size = New System.Drawing.Size(184, 22)
        Me.txtStentWO.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(358, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(125, 25)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        '
        'btnViewSerials
        '
        Me.btnViewSerials.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnViewSerials.Enabled = False
        Me.btnViewSerials.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewSerials.Location = New System.Drawing.Point(327, 15)
        Me.btnViewSerials.Name = "btnViewSerials"
        Me.btnViewSerials.Size = New System.Drawing.Size(125, 25)
        Me.btnViewSerials.TabIndex = 4
        Me.btnViewSerials.Text = "View Serials"
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(189, 15)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(125, 25)
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "New"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(465, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(125, 25)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox1.Controls.Add(Me.btnViewSerials)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 326)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 46)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        '
        'dgSerials
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.dgSerials.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSerials.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgSerials.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSerials.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgSerials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSerials.Location = New System.Drawing.Point(19, 59)
        Me.dgSerials.Name = "dgSerials"
        Me.dgSerials.Size = New System.Drawing.Size(776, 261)
        Me.dgSerials.TabIndex = 139
        '
        'FrmSerials
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(812, 382)
        Me.Controls.Add(Me.dgSerials)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtStentWO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSerials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stent Work Order Serials"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgSerials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FrmSerials_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If strQuery = "ActualSerials" Then
            Me.Text = "Generate Actual Serials"
        ElseIf strQuery = "DummySerials" Then
            Me.Text = "Generate Dummy Serials"
        End If

        SerialYear = objUtil.GetServerYear(Date.Today)
        SerialMonth = objUtil.GetServerMonth(Date.Today)
        FormattedSerialYear = objUtil.GetServerFormattedYear(Date.Today)

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        FrmAddSerial.txtstwrkordno.Text = ""
        FrmAddSerial.lblItemCode.Text = ""
        FrmAddSerial.lblItemDesc.Text = ""
        FrmAddSerial.lblBatchNo.Text = ""
        FrmAddSerial.lblSerialPrefix.Text = ""
        FrmAddSerial.lblSerialSuffix.Text = ""
        FrmAddSerial.lblSerialYYMM.Text = ""
        FrmAddSerial.lblPlanQty.Text = ""
        FrmAddSerial.lblNoOfSerials.Text = ""
        FrmAddSerial.txtstwrkordno.ReadOnly = False
        'FrmAddSerial.txtNoOfSerials.ReadOnly = False
        FrmAddSerial.btnSave.Enabled = True
        FrmAddSerial.TxtDmySerials.Visible = False
        FrmAddSerial.lbldummy.Visible = False
        FrmAddSerial.Text = "Add Serial Number"
        FrmAddSerial.ShowDialog()
        FillGrid(strQuery)
        FrmAddSerial.txtstwrkordno.Focus()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        btnViewSerials.Enabled = False
        FillGrid(strQuery)
    End Sub

    Private Sub btnViewSerials_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewSerials.Click
        ViewSerials()
    End Sub

    Private Sub ViewSerials()
        Try
            If dgSerials.CurrentRow.Index >= 0 Then
                strWONo = Trim(dgSerials.CurrentRow.Cells(0).Value.ToString())
                Sql = "select actualqty from StentsWOMaster where stwono='" & strWONo & "'"
                ds = db.selectQuery(Sql)
                ActualQty = ds.Tables(0).Rows(0).Item(0)
                FrmViewSerials.txtStentWO.Text = strWONo
                FrmViewSerials.txtQuantity.Text = ActualQty
                FrmViewSerials.strWONo = strWONo
                FrmViewSerials.ActualQty = ActualQty
                FrmViewSerials.chkShowRejected.Checked = False
                FrmViewSerials.ShowDialog()
                FillGrid(strQuery)
            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub FillGrid(ByVal strQuery As String)
        Try
            Dim sql As String = ""
            Dim ds As New DataSet

            If strQuery = "ActualSerials" Then
                'sql = "select sm.stwono as 'Stent WO No', sm.planqty as 'Plan Qty', sm.actualqty as 'Actual Qty', isnull((select min(stntserial) from stentserials where stwono = sm.stwono and stenttype = 1 and status = 1) + ' ~ ' + (select max(stntserial) from stentserials where stwono = sm.stwono and stenttype = 1 and status = 1),'Nil') as 'Serials Range' from StentsWOMaster sm where sm. stwono like '%" & txtStentWO.Text.ToString().Trim & "%'"
                sql = "select sm.stwono as 'Stent WO No', w.ItemCode as 'Item Code', w.batchno as 'Batch No', isnull((select count(stntserial) from stentserials where stwono = sm.stwono and stenttype = 1 and status = 1),0) as 'No of Serials', isnull((select min(stntserial) from stentserials where stwono = sm.stwono and stenttype = 1 and status = 1) + ' ~ ' + (select max(stntserial) from stentserials where stwono = sm.stwono and stenttype = 1 and status = 1),'Nil') as 'Serials Range' from StentsWOMaster sm left join WorkOrders w on w.project = sm.stwono where sm. stwono like '%" & txtStentWO.Text.ToString().Trim & "%' order by sm.stwono"
            ElseIf strQuery = "DummySerials" Then
                sql = "select stwono as 'Stent WO No', count(stwono) as 'No of Serials', isnull(min(stntserial) + ' ~ ' + max(stntserial),'Nil') as 'Serials Range' from stentserials where stenttype = 2 and status = 1 and stwono like '%" & txtStentWO.Text.ToString().Trim & "%' group by stwono order by stwono"
            End If

            ds = db.selectQuery(sql)
            dt = ds.Tables(0)
            dgSerials.DataSource = dt

            If strQuery = "ActualSerials" Then
                FormatGrid(143)
            ElseIf strQuery = "DummySerials" Then
                FormatGrid(192)
            End If

            If ds.Tables(0).Rows.Count = 0 Then
                btnViewSerials.Enabled = False
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FormatGrid(ByVal WidthValue As Integer)
        Dim i As Integer
        For i = 0 To dgSerials.Columns.Count - 1
            dgSerials.Columns(i).ReadOnly = True
            dgSerials.Columns(i).Width = WidthValue
        Next
    End Sub

    Private Sub dgSerials_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgSerials.Click
        Try
            If dgSerials.CurrentRow.Index < dt.Rows.Count Then
                If dgSerials.CurrentRow.Index >= 0 Then
                    If UCase(e.ToString) = "SYSTEM.WINDOWS.FORMS.MOUSEEVENTARGS" Then
                        strWONo = Trim(dgSerials.CurrentRow.Cells(0).Value.ToString())

                        Sql = "select stntserial from StentSerials where stwono='" & strWONo & "' and status = 1"
                        ds = db.selectQuery(Sql)

                        If ds.Tables(0).Rows.Count = 0 Then
                            btnViewSerials.Enabled = False
                        Else
                            btnViewSerials.Enabled = True
                        End If

                    End If
                End If
            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub dgSerials_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgSerials.DoubleClick
        'Dim qtyPlan, qtyactual, NoOfGenerated As Integer
        'Try
        '    If dgSerials.CurrentRow.Index < dt.Rows.Count Then

        '        If dgSerials.CurrentRow.Index >= 0 Then
        '            If UCase(e.ToString) = "SYSTEM.WINDOWS.FORMS.MOUSEEVENTARGS" Then
        '                strWONo = Trim(dgSerials.CurrentRow.Cells(0).Value.ToString())

        '                FrmAddSerial.txtstwrkordno.Text = strWONo
        '                clspm.GetWorkOrderDetails(strWONo)
        '                FrmAddSerial.lblItemCode.Text = stWODetails.sItemCode
        '                FrmAddSerial.lblItemDesc.Text = stWODetails.sItemDescription
        '                FrmAddSerial.lblBatchNo.Text = stWODetails.sBatchNo
        '                FrmAddSerial.lblSerialPrefix.Text = stWODetails.sSerialPrefix
        '                FrmAddSerial.lblSerialYYMM.Text = FormattedSerialYear & SerialMonth
        '                FrmAddSerial.lblSerialSuffix.Text = stWODetails.sSerialSuffix

        '                Sql = "select planqty, actualqty from StentsWOMaster where stwono='" & strWONo & "'"
        '                ds = db.selectQuery(Sql)
        '                FrmAddSerial.lblPlanQty.Text = ds.Tables(0).Rows(0).Item("planqty")
        '                FrmAddSerial.txtNoOfSerials.Text = ds.Tables(0).Rows(0).Item("actualqty")

        '                FrmAddSerial.txtstwrkordno.ReadOnly = True
        '                FrmAddSerial.Text = "Edit and Generate Serial Numbers"
        '                qtyPlan = ds.Tables(0).Rows(0).Item("planqty")
        '                qtyactual = ds.Tables(0).Rows(0).Item("actualqty")

        '                Sql = "select count(stntserial) from StentSerials where stwono='" & strWONo & "' and status=1"
        '                ds = db.selectQuery(Sql)
        '                NoOfGenerated = ds.Tables(0).Rows(0).Item(0)
        '                If qtyPlan - NoOfGenerated > 0 Then
        '                    'FrmAddSerial.txtNoOfSerials.ReadOnly = False
        '                    FrmAddSerial.btnSave.Enabled = True
        '                    FrmAddSerial.ShowDialog()
        '                Else
        '                    btnViewSerials.Enabled = False
        '                End If

        '                FillGrid(strQuery)
        '            Else
        '                strWONo = ""
        '            End If
        '        End If
        '    End If
        'Catch ex As System.Exception

        'End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtwrkordno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStentWO.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btnViewSerials.Enabled = False
            FillGrid(strQuery)
        End If
    End Sub

End Class
