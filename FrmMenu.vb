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
        page6()

    End Sub

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
        Form1.Show()
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
        ColoraPiuParole(RichTextBox1, lista, Color.BlueViolet)
        ColoraPiuParole(RichTextBox1, lista2, Color.Blue)
        ' per i commenti
        ColoraRigheConComm(RichTextBox1, "'", Color.Green)
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
        ColoraParoleColori(RichTextBox2, paroleColori)
        ColoraRigheConParola(RichTextBox2, "System.Drawing.Image", Color.Red)
        ColoraRigheConComm(RichTextBox2, "'", Color.Green)
        Dim lista As New List(Of String) From {"imgCerca", "imgSalva", "imgCliente", "if", "end if", "dim"}
        Dim lista2 As New List(Of String) From {"AttachPopup", "PopUpHelper", "Nothing"}
        ColoraPiuParole(RichTextBox2, lista, Color.BlueViolet)
        ColoraPiuParole(RichTextBox2, lista2, Color.Blue)

    End Sub

    Sub page3()
        Dim lista As New List(Of String) From {"ScriviLog", "ScriviLogMsg", "integer", "if ", "end if", "dim", "GridUtility"}
        Dim lista2 As New List(Of String) From {"Clientidatagrid", "LogLeggiScrivi", "Utente", "Id"}
        ColoraPiuParole(RichTextBox3, lista, Color.BlueViolet)
        ColoraPiuParole(RichTextBox3, lista2, Color.Blue)
        ColoraRigheConComm(RichTextBox3, "'", Color.Green)
        ColoraRigheConParola(RichTextBox3, "errore", Color.Red)
        EvidenziaRiga(RichTextBox3, 0, Color.Yellow)
        ColoraRiga(RichTextBox3, 0, Color.Red)
    End Sub

    Sub page4()
        Dim lista As New List(Of String) From {"ScriviLog", "ScriviLogMsg", "DataGVLoad", "ApriDGV", "if ", "end if", "dim", "GridUtility"}
        Dim lista2 As New List(Of String) From {"Clientidatagrid", "LogLeggiScrivi", "IDCliOrd", "IdOrd"}
        ColoraPiuParole(RichTextBox4, lista, Color.BlueViolet)
        ColoraPiuParole(RichTextBox4, lista2, Color.Blue)
        ColoraRigheConComm(RichTextBox4, "'", Color.Green)
        ColoraRigheConParola(RichTextBox4, "errore", Color.Red)
        EvidenziaRiga(RichTextBox4, 0, Color.Yellow)
        ColoraRiga(RichTextBox4, 0, Color.Red)
    End Sub

    Sub page5()
        ColoraRigheConComm(RichTextBox5, "'", Color.Green)
        Dim lista As New List(Of String) From {"ScriviLog", "ScriviLogMsg", "DataGVLoad", "ApriDGV", "integer", "if ", "end if", "dim", "GridUtility"}
        Dim lista2 As New List(Of String) From {"Clientidatagrid", "FillDataTable", "DataTable", "DataView", "MiaQry", "DtClienti", "DvClienti"}
        Dim lista3 As New List(Of String) From {"Dim MiaQry As String ", "Cliente LIKE"}
        ColoraRigheConParola(RichTextBox5, "DB", Color.Red)
        ColoraRigheConParola(RichTextBox5, "TxtCercaCliente.Text", Color.Black)
        ColoraPiuParole(RichTextBox5, lista, Color.BlueViolet)
        ColoraPiuParole(RichTextBox5, lista2, Color.Blue)
        ColoraPiuParole(RichTextBox5, lista3, Color.Blue)

        EvidenziaRiga(RichTextBox5, 0, Color.Yellow)
        ColoraRiga(RichTextBox5, 0, Color.Red)
        EvidenziaRiga(RichTextBox5, 9, Color.Yellow)
        ColoraRiga(RichTextBox5, 9, Color.Red)
        EvidenziaRiga(RichTextBox5, 19, Color.Yellow)
        ColoraRiga(RichTextBox5, 19, Color.Red)
    End Sub

    Sub page6()

        ColoraRigheConParola(RichTextBox6, "Nuova Funzione", Color.Red)
        ColoraRigheConParola(RichTextBox6, "ColoraGrid", Color.Blue)
    End Sub

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