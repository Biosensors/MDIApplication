Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Configuration
Imports System.DirectoryServices
Imports System.Text
Imports System.Text.StringBuilder
Imports MDIApplication.BioTrackMain
Imports MDIApplication.IniFileFunctions
Imports System.Text.RegularExpressions

Public Class FrmPrintSerial
    Inherits System.Windows.Forms.Form

    Public strWONo As String
    Dim sql, sql1, sql2, sql3 As String
    Dim ds, ds1, ds2, ds3 As New DataSet

    Private Sub FrmPrintSerial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'ClearControls()
        txtwrkordno.Select()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            If strWONo = "" Then
                MsgBox("Enter Work Order Number")
                txtwrkordno.Focus()
            ElseIf ddlFromSerial.Items.Count = 0 Or ddlToSerial.Items.Count = 0 Then
                MsgBox("Serial Numbers donot exist for this work order. Enter another work order.")
            ElseIf ddlFromSerial.SelectedValue > ddlToSerial.SelectedValue Then
                MsgBox("'To Serial Number' cannot be less than 'From Serial Number'")
            Else
                sql = "update StentSerials set pcount = pcount + 1 where stntserial between '" & ddlFromSerial.SelectedValue & "' and '" & ddlToSerial.SelectedValue & "' and stwono = '" & strWONo & "'"
                If db.updateQuery(sql) Then
                    'Write code to print serial numbers
                    '-----------------------------------
                    '-----------------------------------
                    '-----------------------------------
                    MsgBox("Printed Successfully")
                Else
                    MsgBox("Not Printed")
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtwrkordno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtwrkordno.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            FillDropDownLists()
        End If
    End Sub

    Private Sub FillDropDownLists()

        Dim bWorkOrderFound As Boolean

        Try
            strWONo = txtwrkordno.Text.Trim
            If strWONo = "" Then
                MsgBox("Enter Work Order Number")
                txtwrkordno.Focus()

            Else
                bWorkOrderFound = clspm.GetWorkOrderDetails(Trim(txtwrkordno.Text))

                If Not (bWorkOrderFound) Then
                    MsgBox("Invalid Work Order")
                    ClearControls()
                    Exit Sub
                Else
                    sql = "select count(stntserial) from StentSerials where stwono='" & strWONo & "' and status = 1 and stenttype=1"
                    ds = db.selectQuery(sql)
                    txtQuantity.Text = ds.Tables(0).Rows(0).Item(0)

                    sql1 = "select stntserial from StentSerials where stwono ='" & strWONo & "' and status = 1 and stenttype=1 order by stntserial"
                    ds1 = db.selectQuery(sql1)

                    sql2 = "select stntserial from StentSerials where stwono ='" & strWONo & "' and status = 1 and stenttype=1 order by stntserial"
                    ds2 = db.selectQuery(sql2)

                    ddlFromSerial.DataSource = ds1.Tables(0)
                    ddlFromSerial.DisplayMember = "stntserial"
                    ddlFromSerial.ValueMember = "stntserial"

                    ddlToSerial.DataSource = ds2.Tables(0)
                    ddlToSerial.DisplayMember = "stntserial"
                    ddlToSerial.ValueMember = "stntserial"

                    sql3 = "select min(stntserial) as MinSerial, max(stntserial) as MaxSerial from StentSerials where stwono ='" & strWONo & "' and stenttype=1 and status = 1"
                    ds3 = db.selectQuery(sql3)
                    ddlFromSerial.SelectedValue = ds3.Tables(0).Rows(0).Item("MinSerial")
                    ddlToSerial.SelectedValue = ds3.Tables(0).Rows(0).Item("MaxSerial")
                End If
            End If

        Catch ex As System.Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearControls()
        txtwrkordno.Text = ""
        txtQuantity.Text = ""
        ClearDropDownLists()
        txtwrkordno.Focus()
    End Sub

    Private Sub ClearDropDownLists()
       
        ds.Clear()

        ddlToSerial.DataSource = ds.Tables(0)
        ddlToSerial.DisplayMember = ""
        ddlToSerial.ValueMember = ""

        ddlFromSerial.DataSource = ds.Tables(0)
        ddlFromSerial.DisplayMember = ""
        ddlFromSerial.ValueMember = ""

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class