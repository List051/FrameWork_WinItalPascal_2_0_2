
Imports CustomMessageBoxVB
Imports WinItalPascal

Public Class FrmReport
    Public Property TitoloReport As String = ""
    Public Property NomeReport As String
    Public Property TabellaReport As DataTable
    Public Property DataSourceReport As String
    '  Private FormInCaricamento As Boolean = True

    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ScreenUtility.FullScreen(Me) ' maximize form
        FrmTitolo.CTitolo(Me, TitoloReport) ' Titolo del Form, inclusa opzionèChiudi Finestra senza uscire dall'applicazione

        RJMessageBox.Show("Carica" & vbCrLf & "NomeReport = " & NomeReport &
                            vbCrLf &
                          "DataSource = " & DataSourceReport & vbCrLf &
                          "Tabella = " & If(TabellaReport Is Nothing, "NULL", TabellaReport.Rows.Count.ToString()))
        ReportImpostazioni.SetImpOrd(ReportViewer1)
        '   FormInCaricamento = True
        ReportManager.ApriReport(
        ReportViewer1,
        NomeReport,
        TabellaReport,
        DataSourceReport)

        '  Me.ReportViewer1.RefreshReport()

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub RjBtnEsportaPDF_Click(sender As Object, e As EventArgs) Handles RjBtnEsportaPDF.Click
        Try

            ReportManager.EsportaPdf(NomeReport, TabellaReport, DataSourceReport)
        Catch ex As Exception
            RJMessageBox.Show("Errore apertura file PDF : " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RjBtnPDF_Click(sender As Object, e As EventArgs) Handles RjBtnPDF.Click
        ReportManager.Stampa(ReportViewer1)
    End Sub

End Class