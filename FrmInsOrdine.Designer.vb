<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInsOrdine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInsOrdine))
        Me.OrdiniDataGrid = New System.Windows.Forms.DataGridView()
        Me.IDOrdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCliOrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtaOrdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzoOrdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImportoOrdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdiniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WinDBGdRDataSet = New CreaFiltroDvg.WinDBGdRDataSet()
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
        Me.RjBtnTuttiClienti = New RJCodeAdvance.RJControls.RJButton()
        Me.RJBtnSalva = New RJCodeAdvance.RJControls.RJButton()
        Me.OrdiniBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TxtTutti = New System.Windows.Forms.TextBox()
        Me.TxtEvidenzia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RjBtnResetta = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjBtnCerca = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RjBtnLog = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.TxtCercaCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RjButton1 = New RJCodeAdvance.RJControls.RJButton()
        Me.OrdiniTableAdapter = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.OrdiniTableAdapter()
        Me.TableAdapterManager = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.TableAdapterManager()
        Me.FatturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FatturaTableAdapter = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.FatturaTableAdapter()
        Me.ClientiTableAdapter = New CreaFiltroDvg.WinDBGdRDataSetTableAdapters.ClientiTableAdapter()
        CType(Me.OrdiniDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdiniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinDBGdRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientiDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdiniBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrdiniBindingNavigator.SuspendLayout()
        CType(Me.RjBtnResetta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjBtnCerca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjBtnLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FatturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrdiniDataGrid
        '
        Me.OrdiniDataGrid.AllowUserToOrderColumns = True
        Me.OrdiniDataGrid.AutoGenerateColumns = False
        Me.OrdiniDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrdiniDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDOrdDataGridViewTextBoxColumn, Me.IDCliOrd, Me.DataDataGridViewTextBoxColumn, Me.MatDataGridViewTextBoxColumn, Me.QtaOrdDataGridViewTextBoxColumn, Me.PrezzoOrdDataGridViewTextBoxColumn, Me.ImportoOrdDataGridViewTextBoxColumn})
        Me.OrdiniDataGrid.DataSource = Me.OrdiniBindingSource
        Me.OrdiniDataGrid.Location = New System.Drawing.Point(28, 140)
        Me.OrdiniDataGrid.Name = "OrdiniDataGrid"
        Me.OrdiniDataGrid.RowHeadersWidth = 51
        Me.OrdiniDataGrid.RowTemplate.Height = 24
        Me.OrdiniDataGrid.Size = New System.Drawing.Size(1754, 552)
        Me.OrdiniDataGrid.TabIndex = 0
        '
        'IDOrdDataGridViewTextBoxColumn
        '
        Me.IDOrdDataGridViewTextBoxColumn.DataPropertyName = "IDOrd"
        Me.IDOrdDataGridViewTextBoxColumn.HeaderText = "IDOrd"
        Me.IDOrdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDOrdDataGridViewTextBoxColumn.Name = "IDOrdDataGridViewTextBoxColumn"
        Me.IDOrdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDOrdDataGridViewTextBoxColumn.Width = 80
        '
        'IDCliOrd
        '
        Me.IDCliOrd.DataPropertyName = "IDCliOrd"
        Me.IDCliOrd.HeaderText = "IDCliOrd"
        Me.IDCliOrd.MinimumWidth = 6
        Me.IDCliOrd.Name = "IDCliOrd"
        Me.IDCliOrd.Width = 80
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.Width = 125
        '
        'MatDataGridViewTextBoxColumn
        '
        Me.MatDataGridViewTextBoxColumn.DataPropertyName = "Mat"
        Me.MatDataGridViewTextBoxColumn.HeaderText = "Mat"
        Me.MatDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MatDataGridViewTextBoxColumn.Name = "MatDataGridViewTextBoxColumn"
        Me.MatDataGridViewTextBoxColumn.Width = 650
        '
        'QtaOrdDataGridViewTextBoxColumn
        '
        Me.QtaOrdDataGridViewTextBoxColumn.DataPropertyName = "QtaOrd"
        Me.QtaOrdDataGridViewTextBoxColumn.HeaderText = "QtaOrd"
        Me.QtaOrdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QtaOrdDataGridViewTextBoxColumn.Name = "QtaOrdDataGridViewTextBoxColumn"
        Me.QtaOrdDataGridViewTextBoxColumn.Width = 80
        '
        'PrezzoOrdDataGridViewTextBoxColumn
        '
        Me.PrezzoOrdDataGridViewTextBoxColumn.DataPropertyName = "PrezzoOrd"
        Me.PrezzoOrdDataGridViewTextBoxColumn.HeaderText = "PrezzoOrd"
        Me.PrezzoOrdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrezzoOrdDataGridViewTextBoxColumn.Name = "PrezzoOrdDataGridViewTextBoxColumn"
        Me.PrezzoOrdDataGridViewTextBoxColumn.Width = 125
        '
        'ImportoOrdDataGridViewTextBoxColumn
        '
        Me.ImportoOrdDataGridViewTextBoxColumn.DataPropertyName = "ImportoOrd"
        Me.ImportoOrdDataGridViewTextBoxColumn.HeaderText = "ImportoOrd"
        Me.ImportoOrdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ImportoOrdDataGridViewTextBoxColumn.Name = "ImportoOrdDataGridViewTextBoxColumn"
        Me.ImportoOrdDataGridViewTextBoxColumn.Width = 125
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
        'ClientiDataGrid
        '
        Me.ClientiDataGrid.AutoGenerateColumns = False
        Me.ClientiDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ClientiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientiDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClientiDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.IndirizzoDataGridViewTextBoxColumn, Me.CittaDataGridViewTextBoxColumn, Me.ProvDataGridViewTextBoxColumn, Me.CAPDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn, Me.PIVADataGridViewTextBoxColumn})
        Me.ClientiDataGrid.DataSource = Me.ClientiBindingSource
        Me.ClientiDataGrid.Location = New System.Drawing.Point(28, 790)
        Me.ClientiDataGrid.Name = "ClientiDataGrid"
        Me.ClientiDataGrid.RowHeadersWidth = 51
        Me.ClientiDataGrid.RowTemplate.Height = 24
        Me.ClientiDataGrid.Size = New System.Drawing.Size(1763, 196)
        Me.ClientiDataGrid.TabIndex = 1
        '
        'IdClientiDataGridViewTextBoxColumn
        '
        Me.IdClientiDataGridViewTextBoxColumn.DataPropertyName = "IdClienti"
        Me.IdClientiDataGridViewTextBoxColumn.HeaderText = "IdClienti"
        Me.IdClientiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdClientiDataGridViewTextBoxColumn.Name = "IdClientiDataGridViewTextBoxColumn"
        Me.IdClientiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        '
        'IndirizzoDataGridViewTextBoxColumn
        '
        Me.IndirizzoDataGridViewTextBoxColumn.DataPropertyName = "Indirizzo"
        Me.IndirizzoDataGridViewTextBoxColumn.HeaderText = "Indirizzo"
        Me.IndirizzoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IndirizzoDataGridViewTextBoxColumn.Name = "IndirizzoDataGridViewTextBoxColumn"
        '
        'CittaDataGridViewTextBoxColumn
        '
        Me.CittaDataGridViewTextBoxColumn.DataPropertyName = "Citta"
        Me.CittaDataGridViewTextBoxColumn.HeaderText = "Citta"
        Me.CittaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CittaDataGridViewTextBoxColumn.Name = "CittaDataGridViewTextBoxColumn"
        '
        'ProvDataGridViewTextBoxColumn
        '
        Me.ProvDataGridViewTextBoxColumn.DataPropertyName = "Prov"
        Me.ProvDataGridViewTextBoxColumn.HeaderText = "Prov"
        Me.ProvDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProvDataGridViewTextBoxColumn.Name = "ProvDataGridViewTextBoxColumn"
        '
        'CAPDataGridViewTextBoxColumn
        '
        Me.CAPDataGridViewTextBoxColumn.DataPropertyName = "CAP"
        Me.CAPDataGridViewTextBoxColumn.HeaderText = "CAP"
        Me.CAPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CAPDataGridViewTextBoxColumn.Name = "CAPDataGridViewTextBoxColumn"
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "Tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "Tel"
        Me.TelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        '
        'PIVADataGridViewTextBoxColumn
        '
        Me.PIVADataGridViewTextBoxColumn.DataPropertyName = "P_IVA"
        Me.PIVADataGridViewTextBoxColumn.HeaderText = "P_IVA"
        Me.PIVADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PIVADataGridViewTextBoxColumn.Name = "PIVADataGridViewTextBoxColumn"
        '
        'ClientiBindingSource
        '
        Me.ClientiBindingSource.DataMember = "Clienti"
        Me.ClientiBindingSource.DataSource = Me.WinDBGdRDataSet
        '
        'RjBtnTuttiClienti
        '
        Me.RjBtnTuttiClienti.BackColor = System.Drawing.Color.Blue
        Me.RjBtnTuttiClienti.BackgroundColor = System.Drawing.Color.Blue
        Me.RjBtnTuttiClienti.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RjBtnTuttiClienti.BorderRadius = 0
        Me.RjBtnTuttiClienti.BorderSize = 0
        Me.RjBtnTuttiClienti.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.RjBtnTuttiClienti.FlatAppearance.BorderSize = 5
        Me.RjBtnTuttiClienti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.RjBtnTuttiClienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnTuttiClienti.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnTuttiClienti.ForeColor = System.Drawing.Color.White
        Me.RjBtnTuttiClienti.Location = New System.Drawing.Point(121, 723)
        Me.RjBtnTuttiClienti.Name = "RjBtnTuttiClienti"
        Me.RjBtnTuttiClienti.Size = New System.Drawing.Size(218, 61)
        Me.RjBtnTuttiClienti.TabIndex = 2
        Me.RjBtnTuttiClienti.Text = "Tutti i Clienti"
        Me.RjBtnTuttiClienti.TextColor = System.Drawing.Color.White
        Me.RjBtnTuttiClienti.UseVisualStyleBackColor = False
        '
        'RJBtnSalva
        '
        Me.RJBtnSalva.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RJBtnSalva.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RJBtnSalva.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RJBtnSalva.BorderRadius = 30
        Me.RJBtnSalva.BorderSize = 5
        Me.RJBtnSalva.FlatAppearance.BorderSize = 0
        Me.RJBtnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RJBtnSalva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RJBtnSalva.ForeColor = System.Drawing.Color.White
        Me.RJBtnSalva.Location = New System.Drawing.Point(28, 57)
        Me.RJBtnSalva.Name = "RJBtnSalva"
        Me.RJBtnSalva.Size = New System.Drawing.Size(233, 77)
        Me.RJBtnSalva.TabIndex = 3
        Me.RJBtnSalva.Text = "Salva Ordine"
        Me.RJBtnSalva.TextColor = System.Drawing.Color.White
        Me.RJBtnSalva.UseVisualStyleBackColor = False
        '
        'OrdiniBindingNavigator
        '
        Me.OrdiniBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OrdiniBindingNavigator.BindingSource = Me.OrdiniBindingSource
        Me.OrdiniBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OrdiniBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OrdiniBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.OrdiniBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.OrdiniBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1})
        Me.OrdiniBindingNavigator.Location = New System.Drawing.Point(130, 94)
        Me.OrdiniBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OrdiniBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OrdiniBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OrdiniBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OrdiniBindingNavigator.Name = "OrdiniBindingNavigator"
        Me.OrdiniBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OrdiniBindingNavigator.Size = New System.Drawing.Size(330, 27)
        Me.OrdiniBindingNavigator.TabIndex = 4
        Me.OrdiniBindingNavigator.Text = "BindingNavigator1"
        Me.OrdiniBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Aggiungi nuovo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 24)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Elimina"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Sposta indietro"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Sposta avanti"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'TxtTutti
        '
        Me.TxtTutti.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTutti.Location = New System.Drawing.Point(864, 80)
        Me.TxtTutti.Name = "TxtTutti"
        Me.TxtTutti.Size = New System.Drawing.Size(138, 30)
        Me.TxtTutti.TabIndex = 7
        '
        'TxtEvidenzia
        '
        Me.TxtEvidenzia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEvidenzia.Location = New System.Drawing.Point(426, 80)
        Me.TxtEvidenzia.Name = "TxtEvidenzia"
        Me.TxtEvidenzia.Size = New System.Drawing.Size(194, 30)
        Me.TxtEvidenzia.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(774, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Cerca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(433, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Evidenzia"
        '
        'RjBtnResetta
        '
        Me.RjBtnResetta.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjBtnResetta.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjBtnResetta.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjBtnResetta.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjBtnResetta.BorderSize = 2
        Me.RjBtnResetta.GradientAngle = 50.0!
        Me.RjBtnResetta.Image = CType(resources.GetObject("RjBtnResetta.Image"), System.Drawing.Image)
        Me.RjBtnResetta.Location = New System.Drawing.Point(674, 57)
        Me.RjBtnResetta.Name = "RjBtnResetta"
        Me.RjBtnResetta.Size = New System.Drawing.Size(64, 64)
        Me.RjBtnResetta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjBtnResetta.TabIndex = 8
        Me.RjBtnResetta.TabStop = False
        '
        'RjBtnCerca
        '
        Me.RjBtnCerca.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjBtnCerca.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjBtnCerca.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjBtnCerca.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjBtnCerca.BorderSize = 2
        Me.RjBtnCerca.GradientAngle = 50.0!
        Me.RjBtnCerca.Image = CType(resources.GetObject("RjBtnCerca.Image"), System.Drawing.Image)
        Me.RjBtnCerca.Location = New System.Drawing.Point(340, 57)
        Me.RjBtnCerca.Name = "RjBtnCerca"
        Me.RjBtnCerca.Size = New System.Drawing.Size(64, 64)
        Me.RjBtnCerca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjBtnCerca.TabIndex = 5
        Me.RjBtnCerca.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1098, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "LOG"
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
        Me.RjBtnLog.Location = New System.Drawing.Point(1161, 57)
        Me.RjBtnLog.Name = "RjBtnLog"
        Me.RjBtnLog.Size = New System.Drawing.Size(64, 64)
        Me.RjBtnLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjBtnLog.TabIndex = 15
        Me.RjBtnLog.TabStop = False
        '
        'TxtCercaCliente
        '
        Me.TxtCercaCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtCercaCliente.Cursor = System.Windows.Forms.Cursors.Help
        Me.TxtCercaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCercaCliente.Location = New System.Drawing.Point(610, 738)
        Me.TxtCercaCliente.Name = "TxtCercaCliente"
        Me.TxtCercaCliente.Size = New System.Drawing.Size(169, 30)
        Me.TxtCercaCliente.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(433, 741)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Cerca Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(812, 738)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(559, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Prima di usare Cerca cliccare sul pulsante ""Tutti i Clienti"""
        Me.Label5.Visible = False
        '
        'RjButton1
        '
        Me.RjButton1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjButton1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RjButton1.BorderRadius = 0
        Me.RjButton1.BorderSize = 0
        Me.RjButton1.FlatAppearance.BorderSize = 0
        Me.RjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton1.ForeColor = System.Drawing.Color.White
        Me.RjButton1.Location = New System.Drawing.Point(1632, 733)
        Me.RjButton1.Name = "RjButton1"
        Me.RjButton1.Size = New System.Drawing.Size(150, 40)
        Me.RjButton1.TabIndex = 19
        Me.RjButton1.Text = "RjButton1"
        Me.RjButton1.TextColor = System.Drawing.Color.White
        Me.RjButton1.UseVisualStyleBackColor = False
        Me.RjButton1.Visible = False
        '
        'OrdiniTableAdapter
        '
        Me.OrdiniTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientiTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.FatturaTableAdapter = Nothing
        Me.TableAdapterManager.MaterialeTableAdapter = Nothing
        Me.TableAdapterManager.OrdiniTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CreaFiltroDvg.WinDBGdRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'ClientiTableAdapter
        '
        Me.ClientiTableAdapter.ClearBeforeFill = True
        '
        'FrmInsOrdine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 998)
        Me.Controls.Add(Me.RjButton1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCercaCliente)
        Me.Controls.Add(Me.RjBtnLog)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtEvidenzia)
        Me.Controls.Add(Me.RjBtnResetta)
        Me.Controls.Add(Me.TxtTutti)
        Me.Controls.Add(Me.RjBtnCerca)
        Me.Controls.Add(Me.OrdiniBindingNavigator)
        Me.Controls.Add(Me.RJBtnSalva)
        Me.Controls.Add(Me.RjBtnTuttiClienti)
        Me.Controls.Add(Me.ClientiDataGrid)
        Me.Controls.Add(Me.OrdiniDataGrid)
        Me.Name = "FrmInsOrdine"
        Me.Text = "FrmInsOrdine"
        CType(Me.OrdiniDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdiniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinDBGdRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientiDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdiniBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrdiniBindingNavigator.ResumeLayout(False)
        Me.OrdiniBindingNavigator.PerformLayout()
        CType(Me.RjBtnResetta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjBtnCerca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjBtnLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FatturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OrdiniDataGrid As DataGridView
    Friend WithEvents ClientiDataGrid As DataGridView
    Friend WithEvents RjBtnTuttiClienti As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents RJBtnSalva As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents OrdiniBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents OrdiniBindingSource As BindingSource
    Friend WithEvents WinDBGdRDataSet As WinDBGdRDataSet
    Friend WithEvents OrdiniTableAdapter As WinDBGdRDataSetTableAdapters.OrdiniTableAdapter
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TableAdapterManager As WinDBGdRDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDOrdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDCliOrd As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtaOrdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrezzoOrdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImportoOrdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RjBtnCerca As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents TxtTutti As TextBox
    Friend WithEvents RjBtnResetta As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents TxtEvidenzia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RjBtnLog As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents TxtCercaCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FatturaBindingSource As BindingSource
    Friend WithEvents FatturaTableAdapter As WinDBGdRDataSetTableAdapters.FatturaTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents ClientiTableAdapter As WinDBGdRDataSetTableAdapters.ClientiTableAdapter
    Friend WithEvents ClientiBindingSource As BindingSource
    Friend WithEvents RjButton1 As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents IdClientiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndirizzoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CittaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CAPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PIVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
