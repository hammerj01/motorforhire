Public Class frmManageActivity

    Private Sub frmManageActivity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = "select idactivities, actname, description, startdate, organized_by from activities"
        Call modFunctions.PopulateListView(ListView1, sql)
    End Sub
End Class