
Imports System.Text.RegularExpressions

Module ColoraTesto

#Region "Private"

    Private Sub SalvaSelezione(rtb As RichTextBox,
                               ByRef start As Integer,
                               ByRef length As Integer)

        start = rtb.SelectionStart
        length = rtb.SelectionLength

    End Sub

    Private Sub RipristinaSelezione(rtb As RichTextBox,
                                    start As Integer,
                                    length As Integer)

        rtb.Select(start, length)

    End Sub

#End Region

#Region "Righe"

    Public Sub ColoraRiga(rtb As RichTextBox,
                          numeroRiga As Integer,
                          colore As Color)

        If numeroRiga < 0 OrElse numeroRiga >= rtb.Lines.Length Then Exit Sub

        Dim pos As Integer
        Dim len As Integer

        SalvaSelezione(rtb, pos, len)

        Dim testo = rtb.Lines(numeroRiga)
        Dim start = rtb.GetFirstCharIndexFromLine(numeroRiga)

        rtb.Select(start, testo.Length)
        rtb.SelectionColor = colore

        RipristinaSelezione(rtb, pos, len)

    End Sub

    Public Sub EvidenziaRiga(rtb As RichTextBox,
                             numeroRiga As Integer,
                             colore As Color)

        If numeroRiga < 0 OrElse numeroRiga >= rtb.Lines.Length Then Exit Sub

        Dim pos As Integer
        Dim len As Integer

        SalvaSelezione(rtb, pos, len)

        Dim testo = rtb.Lines(numeroRiga)
        Dim start = rtb.GetFirstCharIndexFromLine(numeroRiga)

        rtb.Select(start, testo.Length)
        rtb.SelectionBackColor = colore

        RipristinaSelezione(rtb, pos, len)

    End Sub

    Public Sub ColoraRigheConParola(rtb As RichTextBox,
                                    parola As String,
                                    colore As Color)

        For i = 0 To rtb.Lines.Length - 1

            If rtb.Lines(i).IndexOf(parola,
                    StringComparison.OrdinalIgnoreCase) >= 0 Then

                ColoraRiga(rtb, i, colore)

            End If

        Next

    End Sub

    Public Sub ColoraRigheConCommento(rtb As RichTextBox,
                                      commento As String,
                                      colore As Color)

        Dim pos As Integer
        Dim len As Integer

        SalvaSelezione(rtb, pos, len)

        For i = 0 To rtb.Lines.Length - 1

            Dim riga = rtb.Lines(i)

            Dim idx = riga.IndexOf(commento)

            If idx >= 0 Then

                Dim start = rtb.GetFirstCharIndexFromLine(i) + idx

                rtb.Select(start, riga.Length - idx)
                rtb.SelectionColor = colore

            End If

        Next

        RipristinaSelezione(rtb, pos, len)

    End Sub

#End Region

#Region "Parole"

    Public Sub ColoraParola(rtb As RichTextBox,
                            parola As String,
                            colore As Color)

        If String.IsNullOrWhiteSpace(parola) Then Exit Sub

        Dim pos As Integer
        Dim len As Integer

        SalvaSelezione(rtb, pos, len)

        Dim pattern = "\b" & Regex.Escape(parola) & "\b"

        For Each m As Match In Regex.Matches(rtb.Text,
                                             pattern,
                                             RegexOptions.IgnoreCase)

            rtb.Select(m.Index, m.Length)
            rtb.SelectionColor = colore

        Next

        RipristinaSelezione(rtb, pos, len)

    End Sub

    Public Sub ColoraParole(rtb As RichTextBox,
                            parole As IEnumerable(Of String),
                            colore As Color)

        If parole Is Nothing Then Exit Sub

        Dim elenco = parole.
            Where(Function(p) Not String.IsNullOrWhiteSpace(p)).
            Select(Function(p) Regex.Escape(p)).
            ToList()

        If elenco.Count = 0 Then Exit Sub

        Dim pos As Integer
        Dim len As Integer

        SalvaSelezione(rtb, pos, len)

        Dim pattern = "\b(" &
                      String.Join("|", elenco) &
                      ")\b"

        For Each m As Match In Regex.Matches(rtb.Text,
                                             pattern,
                                             RegexOptions.IgnoreCase)

            rtb.Select(m.Index, m.Length)
            rtb.SelectionColor = colore

        Next

        RipristinaSelezione(rtb, pos, len)

    End Sub

    Public Sub ColoraParole(rtb As RichTextBox,
                            paroleColori As Dictionary(Of String, Color))

        If paroleColori Is Nothing Then Exit Sub

        For Each kv In paroleColori

            ColoraParola(rtb, kv.Key, kv.Value)

        Next

    End Sub

#End Region

#Region "Esempio di utilizzo"
    '    Colora.Testo(rtb, "Help", Color.Blue)

    '   Colora.Riga(rtb, 10, Color.Red)

    '   Colora.Commenti(rtb, "'", Color.Green)

    '   Colora.Parole(rtb,
    '    {"Core", "Database", "Forms"},
    '    Color.Blue)

    '   Colora.SfondoRiga(rtb, 5, Color.LightYellow)

#End Region

End Module
