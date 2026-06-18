
Imports System.Data.SqlClient
Imports System.Configuration
Imports CustomMessageBoxVB
Imports WinItalPascal


Public Class FemInsClienti

    Private dtOrdini As DataTable
    Private dvOrdini As DataView

    Private dtClienti As DataTable
    Private dvClienti As DataView
    Private dtView As DataView
    Private bsFatture As New BindingSource
    Private bsOrdini As New BindingSource
    Private bsClienti As New BindingSource

    Private Sub FemInsClienti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'WinDBGdRDataSet.Ordini'. È possibile spostarla o rimuoverla se necessario.
        Me.OrdiniTableAdapter.Fill(Me.WinDBGdRDataSet.Ordini)
        'TODO: questa riga di codice carica i dati nella tabella 'WinDBGdRDataSet.Clienti'. È possibile spostarla o rimuoverla se necessario.
        Me.ClientiTableAdapter.Fill(Me.WinDBGdRDataSet.Clienti)
        dvOrdini = New DataView(dtOrdini)
        dvClienti = New DataView(dtClienti)
        dtClienti = DB.FillDataTable("SELECT * FROM Clienti")
        ScreenUtility.FullScreen(Me)
        FrmTitolo.CTitolo(Me, "Gesionale Clienti")
        colDgv()
        Dim imgSalva As Image = My.Resources.social_page

    End Sub

    Sub colDgv()
        GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)
        GridUtility.ColoraColonne(OrdiniDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

    End Sub
#Region "Filtra Ordini del cliente"

    Private Sub ClientiDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientiDataGrid.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim idCli As Integer =
            CInt(ClientiDataGrid.Rows(e.RowIndex).Cells("IDClienti").Value)
        ResetFiltro(OrdiniDataGrid)
        GridFilter.FiltraDgv(
            OrdiniDataGrid,
            $"IDCliOrd = {idCli}")
        ' Utilizzando il modulo ColoraGrid posso fare in questo modo
        ColoraDgv(OrdiniDataGrid, ClientiDataGrid)
        ' avevo fatto questa 
        'colDgv()
    End Sub

    Private Sub FiltraDgv(
    dgv As DataGridView,
    filtro As String)

        Dim dv As DataView =
        DirectCast(dgv.DataSource, DataView)

        dv.RowFilter = filtro

    End Sub
    Private Sub ResetFiltro(dgv As DataGridView)
        Dim dv As DataView = Nothing

        If TypeOf dgv.DataSource Is BindingSource Then
            Dim bs = DirectCast(dgv.DataSource, BindingSource)
            If bs.List IsNot Nothing AndAlso TypeOf bs.List Is DataView Then
                dv = DirectCast(bs.List, DataView)
            ElseIf TypeOf bs.DataSource Is DataTable Then
                dv = DirectCast(DirectCast(bs.DataSource, DataTable).DefaultView, DataView)
            End If
        ElseIf TypeOf dgv.DataSource Is DataView Then
            dv = DirectCast(dgv.DataSource, DataView)
        ElseIf TypeOf dgv.DataSource Is DataTable Then
            dv = DirectCast(DirectCast(dgv.DataSource, DataTable).DefaultView, DataView)
        End If

        If dv IsNot Nothing Then dv.RowFilter = String.Empty
    End Sub

#End Region

    Private Sub RjCircSalva_Click(sender As Object, e As EventArgs) Handles RjCircSalva.Click

        Try
            If Not VerificaDatiClienti() Then
                Exit Sub ' blocca il salvataggio
            End If

            Me.Validate()
            GridUtility.ConvertiMaiuscolo(ClientiDataGrid)
            Me.ClientiBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.WinDBGdRDataSet)

            ' Specifiche delle modifiche scritte nel file di Log
            Dim Utente As String = ClientiDataGrid.CurrentRow.Cells(1).Value.ToString()
            Dim Id As String = ClientiDataGrid.CurrentRow.Cells(0).Value.ToString()
            LogLeggiScrivi.ScriviLogMsg($"Cliente con Id {Id} " & "a nome di " & $"{Utente}" & " salvato correttamente")

            'LogLeggiScrivi.ScriviLogMsg($"Salvato {ClientiDataGrid.Rows.Count } record")
            If RJMessageBox.Show("Vuoi cancellare record vecchi nel file di log?", "Conferma",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) = DialogResult.Yes Then

                LogLeggiScrivi.ClearLog(1) ' il numero è opzionale , da default elimina 5 gruppi

            End If
            ' Per leggere Avviso corto va bene
            Dim leggiLog = RJMessageBox.Show(LogReader.ReadLog(), "Apro il file di log")
        Catch ex As Exception
            LogLeggiScrivi.ScriviLog("File Log", ex)   ' con nuovo file di Log
            FrameworkLogger.LogError(ex, "SALVA Clienti") ' Alternativa
            RJMessageBox.Show(
            "ERRORE SALVATAGGIO: " & ex.Message,
            "Errore",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
        ' coloro i datagrid 
        colDgv()
    End Sub

    Private Function VerificaDatiClienti() As Boolean

        For Each r As DataGridViewRow In ClientiDataGrid.Rows
            If Not r.IsNewRow Then

                ' --- Controllo CAP (colonna 5) ---
                Dim cap As String = Convert.ToString(r.Cells(5).Value).Trim()

                If cap.Length <> 5 OrElse Not cap.All(AddressOf Char.IsDigit) Then

                    RJMessageBox.Show("Errore: il CAP deve contenere 5 cifre numeriche." &
                       vbCrLf & "Riga: " & r.Index + 1, "Errore inserimento",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Return False
                End If

                ' --- Controllo P_IVA (colonna 7) ---
                Dim piva As String = Convert.ToString(r.Cells(7).Value).Trim()

                If piva = "" Then

                    RJMessageBox.Show("Errore: il campo P.IVA / Codice Fiscale non può essere vuoto." &
                       vbCrLf & "Riga: " & r.Index + 1, "Errore inserimento",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Return False
                End If

                ' SOLO NUMERI → deve essere lungo 11
                If piva.All(AddressOf Char.IsDigit) Then
                    If piva.Length <> 11 Then

                        RJMessageBox.Show("Errore: la Partita IVA deve contenere esattamente 11 cifre numeriche" &
                       vbCrLf & "Riga: " & r.Index + 1, "Errore inserimento",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Return False
                    End If

                    ' LETTERE + NUMERI → deve essere lungo 16
                ElseIf piva.Any(AddressOf Char.IsLetter) Then
                    If piva.Length <> 16 Then
                        RJMessageBox.Show("Errore: il Codice Fiscale deve contenere esattamente 16 caratteri alfanumerici.  " &
                       vbCrLf & "Riga: " & r.Index + 1, "Errore inserimento",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If

                    ' Caso non valido (caratteri strani)
                Else

                    RJMessageBox.Show("Errore: il campo P.IVA / Codice Fiscale contiene caratteri non validi.  " &
                       vbCrLf & "Riga: " & r.Index + 1, "Errore inserimento",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Return False
                End If


                '' --- Controllo P_IVA (colonna 7) ---
                'Dim piva As String = Convert.ToString(r.Cells(7).Value).Trim()

                'If piva.Length <> 16 OrElse Not piva.All(AddressOf Char.IsLetterOrDigit) Then
                '    MsgBox("Errore: la Partita IVA / Codice Fiscale deve contenere 16 caratteri alfanumerici." &
                '       vbCrLf & "Riga: " & r.Index + 1,
                '       MsgBoxStyle.Critical)
                '    Return False
                'End If

            End If
        Next

        Return True
    End Function

    Private Sub RjBtnLog_Click(sender As Object, e As EventArgs) Handles RjBtnLog.Click
        ' Per leggere Avviso corto va bene
        Dim leggiLog = RJMessageBox.Show(LogReader.ReadLog(), "Apro il file di log")
    End Sub

    Private Sub TxtCerca_TextChanged(sender As Object, e As EventArgs) Handles TxtCerca.TextChanged

        GridUtility.FiltraTutti(ClientiDataGrid, dtClienti, TxtCerca.Text)
        GridUtility.EvidenziaTesto(ClientiDataGrid, TxtCerca.Text)

        If TxtCerca.Text = "" Then
            colDgv()
        End If
    End Sub

    Private Sub RjCircularPictureBox1_Click(sender As Object, e As EventArgs) Handles RjCircularPictureBox1.Click
        TxtCerca.Text = ""
        colDgv()
    End Sub


End Class