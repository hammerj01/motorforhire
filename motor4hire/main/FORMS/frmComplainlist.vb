Public Class frmComplainlist

    Private Sub frmComplainlist_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call loadlist()
    End Sub

    Private Sub frmComplainlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call loadlist()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        EDITMODE = False
        frmcomplaints.ShowDialog()
    End Sub

    Public Sub loadlist()
        Dim sql As String

        sql = "SELECT `c`.`idcomplaints`,`c`.`complinants`,`c`.`description`,`c`.datecomplaint,m.plateno,m.description,concat(me.fname, ' ', me.mname, ' ', me.lname ) as name " & _
              " FROM `motor4hire`.`complaints` as c inner join motor as m on c.idmotor = m.idmotor" & _
              " inner join member me on m.idmember = me.idmember"
        modFunctions.PopulateListView(ListView1, sql)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If ListView1.SelectedItems.Count > 0 Then
            act_complaintID = Convert.ToInt32(ListView1.SelectedItems(0).Text).ToString
            EDITMODE = True
            frmcomplaints.Show()
        Else
            MsgBox("Please select a record.")
            Exit Sub
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If ListView1.SelectedItems.Count > 0 Then
            act_complaintID = Convert.ToInt32(ListView1.SelectedItems(0).Text).ToString
            Call modFunctions.DELETE_RECORD("complaints", act_complaintID, "idcomplaints")
            Call loadlist()
        Else
            MsgBox("Please select a record.")
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call loadlist()
    End Sub
End Class