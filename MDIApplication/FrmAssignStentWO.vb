Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports MDIApplication.BioTrackMain

Public Class FrmAssignStentWO

    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim i, TotalSelected As Integer
    Public FGWONo, BatchNo As String
    Public nActualQty, nAssignedQty As Integer

    Private Sub FrmAssignStentWO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillGrid()
    End Sub

    Private Sub FillGrid()
        Try
            'Sql = "select cast(0 as bit) as 'Assign', Item as 'Item Code', stntBatch as 'Batch No', CONVERT(numeric(18,0),QtyIssued) as 'Issued Qty' from zVwWOIssues where workorder ='" & FGWONo & "' and Assigned = 0 and ItemClass = 'CS' order by Item"

            Sql = "select cast(0 as bit) as 'Assign', Item as 'Item Code', stntBatch as 'Batch No', CONVERT(numeric(18,0),QtyIssued) as 'Issued Qty' from zVwWOIssues where workorder ='" & FGWONo & "' and Assigned = 0  and ItemClass = 'RS' order by Item"
            ds = db.selectQuery(Sql)

            dt = ds.Tables(0)
            dgStentWorkOrder.DataSource = dt

            FormatGrid()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        If dt.Rows.Count > 0 Then
            dgStentWorkOrder.ReadOnly = False

            For i = 0 To dgStentWorkOrder.Columns.Count - 1
                dgStentWorkOrder.Columns(i).ReadOnly = True
                dgStentWorkOrder.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                dgStentWorkOrder.Columns(i).Width = 110
            Next

            dgStentWorkOrder.Columns("Assign").ReadOnly = False
            dgStentWorkOrder.Columns("Assign").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgStentWorkOrder.Rows(dt.Rows.Count).ReadOnly = True
        Else
            dgStentWorkOrder.ReadOnly = True
            dgStentWorkOrder.Columns("Assign").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgStentWorkOrder.Columns("Assign").Width = 110
            dgStentWorkOrder.Columns("Item Code").Width = 110
            dgStentWorkOrder.Columns("Batch No").Width = 110
            dgStentWorkOrder.Columns("Issued Qty").Width = 110
        End If
    End Sub

    Private Sub btnAssignBatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignBatch.Click

        TotalSelected = 0

        ' To check the total quantity selected
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("Assign") = True Then
                TotalSelected = dt.Rows(i).Item("Issued Qty") + TotalSelected
                BatchNo = dt.Rows(i).Item("Batch No")
            End If
        Next

        If TotalSelected = 0 Then
            MsgBox("No row selected")
        Else
            If TotalSelected > nActualQty Then   ' (lblActualQty.Text - lblAssignedQty.Text) Then
                'If TotalSelected > clspm.GetAvaialbleSerialNos(Trim(lblWO.Text)) Then   ' (lblActualQty.Text - lblAssignedQty.Text) Then
                MsgBox("Total selection exceeds available Serial Nos")
            Else
                For i = 0 To dt.Rows.Count - 1
                    If dt.Rows(i).Item("Assign") = True Then
                        Sql = "update top (" & dt.Rows(i).Item("Issued Qty") & ") StentSerials set fgwono = '" & FGWONo & "', modifiedby = '" & sLogonUser & "', modifieddate = getdate() where stbatch='" & BatchNo & "' and status=1 and fgwono=''"
                        db.updateQuery(Sql)
                    End If
                Next
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgStentWorkOrder_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim hti As DataGridView.HitTestInfo = Me.dgStentWorkOrder.HitTest(e.X, e.Y)
        Try
            If hti.RowIndex < dt.Rows.Count Then
                If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.ColumnIndex = 0 Then
                    If dt.Rows(hti.RowIndex).Item("Assign") = False Then
                        dt.Rows(hti.RowIndex).Item("Assign") = True
                    Else
                        dt.Rows(hti.RowIndex).Item("Assign") = False
                    End If
                End If
            End If
        Catch ex As System.Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class