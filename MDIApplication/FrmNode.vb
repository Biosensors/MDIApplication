Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Reflection
Imports MDIApplication.BioTrackMain

Public Class FrmNode
    Public clspm As New clsPublic_Methods
    Dim datRow As DataRow

    Private Sub form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadMenuTree("")
        checkFieldEnable()
        cmbType.Items.Clear()

        cmbType.Items.Insert(0, "Std Form")
        cmbType.Items.Insert(1, "Query")
        cmbType.Items.Insert(2, "Application")
    End Sub

    Public Sub LoadMenuTree(ByVal sRoleID As String)

        Try
            '//Retrieve menu data
            Dim menuData As DataSet = clspm.GetSecurityRightsMenus(sRoleID)

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dr As DataRow()
        Dim menuid As String
        Dim Parentmenuid As String
        Dim typeValue As Integer = cmbType.SelectedIndex
        'Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        ' Dim oSqlCommand As SqlCommand
        ' Dim conn As New SqlConnection(sConnectionServer)

        dr = clspm.dsL.Tables(0).Select("MenuText = '" & Trim(txtParentNode.Text) & "' ")
        Dim sQry As String = rtbQuery.Text.ToString()
        ' Dim sQry1 As String = "Test"
        sQry = Replace(sQry, "'", "<SQ>")
        Try
            If txtChildNode.Text = "" Then
                MsgBox("Enter Node")
                txtChildNode.Focus()
            Else
                If (CheckBox1.Checked = False) Then

                    If (rbFormName.Checked) Then
                        If (dr.Length > 0) Then
                            menuid = dr(0)("MenuID")
                            If (typeValue <> 1) Then
                                Sql = ""
                                Sql = "update biomenus set FormName = '" & Trim(txtFormName.Text) & "', type = " & typeValue & ""
                                Sql = Sql & " where menuid = '" & menuid & "'"
                                db.updateQuery(Sql)
                            Else
                                Sql = ""
                                Sql = "update biomenus set qstring = '" & sQry & "', type = " & typeValue & ""
                                Sql = Sql & " where menuid = '" & menuid & "'"
                                db.updateQuery(Sql)
                                ' conn.Open()
                                ' oSqlCommand = New SqlCommand(Sql, conn)
                                ' oSqlCommand.ExecuteNonQuery()
                                '  FrmQuery.GetQueryString = rtbQuery.Text
                                ' FrmQuery.Show()
                            End If
                        End If
                    Else

                        If Trim(txtParentNode.Text) = "Menu" Then
                            Parentmenuid = "0"
                        Else
                            dr = clspm.dsL.Tables(0).Select("MenuText = '" & Trim(txtParentNode.Text) & "'")
                            Parentmenuid = dr(0)("MenuID")
                        End If

                        Sql = ""
                        Sql = Sql & "insert into biomenus(menutext,mainmenuid,menuOrder,isActive,FormName,seqNo,type)"
                        Sql = Sql & " values('" & Trim(txtChildNode.Text) & "', '" & Parentmenuid & "','" & Parentmenuid & "',"
                        Sql = Sql & " '1',' ', '" & Parentmenuid & "', '0')"
                        db.insertQuery(Sql)
                    End If
                Else
                    If Trim(txtParentNode.Text) = "Menu" Then
                        Parentmenuid = "0"
                    Else
                        dr = clspm.dsL.Tables(0).Select("MenuText = '" & Trim(txtParentNode.Text) & "'")
                        Parentmenuid = dr(0)("MenuID")
                    End If

                    Sql = ""
                    Sql = Sql & "insert into biomenus(menutext,mainmenuid,menuOrder,isActive,FormName,seqNo)"
                    Sql = Sql & " values('" & Trim(txtChildNode.Text) & "', '0','0',"
                    Sql = Sql & " '1',' ', '" & Parentmenuid & "')"
                    db.insertQuery(Sql)

                End If
                'FrmMenus.GenerateRightsTree("")
                'FrmMenus.oRightsTree.Refresh()
                Me.Close()
            End If
        Catch ex As System.Exception

        End Try
        ' Me.Close()
    End Sub

    Private Sub rbFormName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFormName.CheckedChanged
        checkFieldEnable()
    End Sub

    Private Sub rbMenuName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMenuName.CheckedChanged
        txtFormName.Visible = False
        lblFormName.Visible = False
        CheckBox1.Checked = False
        lblType.Visible = False
        cmbType.Visible = False
        rtbQuery.Visible = False
        txtFormName.Text = ""
        checkFieldEnable()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        checkFieldEnable()
    End Sub

    Private Sub checkFieldEnable()
        If CheckBox1.Checked = True Then
            rbMenuName.Checked = True
            rbFormName.Checked = False
            txtFormName.Visible = False
            lblFormName.Visible = False
            lblType.Visible = False
            cmbType.Visible = False
            rtbQuery.Visible = False
            txtFormName.Text = ""
            CheckBox1.Checked = True

        ElseIf CheckBox1.Checked = False And rbFormName.Checked = True Then
            rbMenuName.Checked = False
            rbFormName.Checked = True
            ' txtFormName.Visible = True
            ' lblFormName.Visible = True
            CheckBox1.Checked = False
            lblType.Visible = True
            cmbType.Visible = True
            
            rtbQuery.Visible = False
            txtFormName.Text = ""

        End If
    End Sub

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        showNodeFormType()
    End Sub

    Private Sub showNodeFormType()
        Try
            sNodeFormType = ""
            Select Case cmbType.SelectedIndex
                Case Is = 0
                    sNodeFormType = "Std Form"
                    txtFormName.Visible = True
                    lblFormName.Visible = True
                    lblFormName.Text = "Form Name"
                    rtbQuery.Visible = False
                    Exit Select
                Case Is = 1
                    sNodeFormType = "Query"
                    lblFormName.Visible = True
                    lblFormName.Text = "Query"
                    rtbQuery.Visible = True
                    txtFormName.Visible = False
                    Exit Select
                Case Is = 2
                    sNodeFormType = "Application"
                    lblFormName.Visible = True
                    lblFormName.Text = "Application"
                    rtbQuery.Visible = False
                    txtFormName.Visible = True
                    Exit Select
            End Select
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class

