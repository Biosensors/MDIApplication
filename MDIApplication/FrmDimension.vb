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

Public Class FrmDimension
    Inherits System.Windows.Forms.Form
    Public uid As String = sLogonUser
    Public sOprn As String = "CRMP"
    Public sOprnDsca As String
    Public wstatus As Integer
    Public db As New Class1
    Public nCurOprn As Integer
    Public id As String
    Public id1 As String
    Public id2 As String
    Public id3 As String
    Public sColumnsName As String

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmbColumns.Text = "<< Search by >>"
        cmbColumns.Items.Insert(0, "Serial No.")
        cmbColumns.Items.Insert(1, "WorkOrder No.")
        cmbColumns.Items.Insert(2, "Item Code.")
        cmbColumns.Items.Insert(3, "Item Description")
        DateTimePicker2.Value = Now()
        ' DateTimePicker1.Value = DateAdd(DateInterval.Month, -1, Now)
        DateTimePicker1.Value = DateAdd(DateInterval.Weekday, -8, Now)
        'showDimensionGrid()
        uid = sLogonUser
        btnDetails.Enabled = False
    End Sub

    Private Sub DimensionInsert()
        Try
            Dim sql As String
            sql = "insert into Dimensions(stntserial,dim1,dim2,dim3,scanby,scandt,mdfyby,mdfydt)"
            sql = sql & " values('" & Trim(txtsrlno.Text) & "','" & Trim(txtDim1.Text) & "',"
            sql = sql & " '" & Trim(txtDim2.Text) & "', "
            If (Trim(txtDim3.Text) = String.Empty) Then
                sql = sql & "NULL,"
            Else
                sql = sql & "'" & Trim(txtDim3.Text) & "',"
            End If
            sql = sql & "'" & sLogonUser & "',getDate(), '" & sLogonUser & "', getDate())"
            db.insertQuery(sql)

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub showDimensionGrid()
        Try
            sColumnsName = ""
            Select Case cmbColumns.SelectedIndex
                Case Is = 0
                    sColumnsName = "stntserial"
                    Exit Select
                Case Is = 1
                    sColumnsName = "project"
                    Exit Select
                Case Is = 2
                    sColumnsName = "ItemCode"
                    Exit Select
                Case Is = 3
                    sColumnsName = "ItemDesc"
                    Exit Select
            End Select
            Dim dtp2 As String
            dtp2 = DateTimePicker2.Value.AddDays(1).ToShortDateString()
            Dim sql As String
            sql = "select a.stntserial AS SerialNo, b.project as [WorkOrder No.], b.ItemCode as [Item Code], b.ItemDesc as [Item Description],"
            sql = sql & " CONVERT(numeric(5, 4), a.dim1) AS Dimension1, CONVERT(numeric(5, 4), a.dim2)AS Dimension2,"
            sql = sql & " CAST((CASE WHEN CONVERT(decimal, a.dim3) IS NULL THEN 0 ELSE a.dim3 END) AS numeric(5, 4)) AS Dimension3"
            sql = sql & " FROM Dimensions a LEFT OUTER JOIN OperationLogs ss ON ss.srlno1 = a.stntserial LEFT OUTER JOIN"
            sql = sql & " ZWOList b ON b.project = ss.wono where "
            sql = sql & " ss.oprn = '" & sOprn & "'"
            sql = sql & " and a.scandt between  '" & DateTimePicker1.Value.ToShortDateString & "' and '" & dtp2 & "'"
            If Not (sColumnsName = "" Or txtEnter.Text = "") Then
                sql = sql & " and " & sColumnsName & " like '" & Trim(txtEnter.Text) & "%'"
            End If
            sql = sql & " order by a.scandt desc"

            ds = db.selectQuery(sql)
            dgDimension.DataSource = ds.Tables(0).DefaultView

            FormatGrid()

            dsDimension = ds
            '  ds = Nothing

        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgDimension.Columns.Count - 1
            dgDimension.Columns(i).ReadOnly = True
            dgDimension.Columns(i).Width = 126
        Next
    End Sub

    Private Function ValidateSerialNos() As Boolean
        Dim sql As String
        Dim ds As DataSet

        ValidateSerialNos = False
        If Not txtsrlno.Text = "" Then
            Try
                sql = "select a.project, a.ItemCode, a.ItemDesc, b.wono from OperationLogs AS b"
                sql = sql & " LEFT OUTER JOIN "
                sql = sql & " ZWOList AS a ON a.project = b.wono where oprn = '" & sOprn & "'"
                sql = sql & " and srlno1 = '" & txtsrlno.Text & "'"
                ds = db.selectQuery(sql)
                If ds.Tables(0).Rows.Count() > 0 Then
                    FrmDimensionDetails.lblwono.Text = ds.Tables(0).Rows(0).Item("wono")
                    FrmDimensionDetails.lblItemcode.Text = ds.Tables(0).Rows(0).Item("ItemCode")
                    FrmDimensionDetails.lblDescription.Text = ds.Tables(0).Rows(0).Item("ItemDesc")

                    showDimensionGrid()

                    ValidateSerialNos = True
                Else
                    MsgBox("Invalid Serial No")
                    txtsrlno.Text = ""
                    ValidateSerialNos = False
                    txtsrlno.Focus()
                End If
            Catch ex As System.Exception
                MsgBox("Invalid Work Order No")
                txtsrlno.Text = ""
                showDimensionGrid()
                ValidateSerialNos = False
                txtsrlno.Focus()
            End Try
        Else
            ValidateSerialNos = False
        End If
    End Function

    Private Sub txtsrlno_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsrlno.GotFocus
        txtsrlno.Text = ""
        'txtsrlno.ForeColor = Color.Gray
    End Sub

    Private Sub txtDim2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDim2.GotFocus
        txtDim2.Text = ""
        'txtDim2.ForeColor = Color.Gray
    End Sub

    Private Sub txtDim3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDim3.GotFocus
        txtDim3.Text = ""
        'txtDim3.ForeColor = Color.Gray
    End Sub

    Private Sub txtDim1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDim1.GotFocus
        txtDim1.Text = ""
        'txtDim1.ForeColor = Color.Gray
    End Sub

    Private Sub txtsrlno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsrlno.LostFocus
        If Not txtsrlno.Text = "" Then
            If ValidateOnLeaveSerial() Then
            Else
                txtsrlno.Focus()
            End If
        End If
    End Sub

    Private Sub txtdim2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDim2.LostFocus
        If txtDim2.Text = "" Then
        End If
    End Sub

    Private Sub txtdim1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDim1.LostFocus
        If txtDim1.Text = "" Then
            txtDim1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtdim3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDim3.LostFocus
        If txtDim3.Text = "" Then
            txtDim3.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtDim1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDim1.KeyDown
        If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Tab Then
            txtDim2.Text = ""
            e.Handled = True
        End If
    End Sub

    Private Sub txtDim2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDim2.KeyDown
        If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Tab Then
            txtDim3.Text = ""
            e.Handled = True
        End If
    End Sub

    Private Sub txtsrlno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsrlno.KeyDown
        If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Tab Then
            txtDim1.Text = ""
            e.Handled = True

        End If
    End Sub

    Private Sub txtDim3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDim3.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            If IsNumeric(txtDim3.Text) = False Then
                MsgBox("dimension value should not be alphanumeric", MsgBoxStyle.Critical)
            Else
                If txtsrlno.Text <> "" Then

                    If Not ValidateSerialNos() Then
                        txtsrlno.Text = ""
                        txtsrlno.Focus()

                    Else
                        DimensionInsert()
                        showDimensionGrid()
                        txtDim3.Clear()
                        txtDim1.Text = ""
                        txtDim2.Text = ""
                        txtDim3.Text = ""
                    End If

                Else
                    lblError.Text = " serial No, Dimension1 and Dimension2 should be empty"
                End If
                txtsrlno.Clear()
                txtDim1.Clear()
                txtDim2.Clear()
                txtDim3.Clear()
                txtsrlno.Focus()
            End If
        End If

    End Sub

    Private Sub dgDimension_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dgDimension.RowCount > 0 Then
            getDimensionDetails()
            '  FrmDimensionDetails.Tag = "U"
            FrmDimensionDetails.ShowDialog()
            showDimensionGrid()
        End If

    End Sub

    Private Sub getDimensionDetails()
        id = dgDimension.Item(0, dgDimension.CurrentRow.Index).Value
        id1 = dgDimension.Item(1, dgDimension.CurrentRow.Index).Value
        id2 = dgDimension.Item(2, dgDimension.CurrentRow.Index).Value
        id3 = dgDimension.Item(3, dgDimension.CurrentRow.Index).Value

        FrmDimensionDetails.lblwono.Text = id1 ' workorder no
        FrmDimensionDetails.lblItemcode.Text = id2 ' item code
        FrmDimensionDetails.lblDescription.Text = id3 ' itemdescription

        Sql = ""
        Sql = "select stntserial as [Serial No],CONVERT(numeric(5, 4), dim1) as [Dimension1], CONVERT(numeric(5, 4), dim2) as [Dimension2],"
        Sql = Sql & " CAST((CASE WHEN CONVERT(decimal, dim3) IS NULL THEN 0 ELSE dim3 END) AS numeric(5, 4)) AS [Dimension3]"
        Sql = Sql & " from Dimensions where stntserial = '" & id & "'"
        ds = db.selectQuery(Sql)
        If (ds.Tables(0).Rows.Count > 0) Then
            FrmDimensionDetails.txtsrlno.Text = ds.Tables(0).Rows(0).Item("Serial No")
            FrmDimensionDetails.txtDim1.Text = ds.Tables(0).Rows(0).Item("Dimension1")
            FrmDimensionDetails.txtDim2.Text = ds.Tables(0).Rows(0).Item("Dimension2")
            FrmDimensionDetails.txtDim3.Text = ds.Tables(0).Rows(0).Item("Dimension3")
            FrmDimensionDetails.txtsrlno.ReadOnly = True
            FrmDimensionDetails.txtDim1.Focus()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtsrlno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsrlno.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtDim1.Focus()
        End If
    End Sub

    Private Function ValidateOnLeaveSerial() As Boolean

        If (txtsrlno.Text = "") Then
            MsgBox("Serial Number should not be blank, Please Enter the Serial No.", MsgBoxStyle.Critical)
            ValidateOnLeaveSerial = False
        ElseIf IsNumeric(txtsrlno.Text) = False Then
            MsgBox("Serial Number should not be alphanumeric", MsgBoxStyle.Critical)
            ValidateOnLeaveSerial = False

        ElseIf ValidateSerialNos() Then
            Dim sql As String
            sql = "select * from Dimensions where stntserial = '" & Trim(txtsrlno.Text) & "'"
            ds = db.selectQuery(sql)
            If (ds.Tables(0).Rows.Count > 0) Then
                showDimensionGrid()
                MsgBox(" This Serial No is already scanned", MsgBoxStyle.Information)
                txtsrlno.Text = ""
                ValidateOnLeaveSerial = False
                txtsrlno.Focus()
            Else
                txtDim1.Focus()
                ValidateOnLeaveSerial = True
            End If
        Else
            ValidateOnLeaveSerial = False
        End If

    End Function

    Private Sub txtDim1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDim1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) And e.KeyChar = Chr(Keys.Tab) Then
            If (txtDim1.Text = "") Or IsNumeric(txtDim1.Text) = False Then
                MsgBox("Dimension value should not be blank or alphanumeric characters. ", MsgBoxStyle.Critical)
            Else
                txtDim2.Focus()
            End If
        End If
    End Sub

    Private Sub txtDim2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDim2.KeyPress
        If e.KeyChar = Chr(Keys.Enter) And e.KeyChar = Chr(Keys.Tab) Then
            If (txtDim2.Text = "") Or IsNumeric(txtDim2.Text) = False Then
                MsgBox("Dimension value should not be blank or alphanumeric characters.", MsgBoxStyle.Critical)
            Else
                txtDim3.Focus()
            End If
        End If
    End Sub

    Private Sub dgDimension_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        If dgDimension.RowCount > 0 Then

            If UCase(e.Button.ToString) = "LEFT" Then
                sDimSerialNo = dgDimension.Item(1, dgDimension.CurrentRow.Index).Value
            Else
                sDimSerialNo = ""
            End If
            If sDimSerialNo = "" Then
                btnDetails.Enabled = False
            Else
                btnDetails.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtEnter.Text = "" Then
            MsgBox("Enter search text")
        Else
            lblProgress.Visible = True
            Me.Cursor = Cursors.WaitCursor
            Me.Refresh()
            showDimensionGrid()
            lblProgress.Visible = False
            Me.Cursor = Cursors.Arrow
            Me.Refresh()
        End If
    End Sub

    Private Sub btnDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetails.Click
        FrmDimensionDetails.Show()
    End Sub
End Class

