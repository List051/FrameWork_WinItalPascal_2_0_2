'Imports WinItalPascal

'Module ModColoriDgv

'    Public Sub ColoraDgv(ParamArray griglie() As DataGridView)

'        For Each dgv In griglie
'            If dgv IsNot Nothing AndAlso dgv.Columns.Count > 0 Then
'                GridUtility.ColoraColonne(
'                    dgv,
'                    Colori.ColoreTipo.Giallo,
'                    Colori.ColoreTipo.VerdeChiaro,
'                    Colori.ColoreTipo.Azzurro
'                )
'            End If
'        Next

'    End Sub
'    ' Utilizzo 
'    '  ColoraDgv(OrdiniDataGrid, ClientiDataGrid, FatturaDataGrid)
'    '  ColoraDgv(FatturaDataGrid)

'#Region "Opzione dei Colori"
'    Public Sub ColoraDgvColorato(
'    colori As (Colori.ColoreTipo, Colori.ColoreTipo, Colori.ColoreTipo),
'    ParamArray griglie() As DataGridView)

'        For Each dgv In griglie
'            If dgv IsNot Nothing AndAlso dgv.Columns.Count > 0 Then
'                GridUtility.ColoraColonne(
'                dgv,
'                colori.Item1,
'                colori.Item2,
'                colori.Item3
'            )
'            End If
'        Next

'    End Sub

'    ' utilizzo
'    'ColoraDgvColorato((Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro),OrdiniDataGrid, ClientiDataGrid, FatturaDataGrid)

'#End Region

'#Region "Colora Colonne Specifiche"
'    Public Sub ColoraColonneSpec(
'        dgv As DataGridView,
'        colonne() As Integer,
'        Optional coloreSfondo As Color = Nothing,
'        Optional coloreTesto As Color = Nothing)

'        If dgv Is Nothing OrElse dgv.Columns.Count = 0 Then Exit Sub

'        ' Colori di default
'        If coloreSfondo = Nothing Then coloreSfondo = Color.LightYellow
'        If coloreTesto = Nothing Then coloreTesto = Color.Black

'        AddHandler dgv.CellFormatting,
'        Sub(sender As Object, e As DataGridViewCellFormattingEventArgs)

'            If colonne.Contains(e.ColumnIndex) Then
'                e.CellStyle.BackColor = coloreSfondo
'                e.CellStyle.ForeColor = coloreTesto
'            End If

'        End Sub

'    End Sub

'    ' Esempi di utilizzo
'    ' ColoraColonneSpec(ClientiDataGrid,{1, 3},Color.Aquamarine, Color.DarkBlue)
'    ' ColoraColonneSpec(OrdiniDataGrid, {0, 2, 5})  ' Sfondo giallo chiaro, testo nero

'#End Region

'#Region "Altri Colori"
'    Public Enum TemaM
'        Pastello
'        SoftBlu
'        SoftVerde
'    End Enum

'    Public Sub ColoraDgvMod(
'    dgv As DataGridView,
'    tema As TemaM)

'        If dgv Is Nothing OrElse dgv.Columns.Count = 0 Then Exit Sub

'        Dim c1 As Color
'        Dim c2 As Color
'        Dim c3 As Color

'        Select Case tema

'            Case TemaM.Pastello
'                c1 = Color.FromArgb(255, 204, 212)   ' Rosa pastello
'                c2 = Color.FromArgb(204, 255, 229)   ' Verde menta
'                c3 = Color.FromArgb(204, 236, 255)   ' Azzurro pastello

'            Case TemaM.SoftBlu
'                c1 = Color.FromArgb(220, 235, 255)
'                c2 = Color.FromArgb(200, 220, 255)
'                c3 = Color.FromArgb(180, 205, 255)

'            Case TemaM.SoftVerde
'                c1 = Color.FromArgb(220, 255, 220)
'                c2 = Color.FromArgb(200, 240, 200)
'                c3 = Color.FromArgb(180, 225, 180)

'        End Select

'        For i As Integer = 0 To dgv.Columns.Count - 1
'            Dim col = dgv.Columns(i)

'            Select Case i Mod 3
'                Case 0 : col.DefaultCellStyle.BackColor = c1
'                Case 1 : col.DefaultCellStyle.BackColor = c2
'                Case 2 : col.DefaultCellStyle.BackColor = c3
'            End Select

'            col.DefaultCellStyle.ForeColor = Color.Black
'        Next

'    End Sub

'    Public Sub ColoraDgvModMulti(
'    tema As TemaM,
'    ParamArray griglie() As DataGridView)

'        For Each dgv In griglie
'            ColoraDgvMod(dgv, tema)
'        Next

'    End Sub

'    '  ColoraDgvMod(FatturaDataGrid, TemaM.Pastello)

'    ' ColoraDgvModMulti(TemaM.SoftBlu,OrdiniDataGrid,ClientiDataGrid,FatturaDataGrid)

'#End Region

'#Region "Colora Colonne Specifiche Mod"

'    Public Enum TemaProf
'        Of24
'    End Enum

'    Public Sub ColoraDgvOf24(
'    dgv As DataGridView,
'    tema As TemaProf)

'        If dgv Is Nothing OrElse dgv.Columns.Count = 0 Then Exit Sub

'        Dim c1 As Color
'        Dim c2 As Color
'        Dim c3 As Color

'        Select Case tema

'            Case TemaProf.Of24
'                c1 = Color.FromArgb(221, 235, 247)   ' Office Blue
'                c2 = Color.FromArgb(242, 242, 242)   ' Office Gray
'                c3 = Color.FromArgb(255, 242, 204)   ' Office Accent

'        End Select

'        For i As Integer = 0 To dgv.Columns.Count - 1
'            Dim col = dgv.Columns(i)

'            Select Case i Mod 3
'                Case 0 : col.DefaultCellStyle.BackColor = c1
'                Case 1 : col.DefaultCellStyle.BackColor = c2
'                Case 2 : col.DefaultCellStyle.BackColor = c3
'            End Select

'            col.DefaultCellStyle.ForeColor = Color.Black
'        Next

'    End Sub

'    Public Sub ColoraDgvOf24Multi(
'    tema As TemaProf,
'    ParamArray griglie() As DataGridView)

'        For Each dgv In griglie
'            ColoraDgvOf24(dgv, tema)
'        Next

'    End Sub
'    ' ColoraDgvOf24(FatturaDataGrid, TemaProf.Of24)
'    '  ColoraDgvOfficeMulti(TemaProf.Of24,OrdiniDataGrid, ClientiDataGrid,FatturaDataGrid)
'#End Region

'#Region "Reset Colora Colonne "
'    Public Sub ResetColoriDgv(ParamArray griglie() As DataGridView)

'        For Each dgv In griglie
'            If dgv Is Nothing OrElse dgv.Columns.Count = 0 Then Continue For

'            ' Reset colori delle colonne
'            For Each col As DataGridViewColumn In dgv.Columns
'                col.DefaultCellStyle.BackColor = Color.White
'                col.DefaultCellStyle.ForeColor = Color.Black
'            Next

'            ' Reset colori delle celle (per sicurezza)
'            For Each row As DataGridViewRow In dgv.Rows
'                For Each cell As DataGridViewCell In row.Cells
'                    cell.Style.BackColor = Color.White
'                    cell.Style.ForeColor = Color.Black
'                Next
'            Next

'            ' Rimuove eventuali handler aggiunti da ColoraColonneSpec
'            RemoveHandler dgv.CellFormatting, Nothing
'        Next

'    End Sub
'    ' utilizzo
'    ' ripristino sfondo bianco, testo nero
'    'ResetColoriDgv(OrdiniDataGrid, ClientiDataGrid, FatturaDataGrid)
'#End Region

'#Region "Colora Colonne qualsiasi colore"

'    ' ============================================
'    '   COLORI PERSONALIZZATI con colonne saltate
'    ' ============================================

'    Public Enum ColSpec
'        Salta
'    End Enum

'    Public Sub ColoraDgvCustom(
'    dgv As DataGridView,
'    ParamArray colori() As Object)

'        If dgv Is Nothing OrElse dgv.Columns.Count = 0 Then Exit Sub
'        If colori Is Nothing OrElse colori.Length = 0 Then Exit Sub

'        For i As Integer = 0 To dgv.Columns.Count - 1

'            If i < colori.Length Then

'                Dim val = colori(i)

'                ' Se l'utente ha scritto Salta → non colorare
'                If TypeOf val Is ColSpec AndAlso DirectCast(val, ColSpec) = ColSpec.Salta Then
'                    dgv.Columns(i).DefaultCellStyle.BackColor = Color.White
'                    dgv.Columns(i).DefaultCellStyle.ForeColor = Color.Black
'                    Continue For
'                End If

'                ' Se è un colore valido → colorare
'                If TypeOf val Is Color Then
'                    dgv.Columns(i).DefaultCellStyle.BackColor = DirectCast(val, Color)
'                    dgv.Columns(i).DefaultCellStyle.ForeColor = Color.Black
'                    Continue For
'                End If

'            End If

'            ' Colonna senza valore → reset
'            dgv.Columns(i).DefaultCellStyle.BackColor = Color.White
'            dgv.Columns(i).DefaultCellStyle.ForeColor = Color.Black

'        Next

'    End Sub
'    ' utilizzo
'    ' ColoraDgvCustom(OrdiniDataGrid, Color.LightBlue, ColoSpec.Salta, Color.Light)

'    ' multi giridview
'    Public Sub ColoraDgvCustomM(
'    colori() As Object,
'    ParamArray griglie() As DataGridView)

'        For Each dgv In griglie
'            ' Espande l’array di colori nel ParamArray
'            ColoraDgvCustom(dgv, colori)
'        Next

'    End Sub

'    ' utilizzo
'    '        ColoraDgvCustomM({Color.LightBlue, Color.LightGreen, Color.LightYellow},OrdiniDataGrid,ClientiDataGrid)

'#End Region

'End Module






