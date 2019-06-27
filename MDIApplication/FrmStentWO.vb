Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports MDIApplication.BioTrackMain
Imports System.Drawing
Imports System.Drawing.Color

Public Class FrmStentWO
    Inherits System.Windows.Forms.Form

    Public Sql As String
    Dim ds As New DataSet
    Dim dt As New DataTable
    Private frmParent As MDIForm
    Dim dsSource As New DataSet()
    Public clspm As New clsPublic_Methods
    Private status As Boolean = False
    Dim strStentWONo As String
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ClearControls()
        FillGrid()
    End Sub

    Private Sub txtwrkordno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtwrkordno.KeyPress

        Dim bWorkOrderFound As Boolean

        Try
            If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then

                lblBatch.Text = ""
                lblItem.Text = ""
                lblItemDesc.Text = ""
                lblTotalStents.Text = ""

                bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtwrkordno.Text))

                txtwrkordno.Text = stWODetails.sWorkOrderNo
                lblItem.Text = stWODetails.sItemCode
                lblItemDesc.Text = stWODetails.sItemDescription
                lblBatch.Text = stWODetails.sBatchNo
                lblTotalStents.Text = stWODetails.nActualQty

                If Not (bWorkOrderFound) Then
                    MsgBox("Invalid Work Order")
                    ClearControls()
                    Exit Sub
                End If

                FillNoOfAssginedWO()
                FillGrid()
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillNoOfAssginedWO()
        Try
            'Sql = "select count(stntserial) as TotalAssignedQty from stentserials where stenttype =1 and stwono = '" & Me.txtwrkordno.Text.Trim.ToString() & "' and stbatch <> '' "
            Sql = "select count(stntserial) as TotalAssignedQty from stentserials where stenttype =1 and fgwono = '" & Me.txtwrkordno.Text.Trim.ToString() & "'"
            ds = db.selectQuery(Sql)
            lblAssignedQty.Text = ds.Tables(0).Rows(0).Item("TotalAssignedQty")
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillGrid()
        Try
            'Sql = "select Item as 'Item Code', stntBatch as 'Batch No', CONVERT(numeric(18,0),QtyIssued) as 'Assigned Qty' from zVwWOIssues where workorder ='" & Trim(txtwrkordno.Text) & "' and Assigned <> 0 order by Item"
            If Trim(txtwrkordno.Text) <> "" Then
                Sql = "select distinct stwono as 'Stent WO', stbatch as 'Batch No' from stentserials where fgwono ='" & Trim(txtwrkordno.Text) & "'"
                ds = db.selectQuery(Sql)

                dt = ds.Tables(0)
                dgStentWorkOrder.DataSource = dt

                If ds.Tables(0).Rows.Count > 0 Then
                    btnViewSerials.Enabled = True
                Else
                    btnViewSerials.Enabled = False
                End If

                FormatGrid()
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgStentWorkOrder.Columns.Count - 1
            dgStentWorkOrder.Columns(i).ReadOnly = True
            dgStentWorkOrder.Columns(i).Width = 160
        Next
    End Sub

    'Private Sub btnNewWoNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewWoNo.Click
    '    ClearControls()
    '    FillGrid()
    'End Sub

    Private Sub btnAssignBatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignBatch.Click

        Dim frmAssignStentWO As New FrmAssignStentWO
        If Trim(txtwrkordno.Text) = "" Then
            MsgBox("Enter Work Order")
            txtwrkordno.Focus()
        Else
            frmAssignStentWO.FGWONo = Trim(txtwrkordno.Text)
            frmAssignStentWO.BatchNo = Trim(lblBatch.Text)
            frmAssignStentWO.nActualQty = CInt(lblTotalStents.Text)
            frmAssignStentWO.nAssignedQty = CInt(lblAssignedQty.Text)
            frmAssignStentWO.ShowDialog()
            FillNoOfAssginedWO()
            FillGrid()
        End If
    End Sub

    Private Sub btnAssignedSerials_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewSerials.Click
        Dim frmAssignedSerials As New FrmAssignedSerials

        If Trim(txtwrkordno.Text) = "" Then
            MsgBox("Enter Work Order")
            txtwrkordno.Focus()
        Else
            strStentWONo = Trim(dgStentWorkOrder.CurrentRow.Cells("Stent WO").Value.ToString())

            If strStentWONo = "" Then
                MsgBox("Select Stent Work Order")
            Else
                frmAssignedSerials.txtWoNo.Text = strStentWONo
                frmAssignedSerials.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ClearControls()
        txtwrkordno.ReadOnly = False
        txtwrkordno.Text = ""
        lblBatch.Text = ""
        lblItem.Text = ""
        lblItemDesc.Text = ""
        lblTotalStents.Text = ""
        lblAssignedQty.Text = ""
        btnViewSerials.Enabled = False
        ds.Clear()
        txtwrkordno.Focus()
    End Sub

End Class