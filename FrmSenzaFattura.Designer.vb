<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSenzaFattura
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OrdNoFatDataGrid = New System.Windows.Forms.DataGridView()
        Me.IDOrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCliOrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtaOrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzoOrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImportoOrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdiniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WinDBGdRDataSet = New CreaFiltroDvg.WinDBGdRDataSet()
        Me.MancantiDataGrid = New System.Windows.Forms.DataGridView()
        Me.IDFatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDOrdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataFatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeFatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImportoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataFuturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdiniTableAdapter = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.OrdiniTableAdapter()
        Me.FatturaTableAdapter = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.FatturaTableAdapter()
        Me.RjBtnStamaSenzaFattura = New RJCodeAdvance.RJControls.RJButton()
        Me.LabelNomeFat = New System.Windows.Forms.Label()
        Me.ClientiDataGrid = New System.Windows.Forms.DataGridView()
        Me.IdClientiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndirizzoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CittaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientiTableAdapter = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.ClientiTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RjCircularPictureBox1 = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjCBtnCambiaCartella = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.OrdNoFatDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdiniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinDBGdRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MancantiDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FatturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientiDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCBtnCambiaCartella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrdNoFatDataGrid
        '
        Me.OrdNoFatDataGrid.AllowUserToAddRows = False
        Me.OrdNoFatDataGrid.AllowUserToDeleteRows = False
        Me.OrdNoFatDataGrid.AllowUserToOrderColumns = True
        Me.OrdNoFatDataGrid.AutoGenerateColumns = False
        Me.OrdNoFatDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrdNoFatDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDOrd, Me.IDCliOrd, Me.Mat, Me.QtaOrd, Me.PrezzoOrd, Me.ImportoOrd, Me.Data})
        Me.OrdNoFatDataGrid.DataSource = Me.OrdiniBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OrdNoFatDataGrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.OrdNoFatDataGrid.Location = New System.Drawing.Point(39, 243)
        Me.OrdNoFatDataGrid.Name = "OrdNoFatDataGrid"
        Me.OrdNoFatDataGrid.ReadOnly = True
        Me.OrdNoFatDataGrid.RowHeadersWidth = 51
        Me.OrdNoFatDataGrid.RowTemplate.Height = 24
        Me.OrdNoFatDataGrid.Size = New System.Drawing.Size(1402, 460)
        Me.OrdNoFatDataGrid.TabIndex = 0
        '
        'IDOrd
        '
        Me.IDOrd.DataPropertyName = "IDOrd"
        Me.IDOrd.HeaderText = "IDOrd"
        Me.IDOrd.MinimumWidth = 6
        Me.IDOrd.Name = "IDOrd"
        Me.IDOrd.ReadOnly = True
        Me.IDOrd.Width = 60
        '
        'IDCliOrd
        '
        Me.IDCliOrd.DataPropertyName = "IDCliOrd"
        Me.IDCliOrd.HeaderText = "IDCliOrd"
        Me.IDCliOrd.MinimumWidth = 6
        Me.IDCliOrd.Name = "IDCliOrd"
        Me.IDCliOrd.ReadOnly = True
        Me.IDCliOrd.Width = 60
        '
        'Mat
        '
        Me.Mat.DataPropertyName = "Mat"
        Me.Mat.HeaderText = "Materiale Ordinato"
        Me.Mat.MinimumWidth = 6
        Me.Mat.Name = "Mat"
        Me.Mat.ReadOnly = True
        Me.Mat.Width = 545
        '
        'QtaOrd
        '
        Me.QtaOrd.DataPropertyName = "QtaOrd"
        Me.QtaOrd.HeaderText = "QtaOrd"
        Me.QtaOrd.MinimumWidth = 6
        Me.QtaOrd.Name = "QtaOrd"
        Me.QtaOrd.ReadOnly = True
        Me.QtaOrd.Width = 60
        '
        'PrezzoOrd
        '
        Me.PrezzoOrd.DataPropertyName = "PrezzoOrd"
        Me.PrezzoOrd.HeaderText = "PrezzoOrd"
        Me.PrezzoOrd.MinimumWidth = 6
        Me.PrezzoOrd.Name = "PrezzoOrd"
        Me.PrezzoOrd.ReadOnly = True
        Me.PrezzoOrd.Width = 130
        '
        'ImportoOrd
        '
        Me.ImportoOrd.DataPropertyName = "ImportoOrd"
        Me.ImportoOrd.HeaderText = "ImportoOrd"
        Me.ImportoOrd.MinimumWidth = 6
        Me.ImportoOrd.Name = "ImportoOrd"
        Me.ImportoOrd.ReadOnly = True
        Me.ImportoOrd.Width = 130
        '
        'Data
        '
        Me.Data.DataPropertyName = "Data"
        Me.Data.HeaderText = "Data"
        Me.Data.MinimumWidth = 6
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        Me.Data.Width = 6
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
        'MancantiDataGrid
        '
        Me.MancantiDataGrid.AutoGenerateColumns = False
        Me.MancantiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MancantiDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDFatDataGridViewTextBoxColumn, Me.IDCliDataGridViewTextBoxColumn, Me.IDOrdDataGridViewTextBoxColumn1, Me.NumDataGridViewTextBoxColumn, Me.DataFatDataGridViewTextBoxColumn, Me.NomeFatDataGridViewTextBoxColumn, Me.DescrDataGridViewTextBoxColumn, Me.QtaDataGridViewTextBoxColumn, Me.PrezzoDataGridViewTextBoxColumn, Me.ImportoDataGridViewTextBoxColumn, Me.ImageDataGridViewTextBoxColumn, Me.DataFuturaDataGridViewTextBoxColumn})
        Me.MancantiDataGrid.DataSource = Me.FatturaBindingSource
        Me.MancantiDataGrid.Location = New System.Drawing.Point(186, 12)
        Me.MancantiDataGrid.Name = "MancantiDataGrid"
        Me.MancantiDataGrid.RowHeadersWidth = 51
        Me.MancantiDataGrid.RowTemplate.Height = 24
        Me.MancantiDataGrid.Size = New System.Drawing.Size(100, 71)
        Me.MancantiDataGrid.TabIndex = 1
        Me.MancantiDataGrid.Visible = False
        '
        'IDFatDataGridViewTextBoxColumn
        '
        Me.IDFatDataGridViewTextBoxColumn.DataPropertyName = "IDFat"
        Me.IDFatDataGridViewTextBoxColumn.HeaderText = "IDFat"
        Me.IDFatDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDFatDataGridViewTextBoxColumn.Name = "IDFatDataGridViewTextBoxColumn"
        Me.IDFatDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDFatDataGridViewTextBoxColumn.Width = 125
        '
        'IDCliDataGridViewTextBoxColumn
        '
        Me.IDCliDataGridViewTextBoxColumn.DataPropertyName = "IDCli"
        Me.IDCliDataGridViewTextBoxColumn.HeaderText = "IDCli"
        Me.IDCliDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDCliDataGridViewTextBoxColumn.Name = "IDCliDataGridViewTextBoxColumn"
        Me.IDCliDataGridViewTextBoxColumn.Width = 125
        '
        'IDOrdDataGridViewTextBoxColumn1
        '
        Me.IDOrdDataGridViewTextBoxColumn1.DataPropertyName = "IDOrd"
        Me.IDOrdDataGridViewTextBoxColumn1.HeaderText = "IDOrd"
        Me.IDOrdDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IDOrdDataGridViewTextBoxColumn1.Name = "IDOrdDataGridViewTextBoxColumn1"
        Me.IDOrdDataGridViewTextBoxColumn1.Width = 125
        '
        'NumDataGridViewTextBoxColumn
        '
        Me.NumDataGridViewTextBoxColumn.DataPropertyName = "Num"
        Me.NumDataGridViewTextBoxColumn.HeaderText = "Num"
        Me.NumDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumDataGridViewTextBoxColumn.Name = "NumDataGridViewTextBoxColumn"
        Me.NumDataGridViewTextBoxColumn.Width = 125
        '
        'DataFatDataGridViewTextBoxColumn
        '
        Me.DataFatDataGridViewTextBoxColumn.DataPropertyName = "DataFat"
        Me.DataFatDataGridViewTextBoxColumn.HeaderText = "DataFat"
        Me.DataFatDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DataFatDataGridViewTextBoxColumn.Name = "DataFatDataGridViewTextBoxColumn"
        Me.DataFatDataGridViewTextBoxColumn.Width = 125
        '
        'NomeFatDataGridViewTextBoxColumn
        '
        Me.NomeFatDataGridViewTextBoxColumn.DataPropertyName = "NomeFat"
        Me.NomeFatDataGridViewTextBoxColumn.HeaderText = "NomeFat"
        Me.NomeFatDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NomeFatDataGridViewTextBoxColumn.Name = "NomeFatDataGridViewTextBoxColumn"
        Me.NomeFatDataGridViewTextBoxColumn.Width = 125
        '
        'DescrDataGridViewTextBoxColumn
        '
        Me.DescrDataGridViewTextBoxColumn.DataPropertyName = "Descr"
        Me.DescrDataGridViewTextBoxColumn.HeaderText = "Descr"
        Me.DescrDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescrDataGridViewTextBoxColumn.Name = "DescrDataGridViewTextBoxColumn"
        Me.DescrDataGridViewTextBoxColumn.Width = 125
        '
        'QtaDataGridViewTextBoxColumn
        '
        Me.QtaDataGridViewTextBoxColumn.DataPropertyName = "Qta"
        Me.QtaDataGridViewTextBoxColumn.HeaderText = "Qta"
        Me.QtaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QtaDataGridViewTextBoxColumn.Name = "QtaDataGridViewTextBoxColumn"
        Me.QtaDataGridViewTextBoxColumn.Width = 125
        '
        'PrezzoDataGridViewTextBoxColumn
        '
        Me.PrezzoDataGridViewTextBoxColumn.DataPropertyName = "Prezzo"
        Me.PrezzoDataGridViewTextBoxColumn.HeaderText = "Prezzo"
        Me.PrezzoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrezzoDataGridViewTextBoxColumn.Name = "PrezzoDataGridViewTextBoxColumn"
        Me.PrezzoDataGridViewTextBoxColumn.Width = 125
        '
        'ImportoDataGridViewTextBoxColumn
        '
        Me.ImportoDataGridViewTextBoxColumn.DataPropertyName = "Importo"
        Me.ImportoDataGridViewTextBoxColumn.HeaderText = "Importo"
        Me.ImportoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ImportoDataGridViewTextBoxColumn.Name = "ImportoDataGridViewTextBoxColumn"
        Me.ImportoDataGridViewTextBoxColumn.Width = 125
        '
        'ImageDataGridViewTextBoxColumn
        '
        Me.ImageDataGridViewTextBoxColumn.DataPropertyName = "Image"
        Me.ImageDataGridViewTextBoxColumn.HeaderText = "Image"
        Me.ImageDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ImageDataGridViewTextBoxColumn.Name = "ImageDataGridViewTextBoxColumn"
        Me.ImageDataGridViewTextBoxColumn.Width = 125
        '
        'DataFuturaDataGridViewTextBoxColumn
        '
        Me.DataFuturaDataGridViewTextBoxColumn.DataPropertyName = "DataFutura"
        Me.DataFuturaDataGridViewTextBoxColumn.HeaderText = "DataFutura"
        Me.DataFuturaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DataFuturaDataGridViewTextBoxColumn.Name = "DataFuturaDataGridViewTextBoxColumn"
        Me.DataFuturaDataGridViewTextBoxColumn.Width = 125
        '
        'FatturaBindingSource
        '
        Me.FatturaBindingSource.DataMember = "Fattura"
        Me.FatturaBindingSource.DataSource = Me.WinDBGdRDataSet
        '
        'OrdiniTableAdapter
        '
        Me.OrdiniTableAdapter.ClearBeforeFill = True
        '
        'FatturaTableAdapter
        '
        Me.FatturaTableAdapter.ClearBeforeFill = True
        '
        'RjBtnStamaSenzaFattura
        '
        Me.RjBtnStamaSenzaFattura.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnStamaSenzaFattura.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnStamaSenzaFattura.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RjBtnStamaSenzaFattura.BorderRadius = 0
        Me.RjBtnStamaSenzaFattura.BorderSize = 0
        Me.RjBtnStamaSenzaFattura.FlatAppearance.BorderSize = 0
        Me.RjBtnStamaSenzaFattura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnStamaSenzaFattura.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnStamaSenzaFattura.ForeColor = System.Drawing.Color.White
        Me.RjBtnStamaSenzaFattura.Location = New System.Drawing.Point(80, 89)
        Me.RjBtnStamaSenzaFattura.Name = "RjBtnStamaSenzaFattura"
        Me.RjBtnStamaSenzaFattura.Size = New System.Drawing.Size(336, 40)
        Me.RjBtnStamaSenzaFattura.TabIndex = 2
        Me.RjBtnStamaSenzaFattura.Text = "Stampa Ordini senza Fattura"
        Me.RjBtnStamaSenzaFattura.TextColor = System.Drawing.Color.White
        Me.RjBtnStamaSenzaFattura.UseVisualStyleBackColor = False
        '
        'LabelNomeFat
        '
        Me.LabelNomeFat.AutoSize = True
        Me.LabelNomeFat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNomeFat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelNomeFat.Location = New System.Drawing.Point(611, 183)
        Me.LabelNomeFat.Name = "LabelNomeFat"
        Me.LabelNomeFat.Size = New System.Drawing.Size(115, 29)
        Me.LabelNomeFat.TabIndex = 3
        Me.LabelNomeFat.Text = "nomeFat"
        '
        'ClientiDataGrid
        '
        Me.ClientiDataGrid.AutoGenerateColumns = False
        Me.ClientiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientiDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClientiDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.IndirizzoDataGridViewTextBoxColumn, Me.CittaDataGridViewTextBoxColumn, Me.ProvDataGridViewTextBoxColumn, Me.CAPDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn, Me.PIVADataGridViewTextBoxColumn})
        Me.ClientiDataGrid.DataSource = Me.ClientiBindingSource
        Me.ClientiDataGrid.Location = New System.Drawing.Point(80, 12)
        Me.ClientiDataGrid.Name = "ClientiDataGrid"
        Me.ClientiDataGrid.RowHeadersWidth = 51
        Me.ClientiDataGrid.RowTemplate.Height = 24
        Me.ClientiDataGrid.Size = New System.Drawing.Size(100, 66)
        Me.ClientiDataGrid.TabIndex = 4
        Me.ClientiDataGrid.Visible = False
        '
        'IdClientiDataGridViewTextBoxColumn
        '
        Me.IdClientiDataGridViewTextBoxColumn.DataPropertyName = "IdClienti"
        Me.IdClientiDataGridViewTextBoxColumn.HeaderText = "IdClienti"
        Me.IdClientiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdClientiDataGridViewTextBoxColumn.Name = "IdClientiDataGridViewTextBoxColumn"
        Me.IdClientiDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdClientiDataGridViewTextBoxColumn.Width = 125
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.Width = 125
        '
        'IndirizzoDataGridViewTextBoxColumn
        '
        Me.IndirizzoDataGridViewTextBoxColumn.DataPropertyName = "Indirizzo"
        Me.IndirizzoDataGridViewTextBoxColumn.HeaderText = "Indirizzo"
        Me.IndirizzoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IndirizzoDataGridViewTextBoxColumn.Name = "IndirizzoDataGridViewTextBoxColumn"
        Me.IndirizzoDataGridViewTextBoxColumn.Width = 125
        '
        'CittaDataGridViewTextBoxColumn
        '
        Me.CittaDataGridViewTextBoxColumn.DataPropertyName = "Citta"
        Me.CittaDataGridViewTextBoxColumn.HeaderText = "Citta"
        Me.CittaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CittaDataGridViewTextBoxColumn.Name = "CittaDataGridViewTextBoxColumn"
        Me.CittaDataGridViewTextBoxColumn.Width = 125
        '
        'ProvDataGridViewTextBoxColumn
        '
        Me.ProvDataGridViewTextBoxColumn.DataPropertyName = "Prov"
        Me.ProvDataGridViewTextBoxColumn.HeaderText = "Prov"
        Me.ProvDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProvDataGridViewTextBoxColumn.Name = "ProvDataGridViewTextBoxColumn"
        Me.ProvDataGridViewTextBoxColumn.Width = 125
        '
        'CAPDataGridViewTextBoxColumn
        '
        Me.CAPDataGridViewTextBoxColumn.DataPropertyName = "CAP"
        Me.CAPDataGridViewTextBoxColumn.HeaderText = "CAP"
        Me.CAPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CAPDataGridViewTextBoxColumn.Name = "CAPDataGridViewTextBoxColumn"
        Me.CAPDataGridViewTextBoxColumn.Width = 125
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "Tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "Tel"
        Me.TelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        Me.TelDataGridViewTextBoxColumn.Width = 125
        '
        'PIVADataGridViewTextBoxColumn
        '
        Me.PIVADataGridViewTextBoxColumn.DataPropertyName = "P_IVA"
        Me.PIVADataGridViewTextBoxColumn.HeaderText = "P_IVA"
        Me.PIVADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PIVADataGridViewTextBoxColumn.Name = "PIVADataGridViewTextBoxColumn"
        Me.PIVADataGridViewTextBoxColumn.Width = 125
        '
        'ClientiBindingSource
        '
        Me.ClientiBindingSource.DataMember = "Clienti"
        Me.ClientiBindingSource.DataSource = Me.WinDBGdRDataSet
        '
        'ClientiTableAdapter
        '
        Me.ClientiTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Effettuare una fattura al cliente "
        '
        'RjCircularPictureBox1
        '
        Me.RjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCircularPictureBox1.BorderSize = 2
        Me.RjCircularPictureBox1.GradientAngle = 50.0!
        Me.RjCircularPictureBox1.Image = Global.CreaFiltroDvg.My.Resources.Resources.destra
        Me.RjCircularPictureBox1.Location = New System.Drawing.Point(485, 137)
        Me.RjCircularPictureBox1.Name = "RjCircularPictureBox1"
        Me.RjCircularPictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.RjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircularPictureBox1.TabIndex = 6
        Me.RjCircularPictureBox1.TabStop = False
        '
        'RjCBtnCambiaCartella
        '
        Me.RjCBtnCambiaCartella.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCBtnCambiaCartella.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCBtnCambiaCartella.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCBtnCambiaCartella.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCBtnCambiaCartella.BorderSize = 2
        Me.RjCBtnCambiaCartella.GradientAngle = 50.0!
        Me.RjCBtnCambiaCartella.Image = Global.CreaFiltroDvg.My.Resources.Resources.folders2
        Me.RjCBtnCambiaCartella.Location = New System.Drawing.Point(829, 60)
        Me.RjCBtnCambiaCartella.Name = "RjCBtnCambiaCartella"
        Me.RjCBtnCambiaCartella.Size = New System.Drawing.Size(100, 100)
        Me.RjCBtnCambiaCartella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCBtnCambiaCartella.TabIndex = 7
        Me.RjCBtnCambiaCartella.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(961, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(368, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cambia cartella di Salvataggio"
        '
        'FrmSenzaFattura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1497, 760)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RjCBtnCambiaCartella)
        Me.Controls.Add(Me.RjCircularPictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ClientiDataGrid)
        Me.Controls.Add(Me.LabelNomeFat)
        Me.Controls.Add(Me.RjBtnStamaSenzaFattura)
        Me.Controls.Add(Me.MancantiDataGrid)
        Me.Controls.Add(Me.OrdNoFatDataGrid)
        Me.Name = "FrmSenzaFattura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSenzaFattura"
        CType(Me.OrdNoFatDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdiniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinDBGdRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MancantiDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FatturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientiDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircularPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCBtnCambiaCartella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OrdNoFatDataGrid As DataGridView
    Friend WithEvents WinDBGdRDataSet As WinDBGdRDataSet
    Friend WithEvents OrdiniBindingSource As BindingSource
    Friend WithEvents OrdiniTableAdapter As WinDBGdRDataSetTableAdapters.OrdiniTableAdapter
    Friend WithEvents MancantiDataGrid As DataGridView
    Friend WithEvents FatturaBindingSource As BindingSource
    Friend WithEvents FatturaTableAdapter As WinDBGdRDataSetTableAdapters.FatturaTableAdapter
    Friend WithEvents IDFatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDOrdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataFatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeFatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrezzoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImportoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataFuturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RjBtnStamaSenzaFattura As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents LabelNomeFat As Label
    Friend WithEvents ClientiDataGrid As DataGridView
    Friend WithEvents ClientiBindingSource As BindingSource
    Friend WithEvents ClientiTableAdapter As WinDBGdRDataSetTableAdapters.ClientiTableAdapter
    Friend WithEvents IdClientiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndirizzoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CittaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CAPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PIVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents RjCircularPictureBox1 As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents IDOrd As DataGridViewTextBoxColumn
    Friend WithEvents IDCliOrd As DataGridViewTextBoxColumn
    Friend WithEvents Mat As DataGridViewTextBoxColumn
    Friend WithEvents QtaOrd As DataGridViewTextBoxColumn
    Friend WithEvents PrezzoOrd As DataGridViewTextBoxColumn
    Friend WithEvents ImportoOrd As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents RjCBtnCambiaCartella As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Label2 As Label
End Class
