Imports iTextSharp.text.pdf.parser
Imports System.Drawing


Public Class SimpleRenderListener
    Implements IRenderListener

    Public Property RenderedImage As Image

    Public Sub BeginTextBlock() Implements IRenderListener.BeginTextBlock
    End Sub

    Public Sub EndTextBlock() Implements IRenderListener.EndTextBlock
    End Sub

    Public Sub RenderImage(renderInfo As ImageRenderInfo) Implements IRenderListener.RenderImage
        Dim imgObj = renderInfo.GetImage()
        Dim bytes() As Byte = imgObj.GetImageAsBytes()
        Using ms As New IO.MemoryStream(bytes)
            RenderedImage = Image.FromStream(ms)
        End Using
    End Sub

    Public Sub RenderText(renderInfo As TextRenderInfo) Implements IRenderListener.RenderText
    End Sub

End Class