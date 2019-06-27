Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports MDIApplication.BioTrackMain

Public Class FrmAssignedSerials

    Private Sub FrmAssignedSerials_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillGrid()
    End Sub

    Private Sub FillGrid()
        Try
            Dim sql As String
            Dim ds As New DataSet

            sql = "select stntserial as 'Stent Serial', stbatch as 'Batch No' from stentserials where stwono = '" & txtWoNo.Text & "' and stbatch <> '' and status = 1 and stenttype = 1 order by stntserial"
            ds = db.selectQuery(sql)
            dgStentSerials.DataSource = ds.Tables(0).DefaultView

            FormatGrid()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgStentSerials.Columns.Count - 1
            dgStentSerials.Columns(i).ReadOnly = True
            dgStentSerials.Columns(i).Width = 120
        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class