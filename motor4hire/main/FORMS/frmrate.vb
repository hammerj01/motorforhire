Public Class frmrate
    Dim a As New cPayments
    Private Sub frmrate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a.loadRate()
        txtamount.Text = FormatNumber(a.propAmount, 2, , , TriState.True).ToString

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If modFunctions.IsEmpty(txtamount.Text) = True Then
            MsgBox("Please supply the correct format")
            Exit Sub
        End If

        a.propAmount = txtamount.Text
        a.update_rate()
        MsgBox(msgInsert)

    End Sub

    Private Sub txtamount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamount.KeyPress
        If (Not (Char.IsControl(e.KeyChar)) And Not (Char.IsDigit(e.KeyChar)) And (e.KeyChar <> ".")) Then
            e.Handled = True
        End If
        If (txtamount.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True

    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged
        txtamount.Text = FormatNumber(txtamount.Text, 2, , , TriState.True).ToString
    End Sub
End Class