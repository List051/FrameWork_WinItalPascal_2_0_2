<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTest
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.OrdiniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WinDBGdRDataSet = New CreaFiltroDvg.WinDBGdRDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FatturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FatturaTableAdapter = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.FatturaTableAdapter()
        Me.OrdiniTableAdapter = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.OrdiniTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RjBtnPDF = New RJCodeAdvance.RJControls.RJButton()
        Me.RjBtnEsportaPDF = New RJCodeAdvance.RJControls.RJButton()
        CType(Me.OrdiniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinDBGdRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FatturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OrdiniBindingSource
        '
        Me.OrdiniBindingSource.DataMember = "Ordini"
        Me.OrdiniBindingSource.DataSource = Me.WinDBGdRDataSet
        '
        'WinDBGdRDataSet
        '
        Me.WinDBGdRDataSet.DataSetName = "WinDBGdRDataSet"
        Me.WinDBGdRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.OrdiniBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CreaFiltroDvg.Rep2Manager.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 112)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1170, 513)
        Me.ReportViewer1.TabIndex = 0
        '
        'FatturaBindingSource
        '
        Me.FatturaBindingSource.DataMember = "Fattura"
        Me.FatturaBindingSource.DataSource = Me.WinDBGdRDataSet
        '
        'FatturaTableAdapter
        '
        Me.FatturaTableAdapter.ClearBeforeFill = True
        '
        'OrdiniTableAdapter
        '
        Me.OrdiniTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.RjBtnEsportaPDF)
        Me.Panel1.Controls.Add(Me.RjBtnPDF)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1207, 100)
        Me.Panel1.TabIndex = 3
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
        Me.RjBtnPDF.Visible = False
        '
        'RjBtnEsportaPDF
        '
        Me.RjBtnEsportaPDF.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnEsportaPDF.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnEsportaPDF.BorderColor = System.Drawing.Color.Lime
        Me.RjBtnEsportaPDF.BorderRadius = 25
        Me.RjBtnEsportaPDF.BorderSize = 5
        Me.RjBtnEsportaPDF.FlatAppearance.BorderSize = 0
        Me.RjBtnEsportaPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnEsportaPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnEsportaPDF.ForeColor = System.Drawing.Color.White
        Me.RjBtnEsportaPDF.Location = New System.Drawing.Point(340, 23)
        Me.RjBtnEsportaPDF.Name = "RjBtnEsportaPDF"
        Me.RjBtnEsportaPDF.Size = New System.Drawing.Size(469, 61)
        Me.RjBtnEsportaPDF.TabIndex = 2
        Me.RjBtnEsportaPDF.Text = "Stampa o Esporta PDF"
        Me.RjBtnEsportaPDF.TextColor = System.Drawing.Color.White
        Me.RjBtnEsportaPDF.UseVisualStyleBackColor = False
        '
        'FrmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 750)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmTest"
        Me.Text = "FrmTest"
        CType(Me.OrdiniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinDBGdRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FatturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents WinDBGdRDataSet As WinDBGdRDataSet
    Friend WithEvents FatturaBindingSource As BindingSource
    Friend WithEvents FatturaTableAdapter As WinDBGdRDataSetTableAdapters.FatturaTableAdapter
    Friend WithEvents OrdiniBindingSource As BindingSource
    Friend WithEvents OrdiniTableAdapter As WinDBGdRDataSetTableAdapters.OrdiniTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RjBtnPDF As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents RjBtnEsportaPDF As RJCodeAdvance.RJControls.RJButton
End Class
