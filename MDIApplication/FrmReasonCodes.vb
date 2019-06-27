Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports MDIApplication.BioTrackMain

Public Class FrmReasonCodes
    Public sql As String
    Public sReasonType As String
    Public clspm As New clsPublic_Methods
    Dim db As New Class1
    Public id As String
    Public id1 As String
    Public dt As DataTable

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadReasonTypes()
        FillReasonCodes()
    End Sub

    Private Sub LoadReasonTypes()
        Try
            Dim ds As New DataSet
            sql = "select rtype,description from reasontypes"
            ds = db.selectQuery(sql)

            With cmbReasonTypes
                .DisplayMember = "description"
                .ValueMember = "rtype"
                .DataSource = ds.Tables(0)
            End With
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillReasonCodes()
        Try
            sReasonType = cmbReasonTypes.SelectedValue()
            Dim ds As New DataSet
            sql = "select rejcd as [Reason Code],"
            sql = sql & " dsca as [Description]"
            sql = sql & " from Reasons where rtype='" & sReasonType & "'"
            ds = db.selectQuery(sql)

            dt = ds.Tables(0)
            dgReasonCodes.DataSource = dt
            FormatGrid()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgReasonCodes.Columns.Count - 1
            dgReasonCodes.Columns(i).ReadOnly = True
            dgReasonCodes.Columns(i).Width = 180
        Next
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        RejectionCode.Tag = "I"
        RejectionCode.txtrej.ReadOnly = False
        RejectionCode.ShowDialog()
        FillReasonCodes()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgReasonCodes.RowCount > 0 Then
            getReasonCodeDetails()
            RejectionCode.Tag = "U"
            RejectionCode.ShowDialog()
            FillReasonCodes()
        End If
    End Sub

    Private Sub getReasonCodeDetails()

        id = dgReasonCodes.Item(0, dgReasonCodes.CurrentRow.Index).Value.ToString()
        id1 = dgReasonCodes.Item(1, dgReasonCodes.CurrentRow.Index).Value.ToString()

        sql = ""
        sql = "select rtype, rejcd as [Reason Code],"
        sql = sql & " dsca as [Description]"
        sql = sql & " from Reasons where rejcd = '" & id & "'"
        ds = db.selectQuery(sql)

        RejectionCode.LoadReasonTypes()
        RejectionCode.cmbReasonTypes.SelectedValue = ds.Tables(0).Rows(0).Item("rtype")
        RejectionCode.txtrej.Text = ds.Tables(0).Rows(0).Item("Reason Code")
        RejectionCode.txtdesc.Text = ds.Tables(0).Rows(0).Item("Description")

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dgReasonCodes.RowCount > 0 Then

            id = dgReasonCodes.Item(0, dgReasonCodes.CurrentRow.Index).Value
            id1 = dgReasonCodes.Item(1, dgReasonCodes.CurrentRow.Index).Value

            Try
                If MsgBox("Are you sure to delete this Reason Code", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    sql = ""
                    sql = "Delete from Reasons where rejcd ='" & id & "' or dsca = '" & id1 & "'"
                    db.deleteQuery(sql)

                    FillReasonCodes()
                End If
            Catch
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmbReasonTypes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReasonTypes.SelectedIndexChanged
        FillReasonCodes()
    End Sub

    Private Sub dgReasonCodes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgReasonCodes.DoubleClick
        Try
            If dgReasonCodes.CurrentRow.Index < dt.Rows.Count Then
                getReasonCodeDetails()
                RejectionCode.Tag = "U"
                RejectionCode.ShowDialog()
                FillReasonCodes()
            End If
        Catch ex As Exception

        End Try

       
    End Sub

End Class
