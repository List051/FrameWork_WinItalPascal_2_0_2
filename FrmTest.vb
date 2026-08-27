Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CustomMessageBoxVB
Imports WinItalPascal

Public Class FrmTest
    Public Property TitoloReport As String = ""
    Public Property NomeReport As String
    Public Property TabellaReport As DataTable
    Public Property DataSourceReport As String


    Private Sub FrmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'WinDBGdRDataSet.Ordini'. È possibile spostarla o rimuoverla se necessario.
        Me.OrdiniTableAdapter.Fill(Me.WinDBGdRDataSet.Ordini)
        'TODO: questa riga di codice carica i dati nella tabella 'WinDBGdRDataSet.Fattura'. È possibile spostarla o rimuoverla se necessario.
        Me.FatturaTableAdapter.Fill(Me.WinDBGdRDataSet.Fattura)

        'ReportManager.ApriReport("Elenco Ordini", "Report1.rdlc", "Select * from Ordini")
        ' ReportImpostazioni.SetImpOrd(ReportViewer1)
        '   FormInCaricamento = True
        'ReportManager.ApriReport(
        'ReportViewer1,
        'NomeReport,
        'TabellaReport,
        'DataSourceReport)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub RjBtnPDF_Click(sender As Object, e As EventArgs) Handles RjBtnPDF.Click

        Dim frm As New FrmReport
        frm.TitoloReport = "Elenco Ordini Cliente"
        frm.NomeReport = "Rep2Manager.rdlc"
        ' Esempio per debug  prima della query
        Dim conn As SqlConnection = DB.GetConnection()
        RJMessageBox.Show("Connessione: " & conn.DataSource & " DB: " & conn.Database)
        frm.TabellaReport = DB.FillDataTable("SELECT * FROM dbo.Ordini")
        frm.DataSourceReport = "DataSet1"
        RJMessageBox.Show("Apro Report  : " & frm.NomeReport)
        frm.Show()
    End Sub

    Private Sub RjBtnEsportaPDF_Click(sender As Object, e As EventArgs) Handles RjBtnEsportaPDF.Click

        ' ReportManager.Stampa(ReportViewer1)
        Dim frm As New FrmReport
        frm.TitoloReport = "Elenco Ordini Cliente"
        frm.NomeReport = "Rep2Manager.rdlc"
        ' Esempio per debug  prima della query
        Dim conn As SqlConnection = DB.GetConnection()
        RJMessageBox.Show("Connessione: " & conn.DataSource & " DB: " & conn.Database)
        frm.TabellaReport = DB.FillDataTable("SELECT * FROM dbo.Ordini")
        frm.DataSourceReport = "DataSet1"
        RJMessageBox.Show("Apro Report  : " & frm.NomeReport)
        frm.ShowDialog()
    End Sub


End Class