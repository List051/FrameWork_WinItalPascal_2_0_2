
# WinItalPascal – Gestione Report RDLC

## Introduzione

La libreria **WinItalPascal** mette a disposizione una serie di funzioni per la gestione centralizzata dei report **RDLC**.

L'obiettivo è evitare di scrivere codice duplicato in ogni form dell'applicazione.

La libreria si occupa di:

* caricamento del file RDLC;
* collegamento della DataTable;
* visualizzazione nel ReportViewer;
* esportazione PDF;
* stampa;
* aggiornamento del ReportViewer.

---

# Preparazione del Form Report

Per utilizzare `ReportManager` è necessario creare un Form contenente un controllo **ReportViewer**.

Nel form devono essere dichiarate le seguenti proprietà pubbliche:

```vb
Public Property TitoloReport As String = ""
Public Property NomeReport As String
Public Property TabellaReport As DataTable
Public Property DataSourceReport As String
```

## Significato delle proprietà

| Proprietà          | Descrizione                                               |
| ------------------ | --------------------------------------------------------- |
| `TitoloReport`     | Titolo visualizzato nella finestra del report.            |
| `NomeReport`       | Nome del file RDLC (es. `RepClienti.rdlc`).               |
| `TabellaReport`    | `DataTable` contenente i dati da visualizzare.            |
| `DataSourceReport` | Nome del DataSet definito nel file RDLC (es. `DataSet1`). |

Queste proprietà vengono valorizzate dal form chiamante prima dell'apertura del report.

Esempio:

```vb
Dim frm As New FrmReport

frm.TitoloReport = "Elenco Clienti"
frm.NomeReport = "RepClienti.rdlc"
frm.TabellaReport = DB.FillDataTable("SELECT * FROM Clienti")
frm.DataSourceReport = "DataSet1"

frm.ShowDialog()

```

Utilizzando la libreria in _Load
 FrmTitolo.CTitolo(Me, TitoloReport)  ' aggiorna il titolo del form aperto
...

Nota: il nome DataSourceReport deve corrispondere esattamente al nome del DataSet definito nel file .rdlc (ad esempio DataSet1).
 In caso contrario il report non verrà popolato con i dati.

# Requisiti

La cartella dell'applicazione deve contenere:

```
Bin
 └── Debug
      └── Reports
            RepClienti.rdlc
            RepOrdini.rdlc
            RepBeni.rdlc
            ...
```

I file **RDLC** devono essere presenti nella cartella **Reports**.

---

# Classe ReportManager

La classe principale è:

```vb
ReportManager
```

---

## ApriReport

Carica un report utilizzando una DataTable.

```vb
ReportManager.ApriReport(
    ReportViewer1,
    "RepOrdini.rdlc",
    dt,
    "DataSet1")
```

Parametri

| Parametro      | Descrizione                         |
| -------------- | ----------------------------------- |
| ReportViewer   | Controllo ReportViewer del form     |
| ReportName     | Nome del file RDLC                  |
| DataTable      | Tabella contenente i dati           |
| DataSourceName | Nome DataSet definito nel file RDLC |

---

## ApriReport con Query SQL

È disponibile anche l'overload che esegue direttamente una query SQL.

```vb
ReportManager.ApriReport(
    ReportViewer1,
    "RepClienti.rdlc",
    "SELECT * FROM Clienti",
    "DataSet1")
```

oppure

```vb
Dim param As New List(Of SqlParameter)

param.Add(New SqlParameter("@IdCli", idCliente))

ReportManager.ApriReport(
    ReportViewer1,
    "RepOrdiniCliente.rdlc",
    "SELECT * FROM vw_OrdiniClienti WHERE IDCliOrd=@IdCli",
    "DataSet1",
    param)
```

---

## Refresh

Aggiorna il ReportViewer.

```vb
ReportManager.Refresh(ReportViewer1)
```

---

## Clear

Pulisce il ReportViewer.

```vb
ReportManager.Clear(ReportViewer1)
```

---

## Stampa

Apre la finestra di stampa del ReportViewer.

```vb
ReportManager.Stampa(ReportViewer1)
```

---

## EsportaPdf

Esporta il report corrente in formato PDF.

```vb
ReportManager.EsportaPdf(ReportViewer1)
```

Al termine del salvataggio il PDF viene aperto automaticamente.

### Esempio 2 - Esporta senza aprire il PDF

```vb
ReportManager.EsportaPdf(ReportViewer1,False)
```

### Parametri

| Parametro | Descrizione |
|-----------|-------------|
| ReportViewer | Controllo contenente il report |
| apriPdf | Facoltativo. Se `True` apre automaticamente il PDF al termine dell'esportazione. Il valore predefinito è `True`. |


---

# Utilizzo consigliato

Nel form contenente il ReportViewer.

```vb
Private Sub FrmReport_Shown(...) Handles MyBase.Shown

    ReportManager.ApriReport(
        ReportViewer1,
        NomeReport,
        TabellaReport,
        DataSourceReport)

    ReportImpostazioni.SetImpOrd(ReportViewer1)

End Sub
```

---

# Apertura del Form Report

Dal form chiamante.

```vb
Dim frm As New FrmReport

frm.TitoloReport = "Elenco Clienti"
frm.NomeReport = "RepClienti.rdlc"
frm.TabellaReport = DB.FillDataTable(
    "SELECT * FROM Clienti")
frm.DataSourceReport = "DataSet1"

frm.ShowDialog()
```

---

# Query con JOIN

Per report ottenuti da più tabelle è consigliato utilizzare direttamente una query SQL oppure una VIEW.

Esempio:

```sql
 creata direttamente in SQL Server Management
SELECT
  c.Cliente,
  c.P_IVA,
  o.IDOrd,
  o.IDCliOrd,
  o.Data,
  o.Mat,
  o.QtaOrd,
  o.PrezzoOrd,
  o.ImportoOrd
FROM dbo.Ordini AS o
INNER JOIN dbo.Clienti AS c
  ON o.IDCliOrd = c.IdClienti;
```

oppure

```sql
SELECT *
FROM vw_OrdiniClienti
```

---

# Note

* I nuovi report utilizzano **DataTable** e non richiedono DataSet tipizzati.
* Il nome del DataSet presente nel file RDLC deve coincidere con il parametro `DataSourceName` (es. `DataSet1`).
* Prima di esportare o stampare è necessario aver eseguito `ReportManager.ApriReport(...)`.
* I file RDLC devono essere copiati nella cartella `Reports` dell'applicazione.

---

Versione documentazione: 2.0.3

WinItalPascal – ReportManager

