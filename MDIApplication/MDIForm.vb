Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Reflection
Imports System.DirectoryServices
Imports System.Text
Imports System.Text.StringBuilder
Imports MDIApplication.BioTrackMain
Imports MDIApplication.IniFileFunctions
Imports System.Diagnostics.Process

Public Class MDIForm
    Public clspm As New clsPublic_Methods
    Dim datRow As DataRow

    Private Sub form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call OpenLogonForm()
        LogIn.txtPassword.Focus()
    End Sub

    Public Sub PopulateMenu(ByVal userId As String)
        Try
            '//Define new menu
            Menu = New MainMenu

            '//Retrieve menu data
            Dim menuData As DataSet = clspm.GetMenuData(userId)
            AddTopMenuItems(menuData, Menu)

        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub OpenLogonForm()
        sLogonUser = ""
        LogIn.MdiParent = Me
        LogIn.Show()
        If Not sLogonUser = "" Then
            Call PopulateMenu(sLogonUser)
            Me.Activate()
            'MDIForm.Activate()
            Me.TSSlblLogin.Text = UserFullName & " (" & sLogonUser & ")"
            Me.TSSlbldbName.Text = LogIn.cmbServer.SelectedItem
            Me.TSSlblVersion.Text = "Ver: " & sVersion & ""
            'Do load Menu
            'Call MDIForm.PopulateMenu(sLogonUser)

        End If
    End Sub

    Private Sub AddTopMenuItems(ByVal menuData As DataSet, ByVal menu As Menu)
        Dim dr As DataRow()
        Try
            '//Filter parent menu items
            dr = clspm.dsL.Tables(0).Select("MainMenuID = 0")
            '//Populate menu with top menu items

            Dim datRow As DataRow
            For Each datRow In dr
                ' For Each dr In datRow
                Dim parentMenu As MenuItem
                parentMenu = clspm.CreateMenuItem(datRow("MenuText"), datRow("MenuID"))
                menu.MenuItems.Add(parentMenu)

                '//Populate child items of this parent
                AddChildMenuItems(menuData, datRow("MenuID"), parentMenu)
            Next

        Catch ex As System.Exception
        End Try

    End Sub

    Private Sub AddChildMenuItems(ByVal menuData As DataSet, ByVal parentID As Integer, ByVal parentMenu As MenuItem)

        Try
            Dim frmName As String = ""
            Dim dr As DataRow()
            dr = clspm.dsL.Tables(0).Select("MainMenuID = " & parentID)
            '//Populate parent menu item with child menu items
            Dim datRow As DataRow
            For Each datRow In dr
                '//Define new menu item
                Dim childMenu As MenuItem
                Dim menuid As Double
                menuid = datRow("MenuID")
                childMenu = clspm.CreateMenuItem(datRow("MenuText"), menuid)
                parentMenu.MenuItems.Add(childMenu)
                If Not (UCase(datRow("FormName")) = "NULL" Or datRow("FormName") = "") Then

                    FindEventsByName(childMenu, Me, True, "SelectedChildMenu", "OnClick")

                End If

                '//Populate child items of this parent
                AddChildMenuItems(menuData, datRow("MenuID"), childMenu)
            Next

        Catch ex As System.Exception
        End Try

    End Sub

    Private Sub SelectedChildMenu_OnClick(ByVal Sender As Object, ByVal e As System.EventArgs)

        Dim frmName As String = ""
        Dim dr As DataRow()
        dr = clspm.dsL.Tables(0).Select(" MenuID = " & Sender.tag)

        If (Sender.text.ToString() = "Exit") Then
            If (MsgBox("Are you sure you want to exit", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Me.Close()
            End If

        ElseIf (Sender.Text.ToString() = "Scanning") Then
            Process.Start(dr(0).Item("FormName").ToString(), sLogonUser)

        ElseIf (Sender.text.ToString() = "Log Off") Then

            If (MsgBox("Are you sure you want to log off", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Me.Menu = Nothing
                OpenLogonForm()
                Me.TSSlblLogin.Text = ""
                Me.TSSlbldbName.Text = ""
                Me.TSSlblVersion.Text = "Ver: (" & "" & ")"
                'MsgBox("Actual QTY (" & qty & " ) is exceeding the available QTY. (" & nAvailableQty & " )", MsgBoxStyle.Critical)
            Else
                Me.Activate()

                ' ' OpenLogonForm()
                ' '  If Not sLogonUser = "" Then
                ' Call PopulateMenu(sLogonUser)
                ' 'MDIForm.Activate()
                ' Me.TSSlblLogin.Text = UserFullName
                ' Me.TSSlbldbName.Text = LogIn.cmbServer.SelectedItem

            End If
            ''Me.Hide()
            ''frmParent = New MDIForm
            ''Me.Show()
            ''Me.Enabled = True
            ' Me.Menu = Nothing
            'OpenLogonForm()

            'Me.TSSlblLogin.Text = ""
            'Me.TSSlbldbName.Text = ""
        Else

            If dr.Length > 0 Then
                frmName = dr(0).Item("FormName").ToString()
                strQuery = dr(0).Item("qstring").ToString()
                strMenuText = dr(0).Item("MenuText").ToString()
                strQuery = strQuery.Replace("<SQ>", "'")
                'clspm.DynamicallyLoadedObject(frmName).MdiParent = Me
                clspm.DynamicallyLoadedObject(frmName).ShowDialog(Me)
            End If

        End If

    End Sub

    Private Sub FindEventsByName(ByVal sender As Object, ByVal receiver As Object, ByVal bind As Boolean, ByVal handlerPrefix As String, ByVal handlerSufix As String)

        ' Get the sender's public events.
        Dim SenderEvents() As System.Reflection.EventInfo = sender.GetType().GetEvents()

        ' Get the receiver's type and lookup its public
        ' methods matching the naming convention:
        '  handlerPrefix+Click+handlerSufix
        Dim ReceiverType As Type = receiver.GetType()
        Dim E As System.Reflection.EventInfo
        Dim Method As System.Reflection.MethodInfo
        Try
            For Each E In SenderEvents
                If E.Name = "Click" Then
                    Method = ReceiverType.GetMethod(handlerPrefix & "_" & handlerSufix, System.Reflection.BindingFlags.IgnoreCase Or System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
                    'receivertype.getme

                    If Not Method Is Nothing Then
                        Dim D As System.Delegate = System.Delegate.CreateDelegate(E.EventHandlerType, receiver, Method.Name)

                        If bind Then
                            'add the event handler
                            E.AddEventHandler(sender, D)

                        Else
                            'you can also remove the event handler if you pass bind variable as false
                            E.RemoveEventHandler(sender, D)
                        End If

                    End If
                End If

            Next
        Catch ex As System.Exception
            MsgBox(ex)
        End Try
    End Sub

End Class