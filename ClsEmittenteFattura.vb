Imports System.IO

Imports CustomMessageBoxVB
Imports CreaFiltroDvg.ClsDatiEmittente

Public NotInheritable Class ClsEmittenteFattura

    Private Sub New()
    End Sub

    Public Shared Function CaricaDati() As DatiEmittente

        Dim dati As New DatiEmittente

        Dim appFolder As String =
            Application.StartupPath

        Dim filePath As String =
            Path.Combine(
                appFolder,
                "EmFat",
                "EmittenteFattura.txt")

        If File.Exists(filePath) Then

            Using reader As New StreamReader(filePath)

                dati.Nome =
                    reader.ReadLine()

                dati.Indirizzo =
                    reader.ReadLine()

                dati.Telefono =
                    reader.ReadLine()

                dati.PartitaIVA =
                    reader.ReadLine()

                dati.LogoPath =
                    reader.ReadLine()

            End Using

        Else

            RJMessageBox.Show("File EmittenteFattura.txt non trovato.")


        End If

        Return dati

    End Function

End Class




