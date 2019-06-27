
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Reflection

Public Class OprnByStatus
    Public Sql As String
    Public clspm As New clsPublic_Methods
    Public ds As New DataSet

    Protected Sub OprnByStatus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmbOperation.Text = "<< Search by >>"
        cmbOperation.Items.Insert(0, "Crimping")
        cmbOperation.Items.Insert(1, "Sealing")
        cmbOperation.Items.Insert(2, "Boxing")
        cmbOperation.SelectedIndex = 0
        Serialgrid(1)
    End Sub

    Private Sub Serialgrid(ByVal intValue As Integer)
        Dim ds As New DataSet
        Dim sFldName As String
        Try
            sFldName = ""
            Select Case cmbOperation.SelectedIndex
                Case Is = 0
                    sFldName = "CRMP"
                    Exit Select
                Case Is = 1
                    sFldName = "SEAL"
                    Exit Select
                Case Is = 2
                    sFldName = "BOX"
                    Exit Select
            End Select

            If Trim(txtEnter.Text) = "" Then
                If (Me.lblStatus.Text = "Accepted") Then

                    Sql = "select srlno1 as 'Serial No', crby as 'Scanned By', crdt as 'Scanned Date',null as dsca from OperationLogs"
                    Sql = Sql & " WHERE oprn = '" & sFldName & "' and "
                    Sql = Sql & " wono= '" & sMainWorkOrderNO & "'"
                    Sql = Sql & "  and status= '" & Me.txtstatus.Text & "'"
                Else

                    Sql = "select a.srlno1 as 'Serial No', isnull(a.crby,a.mdby) as 'Scanned By', a.crdt as 'Scanned Date', b.dsca as 'Rejected Description' from OperationLogs a"
                    Sql = Sql & " Left outer join Reasons b on a.reascd1 = b.rejcd"
                    Sql = Sql & " WHERE oprn = '" & sFldName & "' and "
                    Sql = Sql & " wono= '" & sMainWorkOrderNO & "' "
                    Sql = Sql & "  and status= '" & Me.txtstatus.Text & "'"
                End If
            Else
                If (Me.lblStatus.Text = "Accepted") Then
                    Sql = "select srlno1 as 'Serial No', crby as 'Scanned By', crdt as 'Scanned Date', null as dsca from OperationLogs"
                    Sql = Sql & " WHERE oprn = '" & sFldName & "' and "
                    Sql = Sql & " wono= '" & sMainWorkOrderNO & "' And "
                    Sql = Sql & " status= '" & Me.txtstatus.Text & "' and "
                    Sql = Sql & " srlno1 like '%" & Me.txtEnter.Text.ToString() & "%' "
                Else

                    Sql = "select a.srlno1 as 'Serial No', isnull(a.crby,a.mdby) as 'Scanned By', a.crdt as 'Scanned Date', b.dsca as 'Rejected Description' from OperationLogs a"
                    Sql = Sql & " Left outer join Reasons b on a.reascd1 = b.rejcd"
                    Sql = Sql & " WHERE oprn = '" & sFldName & "' and "
                    Sql = Sql & " wono= '" & sMainWorkOrderNO & "' And "
                    Sql = Sql & " status= '" & Me.txtstatus.Text & "' And "
                    Sql = Sql & " srlno1 like '%" & Me.txtEnter.Text.ToString() & "%' "
                End If
            End If

            ds = db.selectQuery(Sql)
            dgSerial.DataSource = ds.Tables(0).DefaultView

            If (Me.lblStatus.Text = "Accepted") Then
                HideShowColumns(dgSerial, "True")
            Else
                HideShowColumns(dgSerial, "False")
            End If

            FormatGrid()

        Catch ex As System.Exception
            errMsgBox(Sql)
            errMsgBox("Error:  " & ex.Message.ToString())
        End Try

    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgSerial.Columns.Count - 1
            dgSerial.Columns(i).ReadOnly = True
            dgSerial.Columns(i).Width = 160
        Next
    End Sub

    Public Sub errMsgBox(ByVal msg As String)
        Dim lbl As New Label()

        lbl.Text = "<script language='javascript'>" & Environment.NewLine & _
               "window.alert('" + msg + "')</script>"
        Me.Controls.Add(lbl)

    End Sub

    Private Sub HideShowColumns(ByVal dg As DataGridView, ByVal strValue As String)
        If (strValue = "True") Then
            dg.Columns(3).Visible = False
        Else
            dg.Columns(3).Visible = True
        End If
    End Sub

    Private Sub cmbOperation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Serialgrid(1)
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        lblProgress.Visible = True
        Me.Cursor = Cursors.WaitCursor
        Me.Refresh()

        If (txtEnter.Text = String.Empty) Then
            Serialgrid(1)
        Else
            Serialgrid(1)
        End If

        lblProgress.Visible = False
        Me.Cursor = Cursors.Arrow
        Me.Refresh()
    End Sub
End Class