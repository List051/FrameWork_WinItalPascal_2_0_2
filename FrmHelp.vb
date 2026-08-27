
Imports CustomMessageBoxVB
Imports WinItalPascal

Public Class FrmHelp

    Private Sub FrmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ScreenUtility.FullScreen(Me)

        FrmTitolo.CTitolo(Me, "Help Funzioni WinItalPascal")
        ScreenUtility.CentraForm(Me)

    End Sub

    Private Sub RjCircBtnApriColoraDGV_Click(sender As Object, e As EventArgs) Handles RjCircBtnApriColoraDGV.Click
        Try
            Dim percorsoPDF As String = "C:\Users\Utente\Documents\VSC\📘 HELP ColoraDGV.pdf" ' oppure percorso memorizzato

            Dim frm As New FrmPDFColoraDGVvb()
            frm.CaricaPDF(percorsoPDF)
            frm.Show()
            Me.Close()
        Catch ex As Exception
            RJMessageBox.Show("Errore apertura PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub RjCircBtnApriClientiOrd_Click(sender As Object, e As EventArgs) Handles RjCircBtnApriClientiOrd.Click
        Try
            Dim percorsoPDF As String = "C:\Users\Utente\Documents\VSC\📘 HELP Form Gestione Clienti.pdf" ' oppure percorso memorizzato

            Dim frm As New FrmPDFColoraDGVvb()
            frm.CaricaPDF(percorsoPDF)
            frm.Show()
            Me.Close()
        Catch ex As Exception
            RJMessageBox.Show("Errore apertura PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub RjCircBtpPdfFattura_Click(sender As Object, e As EventArgs) Handles RjCircBtpPdfFattura.Click
        Try
            Dim percorsoPDF As String = "C:\Users\Utente\Documents\VSC\📘 HELP Gestione Fatture.pdf" ' oppure percorso memorizzato

            Dim frm As New FrmPDFColoraDGVvb()
            frm.CaricaPDF(percorsoPDF)
            frm.Show()
            Me.Close()
        Catch ex As Exception
            RJMessageBox.Show("Errore apertura PDF: " & ex.Message)
        End Try
    End Sub
End Class