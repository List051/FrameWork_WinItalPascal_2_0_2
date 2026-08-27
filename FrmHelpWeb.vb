Imports WinItalPascal

Public Class FrmHelpWeb


    Private Sub FrmHelpWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ScreenUtility.FullScreen(Me)
        FrmTitolo.CTitolo(Me, "Apro File Index di WEb Help")

        Dim file As String = ModHelp.PercorsoIndice()

        WebView21.Source = New Uri(file)
    End Sub
End Class