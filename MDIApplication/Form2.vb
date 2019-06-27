Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Reflection

Public Class Form2
    Public db As New Class1
    Dim cfg As New ClsConfig
    Dim constr As String = cfg.connectionString
    Public dsL As New DataSet
    Public conn As New SqlConnection(constr)


    '//Connection to database from web.config file

    ' Private conn As New OleDbConnection(ConfigurationManager.ConnectionStrings("menu").ConnectionString)

    Private Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Call PopulateMenu()

    End Sub

    Private Sub PopulateMenu()

        Try

            '//Define new menu

            'Dim menu As Menu
            Menu = New MainMenu
            '//Retrieve menu data

            Dim menuData As DataSet = GetMenuData()

            AddTopMenuItems(menuData, menu)

            'Me.Controls.Add(menu)



        Catch ex As Exception

            ' Response.Write(ex.Message.ToString() & "<br />")

        End Try

    End Sub

    Private Function GetMenuData() As DataSet

        Try

            '//Populate DataTable

            Dim strSQL As String = "SELECT * FROM MDI_MENUMASTER order by MainMenuId, seqNo"

            'Dim datMenu As OleDbDataAdapter = New OleDbDataAdapter(strSQL, conn)
            dsL = db.selectQuery(strSQL)

            ' Dim tblMenu As DataTable = New DataTable()



            ' datMenu.Fill(tblMenu)

            Return dsL

        Catch ex As Exception

            ' Response.Write(ex.Message.ToString() & "<br />")

        End Try

    End Function

    Private Sub AddTopMenuItems(ByVal menuData As DataSet, ByVal menu As Menu)
        Dim dr As DataRow()
        Try

            '//Populate DataView
            ' Dim datView As DataView = New DataView(menuData)
            '//Filter parent menu items
            'datView.RowFilter = "parentid = 0"

            dr = dsL.Tables(0).Select("MainMenuID = 0")
            '//Populate menu with top menu items

            Dim datRow As DataRow
            For Each datRow In dr
                ' For Each dr In datRow
                '//Define new menu item

                Dim parentMenu As MenuItem
                ' parentMenu = CreateMenuItem(datRow("linktext"), datRow("linkurl"), datRow("linktext"))
                parentMenu = CreateMenuItem(datRow("MenuText"))
                menu.MenuItems.Add(parentMenu)

                '//Populate child items of this parent

                AddChildMenuItems(menuData, datRow("MenuID"), parentMenu)

            Next

        Catch ex As Exception

            ' Response.Write(ex.Message.ToString() & "<br />")

        End Try

    End Sub

    Private Sub AddChildMenuItems(ByVal menuData As DataSet, ByVal parentID As Integer, ByVal parentMenu As MenuItem)

        Try

            Dim dr As DataRow()


            '//Populate DataView
            ' Dim datView As DataView = New DataView(menuData)
            '//Filter child menu items
            '  datView.RowFilter = "parentid = " & parentID

            dr = dsL.Tables(0).Select("MainMenuID = " & parentID)
            '//Populate parent menu item with child menu items
            Dim datRow As DataRow
            For Each datRow In dr
                '//Define new menu item
                Dim childMenu As MenuItem
                childMenu = CreateMenuItem(datRow("MenuText"))
                parentMenu.MenuItems.Add(childMenu)
                '//Populate child items of this parent
                AddChildMenuItems(menuData, datRow("MenuID"), childMenu)


                ' For Each dr In datRow
                'Dim datRow As DataRowView
                ' For Each datRow In datView
                '//Define new menu item
                'Dim childMenu As MenuItem
                'childMenu = CreateMenuItem(datRow("linktext"), datRow("linkurl"), datRow("linktext"))
                'parentMenu.ChildItems.Add(childMenu)
                '//Populate child items of this parent
                '  AddChildMenuItems(menuData, datRow("itemid"), childMenu)

            Next

        Catch ex As Exception

            ' Response.Write(ex.Message.ToString() & "<br />")

        End Try

    End Sub

    Private Function CreateMenuItem(ByVal strText As String) As MenuItem

        Try

            '//Create new menu item

            Dim menuItem As New MenuItem()

            '//Set properties of the menu item

            With menuItem

                .Text = strText

            End With

            Return menuItem

        Catch ex As Exception

            'Response.Write(ex.Message.ToString() & "<br />")

        End Try

    End Function

End Class




