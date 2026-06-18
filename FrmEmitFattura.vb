Imports System.IO
Imports CreaFiltroDvg.ClsDatiEmittente
Imports CustomMessageBoxVB
Imports WinItalPascal

Public Class FrmEmitFattura

    ' Dichiarazione della variabile per memorizzare il percorso del logo

    Public Property NomeEmittente As String
    Public Property IndirizzoEmittente As String
    Public Property TelefonoEmittente As String
    Public Property IVAEmittente As String
    Public Property LogoEmittentePath As String
    Public DatiEmittenteCorrente As DatiEmittente


    Private Sub FrmEmitFattura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FrmTitolo.CTitolo(Me, "Gestione Emittente Fattura")
        'Me.Left = 480
        'Me.Top = 220

        CaricaDatiEmittente()
        DatiEmittenteCorrente =
    ClsEmittenteFattura.CaricaDati()
        Me.MaximizeBox = False
        ' CaricaLogo()

        ' Popola le TextBox con i valori ricevuti
        NomeEmittenteTextBox.Text = NomeEmittente
        IndirizzoEmittenteTextBox.Text = IndirizzoEmittente
        TelefonoEmittenteTextBox.Text = TelefonoEmittente
        IVAEmittenteTextBox.Text = IVAEmittente
        LogoPictureBox.Text = LogoEmittentePath

    End Sub

    Private Sub RjBtnSalvaDatiEmittente_Click(sender As Object, e As EventArgs) Handles RjBtnSalvaDatiEmittente.Click
        SalvaDatiEmittente() ' Salva i dati in un file di testo
        Dim result = RJMessageBox.Show("Ho salvati i tuoi dati Aziendali nel file " & vbCr & " EmittenteFattura.txt ",
                                       "Inserimento Dati Aziendali",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information)
        Me.Close()
    End Sub


    Private Sub CaricaDatiEmittente()

        Dim appFolder As String = Application.StartupPath
        Dim filePath As String = Path.Combine(appFolder, "EmFat", "EmittenteFattura.txt")

        If Not File.Exists(filePath) Then Exit Sub

        Dim righe() As String = File.ReadAllLines(filePath)

        If righe.Length >= 5 Then

            NomeEmittenteTextBox.Text = righe(0)
            IndirizzoEmittenteTextBox.Text = righe(1)
            TelefonoEmittenteTextBox.Text = righe(2)
            IVAEmittenteTextBox.Text = righe(3)

            ' Percorso del logo salvato
            Dim percorsoLogo As String = righe(4)

            If File.Exists(filePath) Then
                Using reader As New StreamReader(filePath)
                    NomeEmittente = reader.ReadLine()
                    IndirizzoEmittente = reader.ReadLine()
                    TelefonoEmittente = reader.ReadLine()
                    IVAEmittente = reader.ReadLine()
                    'reader.ReadLine() ' Ignora il dato IVA, se non serve

                    ' qui leggo il nome del file image
                    LogoEmittentePath = reader.ReadLine() ' Percorso del logo
                End Using

            Else
                RJMessageBox.Show("I tuoi dati Aziendali del file " & vbCr & " EmittenteFattura.txt ",
                                       "Aggiornamento Dati Aziendali",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information)
            End If

            ' Carica il logo
            CaricaLogo(percorsoLogo)

            Dim result = RJMessageBox.Show("I tuoi dati Aziendali del file " & vbCr & " EmittenteFattura.txt ",
                                           "Aggiornamento Dati Aziendali",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub CaricaLogo(percorsoLogo As String)

        ' Se il percorso salvato esiste → usa quello
        If File.Exists(percorsoLogo) Then
            LogoPictureBox.Image = Image.FromFile(percorsoLogo)
            Exit Sub
        End If

        ' Altrimenti usa Logo.png come fallback
        Dim defaultLogo As String = Path.Combine(Application.StartupPath, "EmFat", "Logo.png")

        If File.Exists(defaultLogo) Then
            LogoPictureBox.Image = Image.FromFile(defaultLogo)
        Else
            LogoPictureBox.Image = Nothing
        End If

    End Sub


    Private Sub SalvaDatiEmittente()

        ' Ottieni il percorso della cartella dell'applicazione
        Dim appFolder As String = Application.StartupPath

        ' Usa la cartella dell'applicazione per definire il percorso del file
        Dim filePath As String = Path.Combine(appFolder, "EmFat", "EmittenteFattura.txt")

        ' Usa StreamWriter per aprire il file in modalità aggiunta
        Using writer As New StreamWriter(filePath)

            ' Scrivi i dati dell'emittente
            writer.WriteLine(NomeEmittenteTextBox.Text)
            writer.WriteLine(IndirizzoEmittenteTextBox.Text)
            writer.WriteLine(TelefonoEmittenteTextBox.Text)
            writer.WriteLine(IVAEmittenteTextBox.Text)

            ' Se l'immagine è presente nel PictureBox, salva il percorso dell'immagine
            If LogoPictureBox.Image IsNot Nothing Then
                ' Salva il percorso dell'immagine (ad esempio, percorso completo del file)
                writer.WriteLine(LogoEmittentePath) ' Salva il percorso completo del logo
            Else
                ' Se il logo non è presente, scrivi un valore predefinito o vuoto
                writer.WriteLine("EmFat\nologo.png")
            End If
            ' Salva il percorso dell'immagine (ad esempio, percorso completo del file)
            writer.WriteLine(LogoEmittentePath) ' Salva il percorso completo del logo
        End Using
    End Sub

    Private Sub BtnInserisciLogo_Click(sender As Object, e As EventArgs) Handles BtnInserisciLogo.Click
        ' Crea un dialogo di apertura file per selezionare l'immagine
        Dim openFileDialog As New OpenFileDialog With {
        .Filter = "Immagini|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Tutti i file|*.*",
        .Title = "Seleziona il Logo"
    }

        ' Se l'utente seleziona un file, carica l'immagine nel PictureBox
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Carica l'immagine nel PictureBox
            LogoPictureBox.Image = Image.FromFile(openFileDialog.FileName)

            ' Salva il percorso dell'immagine selezionata nella variabile
            LogoEmittentePath = openFileDialog.FileName

            ' Salva il percorso dell'immagine nel file EmittenteFattura.txt
            SalvaDatiEmittente()
        End If
    End Sub

End Class