Public Class frmcomplaints
    Dim ID As Integer
    Dim memID As Integer
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim c As New cComplaints
        If (modFunctions.IsEmpty(txtplateno.Text)) Then
            MsgBox("plate no. cannot be empty")
            Exit Sub

        ElseIf (modFunctions.IsEmpty(txtComplaints.Text)) Then
            MsgBox("complaints cannot be empty")
            Exit Sub
        ElseIf txtComplaints.TextLength < 5 Or txtcomplaintname.TextLength < 5 Then
            MsgBox("Complaints and or complaint name must have atleast 5 characters. ")
            Exit Sub
        End If

        If EDITMODE = True Then
            c.loadcomplaints(act_complaintID)
            c.propidcomplaints = c.propidcomplaints
            c.propidmotor = c.propidmotor   'ListView1.SelectedItems(0).Text
            c.propcomplinants = txtcomplaintname.Text
            c.propmemberID = c.propmemberID   'Convert.ToInt32(ListView1.SelectedItems(0).SubItems(1).Text).ToString
            c.propdescription = txtComplaints.Text
            c.propdatecomplaint = dtcomplaint.Text
            c.UPDATE_COMPLAINT()
            MsgBox(msgUpdate, MsgBoxStyle.Information, msgSystemInfo)
        Else

            c.propidmotor = ID   'ListView1.SelectedItems(0).Text
            c.propcomplinants = txtcomplaintname.Text
            c.propmemberID = memID  'Convert.ToInt32(ListView1.SelectedItems(0).SubItems(1).Text).ToString
            c.propdescription = txtComplaints.Text
            c.propdatecomplaint = dtcomplaint.Text
            c.INSERT_COMPLAINTS()
            MsgBox(msgInsert, MsgBoxStyle.Information, msgSystemInfo)
        End If
        'Dim sql As String
        'sql = "SELECT `c`.`idcomplaints`,`c`.`complinants`,`c`.`description`,`c`.datecomplaint,m.plateno,m.description,concat(me.fname, ' ', me.mname, ' ', me.lname ) as name " & _
        '     " FROM `motor4hire`.`complaints` as c inner join motor as m on c.idmotor = m.idmotor" & _
        '     " inner join member me on m.idmember = me.idmember"
        'Call PopulateListView(frmComplainlist.ListView1, sql)
        Call frmComplainlist.loadlist()
        Call modFunctions.ClearTextbox(Me)
        frmComplainlist.Close()
        Dim f As frmComplainlist = New frmComplainlist
        'AddHandler f.Load, AddressOf f.loadlist
        'f.Show()
        f.Owner = Me
        f.Show()
        Me.Close()
    End Sub

    Private Sub frmcomplaints_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If EDITMODE = True Then
            Dim mo As New cMotor
            Dim mem As New cMembers
            Dim co As New cComplaints

            co.loadcomplaints(act_complaintID)
            mo.Listof_motorbyplate(co.propidmotor)

            txtplateno.Text = mo.propplateno
            txtmodel.Text = mo.propname
            txtdescription.Text = mo.propdescription
            txtexpiration.Text = mo.propdateofexpiration

            mem.lsvMemberByID(co.propmemberID)
            txtComplaints.Text = co.propdescription
            txtcomplaintname.Text = co.propcomplinants
            txtowner.Text = mem.propfname & " " & mem.propmname & " " & mem.proplname
            txtaddress.Text = mem.propaddress

        End If

        ListView1.Hide()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Dim member As New cMembers
        Dim mo As New cMotor
        If ListView1.SelectedItems.Count > 0 Then
            ID = Convert.ToInt32(ListView1.SelectedItems(0).Text).ToString
            memID = ListView1.SelectedItems(0).SubItems(1).Text
            mo.Listof_motor(ID)
            txtplateno.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtmodel.Text = mo.propname
            txtdescription.Text = mo.propdescription
            txtexpiration.Text = mo.propdateofexpiration

            member.lsvMemberByID(memID)
            txtowner.Text = member.propfname & " " & member.propmname & " " & member.proplname
            txtaddress.Text = member.propaddress

            ListView1.Hide()
        Else
            MsgBox("Please select a record.")
            Exit Sub
        End If
    End Sub

    Private Sub txtplateno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtplateno.TextChanged
        If txtplateno.TextLength > 0 Then
            ListView1.BringToFront()

            Call modFunctions.PopulateListView(ListView1, "select mo.idmotor,m.idmember, mo.plateno " & _
                                               " from member m right join motor mo on m.idmember = mo.idmember where " & _
                                               " mo.plateno like '%" & txtplateno.Text.ToString & "%'  and mo.status = 'active'")
            ListView1.Show()
        Else
            ListView1.Hide()
        End If

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class