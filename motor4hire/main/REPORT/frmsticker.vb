Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmsticker
    Public mysticker As String
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim report As New rptstick
        Dim objText As CrystalDecisions.CrystalReports.Engine.TextObject = report.ReportDefinition.Sections(3).ReportObjects("text3")
        objText.Text = mysticker
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Show()
    End Sub

End Class