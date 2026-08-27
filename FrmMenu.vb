Imports System.Data.SqlClient
Imports CustomMessageBoxVB
Imports System.Drawing
Imports System.Windows.Forms
Imports WinItalPascal

Public Class FrmMenu


    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ScreenUtility.FullScreen(Me)
        FrmTitolo.CTitolo(Me, "Demo Gestionale - Menu contenitore")

        Page1()
        page2()
        page3()
        page4()
        page5()
        page6() ' Pagina Iniziale
        page7()

    End Sub

    Private Sub BtnApriCartellaHelpPDF_Click(sender As Object, e As EventArgs) Handles BtnApriHelpPDF.Click
        Try
            ' Selettore cartella
            Dim folderDlg As New FolderBrowserDialog()
            folderDlg.Description = "Seleziona la cartella dove si trova il file PDF di Help"

            If folderDlg.ShowDialog() <> DialogResult.OK Then
                Exit Sub
            End If

            Dim cartella As String = folderDlg.SelectedPath

            ' Filtro PDF
            Dim openDlg As New OpenFileDialog()
            openDlg.InitialDirectory = cartella
            openDlg.Filter = "File PDF (*.pdf)|*.pdf"
            openDlg.Title = "Seleziona il file Help PDF"

            If openDlg.ShowDialog() <> DialogResult.OK Then
                Exit Sub
            End If

            Dim percorsoPDF As String = openDlg.FileName

            ' Apertura PDF senza chiudere l'app
            Process.Start(percorsoPDF)

        Catch ex As Exception
            IPMessageBox.Show("Errore apertura PDF: " & ex.Message,
                          "Errore",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnApriHelpPDF_Click(sender As Object, e As EventArgs) Handles BtnApriHelpPDF.Click
        Try
            Dim percorsoPDF As String = OttieniPercorsoHelpPDF()

            If String.IsNullOrEmpty(percorsoPDF) Then
                IPMessageBox.Show("Nessun file PDF selezionato.",
                              "Help PDF",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information)
                Exit Sub
            End If

            Process.Start(percorsoPDF)



        Catch ex As Exception
            IPMessageBox.Show("Errore apertura PDF: " & ex.Message,
                          "Errore",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function OttieniPercorsoHelpPDF() As String
        Dim filePath As String = System.IO.Path.Combine(Application.StartupPath, "PercorsoHelpPDF.txt")

        ' --- 1. Se il file TXT esiste, provo a leggerlo ---
        If System.IO.File.Exists(filePath) Then
            Dim percorsoSalvato As String = System.IO.File.ReadAllText(filePath).Trim()

            ' Se contiene un percorso valido → lo uso
            If Not String.IsNullOrWhiteSpace(percorsoSalvato) AndAlso System.IO.File.Exists(percorsoSalvato) Then
                Return percorsoSalvato
            End If
        End If

        ' --- 2. Se il file TXT non esiste o il PDF non è valido → chiedo all'utente ---
        Dim openDlg As New OpenFileDialog()
        openDlg.Title = "Seleziona il file Help PDF"
        openDlg.Filter = "File PDF (*.pdf)|*.pdf"

        If openDlg.ShowDialog() = DialogResult.OK Then
            ' Creo o sovrascrivo il file TXT con il nuovo percorso
            System.IO.File.WriteAllText(filePath, openDlg.FileName)
            Return openDlg.FileName
        End If

        ' --- 3. Nessuna selezione → ritorno Nothing ---
        Return Nothing
    End Function


    Private Sub RjBtnClienti_Click(sender As Object, e As EventArgs) Handles RjBtnClienti.Click
        FemInsClienti.Show()
    End Sub

    Private Sub RjBtnOrdini_Click(sender As Object, e As EventArgs) Handles RjBtnOrdini.Click
        FrmInsOrdine.Show()
    End Sub

    Private Sub RjBtnFattura_Click(sender As Object, e As EventArgs) Handles RjBtnFattura.Click
        FrmGestFatture.Show()
    End Sub
    Private Sub RjBtnForm1_Click(sender As Object, e As EventArgs) Handles RjBtnForm1.Click
        FrmReportOrdini.Show()
    End Sub

    Private Sub RjButton1_Click(sender As Object, e As EventArgs) Handles RjButton1.Click
        FrmHelpWeb.Show()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub RjBtnSenzaFattura_Click(sender As Object, e As EventArgs) Handles RjBtnSenzaFattura.Click
        FrmSenzaFattura.Show()
    End Sub


    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) _
    Handles RichTextBox1.TextChanged

        ' Evita lampeggiamenti
        RichTextBox1.SuspendLayout()

        For i As Integer = 0 To RichTextBox2.Lines.Length - 1
            Dim riga As String = RichTextBox2.Lines(i)

            If riga.Trim().StartsWith("[") Then
                ColoraRiga(RichTextBox1, i, Color.Red)
            End If
        Next

        RichTextBox1.ResumeLayout()
    End Sub

    Sub Page1()
        ColoraRigheConParola(RichTextBox1, "Sub", Color.Blue)
        ColoraRigheConParola(RichTextBox1, "IDClienti", Color.Red)
        ColoraRigheConParola(RichTextBox1, "IDCliOrd", Color.Red)
        ColoraRiga(RichTextBox1, 0, Color.Red)
        ' crea lista parole da colorare
        Dim lista As New List(Of String) From {"if", "string", "integer", "end if", "dim"}
        Dim lista2 As New List(Of String) From {"datagrid", "datagridview", "ClientiDataGrid", "OrdiniDataGrid"}
        ColoraParole(RichTextBox1, lista, Color.BlueViolet)
        ColoraParole(RichTextBox1, lista2, Color.Blue)
        ' per i commenti
        ColoraRigheConCommento(RichTextBox6,
                               "'",
                               Color.Green)
        ' Evidenzia intera riga
        EvidenziaRiga(RichTextBox1, 0, Color.Yellow)
        ColoraRiga(RichTextBox1, 0, Color.Red)

    End Sub

    Sub page2()

        Dim paroleColori As New Dictionary(Of String, Color) From {
                {"My.Resource", Color.Blue},
                {"Color", Color.Blue},
                {"Next", Color.Green}
            }
        ColoraParole(RichTextBox2, paroleColori)
        ColoraRigheConParola(RichTextBox2, "System.Drawing.Image", Color.Red)
        ColoraRigheConCommento(RichTextBox6,
                               "'",
                               Color.Green)
        Dim lista As New List(Of String) From {"imgCerca", "imgSalva", "imgCliente", "if", "end if", "dim"}
        Dim lista2 As New List(Of String) From {"AttachPopup", "PopUpHelper", "Nothing"}
        ColoraParole(RichTextBox2, lista, Color.BlueViolet)
        ColoraParole(RichTextBox2, lista2, Color.Blue)

    End Sub

    Sub page3()
        Dim lista As New List(Of String) From {"ScriviLog", "ScriviLogMsg", "integer", "if ", "end if", "dim", "GridUtility"}
        Dim lista2 As New List(Of String) From {"Clientidatagrid", "LogLeggiScrivi", "Utente", "Id"}
        ColoraParole(RichTextBox3, lista, Color.BlueViolet)
        ColoraParole(RichTextBox3, lista2, Color.Blue)
        ColoraRigheConCommento(RichTextBox6,
                               "'",
                               Color.Green)
        ColoraRigheConParola(RichTextBox3, "errore", Color.Red)
        EvidenziaRiga(RichTextBox3, 0, Color.Yellow)
        ColoraRiga(RichTextBox3, 0, Color.Red)
    End Sub

    Sub page4()
        Dim lista As New List(Of String) From {"ScriviLog", "ScriviLogMsg", "DataGVLoad", "ApriDGV", "if ", "end if", "dim", "GridUtility"}
        Dim lista2 As New List(Of String) From {"Clientidatagrid", "LogLeggiScrivi", "IDCliOrd", "IdOrd"}
        ColoraParole(RichTextBox4, lista, Color.BlueViolet)
        ColoraParole(RichTextBox4, lista2, Color.Blue)
        ColoraRigheConCommento(RichTextBox6,
                               "'",
                               Color.Green)
        ColoraRigheConParola(RichTextBox4, "errore", Color.Red)
        EvidenziaRiga(RichTextBox4, 0, Color.Yellow)
        ColoraRiga(RichTextBox4, 0, Color.Red)
    End Sub

    Sub page5()
        ColoraRigheConCommento(RichTextBox6,
                               "'",
                               Color.Green)
        Dim lista As New List(Of String) From {"ScriviLog", "ScriviLogMsg", "DataGVLoad", "ApriDGV", "integer", "if ", "end if", "dim", "GridUtility"}
        Dim lista2 As New List(Of String) From {"Clientidatagrid", "FillDataTable", "DataTable", "DataView", "MiaQry", "DtClienti", "DvClienti"}
        Dim lista3 As New List(Of String) From {"Dim MiaQry As String ", "Cliente LIKE"}
        ColoraRigheConParola(RichTextBox5, "DB", Color.Red)
        ColoraRigheConParola(RichTextBox5, "TxtCercaCliente.Text", Color.Black)
        ColoraParole(RichTextBox5, lista, Color.BlueViolet)
        ColoraParole(RichTextBox5, lista2, Color.Blue)
        ColoraParole(RichTextBox5, lista3, Color.Blue)

        EvidenziaRiga(RichTextBox5, 0, Color.Yellow)
        ColoraRiga(RichTextBox5, 0, Color.Red)
        EvidenziaRiga(RichTextBox5, 9, Color.Yellow)
        ColoraRiga(RichTextBox5, 9, Color.Red)
        EvidenziaRiga(RichTextBox5, 19, Color.Yellow)
        ColoraRiga(RichTextBox5, 19, Color.Red)
    End Sub

    Sub page6()
        ' Pagina Iniziale

        HelpFormatta.AddMessage(RichTextBox6,
                        "▶",
                        "Modulo Help aggiunto",
                        Color.RoyalBlue)

        ColoraRigheConParola(RichTextBox6,
                             "Nuova Funzione",
                             Color.Red)

        ColoraParole(RichTextBox6,
                     {"Reports",
                      "ModHelp",
                      "Help",
                      "Core",
                      "Database",
                      "Forms",
                      "Logging",
                      "Popup"},
                     Color.Blue)

        ColoraRigheConCommento(RichTextBox6,
                               "'",
                               Color.Green)


        'Dim lista As New List(Of String) From {"Reports", "ModHelp", "Help", "Core", "Database", "Forms", "Logging", "Popup"}
        'ColoraPiuParole(RichTextBox6, lista, Color.Blue)
        'ColoraRigheConComm(RichTextBox6, "'", Color.Green)
        'HelpFormatta.AddMessage(RichTextBox6, "▶", "Modulo Help aggiunto", Color.RoyalBlue)
    End Sub

    Private Sub RjBtnHelpFrm_Click(sender As Object, e As EventArgs) Handles RjBtnHelpFrm.Click
        FrmHelp.Show()
    End Sub


    Sub page7()

        EvidenziaRiga(RichTextBox7, 3, Color.Yellow)
        ColoraRiga(RichTextBox7, 3, Color.Red)
        ' per i commenti
        ColoraRigheConCommento(RichTextBox6,
                               "'",
                               Color.Green)
        ColoraRigheConParola(RichTextBox7, "ApriCartella", Color.Blue)
        ColoraRigheConParola(RichTextBox7, "ApriIndice", Color.Blue)
    End Sub

    Private Sub RjBtnRDLC_Click(sender As Object, e As EventArgs) Handles RjBtnRDLC.Click
        'FrmRDLC.Show()
        apriRDLC()
    End Sub

    Sub apriRDLC()
        Dim frm As New FrmReport

        frm.TitoloReport = "Elenco Ordini Cliente"
        frm.NomeReport = "Rep2Manager.rdlc"
        ' Esempio per debug  prima della query
        Dim conn As SqlConnection = DB.GetConnection()
        IPMessageBox.Show("Connessione: " & conn.DataSource & " DB: " & conn.Database)


        frm.TabellaReport = DB.FillDataTable("SELECT * FROM dbo.Ordini")

        frm.DataSourceReport = "DataSet1"
        IPMessageBox.Show("Apro Report  : " & frm.NomeReport)
        frm.Show()
    End Sub

    Private Sub RjBtnTestRep_Click(sender As Object, e As EventArgs) Handles RjBtnTestRep.Click
        FrmTest.Show()
    End Sub

    'Private Sub RjBtnTestRep_Click(sender As Object, e As EventArgs) Handles RjBtnTestRep.Click
    '    FrmTest.Show()
    'End Sub

    ' ColoraRigheConParola(RichTextBox1, "ERROR", Color.Red)
    ' ColoraRigheConParola(RichTextBox1, "INFO", Color.Blue)
    ' ColoraRiga(RichTextBox1, 1, Color.LimeGreen)
    ' EvidenziaRiga(RichTextBox1, 1, Color.Yellow)


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

End Class