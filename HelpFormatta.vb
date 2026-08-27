
Imports System.Drawing
Imports System.Windows.Forms

Public Class HelpFormatta

    Public Shared Sub AddNote(rtb As RichTextBox, testo As String)

        With rtb

            ' Titolo NOTE
            .SelectionBackColor = Color.LightSteelBlue
            .SelectionColor = Color.Navy
            .SelectionFont = New Font("Segoe UI", 10, FontStyle.Bold)

            .AppendText(" NOTE ")
            .AppendText(vbCrLf)

            ' Corpo
            .SelectionBackColor = Color.White
            .SelectionColor = Color.RoyalBlue
            .SelectionFont = New Font("Segoe UI", 10, FontStyle.Bold)

            .AppendText("▶ ")

            .SelectionColor = Color.Black
            .SelectionFont = New Font("Segoe UI", 10)

            .AppendText(testo)

            .AppendText(vbCrLf & vbCrLf)

        End With

    End Sub


    Public Shared Sub AddTitle(rtb As RichTextBox, titolo As String)

        With rtb

            .SelectionColor = Color.DarkBlue
            .SelectionFont = New Font("Segoe UI", 12, FontStyle.Bold)

            .AppendText(titolo)

            .AppendText(vbCrLf & vbCrLf)

        End With

    End Sub


    Public Shared Sub AddNew(rtb As RichTextBox, testo As String)

        With rtb

            .SelectionColor = Color.Green
            .SelectionFont = New Font("Segoe UI", 10, FontStyle.Bold)

            .AppendText("★ ")

            .SelectionColor = Color.Black
            .AppendText(testo)

            .AppendText(vbCrLf)

        End With

    End Sub

    Public Shared Sub AddMessage(
        rtb As RichTextBox,
        icona As String,
        testo As String,
        colore As Color)

        With rtb

            .SelectionColor = colore
            .SelectionFont = New Font("Segoe UI", 10, FontStyle.Bold)
            .AppendText(icona & " ")

            .SelectionColor = Color.Black
            .SelectionFont = New Font("Segoe UI", 10)
            .AppendText(testo)

            .AppendText(vbCrLf)

        End With

    End Sub
End Class