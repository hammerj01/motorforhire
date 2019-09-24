
Public Class mysystem

    Private Sub MANAGEMEMBERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MANAGEMEMBERToolStripMenuItem.Click
        EDITMODE = False
        'frmMembersEntry.ShowDialog()
        Dim ch As New frmMemberRecords
        ch.MdiParent = Me
        ch.Show()


    End Sub

    Private Sub OFFICERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFFICERSToolStripMenuItem.Click
        'frmOfficers.ShowDialog()
        Dim o As New frmOfficersList
        o.MdiParent = Me
        o.Show()
    End Sub

    Private Sub MEMBERSRECORDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEMBERSRECORDToolStripMenuItem.Click
        Dim M As New frmMemberRecords
        M.MdiParent = Me
        M.btnAdd.Hide()
        M.btnDelete.Hide()
        M.btnedit.Hide()
        M.Show()

    End Sub

    Private Sub ACTIVITIESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACTIVITIESToolStripMenuItem.Click
        'frmActivity.ShowDialog()
        Dim a As New frmActivityList
        a.MdiParent = Me
        a.Show()

    End Sub

    Private Sub USERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERSToolStripMenuItem.Click
        'frmUserAccount.ShowDialog()
        Dim u As New frmUserAccount
        u.MdiParent = Me
        u.Show()

    End Sub

    Private Sub CONTRIBUTIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmPayments.ShowDialog()
        Dim p As New frmPayments
        p.MdiParent = Me
        p.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        End
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPayments.ShowDialog()
    End Sub

    Private Sub mysystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mo As New cMotor
        If mo.ifExpires1week > 0 Then
            frmmotorsexpirelist.ShowDialog()
        End If
        Dim m As New cMembers
        Call m.expiredMembers()
        ' = Image.FromFile("D:\MY PROJECTS\motor4hire\images\bisulogo.jpg")
        'PictureBox2.Image = Image.FromFile("D:\MY PROJECTS\motor4hire\images\sticker.jpg")
        Dim child As Control
        For Each child In Me.Controls
            If TypeOf child Is MdiClient Then
                child.BackColor = Color.CadetBlue
                child.BackgroundImage = Image.FromFile("D:\MY PROJECTS\motor4hire\images\bg.jpg")
                Exit For
            End If
        Next

    End Sub

    Private Sub ComplaintsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplaintsToolStripMenuItem.Click

        Dim p As New frmComplainlist
        p.MdiParent = Me
        p.Show()

    End Sub

    Private Sub OFFICERSToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFFICERSToolStripMenuItem1.Click
        Dim a As New frmOfficerQuery
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub ACTIVITYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACTIVITYToolStripMenuItem.Click
        Dim p As New frmManageActivity
        p.MdiParent = Me
        p.Show()
    End Sub

    Private Sub COMPLAINTSToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPLAINTSToolStripMenuItem1.Click
        'frmComplainlist.ShowDialog()
        Dim c As New frmComplainlist
        c.MdiParent = Me
        c.btnAdd.Hide()
        c.btnEdit.Hide()
        c.btnDelete.Hide()
        c.Button1.Hide()
        c.Show()
    End Sub

    Private Sub DATABASEBACKUPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATABASEBACKUPToolStripMenuItem.Click
        frmbackuprestore.ShowDialog()
    End Sub

    Private Sub GENERATEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmgenerate.ShowDialog()

    End Sub

    Private Sub USERACCOUNTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERACCOUNTToolStripMenuItem.Click
        'rptuseract.ShowDialog()
    End Sub

    Private Sub MEMBERSLISTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEMBERSLISTToolStripMenuItem.Click
        Dim f As New rptmembers
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ACTIVITYLISTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACTIVITYLISTToolStripMenuItem.Click
        Dim f As New rptactivity
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub STICKERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STICKERToolStripMenuItem.Click
        Dim f As New frmsticker
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub OFFICERSLISTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFFICERSLISTToolStripMenuItem.Click
        Dim f As New rptofficers
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MEMBERSHIPFEEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEMBERSHIPFEEToolStripMenuItem.Click
        Dim f As New frmrate
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub WEEKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WEEKToolStripMenuItem.Click
        Dim f As New frmmotorsexpirelist
        f.MdiParent = Me
        f.ShowDialog()
    End Sub

    Private Sub MembersExpiredToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MembersExpiredToolStripMenuItem.Click
        Dim m As New frmexpiredmembers
        m.MdiParent = Me
        m.ShowDialog()
    End Sub

    Private Sub EXPIREDMOTORToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXPIREDMOTORToolStripMenuItem.Click
        Dim f As New frmrenewmotor
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub COMPLAINTSToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPLAINTSToolStripMenuItem2.Click
        Dim f As New rptcomplaints
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MANAGEMOTORToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MANAGEMOTORToolStripMenuItem.Click
        Dim ml As New frmMotorList
        ml.MdiParent = Me
        ml.Show()
    End Sub
    Private Sub INCOMEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INCOMEToolStripMenuItem.Click
        Dim f As New rptPayments
        f.MdiParent = Me
        f.Show()
    End Sub
End Class