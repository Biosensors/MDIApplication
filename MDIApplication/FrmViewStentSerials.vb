Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports MDIApplication.BioTrackMain
Imports System.Drawing
Imports System.Drawing.Color

Public Class FrmViewStentSerials
    Inherits System.Windows.Forms.Form

    Public Sql As String
    Dim ds As New DataSet
    Dim dt As New DataTable
    Private frmParent As MDIForm
    Dim dsSource As New DataSet()
    Public clspm As New clsPublic_Methods
    Private status As Boolean = False
    Public strStentWONo As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        chkActual.Checked = True
        chkDummy.Checked = False
        ClearControls()
        txtwrkordno.Select()
    End Sub

    Private Sub txtwrkordno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtwrkordno.KeyPress

        Dim bWorkOrderFound As Boolean

        Try
            If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then

                lblBatch.Text = ""
                lblItem.Text = ""
                lblItemDesc.Text = ""
                lblActualQty.Text = ""

                bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtwrkordno.Text))

                txtwrkordno.Text = stWODetails.sWorkOrderNo
                lblItem.Text = stWODetails.sItemCode
                lblItemDesc.Text = stWODetails.sItemDescription
                lblBatch.Text = stWODetails.sBatchNo
                lblActualQty.Text = stWODetails.nActualQty

                If Not (bWorkOrderFound) Then
                    MsgBox("Invalid Work Order")
                    ClearControls()
                    FillGrid()
                    Exit Sub
                End If

                Sql = "select count(stntserial) from StentSerials where stwono ='" & Trim(txtwrkordno.Text) & "' and status=1 and stenttype = 1"
                ds = db.selectQuery(Sql)

                lblNoOfSerials.Text = ds.Tables(0).Rows(0).Item(0)

                FillGrid()
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillGrid()
        Try
            If chkActual.Checked = True Then
                If chkDummy.Checked = True Then
                    Sql = ""
                Else
                    Sql = " and stenttype = 1"
                End If
            Else
                If chkDummy.Checked = True Then
                    Sql = " and stenttype = 2"
                Else
                    chkActual.Checked = True
                    chkDummy.Checked = False
                    Sql = " and stenttype = 1"
                End If
            End If

            Sql = "select stntserial as 'Stent Serial', stbatch as 'Batch No' from StentSerials where stwono ='" & Trim(txtwrkordno.Text) & "' and status=1" & Sql
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
        For i = 0 To dgStentWorkOrder.Columns.Count - 1
            dgStentWorkOrder.Columns(i).ReadOnly = True
            dgStentWorkOrder.Columns(i).Width = 167
        Next
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
        lblActualQty.Text = ""
        lblNoOfSerials.Text = ""
        txtwrkordno.Focus()
    End Sub

    Private Sub chkActual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActual.CheckedChanged
        FillGrid()
    End Sub

    Private Sub chkDummy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDummy.CheckedChanged
        FillGrid()
    End Sub

End Class