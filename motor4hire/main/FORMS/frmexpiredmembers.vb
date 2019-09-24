Public Class frmexpiredmembers

    Private Sub frmexpiredmembers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = "select m.idmember, concat(m.fname, ' ',m.mname,' ', m.lname) as name, m.address, m.expirydate, m.status from member m where m.status = 'expired'"
        Call modFunctions.PopulateListView(ListView1, sql)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim pid As Integer
            Dim m As New cMembers

            If (DateDiff(DateInterval.Year, dtregister.Value, Now) < 3) Then
                MsgBox("Error Please supply a correct date")
                Exit Sub
            End If
            pid = Convert.ToInt32(ListView1.SelectedItems(0).Text)
            Dim sql As String

            sql = "update member set expirydate = '" & Format(dtregister.Value, "yyyy-MM-dd").ToString & "',status = 'active' where idmember = " & pid
            GLOBAL_VARIABLES.d.execute(sql)
            GLOBAL_VARIABLES.d.reader.Close()
            MsgBox("Members has been successfully renewed")
            Dim sql1 As String = "select m.idmember, concat(m.fname, ' ',m.mname,' ', m.lname) as name, m.address, m.expirydate, m.status from member m where m.status = 'expired'"
            Call modFunctions.PopulateListView(ListView1, sql1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub dtregister_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtregister.ValueChanged

    End Sub
End Class