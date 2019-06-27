Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmStandardWeight
    Inherits System.Windows.Forms.Form

    Public strStentID As String

    Private Sub FillGrid()
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "select stentid as 'Stent ID', stdweight as 'Standard Weight', abs(mintolerance) as 'Min Weight Limit', maxtolerance as 'Max Weight Limit' from stdweight where stentid like '%" & txtStentID.Text.ToString().Trim & "%'"
            ds = db.selectQuery(sql)
            dgStandardWeight.DataSource = ds.Tables(0).DefaultView
            FormatGrid()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgStandardWeight.Columns.Count - 1
            dgStandardWeight.Columns(i).ReadOnly = True
            dgStandardWeight.Columns(i).Width = 130
        Next
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FillGrid()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgStandardWeight_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgStandardWeight.DoubleClick
        Try
            If dgStandardWeight.CurrentRow.Index >= 0 Then
                If UCase(e.ToString) = "SYSTEM.WINDOWS.FORMS.MOUSEEVENTARGS" Then
                    strStentID = Trim(dgStandardWeight.Item(0, dgStandardWeight.CurrentRow.Index).Value.ToString())

                    Sql = "select stdweight,mintolerance,maxtolerance from stdweight where stentid='" & strStentID & "'"
                    ds = db.selectQuery(Sql)

                    FrmAddStandardWeight.txtStentID.Text = strStentID
                    FrmAddStandardWeight.txtWeight.Text = ds.Tables(0).Rows(0).Item("stdweight")
                    FrmAddStandardWeight.txtMinWeightLimit.Text = Math.Abs(ds.Tables(0).Rows(0).Item("mintolerance"))
                    FrmAddStandardWeight.txtMaxWeightLimit.Text = ds.Tables(0).Rows(0).Item("maxtolerance")
                    FrmAddStandardWeight.Text = "Edit Standard Weight"
                    FrmAddStandardWeight.btnDelete.Enabled = True
                    FrmAddStandardWeight.txtStentID.ReadOnly = True
                    FrmAddStandardWeight.ShowDialog()
                    FillGrid()
                End If
            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        FrmAddStandardWeight.txtStentID.Text = ""
        FrmAddStandardWeight.txtWeight.Text = ""
        FrmAddStandardWeight.txtMinWeightLimit.Text = ""
        FrmAddStandardWeight.txtMaxWeightLimit.Text = ""
        FrmAddStandardWeight.Text = "Add Standard Weight"
        FrmAddStandardWeight.btnDelete.Enabled = False
        FrmAddStandardWeight.txtStentID.ReadOnly = False
        FrmAddStandardWeight.ShowDialog()
        FillGrid()
    End Sub

    Private Sub txtStentID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStentID.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            FillGrid()
        End If
    End Sub
End Class