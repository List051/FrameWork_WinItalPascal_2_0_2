Imports WinItalPascal

Module ModColoriDgv

    Public Sub ColoraDgv(ParamArray griglie() As DataGridView)

        For Each dgv In griglie
            If dgv IsNot Nothing AndAlso dgv.Columns.Count > 0 Then
                GridUtility.ColoraColonne(
                    dgv,
                    Colori.ColoreTipo.Giallo,
                    Colori.ColoreTipo.VerdeChiaro,
                    Colori.ColoreTipo.Azzurro
                )
            End If
        Next

    End Sub
    ' Utilizzo 
    '  ColoraDgv(OrdiniDataGrid, ClientiDataGrid, FatturaDataGrid)
    '  ColoraDgv(FatturaDataGrid)

#Region "Opzione dei Colori"
    Public Sub ColoraDgvColorato(
    colori As (Colori.ColoreTipo, Colori.ColoreTipo, Colori.ColoreTipo),
    ParamArray griglie() As DataGridView)

        For Each dgv In griglie
            If dgv IsNot Nothing AndAlso dgv.Columns.Count > 0 Then
                GridUtility.ColoraColonne(
                dgv,
                colori.Item1,
                colori.Item2,
                colori.Item3
            )
            End If
        Next

    End Sub

    ' utilizzo
    'ColoraDgvColorato((Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro),OrdiniDataGrid, ClientiDataGrid, FatturaDataGrid)

#End Region

#Region "Colora Colonne Specifiche"
    Public Sub ColoraColonneSpec(
        dgv As DataGridView,
        colonne() As Integer,
        Optional coloreSfondo As Color = Nothing,
        Optional coloreTesto As Color = Nothing)

        If dgv Is Nothing OrElse dgv.Columns.Count = 0 Then Exit Sub

        ' Colori di default
        If coloreSfondo = Nothing Then coloreSfondo = Color.LightYellow
        If coloreTesto = Nothing Then coloreTesto = Color.Black

        AddHandler dgv.CellFormatting,
        Sub(sender As Object, e As DataGridViewCellFormattingEventArgs)

            If colonne.Contains(e.ColumnIndex) Then
                e.CellStyle.BackColor = coloreSfondo
                e.CellStyle.ForeColor = coloreTesto
            End If

        End Sub

    End Sub

    ' Esempi di utilizzo
    ' ColoraColonneSpec(ClientiDataGrid,{1, 3},Color.Aquamarine, Color.DarkBlue)
    ' ColoraColonneSpec(OrdiniDataGrid, {0, 2, 5})  ' Sfondo giallo chiaro, testo nero

#End Region

End Module






