Imports System.Data.SqlClient
Imports System.Configuration
'Imports CustomMessageBoxVB
Imports WinItalPascal



Public Class FrmInsOrdine

    Private dtOrdini As DataTable
    Private dvOrdini As DataView
    Private bsOrdini As New BindingSource
    Private dtOriginal As DataTable
    Private dvOriginal As DataView
    Private dtClienti As DataTable
    Private dvClienti As DataView
    'Public Property tableAdapterManager As Object

    Private Sub FrmInsOrdine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'WinDBGdRDataSet.Fattura'. È possibile spostarla o rimuoverla se necessario.
        Me.FatturaTableAdapter.Fill(Me.WinDBGdRDataSet.Fattura)
        'TODO: questa riga di codice carica i dati nella tabella 'WinDBGdRDataSet.Ordini'. È possibile spostarla o rimuoverla se necessario.
        Me.OrdiniTableAdapter.Fill(Me.WinDBGdRDataSet.Ordini)
        Me.TableAdapterManager.OrdiniTableAdapter = Me.OrdiniTableAdapter
        OrdiniDataGrid.DataSource = Me.OrdiniBindingSource
        FrmTitolo.CTitolo(Me, "Crea Routine per FilroDgv")
        ScreenUtility.FullScreen(Me)
        Try
            ' DATI
            Me.ClientiTableAdapter.Fill(Me.WinDBGdRDataSet.Clienti)
            dvClienti = New DataView(dtClienti)
            dtClienti = DB.FillDataTable("SELECT * FROM Clienti")
            'ClientiDataGrid.DataSource = dvClienti
            ' BIND UNA SOLA VOLTA


            dvOriginal = New DataView(dtOriginal)
            dtOriginal = DB.FillDataTable("SELECT * FROM Ordini")
            'OrdiniDataGrid.DataSource = dvOrdini

            GridUtility.ColoraColonne(OrdiniDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

            GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

            Dim imgReset As Image = My.Resources.reset
            PopupHelper.AttachPopup(RjBtnResetta, vbCrLf & "Reset" & vbCrLf & "Resetta la ricerca e le evidenziazioni", imgReset, Color.Aquamarine, Color.Blue)

        Catch ex As Exception
            FrameworkLogger.LogError(ex, "File Log Errori")
            IPMessageBox.Show("Errore durante il caricamento del form: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub OrdiniDataGrid_CellClick(
   sender As Object,
   e As DataGridViewCellEventArgs) _
   Handles OrdiniDataGrid.CellClick

        If e.RowIndex < 0 Then Exit Sub
        If IsDBNull(OrdiniDataGrid.Rows(e.RowIndex).Cells(1).Value) Then
            Exit Sub
        End If
        ' nel datagrdi IDCliOrdDataGridViewTextBoxColumn = IDCliOrd è la colonna che contiene l'ID del cliente,
        ' se è diverso filtriamo altrimenti resettiamo il filtro
        Dim idCli As Integer =
        CInt(OrdiniDataGrid.Rows(e.RowIndex).Cells("IDCliOrd").Value)
        ' ResetFiltro(ClientiDataGrid)
        GridFilter.FiltraDgv(
        ClientiDataGrid,
        $"IdClienti = {idCli}")
        GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

    End Sub

    Private Sub ResetFiltro(dgv As DataGridView)

        Dim dv As DataView =
            DirectCast(dgv.DataSource, DataView)

        dv.RowFilter = ""

    End Sub

#Region "Ordini"




    ' Esegue calcoli automaticamente in OrdiniDataGrid

    '' Aggiorna la sola riga modificata: valore = colonna(4) * colonna(5) -> colonna(6)

    Private Sub OrdiniDataGrid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles OrdiniDataGrid.CellEndEdit

        ' Se la riga è nuova, esci
        If OrdiniDataGrid.Rows(e.RowIndex).IsNewRow Then Exit Sub

        ' Colonne interessate: Qta (4) e Utilizzate (5)
        If e.ColumnIndex = 4 OrElse e.ColumnIndex = 5 Then
            CalcolaResiduoRiga(e.RowIndex)
        End If

    End Sub

    Private Sub CalcolaResiduoRiga(rowIndex As Integer)

        Dim row As DataGridViewRow = OrdiniDataGrid.Rows(rowIndex)

        Dim Qta As Integer = 0
        Dim SxImp As Integer = 0
        Dim TotImp As Integer = 0

        ' Qta (colonna 3)
        If Not IsDBNull(row.Cells(4).Value) AndAlso
         IsNumeric(row.Cells(4).Value) Then
            Qta = CInt(row.Cells(4).Value)
        End If

        ' Importo(colonna 6)
        If Not IsDBNull(row.Cells(5).Value) AndAlso
         IsNumeric(row.Cells(5).Value) Then
            SxImp = CInt(row.Cells(5).Value)
        End If

        ' Calcolo Totale
        TotImp = Qta * SxImp

        ' Scrivi il risultato nella colonna 7
        row.Cells(6).Value = TotImp

    End Sub

    Private Sub RjBtnSalva_Click(sender As Object, e As EventArgs) _
    Handles RJBtnSalva.Click

        Try

            Me.Validate()
            GridUtility.ConvertiMaiuscolo(OrdiniDataGrid)
            Me.OrdiniBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.WinDBGdRDataSet)

            'FrameworkLogger.Log("Ordine salvato correttamente.")
            ' Non ho messo questo tipo di messaggio in libreria
            If IPMessageBox.Show("Vuoi cancellare il log?", "Conferma",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) = DialogResult.Yes Then

                LogLeggiScrivi.ClearLog(1) ' il numero è opzionale , da default elimina 5 gruppi

            End If

            ' Specifiche delle modifiche scritte nel file di Log
            Dim Materiale As String = OrdiniDataGrid.CurrentRow.Cells(3).Value.ToString()
            Dim Id As String = OrdiniDataGrid.CurrentRow.Cells(1).Value.ToString()
            LogLeggiScrivi.ScriviLogMsg($"Cliente con Id {Id} " & "Ordine di " & $"{Materiale}" & " salvato correttamente")
            '  LogLeggiScrivi.ScriviLogMsg($"Salvato {OrdiniDataGrid.Rows.Count } record")

            GridUtility.ColoraColonne(OrdiniDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

        Catch ex As Exception
            LogLeggiScrivi.ScriviLog("File Log", ex)   ' con nuovo file di Log
            FrameworkLogger.LogError(ex, "SALVA ORDINI") ' Alternativa
            IPMessageBox.Show(
            "ERRORE SALVATAGGIO: " & ex.Message,
            "Errore",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try

    End Sub

#End Region

    Sub TuttiClienti()
        ' Quando devo inserire un nuovo ordine voglio vedere tutti i clienti, quindi resetto il filtro
        TxtCercaCliente.Text = ""
        DataGVLoad.ApriDGV(ClientiDataGrid, "Select * from Clienti")
        GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

    End Sub
    Private Sub RjBtnNuovoOrdine_Click_1(sender As Object, e As EventArgs) Handles RjBtnTuttiClienti.Click
        ' Quando devo inserire un nuovo ordine voglio vedere tutti i clienti, quindi resetto il filtro
        ' questo è TUTTI I CLIENTI
        TxtCercaCliente.Text = ""
        DataGVLoad.ApriDGV(ClientiDataGrid, "Select * from Clienti")
        GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)
    End Sub

    Sub colDgv()
        GridUtility.ColoraColonne(OrdiniDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)
        GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

    End Sub

    Private Sub TxtTutti_TextChanged(sender As Object, e As EventArgs) Handles TxtTutti.TextChanged

        GridUtility.FiltraTutti(OrdiniDataGrid, dtOriginal, TxtTutti.Text)
        If TxtCercaCliente.Text = "" Then
            ' resetto il filtro
            DataGVLoad.ApriDGV(ClientiDataGrid, "Select * from Clienti")
        End If
        colDgv()

    End Sub

    Private Sub RjBtnResetta_Click(sender As Object, e As EventArgs) Handles RjBtnResetta.Click
        IPMessageBox.Show("Resetto la ricerca e le evidenziazioni", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TxtTutti.Text = ""
        TxtEvidenzia.Text = ""
        GridUtility.ResetColori(OrdiniDataGrid)
        GridUtility.ColoraColonne(OrdiniDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)
        GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)
    End Sub

    Private Sub RjBtnCerca_Click(sender As Object, e As EventArgs) Handles RjBtnCerca.Click
        Dim filtro As String = TxtEvidenzia.Text.Trim.ToUpper()
        If filtro = "" Then
            IPMessageBox.Show("Inserisci un testo da evidenziare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        GridUtility.EvidenziaTesto(OrdiniDataGrid, filtro)
    End Sub

    Private Sub RjBtnLog_Click(sender As Object, e As EventArgs) Handles RjBtnLog.Click
        ' Per leggere Avviso corto va bene
        Dim leggiLog = IPMessageBox.Show(LogReader.ReadLog(), "Apro il file di log")

        'LogLeggiScrivi.ApriLog()  ' OK, apre il file con NotePad file lunghi
    End Sub

    Private Sub TxtCercaCliente_TextChanged(sender As Object, e As EventArgs) Handles TxtCercaCliente.TextChanged

        Dim MiaQry As String = "SELECT * FROM Clienti WHERE Cliente LIKE '%" & TxtCercaCliente.Text & "%'"

        DataGVLoad.ApriDGV(ClientiDataGrid, MiaQry)
        ClientiDataGrid.Refresh()
        GridUtility.EvidenziaTesto(ClientiDataGrid, TxtCercaCliente.Text)

        If TxtCercaCliente.Text = "" Then

            GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

        End If

    End Sub

    Private Sub RjButton1_Click(sender As Object, e As EventArgs) Handles RjButton1.Click
        If TxtCercaCliente.Text.Trim = "" Then
            DataGVLoad.ApriDGV(ClientiDataGrid, "Select * from Clienti")

            GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

        Else
            Dim MiaQry As String = "SELECT * FROM Clienti WHERE Cliente LIKE '%" & TxtCercaCliente.Text & "%'"

            DataGVLoad.ApriDGV(ClientiDataGrid, MiaQry)

            GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

        End If
    End Sub

End Class