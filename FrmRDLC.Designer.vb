<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRDLC
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
        Me.OrdiniTableAdapter1 = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.OrdiniTableAdapter()
        Me.WinDBGdRDataSet = New CreaFiltroDvg.WinDBGdRDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RjBtnPDF = New RJCodeAdvance.RJControls.RJButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.WinDBGdRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OrdiniTableAdapter1
        '
        Me.OrdiniTableAdapter1.ClearBeforeFill = True
        '
        'WinDBGdRDataSet
        '
        Me.WinDBGdRDataSet.DataSetName = "WinDBGdRDataSet"
        Me.WinDBGdRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 154)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1628, 569)
        Me.ReportViewer1.TabIndex = 0
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
        Me.RjBtnPDF.Location = New System.Drawing.Point(100, 33)
        Me.RjBtnPDF.Name = "RjBtnPDF"
        Me.RjBtnPDF.Size = New System.Drawing.Size(150, 40)
        Me.RjBtnPDF.TabIndex = 1
        Me.RjBtnPDF.Text = "PDF"
        Me.RjBtnPDF.TextColor = System.Drawing.Color.White
        Me.RjBtnPDF.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.RjBtnPDF)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1671, 100)
        Me.Panel1.TabIndex = 2
        '
        'FrmRDLC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1671, 742)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmRDLC"
        Me.Text = "FrmRDLC"
        CType(Me.WinDBGdRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OrdiniTableAdapter1 As WinDBGdRDataSetTableAdapters.OrdiniTableAdapter
    Friend WithEvents WinDBGdRDataSet As WinDBGdRDataSet
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RjBtnPDF As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Panel1 As Panel
End Class
