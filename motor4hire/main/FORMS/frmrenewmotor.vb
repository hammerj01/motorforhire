Public Class frmrenewmotor

    Private Sub frmrenewmotor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'idmotor, name, date_register, idmember, or_num, cr_num, description, dateofexpiration, plateNo, status
        Dim sql As String = "select idmotor, concat(name, ' ', description) as name, plateno,dateofexpiration, status from motor where status = 'expired'"
        Call modFunctions.PopulateListView(ListView1, sql)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim m As New cMotor
            Dim x As Integer
            x = DateDiff(DateInterval.Year, dtregister.Value, Now)
            If (x > 1) Then
                MsgBox("Error Please supply a correct date")
                Exit Sub
            End If
            Dim p As Integer
            p = Convert.ToInt64(ListView1.SelectedItems(0).Text)
            Dim sql As String = "Update motor set status = 'active', dateofexpiration = '" & Format(dtregister.Value, "yyyy-MM-dd").ToString & "' where idmotor = " & p
            GLOBAL_VARIABLES.d.execute(sql)
            GLOBAL_VARIABLES.d.reader.Close()
            Dim sql1 As String = "select idmotor, concat(name, ' ', description) as name, plateno,dateofexpiration, status from motor where status = 'expired'"
            Call modFunctions.PopulateListView(ListView1, sql1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class