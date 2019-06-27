Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports MDIApplication.BioTrackMain

Public Class SumBySerial
    Public Sql As String
    Public db As New Class1
    Public clspm As New clsPublic_Methods
    Dim cfg As New ClsConfig
    Dim constr As String = cfg.connectionString
    Public ds As New DataSet
   
    Protected Sub SumbySerial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmbStatus.Text = " << Search by >> "
        cmbStatus.Items.Insert(0, "Rejected")
        cmbStatus.Items.Insert(1, "Accepted")
        cmbStatus.Items.Insert(2, "Both")

        cmbStatus.SelectedIndex = 0

        cmbColumns.Text = "<< Search by >>"
        cmbColumns.Items.Insert(0, "Serial No.")
        cmbColumns.Items.Insert(1, "WorkOrder No.")
        cmbColumns.Items.Insert(2, "Batch No.")
        cmbColumns.Items.Insert(3, "Item Code")
        DateTimePicker2.Value = Now()
        DateTimePicker1.Value = DateAdd(DateInterval.Month, -1, Now)
        'FillSerialGrid(1)
    End Sub

    Private Sub FillSerialGrid(ByVal intValue As Integer)
        Dim ds As New DataSet
        ' Dim sFldColumnsName As String
        Dim conn As New SqlConnection(constr)
        Try
            sFldColumnsName = ""
            Select Case cmbColumns.SelectedIndex
                Case Is = 0
                    sFldColumnsName = "srlno1"
                    Exit Select
                Case Is = 1
                    sFldColumnsName = "wono"
                    Exit Select
                Case Is = 2
                    sFldColumnsName = "facode"
                    Exit Select
                Case Is = 3
                    sFldColumnsName = "ItemCode"
                    Exit Select
            End Select
           
            Sql = ""
            Sql = Sql & " select a.srlno1 as 'Serial No',a.wono as 'WorkOrder No',b.facode as 'Batch No',b.ItemCode as 'Item Code', "
            Sql = Sql & " a.crdt as 'Scanned Date', isnull(a.crby,a.mdby) as 'Scanned By', (case when ltrim(rtrim(a.status)) = 1 then '' else c.dsca end ) as 'Reason Code' "
            Sql = Sql & " from OperationLogs a Left outer join ZWOList b on a.wono = b.project "
            Sql = Sql & " Left outer join Reasons c on a.reascd1 = c.rejcd "
            'Sql = Sql & " where  ( datediff(dd,a.crdt," & DateTimePicker1.Value.ToShortDateString & ") >= 0 "
            Sql = Sql & " where ( a.crdt between '" & DateTimePicker1.Value.ToShortDateString & "' and '" & DateTimePicker2.Value.ToShortDateString & "') "
            If cmbStatus.SelectedIndex < 2 Then
                Sql = Sql & " and a.status = " & cmbStatus.SelectedIndex
            End If
            If Not (sFldColumnsName = "" Or txtEnter.Text = "") Then
                Sql = Sql & " and " & sFldColumnsName & " like '" & Trim(txtEnter.Text) & "%'"
            End If
            Sql = Sql & " order by a.crdt desc "
            ds = db.selectQuery(Sql)
            'dgSerial.DataSource = ds.Tables("ZWOList")
            dgSerial.DataSource = ds.Tables(0).DefaultView

            If (cmbStatus.SelectedIndex = 1) Then
                HideShowColumns(dgSerial, "True")
            Else
                HideShowColumns(dgSerial, "False")
            End If

            FormatGrid()

        Catch ex As System.Exception
            MessageBox(Sql)
            MessageBox("Error:  " & ex.Message.ToString())

        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgSerial.Columns.Count - 1
            dgSerial.Columns(i).ReadOnly = True
            dgSerial.Columns(i).Width = 120
        Next
    End Sub

    Public Sub MessageBox(ByVal msg As String)
        Dim lbl As New Label()
        lbl.Text = "<script language='javascript'>" & Environment.NewLine & _
                   "window.alert('" + msg + "')</script>"

        Me.Controls.Add(lbl)
    End Sub

    Private Sub HideShowColumns(ByVal dg As DataGridView, ByVal strValue As String)
        If (strValue = "True") Then
            dg.Columns(6).Visible = False
        Else
            dg.Columns(6).Visible = True
        End If
    End Sub
  
    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  FillSerialGrid(2)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtEnter.Text = "" Then
            MsgBox("Enter search text")
        Else
            lblProgress.Visible = True
            Me.Cursor = Cursors.WaitCursor
            Me.Refresh()
            FillSerialGrid(2)
            lblProgress.Visible = False
            Me.Cursor = Cursors.Arrow
            Me.Refresh()
        End If
    End Sub
End Class