Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmgenerate
    Dim pid As Integer
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sticker As String
        sticker = modFunctions.generatepassword(4) & Format(Now, "yy") & modFunctions.generatepassword(4)
        txtStickerNo.Text = sticker
    End Sub

    Private Sub frmgenerate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.Hide()
    End Sub

    Private Sub txtmember_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmember.TextChanged
        Call modFunctions.PopulateListView(ListView1, "select `idmember`, concat(`fname`,' ', `mname`, ' ', `lname` ) " & _
                                               " as name from member where `status` = 'active' and fname like '%" & txtmember.Text.ToString & "%'")
        ListView1.BringToFront()
        ListView1.Show()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Dim m As New cMotor

        pid = Convert.ToInt32(ListView1.SelectedItems(0).Text).ToString
        txtmember.Text = ListView1.SelectedItems(0).SubItems(1).Text
        m.Listof_motor(pid)
        txtmotor.Text = m.propname & " - " & m.propplateno

        ListView1.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m As New cMembers
        ' Dim param As ParameterFieldDefinitions

        If m.chkSticker(pid, txtStickerNo.Text) = True Then
            MsgBox(msgErr)
            Exit Sub
        End If
        m.propmemberID = pid
        m.propgenSticker = txtStickerNo.Text
        m.INSER_STICKER()
        MsgBox(msgInsert, MsgBoxStyle.Information, msgSystemInfo)
        Call modFunctions.ClearTextbox(Me)

    End Sub
End Class