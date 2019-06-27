
Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Reflection
Imports MDIApplication.BioTrackMain
Public Class FrmDimensionDetails
    Public db As New Class1
    Public clspm As New clsPublic_Methods
    Public sql As String
    Public dsSource As New DataSet()
    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dsSource = dsDimension

        If (dsSource.Tables(0).Rows.Count > 0) Then

            AssignDimValue(dsDimension.Tables(0))

            'If Not Trim(txtsrlno.Text) = "" Then
            '    getDimensionDetails(txtsrlno.Text)
            'End If
        End If
    End Sub

    Private Sub AssignDimValue(ByVal dt As DataTable)

        Dim drSelect As DataRow() = dt.Select("[WorkOrder No.] ='" & Trim(sDimSerialNo) & "'")
        If drSelect.Length > 0 Then
            lblwono.Text = drSelect(0).Item(("WorkOrder No.")).ToString
            lblItemcode.Text = drSelect(0)("Item Code")
            lblDescription.Text = drSelect(0)("Item Description")

            txtsrlno.Text = drSelect(0)("SerialNo")
            txtDim1.Text = drSelect(0)("Dimension1")
            txtDim2.Text = drSelect(0)("Dimension2")
            txtDim3.Text = drSelect(0)("Dimension3")
            txtsrlno.ReadOnly = True
            txtDim1.Focus()
        End If
    End Sub
    'Private Sub getDimensionDetails(ByVal strValue As String)
    '    Dim id As String = FrmDimension.id
    '    ' Me.lblwono.Text = FrmDimension.id1 ' workorder no
    '    ' Me.lblItemcode.Text = FrmDimension.id2 ' item code
    '    ' Me.lblDescription.Text = FrmDimension.id3 ' itemdescription

    '    sql = ""
    '    sql = "select srlno as [Serial No.],CONVERT(numeric(5, 4), dim1) as [Dimension1], CONVERT(numeric(5, 4), dim2) as [Dimension2],"
    '    sql = sql & " CAST((CASE WHEN CONVERT(decimal, dim3) IS NULL THEN 0 ELSE dim3 END) AS numeric(5, 4)) AS [Dimension3]"
    '    sql = sql & " from Dimensions where srlno = '" & id & "'"
    '    ds = db.selectQuery(sql)
    '    If (ds.Tables(0).Rows.Count > 0) Then
    '        Me.txtsrlno.Text = ds.Tables(0).Rows(0).Item("Serial No.")
    '        Me.txtDim1.Text = ds.Tables(0).Rows(0).Item("Dimension1")
    '        Me.txtDim2.Text = ds.Tables(0).Rows(0).Item("Dimension2")
    '        Me.txtDim3.Text = ds.Tables(0).Rows(0).Item("Dimension3")
    '        Me.txtsrlno.ReadOnly = True
    '        Me.txtDim1.Focus()
    '    End If
    'End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        sql = ""
        sql = "update Dimensions set dim1 = '" & Trim(txtDim1.Text) & "', dim2='" & Trim(txtDim2.Text) & "', dim3='" & Trim(txtDim3.Text) & "' where stntserial='" & Trim(txtsrlno.Text) & "'"
        db.updateQuery(sql)
        MsgBox("Data Updated", MsgBoxStyle.Information)
        Me.Close()

        FrmDimension.Show()
        'showDimensionGrid()
    End Sub

    Private Sub btnSave_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnSave.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtDim1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDim1.Leave
        If (txtDim1.Text = "") Then
            MsgBox("Please enter the dimension value", MsgBoxStyle.Critical)
        ElseIf IsNumeric(txtDim1.Text) = False Then
            MsgBox("Dimension value should not be alphanumeric", MsgBoxStyle.Critical)
            txtDim1.Focus()
        End If
    End Sub

    Private Sub txtDim2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDim2.Leave
        If (txtDim2.Text = "") Then
            MsgBox("Please enter the dimension value", MsgBoxStyle.Critical)
        ElseIf IsNumeric(txtDim2.Text) = False Then
            MsgBox("Dimension value should not be alphanumeric", MsgBoxStyle.Critical)
            txtDim2.Focus()
        End If
    End Sub

    Private Sub txtDim3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDim3.Leave
        If (txtDim3.Text = "") Then
            MsgBox("Please enter the dimension value", MsgBoxStyle.Critical)
        ElseIf IsNumeric(txtDim3.Text) = False Then
            MsgBox("Dimension value should not be alphanumeric", MsgBoxStyle.Critical)
            txtDim3.Focus()
        End If
    End Sub
End Class