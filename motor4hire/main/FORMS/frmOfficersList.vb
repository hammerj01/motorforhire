Public Class frmOfficersList
    Dim s, n, sql As String
    Dim y As String

    Private Sub frmOfficersList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String

        sql = "select * from officers where status = 'active'"
        modFunctions.PopulateListView(ListView1, sql)

        txtname.Enabled = False
        'dtyear.Enabled = False

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If ListView1.SelectedItems.Count > 0 Then
                EDITMODE = True
                act_officerID = Convert.ToInt32(ListView1.SelectedItems(0).Text)
                frmOfficers.ShowDialog()
            Else
                MsgBox("Please select a record to edit")
                Exit Sub
            End If
        Catch x As Exception
            MsgBox("Error: no record selected.")
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        y = dtyear.Value.Year
        sql = "select * from officers where  year(endterm) = '" & y & "' and status = '" & n & "'"
        modFunctions.PopulateListView(ListView1, sql)

    End Sub

    Private Sub chkname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkname.CheckedChanged
        'If chkname.Checked = True Then
        '    txtname.Enabled = True
        '    n = txtname.Text

        'Else
        '    txtname.Enabled = False
        '    n = ""

        'End If
    End Sub

    Private Sub chkyear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkyear.CheckedChanged
        If chkyear.Checked = True Then
            sql = "select * from officers where status = 'active'"
            modFunctions.PopulateListView(ListView1, sql)
            n = "Active"
        Else
            sql = "select * from officers where status = 'inactive'"
            modFunctions.PopulateListView(ListView1, sql)
            n = "Inactive"
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        EDITMODE = False
        frmOfficers.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sql = "select * from officers where status = 'active'"
        modFunctions.PopulateListView(ListView1, sql)
    End Sub
End Class