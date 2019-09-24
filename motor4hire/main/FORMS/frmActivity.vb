Public Class frmActivity
    Public AID As Integer
    Dim act As New cActivities
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim activityname, description, organizedby As String
        Dim startdate, enddate As Date

        activityname = txtactivityname.Text
        description = txtdescription.Text
        startdate = DateAndTime.Now.ToString("yyyy-MM-dd")
        enddate = DateAndTime.Now.ToString("yyyy-MM-dd")
        organizedby = txtorganizedby.Text

        If (modFunctions.IsEmpty(activityname)) Then
            MsgBox("Cannot be empty")
            Exit Sub
            'ElseIf (startdate > enddate) Then
            '    MsgBox("Start date must be lesser than or equal to end date. ")
            '    Exit Sub
        ElseIf activityname.Length < 5 Or description.Length < 5 Or organizedby.Length <= 3 Then
            MsgBox("activity name and/or description and/or organized by must have atleast 5 characters in length. ")
            Exit Sub
        End If

        If EDITMODE = True Then

            With act
                .propactivityname = activityname
                .propdescription = description
                .propstartdate = startdate
                .propenddate = enddate
                .proporganizedby = organizedby
                .UPDATE_ACTIVITY()
                MsgBox(msgUpdate, MsgBoxStyle.Information, msgSystemInfo)
            End With
        Else
            With act
                .propactivityname = activityname
                .propdescription = description
                .propstartdate = startdate
                .propenddate = enddate
                .proporganizedby = organizedby
                .INSERT_ACTIVITY()
                MsgBox(msgInsert, MsgBoxStyle.Information, msgSystemInfo)
            End With

        End If
        Dim sql As String = "select idactivities, actname, description, startdate,enddate, organized_by from activities"
        Call modFunctions.ClearTextbox(Me)
        'Call modFunctions.PopulateListView(frmActivityList.ListView1, sql)
        'frmActivityList.loadlist()
        'frmActivityList.Refresh()


        Me.Close()

    End Sub

    Private Sub frmActivity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If EDITMODE = True Then
            act.loadFields(AID)
            txtactivityname.Text = act.propactivityname
            txtdescription.Text = act.propdescription
            txtorganizedby.Text = act.proporganizedby
            dtenddate.Text = act.propenddate
            dtstartdate.Text = act.propstartdate
        End If
        ListView1.Hide()
    End Sub

    Private Sub txtorganizedby_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtorganizedby.TextChanged
        'If txtorganizedby.TextLength > 0 Then
        '    Dim sql As String
        '    Dim yr As Integer
        '    ListView1.BringToFront()
        '    ListView1.Show()
        '    yr = DateTime.Now.ToString("yyyy")
        '    sql = "SELECT president,vice,secretary,tresurer,auditor from officers where year(dateelected) = '" & yr.ToString & "' and status = 'active' "
        '    'sql = "SELECT president,vice,secretary,tresurer,auditor from officers where year(dateelected) = '" & yr.ToString & "'" ' and status = 'active' "
        '    Call modFunctions.PopulateListViewRecords(ListView1, sql)
        'Else

        '        ListView1.Hide()
        'End If
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        Dim yr As Integer
        ListView1.BringToFront()
        ListView1.Show()
        yr = DateTime.Now.ToString("yyyy")
        sql = "SELECT president,vice,secretary,tresurer,auditor from officers where year(dateelected) = '" & yr.ToString & "' and status = 'active' "
        'sql = "SELECT president,vice,secretary,tresurer,auditor from officers where year(dateelected) = '" & yr.ToString & "'" ' and status = 'active' "
        Call modFunctions.PopulateListViewRecords(ListView1, sql)
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If (ListView1.SelectedItems.Count > 0) Then

            txtorganizedby.Text = ListView1.SelectedItems.Item(0).Text
            ListView1.Hide()
        Else
            MsgBox("Please select a record")
            Exit Sub
        End If

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class