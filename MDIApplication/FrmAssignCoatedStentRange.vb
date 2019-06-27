Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports MDIApplication.BioTrackMain

Public Class FrmAssignCoatedStentRange

    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim TotalSelected As Integer

    Private Sub FrmAssignCoatedStents_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ClearControls()
        ' Ali, 10.May.2018
        '  txtQuantity.Enabled = False    
        chkSelectAll.Enabled = False
        txtInitialSerialNo.Select()
        'txtCoatedStentWO.Select()
    End Sub

    Private Sub FillWODetails()
        Dim bWorkOrderFound As Boolean
        bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtCoatedStentWO.Text))

        txtCoatedStentWO.Text = stWODetails.sWorkOrderNo
        lblStentItem.Text = stWODetails.sItemCode
        lblStentBatch.Text = stWODetails.sBatchNo

    End Sub

    Private Sub FillGrid()
        Try
            If Trim(txtCoatedStentWO.Text) <> "" Then
                ' COmment by Ali, 10.Jun.2018
                ' Sql = "select cast(0 as bit) as 'Assign', stntserial as 'Stent Serial', stbatch as 'Batch No' from stentserials where (stwono = '" & txtCoatedStentWO.Text & "' or stbatch = '" & txtCoatedStentWO.Text & "') and status = 1 and stenttype = 1 and stntserial not in (select stntserial from StentsByFG) order by stntserial"
                Sql = "EXECUTE  [dbo].[SP_AssignStents2FinalWorkOrder] '"
                Sql = Sql & txtInitialSerialNo.Text & "','"
                Sql = Sql & txtFGWoNo.Text & "',"
                Sql = Sql & txtQuantity.Text & ", '"
                Sql = Sql & sLogonUser & "' "

                ds = db.selectQuery(Sql)
                dt = ds.Tables(0)

                dgStentSerials.DataSource = dt
                ' Ali, 10.MAY.2018
                'If dt.Rows.Count > 0 Then
                '    txtQuantity.Enabled = True
                '    chkSelectAll.Enabled = True
                '    lblStentTotalQty.Text = dt.Rows.Count
                'Else
                '    txtQuantity.Enabled = False
                '    chkSelectAll.Enabled = False
                '    lblStentTotalQty.Text = ""
                'End If
                ' End of Comments, Ali, 10.May.2018
                FormatGrid()
            Else
                ds.Clear()
            End If

        Catch ex As System.Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillData()
        If txtCoatedStentWO.Text = "" Then
            MsgBox("Invalid Stent Batch No")
            ClearControls()
            ' txtQuantity.Enabled = False
            chkSelectAll.Enabled = False
            txtCoatedStentWO.Focus()
        Else
            ClearControls()
            FillWODetails()
            If Trim(txtCoatedStentWO.Text) <> "" Then
                FillGrid()
            Else
                ' txtQuantity.Enabled = False
                chkSelectAll.Enabled = False
            End If
        End If
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        If dt.Rows.Count > 0 Then
            dgStentSerials.ReadOnly = False

            For i = 0 To dgStentSerials.Columns.Count - 1
                dgStentSerials.Columns(i).ReadOnly = True
                dgStentSerials.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                dgStentSerials.Columns(i).Width = 130
            Next

            dgStentSerials.Columns("Assign").ReadOnly = False
            dgStentSerials.Columns("Assign").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgStentSerials.Rows(dt.Rows.Count).ReadOnly = True

        Else
            dgStentSerials.ReadOnly = True
            dgStentSerials.Columns("Assign").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgStentSerials.Columns("Assign").Width = 130
            dgStentSerials.Columns("Stent Serial").Width = 130
            dgStentSerials.Columns("Batch No").Width = 130
        End If
    End Sub
    Function GetDetailsonSerialNo()
        Dim i As Integer
        TotalSelected = 0

        If Trim(txtInitialSerialNo.Text) = "" Then
            MsgBox("Enter Initial Serial No")
        Else
            Sql = "EXEC SP_GetDetailsOnSerialNo '" & Trim(txtInitialSerialNo.Text) & "' "
            ' "insert into StentsByFG(stntserial,fgwono,assignedby,assignedon,status) values('" & Trim(dt.Rows(i).Item("Stent Serial")) & "', '" & Trim(txtFGWoNo.Text) & "','" & sLogonUser & "', getdate(), 1) "

            ds = db.selectQuery(Sql)
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("Selected serial No doesn't Exist")
            Else
                txtCoatedStentWO.Text = ds.Tables(0).Rows(0).Item("StentWorkOrder")
                txtCoatedStentWO.Refresh()
            End If

        End If
     
    End Function


    Private Sub btnAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssign.Click
        Dim i As Integer
        TotalSelected = 0

        ' To check the total quantity selected
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("Assign") = True Then
                TotalSelected = TotalSelected + 1
            End If
        Next

        If TotalSelected = 0 Then
            MsgBox("No record selected")
        Else
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("Assign") = True Then
                    Sql = "insert into StentsByFG(stntserial,fgwono,assignedby,assignedon,status) values('" & Trim(dt.Rows(i).Item("Stent Serial")) & "', '" & Trim(txtFGWoNo.Text) & "','" & sLogonUser & "', getdate(), 1) "
                    db.insertQuery(Sql)
                End If
            Next
            Me.Close()
        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtCoatedStentWO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCoatedStentWO.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            FillData()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        GetDetailsonSerialNo()
        If txtCoatedStentWO.Text = "" Then
            txtCoatedStentWO.Text = 0
        End If
        If txtQuantity.Text > 0 And txtCoatedStentWO.Text <> "" Then
            FillData()
        Else
            MsgBox("Invalie Stent Batch No and/Or Quanity, Try again")
        End If
    End Sub

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        'Dim i As Integer
        'If txtCoatedStentWO.Text <> "" Then
        '    chkSelectAll.Enabled = True
        '    FillGrid()

        '    If chkSelectAll.Checked = True Then
        '        chkSelectAll.Text = "Unselect All"
        '        For i = 0 To dt.Rows.Count - 1
        '            dt.Rows(i).Item("Assign") = True
        '        Next
        '        txtQuantity.Text = dt.Rows.Count
        '    Else
        '        chkSelectAll.Text = "Select All"
        '        For i = 0 To dt.Rows.Count - 1
        '            dt.Rows(i).Item("Assign") = False
        '        Next
        '        txtQuantity.Text = 0
        '    End If
        'Else
        '    chkSelectAll.Enabled = False
        'End If
    End Sub

    Private Sub ClearControls()
        lblStentItem.Text = ""
        lblStentBatch.Text = ""
        ' txtQuantity.Text = 0
        chkSelectAll.Checked = False
        chkSelectAll.Text = "Select All"
        FillGrid()
        dt.Clear()
        dgStentSerials.DataSource = dt
        lblStentTotalQty.Text = ""
    End Sub

    Private Sub txtQuantity_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantity.LostFocus
        Dim i As Integer
        Try
            chkSelectAll.Checked = False
            chkSelectAll.Text = "Select All"

            If Trim(txtQuantity.Text) <> "" Then
                If Not IsNumeric(Trim(txtQuantity.Text)) Then
                    MsgBox("Enter valid number")
                    txtQuantity.Text = "0"
                    txtQuantity.Focus()
                    ' Comments by Ali , 10.may.2018
                    'ElseIf CInt(Trim(txtQuantity.Text)) > dt.Rows.Count Then
                    '    MsgBox("Total selection exceeds available Serial Nos")
                    '    txtQuantity.Text = 0
                    '    For i = 0 To dt.Rows.Count - 1
                    '        dt.Rows(i).Item("Assign") = False
                    '    Next

                    'Else
                    '    ' To select the serials in the grid
                    '    FillGrid()
                    '    For i = 0 To Trim(txtQuantity.Text) - 1
                    '        dt.Rows(i).Item("Assign") = True
                    '    Next
                    ' End of Comments by Ali , 10.may.2018
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvStentSerials_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgStentSerials.MouseUp
        'Dim i As Integer
        'Dim hti As DataGridView.HitTestInfo = Me.dgStentSerials.HitTest(e.X, e.Y)
        'TotalSelected = 0

        'Try
        '    If hti.RowIndex < dt.Rows.Count Then

        '        If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.ColumnIndex = 0 Then

        '            If dt.Rows(hti.RowIndex).Item("Assign") = False Then
        '                dt.Rows(hti.RowIndex).Item("Assign") = True
        '            Else
        '                dt.Rows(hti.RowIndex).Item("Assign") = False
        '            End If

        '            ' To display the total no. of selected serials
        '            For i = 0 To dt.Rows.Count - 1
        '                If dt.Rows(i).Item("Assign") = True Then
        '                    TotalSelected = TotalSelected + 1
        '                End If
        '            Next

        '            txtQuantity.Text = TotalSelected

        '        End If
        '    End If
        'Catch ex As System.Exception
        '    MessageBox.Show(ex.ToString())
        'End Try

    End Sub

    Private Sub txtCoatedStentWO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCoatedStentWO.TextChanged

    End Sub

    Private Sub txtInitialSerialNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInitialSerialNo.KeyPress
        'If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
        '    GetDetailsonSerialNo()
        'End If
    End Sub

    Private Sub txtInitialSerialNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInitialSerialNo.TextChanged
        GetDetailsonSerialNo()
    End Sub

End Class