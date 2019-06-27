Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports MDIApplication.BioTrackMain

Public Class OperationGrid
    Public tabSelected As String
    Public Sql As String
    Public ds As New DataSet
    Public dtAccepted, dtRejected As DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        showAcceptedGrid(1)
        btnDetails.Enabled = False
    End Sub

    Private Sub showAcceptedGrid(ByVal intValue As Integer)
        Dim ds As New DataSet
        Try
            If Trim(txtEnter.Text) = "" Then
                'convert(varchar(12), a.crdt, 106) as ScannedDate,
                Sql = "SELECT a.wono as 'WorkOrder No', b.facode as 'Batch No', b.ItemCode as 'Item Code', b.itemdesc as 'Item Description',"
                Sql = Sql & " COUNT(CASE WHEN a.oprn = 'CRMP' and a.status=1 THEN a.srlno1 END) AS Crimping,"
                Sql = Sql & " COUNT(CASE WHEN a.oprn = 'SEAL' and a.status=1 THEN a.srlno1 END) AS Sealing, "
                Sql = Sql & " COUNT(CASE WHEN a.oprn = 'BOX' and a.status=1 THEN a.srlno1 END) AS Boxing "
                Sql = Sql & " FROM OperationLogs AS a LEFT OUTER JOIN ZWOList AS b "
                Sql = Sql & " ON a.wono = b.project "
                ' Sql = Sql & " where datediff(dd,crdt,getdate()) <= 90"
                'a.crdt,
                Sql = Sql & " GROUP BY a.wono, b.facode, b.ItemCode, b.itemdesc"
                '  Sql = Sql & " ORDER BY crdt desc "
            Else
                'convert(varchar(12), a.crdt, 106) as ScannedDate,
                Sql = "SELECT a.wono as 'WorkOrder No', b.facode as 'Batch No', b.ItemCode as 'Item Code', b.itemdesc as 'Item Description',"
                Sql = Sql & " COUNT(CASE WHEN a.oprn = 'CRMP' and a.status=1 THEN a.srlno1 END) AS Crimping,"
                Sql = Sql & " COUNT(CASE WHEN a.oprn = 'SEAL' and a.status=1 THEN a.srlno1 END) AS Sealing, "
                Sql = Sql & " COUNT(CASE WHEN a.oprn = 'BOX' and a.status=1 THEN a.srlno1 END) AS Boxing "
                Sql = Sql & " FROM OperationLogs AS a LEFT OUTER JOIN ZWOList AS b "
                Sql = Sql & " ON a.wono = b.project "
                Sql = Sql & " where a.wono like '" & Trim(Me.txtEnter.Text).ToString() & "%'  or b.facode like '" & Trim(Me.txtEnter.Text).ToString() & "%'"
                Sql = Sql & " or b.ItemCode like '" & Trim(Me.txtEnter.Text).ToString() & "%' or b.itemdesc like '" & Trim(Me.txtEnter.Text).ToString() & "%'"
                'a.crdt,
                Sql = Sql & " GROUP BY a.wono, b.facode,b.ItemCode, b.itemdesc"
            End If

            ds = db.selectQuery(Sql)
            dtAccepted = ds.Tables(0)
            dgAccepted.DataSource = dtAccepted
            'dgAccepted.DataSource = ds.Tables(0).DefaultView

            FormatAcceptedGrid()

            sStentDS = ds
            'ds = Nothing

        Catch ex As System.Exception
            MessageBox(Sql)
            MessageBox("Error:  " & ex.Message.ToString())
        End Try

    End Sub

    Private Sub showRejectedGrid(ByVal intValue As Integer)
        Dim ds As New DataSet
        Try
            If Trim(txtEnter.Text) = "" Then
                'convert(varchar(12), a.crdt, 106) as ScannedDate,
                Sql = "SELECT a.wono as 'WorkOrder No', b.facode as 'Batch No', b.ItemCode as 'Item Code', b.itemdesc as 'Item Description',"
                Sql = Sql & " COUNT(CASE WHEN a.oprn = 'CRMP' and a.status=0 THEN a.srlno1 END) AS Crimping, "
                Sql = Sql & " COUNT(CASE WHEN a.oprn = 'SEAL' and a.status=0 THEN a.srlno1 END) AS Sealing, "
                Sql = Sql & " COUNT(CASE WHEN a.oprn = 'BOX' and a.status=0 THEN a.srlno1 END) AS Boxing "
                Sql = Sql & " FROM OperationLogs AS a LEFT OUTER JOIN ZWOList AS b "
                Sql = Sql & " ON a.wono = b.project "
                '  Sql = Sql & " where datediff(dd,crdt,getdate()) <= 90"
                'a.crdt,
                Sql = Sql & " GROUP BY a.wono, b.facode, b.ItemCode, b.itemdesc"
                'Sql = Sql & " ORDER BY crdt desc "
            Else
                'convert(varchar(12), a.crdt, 106) as ScannedDate,
                Sql = "SELECT a.wono as 'WorkOrder No', b.facode as 'Batch No', b.ItemCode as 'Item Code', b.itemdesc as 'Item Description',"
                Sql = Sql & " COUNT(CASE WHEN a.oprn = 'CRMP' and a.status=0 THEN a.srlno1 END) AS Crimping, "
                Sql = Sql & " COUNT(CASE WHEN a.oprn = 'SEAL' and a.status=0 THEN a.srlno1 END) AS Sealing, "
                Sql = Sql & " COUNT(CASE WHEN a.oprn = 'BOX' and a.status=0 THEN a.srlno1 END) AS Boxing "
                Sql = Sql & " FROM OperationLogs AS a LEFT OUTER JOIN ZWOList AS b "
                Sql = Sql & " ON a.wono = b.project "
                Sql = Sql & " where a.wono like '" & Trim(Me.txtEnter.Text).ToString() & "%'  or b.facode like '" & Trim(Me.txtEnter.Text).ToString() & "%'"
                Sql = Sql & " or b.ItemCode like '" & Trim(Me.txtEnter.Text).ToString() & "%' or b.itemdesc like '" & Trim(Me.txtEnter.Text).ToString() & "%'"
                'a.crdt,
                Sql = Sql & " GROUP BY a.wono, b.facode,b.ItemCode, b.itemdesc"
            End If
            ds = db.selectQuery(Sql)
            dtRejected = ds.Tables(0)
            dgRejected.DataSource = dtRejected
            'dgRejected.DataSource = ds.Tables(0).DefaultView

            FormatRejectedGrid()

            sStentDS = ds
            ' ds = Nothing

        Catch ex As System.Exception
            MessageBox(Sql)
            MessageBox("Error:  " & ex.Message.ToString())
        End Try
    End Sub

    Private Sub FormatAcceptedGrid()
        Dim i As Integer
        For i = 0 To dgAccepted.Columns.Count - 1
            dgAccepted.Columns(i).ReadOnly = True
            dgAccepted.Columns(i).Width = 130
        Next
    End Sub

    Private Sub FormatRejectedGrid()
        Dim i As Integer
        For i = 0 To dgRejected.Columns.Count - 1
            dgRejected.Columns(i).ReadOnly = True
            dgRejected.Columns(i).Width = 130
        Next
    End Sub

    Public Sub MessageBox(ByVal msg As String)
        Dim lbl As New Label()
        lbl.Text = "<script language='javascript'>" & Environment.NewLine & _
                   "window.alert('" + msg + "')</script>"
        Me.Controls.Add(lbl)
    End Sub

    'Private Sub txtEnter_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEnter.KeyPress
    '    If e.KeyChar = Chr(Keys.Enter) Then
    '        If (tbOperationGrid.SelectedIndex = 0) Then
    '            tabSelected = "Accepted"
    '            showAcceptedGrid(1)
    '        Else
    '            tabSelected = "Rejected"
    '            showRejectedGrid(1)
    '        End If
    '        e.Handled = True
    '    End If

    'End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        lblProgress.Visible = True
        Me.Cursor = Cursors.WaitCursor
        Me.Refresh()

        If (Trim(Not (txtEnter.Text) = String.Empty)) Or (tabSelected = "Accepted") Then
            showAcceptedGrid(1)
        Else
            showRejectedGrid(1)
        End If

        lblProgress.Visible = False
        Me.Cursor = Cursors.Arrow
        Me.Refresh()
    End Sub

    Private Sub btnDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetails.Click
        OprnByStatus.Show()
    End Sub

    Private Sub btnSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnSearch.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If (tbOperationGrid.SelectedIndex = 0) Then
                tabSelected = "Accepted"
                showAcceptedGrid(1)
            Else
                tabSelected = "Rejected"
                showRejectedGrid(1)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub dgRejected_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgRejected.MouseClick
        OprnByStatus.lblBN.Text = ""
        OprnByStatus.lblIC.Text = ""
        OprnByStatus.lblWO.Text = ""

        If UCase(e.Button.ToString) = "LEFT" Then
            If dgRejected.CurrentRow.Index < dtRejected.Rows.Count Then
                sMainWorkOrderNO = dgRejected.Item(0, dgRejected.CurrentRow.Index).Value
                OprnByStatus.lblBN.Text = dgRejected.Item(1, dgRejected.CurrentRow.Index).Value
                OprnByStatus.lblIC.Text = dgRejected.Item(2, dgRejected.CurrentRow.Index).Value
                OprnByStatus.lblWO.Text = sMainWorkOrderNO
                OprnByStatus.txtstatus.Text = 0
                OprnByStatus.lblStatus.Text = "Rejected"
            Else
                sMainWorkOrderNO = ""
            End If
        Else
            sMainWorkOrderNO = ""
        End If
        If sMainWorkOrderNO = "" Then
            btnDetails.Enabled = False
        Else
            btnDetails.Enabled = True
        End If
    End Sub

    Private Sub tbOperationGrid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbOperationGrid.SelectedIndexChanged
        If (tbOperationGrid.SelectedIndex = 0) Then
            tabSelected = "Accepted"
            showAcceptedGrid(1)
        Else
            tabSelected = "Rejected"
            showRejectedGrid(1)
        End If
    End Sub

    Private Sub tbOperationGrid_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbOperationGrid.TabIndexChanged
        If (tbOperationGrid.SelectedIndex = 0) Then
            tabSelected = "Accepted"
            showAcceptedGrid(1)
        Else
            tabSelected = "Rejected"
            showRejectedGrid(1)
        End If
    End Sub

    Private Sub dgAccepted_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgAccepted.MouseClick
        OprnByStatus.lblBN.Text = ""
        OprnByStatus.lblIC.Text = ""
        OprnByStatus.lblWO.Text = ""

        If UCase(e.Button.ToString) = "LEFT" Then
            If dgAccepted.CurrentRow.Index < dtAccepted.Rows.Count Then
                sMainWorkOrderNO = Trim(dgAccepted.Item(0, dgAccepted.CurrentRow.Index).Value)
                OprnByStatus.lblBN.Text = dgAccepted.Item(1, dgAccepted.CurrentRow.Index).Value
                OprnByStatus.lblIC.Text = dgAccepted.Item(2, dgAccepted.CurrentRow.Index).Value
                OprnByStatus.lblWO.Text = sMainWorkOrderNO
                OprnByStatus.txtstatus.Text = 1
                OprnByStatus.lblStatus.Text = "Accepted"
            Else
                sMainWorkOrderNO = ""
            End If
        Else
            sMainWorkOrderNO = ""
        End If
        If sMainWorkOrderNO = "" Then
            btnDetails.Enabled = False
        Else
            btnDetails.Enabled = True
        End If
    End Sub

End Class