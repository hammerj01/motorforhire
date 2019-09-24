Public Class frmUserAccount

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim p As New cUserAccount
        Dim usr, pwd, utype As String

        usr = txtusername.Text.ToString
        pwd = txtpassword.Text.ToString
        utype = cbouser.Text.ToString

        If usr.Length < 6 Or pwd.Length < 6 Then
            MsgBox("username and/or password must have atleast 5 characters in length")
            Exit Sub
        ElseIf (modFunctions.IsEmpty(usr) = True Or modFunctions.IsEmpty(pwd) = True Or modFunctions.IsEmpty(utype) = True) Then
            MsgBox("username and/or password and/or user type is/are empty. ")
            Exit Sub
        End If

        If EDITMODE = True Then
            p.propusername = usr
            p.proppassword = pwd
            p.propusertype = utype
            p.UPDATE_USER()
        Else
            p.propusername = usr
            p.proppassword = pwd
            p.propusertype = utype
            p.INSERT_USER()
            MsgBox(msgInsert, MsgBoxStyle.Information, msgSystemInfo)

        End If
        modFunctions.ClearTextbox(Me)
        Viewaccount()
        Call modFunctions.DisabledButton(Me)
        btnAdd.Enabled = True
    End Sub

    Private Sub frmUserAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Viewaccount()
        Call modFunctions.ClearTextbox(Me)
        Call modFunctions.DisabledButton(Me)
        btnAdd.Enabled = True
    End Sub

    Sub Viewaccount()
        Dim sql As String = "select * from useraccount"
        Call modFunctions.PopulateListView(ListView1, sql)

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtusername.Focus()
        Call modFunctions.ClearTextbox(Me)
        EDITMODE = False
        btnAdd.Enabled = False
        btnSave.Enabled = True
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        EDITMODE = True
        btnSave.Enabled = True
        btnEdit.Enabled = False
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        btnDelete.Enabled = False
        btnAdd.Enabled = True
    End Sub
End Class