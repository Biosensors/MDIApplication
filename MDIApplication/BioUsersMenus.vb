Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Reflection
Imports MDIApplication.BioTrackMain
Public Class BioUsersMenus
    Public clspm As New clsPublic_Methods
    Dim datRow As DataRow

    Private Sub form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Dim sRoleID As String = "NONE"
        ' sConnectionServer = getConnectionString("TEST Server")
        loadCMBRoles()
        cmbRole.SelectedIndex = 0
    End Sub

    Public Sub GenerateRightsTree(ByVal sRoleID As String)

        Try

            '//Define new menu

            '//Retrieve menu data
            Dim menuData As DataSet = clspm.GetSecurityRightsMenus(sRoleID)

            AddTopLevelRights(menuData)

        Catch ex As System.Exception
        End Try

    End Sub

    Public Sub AddTopLevelRights(ByVal menuData As DataSet)
        Dim dr As DataRow()
        Try
            oRightsTree.Nodes.Clear()
            '//Filter parent menu items
            dr = clspm.dsL.Tables(0).Select("MainMenuID = 0")
            '//Populate menu with top menu items
            Dim oParentNode As New TreeNode
            Dim oCurrNode As New TreeNode
            'Dim nParentNodeID As Integer
            Dim datRow As DataRow
            For Each datRow In dr
                ' For Each dr In datRow
                'Dim parentMenu As MenuItem
                oParentNode = New TreeNode
                oParentNode.Checked = datRow("HasAccess")
                oParentNode.Text = datRow("menuText")
                oParentNode.Name = datRow("menuId")

                'oParentNode = oRightsTree.Nodes.Add(datRow("MenuID"), datRow("MenuText"))

                oRightsTree.Nodes.Add(oParentNode)
                'parentMenu = clspm.CreateMenuItem(datRow("MenuText"), datRow("MenuID"))
                'menu.MenuItems.Add(parentMenu)

                '//Populate child items of this parent
                AddChildLevelRights(menuData, datRow("MenuID"), oParentNode)
            Next

        Catch ex As System.Exception
        End Try

    End Sub

    Public Sub AddChildLevelRights(ByVal menuData As DataSet, ByVal parentID As Integer, ByVal ParentNode As TreeNode)

        Try
            Dim frmName As String = ""
            Dim dr As DataRow()
            Dim oChildNode As New TreeNode

            Dim oCurrNode As New TreeNode

            'Dim nParentNodeId As Integer
            dr = clspm.dsL.Tables(0).Select("MainMenuID = " & parentID)
            '//Populate parent menu item with child menu items
            Dim datRow As DataRow
            For Each datRow In dr
                '//Define new menu item
                'Dim childMenu As MenuItem
                Dim menuid As Double
                menuid = datRow("MenuID")
                oChildNode = New TreeNode
                oChildNode.Checked = datRow("HasAccess")
                oChildNode.Text = datRow("menuText")
                oChildNode.Name = datRow("menuId")
                'oParentNode = oRightsTree.Nodes.Add(datRow("MenuID"), datRow("MenuText"))
                ParentNode.Nodes.Add(oChildNode)


                'oChildNode = ParentNode.Nodes.Add(datRow("MenuID"), datRow("MenuText"))

                'oChildNode = oRightsTree.Nodes.Add(datRow("MenuID"), datRow("MenuText"))


                'childMenu = clspm.CreateMenuItem(datRow("MenuText"), menuid)
                'parentMenu.MenuItems.Add(childMenu)
                If Not (UCase(datRow("FormName")) = "NULL" Or datRow("FormName") = "") Then

                    'FindEventsByName(childMenu, Me, True, "SelectedChildMenu", "OnClick")

                End If

                '//Populate child items of this parent
                AddChildLevelRights(menuData, datRow("MenuID"), oChildNode)
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

    Public Sub loadCMBRoles()
        Dim sql As String

        sql = ""
        sql = sql & " select roleid, rolename from BioRoles"

        ds = db.selectQuery(sql)
        'Bind the countries combo
        With cmbRole
            .DisplayMember = "RoleName"
            .ValueMember = "Roleid"
            .DataSource = ds.Tables(0)
        End With
        'ds = Nothing
    End Sub

    Private Sub cmbRole_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRole.SelectedIndexChanged
        Dim sRoleID As String
        sRoleID = cmbRole.SelectedValue.ToString
        'MsgBox(sRoleID)
        Call GenerateRightsTree(sRoleID)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sql As String
        'Dim ds As New DataSet
        ' Dim oCmbSelectedItem As String = cmbRole.SelectedItem.ToString
        Dim LoclNode As New TreeNode
        Try
            sql = "Delete from BioRights where roleid = '" & cmbRole.SelectedValue.ToString & "'"
            db.deleteQuery(sql)
            For Each LoclNode In oRightsTree.Nodes
                If LoclNode.Checked Then
                    sql = ""
                    sql = sql & "insert into biorights(roleid, menuid) values('" & cmbRole.SelectedValue.ToString & "'," & LoclNode.Name & ") "
                    db.insertQuery(sql)
                    If LoclNode.Nodes.Count > 0 Then
                        InsertChildNodes(LoclNode)
                    End If
                End If

            Next
            MsgBox(" Saved successfully", MsgBoxStyle.Information)
        Catch ex As System.Exception

        End Try
    End Sub

    Private Function InsertChildNodes(ByVal cNode As TreeNode)
        Dim cLNode As TreeNode
        For Each cLNode In cNode.Nodes
            If cLNode.Checked Then
                Sql = ""
                Sql = Sql & "insert into biorights(roleid, menuid) values('" & cmbRole.SelectedValue.ToString & "'," & cLNode.Name & ") "
                db.insertQuery(Sql)
                If cLNode.Nodes.Count > 0 Then
                    InsertChildNodes(cLNode)
                End If
            End If
        Next
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class