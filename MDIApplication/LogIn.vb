Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Configuration
Imports System.DirectoryServices
Imports System.Text
Imports System.Text.StringBuilder
Imports MDIApplication.BioTrackMain
Imports MDIApplication.IniFileFunctions
Public Class LogIn
    Public clspm As New clsPublic_Methods
    Public ds As New DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sIniSections As String
        Dim sStr() As String
        Dim j As Integer
        Dim sIniPath As String

        domainUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name
        txtUserName.Text = domainUser

        sIniPath = sGetIniFilePath()
        If Not sIniPath = "" Then
            sIniSections = INIRead(sIniPath)
            sIniSections = sIniSections.Replace(ControlChars.NullChar, "|"c)
            ' to split the pipe and load the sections into the dropdownlist

            sStr = Split(sIniSections, "|")

            If (sStr.Length > 0) Then
                For j = 0 To sStr.Length - 2

                    Me.cmbServer.Items.Add(sStr(j))
                Next
            End If
            'sValue = INIRead(Application.StartupPath & "\biotrack.ini", "section2", "Key2")
        End If
        Me.txtUserName.Focus()
    End Sub

    Private Sub Login_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'If (sLoginCancel) Then
        'Me.Close()
        '    Application.Exit()
        'Else

        Application.Exit()
        '    ' frmParent = New MDIForm
        '    ' frmParent.Show()
        '    'Else
        'End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If (sLoginCancel) Then
            Me.Close()
            Application.Exit()
        Else

            Application.Exit()
            ' frmParent = New MDIForm
            ' frmParent.Show()
            'Else
        End If
    End Sub
    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        If cmbServer.SelectedIndex <> -1 Then
            ValidateLogin()
        End If

    End Sub
    Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged
        If (txtUserName.Text = "") Then
            btnLogIn.Enabled = False
        Else
            btnLogIn.Enabled = True
        End If

    End Sub
    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            If Not (cmbServer.Text = "") Then
                ' If Not (cmbServer.SelectedValue.ToString = "") Then
                ValidateLogin()

            Else
                MsgBox("Select the Application Server", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
    Private Sub ValidateLogin()
        Try
            sLogonUser = "*"
            sConnectionServer = getConnectionString(cmbServer.SelectedItem.ToString, sVersion)

            'Check the same userName/PWD exist in table Users
            ' split the txtUserName.text (ex. BSI\Admin to Admin) for checking in table

            nUserPos = InStr(txtUserName.Text, "\")
            If nUserPos > 0 Then
                Username = Mid(txtUserName.Text, nUserPos + 1, Len(txtUserName.Text))
            Else
                Username = Trim(txtUserName.Text)
            End If
            sLogonUser = Username

            If (True = clspm.ValidateActiveDirectoryLogin(txtUserName.Text.Trim(), txtPassword.Text.Trim())) Then
                'True part - show the form to redirect
                'FormName.show()    

                If (getUserAuthentication() = True) Then
                    ' To update password for successfull windows authentication
                    Sql = "update Users set passwd = '" & txtPassword.Text.Trim() & "' where userid = '" & sLogonUser & "'"
                    db.updateQuery(Sql)
                    SuccessLogin()
                Else
                    sLogonUser = "*"
                    'throw exception stated with userid is not defined in the table
                    MsgBox("User does not exist.", MsgBoxStyle.Critical)
                End If
            Else
                Sql = "select userid from Users where userid = '" & txtUserName.Text.Trim() & "' and passwd = '" & txtPassword.Text.Trim() & "'"
                ds = db.selectQuery(Sql)

                If (ds.Tables(0).Rows.Count > 0) Then
                    SuccessLogin()
                Else
                    MsgBox("Authentication did not succeed. Check user name and password.", MsgBoxStyle.Critical)
                End If

                'show the error message

            End If

        Catch ex As System.Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub SuccessLogin()
        Me.txtPassword.Text = ""
        Me.Hide()

        sLoginCancel = True

        Call MDIForm.PopulateMenu(sLogonUser)
        ' sLogonUser = UserNameActual
        ' MDIForm.Activate()
        MDIForm.TSSlblLogin.Text = UserFullName & " (" & sLogonUser & ")"
        MDIForm.TSSlbldbName.Text = cmbServer.SelectedItem
        MDIForm.TSSlblVersion.Text = "Ver: " & sVersion & ""
        MDIForm.Activate()
        'Do load Menu
        'Call MDIForm.PopulateMenu(sLogonUser)
    End Sub

    Private Sub cmbServer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbServer.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then

            If cmbServer.SelectedIndex <> -1 Then
                'If Not (cmbServer.SelectedItem.ToString = "") Then
                ValidateLogin()
            End If

        End If
    End Sub
End Class