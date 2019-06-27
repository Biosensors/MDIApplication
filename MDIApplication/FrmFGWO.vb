Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports MDIApplication.BioTrackMain
Imports System.Drawing
Imports System.Drawing.Color

Public Class FrmFGWO
    Inherits System.Windows.Forms.Form

    Public Sql As String
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim strFGWONo As String
   
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ClearControls()
        txtWoNo.Select()
    End Sub

    Private Sub txtWoNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWoNo.KeyPress
        Try
            If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
                FillGrid()
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FillGrid()
    End Sub

    Private Sub FillGrid()
        Try
            Sql = "select F.fgwono as 'FG Work Order', S.stwono as ' Stent Work Order', count(S.stwono) 'No Of Stents' from StentsByFG F left outer join StentSerials S on F.stntserial = S.stntserial where F.fgwono like '%" & txtWoNo.Text.ToString().Trim & "%' or S.stwono like '%" & txtWoNo.Text.ToString().Trim & "%' group by F.fgwono, S.stwono order by F.fgwono"
            ds = db.selectQuery(Sql)

            dt = ds.Tables(0)
            dgStentSerials.DataSource = dt

            FormatGrid()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgStentSerials.Columns.Count - 1
            dgStentSerials.Columns(i).ReadOnly = True
            dgStentSerials.Columns(i).Width = 172
        Next
    End Sub

    Private Sub ClearControls()
        txtWoNo.Text = ""
        ds.Clear()
        txtWoNo.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgStentSerials_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgStentSerials.DoubleClick
        Try
            If dgStentSerials.CurrentRow.Index < dt.Rows.Count Then

                If dgStentSerials.CurrentRow.Index >= 0 Then
                    If UCase(e.ToString) = "SYSTEM.WINDOWS.FORMS.MOUSEEVENTARGS" Then
                        strFGWONo = Trim(dgStentSerials.CurrentRow.Cells(0).Value.ToString())

                        FrmFGWODetails.txtFGWoNo.Text = strFGWONo
                        FrmFGWODetails.ShowDialog()
                    Else
                        strFGWONo = ""
                    End If
                End If
            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        FrmFGWODetails.txtFGWoNo.Text = ""
        FrmFGWODetails.ShowDialog()
    End Sub

End Class