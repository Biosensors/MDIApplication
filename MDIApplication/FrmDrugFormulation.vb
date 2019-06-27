Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.ComponentModel.Container
Imports System.Drawing

Public Class FrmDrugFormulation
    Inherits System.Windows.Forms.Form

    Dim ds, ds1 As New DataSet
    Dim dt As New DataTable
    Dim strSerialNo As String
    Dim Sql1 As String

    Private Sub FrmDrugFormulation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ddlFormulationBatch.Items.Clear()
        ddlAMPC.Items.Clear()
        FillAMPCDropDownList()

        ClearWOControls()
        ClearFooterControls()
        DisableUpdateControls()
        txtWoNo.Focus()
        FillGrid()
    End Sub

    Private Sub FillWODetails()

        Dim bWorkOrderFound As Boolean

        Try
            bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtWoNo.Text))

            If Not (bWorkOrderFound) Then
                MsgBox("Invalid Work Order")
                txtWoNo.Text = ""
                txtItem.Text = ""
                txtBatch.Text = ""
                Exit Sub
            End If

            ClearFooterControls()
            EnableUpdateControls()

            txtWoNo.Text = stWODetails.sWorkOrderNo
            txtItem.Text = stWODetails.sItemCode
            txtBatch.Text = stWODetails.sBatchNo
            txtStentLength.Text = stWODetails.nStentLength

            FillFormulationBatches()
            ddlFormulationBatch.SelectedValue = stWODetails.sFormulationBatch

            txtWoNo.ReadOnly = True

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillFormulationBatches()

        Sql = "select Item, StntBatch, rtrim(StntBatch) + ' (' + Item + ')' as ItemWithBatch from zvwwoissues where workorder = '" & Trim(txtWoNo.Text) & "' and (StntBatch is not null or StntBatch <> '') order by StntBatch"
        ds1 = db.selectQuery(Sql)

        ddlFormulationBatch.DataSource = ds1.Tables(0)
        ddlFormulationBatch.DisplayMember = "ItemWithBatch"
        ddlFormulationBatch.ValueMember = "StntBatch"

    End Sub

    Private Sub FillAMPCDropDownList()
        Dim i As Integer
        For i = 1 To 12
            ddlAMPC.Items.Add(i)
        Next
        ddlAMPC.SelectedIndex = 0
    End Sub

    Public Sub FillGrid()
        Try
            Dim sql As String

            sql = "select stntserial as 'Serial', ampc as AMPC, vialno as 'Vial No', uvdose as 'UV Dose', formulation as 'Frmln. Vol', cast(0 as bit) as 'Delete' from DrugConcentrationsD where stwono = '" & txtWoNo.Text.ToString().Trim & "'"
            ds = db.selectQuery(sql)

            dt = ds.Tables(0)
            dgDrugFormulation.DataSource = dt

            FormatGrid()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        If dt.Rows.Count > 0 Then
            dgDrugFormulation.ReadOnly = False

            For i = 0 To dgDrugFormulation.Columns.Count - 1
                dgDrugFormulation.Columns(i).ReadOnly = True
                dgDrugFormulation.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            dgDrugFormulation.Columns("Delete").ReadOnly = False
            dgDrugFormulation.Columns("Delete").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgDrugFormulation.Rows(dt.Rows.Count).ReadOnly = True

        Else
            dgDrugFormulation.ReadOnly = True
            dgDrugFormulation.Columns("Delete").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
    End Sub

    Private Sub EditDrugFormulation()
        Try
            strSerialNo = Trim(dgDrugFormulation.CurrentRow.Cells(0).Value.ToString())

            Sql = "select h.fmlnbatch as batch,d.ampc as ampc, d.vialno as vialno, d.uvdose as uvdose, d.formulation as formulationvol from DrugConcentrationsD d, DrugConcentrationsH h where d.stwono=h.stwono and d.stntserial='" & strSerialNo & "'"
            ds = db.selectQuery(Sql)

            DdlAMPCValue = ds.Tables(0).Rows(0).Item("ampc")
            ddlAMPC.Text = DdlAMPCValue
            txtStentSerial.Text = strSerialNo
            txtVialNo.Text = ds.Tables(0).Rows(0).Item("vialno")
            txtUVDose.Text = Math.Abs(ds.Tables(0).Rows(0).Item("uvdose"))
            txtFormulationVolume.Text = ds.Tables(0).Rows(0).Item("formulationvol")
            txtStentSerial.ReadOnly = True
            ddlFormulationBatch.Enabled = False
            txtStentLength.ReadOnly = True
            FillGrid()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgDrugFormulation_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDrugFormulation.DoubleClick
        Try
            If dgDrugFormulation.CurrentRow.Index < dt.Rows.Count Then
                If dgDrugFormulation.CurrentRow.Index >= 0 Then
                    If UCase(e.ToString) = "SYSTEM.WINDOWS.FORMS.MOUSEEVENTARGS" Then
                        EditDrugFormulation()
                    End If
                End If
            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub dgDrugFormulation_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgDrugFormulation.MouseUp
        Dim hti As DataGridView.HitTestInfo = Me.dgDrugFormulation.HitTest(e.X, e.Y)
        Try
            If hti.RowIndex < dt.Rows.Count Then
                If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.ColumnIndex = 5 Then
                    If dt.Rows(hti.RowIndex).Item("Delete") = False Then
                        dt.Rows(hti.RowIndex).Item("Delete") = True
                    Else
                        dt.Rows(hti.RowIndex).Item("Delete") = False
                    End If
                End If
            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Private Function ValidateSerialNo()
        Try
            Sql = "select stntserial,status from stentserials where stntserial='" & txtStentSerial.Text.Trim() & "' and stwono='" & txtWoNo.Text.Trim() & "'"
            ds = db.selectQuery(Sql)
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("Invalid stent serial number")
                txtStentSerial.Text = ""
                txtStentSerial.Focus()
                ValidateSerialNo = False

            ElseIf ds.Tables(0).Rows(0).Item("status") = 0 Then
                MsgBox("This stent serial number is not active")
                txtStentSerial.Text = ""
                txtStentSerial.Focus()
                ValidateSerialNo = False
            Else
                ValidateSerialNo = True
            End If
        Catch ex As System.Exception
            ValidateSerialNo = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim bWorkOrderFound As Boolean
        bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtWoNo.Text))

        If txtWoNo.Text = "" Then
            MsgBox("Enter Work Order")
            txtWoNo.Focus()

        ElseIf txtStentLength.Text = "" Then
            MsgBox("Enter Formulation Batch")
            txtStentLength.Focus()
        Else
            If Not (bWorkOrderFound) Then
                MsgBox("Invalid Work Order")
                txtWoNo.Text = ""
                txtItem.Text = ""
                txtBatch.Text = ""
                FillFormulationBatches()
                txtWoNo.Focus()
                Exit Sub
            End If

            Try
                If txtStentSerial.Text.Trim = "" Then
                    MsgBox("Enter Stent Serial")
                    txtStentSerial.Focus()

                ElseIf txtVialNo.Text.Trim = "" Then
                    MsgBox("Enter Vial Number")
                    txtVialNo.Focus()

                ElseIf txtUVDose.Text.Trim = "" Then
                    MsgBox("Enter UV Dose")
                    txtUVDose.Focus()

                ElseIf txtFormulationVolume.Text.Trim = "" Then
                    MsgBox("Enter Formulation Volume")
                    txtFormulationVolume.Focus()

                ElseIf Not IsNumeric(txtVialNo.Text.Trim) Then
                    MsgBox("Vial Number must be numeric")
                    txtVialNo.Text = ""
                    txtVialNo.Focus()

                ElseIf Not IsNumeric(txtUVDose.Text.Trim) Then
                    MsgBox("UV Dose must be numeric")
                    txtUVDose.Text = ""
                    txtUVDose.Focus()

                ElseIf Not IsNumeric(txtFormulationVolume.Text.Trim) Then
                    MsgBox("Formulation Volume must be numeric")
                    txtFormulationVolume.Text = ""
                    txtFormulationVolume.Focus()

                ElseIf ValidateSerialNo() Then

                    If txtStentSerial.ReadOnly = False Then

                        Sql = "insert into DrugConcentrationsH(stwono,fmlnbatch,preparedby,preparedon) values('" & txtWoNo.Text.Trim & "', '" & ddlFormulationBatch.SelectedValue & "', '" & sLogonUser & "',getdate())"
                        db.insertQuery(Sql)

                        Sql1 = "insert into DrugConcentrationsD(stwono,stntserial,ampc,vialno,uvdose,formulation,createdby,createdon,modifiedby,modifiedon) values('" & txtWoNo.Text.Trim & "','" & txtStentSerial.Text.Trim & "', '" & ddlAMPC.SelectedItem & "', '" & txtVialNo.Text.Trim & "', '" & txtUVDose.Text.Trim & "', '" & txtFormulationVolume.Text.Trim & "', '" & sLogonUser & "', getdate(), '" & sLogonUser & "', getdate())"

                        If db.insertQuery(Sql1) Then
                            ClearFooterControls()
                            EnableUpdateControls()
                            txtStentSerial.Focus()
                        Else
                            MsgBox("Stent serial already exists")
                            ClearFooterControls()
                            EnableUpdateControls()
                            txtStentSerial.Focus()
                        End If

                    ElseIf txtStentSerial.ReadOnly = True Then

                        Sql = "update DrugConcentrationsD set ampc='" & ddlAMPC.SelectedItem & "', vialno = " & txtVialNo.Text.Trim & ", uvdose=" & txtUVDose.Text.Trim & ", formulation= " & txtFormulationVolume.Text.Trim & " where stntserial='" & Trim(txtStentSerial.Text) & "'"
                        If db.updateQuery(Sql) Then
                            ClearFooterControls()
                            txtStentSerial.Focus()
                        Else
                            MsgBox("Drug Formulation not updated")
                        End If
                    End If
                End If
            Catch ex As System.Exception
                MsgBox(ex.Message)
            End Try

            FillGrid()
          
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim Ans As Integer
            Dim i As Integer
            Dim deleteFlag, deleteFlag2, FlagDeleteHeader As Boolean
            deleteFlag = False
            deleteFlag2 = False
            FlagDeleteHeader = False

            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("Delete") = True Then
                    deleteFlag = True
                End If
            Next

            If deleteFlag = True Then
                Ans = MsgBox("Are you sure want to delete?", vbYesNo + vbExclamation)

                If Ans = vbYes Then
                    For i = 0 To dt.Rows.Count - 1
                        If dt.Rows(i).Item("Delete") = True Then
                            strSerialNo = dt.Rows(i).Item("Serial")

                            Sql = "delete from DrugConcentrationsD where stntserial ='" & strSerialNo & "'"
                            db.deleteQuery(Sql)
                            deleteFlag2 = True

                            Sql = "select stwono from DrugConcentrationsD where stwono = '" & Trim(txtWoNo.Text) & "'"
                            ds = db.selectQuery(Sql)
                            If ds.Tables(0).Rows.Count = 0 Then
                                FlagDeleteHeader = True
                            End If
                        End If
                    Next
                End If

                If deleteFlag2 Then
                    'MsgBox("Records deleted")
                End If

                ' Delete records in header table if all the records are deleted from the details table
                If FlagDeleteHeader = True Then
                    Sql1 = "delete from DrugConcentrationsH where stwono = '" & Trim(txtWoNo.Text) & "'"
                    db.deleteQuery(Sql1)
                    ClearWOControls()
                    ClearFooterControls()
                    DisableUpdateControls()
                End If
            Else
                MsgBox("No record selected")
            End If

            FillGrid()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearWOControls()
        ClearFooterControls()
        DisableUpdateControls()
        FillGrid()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Trim(txtStentLength.Text) = "" Then
                MsgBox("Enter Stent Length")
                txtStentLength.Focus()

            ElseIf Not IsNumeric(txtStentLength.Text.Trim) Then
                MsgBox("Stent Length must be numeric")
                txtStentLength.Text = ""
                txtStentLength.Focus()
            Else
                Sql = "update DrugConcentrationsH set fmlnbatch = '" & Trim(ddlFormulationBatch.SelectedValue) & "', stntlength = " & Val(Trim(txtStentLength.Text)) & " where stwono = '" & Trim(txtWoNo.Text) & "'"
                If db.updateQuery(Sql) Then
                    'MsgBox("FG work order details updated")
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtFGWO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWoNo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            If txtWoNo.Text = "" Then
                MsgBox("Enter Work Order")
                txtWoNo.Focus()
            Else
                FillWODetails()
                FillGrid()
            End If
        End If
    End Sub

    Private Sub txtFGWO_ReadOnlyChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWoNo.ReadOnlyChanged
        If txtWoNo.ReadOnly Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub EnableUpdateControls()
        txtStentSerial.Enabled = True
        ddlAMPC.Enabled = True
        txtVialNo.Enabled = True
        txtUVDose.Enabled = True
        txtFormulationVolume.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub DisableUpdateControls()
        txtStentSerial.Enabled = False
        ddlAMPC.Enabled = False
        txtVialNo.Enabled = False
        txtUVDose.Enabled = False
        txtFormulationVolume.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub ClearWOControls()
        txtWoNo.Text = ""
        txtItem.Text = ""
        txtBatch.Text = ""
        txtStentLength.Text = ""
        btnSave.Enabled = False
        txtWoNo.ReadOnly = False
        ddlFormulationBatch.Enabled = True
        FillFormulationBatches()
        txtStentLength.ReadOnly = False
        txtWoNo.Focus()
    End Sub

    Private Sub ClearFooterControls()
        txtStentSerial.Text = ""
        ddlAMPC.SelectedIndex = 0
        txtVialNo.Text = ""
        txtUVDose.Text = ""
        txtFormulationVolume.Text = ""
        txtStentSerial.ReadOnly = False
    End Sub

End Class