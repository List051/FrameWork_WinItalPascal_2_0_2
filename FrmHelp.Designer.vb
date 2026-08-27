<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHelp
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHelp))
        Me.PanelColoraDGV = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RjCircBtnApriColoraDGV = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RjCircBtnApriClientiOrd = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.RjCircBtpPdfFattura = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PanelColoraDGV.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircBtnApriColoraDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircBtnApriClientiOrd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircBtpPdfFattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelColoraDGV
        '
        Me.PanelColoraDGV.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelColoraDGV.Controls.Add(Me.Label9)
        Me.PanelColoraDGV.Controls.Add(Me.Label2)
        Me.PanelColoraDGV.Controls.Add(Me.Label1)
        Me.PanelColoraDGV.Controls.Add(Me.PictureBox1)
        Me.PanelColoraDGV.Controls.Add(Me.RjCircBtnApriColoraDGV)
        Me.PanelColoraDGV.Location = New System.Drawing.Point(70, 93)
        Me.PanelColoraDGV.Name = "PanelColoraDGV"
        Me.PanelColoraDGV.Size = New System.Drawing.Size(383, 483)
        Me.PanelColoraDGV.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(296, 87)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Qualsiasi DataBase" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Importante in App.config" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """MiaConnessione"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apri ColoraDGV"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ColoraDGV"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox1.Image = Global.CreaFiltroDvg.My.Resources.Resources.pdfico
        Me.PictureBox1.Location = New System.Drawing.Point(37, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'RjCircBtnApriColoraDGV
        '
        Me.RjCircBtnApriColoraDGV.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCircBtnApriColoraDGV.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCircBtnApriColoraDGV.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCircBtnApriColoraDGV.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCircBtnApriColoraDGV.BorderSize = 2
        Me.RjCircBtnApriColoraDGV.Cursor = System.Windows.Forms.Cursors.Help
        Me.RjCircBtnApriColoraDGV.GradientAngle = 50.0!
        Me.RjCircBtnApriColoraDGV.Image = Global.CreaFiltroDvg.My.Resources.Resources.social_page
        Me.RjCircBtnApriColoraDGV.Location = New System.Drawing.Point(37, 195)
        Me.RjCircBtnApriColoraDGV.Name = "RjCircBtnApriColoraDGV"
        Me.RjCircBtnApriColoraDGV.Size = New System.Drawing.Size(100, 100)
        Me.RjCircBtnApriColoraDGV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircBtnApriColoraDGV.TabIndex = 0
        Me.RjCircBtnApriColoraDGV.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.RjCircBtnApriClientiOrd)
        Me.Panel1.Location = New System.Drawing.Point(497, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 483)
        Me.Panel1.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(306, 116)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Inserisce Nuovo Ordine" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Controllo Ordini collegati" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Evidenzia Ricerche" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Filtro Is" &
    "tantaneo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(143, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apri Clienti-Ordini"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(160, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Gestione Clienti"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox2.Image = Global.CreaFiltroDvg.My.Resources.Resources.pdfico
        Me.PictureBox2.Location = New System.Drawing.Point(37, 69)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 105)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'RjCircBtnApriClientiOrd
        '
        Me.RjCircBtnApriClientiOrd.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCircBtnApriClientiOrd.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCircBtnApriClientiOrd.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCircBtnApriClientiOrd.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCircBtnApriClientiOrd.BorderSize = 2
        Me.RjCircBtnApriClientiOrd.Cursor = System.Windows.Forms.Cursors.Help
        Me.RjCircBtnApriClientiOrd.GradientAngle = 50.0!
        Me.RjCircBtnApriClientiOrd.Image = Global.CreaFiltroDvg.My.Resources.Resources.social_page
        Me.RjCircBtnApriClientiOrd.Location = New System.Drawing.Point(37, 195)
        Me.RjCircBtnApriClientiOrd.Name = "RjCircBtnApriClientiOrd"
        Me.RjCircBtnApriClientiOrd.Size = New System.Drawing.Size(100, 100)
        Me.RjCircBtnApriClientiOrd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircBtnApriClientiOrd.TabIndex = 0
        Me.RjCircBtnApriClientiOrd.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.RjCircBtpPdfFattura)
        Me.Panel2.Location = New System.Drawing.Point(922, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(407, 483)
        Me.Panel2.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(373, 145)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Inserisce Nuova Fattura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inserisce Emittente Fattura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Controllo Fatture NON emess" &
    "e" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Salva Fattura in PDF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stampa Fattura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(143, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(260, 29)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Apri Gestione Fattura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(160, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 29)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Gestione Fattura"
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox3.Image = Global.CreaFiltroDvg.My.Resources.Resources.pdfico
        Me.PictureBox3.Location = New System.Drawing.Point(37, 69)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 105)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'RjCircBtpPdfFattura
        '
        Me.RjCircBtpPdfFattura.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCircBtpPdfFattura.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCircBtpPdfFattura.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCircBtpPdfFattura.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCircBtpPdfFattura.BorderSize = 2
        Me.RjCircBtpPdfFattura.Cursor = System.Windows.Forms.Cursors.Help
        Me.RjCircBtpPdfFattura.GradientAngle = 50.0!
        Me.RjCircBtpPdfFattura.Image = Global.CreaFiltroDvg.My.Resources.Resources.social_page
        Me.RjCircBtpPdfFattura.Location = New System.Drawing.Point(37, 195)
        Me.RjCircBtpPdfFattura.Name = "RjCircBtpPdfFattura"
        Me.RjCircBtpPdfFattura.Size = New System.Drawing.Size(100, 100)
        Me.RjCircBtpPdfFattura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircBtpPdfFattura.TabIndex = 0
        Me.RjCircBtpPdfFattura.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(79, 613)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1255, 425)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'FrmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1391, 850)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelColoraDGV)
        Me.Name = "FrmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmHelp"
        Me.PanelColoraDGV.ResumeLayout(False)
        Me.PanelColoraDGV.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircBtnApriColoraDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircBtnApriClientiOrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircBtpPdfFattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelColoraDGV As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RjCircBtnApriColoraDGV As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RjCircBtnApriClientiOrd As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents RjCircBtpPdfFattura As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label9 As Label
End Class
