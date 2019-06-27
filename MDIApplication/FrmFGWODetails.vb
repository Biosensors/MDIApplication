Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports MDIApplication.BioTrackMain
Imports System.Drawing
Imports System.Drawing.Color

Public Class FrmFGWODetails
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
        ClearControls()
        If txtFGWoNo.Text <> "" Then
            FillWorkOrderDetails()
        End If
        txtFGWoNo.Select()
    End Sub

    Private Sub txtFGWoNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFGWoNo.KeyPress
        Try
            If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
                FillWorkOrderDetails()
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillWorkOrderDetails()

        Dim bWorkOrderFound As Boolean

        lblBatch.Text = ""
        lblItem.Text = ""
        lblItemDesc.Text = ""
        lblActualQty.Text = ""

        bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtFGWoNo.Text))

        txtFGWoNo.Text = stWODetails.sWorkOrderNo
        lblItem.Text = stWODetails.sItemCode
        lblItemDesc.Text = stWODetails.sItemDescription
        lblBatch.Text = stWODetails.sBatchNo
        lblActualQty.Text = stWODetails.nActualQty

        If Not (bWorkOrderFound) Then
            MsgBox("Invalid Work Order")
            ClearControls()
            Exit Sub
        End If

        FillGrid()

    End Sub

    Private Sub FillGrid()
        Try
            Sql = "select cast(0 as bit) as 'Delete', F.stntserial as 'Stent Serial', cast(sum(Case when O.oprn = 'CRMP' then 1 else 0 end) as bit) as Crimp, cast(sum(Case when O.oprn = 'SEAL' then 1 else 0 end) as bit) as Seal, cast(sum(Case when O.oprn = 'BOX' then 1 else 0 end) as bit) as Box from StentsByFG F left outer join OperationLogs O on F.stntserial = O.srlno1 where F.fgwono ='" & Trim(txtFGWoNo.Text) & "' group by F.stntserial order by F.stntserial"
            ds = db.selectQuery(Sql)

            dt = ds.Tables(0)
            dgStentSerials.DataSource = dt

            FormatGrid()

            lblAssignedQty.Text = ds.Tables(0).Rows.Count

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("Crimp") = True Or dt.Rows(i).Item("Seal") = True Or dt.Rows(i).Item("Box") = True Then
                    dgStentSerials.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                    dgStentSerials.Rows(i).ReadOnly = True
                End If
            Next
        End If

        If dt.Rows.Count >= 0 Then
            dgStentSerials.Rows(i).ReadOnly = True
        End If

        For i = 0 To dgStentSerials.Columns.Count - 1
            dgStentSerials.Columns(i).ReadOnly = True
            dgStentSerials.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        dgStentSerials.Columns("Delete").ReadOnly = False
        dgStentSerials.Columns("Stent Serial").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft

    End Sub

    Private Sub ClearControls()
        lblBatch.Text = ""
        lblItem.Text = ""
        lblItemDesc.Text = ""
        lblActualQty.Text = ""
        ds.Clear()
        FillGrid()
        lblAssignedQty.Text = ""
        txtFGWoNo.Focus()
    End Sub

    Private Sub btnAssignCoatedStents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignCoatedStents.Click
        ' Dim frmAssignCoatedStents As New FrmAssignCoatedStents
        ' Comment by Ali, 18.MAY.2018
        Dim FrmAssignCoatedStentRange As New FrmAssignCoatedStentRange

        If Trim(txtFGWoNo.Text) = "" Then
            MsgBox("Enter Work Order")
            txtFGWoNo.Focus()
        Else
            FrmAssignCoatedStentRange.txtFGWoNo.Text = txtFGWoNo.Text
            FrmAssignCoatedStentRange.lblItem.Text = lblItem.Text
            FrmAssignCoatedStentRange.lblItemDesc.Text = lblItemDesc.Text
            FrmAssignCoatedStentRange.lblBatch.Text = lblBatch.Text
            FrmAssignCoatedStentRange.lblQty.Text = lblActualQty.Text

            ' frmAssignCoatedStents.ShowDialog()  ' Ali, 18.May.2018
            FrmAssignCoatedStentRange.ShowDialog()
            FillGrid()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim Ans As Integer
        Dim i As Integer
        Dim deleteFlag As Boolean
        deleteFlag = False

        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("Delete") = True Then
                deleteFlag = True
            End If
        Next

        If deleteFlag = True Then
            Ans = MsgBox("Are you sure want to delete these serial numbers?", vbYesNo + vbExclamation)

            If Ans = vbYes Then
                For i = 0 To dt.Rows.Count - 1
                    If dt.Rows(i).Item("Delete") = True Then
                        strSerialNo = dt.Rows(i).Item("Stent Serial")
                        Sql = "delete from StentsByFG where stntserial ='" & strSerialNo & "'"
                        db.deleteQuery(Sql)
                        deleteFlag = True
                    End If
                Next
                FillGrid()
            End If
        Else
            MsgBox("No record selected")
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class