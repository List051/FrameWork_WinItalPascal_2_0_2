
Imports WinItalPascal
Imports CustomMessageBoxVB
Public Class FrmReportOrdini

    Private Sub FrmReportOrdini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmTitolo.CTitolo(Me, "Report Ordini")

        Me.OrdiniTableAdapter.Fill(Me.WinDBGdRDataSet.Ordini)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub RjBtnCerca_Click(sender As Object, e As EventArgs) Handles RjBtnCerca.Click
        ' Filtra i dati in base al valore di ricerca Materiale
        ' il campo è definito Materiale nella tabella Ordini
        Try
            Me.OrdiniTableAdapter.FillByMateriale(Me.WinDBGdRDataSet.Ordini, TxtCerca.Text)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            rjMessageBox.Show("Errore durante la ricerca: " & ex.Message)
        End Try

    End Sub

    Private Sub FillByMaterialeToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByMaterialeToolStripButton.Click
        Try
            Me.OrdiniTableAdapter.FillByMateriale(Me.WinDBGdRDataSet.Ordini, MaterialeToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class