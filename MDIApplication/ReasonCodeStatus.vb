Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography

Public Class ReasonCodeStatus

    Public Sql As String
    Public clspm As New clsPublic_Methods
    Public ds As New DataSet

    Protected Sub ReasonCodeStatus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmbOperation.Text = " << Search by >> "
        cmbOperation.Items.Insert(0, "Crimping")
        cmbOperation.Items.Insert(1, "Sealing")
        cmbOperation.Items.Insert(2, "Boxing")
        cmbOperation.SelectedIndex = 0
        ReasonGrid()
    End Sub

    Private Sub ReasonGrid()
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

            Sql = "SELECT     a.srlno1 as [Serial No.], a.wono as [Work Order No.], b.facode as [Batch No.] , b.ItemCode as [Item Code],  isnull(a.crby,a.mdby) as [Scanned By], a.crdt as [Scanned Date]"
            Sql = Sql & " FROM OperationLogs a LEFT OUTER JOIN ZWOList b"
            Sql = Sql & " ON a.wono = b.project"
            Sql = Sql & " WHERE a.reascd1 = '" & sMainReasonCodes & "'"
            Sql = Sql & " AND a.oprn = '" & sFldName & "'"
            Sql = Sql & " GROUP BY a.srlno1, a.wono, b.facode, b.ItemCode, a.crby, a.mdby, a.crdt"

            ds = db.selectQuery(Sql)
            dgReasons.DataSource = ds.Tables(0).DefaultView

            FormatGrid()

        Catch ex As System.Exception
            errMsgBox(Sql)
            errMsgBox("Error:  " & ex.Message.ToString())
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgReasons.Columns.Count - 1
            dgReasons.Columns(i).ReadOnly = True
            dgReasons.Columns(i).Width = 126
        Next
    End Sub

    Public Sub errMsgBox(ByVal msg As String)
        Dim lbl As New Label()

        lbl.Text = "<script language='javascript'>" & Environment.NewLine & _
               "window.alert('" + msg + "')</script>"
        Me.Controls.Add(lbl)

    End Sub

    Private Sub cmbOperation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOperation.SelectedIndexChanged
        ReasonGrid()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class