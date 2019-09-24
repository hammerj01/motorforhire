Imports MySql.Data.MySqlClient
Public Class frmMembersEntry
    Dim members As New cMembers
    Dim motor As New cMotor
    Dim a As New cPayments
    Public commonID As Integer
    Dim lname, fname, mname, req, req1 As String
    Dim license, orno, crno As String
    Dim address, barangay, gender As String
    Dim motorname, description, plateno, img As String
    Dim age As Integer
    Dim birthday, license_expiry, motor_expiry As Date

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim getlastID As New MySqlCommand
        Dim payment As New cPayments
        'Dim id As Integer

        Dim arr(1), arr1(1) As String
        Dim mystatus As String = "Inactive"
        Call Setmember()
        If chkrequirements.CheckedItems.Count < 2 Then
            Dim i As Integer
            For i = 0 To chkrequirements.CheckedItems.Count - 1
                MsgBox(chkrequirements.CheckedItems(i))
            Next
            MsgBox("Please comply all the requirements.", MsgBoxStyle.Information, msgSystemInfo)
            If MsgBox("Are you sure you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For i = 0 To chkrequirements.CheckedItems.Count - 1
                    'MsgBox(chkrequirements.CheckedItems(i))
                    arr(i) = chkrequirements.CheckedItems(i)
                Next
                If "barangay clearance" = arr(0).ToString Then
                    req = arr(0).ToString
                Else
                    req1 = arr(0).ToString
                End If
                mystatus = mystatus

            Else
                Exit Sub
            End If
        Else
            Dim i As Integer
            For i = 0 To chkrequirements.CheckedItems.Count - 1
                'MsgBox(chkrequirements.CheckedItems(i))
                arr(i) = chkrequirements.CheckedItems(i)
            Next
            req = arr(0).ToString
            req1 = arr(1).ToString

            mystatus = "Active"
        End If
        If modFunctions.IsEmpty(fname) = True Then
            MsgBox("firstname cannot be empty", MsgBoxStyle.Information, msgSystemInfo)
            Exit Sub
        ElseIf modFunctions.IsEmpty(lname) = True Then
            MsgBox("lasname cannot be empty", MsgBoxStyle.Information, msgSystemInfo)
            Exit Sub
        ElseIf age < 18 Then
            MsgBox("Age is not allowed.", MsgBoxStyle.Information, msgSystemInfo)
            Exit Sub
        ElseIf modFunctions.IsEmpty(birthday) = True Then
            MsgBox("birthday cannot be empty", MsgBoxStyle.Information, msgSystemInfo)
            Exit Sub
        ElseIf modFunctions.IsEmpty(license) = True Then
            MsgBox("license cannot be empty", MsgBoxStyle.Information, msgSystemInfo)
            Exit Sub
            'ElseIf modFunctions.IsEmpty(motorname) = True Then
            '   MsgBox("motor name cannot be empty", MsgBoxStyle.Information, msgSystemInfo)
            '  Exit Sub
        ElseIf fname.Length < 3 Or lname.Length < 3 Then
            MsgBox("first or last name must have atleast  characters.", MsgBoxStyle.Information, msgSystemInfo)
            Exit Sub
        ElseIf barangay.Length < 8 Then
            MsgBox("barangay must have atleast 8 characters. ", MsgBoxStyle.Information, msgSystemInfo)
            Exit Sub
            'ElseIf orno.Length < 6 Or crno.Length < 6 Or plateno.Length < 6 Then
            '   MsgBox("OR no. , CR no and or plate no. must have atleast 5 characters.", MsgBoxStyle.Information, msgSystemInfo)
            '  Exit Sub
        End If

        'If EDITMODE = False Then
        'If (Convert.ToDouble(txtamounttender.Text.ToString) < Convert.ToDouble(txtamount.Text.ToString)) Then
        '    MsgBox("Invalid amount.", MsgBoxStyle.Information, msgSystemInfo)
        '    Exit Sub
        'End If
        'End If

        'If motor.Motorisexist(LCase(plateno)) = True Then
        '    MsgBox("Plate no. is already exist", MsgBoxStyle.Information, msgSystemInfo)
        '    Exit Sub

        'End If

        If EDITMODE = True Then
            'txtamount.ReadOnly = True
            'txtamounttender.ReadOnly = True
            'Call Setmember()
            members.propstatus = mystatus
            members.propreq1 = req
            members.propreq2 = req1
            members.propmemberID = commonID
            members.propImg = lblpicture.Text
            members.propaddress = "Balilihan"
            members.Update_members()
            MsgBox(msgUpdate, MsgBoxStyle.Information, msgSystemInfo)
            Call frmMemberRecords.query()
            Me.Hide()
        Else
            'Call Setmember()
            If modFunctions.chkLicenseORCR(license.ToString) = True Then
                MsgBox("License No. is already exist.")
                Exit Sub
            End If

            members.propstatus = mystatus
            members.propreq1 = req
            members.propreq2 = req1
            members.propdatereg = Now()
            members.propImg = lblpicture.Text
            members.propaddress = "Balilihan"
            members.Insert_members()
            'id = GLOBAL_VARIABLES.d.GetLastID()
            'members.lsvMemberByID(id)
            If members.IsmemberExist(fname.ToString, lname.ToString) = True Then
                MsgBox("Member is already exist.")
                Exit Sub
            End If
            MsgBox(msgInsert, MsgBoxStyle.Information, msgSystemInfo)
        End If
        Call modFunctions.ClearTextbox(Me)
        txtage.Text = DateDiff(DateInterval.Year, dtbirthday.Value, Now)
        a.loadRate()
        'txtamount.Text = a.propAmount
    End Sub

    Sub Getmember()
        lname = txtlnames.Text
        fname = txtfname.Text
        mname = txtmi.Text
        address = txtaddress.Text
        barangay = txtbarangay.Text
        birthday = dtbirthday.Text
        age = txtage.Text.ToString
        license = txtlicense.Text
        license_expiry = dtexpiry.Text
        gender = cbogender.Text

        'motorname = txtmotor.Text
        'description = txtdescription.Text
        'orno = txtorno.Text
        'crno = txtcrno.Text
        'plateno = txtplateno.Text
        'motor_expiry = dtmotorexpiry.Text

    End Sub

    Sub Setmember()
        Call Getmember()
        With members
            '.propmemberID = 
            .proplname = lname
            .propfname = fname
            .propmname = mname
            .propage = age
            .propbirthday = birthday
            .proplicenseno = license
            .propgender = gender
            .propaddress = address
            .propbarangay = barangay
            .propexpirydate = license_expiry

        End With
    End Sub

    Sub query()
        Dim sql As String = "select m.idmember, concat(m.fname, ' ', m.mname, ' ' , m.lname) as name, m.barangay," & _
             " m.gender, m.bday,m.age,  m.licenseno, m.expirydate, concat(m.requirements1, ', ',   m.requirements2) as requirements,  " & _
             " m.datereg,r.name, r.plateNo , r.description,r.date_register," & _
             " r.or_num, r.cr_num, r.dateofexpiration " & _
             "from member m inner join motor r on m.idmember = r.idmember"
    End Sub


    Private Sub frmMembersEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call modFunctions.ClearTextbox(Me)
        txtage.Text = DateDiff(DateInterval.Year, dtbirthday.Value, Now)

        a.loadRate()
        
        If EDITMODE = True Then
            members.lsvMemberByID(commonID)
            txtfname.Text = members.propfname
            txtlnames.Text = members.proplname
            txtmi.Text = members.propmname
            txtaddress.Text = members.propaddress
            txtage.Text = members.propage
            dtbirthday.Value = members.propbirthday
            cbogender.Text = members.propgender
            txtlicense.Text = members.proplicenseno
            txtbarangay.Text = members.propbarangay
            dtexpiry.Value = members.propexpirydate
            'PictureBox1.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\members\" & members.propImg & " ")
            lblpicture.Text = members.propImg
            Dim i As Integer
            ' MsgBox(chkrequirements.Items.Count & " " & members.propreq1)

            For i = 0 To chkrequirements.Items.Count - 1

                If i = 0 And members.propreq1 <> "" Then
                    chkrequirements.SetItemCheckState(i, CheckState.Checked)
                End If
                If i = 1 And members.propreq2 <> "" Then
                    chkrequirements.SetItemCheckState(i, CheckState.Checked)
                End If
            Next i
            'motor.Listof_motor(members.propmemberID)
        Else
            PictureBox1.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\members\User.png")
            lblpicture.Text = "User.png"
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call modFunctions.ClearTextbox(Me)
        txtage.Text = DateDiff(DateInterval.Year, dtbirthday.Value, Date.Today)
        a.loadRate()
        'txtamount.Text = a.propAmount
    End Sub

    Private Sub dtbirthday_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtbirthday.ValueChanged
        txtage.Text = Math.Floor(DateDiff(DateInterval.Day, dtbirthday.Value, Now) / 365.25)
    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtchange_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtamounttender_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'txtamounttender.Text = FormatNumber(txtamounttender.Text.ToString, 2, , , TriState.True).ToString
    End Sub

    'Private Sub txtamounttender_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If (Not (Char.IsControl(e.KeyChar)) And Not (Char.IsDigit(e.KeyChar)) And (e.KeyChar <> ".")) Then
    '        e.Handled = True
    '    End If

    '    If (txtamount.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True



    'End Sub

    'Private Sub txtamounttender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        txtchange.Text = txtamount.Text - txtamounttender.Text
    '        txtamounttender.Text = FormatNumber(txtamounttender.Text.ToString, 2, , , TriState.True).ToString

    '    Catch
    '        txtchange.Text = "0.0"
    '    End Try
    'End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtfname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfname.KeyPress
        If AscW(e.KeyChar) > 64 And AscW(e.KeyChar) < 91 Or AscW(e.KeyChar) > 96 And AscW(e.KeyChar) < 123 Or AscW(e.KeyChar) = 8 Or e.KeyChar = " " Then
        Else
            e.KeyChar = Nothing
        End If

    End Sub

    Private Sub txtfname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfname.LostFocus
        txtfname.Text = modFunctions.UppercaseFirstLetter(txtfname.Text)  'f.ToString & Mid(txtfname.Text, 2)
    End Sub

    Private Sub txtfname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfname.TextChanged

    End Sub

    Private Sub txtlnames_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlnames.KeyPress
        If AscW(e.KeyChar) > 64 And AscW(e.KeyChar) < 91 Or AscW(e.KeyChar) > 96 And AscW(e.KeyChar) < 123 Or AscW(e.KeyChar) = 8 Or e.KeyChar = " " Then
        Else
            e.KeyChar = Nothing
        End If

    End Sub

    Private Sub txtlnames_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlnames.LostFocus
        txtlnames.Text = modFunctions.UppercaseFirstLetter(txtlnames.Text)
    End Sub

    Private Sub txtlnames_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlnames.TextChanged

    End Sub

    Private Sub txtmi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmi.KeyPress
        If AscW(e.KeyChar) > 64 And AscW(e.KeyChar) < 91 Or AscW(e.KeyChar) > 96 And AscW(e.KeyChar) < 123 Or AscW(e.KeyChar) = 8 Then
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtmi_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmi.LostFocus

        txtmi.Text = UCase(txtmi.Text)

    End Sub

    Private Sub txtmi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmi.TextChanged

    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        'saveFileDialog1.InitialDirectory = "D:\MY PROJECTS\motor4hire\images\officers pictures\"
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblpicture.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName.ToString)
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.Image.Save("D:\MY PROJECTS\motor4hire\images\members\" & System.IO.Path.GetFileName(OpenFileDialog1.FileName.ToString))
        End If
    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        If LCase(lblpicture.Text) = LCase("User.png") Then
            MsgBox("Cannot delete default image")
            Exit Sub
        End If
        PictureBox1.Image.Dispose()
        PictureBox1.Image = Nothing
        Me.Refresh()
        Dim file As New IO.FileStream("D:\MY PROJECTS\motor4hire\images\members\" & lblpicture.Text & "", IO.FileMode.Open)
        Dim image As Image = image.FromStream(file)
        file.Close()

        IO.File.Delete("D:\MY PROJECTS\motor4hire\images\officers pictures\" & lblpicture.Text & "")
    End Sub

    Private Sub txtbarangay_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbarangay.LostFocus
        txtbarangay.Text = modFunctions.UppercaseFirstLetter(txtbarangay.Text)
    End Sub

    Private Sub txtbarangay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbarangay.TextChanged

    End Sub
End Class