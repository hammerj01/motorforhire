Public Class frmPayments

  
    Private Sub txtmember_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmember.TextChanged
        ListView1.Show()
        Call modFunctions.PopulateListView(ListView1, "select `idmember`, concat(`fname`,' ', `mname`, ' ', `lname` ) " & _
                                                " as name from member where fname like '%" & txtmember.Text.ToString & "%'")
    End Sub

    Private Sub frmPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.Hide()
        txtamount.Text = Format(1500, "#,###.00").ToString
    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged

    End Sub

    Private Sub txtamounttender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamounttender.TextChanged
        'if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        '   {
        '       e.Handled = true;
        '   }

        '   // only allow one decimal point
        '   if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        '   {
        '       e.Handled = true;
        '   }
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Dim member As New cMembers
        Dim ID As Integer
        ID = Convert.ToInt32(ListView1.SelectedItems(0).Text).ToString
        member.lsvMemberByID(ID)
        txtmemberID.Text = member.propmemberID.ToString
        txtmember.Text = member.propfname & " " & member.propmname & " " & member.proplname
        ListView1.Hide()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim payment As New cPayments
        Dim member As New cMembers
        member.lsvMemberByID(txtmemberID.Text)

        If (member.CheckStatus(member.propmemberID) = True) Then
            MsgBox("Member is already active", MsgBoxStyle.Information, msgSystemInfo)
            Exit Sub
        End If
        payment.propmemberID = member.propmemberID
        payment.proplname = member.proplname
        payment.propfname = member.propfname
        payment.propmname = member.propmname
        payment.propAmount = txtamounttender.Text
        payment.INSERT_PAYMENTS()
        MsgBox(msgInsert, MsgBoxStyle.Information)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class