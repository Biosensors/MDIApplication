
Public Class FrmAmpcViewData
    Inherits System.Windows.Forms.Form

    Public sStentID As String
    Public sBatchNo As String

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        'To check for valid stent serial no for the batchno
        Sql = "select stntserial from stentserials where stbatch = '" & sBatchNo & "' and stntserial = '" & Trim(txtStentSerialNo.Text) & "'"
        ds = db.selectQuery(Sql)
        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("Invalid Stent Serial No")
            txtStentSerialNo.Focus()
        Else
            'To check stent serial already exists
            Sql = "select stentid from ampcdata where stentid = '" & Trim(txtStentSerialNo.Text) & "'"
            ds = db.selectQuery(Sql)
            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("Stent ID already exists")
                txtStentSerialNo.Focus()
            Else
                'Update serial no
                Sql = "update AmpcData set stentid = '" & Trim(txtStentSerialNo.Text) & "', modifieddate = getdate(), modifiedby = '" & sLogonUser & "' where stentId = '" & sStentID & "'"
                db.updateQuery(Sql)
                Me.Close()

                'FrmAmpcDataReview.FillGrid()
            End If
        End If

    End Sub
End Class