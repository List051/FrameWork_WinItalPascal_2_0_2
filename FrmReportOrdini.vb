
Imports WinItalPascal

Public Class FrmReportOrdini

    Private Sub FrmReportOrdini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmTitolo.CTitolo(Me, "Report Ordini")

        Me.OrdiniTableAdapter.Fill(Me.WinDBGdRDataSet.Ordini)
        Me.ReportViewer1.RefreshReport()
    End Sub


End Class