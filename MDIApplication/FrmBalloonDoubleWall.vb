Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmBalloonDoubleWall
    Inherits System.Windows.Forms.Form

    Public strBlnPartNo As String

    Private Sub FillGrid()
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "select blnpartno as 'Balloon Part No', abs(dwmin) as 'Double Wall Min', dwmax as 'Double Wall Max', distalidmin as 'Distal ID Min', distalidmax as 'Distal ID Max' from blndoublewalldata where blnpartno like '%" & txtBalloonPartNo.Text.ToString().Trim & "%'"
            ds = db.selectQuery(sql)
            dgBalloonDoubleWall.DataSource = ds.Tables(0).DefaultView
            FormatGrid()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgBalloonDoubleWall.Columns.Count - 1
            dgBalloonDoubleWall.Columns(i).ReadOnly = True
            dgBalloonDoubleWall.Columns(i).Width = 132
        Next
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FillGrid()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        FrmAddBalloonDoubleWall.txtBalloonPartNo.Text = ""
        FrmAddBalloonDoubleWall.txtDoubleWallMinValue.Text = ""
        FrmAddBalloonDoubleWall.txtDoubleWallMaxValue.Text = ""
        FrmAddBalloonDoubleWall.txtDistalIDMinValue.Text = ""
        FrmAddBalloonDoubleWall.txtDistalIDMaxValue.Text = ""
        FrmAddBalloonDoubleWall.Text = "Add Balloon Double Wall Data"
        FrmAddBalloonDoubleWall.btnDelete.Enabled = False
        FrmAddBalloonDoubleWall.txtBalloonPartNo.ReadOnly = False
        FrmAddBalloonDoubleWall.txtBalloonPartNo.Select()
        FrmAddBalloonDoubleWall.ShowDialog()
        FillGrid()
    End Sub

    Private Sub dgBalloonDoubleWall_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgBalloonDoubleWall.DoubleClick
        Try
            If dgBalloonDoubleWall.CurrentRow.Index >= 0 Then
                If UCase(e.ToString) = "SYSTEM.WINDOWS.FORMS.MOUSEEVENTARGS" Then
                    strBlnPartNo = Trim(dgBalloonDoubleWall.Item(0, dgBalloonDoubleWall.CurrentRow.Index).Value.ToString())

                    Sql = "select blnpartno,dwmin,dwmax,distalidmin,distalidmax from blndoublewalldata where blnpartno ='" & strBlnPartNo & "'"
                    ds = db.selectQuery(Sql)

                    FrmAddBalloonDoubleWall.txtBalloonPartNo.Text = strBlnPartNo
                    FrmAddBalloonDoubleWall.txtDoubleWallMinValue.Text = Math.Abs(ds.Tables(0).Rows(0).Item("dwmin"))
                    FrmAddBalloonDoubleWall.txtDoubleWallMaxValue.Text = ds.Tables(0).Rows(0).Item("dwmax")
                    FrmAddBalloonDoubleWall.txtDistalIDMinValue.Text = Math.Abs(ds.Tables(0).Rows(0).Item("distalidmin"))
                    FrmAddBalloonDoubleWall.txtDistalIDMaxValue.Text = ds.Tables(0).Rows(0).Item("distalidmax")
                    FrmAddBalloonDoubleWall.Text = "Edit Balloon Double Wall Data"
                    FrmAddBalloonDoubleWall.btnDelete.Enabled = True
                    FrmAddBalloonDoubleWall.txtBalloonPartNo.ReadOnly = True
                    FrmAddBalloonDoubleWall.btnSave.Select()
                    FrmAddBalloonDoubleWall.ShowDialog()
                    FillGrid()
                End If
            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub txtBalloonPartNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBalloonPartNo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            FillGrid()
        End If
    End Sub

End Class