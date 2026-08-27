
# README_GridUtility.md

```markdown
# WinItalPascal - GridUtility

## Gestione avanzata DataGridView per applicazioni VB.NET WinForms

La libreria WinItalPascal contiene una serie di strumenti dedicati alla gestione dei controlli DataGridView.

L'obiettivo è semplificare tutte quelle operazioni che normalmente vengono ripetute nei vari progetti:

- configurazione grafica;
- caricamento dati;
- gestione colori;
- ricerca;
- filtri;
- selezione righe;
- formattazione colonne;
- gestione valori null;
- personalizzazione tabelle.

Le classi principali sono:

```

GridUtility
GridFilter
ModColoriDgv

```

---

# GridUtility

La classe `GridUtility` contiene le funzioni principali per configurare e gestire un DataGridView.

---

## Inizializzazione DataGridView

Metodo:

```

GridUtility.Initialize(DataGridView)

````

Configura automaticamente:

- stile intestazioni;
- colori;
- font;
- altezza righe;
- selezione completa riga;
- blocco inserimento e cancellazione;
- formattazione generale.

Esempio:

```vb
Private Sub FrmClienti_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    GridUtility.Initialize(ClientiDataGridView)

End Sub
````

---

# DataGridView modificabile

Per griglie dove è necessario inserire nuovi record:

Metodo:

```
GridUtility.InitiaGrid(DataGridView)
```

Differenze:

* permette inserimento righe;
* abilita gestione Identity;
* inserisce automaticamente valore -1 nella nuova riga.

Esempio:

```vb
GridUtility.InitiaGrid(ClientiDataGridView)
```

---

# Conversione testo maiuscolo

Metodo:

```
GridUtility.ConvertiMaiuscolo()
```

Converte tutte le celle testuali in maiuscolo.

Esempio:

```vb
GridUtility.ConvertiMaiuscolo(ClientiDataGridView)
```

---

# Evidenziazione dati

## Cerca testo nella griglia

Metodo:

```vb
GridUtility.EvidenziaTesto(
    DgvOrdini,
    "RAM"
)
```

Evidenzia tutte le celle contenenti il testo indicato.

---

# Colorazione celle

## Colora celle con valore OK

Esempio:

```vb
GridUtility.ColoraOK(ClientiDataGridView)
```

---

## Colorazione colonne

Esempio:

```vb
GridUtility.ColoraColonne(
    DgvClienti,
    Colori.ColoreTipo.Giallo,
    Colori.ColoreTipo.VerdeChiaro,
    Colori.ColoreTipo.Azzurro
)
```

---

# Gestione selezione riga

## Evidenzia riga corrente

Esempio:

```vb
GridUtility.ColoraRigaSelezionata(DgvClienti)
```

Con colore personalizzato:

```vb
GridUtility.ColoraRigaSelezionata(
    DgvClienti,
    Colori.ColoreTipo.Azzurro
)
```

---

# Reset colori

Ripristina la configurazione originale.

```vb
GridUtility.ResetColori(DgvClienti)
```

---

# Controllo valori vuoti

Permette di evidenziare celle senza valore.

Esempio:

```vb
GridUtility.ImpostaColNull(
    DgvClienti,
    "Telefono"
)
```

Risultato:

* celle vuote evidenziate;
* possibilità di scegliere colore sfondo;
* possibilità di scegliere colore testo.

---

# GridFilter

La classe `GridFilter` permette di applicare filtri dinamici ai dati visualizzati.

Supporta:

* DataTable;
* DataView;
* BindingSource.

---

# Applicazione filtro

Esempio:

```vb
GridFilter.FiltraDgv(
    DgvOrdini,
    "Cliente LIKE '%Mario%'"
)
```

---

# Reset filtro

Ripristina tutti i dati.

```vb
GridFilter.ResetFiltro(DgvOrdini)
```

---

# Ricerca generale su tutte le colonne

Esempio:

```vb
GridUtility.FiltraTutti(
    DgvOrdini,
    DtOrdini,
    TxtRicerca.Text
)
```

La ricerca viene eseguita su tutte le colonne disponibili.

---

# ModColoriDgv

Modulo dedicato alla personalizzazione grafica delle DataGridView.

Permette di applicare:

* colori colonne;
* temi predefiniti;
* colori personalizzati;
* gestione multipla di più griglie.

---

# Colorazione automatica colonne

Esempio:

```vb
ColoraDgv(
    OrdiniDataGrid,
    ClientiDataGrid,
    FatturaDataGrid
)
```

---

# Temi disponibili

## Tema Pastello

```vb
ColoraDgvMod(
    FatturaDataGrid,
    TemaM.Pastello
)
```

---

## Tema Soft Blu

```vb
ColoraDgvMod(
    FatturaDataGrid,
    TemaM.SoftBlu
)
```

---

## Tema Soft Verde

```vb
ColoraDgvMod(
    FatturaDataGrid,
    TemaM.SoftVerde
)
```

---

# Tema Office 24

Esempio:

```vb
ColoraDgvOf24(
    FatturaDataGrid,
    TemaProf.Of24
)
```

---

# Colori personalizzati

Possibilità di scegliere manualmente i colori delle colonne.

Esempio:

```vb
ColoraDgvCustom(
    OrdiniDataGrid,
    Color.LightBlue,
    Color.LightGreen,
    Color.LightYellow
)
```

È possibile saltare una colonna:

```vb
ColoraDgvCustom(
    OrdiniDataGrid,
    Color.LightBlue,
    ColSpec.Salta,
    Color.LightYellow
)
```

---

# Esempio completo utilizzo

```vb
Private Sub FrmOrdini_Load(
sender As Object,
e As EventArgs
) Handles MyBase.Load


    GridUtility.Initialize(
        OrdiniDataGridView)


    GridUtility.ConvertiMaiuscolo(
        OrdiniDataGridView)


    GridUtility.ColoraRigaSelezionata(
        OrdiniDataGridView)


End Sub
```

---

# Logging errori

Tutte le funzioni della libreria utilizzano:

```
FrameworkLogger
```

In caso di errore viene creato automaticamente:

```
ItalPascal_Log.txt
```

nella cartella dell'applicazione.

---

# Video Tutorial

Video dimostrativo GridUtility:

```
Inserire link video
```

---

# Documentazione correlata

```
README.md
README_Database.md
README_Reports.md
README_Forms.md
README_Logging.md
README_Popup.md
```

---

WinItalPascal

Utility Library for VB.NET WinForms

Versione documentazione: 2.0.3

```