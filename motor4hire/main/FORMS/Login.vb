Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim u As New cUserAccount
        Dim usr, pwd As String

        usr = UsernameTextBox.Text
        pwd = PasswordTextBox.Text
        Try
            If (modFunctions.IsEmpty(usr) = True And modFunctions.IsEmpty(pwd)) Then
                MsgBox("Username/Password is empty.")
                Exit Sub
            End If

            If u.chkuser(usr, pwd) = True Then
                MsgBox("Access Grandted.", MsgBoxStyle.Information, msgSystemInfo)
                mysystem.Show()
            Else
                MsgBox("Username/Password is invalid.")
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Hide()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class
