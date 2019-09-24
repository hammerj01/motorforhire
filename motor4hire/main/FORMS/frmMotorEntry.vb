Public Class frmMotorEntry
    Dim m As New cMotor
    Dim motorname, description, plateno, img, crno, orno, chasisno As String
    Dim xpirydate As Date
    Dim mem As New cMembers
    Dim pay As New cPayments
    Dim motID, memID As Integer

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sticker As String
        Dim s As New cSticker
        Dim yr, yr1 As Integer
        motorname = txtmotor.Text
        description = txtdescription.Text
        orno = txtorno.Text
        crno = txtcrno.Text
        plateno = txtplateno.Text
        xpirydate = dtmotorexpiry.Text
        chasisno = txtchasis.Text

        Dim sql As String
        sql = "select mo.idmotor,concat(m.fname, ' ', m.mname, ' ', m.lname)as name,mo.name," & _
        "mo.description,mo.plateno,mo.or_num,mo.cr_num,mo.chasisno,dateofexpiration, m.idmember" & _
        " from member m inner join motor mo on m.idmember=mo.idmember"
        yr = Convert.ToInt64(DateTime.Now.ToString("yyyy").ToString).ToString
        yr1 = Format(dtmotorexpiry.Value, "yyyy").ToString
        If motorname.Length < 5 Then
            MsgBox("Motocycle model should not be less than 5")
            Exit Sub
        ElseIf description.Length < 5 Then
            MsgBox("Description should not be less than 5")
            Exit Sub
        ElseIf modFunctions.IsEmpty(motorname) = True Or modFunctions.IsEmpty(description) = True Or modFunctions.IsEmpty(orno) = True Or modFunctions.IsEmpty(crno) = True Then
            MsgBox("Please supply an empty fields.")
            Exit Sub
        ElseIf modFunctions.IsEmpty(plateno) = True Or modFunctions.IsEmpty(chasisno) = True Then
            MsgBox("Please supply an empty fields.")
            Exit Sub
        ElseIf Convert.ToInt64(yr.ToString) >= Convert.ToInt64(yr1.ToString) Then
            MsgBox("Please specify the correct expiry date.")
            Exit Sub
        
        End If
        If EDITMODE = False Then
            If Convert.ToDouble(txtamount.Text).ToString > Convert.ToDouble(txtamounttender.Text).ToString Then
                MsgBox("Amount tender should not be lesser than the amount")
                Exit Sub
            End If
        End If

        If EDITMODE = True Then
            m.propcrno = crno
            m.propmemberID = act_memberID
            m.propormo = orno
            m.propname = motorname
            m.propdescription = description
            m.propplateno = plateno
            m.propdateofexpiration = xpirydate
            m.propchasis = chasisno
            m.update_motor()
            MsgBox(msgUpdate)
            Me.Close()
        Else
            If act_memberID < 1 Then
                MsgBox("Please select the owner on the motor cycle.")
                Exit Sub
            End If
            m.propcrno = crno
            m.propmemberID = act_memberID
            m.propormo = orno
            m.propname = motorname
            m.propdescription = description
            m.propplateno = plateno
            m.propdateofexpiration = xpirydate
            m.propchasis = chasisno
            m.propstatus = "Active"
            m.Insert_motor()

            pay.propAmount = txtamount.Text
            pay.propmemberID = act_memberID
            mem.lsvMemberByID(act_memberID)
            pay.propfname = mem.propfname
            pay.propmname = mem.propmname
            pay.proplname = mem.proplname
            pay.INSERT_PAYMENTS()

            sticker = modFunctions.generatepassword(4) & Format(Now, "yy") & modFunctions.generatepassword(4)

            s.propStickerno = sticker
            s.propmemberID = act_memberID
            s.propstatus = "Active"
            s.propDatestart = dtmotorexpiry.Text
            s.INSERT_STICKER()
            MsgBox("Record has been successfully save.")
            MsgBox("Printing sticker.")
            Call modFunctions.PopulateListView(frmMotorList.ListView1, sql)
            Me.Close()

            frmsticker.mysticker = sticker
            frmsticker.ShowDialog()
            modFunctions.ClearTextbox(Me)


        End If
    End Sub

    Private Sub txtowner_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtowner.TextChanged
        Dim sql As String

        If txtowner.TextLength > 0 Then
            ListView1.BringToFront()
            sql = "select `idmember`," & _
                              " concat(`fname`,' ', `mname`, ' ', `lname` ) " & _
                              " as name from member where (fname like '" & txtowner.Text.ToString & "%' or lname like '" & txtowner.Text.ToString & "%') and (status = 'Active' or status = 'expired')"
            Call modFunctions.PopulateListView(ListView1, sql)
            ListView1.Visible = True
        Else
            ListView1.Visible = False
        End If
    End Sub

    Private Sub frmMotorEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtamounttender.Text = "0.0"
        If EDITMODE = True Then
            mem.lsvMemberByID(act_memberID)
            memID = mem.propmemberID.ToString
            m.Listof_motor(act_motorID)
            txtowner.Text = mem.propfname & " " & mem.proplname
            txtmotor.Text = m.propname
            txtdescription.Text = m.propdescription
            txtorno.Text = m.propormo
            txtcrno.Text = m.propcrno
            txtchasis.Text = m.propchasis
            txtplateno.Text = m.propplateno
            dtmotorexpiry.Value = Format(m.propdateofexpiration, "MM-dd-yyyy").ToString
            txtamount.Enabled = True
            txtamounttender.Enabled = True
            txtchange.Enabled = True
        End If
        ListView1.Visible = False
    End Sub

    Private Sub txtchange_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtchange.TextChanged
        'txtchange.Text = Convert.ToDouble(txtamount.Text).ToString - Convert.ToDouble(txtamounttender.Text).ToString
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            act_memberID = Convert.ToInt32(ListView1.SelectedItems(0).Text).ToString
            mem.lsvMemberByID(act_memberID)
            memID = mem.propmemberID.ToString
            txtowner.Text = mem.propfname & " " & mem.propmname & " " & mem.proplname
            ListView1.Visible = False
        Else
            act_memberID = 0
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub txtamounttender_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamounttender.KeyDown
        'txtamounttender.Text = FormatNumber(txtamounttender.Text.ToString, 2, , , TriState.True).ToString
    End Sub

    Private Sub txtamounttender_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamounttender.KeyPress
        If (Not (Char.IsControl(e.KeyChar)) And Not (Char.IsDigit(e.KeyChar)) And (e.KeyChar <> ".")) Then
            e.Handled = True
        End If

        If (txtamount.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True
    End Sub

    Private Sub txtamounttender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamounttender.TextChanged
        Try
            txtchange.Text = FormatNumber(txtamount.Text - txtamounttender.Text, 2, , , TriState.True).ToString
            txtamounttender.Text = FormatNumber(txtamounttender.Text.ToString, 2, , , TriState.True).ToString
            txtchange.Text = FormatNumber(txtchange.Text.ToString, 2, , , TriState.True).ToString
        Catch
            txtchange.Text = "0.0"
        End Try
    End Sub
End Class