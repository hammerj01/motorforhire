Public Class frmMemberRecords
    Dim m As New cMembers
    Private Sub frmMemberRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call query()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        EDITMODE = False
        frmMembersEntry.ShowDialog()
    End Sub

    Public Sub query()
        Dim sql As String = "select m.idmember, concat(m.fname, ' ', m.mname, ' ' , m.lname) as name, m.address, m.barangay," & _
              " m.gender, m.bday,m.age,  m.licenseno, m.expirydate, concat(m.requirements1, ', ',   m.requirements2) as requirements,  " & _
              " m.datereg,r.name, r.plateNo , r.description,r.date_register," & _
              " r.or_num, r.cr_num, r.dateofexpiration " & _
              "from member m inner join motor r on m.idmember = r.idmember group by m.idmember"
        Call modFunctions.PopulateListView(ListView1, sql)
    End Sub

    Private Sub btnedit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Dim pid As Integer

        If ListView1.SelectedItems.Count > 0 Then
            pid = Convert.ToInt32(ListView1.SelectedItems(0).Text)
            EDITMODE = True
            m.lsvMemberByID(pid)
            frmMembersEntry.commonID = m.propmemberID
            frmMembersEntry.ShowDialog()
        Else
            MsgBox("Please select a recor")
        End If


    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete a record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim pid As Integer
            If ListView1.SelectedItems.Count > 0 Then
                pid = Convert.ToInt32(ListView1.SelectedItems(0).Text)
                'm.lsvMemberByID(pid)
                Call modFunctions.DELETE_RECORD("member", pid, "idmember")
                Call modFunctions.DELETE_RECORD("motor", pid, "idmotor")
                MsgBox("Record has been successfully deleted.")
                Call query()
            Else
                MsgBox("Please select a recor")
            End If

        End If
    End Sub
End Class