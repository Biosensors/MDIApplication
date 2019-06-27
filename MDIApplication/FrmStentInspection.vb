Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmStentInspection

    Dim ds As DataSet

    Private Sub FrmStentInspection_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtOperator.Text = sLogonUser
        ClearControls()
    End Sub

    Private Sub FillWODetails()

        Dim bWorkOrderFound As Boolean

        Try
            bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtStentWO.Text))

            txtItem.Text = stWODetails.sItemCode
            txtBatch.Text = stWODetails.sBatchNo
            txtWOQty.Text = stWODetails.nActualQty

            If Not (bWorkOrderFound) Then
                MsgBox("Invalid Work Order")
                ClearControls()
                txtStentWO.Focus()
                Exit Sub
            End If

            Sql = "select count(stntserial) as StentQty from stentserials where stwono = '" & txtStentWO.Text.ToString() & "' and status=1 and stenttype=1"
            ds = db.selectQuery(Sql)
            txtStentQty.Text = ds.Tables(0).Rows(0).Item("StentQty")

            FillTotalsAndPercentage()
            txtStentSerialNo.Enabled = True
            txtStentSerialNo.Focus()
            btnPass.Enabled = True
            btnFail.Enabled = True

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidateSerialNo()
        Try
            If Trim(txtStentWO.Text) = "" Then
                MsgBox("Enter Stent Work Order first")
                txtStentSerialNo.Text = ""
                txtStentWO.Focus()
            Else
                Sql = "select stntserial,status,inspnstatus from stentserials where stntserial='" & txtStentSerialNo.Text.Trim() & "' and stwono='" & txtStentWO.Text.Trim() & "' and status = 1 and stenttype=1"
                ds = db.selectQuery(Sql)
                If ds.Tables(0).Rows.Count = 0 Then
                    MsgBox("Invalid stent serial number")
                    txtStentSerialNo.Text = ""
                    txtStentSerialNo.Focus()
                    ValidateSerialNo = False

                ElseIf ds.Tables(0).Rows(0).Item("status") = 0 Then
                    MsgBox("This stent serial number is not active")
                    txtStentSerialNo.Text = ""
                    txtStentSerialNo.Focus()
                    ValidateSerialNo = False

                ElseIf ds.Tables(0).Rows(0).Item("inspnstatus") <> -1 Then
                    MsgBox("Inspection is done for this stent serial number")
                    txtStentSerialNo.Text = ""
                    txtStentSerialNo.Focus()
                    ValidateSerialNo = False
                Else
                    ValidateSerialNo = True
                End If
            End If
        Catch ex As System.Exception
            ValidateSerialNo = False
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub FillTotalsAndPercentage()

        If Val(txtStentQty.Text) > 0 Then
            Sql = "select count(stntserial) as TotalPass from stentserials where stwono='" & txtStentWO.Text.Trim() & "' and inspnstatus=1 and status = 1 and stenttype=1"
            ds = db.selectQuery(Sql)
            txtTotalPass.Text = ds.Tables(0).Rows(0).Item("TotalPass")
            lblPassPercent.Text = Math.Round(Val(txtTotalPass.Text) / Val(txtStentQty.Text) * 100, 2)

            If lblPassPercent.Text = 0 Then lblPassPercent.Text = "0.00"

            Sql = "select count(stntserial) as TotalFail from stentserials where stwono='" & txtStentWO.Text.Trim() & "' and inspnstatus=0 and status = 1 and stenttype=1"
            ds = db.selectQuery(Sql)
            txtTotalFail.Text = ds.Tables(0).Rows(0).Item("TotalFail")
            lblFailPercent.Text = Math.Round(Val(txtTotalFail.Text) / Val(txtStentQty.Text) * 100, 2)

            If lblFailPercent.Text = 0 Then lblFailPercent.Text = "0.00"

        Else
            lblPassPercent.Text = "0.00"
            lblFailPercent.Text = "0.00"
        End If

    End Sub

    Private Sub ClearControls()
        txtStentWO.Text = ""
        txtItem.Text = ""
        txtBatch.Text = ""
        txtWOQty.Text = ""
        txtStentQty.Text = ""
        txtTotalPass.Text = ""
        txtTotalFail.Text = ""
        lblPassPercent.Text = "0.00"
        lblFailPercent.Text = "0.00"
        txtStentSerialNo.Text = ""
        txtStentWO.ReadOnly = False
        btnPass.Enabled = False
        btnFail.Enabled = False
        txtStentSerialNo.Enabled = False
        txtStentWO.Focus()
    End Sub

    Private Sub txtStentWO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStentWO.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            If txtStentWO.Text = "" Then
                MsgBox("Enter Stent Work Order")
                txtStentWO.Focus()
            Else
                FillWODetails()
            End If
        End If
    End Sub

    Private Sub txtStentSerialNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStentSerialNo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            If txtStentSerialNo.Text = "" Then
                MsgBox("Enter Stent Serial Number")
                txtStentSerialNo.Focus()
            Else
                If ValidateSerialNo() Then
                    btnFail.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btnPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPass.Click
        If txtStentSerialNo.Text = "" Then
            MsgBox("Enter stent serial number")
            txtStentSerialNo.Focus()
            Exit Sub
        Else
            If ValidateSerialNo() Then
                Sql = "update stentserials set inspnstatus = 1, inspndate = getdate(), inspnby = '" & sLogonUser & "' where stntserial ='" & Trim(txtStentSerialNo.Text) & "'"
                db.updateQuery(Sql)
                txtStentSerialNo.Text = ""
                FillTotalsAndPercentage()
                txtStentSerialNo.Focus()
            End If
        End If
    End Sub

    Private Sub btnFail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFail.Click
        If txtStentSerialNo.Text = "" Then
            MsgBox("Enter stent serial number")
            txtStentSerialNo.Focus()
            Exit Sub
        Else
            If ValidateSerialNo() Then
                FrmRejectionReasonsList.lblSerialNo.Text = txtStentSerialNo.Text
                FrmRejectionReasonsList.ShowDialog()
                txtStentSerialNo.Text = ""
                FillTotalsAndPercentage()
                txtStentSerialNo.Focus()
            End If
        End If
    End Sub

    Private Sub btnNextStentWO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextStentWO.Click
        ClearControls()
        txtStentSerialNo.Enabled = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class