Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmAmpcDataLogs
    Inherits System.Windows.Forms.Form

    Dim bWorkOrderFound As Boolean
    Dim dt As New DataTable
    Dim strStentBatchNo, strStentSerialNo As String

    Private Sub FrmAmpcDataLogs_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtBatchNo.Text = ""
        ClearControls()
        txtBatchNo.Select()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ClearControls()
        ValidateAndFillDetails()
    End Sub

    Private Sub txtStentWONo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBatchNo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            ClearControls()
            ValidateAndFillDetails()
        End If
    End Sub

    Private Sub ValidateAndFillDetails()
        If Trim(txtBatchNo.Text) = "" Then
            MsgBox("Enter Batch No")
            txtBatchNo.Focus()
        Else
            bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtBatchNo.Text))

            If bWorkOrderFound = True Then

                Sql = "select count(shoporderid) as TotalCount from ampcdata where shoporderid = '" & Trim(txtBatchNo.Text) & "'"
                ds = db.selectQuery(Sql)

                If ds.Tables(0).Rows(0).Item("TotalCount") > 0 Then
                    txtBatchNo.Text = stWODetails.sBatchNo
                    FillLogDetails(Trim(txtBatchNo.Text))
                Else
                    MsgBox("AMPC Coating Data not available for this Batch No")
                    txtBatchNo.Text = ""
                    ClearControls()
                    txtBatchNo.Focus()
                End If
            Else
                MsgBox("Invalid Batch No")
                txtBatchNo.Text = ""
                ClearControls()
                txtBatchNo.Focus()
            End If
        End If
    End Sub

    Private Sub FillLogDetails(ByVal WONo As String)

        'To get number of No AMPC Coating
        Sql = "select count(stntserial) as NoAmpcCoating from stentserials where stbatch = '" & WONo & "'and stntserial not in (select stentid from ampcdata where shoporderid='" & WONo & "')"
        ds = db.selectQuery(Sql)
        txtNoAmpcCoating.Text = ds.Tables(0).Rows(0).Item("NoAmpcCoating")

        'To get number of Invalid Stent Serials
        Sql = "select count(stentid) as InvalidStentSerials from ampcdata where shoporderid = '" & WONo & "' and stentid not in (select stntserial from stentserials where stbatch = '" & WONo & "')"
        ds = db.selectQuery(Sql)
        txtInvalidStentSerials.Text = ds.Tables(0).Rows(0).Item("InvalidStentSerials")

        'To get number of Duplicate Stent Serials
        Sql = "select count(stentid)as DuplicateStentSerials from ampcdata where shoporderid = '" & WONo & "' group by stentid having count(stentid) > 1"
        ds = db.selectQuery(Sql)
        txtDuplicateStentSerials.Text = ds.Tables(0).Rows.Count

        If CInt(txtNoAmpcCoating.Text) > 0 Then
            btnNoAmpcCoating.Enabled = True
        End If

        If CInt(txtInvalidStentSerials.Text) > 0 Then
            btnInvalidStentSerials.Enabled = True
        End If

        If CInt(txtDuplicateStentSerials.Text) > 0 Then
            btnDuplicateStentSerials.Enabled = True
        End If

    End Sub

    Private Sub ClearControls()
        txtNoAmpcCoating.Text = ""
        txtInvalidStentSerials.Text = ""
        txtDuplicateStentSerials.Text = ""
        btnNoAmpcCoating.Enabled = False
        btnInvalidStentSerials.Enabled = False
        btnDuplicateStentSerials.Enabled = False
    End Sub

    Private Sub btnNoAmpcCoating_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoAmpcCoating.Click
        FrmAmpcDataLogSerials.txtWoNo.Text = Trim(txtBatchNo.Text)
        FrmAmpcDataLogSerials.sFillCategory = "NoAmpcCoating"
        FrmAmpcDataLogSerials.lblTitle.Text = "No AMPC Coating"
        FrmAmpcDataLogSerials.ShowDialog()
    End Sub

    Private Sub btnInvalidStentSerials_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvalidStentSerials.Click
        FrmAmpcDataLogSerials.txtWoNo.Text = Trim(txtBatchNo.Text)
        FrmAmpcDataLogSerials.sFillCategory = "InvalidStentSerials"
        FrmAmpcDataLogSerials.lblTitle.Text = "Invalid Stent Serials"
        FrmAmpcDataLogSerials.ShowDialog()
    End Sub

    Private Sub btnDuplicateStentSerials_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuplicateStentSerials.Click
        FrmAmpcDataLogSerials.txtWoNo.Text = Trim(txtBatchNo.Text)
        FrmAmpcDataLogSerials.sFillCategory = "DuplicateStentSerials"
        FrmAmpcDataLogSerials.lblTitle.Text = "Duplicate Stent Serials"
        FrmAmpcDataLogSerials.ShowDialog()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class