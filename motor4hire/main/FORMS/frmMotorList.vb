Public Class frmMotorList
    Dim motorID, memberID As Integer
    Private Sub frmMotorList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call loadrecord()
    End Sub

    Sub loadrecord()
        Dim sql As String
        sql = "select mo.idmotor,concat(m.fname, ' ', m.mname, ' ', m.lname)as name,mo.name," & _
        "mo.description,mo.plateno,mo.or_num,mo.cr_num,mo.chasisno,dateofexpiration, m.idmember" & _
        " from member m inner join motor mo on m.idmember=mo.idmember"
        Call modFunctions.PopulateListView(ListView1, sql)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        EDITMODE = False
        frmMotorEntry.ShowDialog()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If ListView1.SelectedItems.Count > 0 Then
            act_motorID = Convert.ToInt32(ListView1.SelectedItems(0).Text).ToString
            act_memberID = Convert.ToInt32(ListView1.SelectedItems.Item(0).SubItems(9).Text.ToString)
            EDITMODE = True
            frmMotorEntry.ShowDialog()
        Else
            MsgBox("Error")
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim mid As Integer

            mid = Convert.ToInt32(ListView1.SelectedItems(0).Text)
            Call modFunctions.DELETE_RECORD("motor", mid, "idmotor")
            MsgBox("Record has been successfully deleted.")
            loadrecord()
        Else
            MsgBox("Please select a record to delete")
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        loadrecord()
    End Sub
End Class
