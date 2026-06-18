<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestFatture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestFatture))
        Me.FatDataGrid = New System.Windows.Forms.DataGridView()
        Me.IDFat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDOrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataFat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeFat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prezzo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Image = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataFutura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WinDBGdRDataSet = New CreaFiltroDvg.WinDBGdRDataSet()
        Me.OrdDataGrid = New System.Windows.Forms.DataGridView()
        Me.IDOrdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCliOrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtaOrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzoOrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImportoOrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdiniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.TableAdapterManager()
        Me.FatturaTableAdapter = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.FatturaTableAdapter()
        Me.OrdiniTableAdapter = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.OrdiniTableAdapter()
        Me.ClientiTableAdapter = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.ClientiTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtIdCli = New System.Windows.Forms.TextBox()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtColli = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPrezzo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtImporto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtIVA = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblIVA = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtTotaleConIVA = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RjBtnEseguiCalcoli = New RJCodeAdvance.RJControls.RJButton()
        Me.TxtNomeFat = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.RjCircBtnAnteprima = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjGeneraPDF = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjCircBtnCambiaCartella = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjCircBtnEmittente = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjTutteFat = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjCercaFattura = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjBtnLog = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjCircApriDGVQry = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjCircClienti = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjCircOrdini = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjCercaFatKO = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjSalvaFattura = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.RjCircBtnNuovaFattura = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        CType(Me.FatDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FatturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinDBGdRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdiniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientiDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircBtnAnteprima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjGeneraPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircBtnCambiaCartella, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircBtnEmittente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjTutteFat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCercaFattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjBtnLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircApriDGVQry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircClienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircOrdini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCercaFatKO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjSalvaFattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircBtnNuovaFattura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FatDataGrid
        '
        Me.FatDataGrid.AutoGenerateColumns = False
        Me.FatDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FatDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDFat, Me.IDCli, Me.IDOrd, Me.Num, Me.DataFat, Me.NomeFat, Me.Descr, Me.Qta, Me.Prezzo, Me.Importo, Me.Image, Me.DataFutura})
        Me.FatDataGrid.DataSource = Me.FatturaBindingSource
        Me.FatDataGrid.Location = New System.Drawing.Point(27, 166)
        Me.FatDataGrid.Name = "FatDataGrid"
        Me.FatDataGrid.RowHeadersWidth = 51
        Me.FatDataGrid.RowTemplate.Height = 24
        Me.FatDataGrid.Size = New System.Drawing.Size(1755, 278)
        Me.FatDataGrid.TabIndex = 0
        '
        'IDFat
        '
        Me.IDFat.DataPropertyName = "IDFat"
        Me.IDFat.HeaderText = "IDFat"
        Me.IDFat.MinimumWidth = 6
        Me.IDFat.Name = "IDFat"
        Me.IDFat.ReadOnly = True
        Me.IDFat.Width = 50
        '
        'IDCli
        '
        Me.IDCli.DataPropertyName = "IDCli"
        Me.IDCli.HeaderText = "IDCliente"
        Me.IDCli.MinimumWidth = 6
        Me.IDCli.Name = "IDCli"
        Me.IDCli.Width = 65
        '
        'IDOrd
        '
        Me.IDOrd.DataPropertyName = "IDOrd"
        Me.IDOrd.HeaderText = "IDOrd"
        Me.IDOrd.MinimumWidth = 6
        Me.IDOrd.Name = "IDOrd"
        Me.IDOrd.Width = 50
        '
        'Num
        '
        Me.Num.DataPropertyName = "Num"
        Me.Num.HeaderText = "N. Fattura"
        Me.Num.MinimumWidth = 6
        Me.Num.Name = "Num"
        Me.Num.Width = 50
        '
        'DataFat
        '
        Me.DataFat.DataPropertyName = "DataFat"
        Me.DataFat.HeaderText = "Data Fattura"
        Me.DataFat.MinimumWidth = 6
        Me.DataFat.Name = "DataFat"
        Me.DataFat.Width = 80
        '
        'NomeFat
        '
        Me.NomeFat.DataPropertyName = "NomeFat"
        Me.NomeFat.HeaderText = "Nome in Fattura"
        Me.NomeFat.MinimumWidth = 6
        Me.NomeFat.Name = "NomeFat"
        Me.NomeFat.Width = 325
        '
        'Descr
        '
        Me.Descr.DataPropertyName = "Descr"
        Me.Descr.HeaderText = "Descrizione"
        Me.Descr.MinimumWidth = 6
        Me.Descr.Name = "Descr"
        Me.Descr.Width = 425
        '
        'Qta
        '
        Me.Qta.DataPropertyName = "Qta"
        Me.Qta.HeaderText = "Qta"
        Me.Qta.MinimumWidth = 6
        Me.Qta.Name = "Qta"
        Me.Qta.Width = 50
        '
        'Prezzo
        '
        Me.Prezzo.DataPropertyName = "Prezzo"
        Me.Prezzo.HeaderText = "Prezzo"
        Me.Prezzo.MinimumWidth = 6
        Me.Prezzo.Name = "Prezzo"
        Me.Prezzo.Width = 125
        '
        'Importo
        '
        Me.Importo.DataPropertyName = "Importo"
        Me.Importo.HeaderText = "Importo"
        Me.Importo.MinimumWidth = 6
        Me.Importo.Name = "Importo"
        Me.Importo.Width = 125
        '
        'Image
        '
        Me.Image.DataPropertyName = "Image"
        Me.Image.HeaderText = "Pagato"
        Me.Image.MinimumWidth = 6
        Me.Image.Name = "Image"
        Me.Image.Width = 70
        '
        'DataFutura
        '
        Me.DataFutura.DataPropertyName = "DataFutura"
        Me.DataFutura.HeaderText = "DataFutura"
        Me.DataFutura.MinimumWidth = 6
        Me.DataFutura.Name = "DataFutura"
        Me.DataFutura.Width = 80
        '
        'FatturaBindingSource
        '
        Me.FatturaBindingSource.DataMember = "Fattura"
        Me.FatturaBindingSource.DataSource = Me.WinDBGdRDataSet
        '
        'WinDBGdRDataSet
        '
        Me.WinDBGdRDataSet.DataSetName = "WinDBGdRDataSet"
        Me.WinDBGdRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdDataGrid
        '
        Me.OrdDataGrid.AutoGenerateColumns = False
        Me.OrdDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrdDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDOrdDataGridViewTextBoxColumn1, Me.IDCliOrd, Me.MatDataGridViewTextBoxColumn, Me.QtaOrd, Me.PrezzoOrd, Me.ImportoOrd})
        Me.OrdDataGrid.DataSource = Me.OrdiniBindingSource
        Me.OrdDataGrid.Location = New System.Drawing.Point(37, 691)
        Me.OrdDataGrid.Name = "OrdDataGrid"
        Me.OrdDataGrid.RowHeadersWidth = 51
        Me.OrdDataGrid.RowTemplate.Height = 24
        Me.OrdDataGrid.Size = New System.Drawing.Size(1619, 198)
        Me.OrdDataGrid.TabIndex = 2
        '
        'IDOrdDataGridViewTextBoxColumn1
        '
        Me.IDOrdDataGridViewTextBoxColumn1.DataPropertyName = "IDOrd"
        Me.IDOrdDataGridViewTextBoxColumn1.HeaderText = "IDOrd"
        Me.IDOrdDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IDOrdDataGridViewTextBoxColumn1.Name = "IDOrdDataGridViewTextBoxColumn1"
        Me.IDOrdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDOrdDataGridViewTextBoxColumn1.Width = 60
        '
        'IDCliOrd
        '
        Me.IDCliOrd.DataPropertyName = "IDCliOrd"
        Me.IDCliOrd.HeaderText = "IDCliente"
        Me.IDCliOrd.MinimumWidth = 6
        Me.IDCliOrd.Name = "IDCliOrd"
        Me.IDCliOrd.Width = 80
        '
        'MatDataGridViewTextBoxColumn
        '
        Me.MatDataGridViewTextBoxColumn.DataPropertyName = "Mat"
        Me.MatDataGridViewTextBoxColumn.HeaderText = "Materiale"
        Me.MatDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MatDataGridViewTextBoxColumn.Name = "MatDataGridViewTextBoxColumn"
        Me.MatDataGridViewTextBoxColumn.Width = 620
        '
        'QtaOrd
        '
        Me.QtaOrd.DataPropertyName = "QtaOrd"
        Me.QtaOrd.HeaderText = "Quantità"
        Me.QtaOrd.MinimumWidth = 6
        Me.QtaOrd.Name = "QtaOrd"
        Me.QtaOrd.Width = 60
        '
        'PrezzoOrd
        '
        Me.PrezzoOrd.DataPropertyName = "PrezzoOrd"
        Me.PrezzoOrd.HeaderText = "Prezzo"
        Me.PrezzoOrd.MinimumWidth = 6
        Me.PrezzoOrd.Name = "PrezzoOrd"
        Me.PrezzoOrd.Width = 160
        '
        'ImportoOrd
        '
        Me.ImportoOrd.DataPropertyName = "ImportoOrd"
        Me.ImportoOrd.HeaderText = "Importo"
        Me.ImportoOrd.MinimumWidth = 6
        Me.ImportoOrd.Name = "ImportoOrd"
        Me.ImportoOrd.Width = 160
        '
        'OrdiniBindingSource
        '
        Me.OrdiniBindingSource.DataMember = "Ordini"
        Me.OrdiniBindingSource.DataSource = Me.WinDBGdRDataSet
        '
        'ClientiDataGrid
        '
        Me.ClientiDataGrid.AutoGenerateColumns = False
        Me.ClientiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientiDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClientiDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.IndirizzoDataGridViewTextBoxColumn, Me.CittaDataGridViewTextBoxColumn, Me.ProvDataGridViewTextBoxColumn, Me.CAPDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn, Me.PIVADataGridViewTextBoxColumn})
        Me.ClientiDataGrid.DataSource = Me.ClientiBindingSource
        Me.ClientiDataGrid.Location = New System.Drawing.Point(27, 921)
        Me.ClientiDataGrid.Name = "ClientiDataGrid"
        Me.ClientiDataGrid.RowHeadersWidth = 51
        Me.ClientiDataGrid.RowTemplate.Height = 24
        Me.ClientiDataGrid.Size = New System.Drawing.Size(1629, 104)
        Me.ClientiDataGrid.TabIndex = 4
        '
        'IdClientiDataGridViewTextBoxColumn
        '
        Me.IdClientiDataGridViewTextBoxColumn.DataPropertyName = "IdClienti"
        Me.IdClientiDataGridViewTextBoxColumn.HeaderText = "IdClienti"
        Me.IdClientiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdClientiDataGridViewTextBoxColumn.Name = "IdClientiDataGridViewTextBoxColumn"
        Me.IdClientiDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdClientiDataGridViewTextBoxColumn.Width = 70
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.Width = 325
        '
        'IndirizzoDataGridViewTextBoxColumn
        '
        Me.IndirizzoDataGridViewTextBoxColumn.DataPropertyName = "Indirizzo"
        Me.IndirizzoDataGridViewTextBoxColumn.HeaderText = "Indirizzo"
        Me.IndirizzoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IndirizzoDataGridViewTextBoxColumn.Name = "IndirizzoDataGridViewTextBoxColumn"
        Me.IndirizzoDataGridViewTextBoxColumn.Width = 325
        '
        'CittaDataGridViewTextBoxColumn
        '
        Me.CittaDataGridViewTextBoxColumn.DataPropertyName = "Citta"
        Me.CittaDataGridViewTextBoxColumn.HeaderText = "Citta"
        Me.CittaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CittaDataGridViewTextBoxColumn.Name = "CittaDataGridViewTextBoxColumn"
        Me.CittaDataGridViewTextBoxColumn.Width = 225
        '
        'ProvDataGridViewTextBoxColumn
        '
        Me.ProvDataGridViewTextBoxColumn.DataPropertyName = "Prov"
        Me.ProvDataGridViewTextBoxColumn.HeaderText = "Prov"
        Me.ProvDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProvDataGridViewTextBoxColumn.Name = "ProvDataGridViewTextBoxColumn"
        Me.ProvDataGridViewTextBoxColumn.Width = 50
        '
        'CAPDataGridViewTextBoxColumn
        '
        Me.CAPDataGridViewTextBoxColumn.DataPropertyName = "CAP"
        Me.CAPDataGridViewTextBoxColumn.HeaderText = "CAP"
        Me.CAPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CAPDataGridViewTextBoxColumn.Name = "CAPDataGridViewTextBoxColumn"
        Me.CAPDataGridViewTextBoxColumn.Width = 50
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "Tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "Tel"
        Me.TelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        Me.TelDataGridViewTextBoxColumn.Width = 180
        '
        'PIVADataGridViewTextBoxColumn
        '
        Me.PIVADataGridViewTextBoxColumn.DataPropertyName = "P_IVA"
        Me.PIVADataGridViewTextBoxColumn.HeaderText = "P_IVA"
        Me.PIVADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PIVADataGridViewTextBoxColumn.Name = "PIVADataGridViewTextBoxColumn"
        Me.PIVADataGridViewTextBoxColumn.Width = 225
        '
        'ClientiBindingSource
        '
        Me.ClientiBindingSource.DataMember = "Clienti"
        Me.ClientiBindingSource.DataSource = Me.WinDBGdRDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(32, 645)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Cerca Cliente con Fattura da emettere"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(47, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Salva Fattura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(39, 602)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(303, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Cerca Cliente con ApriDgvQry"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(953, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "LOG"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientiTableAdapter = Nothing
        Me.TableAdapterManager.FatturaTableAdapter = Me.FatturaTableAdapter
        Me.TableAdapterManager.MaterialeTableAdapter = Nothing
        Me.TableAdapterManager.OrdiniTableAdapter = Me.OrdiniTableAdapter
        Me.TableAdapterManager.UpdateOrder = CreaFiltroDvg.WinDBGdRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FatturaTableAdapter
        '
        Me.FatturaTableAdapter.ClearBeforeFill = True
        '
        'OrdiniTableAdapter
        '
        Me.OrdiniTableAdapter.ClearBeforeFill = True
        '
        'ClientiTableAdapter
        '
        Me.ClientiTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(293, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Cerca Fattura da emettere"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(309, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 25)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "IDCliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 479)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 25)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Q.tà"
        '
        'TxtIdCli
        '
        Me.TxtIdCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtIdCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdCli.Location = New System.Drawing.Point(325, 131)
        Me.TxtIdCli.Name = "TxtIdCli"
        Me.TxtIdCli.Size = New System.Drawing.Size(74, 27)
        Me.TxtIdCli.TabIndex = 24
        Me.TxtIdCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNum
        '
        Me.TxtNum.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TxtNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNum.ForeColor = System.Drawing.Color.Navy
        Me.TxtNum.Location = New System.Drawing.Point(450, 131)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(74, 27)
        Me.TxtNum.TabIndex = 25
        Me.TxtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(746, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 25)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Tutte le fatture"
        '
        'TxtColli
        '
        Me.TxtColli.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtColli.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtColli.ForeColor = System.Drawing.Color.Navy
        Me.TxtColli.Location = New System.Drawing.Point(94, 477)
        Me.TxtColli.Name = "TxtColli"
        Me.TxtColli.ReadOnly = True
        Me.TxtColli.Size = New System.Drawing.Size(74, 27)
        Me.TxtColli.TabIndex = 29
        Me.TxtColli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(445, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 25)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "N. Fattura"
        '
        'TxtPrezzo
        '
        Me.TxtPrezzo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtPrezzo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrezzo.ForeColor = System.Drawing.Color.Navy
        Me.TxtPrezzo.Location = New System.Drawing.Point(325, 477)
        Me.TxtPrezzo.Name = "TxtPrezzo"
        Me.TxtPrezzo.ReadOnly = True
        Me.TxtPrezzo.Size = New System.Drawing.Size(179, 27)
        Me.TxtPrezzo.TabIndex = 31
        Me.TxtPrezzo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(239, 479)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 25)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Prezzo"
        '
        'TxtImporto
        '
        Me.TxtImporto.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtImporto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImporto.ForeColor = System.Drawing.Color.Navy
        Me.TxtImporto.Location = New System.Drawing.Point(607, 477)
        Me.TxtImporto.Name = "TxtImporto"
        Me.TxtImporto.ReadOnly = True
        Me.TxtImporto.Size = New System.Drawing.Size(187, 27)
        Me.TxtImporto.TabIndex = 33
        Me.TxtImporto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(510, 479)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 25)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Importo"
        '
        'TxtIVA
        '
        Me.TxtIVA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIVA.ForeColor = System.Drawing.Color.Navy
        Me.TxtIVA.Location = New System.Drawing.Point(114, 530)
        Me.TxtIVA.Name = "TxtIVA"
        Me.TxtIVA.Size = New System.Drawing.Size(74, 27)
        Me.TxtIVA.TabIndex = 35
        Me.TxtIVA.Text = "23"
        Me.TxtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(35, 532)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 25)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "IVA %"
        '
        'LblIVA
        '
        Me.LblIVA.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIVA.ForeColor = System.Drawing.Color.Navy
        Me.LblIVA.Location = New System.Drawing.Point(404, 530)
        Me.LblIVA.Name = "LblIVA"
        Me.LblIVA.ReadOnly = True
        Me.LblIVA.Size = New System.Drawing.Size(152, 27)
        Me.LblIVA.TabIndex = 39
        Me.LblIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(239, 532)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(145, 25)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "IVA Calcolata"
        '
        'TxtTotaleConIVA
        '
        Me.TxtTotaleConIVA.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtTotaleConIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotaleConIVA.ForeColor = System.Drawing.Color.Navy
        Me.TxtTotaleConIVA.Location = New System.Drawing.Point(1016, 530)
        Me.TxtTotaleConIVA.Name = "TxtTotaleConIVA"
        Me.TxtTotaleConIVA.ReadOnly = True
        Me.TxtTotaleConIVA.Size = New System.Drawing.Size(192, 27)
        Me.TxtTotaleConIVA.TabIndex = 41
        Me.TxtTotaleConIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(854, 532)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(156, 25)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Totale con IVA"
        '
        'RjBtnEseguiCalcoli
        '
        Me.RjBtnEseguiCalcoli.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnEseguiCalcoli.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnEseguiCalcoli.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RjBtnEseguiCalcoli.BorderRadius = 0
        Me.RjBtnEseguiCalcoli.BorderSize = 0
        Me.RjBtnEseguiCalcoli.FlatAppearance.BorderSize = 0
        Me.RjBtnEseguiCalcoli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnEseguiCalcoli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnEseguiCalcoli.ForeColor = System.Drawing.Color.White
        Me.RjBtnEseguiCalcoli.Location = New System.Drawing.Point(607, 524)
        Me.RjBtnEseguiCalcoli.Name = "RjBtnEseguiCalcoli"
        Me.RjBtnEseguiCalcoli.Size = New System.Drawing.Size(209, 40)
        Me.RjBtnEseguiCalcoli.TabIndex = 42
        Me.RjBtnEseguiCalcoli.Text = "Esegui Calcoli"
        Me.RjBtnEseguiCalcoli.TextColor = System.Drawing.Color.White
        Me.RjBtnEseguiCalcoli.UseVisualStyleBackColor = False
        '
        'TxtNomeFat
        '
        Me.TxtNomeFat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomeFat.Location = New System.Drawing.Point(1264, 465)
        Me.TxtNomeFat.Multiline = True
        Me.TxtNomeFat.Name = "TxtNomeFat"
        Me.TxtNomeFat.Size = New System.Drawing.Size(518, 205)
        Me.TxtNomeFat.TabIndex = 43
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1056, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 25)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Emittente Fattura"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1576, 131)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(207, 25)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Cartella Salvataggio"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1369, 130)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 25)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "PDF Fattura"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1035, 645)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(184, 25)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "Anteprima Fattura"
        '
        'RjCircBtnAnteprima
        '
        Me.RjCircBtnAnteprima.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCircBtnAnteprima.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCircBtnAnteprima.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCircBtnAnteprima.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCircBtnAnteprima.BorderSize = 2
        Me.RjCircBtnAnteprima.GradientAngle = 50.0!
        Me.RjCircBtnAnteprima.Image = Global.CreaFiltroDvg.My.Resources.Resources.stampa
        Me.RjCircBtnAnteprima.Location = New System.Drawing.Point(973, 629)
        Me.RjCircBtnAnteprima.Name = "RjCircBtnAnteprima"
        Me.RjCircBtnAnteprima.Size = New System.Drawing.Size(56, 56)
        Me.RjCircBtnAnteprima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircBtnAnteprima.TabIndex = 51
        Me.RjCircBtnAnteprima.TabStop = False
        '
        'RjGeneraPDF
        '
        Me.RjGeneraPDF.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjGeneraPDF.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjGeneraPDF.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjGeneraPDF.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjGeneraPDF.BorderSize = 2
        Me.RjGeneraPDF.GradientAngle = 50.0!
        Me.RjGeneraPDF.Image = Global.CreaFiltroDvg.My.Resources.Resources.stampa
        Me.RjGeneraPDF.Location = New System.Drawing.Point(1399, 64)
        Me.RjGeneraPDF.Name = "RjGeneraPDF"
        Me.RjGeneraPDF.Size = New System.Drawing.Size(56, 56)
        Me.RjGeneraPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjGeneraPDF.TabIndex = 49
        Me.RjGeneraPDF.TabStop = False
        '
        'RjCircBtnCambiaCartella
        '
        Me.RjCircBtnCambiaCartella.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCircBtnCambiaCartella.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCircBtnCambiaCartella.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCircBtnCambiaCartella.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCircBtnCambiaCartella.BorderSize = 2
        Me.RjCircBtnCambiaCartella.GradientAngle = 50.0!
        Me.RjCircBtnCambiaCartella.Image = Global.CreaFiltroDvg.My.Resources.Resources.folders2
        Me.RjCircBtnCambiaCartella.Location = New System.Drawing.Point(1655, 72)
        Me.RjCircBtnCambiaCartella.Name = "RjCircBtnCambiaCartella"
        Me.RjCircBtnCambiaCartella.Size = New System.Drawing.Size(56, 56)
        Me.RjCircBtnCambiaCartella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircBtnCambiaCartella.TabIndex = 48
        Me.RjCircBtnCambiaCartella.TabStop = False
        '
        'RjCircBtnEmittente
        '
        Me.RjCircBtnEmittente.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCircBtnEmittente.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCircBtnEmittente.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCircBtnEmittente.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCircBtnEmittente.BorderSize = 2
        Me.RjCircBtnEmittente.GradientAngle = 50.0!
        Me.RjCircBtnEmittente.Image = CType(resources.GetObject("RjCircBtnEmittente.Image"), System.Drawing.Image)
        Me.RjCircBtnEmittente.Location = New System.Drawing.Point(1101, 64)
        Me.RjCircBtnEmittente.Name = "RjCircBtnEmittente"
        Me.RjCircBtnEmittente.Size = New System.Drawing.Size(56, 56)
        Me.RjCircBtnEmittente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircBtnEmittente.TabIndex = 44
        Me.RjCircBtnEmittente.TabStop = False
        '
        'RjTutteFat
        '
        Me.RjTutteFat.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjTutteFat.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjTutteFat.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjTutteFat.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjTutteFat.BorderSize = 2
        Me.RjTutteFat.GradientAngle = 50.0!
        Me.RjTutteFat.Image = Global.CreaFiltroDvg.My.Resources.Resources.tutti
        Me.RjTutteFat.Location = New System.Drawing.Point(785, 64)
        Me.RjTutteFat.Name = "RjTutteFat"
        Me.RjTutteFat.Size = New System.Drawing.Size(56, 56)
        Me.RjTutteFat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjTutteFat.TabIndex = 26
        Me.RjTutteFat.TabStop = False
        '
        'RjCercaFattura
        '
        Me.RjCercaFattura.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCercaFattura.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCercaFattura.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCercaFattura.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCercaFattura.BorderSize = 2
        Me.RjCercaFattura.GradientAngle = 50.0!
        Me.RjCercaFattura.Image = CType(resources.GetObject("RjCercaFattura.Image"), System.Drawing.Image)
        Me.RjCercaFattura.Location = New System.Drawing.Point(231, 72)
        Me.RjCercaFattura.Name = "RjCercaFattura"
        Me.RjCercaFattura.Size = New System.Drawing.Size(56, 56)
        Me.RjCercaFattura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCercaFattura.TabIndex = 20
        Me.RjCercaFattura.TabStop = False
        '
        'RjBtnLog
        '
        Me.RjBtnLog.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjBtnLog.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjBtnLog.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjBtnLog.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjBtnLog.BorderSize = 2
        Me.RjBtnLog.GradientAngle = 50.0!
        Me.RjBtnLog.Image = CType(resources.GetObject("RjBtnLog.Image"), System.Drawing.Image)
        Me.RjBtnLog.Location = New System.Drawing.Point(946, 56)
        Me.RjBtnLog.Name = "RjBtnLog"
        Me.RjBtnLog.Size = New System.Drawing.Size(64, 64)
        Me.RjBtnLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjBtnLog.TabIndex = 19
        Me.RjBtnLog.TabStop = False
        '
        'RjCircApriDGVQry
        '
        Me.RjCircApriDGVQry.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCircApriDGVQry.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCircApriDGVQry.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCircApriDGVQry.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCircApriDGVQry.BorderSize = 2
        Me.RjCircApriDGVQry.GradientAngle = 50.0!
        Me.RjCircApriDGVQry.Image = Global.CreaFiltroDvg.My.Resources.Resources.cercaFat
        Me.RjCircApriDGVQry.Location = New System.Drawing.Point(385, 586)
        Me.RjCircApriDGVQry.Name = "RjCircApriDGVQry"
        Me.RjCircApriDGVQry.Size = New System.Drawing.Size(56, 56)
        Me.RjCircApriDGVQry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircApriDGVQry.TabIndex = 16
        Me.RjCircApriDGVQry.TabStop = False
        '
        'RjCircClienti
        '
        Me.RjCircClienti.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCircClienti.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCircClienti.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCircClienti.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCircClienti.BorderSize = 2
        Me.RjCircClienti.GradientAngle = 50.0!
        Me.RjCircClienti.Image = Global.CreaFiltroDvg.My.Resources.Resources.sinistra
        Me.RjCircClienti.Location = New System.Drawing.Point(1679, 905)
        Me.RjCircClienti.Name = "RjCircClienti"
        Me.RjCircClienti.Size = New System.Drawing.Size(113, 113)
        Me.RjCircClienti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircClienti.TabIndex = 15
        Me.RjCircClienti.TabStop = False
        '
        'RjCircOrdini
        '
        Me.RjCircOrdini.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCircOrdini.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCircOrdini.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCircOrdini.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCircOrdini.BorderSize = 2
        Me.RjCircOrdini.GradientAngle = 50.0!
        Me.RjCircOrdini.Image = Global.CreaFiltroDvg.My.Resources.Resources.sinistra
        Me.RjCircOrdini.Location = New System.Drawing.Point(1679, 700)
        Me.RjCircOrdini.Name = "RjCircOrdini"
        Me.RjCircOrdini.Size = New System.Drawing.Size(113, 113)
        Me.RjCircOrdini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircOrdini.TabIndex = 14
        Me.RjCircOrdini.TabStop = False
        '
        'RjCercaFatKO
        '
        Me.RjCercaFatKO.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCercaFatKO.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCercaFatKO.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCercaFatKO.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCercaFatKO.BorderSize = 2
        Me.RjCercaFatKO.GradientAngle = 50.0!
        Me.RjCercaFatKO.Image = Global.CreaFiltroDvg.My.Resources.Resources.cercaFat
        Me.RjCercaFatKO.Location = New System.Drawing.Point(494, 629)
        Me.RjCercaFatKO.Name = "RjCercaFatKO"
        Me.RjCercaFatKO.Size = New System.Drawing.Size(56, 56)
        Me.RjCercaFatKO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCercaFatKO.TabIndex = 6
        Me.RjCercaFatKO.TabStop = False
        '
        'RjSalvaFattura
        '
        Me.RjSalvaFattura.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjSalvaFattura.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjSalvaFattura.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjSalvaFattura.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjSalvaFattura.BorderSize = 2
        Me.RjSalvaFattura.GradientAngle = 50.0!
        Me.RjSalvaFattura.Image = Global.CreaFiltroDvg.My.Resources.Resources.social_page
        Me.RjSalvaFattura.Location = New System.Drawing.Point(94, 65)
        Me.RjSalvaFattura.Name = "RjSalvaFattura"
        Me.RjSalvaFattura.Size = New System.Drawing.Size(63, 63)
        Me.RjSalvaFattura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjSalvaFattura.TabIndex = 5
        Me.RjSalvaFattura.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(583, 130)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(148, 25)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "Nuova Fattura"
        Me.Label19.Visible = False
        '
        'RjCircBtnNuovaFattura
        '
        Me.RjCircBtnNuovaFattura.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCircBtnNuovaFattura.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCircBtnNuovaFattura.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCircBtnNuovaFattura.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCircBtnNuovaFattura.BorderSize = 2
        Me.RjCircBtnNuovaFattura.GradientAngle = 50.0!
        Me.RjCircBtnNuovaFattura.Image = CType(resources.GetObject("RjCircBtnNuovaFattura.Image"), System.Drawing.Image)
        Me.RjCircBtnNuovaFattura.Location = New System.Drawing.Point(630, 65)
        Me.RjCircBtnNuovaFattura.Name = "RjCircBtnNuovaFattura"
        Me.RjCircBtnNuovaFattura.Size = New System.Drawing.Size(63, 63)
        Me.RjCircBtnNuovaFattura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircBtnNuovaFattura.TabIndex = 53
        Me.RjCircBtnNuovaFattura.TabStop = False
        Me.RjCircBtnNuovaFattura.Visible = False
        '
        'FrmGestFatture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1053)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.RjCircBtnNuovaFattura)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.RjCircBtnAnteprima)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.RjGeneraPDF)
        Me.Controls.Add(Me.RjCircBtnCambiaCartella)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.RjCircBtnEmittente)
        Me.Controls.Add(Me.TxtNomeFat)
        Me.Controls.Add(Me.RjBtnEseguiCalcoli)
        Me.Controls.Add(Me.TxtTotaleConIVA)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LblIVA)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtIVA)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtImporto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtPrezzo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtColli)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RjTutteFat)
        Me.Controls.Add(Me.TxtNum)
        Me.Controls.Add(Me.TxtIdCli)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RjCercaFattura)
        Me.Controls.Add(Me.RjBtnLog)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RjCircApriDGVQry)
        Me.Controls.Add(Me.RjCircClienti)
        Me.Controls.Add(Me.RjCircOrdini)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RjCercaFatKO)
        Me.Controls.Add(Me.RjSalvaFattura)
        Me.Controls.Add(Me.ClientiDataGrid)
        Me.Controls.Add(Me.OrdDataGrid)
        Me.Controls.Add(Me.FatDataGrid)
        Me.Name = "FrmGestFatture"
        Me.Text = "FrmGestFatture"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FatDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FatturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinDBGdRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdiniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientiDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircBtnAnteprima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjGeneraPDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircBtnCambiaCartella, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircBtnEmittente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjTutteFat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCercaFattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjBtnLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircApriDGVQry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircClienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircOrdini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCercaFatKO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjSalvaFattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircBtnNuovaFattura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableAdapterManager As WinDBGdRDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FatturaTableAdapter As WinDBGdRDataSetTableAdapters.FatturaTableAdapter
    Friend WithEvents WinDBGdRDataSet As WinDBGdRDataSet
    Friend WithEvents FatDataGrid As DataGridView
    Friend WithEvents FatturaBindingSource As BindingSource
    Friend WithEvents OrdiniTableAdapter As WinDBGdRDataSetTableAdapters.OrdiniTableAdapter
    Friend WithEvents OrdDataGrid As DataGridView
    Friend WithEvents OrdiniBindingSource As BindingSource
    Friend WithEvents ClientiDataGrid As DataGridView
    Friend WithEvents ClientiBindingSource As BindingSource
    Friend WithEvents ClientiTableAdapter As WinDBGdRDataSetTableAdapters.ClientiTableAdapter
    Friend WithEvents RjSalvaFattura As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents RjCercaFatKO As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RjCircOrdini As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents RjCircClienti As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents RjCircApriDGVQry As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RjBtnLog As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents IdClientiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndirizzoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CittaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CAPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PIVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDOrdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDCliOrd As DataGridViewTextBoxColumn
    Friend WithEvents MatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtaOrd As DataGridViewTextBoxColumn
    Friend WithEvents PrezzoOrd As DataGridViewTextBoxColumn
    Friend WithEvents ImportoOrd As DataGridViewTextBoxColumn
    Friend WithEvents RjCercaFattura As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtIdCli As TextBox
    Friend WithEvents TxtNum As TextBox
    Friend WithEvents IDFat As DataGridViewTextBoxColumn
    Friend WithEvents IDCli As DataGridViewTextBoxColumn
    Friend WithEvents IDOrd As DataGridViewTextBoxColumn
    Friend WithEvents Num As DataGridViewTextBoxColumn
    Friend WithEvents DataFat As DataGridViewTextBoxColumn
    Friend WithEvents NomeFat As DataGridViewTextBoxColumn
    Friend WithEvents Descr As DataGridViewTextBoxColumn
    Friend WithEvents Qta As DataGridViewTextBoxColumn
    Friend WithEvents Prezzo As DataGridViewTextBoxColumn
    Friend WithEvents Importo As DataGridViewTextBoxColumn
    Friend WithEvents Image As DataGridViewTextBoxColumn
    Friend WithEvents DataFutura As DataGridViewTextBoxColumn
    Friend WithEvents RjTutteFat As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtColli As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPrezzo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtImporto As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtIVA As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LblIVA As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtTotaleConIVA As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents RjBtnEseguiCalcoli As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents TxtNomeFat As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents RjCircBtnEmittente As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents RjCircBtnCambiaCartella As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents RjGeneraPDF As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents RjCircBtnAnteprima As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents RjCircBtnNuovaFattura As RJCodeAdvance.RJControls.RJCircularPictureBox
End Class
