Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Reflection
Imports MDIApplication.BioTrackMain

Public Class FrmQuery
    Public clspm As New clsPublic_Methods
    Public Sql As String
    Public db As New Class1
    Public dsQry As DataSet

    Private Sub form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Text = strMenuText
        fillQueryGrid()
    End Sub

    'Public Property GetQueryString()
    '    Get
    '        Return strQuery
    '    End Get
    '    Set(ByVal value)
    '        strQuery = value
    '    End Set
    'End Property

    Private Sub fillQueryGrid()
        Try
            ds = db.selectQuery(strQuery)
            dgQuery.DataSource = ds.Tables(0).DefaultView
            FormatGrid()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        For i = 0 To dgQuery.Columns.Count - 1
            dgQuery.Columns(i).ReadOnly = True
            dgQuery.Columns(i).Width = 140
        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Function getConditionQry() As String
        Dim strWhere As String = "Where"
        Dim qrystr As String
        If Not (cmbWarehouse.SelectedText = "") Then
            qrystr = " and warehouse = '" & cmbWarehouse.SelectedValue & "'"
        End If
        If Not (txtItem.Text = "") Then
            qrystr = " and Item = '" & txtItem.Text & "'"
        End If
        If (chbxAll.Checked = True) Then
            DateTimePicker1.Text = ""
            DateTimePicker2.Text = ""
        Else
            DateTimePicker1.Text = Now()
            DateTimePicker2.Text = Now()
        End If
        If Not (txtRef.Text = "") Then
            qrystr = " and Reference = '" & txtRef.Text & "'"
        End If
        If Not (txtResource.Text = "") Then
            qrystr = " and Resource = '" & txtResource.Text & "'"
        End If
        getConditionQry()
    End Function

End Class