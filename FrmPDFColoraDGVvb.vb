
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.parser
Imports System.Drawing.Imaging
Imports CustomMessageBoxVB

Imports WinItalPascal


Public Class FrmPDFColoraDGVvb
    Private Sub FrmPDFColoraDGVvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ScreenUtility.FullScreen(Me)
        FrmTitolo.CTitolo(Me, "Help PDF -  Funzione WinItalPascal")

        Try
            ' Eventuali messaggi di avviso o istruzioni per l'utente
        Catch ex As Exception
            RJMessageBox.Show("Errore visualizzazione PDF: " & ex.Message)
        End Try
    End Sub

    Public Sub CaricaPDF(percorso As String)
            Try
                WebBrowser1.Navigate(percorso)
            Catch ex As Exception
                RJMessageBox.Show("Errore apertura PDF: " & ex.Message)
            End Try
        End Sub

End Class