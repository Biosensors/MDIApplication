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

Public Class FrmViewSerials
    Inherits System.Windows.Forms.Form
    Public uid As String = sLogonUser
    Public strWONo, BatchNo As String
    Public ActualQty, GeneratedQty As Integer
    Public LastSrNo As String
    Public GeneratedSerial As String
    Public dt As DataTable
    Dim objUtil As New ClsUtil()

    Public db As New Class1
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStentWO As System.Windows.Forms.TextBox
    Friend WithEvents btnReject As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGeneratedQty As System.Windows.Forms.TextBox
    Friend WithEvents chkShowRejected As System.Windows.Forms.CheckBox
    Friend WithEvents dgSerials As System.Windows.Forms.DataGridView
    Private Gstatus As String
    Public StentType As String

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmViewSerials))
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtStentWO = New System.Windows.Forms.TextBox
        Me.btnReject = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtGeneratedQty = New System.Windows.Forms.TextBox
        Me.chkShowRejected = New System.Windows.Forms.CheckBox
        Me.dgSerials = New System.Windows.Forms.DataGridView
        CType(Me.dgSerials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 24)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Stent Work Order"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStentWO
        '
        Me.txtStentWO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStentWO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStentWO.Location = New System.Drawing.Point(209, 19)
        Me.txtStentWO.MaxLength = 12
        Me.txtStentWO.Name = "txtStentWO"
        Me.txtStentWO.ReadOnly = True
        Me.txtStentWO.Size = New System.Drawing.Size(162, 22)
        Me.txtStentWO.TabIndex = 1
        '
        'btnReject
        '
        Me.btnReject.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnReject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReject.Location = New System.Drawing.Point(161, 397)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(100, 25)
        Me.btnReject.TabIndex = 6
        Me.btnReject.Text = "Reject"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 24)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Actual Quantity"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQuantity
        '
        Me.txtQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(209, 54)
        Me.txtQuantity.MaxLength = 5
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(162, 22)
        Me.txtQuantity.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(270, 397)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 25)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 24)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "No of Generated Serials"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGeneratedQty
        '
        Me.txtGeneratedQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGeneratedQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGeneratedQty.Location = New System.Drawing.Point(209, 90)
        Me.txtGeneratedQty.MaxLength = 5
        Me.txtGeneratedQty.Name = "txtGeneratedQty"
        Me.txtGeneratedQty.ReadOnly = True
        Me.txtGeneratedQty.Size = New System.Drawing.Size(162, 22)
        Me.txtGeneratedQty.TabIndex = 3
        '
        'chkShowRejected
        '
        Me.chkShowRejected.AutoSize = True
        Me.chkShowRejected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowRejected.Location = New System.Drawing.Point(380, 91)
        Me.chkShowRejected.Name = "chkShowRejected"
        Me.chkShowRejected.Size = New System.Drawing.Size(166, 20)
        Me.chkShowRejected.TabIndex = 4
        Me.chkShowRejected.Text = "Show Rejected Also"
        Me.chkShowRejected.UseVisualStyleBackColor = True
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
        Me.dgSerials.Location = New System.Drawing.Point(23, 127)
        Me.dgSerials.Name = "dgSerials"
        Me.dgSerials.Size = New System.Drawing.Size(521, 261)
        Me.dgSerials.TabIndex = 140
        '
        'FrmViewSerials
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(566, 432)
        Me.Controls.Add(Me.dgSerials)
        Me.Controls.Add(Me.chkShowRejected)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGeneratedQty)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtStentWO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmViewSerials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Serial Numbers"
        CType(Me.dgSerials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FrmViewSerials_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        If strQuery = "ActualSerials" Then
            Me.Text = "Actual Serial Numbers"
        ElseIf strQuery = "DummySerials" Then
            Me.Text = "Dummy Serial Numbers"
        End If

        If strWONo <> "" Then
            FillGrid()
        End If
        btnReject.Enabled = False
    End Sub

    Private Sub btnReject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReject.Click
        Try
            If btnReject.Text = "Reject" Then
                FrmSerialRejectReason.txtStentSerial.Text = dgSerials.Item(0, dgSerials.CurrentRow.Index).Value.ToString
                FrmSerialRejectReason.lblRejectionType.Text = "Status"
                FrmSerialRejectReason.ShowDialog()
            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Public Sub FillGrid()
        Try
            Dim sql As String = ""
            Dim ds As New DataSet

            ' Display the generated number of serials in the textbox
            If strQuery = "ActualSerials" Then
                sql = "select stntserial from StentSerials where stwono ='" & strWONo & "' and status=1 and stenttype=1"
            ElseIf strQuery = "DummySerials" Then
                sql = "select stntserial from StentSerials where stwono ='" & strWONo & "' and status=1 and stenttype=2"
            End If

            ds = db.selectQuery(sql)
            txtGeneratedQty.Text = ds.Tables(0).Rows.Count

            ' Display the serials in the datagrid
            If chkShowRejected.Checked = True Then
                sql = " and (status = 0 or status = 1)"
            Else
                sql = " and status = 1"
            End If

            If strQuery = "ActualSerials" Then
                'sql = "select ss.stntserial as 'Stent Serial', Status = case when ss.status = 1 then 'Active' else 'Rejected' end, ss.stbatch as 'Batch No', isnull((select CONVERT(numeric(18,4),finalwt) from stentfinalweights where coating = 1 and stntserial = ss.stntserial),0) as 'Pre Coat Wt', isnull((select CONVERT(numeric(18,4),finalwt) from stentfinalweights where coating = 2 and stntserial = ss.stntserial),0) as 'Post Coat Wt' from StentSerials ss where ss.stenttype = 1 and ss.stwono ='" & strWONo & "'" & sql
                sql = "select ss.stntserial as 'Stent Serial', Status = case when ss.status = 1 then 'Active' else 'Rejected' end, isnull((select CONVERT(numeric(18,4),finalwt) from stentfinalweights where coating = 1 and stntserial = ss.stntserial),0) as 'Pre Coat Wt', isnull((select CONVERT(numeric(18,4),finalwt) from stentfinalweights where coating = 2 and stntserial = ss.stntserial),0) as 'Post Coat Wt' from StentSerials ss where ss.stenttype = 1 and ss.stwono ='" & strWONo & "'" & sql
            ElseIf strQuery = "DummySerials" Then
                'sql = "select ss.stntserial as 'Stent Serial', Status = case when ss.status = 1 then 'Active' else 'Rejected' end, ss.stbatch as 'Batch No', isnull((select CONVERT(numeric(18,4),finalwt) from stentfinalweights where coating = 1 and stntserial = ss.stntserial),0) as 'Pre Coat Wt', isnull((select CONVERT(numeric(18,4),finalwt) from stentfinalweights where coating = 2 and stntserial = ss.stntserial),0) as 'Post Coat Wt' from StentSerials ss where ss.stenttype = 2 and ss.stwono ='" & strWONo & "'" & sql
                sql = "select ss.stntserial as 'Stent Serial', Status = case when ss.status = 1 then 'Active' else 'Rejected' end, isnull((select CONVERT(numeric(18,4),finalwt) from stentfinalweights where coating = 1 and stntserial = ss.stntserial),0) as 'Pre Coat Wt', isnull((select CONVERT(numeric(18,4),finalwt) from stentfinalweights where coating = 2 and stntserial = ss.stntserial),0) as 'Post Coat Wt' from StentSerials ss where ss.stenttype = 2 and ss.stwono ='" & strWONo & "'" & sql
            End If

            ds = db.selectQuery(sql)
            dt = ds.Tables(0)
            dgSerials.DataSource = dt

            FormatGrid()

            If ds.Tables(0).Rows.Count <> 0 Then
                btnReject.Enabled = True
            Else
                btnReject.Enabled = False
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgSerials.Columns.Count - 1
            dgSerials.Columns(i).ReadOnly = True
            dgSerials.Columns(i).Width = 115
        Next
    End Sub

    Private Sub dgSerials_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgSerials.Click
        Try
            If dgSerials.CurrentRow.Index < dt.Rows.Count Then
                If dgSerials.CurrentRow.Index >= 0 Then
                    If UCase(e.ToString) = "SYSTEM.WINDOWS.FORMS.MOUSEEVENTARGS" Then
                        btnReject.Enabled = True
                        If dgSerials.Item(1, dgSerials.CurrentRow.Index).Value.ToString = "Active" Then
                            btnReject.Text = "Reject"
                        Else
                            btnReject.Enabled = False
                        End If
                    Else
                        btnReject.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgSerials_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)
        MsgBox("Navigate")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If strQuery = "ActualSerials" Then

            If Val(txtQuantity.Text) > Val(txtGeneratedQty.Text) Then

                Dim Ans As Integer
                Dim RemainingNoOfSerials As Integer
                Dim NoOfGenerated As Integer
                RemainingNoOfSerials = Val(txtQuantity.Text) - Val(txtGeneratedQty.Text)

                Sql = "select count(stntserial) from StentSerials where stwono='" & strWONo & "' and status=1 and stenttype=1"
                ds = db.selectQuery(Sql)
                NoOfGenerated = ds.Tables(0).Rows(0).Item(0)

                Ans = MsgBox("Do you want to generate remaining " & RemainingNoOfSerials & " actual serial number(s) for this Stent Work Order?", vbYesNo + vbExclamation, "Generate Serial Numbers")

                If Ans = vbYes Then

                    Dim SerialYear As Integer = objUtil.GetServerYear(stWODetails.dWorkOrderDate)
                    Dim SerialMonth As Integer = objUtil.GetServerMonth(stWODetails.dWorkOrderDate)

                    strWONo = Trim(txtStentWO.Text)

                    Sql = "select lastsrno from serialcount where year=" & SerialYear & " and month= " & SerialMonth & ""
                    ds = db.selectQuery(Sql)

                    If ds.Tables(0).Rows.Count = 0 Then
                        LastSrNo = 0
                    Else
                        LastSrNo = ds.Tables(0).Rows(0).Item(0)
                    End If
                    LastSrNo = LastSrNo + 1

                    Dim FormattedSerialYear As String = objUtil.GetServerFormattedYear(stWODetails.dWorkOrderDate)
                    Dim FormattedSerialMonth As String = objUtil.GetServerMonth(stWODetails.dWorkOrderDate)
                    LastSrNo = objUtil.StuffWithZeros(LastSrNo, 5)

                    Sql = "select planqty,batchno from WorkOrders where project='" & strWONo & "'"
                    ds = db.selectQuery(Sql)
                    BatchNo = Trim(ds.Tables(0).Rows(0).Item("batchno"))

                    Dim count As Integer
                    For count = LastSrNo To (LastSrNo + ((ActualQty - NoOfGenerated) - 1))
                        GeneratedSerial = stWODetails.sSerialPrefix & String.Concat(FormattedSerialYear, FormattedSerialMonth, LastSrNo) & stWODetails.sSerialSuffix
                        LastSrNo = CInt(LastSrNo) + 1
                        LastSrNo = objUtil.StuffWithZeros(LastSrNo, 5)

                        Sql = "insert into StentSerials(stntserial,status,stwono,stbatch,stenttype,createdby,createddate,modifiedby,modifieddate,pcount) values ('" & GeneratedSerial & "',1,'" & strWONo & "','" & BatchNo & "',1,'" & uid & "', getdate(),'" & uid & "', getdate(), '0') "
                        db.insertQuery(Sql)
                    Next count

                    Sql = "select year, month from serialcount where year= " & SerialYear & " and month=" & SerialMonth & ""
                    ds = db.selectQuery(Sql)
                    If ds.Tables(0).Rows.Count() = 0 Then
                        Sql = "insert into serialcount(year,month,lastsrno,dmysrno,lastupdatedby,lastupdateddate) values('" & SerialYear & "', '" & SerialMonth & "','" & LastSrNo - 1 & "',0,'" & uid & "',getdate())"
                        ds = db.selectQuery(Sql)
                    Else
                        Sql = "update SerialCount set lastsrno = '" & LastSrNo - 1 & "',lastupdatedby='" & uid & "',lastupdateddate=getdate() where year='" & SerialYear & "' and month='" & SerialMonth & "'"
                        db.updateQuery(Sql)
                    End If

                    If INIRead(INIFilePath, sServerName, "EnableLabelData") = 1 Then
                        'Write Normal Serials
                        clspm.WriteStentSerials(strWONo, "N")
                    End If

                    MsgBox("Serial Numbers generated successfully")
                End If
            End If

        End If
        Me.Close()

    End Sub

    Private Sub chkShowRejected_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowRejected.CheckedChanged
        FillGrid()
    End Sub

End Class
