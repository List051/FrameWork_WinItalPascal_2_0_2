Module ModColTesto


#Region "Colora RichTextBox"
    Public Sub ColoraRiga(rtb As RichTextBox, numeroRiga As Integer, colore As Color)
        If numeroRiga < 0 Or numeroRiga >= rtb.Lines.Length Then Exit Sub

        Dim testoRiga As String = rtb.Lines(numeroRiga)
        Dim start As Integer = rtb.GetFirstCharIndexFromLine(numeroRiga)

        rtb.Select(start, testoRiga.Length)
        rtb.SelectionColor = colore
    End Sub
    Public Sub ColoraRigheConParola(rtb As RichTextBox, parola As String, colore As Color)

        For i As Integer = 0 To rtb.Lines.Length - 1
            Dim riga As String = rtb.Lines(i)

            If riga.IndexOf(parola, StringComparison.OrdinalIgnoreCase) >= 0 Then
                ColoraRiga(rtb, i, colore)
            End If
        Next

    End Sub
    Public Sub ColoraRigheConComm(rtb As RichTextBox, parola As String, colore As Color)

        For i As Integer = 0 To rtb.Lines.Length - 1
            Dim riga As String = rtb.Lines(i)

            If riga.Contains(parola) Then
                Dim start As Integer = rtb.GetFirstCharIndexFromLine(i)
                rtb.Select(start, riga.Length)
                rtb.SelectionColor = colore
            End If
        Next

        rtb.Select(0, 0) ' deseleziona
    End Sub

    Public Sub EvidenziaRiga(rtb As RichTextBox, numeroRiga As Integer, coloreSfondo As Color)

        If numeroRiga < 0 Or numeroRiga >= rtb.Lines.Length Then Exit Sub

        Dim testoRiga As String = rtb.Lines(numeroRiga)
        Dim start As Integer = rtb.GetFirstCharIndexFromLine(numeroRiga)

        rtb.Select(start, testoRiga.Length)
        rtb.SelectionBackColor = coloreSfondo
    End Sub
    Public Sub ColoraParola(rtb As RichTextBox, parola As String, colore As Color)

        If String.IsNullOrWhiteSpace(parola) Then Exit Sub

        Dim start As Integer = 0
        Dim index As Integer = 0

        While index <> -1
            index = rtb.Text.IndexOf(parola, start, StringComparison.OrdinalIgnoreCase)

            If index <> -1 Then
                rtb.Select(index, parola.Length)
                rtb.SelectionColor = colore

                start = index + parola.Length
            End If
        End While

        rtb.Select(0, 0) ' deseleziona
    End Sub

    Public Sub ColoraPiuParole(rtb As RichTextBox, parole As List(Of String), colore As Color)

        For Each p In parole
            ColoraParola(rtb, p, colore)
        Next

    End Sub


    Public Sub ColoraParolaPlus(rtb As RichTextBox, parola As String, colore As Color)

        If String.IsNullOrWhiteSpace(parola) Then Exit Sub

        Dim start As Integer = 0
        Dim index As Integer = 0

        While index <> -1
            index = rtb.Text.IndexOf(parola, start, StringComparison.OrdinalIgnoreCase)

            If index <> -1 Then
                rtb.Select(index, parola.Length)
                rtb.SelectionColor = colore

                start = index + parola.Length
            End If
        End While

        rtb.Select(0, 0)
    End Sub

    Public Sub ColoraParoleColori(rtb As RichTextBox, paroleColori As Dictionary(Of String, Color))

        For Each kvp In paroleColori
            Dim parola As String = kvp.Key
            Dim colore As Color = kvp.Value

            ColoraParolaPlus(rtb, parola, colore)
        Next

    End Sub

    ' esempio
    '    Dim paroleColori As New Dictionary(Of String, Color) From {
    '    {"ERROR", Color.Red},
    '    {"WARNING", Color.Orange},
    '    {"OK", Color.Green},
    '    {"INFO", Color.Blue}
    '}

    'ColoraParoleColori(RichTextBox1, paroleColori)

    ' mentre scrivi  
    'Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    '    Dim paroleColori As New Dictionary(Of String, Color) From {
    '    {"ERROR", Color.Red},
    '    {"WARNING", Color.Orange},
    '    {"OK", Color.Green}
    '}

    '    Dim pos As Integer = RichTextBox1.SelectionStart

    '    ColoraParoleColori(RichTextBox1, paroleColori)

    '    RichTextBox1.SelectionStart = pos
    '    RichTextBox1.SelectionColor = Color.Black
    'End Sub


#End Region
End Module
