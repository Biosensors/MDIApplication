Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports MDIApplication.BioTrackMain
Imports System.Drawing
Imports System.Drawing.Color

Public Class FrmViewInspectionSerials
    Inherits System.Windows.Forms.Form

    Public Sql As String
    Dim ds, ds0 As New DataSet
    Dim dt As New DataTable
    Private frmParent As MDIForm
    Dim dsSource As New DataSet()
    Public clspm As New clsPublic_Methods
    Private status As Boolean = False
    Public strStentWONo As String
    Dim strSerialNo As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       FillGrid()
    End Sub

    Public Sub FillGrid()
        Try
            Sql = "select s.stntserial as 'Stent Serial', case s.inspnstatus when '1' then 'Accepted' when '0' then 'Rejected' end as 'Inspection Status', case s.inspncode when '' then '' else s.inspncode + ' - ' + r.dsca end as 'Inspection Code', u.uname as 'Operator', convert(varchar(12), s.inspndate, 106) as 'Inspected On' from StentSerials s left join Reasons r on s.inspncode = r.rejcd left join Users u on s.inspnby = u.userid where s.inspnstatus <> -1 and s.stwono = '" & Trim(txtWONo.Text) & "'"
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
            dgStentSerials.Columns(i).Width = 140
        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnReject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReject.Click
        Try
            If btnReject.Text = "Reject" Then
                FrmSerialRejectReason.txtStentSerial.Text = dgStentSerials.Item(0, dgStentSerials.CurrentRow.Index).Value.ToString
                FrmSerialRejectReason.lblRejectionType.Text = "InspectionStatus"
                FrmSerialRejectReason.ShowDialog()

            ElseIf btnReject.Text = "Undo Reject" Then
                Sql = "update StentSerials set inspnstatus=1,inspncode='', modifiedby = '" & sLogonUser & "' , modifieddate=getdate() where stntserial = '" & Trim(dgStentSerials.Item(0, dgStentSerials.CurrentRow.Index).Value.ToString) & "'"
                db.updateQuery(Sql)
                FillGrid()
            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub dgStentSerials_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgStentSerials.Click
        Try
            If dgStentSerials.CurrentRow.Index < dt.Rows.Count Then
                If dgStentSerials.CurrentRow.Index >= 0 Then
                    If UCase(e.ToString) = "SYSTEM.WINDOWS.FORMS.MOUSEEVENTARGS" Then
                        btnReject.Enabled = True
                        If dgStentSerials.Item(1, dgStentSerials.CurrentRow.Index).Value.ToString = "Accepted" Then
                            btnReject.Text = "Reject"
                        ElseIf dgStentSerials.Item(1, dgStentSerials.CurrentRow.Index).Value.ToString = "Rejected" Then
                            btnReject.Text = "Undo Reject"
                        End If
                    Else
                        btnReject.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtWONo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWONo.TextChanged

    End Sub
End Class