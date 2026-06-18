<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReportOrdini
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.OrdiniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WinDBGdRDataSet = New CreaFiltroDvg.WinDBGdRDataSet()
        Me.OrdiniTableAdapter = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.OrdiniTableAdapter()
        Me.RjBtnCerca = New RJCodeAdvance.RJControls.RJButton()
        CType(Me.OrdiniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinDBGdRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.OrdiniBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CreaFiltroDvg.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(30, 172)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1506, 502)
        Me.ReportViewer1.TabIndex = 0
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
        'OrdiniTableAdapter
        '
        Me.OrdiniTableAdapter.ClearBeforeFill = True
        '
        'RjBtnCerca
        '
        Me.RjBtnCerca.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnCerca.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnCerca.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RjBtnCerca.BorderRadius = 0
        Me.RjBtnCerca.BorderSize = 0
        Me.RjBtnCerca.FlatAppearance.BorderSize = 0
        Me.RjBtnCerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnCerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnCerca.ForeColor = System.Drawing.Color.White
        Me.RjBtnCerca.Location = New System.Drawing.Point(145, 73)
        Me.RjBtnCerca.Name = "RjBtnCerca"
        Me.RjBtnCerca.Size = New System.Drawing.Size(150, 40)
        Me.RjBtnCerca.TabIndex = 1
        Me.RjBtnCerca.Text = "CERCA"
        Me.RjBtnCerca.TextColor = System.Drawing.Color.White
        Me.RjBtnCerca.UseVisualStyleBackColor = False
        '
        'FrmReportOrdini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1589, 762)
        Me.Controls.Add(Me.RjBtnCerca)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReportOrdini"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReportOrdini"
        CType(Me.OrdiniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinDBGdRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents OrdiniTableAdapter As WinDBGdRDataSetTableAdapters.OrdiniTableAdapter
    Friend WithEvents WinDBGdRDataSet As WinDBGdRDataSet
    Friend WithEvents OrdiniBindingSource As BindingSource
    Friend WithEvents RjBtnCerca As RJCodeAdvance.RJControls.RJButton
End Class
