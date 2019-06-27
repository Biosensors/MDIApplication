Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports MDIApplication.BioTrackMain

Public Class RolesForm
    Public sql As String
    Public clspm As New clsPublic_Methods
    Dim db As New Class1
    Public id As String
    Public id1 As String
    Public dt As DataTable

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Roles()
    End Sub

    Private Function Roles()
        Try
            Dim ds As New DataSet
            sql = "select roleid as [Role ID],"
            sql = sql & " rolename as [Role Name]"
            sql = sql & " from BioRoles"
            ds = db.selectQuery(sql)

            dt = ds.Tables(0)
            dgRole.DataSource = dt

            FormatGrid()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgRole.Columns.Count - 1
            dgRole.Columns(i).ReadOnly = True
            dgRole.Columns(i).Width = 190
        Next
    End Sub

    Private Sub dgRole_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If dgRole.CurrentRow.Index < dt.Rows.Count Then
            getRoledetails()
            RoleAssign.Tag = "U"
            RoleAssign.ShowDialog()
            Roles()
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        RoleAssign.pstatus = "s"
        RoleAssign.Tag = "I"
        RoleAssign.txtRoleId.ReadOnly = False
        RoleAssign.Text = "Add Role"
        RoleAssign.ShowDialog()
        Roles()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        getRoledetails()
        RoleAssign.Tag = "U"
        RoleAssign.Text = "Edit Role"
        RoleAssign.ShowDialog()
        Roles()
    End Sub

    Private Sub getRoledetails()
        id = dgRole.Item(0, dgRole.CurrentRow.Index).Value
        id1 = dgRole.Item(1, dgRole.CurrentRow.Index).Value

        sql = ""
        sql = "select roleid as [Role ID],"
        sql = sql & " rolename as [Role Name]"
        sql = sql & " from BioRoles where roleid = '" & id & "'"
        ds = db.selectQuery(sql)
        RoleAssign.txtRoleId.Text = ds.Tables(0).Rows(0).Item("Role ID")
        RoleAssign.txtRoleName.Text = ds.Tables(0).Rows(0).Item("Role Name")
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        id = dgRole.Item(0, dgRole.CurrentRow.Index).Value
        id1 = dgRole.Item(1, dgRole.CurrentRow.Index).Value

        Try
            If MsgBox("Are you sure to delete this Role", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                sql = ""
                sql = "Delete from BioRoles where roleid ='" & id & "' or rolename = '" & id1 & "'"
                db.deleteQuery(sql)
                MsgBox("Deleted Successfully", MsgBoxStyle.Information)
                Roles()
            End If
        Catch
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class