Imports MySql.Data.MySqlClient
Public Class rptactivity

    Private Sub rptactivity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim a As New cActivities

        Try
            Dim rpt As New CrystalReport1
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class