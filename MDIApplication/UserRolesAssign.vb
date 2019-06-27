Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Reflection
Imports MDIApplication.BioTrackMain

Public Class UserRolesAssign
    Public bu As New BioUsersMenus
    Public u As New FrmUser
    Public clspm As New clsPublic_Methods
    Dim datRow As DataRow
    Public sRoleid As String

    Private Sub form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        GenerateUsersRolesTree(txtuid.Text)
    End Sub

    Public Sub GenerateUsersRolesTree(ByVal sUserID As String)

        Try
            '//Retrieve menu data
            Dim menuData As DataSet = clspm.GetUserRoles(sUserID)

            AddTopLevelRights(menuData)

        Catch ex As System.Exception
        End Try

    End Sub

    Public Sub AddTopLevelRights(ByVal menuData As DataSet)
        ' Dim dr As DataRow()
        Try
            oRightsTree.Nodes.Clear()
            '//Populate menu with top menu items
            Dim oParentNode As New TreeNode
            Dim oCurrNode As New TreeNode
            Dim datRow As DataRow
            For Each datRow In menuData.Tables(0).Rows
                oParentNode = New TreeNode
                oParentNode.Checked = datRow("HasAccess")
                oParentNode.Text = datRow("RoleName")
                oParentNode.Name = datRow("RoleID")
                oRightsTree.Nodes.Add(oParentNode)
            Next

        Catch ex As System.Exception
        End Try

    End Sub

    Public Sub oRightsTree_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles oRightsTree.AfterCheck

        If e.Action <> TreeViewAction.Unknown Then
            If e.Node.Nodes.Count > 0 Then
                CheckAllChildNodes(e.Node, e.Node.Checked)
            End If
        End If
    End Sub

    Public Function CheckAllChildNodes(ByVal TreeNode As TreeNode, ByVal ChkStatus As Boolean)
        Dim LoclNode As New TreeNode
        For Each LoclNode In TreeNode.Nodes
            LoclNode.Checked = ChkStatus
            If LoclNode.Nodes.Count > 0 Then
                CheckAllChildNodes(LoclNode, ChkStatus)
            End If
        Next
    End Function
    
    Private Function InsertChildNodes(ByVal cNode As TreeNode)
        Dim cLNode As TreeNode
        For Each cLNode In cNode.Nodes
            If cLNode.Checked Then
                Sql = ""
                Sql = Sql & "insert into biouserrights(userid, roleid) values('" & txtuid.Text.Trim & "'," & sRoleid & ") "
                db.insertQuery(Sql)
                If cLNode.Nodes.Count > 0 Then
                    InsertChildNodes(cLNode)
                End If
            End If
        Next
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sql As String

        Dim LoclNode As New TreeNode
        Try
            sql = " delete from Biouserrights where userid = '" & txtuid.Text.Trim & "'"
            db.deleteQuery(sql)
            For Each LoclNode In oRightsTree.Nodes
                If LoclNode.Checked Then
                    sql = ""
                    sql = sql & "insert into biouserrights(userid, roleid) values('" & txtuid.Text.Trim & "', '" & LoclNode.Name & "') "
                    db.insertQuery(sql)
                    If LoclNode.Nodes.Count > 0 Then
                        InsertChildNodes(LoclNode)
                    End If
                End If

            Next
            MsgBox("Saved successfully", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class