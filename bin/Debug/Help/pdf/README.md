
```markdown
# WinItalPascal

## Libreria di utilità per applicazioni VB.NET WinForms

**WinItalPascal** è una libreria di componenti e utility pensata per velocizzare lo sviluppo di applicazioni desktop realizzate con:

* VB.NET
* Windows Forms
* .NET Framework 4.8

La libreria raccoglie funzioni comuni normalmente riscritte in ogni progetto:

* gestione database SQL Server;
* gestione avanzata DataGridView;
* report RDLC;
* gestione form;
* logging;
* popup;
* utility grafiche.

L'obiettivo è fornire codice riutilizzabile, ordinato e facilmente manutenibile.

---

# 📦 Struttura della Libreria

```

WinItalPascal
│
├── Database
│   └── DB
│
├── Grid
│   └── DataGVLoad
│
├── Reports
│   ├── ReportManager
│   └── ReportImpostazioni
│
├── Forms
│
├── Logging
│   └── FrameworkLogger
│
└── Popup

````

---

# 📦 Installazione

Installazione tramite NuGet:

```powershell
Install-Package WinItalPascal
````

oppure tramite Visual Studio:

```
Gestione pacchetti NuGet
→ Cerca
→ WinItalPascal
```

---

# 🚀 Funzionalità disponibili

## 🗄 Database

Modulo per la gestione SQL Server.

Classe principale:

```
DB
```

Funzioni disponibili:

* GetConnection;
* ExecuteScalar;
* ExecuteNonQuery;
* ExecuteReader;
* FillDataTable;
* FillDataSet;
* query parametrizzate;
* gestione connessioni.

Documentazione:

📄 README_Database.md

---

## 📊 GridUtility

Gestione avanzata DataGridView.

Classe principale:

```
DataGVLoad
```

Funzioni disponibili:

* caricamento dati;
* configurazione automatica colonne;
* formattazione;
* gestione colori;
* ricerca;
* conversione testo;
* gestione eventi.

Documentazione:

📄 README_GridUtility.md

---

## 📄 Report RDLC

Gestione centralizzata dei report.

Classi principali:

```
ReportManager
ReportImpostazioni
```

Funzioni disponibili:

* caricamento report RDLC;
* collegamento DataTable;
* gestione ReportViewer;
* stampa;
* esportazione PDF;
* query SQL;
* query parametrizzate.

Documentazione:

📄 README_Reports.md

---

## 🪟 Forms Utility

Utility dedicate ai Windows Form.

Funzioni disponibili:

* apertura form;
* gestione titoli;
* Fade;
* gestione schermate.

Documentazione:

📄 README_Forms.md

> "Gestione avanzata dei Windows Form tramite titoli personalizzati,
 apertura schermate, gestione dimensionamento e modalità FullScreen."
---

## 📝 Logging

Sistema integrato di registrazione eventi.

Classi principali:

```
FrameworkLogger
LogLeggiScrivi
```

Funzioni:

* log eventi;
* registrazione errori;
* gestione file log.

---

## 🔔 Popup e Utility

Gestione finestre informative e messaggi personalizzati.

Comprende:

* PopupHelper;
* PopupForm;
* utility grafiche.

Documentazione:

📄 README_Popup.md

---

# ⚙ Configurazione Database

La libreria utilizza la connection string:

```
MiaConnessione
```

Esempio:

```xml
<connectionStrings>

<add name="MiaConnessione"
 connectionString="Data Source=SERVER;
 Initial Catalog=DBClienti;
 Integrated Security=True;
 TrustServerCertificate=True"
 providerName="System.Data.SqlClient"/>

</connectionStrings>
```

---

# 🎬 Video Tutorial

Video dimostrativi della libreria WinItalPascal.

| Video | Argomento             | Link                                                                                                 |
| ----- | --------------------- | ---------------------------------------------------------------------------------------------------- |
| #01   | Introduzione libreria | Inserire link                                                                                        |
| #02   | Database              | Inserire link                                                                                        |
| #03   | GridUtility           | Inserire link                                                                                        |
| #04   | Report RDLC           | Inserire link                                                                                        |
| #05   | Forms & ScreenUtility | Inserire link                                                                                        |
| #06   | Logging               | Inserire link                                                                                        |
| #07   | Popup e Utility       | [https://youtu.be/4EyZb3B9hFM?si=kW89BimOeiNbdfmU |

Canale YouTube:

[https://www.youtube.com/@iaoraGo](https://www.youtube.com/@iaoraGo)

---

# 💻 Repository GitHub

Repository ufficiale:

[https://github.com/List051/WinItalPascal](https://github.com/List051/WinItalPascal)

---

# 📦 Pacchetto NuGet

Disponibile su:

[https://www.nuget.org/packages/WinItalPascal](https://www.nuget.org/packages/WinItalPascal)

---

# 📚 Documentazione

Manuali disponibili:

```
README.md
README_Database.md
README_GridUtility.md
README_Reports.md
README_Forms.md
README_Logging.md
README_Popup.md
CHANGELOG.md
```

---

# 🛠 Compatibilità

* .NET Framework 4.8
* VB.NET WinForms
* SQL Server
* Visual Studio 2019
* Visual Studio 2022

---

# 📄 Licenza

MIT License.

Utilizzabile in applicazioni personali, aziendali e commerciali.

---

**WinItalPascal**

Utility Library for VB.NET WinForms

Versione documentazione: 2.0.3
