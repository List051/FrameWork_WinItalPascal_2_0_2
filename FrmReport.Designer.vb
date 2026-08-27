<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReport
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RjBtnEsportaPDF = New RJCodeAdvance.RJControls.RJButton()
        Me.RjBtnPDF = New RJCodeAdvance.RJControls.RJButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1396, 813)
        Me.ReportViewer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.RjBtnEsportaPDF)
        Me.Panel1.Controls.Add(Me.RjBtnPDF)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 713)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1396, 100)
        Me.Panel1.TabIndex = 1
        '
        'RjBtnEsportaPDF
        '
        Me.RjBtnEsportaPDF.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnEsportaPDF.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnEsportaPDF.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RjBtnEsportaPDF.BorderRadius = 0
        Me.RjBtnEsportaPDF.BorderSize = 0
        Me.RjBtnEsportaPDF.FlatAppearance.BorderSize = 0
        Me.RjBtnEsportaPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnEsportaPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnEsportaPDF.ForeColor = System.Drawing.Color.White
        Me.RjBtnEsportaPDF.Location = New System.Drawing.Point(341, 29)
        Me.RjBtnEsportaPDF.Name = "RjBtnEsportaPDF"
        Me.RjBtnEsportaPDF.Size = New System.Drawing.Size(207, 40)
        Me.RjBtnEsportaPDF.TabIndex = 4
        Me.RjBtnEsportaPDF.Text = "Esporta PDF"
        Me.RjBtnEsportaPDF.TextColor = System.Drawing.Color.White
        Me.RjBtnEsportaPDF.UseVisualStyleBackColor = False
        '
        'RjBtnPDF
        '
        Me.RjBtnPDF.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnPDF.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnPDF.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RjBtnPDF.BorderRadius = 0
        Me.RjBtnPDF.BorderSize = 0
        Me.RjBtnPDF.FlatAppearance.BorderSize = 0
        Me.RjBtnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnPDF.ForeColor = System.Drawing.Color.White
        Me.RjBtnPDF.Location = New System.Drawing.Point(101, 29)
        Me.RjBtnPDF.Name = "RjBtnPDF"
        Me.RjBtnPDF.Size = New System.Drawing.Size(150, 40)
        Me.RjBtnPDF.TabIndex = 3
        Me.RjBtnPDF.Text = "PDF"
        Me.RjBtnPDF.TextColor = System.Drawing.Color.White
        Me.RjBtnPDF.UseVisualStyleBackColor = False
        '
        'FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1396, 813)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReport"
        Me.Text = "FrmReport"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RjBtnEsportaPDF As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents RjBtnPDF As RJCodeAdvance.RJControls.RJButton
End Class
