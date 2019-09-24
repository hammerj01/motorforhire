Public Class rptofficers

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim o As New cOfficers
        Try
            Dim rpt As New rptvofficers
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class