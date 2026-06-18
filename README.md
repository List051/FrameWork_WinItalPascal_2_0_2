**README completo e finale**, con tutte le sezioni, immagini e spiegazioni integrate.  
È pronto per essere pubblicato su GitHub o incluso nel tuo progetto VB.NET.

# 🎬 Demo Video

Guarda la demo completa della libreria:

📺 **YouTube Demo**  
https://youtu.be/BsjiVc-j8qs

🎬 **Elenco video e versioni:**  

# ' Qui modificherò il path quando avrò inserito il progetto in GitHub
[Visualizza la pagina Video.html](https://htmlpreview.github.io/?https://github.com/List051/WinTest_Framework/blob/main/Video.html)

Option download in local : https://List051.github.io/WinTest_Framework/video.html



---

# 📘 README — **FrmGestFatture**
_Gestione Fatture, Ordini e Clienti con generazione PDF professionale_

---

## 📌 **Descrizione generale**

`FrmGestFatture` è il form principale dell’applicativo **WinItalPascal**, dedicato alla gestione completa delle fatture.  
Consente di:

- Visualizzare clienti, ordini e fatture  
- Cercare ordini non ancora fatturati  
- Creare e salvare nuove fatture  
- Calcolare automaticamente totali, IVA e totale finale  
- Generare un **PDF professionale** con logo, intestazione, tabella articoli e totali  
- Gestire la cartella di salvataggio dei PDF  
- Anteprima PDF prima del salvataggio 
- Registrare e leggere log delle operazioni  

---

## 🧩 **Funzionalità principali**

### ✔️ Caricamento automatico dei dati
All’avvio vengono caricati i dataset:
- **Clienti**
- **Ordini**
- **Fattura**

Ogni DataGrid viene colorato tramite `GridUtility.ColoraColonne`.

---

### ✔️ Filtri e ricerche
Il form permette di:
- Filtrare i clienti in base all’ordine selezionato  
- Cercare ordini **non ancora fatturati**  
- Cercare una fattura specifica per ID cliente e numero  
- Visualizzare tutte le fatture registrate  

---

### ✔️ Gestione Cliente da fatturare
La funzione `CaricaCliente()` compone automaticamente l’indirizzo del cliente, includendo:
- Nome  
- Indirizzo  
- CAP, città e provincia  
- P.IVA / CF  

---

### ✔️ Calcolo Totali Fattura
La funzione `CalcolaTotaliFiltrati()`:
- Somma quantità, prezzi e importi  
- Calcola IVA e totale finale  
- Aggiorna le TextBox con i valori calcolati  

---

### ✔️ Generazione PDF professionale
La funzione `GeneraPDFTotali()` crea un PDF completo con:
- Logo e dati dell’emittente  
- Dati cliente formattati  
- Tabella articoli (Descrizione, Qta, Prezzo, Importo)  
- **Tabella Totali Professionale**  
- Anteprima PDF prima del salvataggio 
- Salvataggio automatico nella cartella scelta  

---

### 🗂️ Cartella “Stampa Fatture”
Mostra i file PDF generati automaticamente dal form `FrmGestFatture`, ciascuno nominato con il formato  
`NomeCliente_Fattura_Num_Data.pdf`.

---

### 📊 Tabelle Ordini e Clienti
Visualizzazione dei dati caricati nel form: ordini con quantità, prezzo e importo; clienti con indirizzo, città, provincia e telefono.  
Colorazione automatica tramite `GridUtility.ColoraColonne`.

---

### 🧾 Esempio di Fattura PDF generata
Esempio di PDF creato da `GeneraPDFTotali()`, con logo, dati emittente, dati cliente, tabella articoli e totali calcolati.


---

### 📋 Tabella Fatture
Elenco delle fatture emesse con dettagli su cliente, data, descrizione, quantità, prezzo e importo.


---

### 💻 Schermata principale del form
Interfaccia completa del form `FrmGestFatture`, con pulsanti di gestione, calcolo IVA, ricerca clienti e selezione cartella PDF.

---

#### 🔍 Sezione “Cerca Cliente”
Mostra i due pulsanti di ricerca cliente:
- **Cerca Cliente con Fattura da emettere** → filtra i clienti con ordini non ancora fatturati.  
- **Cerca Cliente con ApriDgvQry** → apre la query diretta per visualizzare i clienti e ordini.

---

#### 🧾 Sezione “Gestione Fatture”
Questa barra superiore raccoglie tutte le funzioni principali del form:

| Icona | Funzione | Descrizione |
|-------|-----------|-------------|
| 🟣 **Salva Fattura** | Salva la fattura nel database |
| 🔴 **Cerca Fattura da emettere** | Ricerca ordini non ancora fatturati |
| 🟢 **Tutte le fatture** | Visualizza tutte le fatture registrate |
| ⚙️ **LOG** | Mostra il file di log delle operazioni |
| 📋 **Emittente Fattura** | Apre la finestra per modificare i dati dell’emittente |
| 📂 **Seleziona Cartella Salvataggio PDF Fattura** | Permette di scegliere la cartella dove salvare i PDF generati |


---

## 🧱 **Struttura del Database**

Il form `FrmGestFatture` si basa su tre tabelle principali del database SQL Server: **Clienti**, **Ordini** e **Fattura**.  
Queste tabelle sono collegate tra loro tramite chiavi primarie e chiavi esterne, garantendo integrità referenziale tra clienti, ordini e fatture.


---

### 📋 **Tabella `dbo.Clienti`**
Contiene i dati anagrafici dei clienti.

| Colonna | Tipo | Descrizione |
|----------|------|-------------|
| IdClienti | int (PK, non Null) | Identificativo univoco del cliente |
| Cliente | nvarchar(50) | Nome o ragione sociale |
| Indirizzo | nvarchar(50) | Indirizzo completo |
| Citta | nvarchar(50) | Città |
| Prov | nvarchar(10) | Provincia |
| CAP | nvarchar(5) | Codice di avviamento postale |
| Tel | nvarchar(50) | Numero di telefono |
| P_IVA | nvarchar(16) | Partita IVA o codice fiscale |

---

### 📦 **Tabella `dbo.Ordini`**
Contiene gli ordini effettuati dai clienti.

| Colonna | Tipo | Descrizione |
|----------|------|-------------|
| IDOrd | int (PK, non Null) | Identificativo univoco dell’ordine |
| IDCliOrd | int (non Null) | ID del cliente associato |
| Data | date (non Null) | Data dell’ordine |
| Mat | nvarchar(50) | Materiale o prodotto ordinato |
| QtaOrd | int (non Null) | Quantità ordinata |
| PrezzoOrd | decimal(18,2) | Prezzo unitario |
| ImportoOrd | decimal(18,2) | Totale dell’ordine |

---

### 🧾 **Tabella `dbo.Fattura`**
Contiene le fatture emesse e collegate agli ordini.

| Colonna | Tipo | Descrizione |
|----------|------|-------------|
| IDFat | int (PK, non Null) | Identificativo univoco della fattura |
| IDCli | int (non Null) | ID del cliente |
| IDOrd | int (non Null) | ID dell’ordine |
| Num | int (non Null) | Numero della fattura |
| DataFat | date (non Null) | Data di emissione |
| NomeFat | nvarchar(50) | Nome o intestazione della fattura |
| Descr | nvarchar(50) | Descrizione articolo |
| Qta | int (non Null) | Quantità |
| Prezzo | decimal(18,2) | Prezzo unitario |
| Importo | decimal(18,2) | Totale imponibile |
| Image | nvarchar(50) | Percorso immagine articolo |
| DataFutura | date (non Null) | Data futura o scadenza |

---

## 🧰 **Librerie utilizzate**

- **iTextSharp** → generazione PDF  
- **CustomMessageBoxVB** → messaggi personalizzati  
- **WinItalPascal** → utility varie  
- **GridUtility** → colorazione DataGrid  
- **PopupHelper** → popup informativi  
- **LogLeggiScrivi / LogReader** → gestione log  
- **FrameworkLogger** → gestione errori  

---
# 📁 Struttura Libreria

```text
WinItalPascal 2.0.2
│
├── Core
│   ├── ConfigHelper.vb
│   ├── ThemeFonts.vb
│   ├── Colori.vb
│
├── Database
│   ├── DB.vb
│   ├── GridUtility.vb
│   	├── GridFilter.vb		Nuova funzione
│   	├── DBQry.vb			Nuova funzione
│
├── Forms
│   ├── FormHelper.vb
│   ├── FormUtility.vb
│   ├── FadeUtility.vb
│   ├── ScreenUtility.vb
│   
│
├── Logging
│   ├── FrameworkLogger.vb
│   ├── LogReader.vb
│   	├── LeggeLog.vb			Nuova funzione
│   
│
├── Popup
│   ├── PopupForm.vb
│   ├── PopupHelper.vb
```
	├── Inserito nel progetto ( NON in Libreria )	--> Nuova funzione in Modulo  ColoraGrid.vb
---
