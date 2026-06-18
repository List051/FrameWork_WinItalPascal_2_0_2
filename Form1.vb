

Imports System.Data.SqlClient
Imports System.Configuration
Imports CustomMessageBoxVB
Imports WinItalPascal


Public Class Form1
    'Private DgClienti As DataGridView
    Private dtView As DataTable

    'Private dgvOrd As DataGridView
    Private dtOrd As DataTable
    Private dtOriginal As DataTable
    'Private DgFattura As DataGridView
    Private dtFattura As DataTable
    Private dvFattura As DataView

    Private dtFatture As DataTable
    Private dvFatture As DataView

    Private dtOrdini As DataTable
    Private dvOrdini As DataView

    Private dtClienti As DataTable
    Private dvClienti As DataView


    Private bsFatture As New BindingSource
    Private bsOrdini As New BindingSource
    Private bsClienti As New BindingSource

    Private ReadOnly Property GridFatture As DataGridView
        Get
            Return FatturaDataGrid
        End Get
    End Property


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FrmTitolo.CTitolo(Me, "Elenco Fatture - Evidenzia Fatture in Attesa")
        ScreenUtility.FullScreen(Me)
        Try
            ' DATI
            dtFatture = DB.FillDataTable("SELECT * FROM Fattura")
            dtOrdini = DB.FillDataTable("SELECT * FROM Ordini")
            dtClienti = DB.FillDataTable("SELECT * FROM Clienti")

            dvFatture = New DataView(dtFatture)
            dvOrdini = New DataView(dtOrdini)
            dvClienti = New DataView(dtClienti)

            ' BIND UNA SOLA VOLTA
            FatturaDataGrid.DataSource = dvFatture
            OrdiniDataGrid.DataSource = dvOrdini
            ClientiDataGrid.DataSource = dvClienti

            dtOriginal = DB.FillDataTable("SELECT * FROM Fattura")

            GridUtility.ColoraColonne(OrdiniDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)
            GridUtility.ColoraColonne(FatturaDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)
            GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

            ' image per button
            'Dim imgSalva As Image = My.Resources.editFat
            Dim imgCerca As Image = My.Resources.cercaFat
            Dim imgCliente As Image = My.Resources.sinistra
            Dim imgRicarica As Image = My.Resources.reset
            ' Messaggio informazione
            PopupHelper.AttachPopup(RjBtnCerca, vbCrLf & "Attenzione" & vbCrLf & "Cerca in Fattura ed evidenzia" & vbCrLf & "Prosegui cliccando per visualizzare", imgCerca, Color.Aquamarine, Color.Blue)
            PopupHelper.AttachPopup(RjBtnRicarica, vbCrLf & "Attenzione" & vbCrLf & "Ripristina griglia", imgRicarica, Color.Aquamarine, Color.Blue)



        Catch ex As Exception
            FrameworkLogger.LogError(ex, "File Log Errori")
            RJMessageBox.Show("Errore durante il caricamento del form: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub FiltraDgv(
    dgv As DataGridView,
    filtro As String)

        Dim dv As DataView =
        DirectCast(dgv.DataSource, DataView)

        dv.RowFilter = filtro

    End Sub


    Private Sub FatturaDataGrid_CellClick(
    sender As Object,
    e As DataGridViewCellEventArgs) _
    Handles FatturaDataGrid.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim idCli As Integer =
            CInt(FatturaDataGrid.Rows(e.RowIndex).Cells("IDCli").Value)
        ResetFiltro(OrdiniDataGrid)
        GridFilter.FiltraDgv(
            OrdiniDataGrid,
            $"IDCliOrd = {idCli}")

        GridUtility.ColoraColonne(OrdiniDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

    End Sub

    Private Sub OrdiniDataGrid_CellClick(
    sender As Object,
    e As DataGridViewCellEventArgs) _
    Handles OrdiniDataGrid.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim idCli As Integer =
        CInt(OrdiniDataGrid.Rows(e.RowIndex).Cells("IDCliOrd").Value)
        ResetFiltro(ClientiDataGrid)
        GridFilter.FiltraDgv(
        ClientiDataGrid,
        $"IdClienti = {idCli}")

        ' Inserito modulo per scrivere meno
        ColoraDgv(ClientiDataGrid)
        'GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

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


    Private Sub RjButton1_Click(sender As Object, e As EventArgs) Handles RjButton1.Click
        FrmInsOrdine.Show()
    End Sub

    Private Sub RjBtnRicarica_Click(sender As Object, e As EventArgs) Handles RjBtnRicarica.Click
        TxtEvidenzia.Text = ""
        TxtTutti.Text = ""
        GridUtility.ResetColori(FatturaDataGrid)

        ' ColoraDgv è in un modulo, posso caricare qualsiasi datagrid
        ColoraDgv(OrdiniDataGrid, ClientiDataGrid, FatturaDataGrid)

        'GridUtility.ColoraColonne(OrdiniDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)
        'GridUtility.ColoraColonne(ClientiDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)
        'GridUtility.ColoraColonne(FatturaDataGrid, Colori.ColoreTipo.Giallo, Colori.ColoreTipo.VerdeChiaro, Colori.ColoreTipo.Azzurro)

    End Sub




    Private Sub RjBtnCerca_Click(sender As Object, e As EventArgs) Handles RjBtnCerca.Click
        Dim filtro As String = TxtEvidenzia.Text.Trim.ToUpper()
        If filtro = "" Then
            RJMessageBox.Show("Inserisci un testo da evidenziare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        GridUtility.EvidenziaTesto(FatturaDataGrid, filtro)
    End Sub

    Private Sub TxtTutti_TextChanged(sender As Object, e As EventArgs) Handles TxtTutti.TextChanged
        GridUtility.FiltraTutti(FatturaDataGrid, dtOriginal, TxtTutti.Text)
    End Sub

    Private Sub RjBtnFatture_Click(sender As Object, e As EventArgs) Handles RjBtnFatture.Click
        FrmGestFatture.Show()
    End Sub


    '********************
    ' Eventuale Btn per resettare
    'Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click

    '    ResetFiltro(OrdiniDataGrid)
    '    ResetFiltro(ClientiDataGrid)
    '    ResetFiltro(FatturaDataGrid)
    'End Sub
    '***********************

End Class
