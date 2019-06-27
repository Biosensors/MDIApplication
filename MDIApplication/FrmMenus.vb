Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Reflection
Imports MDIApplication.BioTrackMain

Public Class FrmMenus

    Public clspm As New clsPublic_Methods
    Dim datRow As DataRow

    Private Sub form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        GenerateRightsTree("")
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
        oRightsTree.CheckBoxes = False
        Try
            oRightsTree.Nodes.Clear()
            '//Filter parent menu items
            dr = clspm.dsL.Tables(0).Select("MainMenuID = 0 ")
            '//Populate menu with top menu items
            Dim oParentNode As New TreeNode
            Dim oCurrNode As New TreeNode
            Dim datRow As DataRow
            For Each datRow In dr
                oParentNode = New TreeNode
                oParentNode.Text = datRow("menuText")
                oParentNode.Name = datRow("menuId")
                oRightsTree.Nodes.Add(oParentNode)
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

            dr = clspm.dsL.Tables(0).Select("MainMenuID = " & parentID)
            '//Populate parent menu item with child menu items
            Dim datRow As DataRow
            For Each datRow In dr
                '//Define new menu item
                Dim menuid As Double
                menuid = datRow("MenuID")
                oChildNode = New TreeNode
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

    Private Function InsertChildNodes(ByVal cNode As TreeNode)
        Dim cLNode As TreeNode
        For Each cLNode In cNode.Nodes
            If cLNode.Checked Then
                Sql = ""
                'sql = sql & "insert into biorights(roleid, menuid) values('" & cmbRole.SelectedValue.ToString & "'," & cLNode.Name & ") "
                db.insertQuery(Sql)
                If cLNode.Nodes.Count > 0 Then
                    InsertChildNodes(cLNode)
                End If
            End If
        Next
    End Function

    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click

        'If oRightsTree.SelectedNode. = Nothing Then
        'If Not oRightsTree.SelectedNode.Level.ToString = Nothing Then
        If Not oRightsTree.SelectedNode.Level = 0 Then
            FrmNode.txtParentNode.Text = oRightsTree.SelectedNode.Text
            FrmNode.txtParentNode.ReadOnly = True
            FrmNode.txtChildNode.Text = ""
            FrmNode.CheckBox1.Checked = False
        Else
            FrmNode.txtParentNode.Text = oRightsTree.SelectedNode.Text
            FrmNode.txtParentNode.ReadOnly = True
            FrmNode.txtChildNode.Text = ""
            FrmNode.CheckBox1.Checked = False
        End If
        ' FrmNode.txtChildNode.Text = oRightsTree.SelectedNode.Text
        FrmNode.txtParentNode.ReadOnly = True
        '  FrmNode.rbFormName.Checked = True
        '  FrmNode.txtFormName.Visible = True
        FrmNode.rbMenuName.Checked = True
        ' FrmNode.txtChildNode.Text = ""
        FrmNode.CheckBox1.Checked = False
        FrmNode.CheckBox1.Visible = True
        FrmNode.Label4.Visible = True
        ' FrmNode.ShowDialog()
        FrmNode.ShowDialog()
        GenerateRightsTree("")
        oRightsTree.Refresh()
        'End If
    End Sub

    Private Sub oRightsTree_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oRightsTree.DoubleClick
        If Not oRightsTree.SelectedNode.Level = 0 Then
            FrmNode.txtParentNode.Text = oRightsTree.SelectedNode.Parent.Text
            FrmNode.txtChildNode.Text = ""
            FrmNode.CheckBox1.Checked = False

        Else
            FrmNode.txtParentNode.Text = "Menu"
        End If
        FrmNode.txtChildNode.Text = oRightsTree.SelectedNode.Text
        FrmNode.txtParentNode.ReadOnly = True
        FrmNode.rbMenuName.Checked = True
        FrmNode.CheckBox1.Checked = False
        FrmNode.CheckBox1.Visible = False
        FrmNode.Label4.Visible = False
        'FrmNode.ShowDialog()
        FrmNode.Show()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim sql As String
        Dim dr As DataRow()
        If (MsgBox("Are you sure you want to delete this menu", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            dr = clspm.dsL.Tables(0).Select("MenuText = '" & oRightsTree.SelectedNode.Text & "' ")
            If (dr.Length > 0) Then
                Dim menuid As String = dr(0)("MenuID")
                sql = ""
                sql = sql & "delete from Biomenus where MenuID = '" & menuid & "'"
                db.deleteQuery(sql)
            End If
            MsgBox("Deleted Successfully", MsgBoxStyle.Information)
        Else
            Me.Show()
        End If
        GenerateRightsTree("")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class