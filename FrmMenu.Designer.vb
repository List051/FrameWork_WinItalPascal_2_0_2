<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.PanelBody = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RjBtnSenzaFattura = New RJCodeAdvance.RJControls.RJButton()
        Me.RjButton1 = New RJCodeAdvance.RJControls.RJButton()
        Me.RjBtnForm1 = New RJCodeAdvance.RJControls.RJButton()
        Me.RjBtnFattura = New RJCodeAdvance.RJControls.RJButton()
        Me.RjBtnOrdini = New RJCodeAdvance.RJControls.RJButton()
        Me.RjBtnClienti = New RJCodeAdvance.RJControls.RJButton()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.RichTextBox6 = New System.Windows.Forms.RichTextBox()
        Me.PanelBody.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBody
        '
        Me.PanelBody.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelBody.Controls.Add(Me.TabControl1)
        Me.PanelBody.Controls.Add(Me.Panel1)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(0, 0)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(1622, 778)
        Me.PanelBody.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(206, 71)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1404, 695)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1396, 666)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Filtra DataGrid"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(38, 41)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(1304, 549)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.RichTextBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1396, 666)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PopupHelper"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.White
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox2.Location = New System.Drawing.Point(19, 35)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox2.Size = New System.Drawing.Size(1355, 570)
        Me.RichTextBox2.TabIndex = 19
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.RichTextBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1396, 666)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Scrivi Log"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(60, 28)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(1308, 620)
        Me.RichTextBox3.TabIndex = 0
        Me.RichTextBox3.Text = resources.GetString("RichTextBox3.Text")
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.RichTextBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1396, 666)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "ApriDGV"
        '
        'RichTextBox4
        '
        Me.RichTextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(50, 24)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(1308, 639)
        Me.RichTextBox4.TabIndex = 1
        Me.RichTextBox4.Text = resources.GetString("RichTextBox4.Text")
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.RichTextBox5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1396, 666)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Filtra Tutti"
        '
        'RichTextBox5
        '
        Me.RichTextBox5.BackColor = System.Drawing.Color.White
        Me.RichTextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox5.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox5.Location = New System.Drawing.Point(21, 28)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.ReadOnly = True
        Me.RichTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox5.Size = New System.Drawing.Size(1355, 570)
        Me.RichTextBox5.TabIndex = 20
        Me.RichTextBox5.Text = resources.GetString("RichTextBox5.Text")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.RjBtnSenzaFattura)
        Me.Panel1.Controls.Add(Me.RjButton1)
        Me.Panel1.Controls.Add(Me.RjBtnForm1)
        Me.Panel1.Controls.Add(Me.RjBtnFattura)
        Me.Panel1.Controls.Add(Me.RjBtnOrdini)
        Me.Panel1.Controls.Add(Me.RjBtnClienti)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 778)
        Me.Panel1.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'RjBtnSenzaFattura
        '
        Me.RjBtnSenzaFattura.BackColor = System.Drawing.Color.RoyalBlue
        Me.RjBtnSenzaFattura.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.RjBtnSenzaFattura.BorderColor = System.Drawing.Color.Lime
        Me.RjBtnSenzaFattura.BorderRadius = 15
        Me.RjBtnSenzaFattura.BorderSize = 5
        Me.RjBtnSenzaFattura.FlatAppearance.BorderSize = 0
        Me.RjBtnSenzaFattura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnSenzaFattura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnSenzaFattura.ForeColor = System.Drawing.Color.White
        Me.RjBtnSenzaFattura.Location = New System.Drawing.Point(12, 444)
        Me.RjBtnSenzaFattura.Name = "RjBtnSenzaFattura"
        Me.RjBtnSenzaFattura.Size = New System.Drawing.Size(150, 76)
        Me.RjBtnSenzaFattura.TabIndex = 23
        Me.RjBtnSenzaFattura.Text = "Senza Fattura"
        Me.RjBtnSenzaFattura.TextColor = System.Drawing.Color.White
        Me.RjBtnSenzaFattura.UseVisualStyleBackColor = False
        '
        'RjButton1
        '
        Me.RjButton1.BackColor = System.Drawing.Color.RoyalBlue
        Me.RjButton1.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.RjButton1.BorderColor = System.Drawing.Color.Lime
        Me.RjButton1.BorderRadius = 15
        Me.RjButton1.BorderSize = 5
        Me.RjButton1.FlatAppearance.BorderSize = 0
        Me.RjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjButton1.ForeColor = System.Drawing.Color.White
        Me.RjButton1.Location = New System.Drawing.Point(12, 674)
        Me.RjButton1.Name = "RjButton1"
        Me.RjButton1.Size = New System.Drawing.Size(150, 47)
        Me.RjButton1.TabIndex = 22
        Me.RjButton1.Text = "Form Test"
        Me.RjButton1.TextColor = System.Drawing.Color.White
        Me.RjButton1.UseVisualStyleBackColor = False
        '
        'RjBtnForm1
        '
        Me.RjBtnForm1.BackColor = System.Drawing.Color.RoyalBlue
        Me.RjBtnForm1.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.RjBtnForm1.BorderColor = System.Drawing.Color.Lime
        Me.RjBtnForm1.BorderRadius = 15
        Me.RjBtnForm1.BorderSize = 5
        Me.RjBtnForm1.FlatAppearance.BorderSize = 0
        Me.RjBtnForm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnForm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnForm1.ForeColor = System.Drawing.Color.White
        Me.RjBtnForm1.Location = New System.Drawing.Point(12, 557)
        Me.RjBtnForm1.Name = "RjBtnForm1"
        Me.RjBtnForm1.Size = New System.Drawing.Size(150, 77)
        Me.RjBtnForm1.TabIndex = 21
        Me.RjBtnForm1.Text = "Report Ordini"
        Me.RjBtnForm1.TextColor = System.Drawing.Color.White
        Me.RjBtnForm1.UseVisualStyleBackColor = False
        '
        'RjBtnFattura
        '
        Me.RjBtnFattura.BackColor = System.Drawing.Color.RoyalBlue
        Me.RjBtnFattura.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.RjBtnFattura.BorderColor = System.Drawing.Color.Lime
        Me.RjBtnFattura.BorderRadius = 15
        Me.RjBtnFattura.BorderSize = 5
        Me.RjBtnFattura.FlatAppearance.BorderSize = 0
        Me.RjBtnFattura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnFattura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnFattura.ForeColor = System.Drawing.Color.White
        Me.RjBtnFattura.Location = New System.Drawing.Point(12, 344)
        Me.RjBtnFattura.Name = "RjBtnFattura"
        Me.RjBtnFattura.Size = New System.Drawing.Size(150, 47)
        Me.RjBtnFattura.TabIndex = 20
        Me.RjBtnFattura.Text = "Fattura"
        Me.RjBtnFattura.TextColor = System.Drawing.Color.White
        Me.RjBtnFattura.UseVisualStyleBackColor = False
        '
        'RjBtnOrdini
        '
        Me.RjBtnOrdini.BackColor = System.Drawing.Color.RoyalBlue
        Me.RjBtnOrdini.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.RjBtnOrdini.BorderColor = System.Drawing.Color.Lime
        Me.RjBtnOrdini.BorderRadius = 15
        Me.RjBtnOrdini.BorderSize = 5
        Me.RjBtnOrdini.FlatAppearance.BorderSize = 0
        Me.RjBtnOrdini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnOrdini.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnOrdini.ForeColor = System.Drawing.Color.White
        Me.RjBtnOrdini.Location = New System.Drawing.Point(12, 251)
        Me.RjBtnOrdini.Name = "RjBtnOrdini"
        Me.RjBtnOrdini.Size = New System.Drawing.Size(150, 47)
        Me.RjBtnOrdini.TabIndex = 19
        Me.RjBtnOrdini.Text = "Ordini"
        Me.RjBtnOrdini.TextColor = System.Drawing.Color.White
        Me.RjBtnOrdini.UseVisualStyleBackColor = False
        '
        'RjBtnClienti
        '
        Me.RjBtnClienti.BackColor = System.Drawing.Color.RoyalBlue
        Me.RjBtnClienti.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.RjBtnClienti.BorderColor = System.Drawing.Color.Lime
        Me.RjBtnClienti.BorderRadius = 15
        Me.RjBtnClienti.BorderSize = 5
        Me.RjBtnClienti.FlatAppearance.BorderSize = 0
        Me.RjBtnClienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnClienti.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnClienti.ForeColor = System.Drawing.Color.White
        Me.RjBtnClienti.Location = New System.Drawing.Point(12, 149)
        Me.RjBtnClienti.Name = "RjBtnClienti"
        Me.RjBtnClienti.Size = New System.Drawing.Size(150, 47)
        Me.RjBtnClienti.TabIndex = 18
        Me.RjBtnClienti.Text = "Clienti"
        Me.RjBtnClienti.TextColor = System.Drawing.Color.White
        Me.RjBtnClienti.UseVisualStyleBackColor = False
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.RichTextBox6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1396, 666)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Libreria"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'RichTextBox6
        '
        Me.RichTextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox6.Location = New System.Drawing.Point(62, 62)
        Me.RichTextBox6.Name = "RichTextBox6"
        Me.RichTextBox6.Size = New System.Drawing.Size(1286, 585)
        Me.RichTextBox6.TabIndex = 0
        Me.RichTextBox6.Text = resources.GetString("RichTextBox6.Text")
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1622, 778)
        Me.Controls.Add(Me.PanelBody)
        Me.Name = "FrmMenu"
        Me.Text = "FrmMenuvb"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelBody.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBody As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents RjBtnFattura As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents RjBtnOrdini As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents RjBtnClienti As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents RjBtnForm1 As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents RichTextBox5 As RichTextBox
    Friend WithEvents RjButton1 As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents RjBtnSenzaFattura As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents RichTextBox6 As RichTextBox
End Class
