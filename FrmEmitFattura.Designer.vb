<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmitFattura
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RjCircularPictureBox1 = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.BtnInserisciLogo = New System.Windows.Forms.Button()
        Me.RjBtnSalvaDatiEmittente = New RJCodeAdvance.RJControls.RJButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IVAEmittenteTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TelefonoEmittenteTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IndirizzoEmittenteTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NomeEmittenteTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.RjCircularPictureBox1)
        Me.Panel1.Controls.Add(Me.LogoPictureBox)
        Me.Panel1.Controls.Add(Me.BtnInserisciLogo)
        Me.Panel1.Controls.Add(Me.RjBtnSalvaDatiEmittente)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(832, 593)
        Me.Panel1.TabIndex = 0
        '
        'RjCircularPictureBox1
        '
        Me.RjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCircularPictureBox1.BorderSize = 2
        Me.RjCircularPictureBox1.GradientAngle = 50.0!
        Me.RjCircularPictureBox1.Image = Global.CreaFiltroDvg.My.Resources.Resources.sinistra
        Me.RjCircularPictureBox1.Location = New System.Drawing.Point(242, 60)
        Me.RjCircularPictureBox1.Name = "RjCircularPictureBox1"
        Me.RjCircularPictureBox1.Size = New System.Drawing.Size(87, 87)
        Me.RjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircularPictureBox1.TabIndex = 4
        Me.RjCircularPictureBox1.TabStop = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Location = New System.Drawing.Point(74, 60)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(100, 79)
        Me.LogoPictureBox.TabIndex = 3
        Me.LogoPictureBox.TabStop = False
        '
        'BtnInserisciLogo
        '
        Me.BtnInserisciLogo.BackColor = System.Drawing.Color.Orange
        Me.BtnInserisciLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInserisciLogo.Image = Global.CreaFiltroDvg.My.Resources.Resources.logoEmittente
        Me.BtnInserisciLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInserisciLogo.Location = New System.Drawing.Point(360, 65)
        Me.BtnInserisciLogo.Name = "BtnInserisciLogo"
        Me.BtnInserisciLogo.Size = New System.Drawing.Size(234, 74)
        Me.BtnInserisciLogo.TabIndex = 2
        Me.BtnInserisciLogo.Text = "Inserisci Logo"
        Me.BtnInserisciLogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInserisciLogo.UseVisualStyleBackColor = False
        '
        'RjBtnSalvaDatiEmittente
        '
        Me.RjBtnSalvaDatiEmittente.BackColor = System.Drawing.Color.Orange
        Me.RjBtnSalvaDatiEmittente.BackgroundColor = System.Drawing.Color.Orange
        Me.RjBtnSalvaDatiEmittente.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RjBtnSalvaDatiEmittente.BorderRadius = 0
        Me.RjBtnSalvaDatiEmittente.BorderSize = 0
        Me.RjBtnSalvaDatiEmittente.FlatAppearance.BorderSize = 0
        Me.RjBtnSalvaDatiEmittente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnSalvaDatiEmittente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnSalvaDatiEmittente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RjBtnSalvaDatiEmittente.Location = New System.Drawing.Point(108, 505)
        Me.RjBtnSalvaDatiEmittente.Name = "RjBtnSalvaDatiEmittente"
        Me.RjBtnSalvaDatiEmittente.Size = New System.Drawing.Size(654, 40)
        Me.RjBtnSalvaDatiEmittente.TabIndex = 1
        Me.RjBtnSalvaDatiEmittente.Text = "Salva dati Emittente Fattura"
        Me.RjBtnSalvaDatiEmittente.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RjBtnSalvaDatiEmittente.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lime
        Me.Panel2.Controls.Add(Me.IVAEmittenteTextBox)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TelefonoEmittenteTextBox)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.IndirizzoEmittenteTextBox)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.NomeEmittenteTextBox)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(31, 206)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(764, 271)
        Me.Panel2.TabIndex = 0
        '
        'IVAEmittenteTextBox
        '
        Me.IVAEmittenteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IVAEmittenteTextBox.Location = New System.Drawing.Point(249, 197)
        Me.IVAEmittenteTextBox.Name = "IVAEmittenteTextBox"
        Me.IVAEmittenteTextBox.Size = New System.Drawing.Size(482, 30)
        Me.IVAEmittenteTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "P.IVA Emittente"
        '
        'TelefonoEmittenteTextBox
        '
        Me.TelefonoEmittenteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoEmittenteTextBox.Location = New System.Drawing.Point(249, 142)
        Me.TelefonoEmittenteTextBox.Name = "TelefonoEmittenteTextBox"
        Me.TelefonoEmittenteTextBox.Size = New System.Drawing.Size(482, 30)
        Me.TelefonoEmittenteTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Recapito Emittente"
        '
        'IndirizzoEmittenteTextBox
        '
        Me.IndirizzoEmittenteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndirizzoEmittenteTextBox.Location = New System.Drawing.Point(249, 92)
        Me.IndirizzoEmittenteTextBox.Name = "IndirizzoEmittenteTextBox"
        Me.IndirizzoEmittenteTextBox.Size = New System.Drawing.Size(482, 30)
        Me.IndirizzoEmittenteTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Indirizzo Emittente"
        '
        'NomeEmittenteTextBox
        '
        Me.NomeEmittenteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeEmittenteTextBox.Location = New System.Drawing.Point(249, 34)
        Me.NomeEmittenteTextBox.Name = "NomeEmittenteTextBox"
        Me.NomeEmittenteTextBox.Size = New System.Drawing.Size(482, 30)
        Me.NomeEmittenteTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome Emittente"
        '
        'FrmEmitFattura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 593)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmEmitFattura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEmitFattura"
        Me.Panel1.ResumeLayout(False)
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NomeEmittenteTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IVAEmittenteTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TelefonoEmittenteTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents IndirizzoEmittenteTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RjBtnSalvaDatiEmittente As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents BtnInserisciLogo As Button
    Friend WithEvents RjCircularPictureBox1 As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents LogoPictureBox As PictureBox
End Class
