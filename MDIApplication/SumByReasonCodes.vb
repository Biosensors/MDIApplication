Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports MDIApplication.BioTrackMain

Public Class SumByReasonCodes
    Public Sql As String
    Public db As New Class1
    Public clspm As New clsPublic_Methods
    Dim cfg As New ClsConfig
    Dim constr As String = cfg.connectionString
    Public ds As New DataSet
    Public conn As New SqlConnection(constr)
    Dim dt As DataTable

    Protected Sub SumByReasonCosdes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DateTimePicker2.Value = Now()
        DateTimePicker1.Value = DateAdd(DateInterval.Month, -1, Now)
        'FillReasonGrid()
        btnDetails.Enabled = False
    End Sub

    Private Sub FillReasonGrid()
        Dim oCurCursor As Cursor

        Dim ds As New DataSet
        Try
            Sql = "select zz.ReasonCode as [Reason Code], zz.name as Description , zz.Crimping, zz.Sealing,zz.Boxing,"
            Sql = Sql & " CAST((Case when convert(decimal, zz.CrmpTotal) <= 0 then 0 else (zz.crimping/zz.CrmpTotal)* 100  end)as numeric(7,3))   as [Crimp %],"
            Sql = Sql & " CAST((Case when convert(decimal, zz.SEALTotal) = 0 then 0 else (zz.sealing/zz.SEALTotal)* 100 end )as numeric(7,3)) as [Seal %],"
            Sql = Sql & " CAST((Case when convert(decimal, zz.Boxtotal) = 0 then 0 else (zz.boxing/zz.Boxtotal)* 100 end)as numeric(7,3)) as [Box %]"
            Sql = Sql & " from ( SELECT b.reascd1 as ReasonCode, a.dsca as Name,"
            Sql = Sql & " cast(COUNT(CASE WHEN b.oprn = 'CRMP' THEN srlno1 END) as decimal ) AS CRIMPING,"
            Sql = Sql & " cast(COUNT(CASE WHEN b.oprn = 'SEAL' THEN srlno1 END) as decimal) AS SEALING,"
            Sql = Sql & " cast(COUNT(CASE WHEN b.oprn = 'BOX' THEN srlno1 END) as decimal) AS BOXING,"

            Sql = Sql & " (SELECT COUNT(srlno1) FROM OperationLogs AS xx"
            Sql = Sql & " WHERE (oprn = 'CRMP') AND (status = 0) and xx.crdt between '" & DateTimePicker1.Value.ToShortDateString & "' and '" & DateTimePicker2.Value.ToShortDateString & "') AS CrmpTotal,"

            Sql = Sql & " (SELECT COUNT(srlno1) FROM  OperationLogs AS xx"
            Sql = Sql & " WHERE (oprn = 'SEAL') AND (status = 0) and xx.crdt between '" & DateTimePicker1.Value.ToShortDateString & "' and '" & DateTimePicker2.Value.ToShortDateString & "') AS SEALTotal,"

            Sql = Sql & " (SELECT COUNT(srlno1) FROM OperationLogs AS xx"
            Sql = Sql & " WHERE (oprn = 'BOX') AND (status = 0) and xx.crdt between '" & DateTimePicker1.Value.ToShortDateString & "' and '" & DateTimePicker2.Value.ToShortDateString & "') AS BOXTotal"

            Sql = Sql & " FROM  OperationLogs AS b LEFT OUTER JOIN Reasons AS a ON b.reascd1 = a.rejcd"
            Sql = Sql & " WHERE (b.status = 0 and b.crdt between '" & DateTimePicker1.Value.ToShortDateString & "' and '" & DateTimePicker2.Value.ToShortDateString & "')"
            Sql = Sql & " GROUP BY b.reascd1, a.dsca )  zz"

            oCurCursor = Me.Cursor
            Me.Cursor = Cursors.WaitCursor
            ds = db.selectQuery(Sql)

            dgOperation.DataSource = ds.Tables("OperationLogs")
            dt = ds.Tables(0)
            dgOperation.DataSource = dt

            FormatGrid()

            Me.Cursor = oCurCursor
        Catch ex As System.Exception
            MessageBox(Sql)
            MessageBox("Error:  " & ex.Message.ToString())
        End Try

    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgOperation.Columns.Count - 1
            dgOperation.Columns(i).ReadOnly = True
            dgOperation.Columns(i).Width = 114
        Next
    End Sub

    Public Sub MessageBox(ByVal msg As String)
        Dim lbl As New Label()
        lbl.Text = "<script language='javascript'>" & Environment.NewLine & _
                   "window.alert('" + msg + "')</script>"
        Me.Controls.Add(lbl)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        lblProgress.Visible = True
        Me.Cursor = Cursors.WaitCursor
        Me.Refresh()
        FillReasonGrid()
        lblProgress.Visible = False
        Me.Cursor = Cursors.Arrow
        Me.Refresh()
    End Sub

    Private Sub btnDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetails.Click
        ReasonCodeStatus.Show()
    End Sub

    Private Sub dgOperation_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgOperation.MouseClick
        ReasonCodeStatus.lblReasonCodes.Text = ""

        If dgOperation.CurrentRow.Index < dt.Rows.Count Then
            If dgOperation.RowCount > 0 Then
                If UCase(e.Button.ToString) = "LEFT" Then
                    sMainReasonCodes = dgOperation.Item(0, dgOperation.CurrentRow.Index).Value
                    If Not dgOperation.Item(1, dgOperation.CurrentRow.Index).Value.Equals(System.DBNull.Value) Then
                        ReasonCodeStatus.lblReasonCodes.Text = dgOperation.Item(1, dgOperation.CurrentRow.Index).Value
                    Else

                    End If
                Else
                    sMainReasonCodes = ""
                End If
                If sMainReasonCodes = "" Then
                    btnDetails.Enabled = False
                Else
                    btnDetails.Enabled = True
                End If
            End If
        End If
        
    End Sub

End Class