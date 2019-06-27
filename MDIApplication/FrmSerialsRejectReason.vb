Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmSerialRejectReason

    Private Sub FrmSerialsRejectReason_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim ds As New DataSet
            Sql = "select rejcd,dsca from reasons where rtype = 'R04'"   ' Inspection Reason Types only
            ds = db.selectQuery(Sql)

            With lboxReasons
                .DisplayMember = "dsca"
                .ValueMember = "rejcd"
                .DataSource = ds.Tables(0)
            End With
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReject.Click

        Dim Ans As Integer
        Ans = MsgBox("Are you sure want to reject this serial number?", vbYesNo + vbExclamation, "Reject Serial Numbers")

        If Ans = vbYes Then

            'Reject Stent Status
            If lblRejectionType.Text = "Status" Then
                Sql = "update StentSerials set status=0,rejcd='" & lboxReasons.SelectedValue & "' where stntserial = '" & txtStentSerial.Text & "'"
                If db.updateQuery(Sql) Then
                    Me.Close()
                Else
                    MsgBox("Stent serial not rejected")
                End If
                FrmViewSerials.FillGrid()

                'Reject Inspection Status
            ElseIf lblRejectionType.Text = "InspectionStatus" Then
                Sql = "update StentSerials set inspnstatus=0,inspncode='" & lboxReasons.SelectedValue & "' where stntserial = '" & txtStentSerial.Text & "'"
                If db.updateQuery(Sql) Then
                    Me.Close()
                Else
                    MsgBox("Stent serial not rejected")
                End If
                FrmViewInspectionSerials.FillGrid()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class