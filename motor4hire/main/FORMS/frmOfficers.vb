Imports System.IO

Public Class frmOfficers
    Dim president, vice As String
    Dim secretary, treasurer As String
    Dim auditor As String
    Dim dateelected As Date
    Dim pID, vID, tID, aID, sID As Integer
    Dim pimage, vimage, simage, timage, aimage As String

    Private Sub frmOfficers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        ListView1.Hide()
        ListView2.Hide()
        ListView3.Hide()
        ListView4.Hide()
        ListView5.Hide()
    End Sub
    Private Sub frmOfficers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If EDITMODE = True Then

            Dim officer As New cOfficers

            officer.LoadOfficer(act_officerID)
            txtpresident.Text = officer.proppresident
            txtvicepresident.Text = officer.propvice
            txttresurer.Text = officer.proptresurer
            txtsecretary.Text = officer.propsecretary
            txauditor.Text = officer.propauditor
            dtElection.Value = Format(officer.propddateelected, "M/dd/yyyy").ToString
            dtendterm.Value = Format(officer.propendterm, "M/dd/yyyy").ToString

            If modFunctions.IsEmpty(officer.propPres_image) = True Then
                PictureBox1.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\User.png")
                lblpres.Text = "User.png"
            Else
                PictureBox1.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\" & officer.propPres_image & " ")
                lblpres.Text = officer.propPres_image
            End If
            If modFunctions.IsEmpty(officer.propSec_image) = True Then
                PictureBox5.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\user.png")
                lblSecretary.Text = "User.png"
            Else
                PictureBox5.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\" & officer.propSec_image & " ")
                lblSecretary.Text = officer.propSec_image
            End If

            If modFunctions.IsEmpty(officer.propVice_image) = True Then
                PictureBox2.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\user.png")
                lblvice.Text = "User.png"
            Else
                PictureBox2.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\" & officer.propVice_image & " ")
                lblvice.Text = officer.propVice_image
            End If

            If modFunctions.IsEmpty(officer.propTres_image) = True Then
                PictureBox3.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\user.png")
                lbltreasurer.Text = "User.png"
            Else
                PictureBox3.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\" & officer.propTres_image & " ")
                lbltreasurer.Text = officer.propTres_image
            End If

            If modFunctions.IsEmpty(officer.propAud_image) = True Then
                PictureBox4.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\user.png")
                lblauditor.Text = "User.png"
            Else
                PictureBox4.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\" & officer.propAud_image & " ")
                lblauditor.Text = officer.propAud_image
            End If

            'PictureBox5.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\" & officer.propSec_image & " ")
            If officer.propactive = "Active" Then
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False
            End If
        Else
            PictureBox1.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\User.png")
            PictureBox2.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\User.png")
            PictureBox3.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\User.png")
            PictureBox4.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\User.png")
            PictureBox5.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\User.png")

            lblpres.Text = "User.png"
            lblvice.Text = "User.png"
            lblauditor.Text = "User.png"
            lblSecretary.Text = "User.png"
            lbltreasurer.Text = "User.png"
        End If
        ListView1.Hide()
        ListView2.Hide()
        ListView3.Hide()
        ListView4.Hide()
        ListView5.Hide()

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        pID = Convert.ToInt32(ListView1.SelectedItems(0).Text).ToString
        txtpresident.Text = ListView1.SelectedItems(0).SubItems(1).Text
        ListView1.Hide()
    End Sub

    Private Sub txtpresident_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpresident.LostFocus
        ListView1.Hide()
    End Sub

    Private Sub txtpresident_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpresident.TextChanged
        Call modFunctions.PopulateListView(ListView1, "select `idmember`," & _
                              " concat(`fname`,' ', `mname`, ' ', `lname` ) " & _
                              " as name from member where fname like '%" & txtpresident.Text.ToString & "%' and status != 'Inactive'")
        ListView1.Show()
    End Sub

    Private Sub ListView3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView3.Click
        sID = Convert.ToInt32(ListView3.SelectedItems(0).Text).ToString
        txtsecretary.Text = ListView3.SelectedItems(0).SubItems(1).Text
        ListView3.Hide()
    End Sub

    Private Sub txtsecretary_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsecretary.LostFocus
        ListView3.Hide()
    End Sub

    Private Sub txtsecretary_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsecretary.TextChanged
        Call modFunctions.PopulateListView(ListView3, "select `idmember`," & _
                               " concat(`fname`,' ', `mname`, ' ', `lname` ) " & _
                               " as name from member where fname like '%" & txtsecretary.Text.ToString & "%' and status != 'Inactive'")
        With ListView3
            .Show()
            .Width = 374
            .Height = 197
        End With
    End Sub

    Private Sub txauditor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txauditor.LostFocus
        ListView2.Hide()
    End Sub

    Private Sub txauditor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txauditor.TextChanged
        Call modFunctions.PopulateListView(ListView2, "select `idmember`, concat(`fname`,' ', `mname`, ' ', `lname` ) " & _
                                               " as name from member where fname like '%" & txauditor.Text.ToString & "%' and status != 'Inactive'")
        With ListView2
            .Show()
            .Width = 374
            .Height = 197
        End With

    End Sub

    Private Sub txttresurer_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttresurer.LostFocus
        ListView5.Hide()
    End Sub

    Private Sub txttresurer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttresurer.TextChanged
        Call modFunctions.PopulateListView(ListView5, "select `idmember`," & _
                                " concat(`fname`,' ', `mname`, ' ', `lname` ) " & _
                                " as name from member where fname like '%" & txttresurer.Text.ToString & "%' and status != 'Inactive'")
        With ListView5
            .Show()
            .Width = 374
            .Height = 197
        End With
    End Sub

    Private Sub txtvicepresident_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvicepresident.LostFocus
        ListView4.Hide()
    End Sub

    Private Sub txtvicepresident_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvicepresident.TextChanged
        Call modFunctions.PopulateListView(ListView4, "select `idmember`," & _
                          " concat(`fname`,' ', `mname`, ' ', `lname` ) " & _
                          " as name from member where fname like '%" & txtvicepresident.Text.ToString & "%' and status != 'Inactive'")
        With ListView4
            .Show()
            .Width = 374
            .Height = 197
        End With
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim officer As New cOfficers
        Dim status As String = "Inactive"

        If (modFunctions.IsEmpty(pID) = True) Or (modFunctions.IsEmpty(sID) = True) Or (modFunctions.IsEmpty(vID) = True) Or (modFunctions.IsEmpty(aID) = True) Or (modFunctions.IsEmpty(tID) = True) Then
            MsgBox("Please supply the correct value.")
            Exit Sub
        ElseIf txtpresident.Text = txtsecretary.Text Or txtpresident.Text = txauditor.Text Or txtpresident.Text = txttresurer.Text Then
            MsgBox("Officer must have only 1 position.")
            Exit Sub
        ElseIf txtvicepresident.Text = txtpresident.Text Or txtvicepresident.Text = txauditor.Text Or txtvicepresident.Text = txttresurer.Text Then
            MsgBox("Officer must have only 1 position.")
            Exit Sub
        ElseIf txtsecretary.Text = txauditor.Text Or txtsecretary.Text = txttresurer.Text Or txttresurer.Text = txauditor.Text Then
            MsgBox("Officer must have only 1 position.")
            Exit Sub
        End If

        If CheckBox1.Checked = True Then
            status = "Active"
        Else
            status = "Inactive"
        End If

        If officer.officerstatus(dtElection.Text, dtendterm.Text, status) = True Then
            MsgBox("Election status is active. update the status endterm to inactive")
            Exit Sub
        ElseIf dtElection.Value.Year >= dtendterm.Value.Year Then
            MsgBox("Election date must be lesser than or equal to end term")
            Exit Sub
        End If

        If EDITMODE = True Then
            officer.propidofficers = act_officerID
            officer.proppresident = txtpresident.Text
            officer.propvice = txtvicepresident.Text
            officer.propsecretary = txtsecretary.Text
            officer.proptresurer = txttresurer.Text
            officer.propauditor = txauditor.Text
            officer.propddateelected = dtElection.Text
            officer.propendterm = dtendterm.Text
            officer.propAud_image = lblauditor.Text
            officer.propPres_image = lblpres.Text
            officer.propVice_image = lblvice.Text
            officer.propTres_image = lbltreasurer.Text
            officer.propSec_image = lblSecretary.Text
            officer.propactive = status
            officer.UPDATE_OFFICERS()
            MsgBox(msgUpdate, MsgBoxStyle.Information, msgSystemInfo)
        Else
            officer.proppresident = txtpresident.Text
            officer.propvice = txtvicepresident.Text
            officer.propsecretary = txtsecretary.Text
            officer.proptresurer = txttresurer.Text
            officer.propauditor = txauditor.Text
            officer.propddateelected = dtElection.Text
            officer.propendterm = dtendterm.Text
            officer.propAud_image = lblauditor.Text
            officer.propPres_image = lblpres.Text
            officer.propVice_image = lblvice.Text
            officer.propTres_image = lbltreasurer.Text
            officer.propSec_image = lblSecretary.Text
            officer.propactive = status
            officer.INSERT_OFFICERS()
            MsgBox(msgInsert, MsgBoxStyle.Information, msgSystemInfo)
        End If
        Dim sql As String = "select * from officers where status = 'Active'"
        Call modFunctions.PopulateListView(frmOfficersList.ListView1, sql)
        modFunctions.ClearTextbox(Me)
        PictureBox1.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\User.png")
        PictureBox2.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\User.png")
        PictureBox3.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\User.png")
        PictureBox4.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\User.png")
        PictureBox5.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\officers pictures\User.png")

        lblpres.Text = "User.png"
        lblvice.Text = "User.png"
        lblauditor.Text = "User.png"
        lblSecretary.Text = "User.png"
        lbltreasurer.Text = "User.png"
        Close()

    End Sub

    Private Sub ListView2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.Click
        aID = Convert.ToInt32(ListView2.SelectedItems(0).Text).ToString

        txauditor.Text = ListView2.SelectedItems(0).SubItems(1).Text
        ListView2.Hide()
    End Sub

    Private Sub ListView3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView3.SelectedIndexChanged

    End Sub

    Private Sub ListView5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView5.Click

        tID = Convert.ToInt32(ListView5.SelectedItems(0).Text).ToString
        txttresurer.Text = ListView5.SelectedItems(0).SubItems(1).Text
        ListView5.Hide()

    End Sub

    Private Sub ListView4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView4.Click
        vID = Convert.ToInt32(ListView4.SelectedItems(0).Text).ToString
        txtvicepresident.Text = ListView4.SelectedItems(0).SubItems(1).Text
        ListView4.Hide()
    End Sub

    Private Sub ListView5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView5.SelectedIndexChanged

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call modFunctions.ClearTextbox(Me)
    End Sub

    Private Sub ListView4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView4.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.OpenFile()
    End Sub

    Private Sub btnPresident_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPresident.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        'saveFileDialog1.InitialDirectory = "D:\MY PROJECTS\motor4hire\images\officers pictures\"
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblpres.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName.ToString)
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.Image.Save("D:\MY PROJECTS\motor4hire\images\officers pictures\" & System.IO.Path.GetFileName(OpenFileDialog1.FileName.ToString))
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim saveFileDialog1 As New SaveFileDialog

        saveFileDialog1.InitialDirectory = "D:\MY PROJECTS\motor4hire\images\officers pictures\"
        saveFileDialog1.Title = "Save text Files"
        saveFileDialog1.CheckFileExists = True
        saveFileDialog1.CheckPathExists = True
        saveFileDialog1.DefaultExt = "txt"
        saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpresremove.Click
        If LCase(lblpres.Text) = LCase("User.png") Then
            MsgBox("Cannot delete default image")
            Exit Sub
        End If
        PictureBox1.Image.Dispose()
        PictureBox1.Image = Nothing
        Me.Refresh()
        Dim file As New IO.FileStream("D:\MY PROJECTS\motor4hire\images\officers pictures\" & lblpres.Text & "", IO.FileMode.Open)
        Dim image As Image = image.FromStream(file)
        file.Close()
        
        IO.File.Delete("D:\MY PROJECTS\motor4hire\images\officers pictures\" & lblpres.Text & "")

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        'saveFileDialog1.InitialDirectory = "D:\MY PROJECTS\motor4hire\images\officers pictures\"
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblSecretary.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName.ToString)
            PictureBox5.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox5.Image.Save("D:\MY PROJECTS\motor4hire\images\officers pictures\" & System.IO.Path.GetFileName(OpenFileDialog1.FileName.ToString))
        End If
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        'saveFileDialog1.InitialDirectory = "D:\MY PROJECTS\motor4hire\images\officers pictures\"
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblvice.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName.ToString)
            PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox2.Image.Save("D:\MY PROJECTS\motor4hire\images\officers pictures\" & System.IO.Path.GetFileName(OpenFileDialog1.FileName.ToString))
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        'saveFileDialog1.InitialDirectory = "D:\MY PROJECTS\motor4hire\images\officers pictures\"
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblauditor.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName.ToString)
            PictureBox4.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox4.Image.Save("D:\MY PROJECTS\motor4hire\images\officers pictures\" & System.IO.Path.GetFileName(OpenFileDialog1.FileName.ToString))
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        'saveFileDialog1.InitialDirectory = "D:\MY PROJECTS\motor4hire\images\officers pictures\"
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lbltreasurer.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName.ToString)
            PictureBox3.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox3.Image.Save("D:\MY PROJECTS\motor4hire\images\officers pictures\" & System.IO.Path.GetFileName(OpenFileDialog1.FileName.ToString))
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If LCase(lblvice.Text) = LCase("User.png") Then
            MsgBox("Cannot delete default image")
            Exit Sub
        End If
        PictureBox2.Image.Dispose()
        PictureBox2.Image = Nothing
        Me.Refresh()
        Dim file As New IO.FileStream("D:\MY PROJECTS\motor4hire\images\officers pictures\" & lblvice.Text & "", IO.FileMode.Open)
        Dim image As Image = image.FromStream(file)
        file.Close()
        
        IO.File.Delete("D:\MY PROJECTS\motor4hire\images\officers pictures\" & lblvice.Text & "")
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If LCase(lblauditor.Text) = LCase("User.png") Then
            MsgBox("Cannot delete default image")
            Exit Sub
        End If
        PictureBox4.Image.Dispose()
        PictureBox4.Image = Nothing
        Me.Refresh()
        Dim file As New IO.FileStream("D:\MY PROJECTS\motor4hire\images\officers pictures\" & lblauditor.Text & "", IO.FileMode.Open)
        Dim image As Image = image.FromStream(file)
        file.Close()
        
        IO.File.Delete("D:\MY PROJECTS\motor4hire\images\officers pictures\" & lblauditor.Text & "")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If LCase(lbltreasurer.Text) = LCase("User.png") Then
            MsgBox("Cannot delete default image")
            Exit Sub
        End If
        PictureBox3.Image.Dispose()
        PictureBox3.Image = Nothing
        Me.Refresh()
        Dim file As New IO.FileStream("D:\MY PROJECTS\motor4hire\images\officers pictures\" & lbltreasurer.Text & "", IO.FileMode.Open)
        Dim image As Image = image.FromStream(file)
        file.Close()
        
        IO.File.Delete("D:\MY PROJECTS\motor4hire\images\officers pictures\" & lbltreasurer.Text & "")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If LCase(lblSecretary.Text) = LCase("User.png") Then
            MsgBox("Cannot delete default image")
            Exit Sub
        End If
        PictureBox5.Image.Dispose()
        PictureBox5.Image = Nothing
        Me.Refresh()
        Dim file As New IO.FileStream("D:\MY PROJECTS\motor4hire\images\officers pictures\" & lblSecretary.Text & "", IO.FileMode.Open)
        Dim image As Image = image.FromStream(file)
        file.Close()
        
        IO.File.Delete("D:\MY PROJECTS\motor4hire\images\officers pictures\" & lblSecretary.Text & "")
    End Sub
End Class