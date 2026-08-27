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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RjBtnCerca = New RJCodeAdvance.RJControls.RJButton()
        Me.TxtCerca = New System.Windows.Forms.TextBox()
        Me.FillByMaterialeToolStrip = New System.Windows.Forms.ToolStrip()
        Me.MaterialeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.MaterialeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByMaterialeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OrdiniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WinDBGdRDataSet = New CreaFiltroDvg.WinDBGdRDataSet()
        Me.OrdiniTableAdapter = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.OrdiniTableAdapter()
        Me.FillByMaterialeToolStrip.SuspendLayout()
        CType(Me.OrdiniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinDBGdRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.OrdiniBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CreaFiltroDvg.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(30, 172)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1506, 502)
        Me.ReportViewer1.TabIndex = 0
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
        Me.RjBtnCerca.Location = New System.Drawing.Point(145, 99)
        Me.RjBtnCerca.Name = "RjBtnCerca"
        Me.RjBtnCerca.Size = New System.Drawing.Size(150, 40)
        Me.RjBtnCerca.TabIndex = 1
        Me.RjBtnCerca.Text = "CERCA"
        Me.RjBtnCerca.TextColor = System.Drawing.Color.White
        Me.RjBtnCerca.UseVisualStyleBackColor = False
        '
        'TxtCerca
        '
        Me.TxtCerca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtCerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCerca.Location = New System.Drawing.Point(363, 105)
        Me.TxtCerca.Name = "TxtCerca"
        Me.TxtCerca.Size = New System.Drawing.Size(174, 30)
        Me.TxtCerca.TabIndex = 2
        '
        'FillByMaterialeToolStrip
        '
        Me.FillByMaterialeToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.FillByMaterialeToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByMaterialeToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaterialeToolStripLabel, Me.MaterialeToolStripTextBox, Me.FillByMaterialeToolStripButton})
        Me.FillByMaterialeToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByMaterialeToolStrip.Name = "FillByMaterialeToolStrip"
        Me.FillByMaterialeToolStrip.Size = New System.Drawing.Size(1589, 27)
        Me.FillByMaterialeToolStrip.TabIndex = 3
        Me.FillByMaterialeToolStrip.Text = "FillByMaterialeToolStrip"
        '
        'MaterialeToolStripLabel
        '
        Me.MaterialeToolStripLabel.Name = "MaterialeToolStripLabel"
        Me.MaterialeToolStripLabel.Size = New System.Drawing.Size(75, 24)
        Me.MaterialeToolStripLabel.Text = "materiale:"
        '
        'MaterialeToolStripTextBox
        '
        Me.MaterialeToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MaterialeToolStripTextBox.Name = "MaterialeToolStripTextBox"
        Me.MaterialeToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'FillByMaterialeToolStripButton
        '
        Me.FillByMaterialeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByMaterialeToolStripButton.Name = "FillByMaterialeToolStripButton"
        Me.FillByMaterialeToolStripButton.Size = New System.Drawing.Size(111, 24)
        Me.FillByMaterialeToolStripButton.Text = "FillByMateriale"
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
        'FrmReportOrdini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1589, 762)
        Me.Controls.Add(Me.FillByMaterialeToolStrip)
        Me.Controls.Add(Me.TxtCerca)
        Me.Controls.Add(Me.RjBtnCerca)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReportOrdini"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReportOrdini"
        Me.FillByMaterialeToolStrip.ResumeLayout(False)
        Me.FillByMaterialeToolStrip.PerformLayout()
        CType(Me.OrdiniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinDBGdRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents OrdiniTableAdapter As WinDBGdRDataSetTableAdapters.OrdiniTableAdapter
    Friend WithEvents WinDBGdRDataSet As WinDBGdRDataSet
    Friend WithEvents OrdiniBindingSource As BindingSource
    Friend WithEvents RjBtnCerca As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents TxtCerca As TextBox
    Friend WithEvents FillByMaterialeToolStrip As ToolStrip
    Friend WithEvents MaterialeToolStripLabel As ToolStripLabel
    Friend WithEvents MaterialeToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByMaterialeToolStripButton As ToolStripButton
End Class
