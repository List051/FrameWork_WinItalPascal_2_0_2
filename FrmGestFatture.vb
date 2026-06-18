Imports System.Configuration
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Imports CustomMessageBoxVB
Imports WinItalPascal

' ho eliminato il modulo perchè inutile
'Imports CreaFiltroDvg.ClsDatiEmittente


Public Class FrmGestFatture

    ' inserisco variabili
    Public NomeEmittente As String
    Public IndirizzoEmittente As String

    ' Public DatiEmittenteCorrente As DatiEmittente -  Inutile

    Public Property ClienteNome As String
    Public Property ClienteIndirizzo As String
    Public Property ClienteCapCitta As String
    Public Property ClientePIVA As String


    Private Sub FrmGestFatture_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ScreenUtility.FullScreen(Me)
        FrmTitolo.CTitolo(Me, "Gestione Fatture - Controlla Fatture NON emesse")




        'TODO: questa riga di codice carica i dati nella tabella 'WinDBGdRDataSet.Clienti'. È possibile spostarla o rimuoverla se necessario.
        Me.ClientiTableAdapter.Fill(Me.WinDBGdRDataSet.Clienti)
        GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)
        'TODO: questa riga di codice carica i dati nella tabella 'WinDBGdRDataSet.Ordini'. È possibile spostarla o rimuoverla se necessario.
        Me.OrdiniTableAdapter.Fill(Me.WinDBGdRDataSet.Ordini)
        GridUtility.ColoraColonne(OrdDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)
        'TODO: questa riga di codice carica i dati nella tabella 'WinDBGdRDataSet.Fattura'. È possibile spostarla o rimuoverla se necessario.
        Me.FatturaTableAdapter.Fill(Me.WinDBGdRDataSet.Fattura)
        GridUtility.ColoraColonne(FatDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

        ' Carica immagine da My.Resources
        ' Devo inserire in questo modo affinche non interferisce con iTextySharp
        Dim imgSalva As System.Drawing.Image = My.Resources.chek

        PopupHelper.AttachPopup(RjSalvaFattura, vbCrLf & "      Attenzione - Salva Fattura " & vbCrLf & " " & vbCrLf & "Prima di emettere una Nuova Fattura utilizza " & vbCrLf & "il pulsante per cercare Ordini senza fattura" & vbCrLf & "Seleziona il rigo per vedere il Cliente", imgSalva, Color.Aquamarine, Color.Blue)

        ' Messaggio informazione
        PopupHelper.AttachPopup(RjCercaFatKO, vbCrLf & "       Attenzione" & vbCrLf & "Cerca Ordini senza fatturazione" & vbCrLf & "Prosegui cliccando su un rigo per visualizzare" & vbCrLf & "il cliente senza fattura", Nothing, Color.Aquamarine, Color.Blue)

        PopupHelper.AttachPopup(RjCircClienti, vbCrLf & "     Attenzione" & vbCrLf & "     Cliente da fatturare,nella colonna" & vbCrLf & " GIALLA visualizza il numero ID da inserire in fattura", Nothing, Color.Aquamarine, Color.Blue)

        PopupHelper.AttachPopup(RjCircOrdini, vbCrLf & "Attenzione" & vbCrLf & "     Cliente da fatturare,nella colonna" & vbCrLf & " GIALLA visualizza il numero ID da inserire in fattura", Nothing, Color.Aquamarine, Color.Blue)

        PopupHelper.AttachPopup(RjBtnEseguiCalcoli, vbCrLf & "Attenzione Totali Fatture" & vbCrLf & "" & vbCrLf & "Questo è il Totale delle Fatture emesse " & vbCrLf & vbCrLf & "Seleziona il Numero IdCliente e Numero Fattura se vuoi eseguire i calcoli di una fattura da stampare ", Nothing, Color.Aquamarine, Color.Blue)

        PopupHelper.AttachPopup(RjCircBtnCambiaCartella, vbCrLf & " " & vbCrLf & " Seleziona dove vuoi salvare la fattura " & vbCrLf & " In seguito la salverà nella stessa cartella " & vbCrLf & " a meno che non vuoi salvare in una diversa cartella ", Nothing, Color.Aquamarine, Color.Blue)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.FatturaTableAdapter.Fill(Me.WinDBGdRDataSet.Fattura)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub OrdDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrdDataGrid.CellClick
        If e.RowIndex < 0 Then Exit Sub
        ' nel datagrdid IDCliOrdDataGridViewTextBoxColumn = IDCliOrd è la colonna che contiene l'ID del cliente,
        ' se è diverso filtriamo altrimenti resettiamo il filtro
        Dim idCli As Integer =
        CInt(OrdDataGrid.Rows(e.RowIndex).Cells("IDCliOrd").Value)
        ' ResetFiltro(ClientiDataGrid)
        GridFilter.FiltraDgv(
        ClientiDataGrid,
        $"IdClienti = {idCli}")
        GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

    End Sub

    Private Sub RjCircApriDGVQry_Click(sender As Object, e As EventArgs) Handles RjCircApriDGVQry.Click
        ' esegui la queri che segue
        Dim qry As String = "Select Ordini.IDOrd, Ordini.IDCliOrd, Ordini.Mat,Ordini.QtaOrd,Ordini.PrezzoOrd,Ordini.ImportoOrd
From Ordini LEFT OUTER Join
                  Fattura On Ordini.IDOrd = Fattura.IDOrd
Where (Fattura.IDOrd Is NULL)"

        DataGVLoad.ApriDGV(OrdDataGrid, qry) ' decisamente più xsemplice
        LogLeggiScrivi.ScriviLogMsg("La Query è stata eseguita correttamente")

        ' Per leggere Avviso corto va bene
        Dim leggiLog = RJMessageBox.Show(LogReader.ReadLog(), "Apro il file di log")
        GridUtility.ColoraColonne(OrdDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)
    End Sub

    ' Differenze da ApriDGV 
    Private Sub RjCercaFatKO_Click(sender As Object, e As EventArgs) Handles RjCercaFatKO.Click
        ' esegui la queri che segue
        Dim qry As String = "Select Ordini.IDOrd, Ordini.IDCliOrd, Ordini.Mat,Ordini.QtaOrd,Ordini.PrezzoOrd,Ordini.ImportoOrd
From Ordini LEFT OUTER Join
                  Fattura On Ordini.IDOrd = Fattura.IDOrd
Where (Fattura.IDOrd Is NULL)"
        ' *** riscritta dentro ApriDGV **********
        Dim cs As String = ConfigurationManager.ConnectionStrings("MiaConnessione")?.ConnectionString
        If String.IsNullOrEmpty(cs) Then
            Throw New InvalidOperationException("Connection string 'MiaConnessione' non trovata.")
        End If
        Using conn As New SqlClient.SqlConnection(cs)
            Using cmd As New SqlClient.SqlCommand(qry, conn)
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    conn.Open()
                    da.Fill(dt)
                    conn.Close()
                    OrdDataGrid.DataSource = dt
                End Using
            End Using
        End Using
        '************************************************
        GridUtility.ColoraColonne(OrdDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)
    End Sub


    Private Sub RjSalvaFattura_Click(sender As Object, e As EventArgs) Handles RjSalvaFattura.Click
        Try

            Me.Validate()
            Me.FatturaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.WinDBGdRDataSet)
            RJMessageBox.Show("Fattura Salvata correttamente")

            If RJMessageBox.Show("Vuoi eliminare righe per vedere ultimi 10 msg ?", "Elimino messaggi in Log",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) = DialogResult.Yes Then
                ' Non ho messo questo tipo di messaggio in libreria
                LogLeggiScrivi.ClearLog(10) '  da default ClearLog()  mantiene ultimi 5 gruppi
            End If

            Dim Utente As String = Convert.ToString(FatDataGrid.CurrentRow.Cells(5).Value)

            Dim NumeroFattura As String = Convert.ToString(FatDataGrid.CurrentRow.Cells(3).Value)

            LogLeggiScrivi.ScriviLogMsg("Fattura " & NumeroFattura & " di " & Utente & " salvata correttamente.")
            'FrameworkLogger.Log("Fattura " & NumeroFattura & " di " & Utente & " salvata correttamente.")

            GridUtility.ColoraColonne(FatDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

        Catch ex As Exception

            FrameworkLogger.LogError(ex, "SALVA FATTURA")
            RJMessageBox.Show(
            "ERRORE SALVATAGGIO: " & ex.Message,
            "Errore",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub RjBtnLog_Click(sender As Object, e As EventArgs) Handles RjBtnLog.Click
        ' leggo file Log

        RJMessageBox.Show(LogReader.ReadLog(), "Leggo file LOG")
    End Sub

    Private Sub RjCercaFattura_Click(sender As Object, e As EventArgs) Handles RjCercaFattura.Click
        Dim QryNF As String =
    "SELECT * FROM Fattura WHERE IDCli = " & TxtIdCli.Text &
    " AND Num = " & TxtNum.Text

        DataGVLoad.ApriDGV(FatDataGrid, QryNF)
        FatDataGrid.Refresh()

    End Sub

    Private Sub RjTutteFat_Click(sender As Object, e As EventArgs) Handles RjTutteFat.Click
        ' svuoto le textbox
        TxtColli.Clear()
        TxtPrezzo.Clear()
        TxtImporto.Clear()
        LblIVA.Clear()
        TxtTotaleConIVA.Clear()
        TxtNomeFat.Clear()
        ' campi cerca Fattura
        TxtIdCli.Clear()
        TxtNum.Clear()
        ' tutte le fatture
        DataGVLoad.ApriDGV(FatDataGrid, "Select * from Fattura")
        GridUtility.ColoraColonne(FatDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)
    End Sub

    Private Sub FatDataGridview_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles FatDataGrid.CellFormatting
        If e.ColumnIndex = 3 Then ' colonna 4
            e.CellStyle.BackColor = Color.LightGoldenrodYellow
            e.CellStyle.ForeColor = Color.Black
        End If
    End Sub

    Sub CaricaCliente()
        Try
            If ClientiDataGrid.CurrentRow Is Nothing Then Exit Sub

            Dim r As DataGridViewRow = ClientiDataGrid.CurrentRow

            ' Mappatura Cliente da Fatturare
            Dim cliente As String = r.Cells(1).Value?.ToString()
            Dim indirizzo As String = r.Cells(2).Value?.ToString()
            Dim cap As String = r.Cells(5).Value?.ToString()
            Dim citta As String = r.Cells(3).Value?.ToString()
            Dim provincia As String = r.Cells(4).Value?.ToString()
            Dim piva As String = r.Cells(7).Value?.ToString()

            ' Composizione destinazione fattura
            Dim sb As New System.Text.StringBuilder()

            ' Nome cliente
            sb.AppendLine(cliente)
            sb.AppendLine()   ' riga vuota elegante

            ' Indirizzo
            If indirizzo <> "" Then sb.AppendLine(indirizzo)

            ' CAP + Città + Provincia
            Dim rigaLocalita As String = cap & " " & citta
            If provincia <> "" Then rigaLocalita &= " (" & provincia & ")"
            sb.AppendLine(rigaLocalita)

            sb.AppendLine()   ' altra riga vuota elegante

            ' P.IVA o CF
            If piva <> "" Then sb.AppendLine("P.IVA / CF: " & piva)

            TxtNomeFat.Text = sb.ToString()

        Catch ex As Exception
            RJMessageBox.Show(ex.Message)
        End Try
    End Sub

#Region "Calcola Totali Fattura"

    Private Sub CalcolaTotaliFiltrati()

        Dim totQta As Decimal = 0D
        Dim totPrezzo As Decimal = 0D
        Dim totImporto As Decimal = 0D

        For Each r As DataGridViewRow In FatDataGrid.Rows
            If Not r.IsNewRow AndAlso r.Visible Then

                ' Colonna 7 = Qta
                Dim q = r.Cells(7).Value
                If q IsNot Nothing AndAlso Not IsDBNull(q) Then
                    totQta += Convert.ToDecimal(q)
                End If

                ' Colonna 8 = Prezzo
                Dim p = r.Cells(8).Value
                If p IsNot Nothing AndAlso Not IsDBNull(p) Then
                    totPrezzo += Convert.ToDecimal(p)
                End If

                ' Colonna 9 = Importo
                Dim imp = r.Cells(9).Value
                If imp IsNot Nothing AndAlso Not IsDBNull(imp) Then
                    totImporto += Convert.ToDecimal(imp)
                End If

            End If
        Next

        ' Inserimento nelle TextBox
        TxtColli.Text = totQta.ToString("N2")
        TxtPrezzo.Text = totPrezzo.ToString("N2")
        TxtImporto.Text = totImporto.ToString("N2")
        'TxtTotaleImporto.Text = TxtImporto.Text
        ' Calcolo IVA
        Dim percIVA As Decimal = Convert.ToDecimal(TxtIVA.Text) / 100D
        Dim valoreIVA As Decimal = totImporto * percIVA
        LblIVA.Text = valoreIVA.ToString("N2")
        ' Totale con IVA
        TxtTotaleConIVA.Text = (totImporto + valoreIVA).ToString("N2")

    End Sub

    Private Sub RjBtnEseguiCalcoli_Click_1(sender As Object, e As EventArgs) Handles RjBtnEseguiCalcoli.Click

        CalcolaTotaliFiltrati()
        CaricaCliente()
        If TxtIdCli.Text.Trim() = "" AndAlso TxtNum.Text.Trim() = "" Then
            TxtNomeFat.Clear()
            ' Composizione destinazione fattura
            Dim sb As New System.Text.StringBuilder()

            sb.AppendLine()   ' riga vuota elegante
            sb.AppendLine("TOTALE DELLE FATTURE EMESSE")

            TxtNomeFat.Text = sb.ToString()
            FrmEmitFattura.Show()
            ' --- Formattazione elegante ---
            With TxtNomeFat
                .SelectAll()
                .TextAlign = HorizontalAlignment.Center
                .ForeColor = Color.Blue
                .DeselectAll()
            End With

        End If
    End Sub
#End Region

#Region "Stampa Fattura"
    Private Sub RjCircBtnEmittente_Click(sender As Object, e As EventArgs) Handles RjCircBtnEmittente.Click
        FrmEmitFattura.Show()
    End Sub

    Private Sub RjGeneraPDF_Click(sender As Object, e As EventArgs) Handles RjGeneraPDF.Click
        ' modifica per generare PDF
        GeneraPDFTotali()
    End Sub
    Private Sub GeneraPDFTotali()

        ' --- Controllo righe ---
        If FatDataGrid.Rows.Count = 0 Then
            MessageBox.Show("Nessuna riga nella fattura.")
            Exit Sub
        End If

        ' --- Dati generali ---
        Dim r = FatDataGrid.Rows(0)
        Dim Num As Integer = r.Cells("Num").Value
        Dim DataFat As Date = r.Cells("DataFat").Value
        Dim NomeFat As String = r.Cells("NomeFat").Value

        ' --- Cliente ---
        Dim DatiCliente As String = TxtNomeFat.Text

        ' --- Emittente ---
        Dim EmittentePath As String = Path.Combine(Application.StartupPath, "EmFat\EmittenteFattura.txt")
        Dim LogoPath As String = Path.Combine(Application.StartupPath, "EmFat\Logo.png")

        Dim DatiEmittente As String =
        If(File.Exists(EmittentePath),
           File.ReadAllText(EmittentePath),
           "EMITTENTE NON TROVATO")

        ' --- Nome file ---
        Dim NomeFile As String = $"{NomeFat}_Fattura_{Num}_{DataFat:yyyy-MM-dd}.pdf"
        Dim cartella As String = OttieniPercorsoSalvataggio()
        Dim Percorso As String = Path.Combine(cartella, NomeFile)

        ' --- PDF ---
        Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)
        PdfWriter.GetInstance(doc, New FileStream(Percorso, FileMode.Create))
        doc.Open()

        ' --- Logo ---
        If File.Exists(LogoPath) Then
            Dim logo = iTextSharp.text.Image.GetInstance(LogoPath)
            logo.ScaleToFit(120, 120)
            logo.Alignment = Element.ALIGN_LEFT
            doc.Add(logo)
        End If

        ' --- Emittente ---
        doc.Add(New Paragraph(DatiEmittente, FontFactory.GetFont(FontFactory.HELVETICA, 10)))
        doc.Add(New Paragraph(" "))
        doc.Add(New Paragraph(" "))

        ' --- Titolo ---
        Dim titolo As New Paragraph($"FATTURA N° {Num}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20))
        titolo.Alignment = Element.ALIGN_CENTER
        doc.Add(titolo)

        doc.Add(New Paragraph($"Data: {DataFat:dd/MM/yyyy}"))
        doc.Add(New Paragraph(" "))

        ' --- Cliente ---
        doc.Add(New Paragraph("DATI CLIENTE:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)))
        doc.Add(New Paragraph(DatiCliente))
        doc.Add(New Paragraph(" "))

        ' --- Tabella articoli ---
        Dim tab As New PdfPTable(4)
        tab.WidthPercentage = 100
        tab.SetWidths({40, 20, 20, 20})

        tab.AddCell("Descrizione")
        tab.AddCell("Qta")
        tab.AddCell("Prezzo")
        tab.AddCell("Importo")

        For Each row As DataGridViewRow In FatDataGrid.Rows
            If Not row.IsNewRow Then
                tab.AddCell(row.Cells("Descr").Value.ToString())
                tab.AddCell(row.Cells("Qta").Value.ToString())
                tab.AddCell(Format(row.Cells("Prezzo").Value, "0.00"))
                tab.AddCell(Format(row.Cells("Importo").Value, "0.00"))
            End If
        Next

        doc.Add(tab)
        doc.Add(New Paragraph(" "))

        ' --- Tabella Totali Professionale ---
        doc.Add(CreaTabellaTotali())
        doc.Add(New Paragraph(" "))

        ' --- Immagini articoli ---
        For Each row As DataGridViewRow In FatDataGrid.Rows
            If Not row.IsNewRow Then
                Dim ImgPath As String = row.Cells("Image").Value.ToString()
                If File.Exists(ImgPath) Then
                    Dim img = iTextSharp.text.Image.GetInstance(ImgPath)
                    img.ScaleToFit(120, 120)
                    doc.Add(img)
                End If
            End If
        Next

        doc.Close()
        RJMessageBox.Show("PDF generato: " & Percorso)

    End Sub

    Private Function CreaTabellaTotali() As PdfPTable

        ' --- Calcoli ---
        Dim TotaleImponibile As Decimal = Convert.ToDecimal(TxtImporto.Text)
        Dim PercIVA As Decimal = Convert.ToDecimal(TxtIVA.Text) / 100D
        Dim ImportoIVA As Decimal = TotaleImponibile * PercIVA
        Dim TotaleFinale As Decimal = TotaleImponibile + ImportoIVA

        ' --- Tabella ---
        Dim tabTot As New PdfPTable(2)
        tabTot.WidthPercentage = 40
        tabTot.HorizontalAlignment = Element.ALIGN_RIGHT
        tabTot.SetWidths({60, 40})

        Dim fontBold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)
        Dim fontNorm = FontFactory.GetFont(FontFactory.HELVETICA, 11)

        ' --- Righe ---
        tabTot.AddCell(CreaCella("Totale imponibile:", fontBold))
        tabTot.AddCell(CreaCella($"{TotaleImponibile:0.00} €", fontBold, True))

        tabTot.AddCell(CreaCella($"IVA {TxtIVA.Text}%:", fontNorm))
        tabTot.AddCell(CreaCella($"{ImportoIVA:0.00} €", fontNorm, True))

        Dim cellTotale As New PdfPCell(New Phrase("TOTALE FATTURA:", fontBold))
        cellTotale.Border = PdfPCell.TOP_BORDER
        cellTotale.Padding = 6
        tabTot.AddCell(cellTotale)

        Dim cellValoreTotale As New PdfPCell(New Phrase($"{TotaleFinale:0.00} €", fontBold))
        cellValoreTotale.Border = PdfPCell.TOP_BORDER
        cellValoreTotale.Padding = 6
        cellValoreTotale.HorizontalAlignment = Element.ALIGN_RIGHT
        tabTot.AddCell(cellValoreTotale)

        Return tabTot

    End Function
    Private Function CreaCella(testo As String, f As Font, Optional alignRight As Boolean = False) As PdfPCell
        Dim c As New PdfPCell(New Phrase(testo, f))
        c.Border = PdfPCell.NO_BORDER
        c.Padding = 4
        If alignRight Then
            c.HorizontalAlignment = Element.ALIGN_RIGHT
        End If
        Return c
    End Function

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


    Private Sub RjCircBtnCambiaCartella_Click(sender As Object, e As EventArgs) Handles RjCircBtnCambiaCartella.Click
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

    Private Sub FatDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FatDataGrid.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If IsDBNull(FatDataGrid.Rows(e.RowIndex).Cells(1).Value) Then
            Exit Sub
        End If

        ' se èuguale filtriamo altrimenti resettiamo il filtro
        Dim idCli As Integer =
        CInt(FatDataGrid.Rows(e.RowIndex).Cells("IDCli").Value)
        ' ResetFiltro(ClientiDataGrid)
        GridFilter.FiltraDgv(
        ClientiDataGrid,
        $"IdClienti = {idCli}")
        GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo,
                            Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

    End Sub

#End Region

#Region "Anteprima"
    Private Sub MostraAnteprimaPDF()
        Try
            Dim pdfBytes = GeneraPDFInMemory()

            ' Percorso temporaneo
            Dim tempPath As String = Path.Combine(Path.GetTempPath(), "AnteprimaFattura.pdf")
            File.WriteAllBytes(tempPath, pdfBytes)

            ' Mostra la form di anteprima
            Dim frm As New FrmPreviewPDF()
            frm.CaricaPDF(tempPath)
            frm.Show()

        Catch ex As Exception
            RJMessageBox.Show("Errore durante l'anteprima PDF:" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function GeneraPDFInMemory() As Byte()
        Using ms As New MemoryStream()

            Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)
            PdfWriter.GetInstance(doc, ms)
            doc.Open()

            ' ---------------------------------------------------------
            ' 1) LOGO EMITTENTE
            ' ---------------------------------------------------------
            Dim logoPath As String = Path.Combine(Application.StartupPath, "EmFat", "Logo.png")
            If File.Exists(logoPath) Then
                Dim logo = iTextSharp.text.Image.GetInstance(logoPath)
                logo.ScaleAbsoluteWidth(120)
                logo.ScaleAbsoluteHeight(60)
                logo.Alignment = Element.ALIGN_LEFT
                doc.Add(logo)
            End If

            ' ---------------------------------------------------------
            ' 2) DATI EMITTENTE
            ' ---------------------------------------------------------
            Dim datiEmittentePath As String = Path.Combine(Application.StartupPath, "EmFat", "EmittenteFattura.txt")
            If File.Exists(datiEmittentePath) Then
                Dim datiEmittente = File.ReadAllText(datiEmittentePath)
                Dim p As New Paragraph(datiEmittente, FontFactory.GetFont(FontFactory.HELVETICA, 10))
                p.SpacingAfter = 10
                doc.Add(p)
            End If

            ' ---------------------------------------------------------
            ' 3) DATI CLIENTE
            ' ---------------------------------------------------------
            Dim fontTitolo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
            Dim fontNorm = FontFactory.GetFont(FontFactory.HELVETICA, 10)

            Dim titoloCliente As New Paragraph("DATI CLIENTE", fontTitolo)
            titoloCliente.SpacingBefore = 10
            titoloCliente.SpacingAfter = 5
            doc.Add(titoloCliente)

            Dim pCliente As New Paragraph(TxtNomeFat.Text, fontNorm)
            pCliente.SpacingAfter = 10
            doc.Add(pCliente)

            ' ---------------------------------------------------------
            ' 4) TABELLA ARTICOLI
            ' ---------------------------------------------------------
            Dim tab As New PdfPTable(4)
            tab.WidthPercentage = 100
            tab.SetWidths({50, 10, 20, 20})

            tab.AddCell(New PdfPCell(New Phrase("Descrizione", fontTitolo)))
            tab.AddCell(New PdfPCell(New Phrase("Qta", fontTitolo)))
            tab.AddCell(New PdfPCell(New Phrase("Prezzo", fontTitolo)))
            tab.AddCell(New PdfPCell(New Phrase("Importo", fontTitolo)))

            For Each r As DataGridViewRow In FatDataGrid.Rows
                If Not r.IsNewRow Then
                    tab.AddCell(New Phrase(r.Cells("Descr").Value.ToString(), fontNorm))
                    tab.AddCell(New Phrase(r.Cells("Qta").Value.ToString(), fontNorm))
                    tab.AddCell(New Phrase(FormatNumber(r.Cells("Prezzo").Value, 2) & " €", fontNorm))
                    tab.AddCell(New Phrase(FormatNumber(r.Cells("Importo").Value, 2) & " €", fontNorm))
                End If
            Next

            doc.Add(tab)

            ' ---------------------------------------------------------
            ' 5) TABELLA TOTALI
            ' ---------------------------------------------------------
            Dim tabTot = CreaTabellaTotali()
            tabTot.SpacingBefore = 20
            doc.Add(tabTot)

            ' ---------------------------------------------------------
            ' 6) IMMAGINI ARTICOLI
            ' ---------------------------------------------------------
            For Each r As DataGridViewRow In FatDataGrid.Rows
                If Not r.IsNewRow Then
                    Dim imgPath As String = r.Cells("Image").Value.ToString()
                    If File.Exists(imgPath) Then
                        Dim img = iTextSharp.text.Image.GetInstance(imgPath)
                        img.ScaleAbsoluteWidth(120)
                        img.ScaleAbsoluteHeight(120)
                        img.SpacingBefore = 10
                        doc.Add(img)
                    End If
                End If
            Next

            doc.Close()
            Return ms.ToArray()

        End Using
    End Function

    Private Sub RjCircBtnAnteprima_Click(sender As Object, e As EventArgs) Handles RjCircBtnAnteprima.Click
        Try
            MostraAnteprimaPDF()
        Catch ex As Exception
            RJMessageBox.Show("Errore durante l'anteprima PDF:" & vbCrLf &
                      ex.Message & vbCrLf &
                      ex.StackTrace)
        End Try

    End Sub

    Private Sub RjCircBtnNuovaFattura_Click(sender As Object, e As EventArgs) Handles RjCircBtnNuovaFattura.Click
        Try

            ' Crea una nuova riga nel BindingSource
            Dim nuovaRiga As DataRowView = CType(FatturaBindingSource.AddNew(), DataRowView)

            ' Imposta valori iniziali (se vuoi)
            nuovaRiga("DataFat") = DateTime.Now
            nuovaRiga("NomeFat") = ""
            nuovaRiga("Descr") = ""
            nuovaRiga("Qta") = 0
            nuovaRiga("Prezzo") = 0
            nuovaRiga("Importo") = 0

            ' Conferma l'aggiunta
            FatturaBindingSource.EndEdit()

            ' Seleziona automaticamente la nuova riga nel DataGridView
            Dim index As Integer = FatturaBindingSource.Position
            FatDataGrid.Rows(index).Selected = True
            FatDataGrid.CurrentCell = FatDataGrid.Rows(index).Cells(1)

        Catch ex As Exception
            RJMessageBox.Show("Errore durante la creazione della nuova fattura: " & ex.Message)
        End Try
    End Sub

#End Region


End Class