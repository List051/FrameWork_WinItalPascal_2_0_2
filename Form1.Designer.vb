<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FatturaDataGrid = New System.Windows.Forms.DataGridView()
        Me.OrdiniDataGrid = New System.Windows.Forms.DataGridView()
        Me.ClientiDataGrid = New System.Windows.Forms.DataGridView()
        Me.RjButton1 = New RJCodeAdvance.RJControls.RJButton()
        Me.RjBtnRicarica = New RJCodeAdvance.RJControls.RJButton()
        Me.TxtEvidenzia = New System.Windows.Forms.TextBox()
        Me.TxtTutti = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RjBtnCerca = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjBtnFatture = New RJCodeAdvance.RJControls.RJButton()
        CType(Me.FatturaDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdiniDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientiDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjBtnCerca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FatturaDataGrid
        '
        Me.FatturaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FatturaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FatturaDataGrid.Location = New System.Drawing.Point(12, 140)
        Me.FatturaDataGrid.Name = "FatturaDataGrid"
        Me.FatturaDataGrid.RowHeadersWidth = 51
        Me.FatturaDataGrid.RowTemplate.Height = 24
        Me.FatturaDataGrid.Size = New System.Drawing.Size(1700, 387)
        Me.FatturaDataGrid.TabIndex = 0
        '
        'OrdiniDataGrid
        '
        Me.OrdiniDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OrdiniDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrdiniDataGrid.Location = New System.Drawing.Point(12, 555)
        Me.OrdiniDataGrid.Name = "OrdiniDataGrid"
        Me.OrdiniDataGrid.RowHeadersWidth = 51
        Me.OrdiniDataGrid.RowTemplate.Height = 24
        Me.OrdiniDataGrid.Size = New System.Drawing.Size(1700, 153)
        Me.OrdiniDataGrid.TabIndex = 1
        '
        'ClientiDataGrid
        '
        Me.ClientiDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ClientiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientiDataGrid.Location = New System.Drawing.Point(12, 745)
        Me.ClientiDataGrid.Name = "ClientiDataGrid"
        Me.ClientiDataGrid.RowHeadersWidth = 51
        Me.ClientiDataGrid.RowTemplate.Height = 24
        Me.ClientiDataGrid.Size = New System.Drawing.Size(1700, 142)
        Me.ClientiDataGrid.TabIndex = 2
        '
        'RjButton1
        '
        Me.RjButton1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjButton1.BorderColor = System.Drawing.Color.Lime
        Me.RjButton1.BorderRadius = 25
        Me.RjButton1.BorderSize = 5
        Me.RjButton1.FlatAppearance.BorderSize = 0
        Me.RjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjButton1.ForeColor = System.Drawing.Color.White
        Me.RjButton1.Location = New System.Drawing.Point(67, 82)
        Me.RjButton1.Name = "RjButton1"
        Me.RjButton1.Size = New System.Drawing.Size(185, 52)
        Me.RjButton1.TabIndex = 3
        Me.RjButton1.Text = "Apri Ordini"
        Me.RjButton1.TextColor = System.Drawing.Color.White
        Me.RjButton1.UseVisualStyleBackColor = False
        '
        'RjBtnRicarica
        '
        Me.RjBtnRicarica.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnRicarica.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnRicarica.BorderColor = System.Drawing.Color.Lime
        Me.RjBtnRicarica.BorderRadius = 25
        Me.RjBtnRicarica.BorderSize = 5
        Me.RjBtnRicarica.FlatAppearance.BorderSize = 0
        Me.RjBtnRicarica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnRicarica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnRicarica.ForeColor = System.Drawing.Color.White
        Me.RjBtnRicarica.Location = New System.Drawing.Point(252, 82)
        Me.RjBtnRicarica.Name = "RjBtnRicarica"
        Me.RjBtnRicarica.Size = New System.Drawing.Size(185, 52)
        Me.RjBtnRicarica.TabIndex = 4
        Me.RjBtnRicarica.Text = "Ricarica"
        Me.RjBtnRicarica.TextColor = System.Drawing.Color.White
        Me.RjBtnRicarica.UseVisualStyleBackColor = False
        '
        'TxtEvidenzia
        '
        Me.TxtEvidenzia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtEvidenzia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEvidenzia.Location = New System.Drawing.Point(580, 93)
        Me.TxtEvidenzia.Name = "TxtEvidenzia"
        Me.TxtEvidenzia.Size = New System.Drawing.Size(250, 30)
        Me.TxtEvidenzia.TabIndex = 9
        '
        'TxtTutti
        '
        Me.TxtTutti.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTutti.Cursor = System.Windows.Forms.Cursors.Help
        Me.TxtTutti.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTutti.Location = New System.Drawing.Point(1224, 90)
        Me.TxtTutti.Name = "TxtTutti"
        Me.TxtTutti.Size = New System.Drawing.Size(171, 34)
        Me.TxtTutti.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1131, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cerca"
        '
        'RjBtnCerca
        '
        Me.RjBtnCerca.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjBtnCerca.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjBtnCerca.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjBtnCerca.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjBtnCerca.BorderSize = 2
        Me.RjBtnCerca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RjBtnCerca.GradientAngle = 50.0!
        Me.RjBtnCerca.Image = CType(resources.GetObject("RjBtnCerca.Image"), System.Drawing.Image)
        Me.RjBtnCerca.Location = New System.Drawing.Point(510, 64)
        Me.RjBtnCerca.Name = "RjBtnCerca"
        Me.RjBtnCerca.Size = New System.Drawing.Size(64, 64)
        Me.RjBtnCerca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjBtnCerca.TabIndex = 7
        Me.RjBtnCerca.TabStop = False
        '
        'RjBtnFatture
        '
        Me.RjBtnFatture.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnFatture.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnFatture.BorderColor = System.Drawing.Color.Lime
        Me.RjBtnFatture.BorderRadius = 25
        Me.RjBtnFatture.BorderSize = 5
        Me.RjBtnFatture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RjBtnFatture.FlatAppearance.BorderSize = 0
        Me.RjBtnFatture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnFatture.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnFatture.ForeColor = System.Drawing.Color.White
        Me.RjBtnFatture.Location = New System.Drawing.Point(861, 76)
        Me.RjBtnFatture.Name = "RjBtnFatture"
        Me.RjBtnFatture.Size = New System.Drawing.Size(185, 52)
        Me.RjBtnFatture.TabIndex = 12
        Me.RjBtnFatture.Text = "Apri Fattura"
        Me.RjBtnFatture.TextColor = System.Drawing.Color.White
        Me.RjBtnFatture.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 886)
        Me.Controls.Add(Me.RjBtnFatture)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTutti)
        Me.Controls.Add(Me.TxtEvidenzia)
        Me.Controls.Add(Me.RjBtnCerca)
        Me.Controls.Add(Me.RjBtnRicarica)
        Me.Controls.Add(Me.RjButton1)
        Me.Controls.Add(Me.ClientiDataGrid)
        Me.Controls.Add(Me.OrdiniDataGrid)
        Me.Controls.Add(Me.FatturaDataGrid)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FatturaDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdiniDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientiDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjBtnCerca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FatturaDataGrid As DataGridView
    Friend WithEvents OrdiniDataGrid As DataGridView
    Friend WithEvents ClientiDataGrid As DataGridView
    Friend WithEvents RjButton1 As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents RjBtnRicarica As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents RjBtnCerca As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents TxtEvidenzia As TextBox
    Friend WithEvents TxtTutti As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RjBtnFatture As RJCodeAdvance.RJControls.RJButton
End Class
