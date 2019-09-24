Public Class frmOfficerQuery
    Dim y, n As String
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim sql As String
        y = dtyear.Value.Year
        sql = "select * from officers where  year(endterm) = '" & y & "' and status = '" & n & "'"
        modFunctions.PopulateListView(ListView1, sql)
    End Sub

    Private Sub chkyear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkyear.CheckedChanged
        Dim sql As String
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        sql = "select * from officers where status = 'active'"
        modFunctions.PopulateListView(ListView1, sql)
    End Sub
End Class