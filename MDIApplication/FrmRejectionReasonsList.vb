
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmRejectionReasonsList

    Dim dsCodes As New DataSet
    Dim ColorChange As Boolean = False

    Private Sub FrmRejectionReasonsList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Controls.Clear()
    End Sub

    Private Sub FrmRejectionReasonsList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim i As Integer

            Sql = "select rejcd,dsca from reasons where rtype = 'R04' order by dsca"
            dsCodes = db.selectQuery(Sql)

            For i = 0 To 3
                AddButton(i, i, 15)
            Next i

            ColorChange = True
            For i = 4 To 7
                AddButton(i, i - 4, 90)
            Next i

            ColorChange = False
            For i = 8 To 11
                AddButton(i, i - 8, 165)
            Next i

            ColorChange = True
            For i = 12 To 15
                AddButton(i, i - 12, 240)
            Next i

            ColorChange = False
            For i = 16 To 19
                AddButton(i, i - 16, 315)
            Next i

        Catch ex As System.Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddButton(ByVal i As Integer, ByVal No As Integer, ByVal btnYPosition As Integer)
        Dim btn As New Button()

        btn.Name = dsCodes.Tables(0).Rows(i).Item("rejcd")
        btn.Text = dsCodes.Tables(0).Rows(i).Item("dsca")
        btn.Location = New Point((No * 165) + 15, btnYPosition)
        btn.Size = New Size(150, 60)
        btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13, FontStyle.Bold)

        If ColorChange = False Then
            btn.BackColor = Color.LightPink
            ColorChange = True
        Else
            btn.BackColor = Color.LightSkyBlue
            ColorChange = False
        End If

        Me.Controls.Add(btn)
        AddHandler btn.Click, AddressOf Me.ClickButton

    End Sub

    Private Sub ClickButton(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As Button
        btn = CType(sender, Button)

        Sql = "update stentserials set inspnstatus = 0, inspncode = '" & btn.Name.ToString() & "', inspndate = getdate(), inspnby = '" & sLogonUser & "' where stntserial ='" & Trim(lblSerialNo.Text) & "'"
        db.updateQuery(Sql)

        dsCodes.Clear()
        Me.Close()
    End Sub

End Class