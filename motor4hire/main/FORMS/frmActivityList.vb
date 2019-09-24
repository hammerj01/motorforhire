Public Class frmActivityList

    Private Sub frmActivityList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call loadlist()

    End Sub

    Sub loadlist()
        Dim sql As String = "select idactivities, actname, description, startdate, organized_by from activities"
        Call modFunctions.PopulateListView(ListView1, sql)

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If ListView1.SelectedItems.Count > 0 Then
                Dim pid As Integer
                Dim act As New cActivities
                pid = Convert.ToInt32(ListView1.SelectedItems(0).Text)
                EDITMODE = True
                act.loadFields(pid)
                frmActivity.AID = act.propidactivity
                frmActivity.ShowDialog()
            Else
                MsgBox("No record has been selected")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(msgErr, MsgBoxStyle.Information, msgSystemInfo)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If ListView1.SelectedItems.Count > 0 Then
                Dim d As New cActivities
                Dim pid As Integer
                pid = Convert.ToInt32(ListView1.SelectedItems(0).Text)
                d.propidactivity = pid
                d.DELETE_ACTIVITY()
                MsgBox("Record has been successfully deleted.", MsgBoxStyle.Information, msgSystemInfo)
                Dim sql As String = "select idactivities, actname, description, startdate,enddate, organized_by from activities"
                Call modFunctions.PopulateListView(ListView1, sql)
            Else
                MsgBox("No record has been selected")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(msgErr, MsgBoxStyle.Information, msgSystemInfo)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        EDITMODE = False
        frmActivity.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call loadlist()
    End Sub
End Class