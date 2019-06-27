Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Reflection
Imports MDIApplication.BioTrackMain

Public Class UserMainForm
    Public sql As String
    Public inc As Integer
    Public id As String
    Public id1 As String
    Public ds As New DataSet
    Public db As New Class1
    Public n As String
    Public s As String
    Public r As New UserRolesAssign
    Public clspm As New clsPublic_Methods
    Dim datRow As DataRow
    Dim dt As DataTable

    Private Sub UserForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  sConnectionServer = getConnectionString("TEST Server")
        Users()
    End Sub

    Private Function Users()
        Try
            Dim sql As String

            Dim db As New Class1
            Dim ds As New DataSet
            sql = "select uname as [User Name], "
            sql = sql & " userid as [User ID]"
            sql = sql & " from Users where  not userid='Admin'"
            sql = sql & " order by uname"
            ds = db.selectQuery(sql)

            dt = ds.Tables(0)
            dgUser.DataSource = dt

            FormatGrid()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgUser.Columns.Count - 1
            dgUser.Columns(i).ReadOnly = True
            dgUser.Columns(i).Width = 186
        Next
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click, Button2.Click
        FrmUser.pstatus = "s"
        FrmUser.Tag = "I"
        FrmUser.Text = "New User Registration Form"
        FrmUser.txtuid.Text = ""
        FrmUser.txtname.Text = ""
        FrmUser.txtPassword.Text = ""
        FrmUser.ShowDialog()
        Users()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click, Button1.Click
        getUserdetails()
        FrmUser.Tag = "U"
        FrmUser.Text = "Edit User Form"
        FrmUser.ShowDialog()
        Users()
    End Sub

    Private Sub getUserdetails()

        id = dgUser.Item(0, dgUser.CurrentRow.Index).Value
        id1 = dgUser.Item(1, dgUser.CurrentRow.Index).Value

        sql = ""
        sql = "select uname as [Name],userid as [User ID], passwd as Password, stat "
        sql = sql & " from Users where userid = '" & id1 & "'"
        ds = db.selectQuery(sql)
        FrmUser.txtname.Text = ds.Tables(0).Rows(0).Item("Name")
        FrmUser.txtuid.Text = ds.Tables(0).Rows(0).Item("User Id")
        FrmUser.txtPassword.Text = ds.Tables(0).Rows(0).Item("Password")
        FrmUser.chbstat.Checked = ds.Tables(0).Rows(0).Item("stat")

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        id = dgUser.Item(0, dgUser.CurrentRow.Index).Value
        id1 = dgUser.Item(1, dgUser.CurrentRow.Index).Value
        Try
            If MsgBox("Are you sure to delete this User", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = ""
                sql = "Delete from Users where uname ='" & id & "' or userid = '" & id1 & "'"
                db.deleteQuery(sql)
                MsgBox("Deleted Successfully", MsgBoxStyle.Information)
                Users()
            End If
        Catch
        End Try
    End Sub

    Private Sub btnRoles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoles.Click

        id = dgUser.Item(0, dgUser.CurrentRow.Index).Value
        id1 = dgUser.Item(1, dgUser.CurrentRow.Index).Value

        sql = ""
        sql = "select uname as [Name],userid as [User ID], stat "
        sql = sql & " from Users where userid = '" & id1 & "'"
        ds = db.selectQuery(sql)

        UserRolesAssign.txtname.Text = ds.Tables(0).Rows(0).Item("Name")
        UserRolesAssign.txtuid.Text = ds.Tables(0).Rows(0).Item("User Id")
        UserRolesAssign.txtname.ReadOnly = True
        UserRolesAssign.txtuid.ReadOnly = True
        UserRolesAssign.Show()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dguser_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If dgUser.CurrentRow.Index < dt.Rows.Count Then
            getUserdetails()
            FrmUser.Tag = "U"
            FrmUser.ShowDialog()

            Users()
        End If
        
    End Sub

End Class