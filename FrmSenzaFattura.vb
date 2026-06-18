Imports WinItalPascal
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports CustomMessageBoxVB
Public Class FrmSenzaFattura


    Private Sub FrmSenzaFattura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'WinDBGdRDataSet.Clienti'. È possibile spostarla o rimuoverla se necessario.
        Me.ClientiTableAdapter.Fill(Me.WinDBGdRDataSet.Clienti)
        'TODO: questa riga di codice carica i dati nella tabella 'WinDBGdRDataSet.Fattura'. È possibile spostarla o rimuoverla se necessario.
        Me.FatturaTableAdapter.Fill(Me.WinDBGdRDataSet.Fattura)
        ' il macantiDataGrid non lo visualizzo, è Visible=False

        'TODO: questa riga di codice carica i dati nella tabella 'WinDBGdRDataSet.Ordini'. È possibile spostarla o rimuoverla se necessario.
        Me.OrdiniTableAdapter.Fill(Me.WinDBGdRDataSet.Ordini)
        FrmTitolo.CTitolo(Me, "Elenco Ordini senza Fattura")
        Dim qryFat As String = "Select * from Fattura"


        DataGVLoad.ApriDGV(MancantiDataGrid, qryFat)
        ' esegui la queri che segue
        ' in questa fase funziona benissimo
        Dim qry As String = "Select Ordini.IDOrd, Ordini.IDCliOrd, Ordini.Mat,Ordini.QtaOrd,Ordini.PrezzoOrd,Ordini.ImportoOrd
From Ordini LEFT OUTER Join
                  Fattura On Ordini.IDOrd = Fattura.IDOrd
Where (Fattura.IDOrd Is NULL)"
        DataGVLoad.ApriDGV(OrdNoFatDataGrid, qry)

    End Sub


    Private Function TrovaClienteById(idCli As Integer) As String
        For Each r As DataGridViewRow In ClientiDataGrid.Rows
            If Not r.IsNewRow Then
                Dim id As Integer
                If Integer.TryParse(r.Cells(0).Value.ToString(), id) AndAlso id = idCli Then
                    Return r.Cells(1).Value.ToString()   ' nome cliente
                End If
            End If
        Next
        Return ""
    End Function

    Private Sub OrdNoFatDataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles OrdNoFatDataGrid.SelectionChanged
        If OrdNoFatDataGrid.CurrentRow Is Nothing Then Exit Sub

        Dim idCliOrd As Integer

        If Not Integer.TryParse(OrdNoFatDataGrid.CurrentRow.Cells(1).Value.ToString(), idCliOrd) Then
            LabelNomeFat.Text = "ID cliente non valido"
            Exit Sub
        End If

        Dim nomeCli As String = TrovaClienteById(idCliOrd)

        If nomeCli <> "" Then
            LabelNomeFat.Text = nomeCli
        Else
            RJMessageBox.Show("Non ci sono Ordini da Fatturare  " & LabelNomeFat.Text, "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'LabelNomeFat.Text = "Cliente non trovato"
        End If
    End Sub

#Region "Stampa Senza Fattura"

    Private Sub RjBtnStamaSenzaFattura_Click(sender As Object, e As EventArgs) Handles RjBtnStamaSenzaFattura.Click
        Try
            Dim doc As New iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 40, 40, 40, 40)

            Dim nomeFile As String = "Ordini_Senza_Fattura_" &
                         DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"

            ' --- Cartella di salvataggio file ---

            Dim cartella As String = OttieniPercorsoSalvataggio()
            Dim Percorso As String = Path.Combine(cartella, nomeFile)
            Dim writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, New System.IO.FileStream(Percorso, System.IO.FileMode.Create))
            doc.Open()

            ' --- BARRA COLORATA ---
            Dim barra As New iTextSharp.text.pdf.PdfPTable(1)
            barra.WidthPercentage = 100

            Dim cellBarra As New iTextSharp.text.pdf.PdfPCell()
            cellBarra.BackgroundColor = New iTextSharp.text.BaseColor(30, 144, 255)
            cellBarra.FixedHeight = 20
            cellBarra.Border = iTextSharp.text.Rectangle.NO_BORDER
            barra.AddCell(cellBarra)

            doc.Add(barra)

            ' --- TITOLO ---
            Dim titolo As New iTextSharp.text.Paragraph(
            "ELENCO ORDINI SENZA FATTURA",
            New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)
        )
            titolo.Alignment = iTextSharp.text.Element.ALIGN_CENTER
            titolo.SpacingAfter = 15
            doc.Add(titolo)

            ' --- DATA E ORA DI STAMPA ---
            Dim dataOra As New iTextSharp.text.Paragraph(
            "Stampato il: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
            New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.ITALIC)
        )
            dataOra.Alignment = iTextSharp.text.Element.ALIGN_RIGHT
            dataOra.SpacingAfter = 20
            doc.Add(dataOra)

            ' --- TABELLA ---
            Dim tab As New iTextSharp.text.pdf.PdfPTable(7)
            tab.WidthPercentage = 100
            tab.SetWidths({10, 15, 25, 25, 10, 15, 15})

            ' INTESTAZIONI
            AggiungiCella(tab, "ID Ord", True)
            AggiungiCella(tab, "ID Cliente", True)
            AggiungiCella(tab, "Nome Cliente", True)
            AggiungiCella(tab, "Materiale", True)
            AggiungiCella(tab, "Qta", True)
            AggiungiCella(tab, "Prezzo", True)
            AggiungiCella(tab, "Importo", True)

            ' --- RIGHE ---
            Dim totale As Decimal = 0
            Dim rowIndex As Integer = 0

            For Each r As DataGridViewRow In OrdNoFatDataGrid.Rows
                If Not r.IsNewRow Then

                    Dim idCli As Integer = CInt(r.Cells("IDCliOrd").Value)
                    Dim nomeCli As String = GetNomeCliente(idCli)

                    Dim bg As iTextSharp.text.BaseColor =
                    If(rowIndex Mod 2 = 0,
                       New iTextSharp.text.BaseColor(245, 245, 245),
                       iTextSharp.text.BaseColor.WHITE)

                    AggiungiCella(tab, r.Cells("IDOrd").Value.ToString(), False, bg)
                    AggiungiCella(tab, idCli.ToString(), False, bg)
                    AggiungiCella(tab, nomeCli, False, bg)
                    AggiungiCella(tab, r.Cells("Mat").Value.ToString(), False, bg)
                    AggiungiCella(tab, r.Cells("QtaOrd").Value.ToString(), False, bg)
                    AggiungiCella(tab, FormatCurrency(r.Cells("PrezzoOrd").Value), False, bg)
                    AggiungiCella(tab, FormatCurrency(r.Cells("ImportoOrd").Value), False, bg)

                    totale += CDec(r.Cells("ImportoOrd").Value)
                    rowIndex += 1
                End If
            Next

            doc.Add(tab)

            ' --- TOTALE GENERALE ---
            Dim totPar As New iTextSharp.text.Paragraph(
            "Totale generale: " & FormatCurrency(totale),
            New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD)
        )
            totPar.Alignment = iTextSharp.text.Element.ALIGN_RIGHT
            totPar.SpacingBefore = 15
            totPar.SpacingAfter = 10
            doc.Add(totPar)

            doc.Close()
            writer.Close()

            RJMessageBox.Show("PDF generato correttamente:" & vbCrLf & nomeFile,
                        "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            RJMessageBox.Show("Errore durante la creazione del PDF: " & ex.Message)
        End Try
    End Sub

    Private Function GetNomeCliente(idCli As Integer) As String
        For Each r As DataGridViewRow In ClientiDataGrid.Rows
            If Not r.IsNewRow Then
                If CInt(r.Cells(0).Value) = idCli Then
                    Return r.Cells(1).Value.ToString()   ' Nome cliente
                End If
            End If
        Next
        Return "Sconosciuto"
    End Function

    Private Sub AggiungiCella(tab As iTextSharp.text.pdf.PdfPTable,
                          testo As String,
                          Optional bold As Boolean = False,
                          Optional bgColor As iTextSharp.text.BaseColor = Nothing)

        Dim f As iTextSharp.text.Font =
        If(bold,
           New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD),
           New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10))

        Dim cell As New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(testo, f))

        cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
        cell.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE
        cell.Padding = 5
        cell.BorderWidth = 0.5

        If bgColor IsNot Nothing Then
            cell.BackgroundColor = bgColor
        End If

        tab.AddCell(cell)
    End Sub

    Private Sub RjCBtnCambiaCartella_Click(sender As Object, e As EventArgs) Handles RjCBtnCambiaCartella.Click
        Dim filePath As String = Path.Combine(Application.StartupPath, "PercorsoSalvataggio.txt")

        Using dlg As New FolderBrowserDialog
            dlg.Description = "Seleziona la nuova cartella dove salvare le fatture"
            dlg.ShowNewFolderButton = True

            If dlg.ShowDialog() = DialogResult.OK Then
                File.WriteAllText(filePath, dlg.SelectedPath)
                RJMessageBox.Show("Nuova cartella salvata correttamente:" & vbCrLf & dlg.SelectedPath)
            End If
        End Using
    End Sub

    Private Function OttieniPercorsoSalvataggio() As String
        Dim filePath As String = Path.Combine(Application.StartupPath, "PercorsoSalvataggio.txt")

        ' Se il file esiste, leggo il percorso salvato
        If File.Exists(filePath) Then
            Dim percorsoSalvato = File.ReadAllText(filePath).Trim()
            If Directory.Exists(percorsoSalvato) Then
                Return percorsoSalvato
            End If
        End If

        ' Se non esiste, chiedo all'utente
        Using dlg As New FolderBrowserDialog
            dlg.Description = "Seleziona la cartella dove salvare le fatture"
            dlg.ShowNewFolderButton = True

            If dlg.ShowDialog() = DialogResult.OK Then
                ' Salvo il percorso scelto
                File.WriteAllText(filePath, dlg.SelectedPath)
                Return dlg.SelectedPath
            Else
                ' Se annulla, salvo sul Desktop
                Return Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            End If
        End Using
    End Function

#End Region


End Class