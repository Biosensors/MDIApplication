Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.ComponentModel.Container
Imports System.Drawing

Public Class FrmStentWeight
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim strSerialNo As String
    Dim StentKey As Integer
    Dim iCoating As Integer

    Private Sub FrmStentWeight_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        chkPreCoat.Checked = True
        chkPostCoat.Checked = True
        chk15MinsCheck.Checked = True
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FillGrid()
    End Sub

    Public Sub FillGrid()
        Try
            Dim sql As String

            Dim sqlCoat As String
            sqlCoat = ""

            If chkPreCoat.Checked Then
                If chk15MinsCheck.Checked Then
                    If chkPostCoat.Checked Then
                        sqlCoat = ""
                    Else
                        sqlCoat = " and (coating = 1 or coating = 2)"
                    End If
                Else
                    If chkPostCoat.Checked = True Then
                        sqlCoat = " and (coating = 1 or coating = 3)"
                    Else
                        sqlCoat = " and coating = 1"
                    End If
                End If
            Else
                If chk15MinsCheck.Checked Then
                    If chkPostCoat.Checked Then
                        sqlCoat = " and (coating = 2 or coating = 3)"
                    Else
                        sqlCoat = " and coating = 2"
                    End If
                Else
                    If chkPostCoat.Checked Then
                        sqlCoat = " and coating = 3"
                    Else
                        chkPreCoat.Checked = True
                        chkPostCoat.Checked = True
                        chk15MinsCheck.Checked = True
                        sqlCoat = ""
                    End If
                End If
            End If

            'sql = "select stntkey, stntserial as 'Stent Serial', CONVERT(numeric(18,4),finalwt) as Weight, coating as coat, Coating = case coating when 1 then 'Pre Coating' when 2 then '15 Mins Check' when 3 then 'Post Coating' end, machine as Machine, weightedby as 'Operator', convert(varchar(12), weightedon, 106) as 'Weighed On', cast(0 as bit) as 'Delete' from stentfinalweights where stntserial like '%" & txtStentSerialNo.Text.ToString().Trim & "%'"
            'sql = sql & sqlCoat
            'sql = sql & " order by stntserial, coat"

            sql = "select w.stntkey, s.stwono as 'WO No', w.stntserial as 'Stent Serial', CONVERT(numeric(18,4),finalwt) as Weight, coating as coat, Coating = case coating when 1 then 'Pre Coating' when 2 then '15 Mins Check' when 3 then 'Post Coating' end, machine as Machine, weightedby as 'Operator', convert(varchar(12), weightedon, 106) as 'Weighed On', cast(0 as bit) as 'Delete' from stentfinalweights w left join stentserials s on s.stntserial = w.stntserial where (s.stwono like '%" & txtStentSerialNo.Text.ToString().Trim & "%' or w.stntserial like '%" & txtStentSerialNo.Text.ToString().Trim & "%')"
            sql = sql & sqlCoat
            sql = sql & " order by w.stntserial, coat"
            ds = db.selectQuery(sql)

            ds.Tables(0).Columns("stntkey").ColumnMapping = MappingType.Hidden
            ds.Tables(0).Columns("coat").ColumnMapping = MappingType.Hidden
            dt = ds.Tables(0)
            dgStentWeights.DataSource = dt

            FormatGrid()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        Dim i As Integer
        If dt.Rows.Count > 0 Then
            dgStentWeights.ReadOnly = False

            For i = 0 To dgStentWeights.Columns.Count - 1
                dgStentWeights.Columns(i).ReadOnly = True
                dgStentWeights.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                dgStentWeights.Columns(i).Width = 104
            Next

            dgStentWeights.Columns("Delete").ReadOnly = False
            dgStentWeights.Columns("Delete").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgStentWeights.Rows(dt.Rows.Count).ReadOnly = True

        Else
            dgStentWeights.ReadOnly = True
            dgStentWeights.Columns("Delete").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim Ans, Ans2 As Integer
        Dim i As Integer
        Dim deleteFlag, deleteFlag2 As Boolean
        deleteFlag = False
        deleteFlag2 = False
        Dim strCoating As String

        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("Delete") = True Then
                deleteFlag = True
            End If
        Next

        If deleteFlag = True Then
            Ans = MsgBox("Are you sure want to delete all Pre Coating, 15 Mins Check and Post Coating weights of these serial numbers?", vbYesNo + vbExclamation)

            If Ans = vbYes Then
                For i = 0 To dt.Rows.Count - 1
                    If dt.Rows(i).Item("Delete") = True Then
                        strSerialNo = dt.Rows(i).Item("Stent Serial")
                        Sql = "delete from stentfinalweights where stntserial ='" & strSerialNo & "'"
                        db.deleteQuery(Sql)
                        deleteFlag2 = True
                    End If
                Next

            ElseIf Ans = vbNo Then
                Ans2 = MsgBox("Are you sure want to delete selected weights only?", vbYesNo + vbExclamation)

                If Ans2 = vbYes Then
                    For i = 0 To dt.Rows.Count - 1
                        If dt.Rows(i).Item("Delete") = True Then
                            StentKey = dt.Rows(i).Item("stntkey")
                            strSerialNo = dt.Rows(i).Item("Stent Serial")
                            strCoating = dt.Rows(i).Item("Coating")
                            iCoating = GetCoatValue(strCoating)

                            If iCoating = 3 Then
                                deleteFlag2 = True
                                DeleteWeight(StentKey)
                            ElseIf iCoating = 2 Then
                                Sql = "select coating from stentfinalweights where stntserial='" & strSerialNo & "' and coating = 3"
                                ds = db.selectQuery(Sql)
                                If ds.Tables(0).Rows.Count > 0 Then
                                    MsgBox("Weight cannot be deleted without deleting Post coating weight for serial number " & strSerialNo)
                                Else
                                    deleteFlag2 = True
                                    DeleteWeight(StentKey)
                                End If

                            ElseIf iCoating = 1 Then
                                Sql = "select coating from stentfinalweights where stntserial='" & strSerialNo & "' and coating in (2,3)"
                                ds = db.selectQuery(Sql)
                                If ds.Tables(0).Rows.Count > 0 Then
                                    MsgBox("Weight cannot be deleted without deleting Post coating or 15 Mins check weight for serial number " & strSerialNo)
                                Else
                                    deleteFlag2 = True
                                    DeleteWeight(StentKey)
                                End If
                            End If
                        End If
                    Next
                End If
            End If

            If deleteFlag2 Then
                'MsgBox("Weights deleted")
            Else
                'MsgBox("Weights not deleted")
            End If

        Else
            MsgBox("No record selected")
        End If

        FillGrid()

    End Sub

    Private Sub DeleteWeight(ByVal stentkey As Integer)
        Sql = "delete from stentfinalweights where stntkey=" & stentkey & ""
        db.deleteQuery(Sql)
    End Sub

    Private Sub txtStentSerialNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStentSerialNo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            FillGrid()
        End If
    End Sub

    Function GetCoatValue(ByVal strCoat As String)
        If strCoat = "Pre Coating" Then
            Return 1
        ElseIf strCoat = "15 Mins Check" Then
            Return 2
        ElseIf strCoat = "Post Coating" Then
            Return 3
        End If
    End Function

    Private Sub dgStentWeights_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgStentWeights.MouseUp
        Dim hti As DataGridView.HitTestInfo = Me.dgStentWeights.HitTest(e.X, e.Y)
        Try
            If hti.RowIndex < dt.Rows.Count Then
                If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.ColumnIndex = 6 Then
                    If dt.Rows(hti.RowIndex).Item("Delete") = False Then
                        dt.Rows(hti.RowIndex).Item("Delete") = True
                    Else
                        dt.Rows(hti.RowIndex).Item("Delete") = False
                    End If
                End If
            End If
        Catch ex As System.Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class