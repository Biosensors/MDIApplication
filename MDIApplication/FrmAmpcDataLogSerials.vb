Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports MDIApplication.BioTrackMain

Public Class FrmAmpcDataLogSerials

    Public sFillCategory As String
    Dim sWoNo As String

    Private Sub FrmAssignedSerials_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sWoNo = Trim(txtWoNo.Text)
        FillGrid(sFillCategory, sWoNo)
    End Sub

    Private Sub FillGrid(ByVal sFillCategory As String, ByVal sWoNo As String)
        Try
            Dim sql As String = ""
            Dim ds As New DataSet

            If sFillCategory = "NoAmpcCoating" Then
                sql = "select stntserial as 'Stent Serial' from stentserials where stbatch = '" & sWoNo & "' and stntserial not in (select stentid from ampcdata where shoporderid = '" & sWoNo & "') order by stntserial"

            ElseIf sFillCategory = "InvalidStentSerials" Then
                sql = "select stentid as 'Stent Serial' from ampcdata where shoporderid = '" & sWoNo & "' and stentid not in (select stntserial from stentserials where stbatch = '" & sWoNo & "') order by stentid"

            ElseIf sFillCategory = "DuplicateStentSerials" Then
                sql = "select stentid as 'Stent Serial', count(stentid) as 'Count' from ampcdata where shoporderid = '" & sWoNo & "' group by stentid having count(stentid) > 1"
            End If

            ds = db.selectQuery(sql)
            dgStentSerials.DataSource = ds.Tables(0).DefaultView

            If sFillCategory = "NoAmpcCoating" Then
                FormatGrid(171)
            ElseIf sFillCategory = "InvalidStentSerials" Then
                FormatGrid(171)
            ElseIf sFillCategory = "DuplicateStentSerials" Then
                FormatGrid(94)
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FormatGrid(ByVal Width As Integer)
        Dim i As Integer
        For i = 0 To dgStentSerials.Columns.Count - 1
            dgStentSerials.Columns(i).ReadOnly = True
            dgStentSerials.Columns(i).Width = Width
        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class