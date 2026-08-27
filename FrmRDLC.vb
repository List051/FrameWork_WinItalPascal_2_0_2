

Imports System.Data.SqlClient
Imports CustomMessageBoxVB
Imports Microsoft.Reporting.WinForms
Imports WinItalPascal

Public Class FrmRDLC

    Private dvO As DataView
    Private dtO As DataTable




    Private Sub FrmRDLC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ScreenUtility.FullScreen(Me)
        FrmTitolo.CTitolo(Me, "Stampa Ordini RDLC")

        Dim dtO As DataTable = DB.FillDataTable("SELECT * FROM Ordini")

        ReportViewer1.ProcessingMode = ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath =
            IO.Path.Combine(Application.StartupPath, "Reports\Report1.rdlc")

        ReportViewer1.LocalReport.DataSources.Clear()

        Dim rds As New ReportDataSource("DataSet1", dtO)
        ReportViewer1.LocalReport.DataSources.Add(rds)

        ReportViewer1.RefreshReport()


    End Sub

    Private Sub RjBtnPDF_Click(sender As Object, e As EventArgs) Handles RjBtnPDF.Click

    End Sub
End Class