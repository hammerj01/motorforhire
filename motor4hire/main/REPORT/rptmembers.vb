Public Class rptmembers

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim m As New cMembers

        Try
            Dim rpt As New rptvmember
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class