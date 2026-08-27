
```markdown
# WinItalPascal – Logging


## Introduzione

La libreria **WinItalPascal** include un sistema integrato di logging per applicazioni **VB.NET WinForms**.

Il modulo permette di:

* registrare eventi dell'applicazione;
* salvare errori ed eccezioni;
* aprire il file di log;
* leggere il contenuto del log;
* mantenere ordinato il file eliminando gli eventi meno recenti.

Il sistema utilizza un semplice file di testo:

```

ItalPascal_Log.txt

```
creato automaticamente nella cartella dell'applicazione.

Bin
 └── Debug
      └── ItalPascal_Log.txt


---

# Struttura del modulo

Il sistema Logging comprende:


```

Logging

├── FrameworkLogger
│
├── LogLeggiScrivi
│
└── LogReader

````


---

# FrameworkLogger


## Descrizione

`FrameworkLogger` è la classe principale per la registrazione veloce di eventi ed errori.

È pensata per essere utilizzata all'interno dei blocchi:

```vb
Try
    ...
Catch ex As Exception
    ...
End Try
````

---

# Log

Registra un messaggio nel file di log.

Esempio:

```vb
FrameworkLogger.Log(
    "Applicazione avviata")
```

Il risultato nel file:

```
2026-07-25 10:30:15 - Applicazione avviata
```

---

# LogError

Registra un errore con eventuale contesto.

Esempio:

```vb
Try

    SalvaDati()

Catch ex As Exception

    FrameworkLogger.LogError(
        ex,
        "Salvataggio ordine")

End Try
```

Risultato:

```
ERROR [Salvataggio ordine] - Errore rilevato
```

---

# LogLeggiScrivi

La classe `LogLeggiScrivi` permette una gestione completa del file log.

Funzioni principali:

| Metodo       | Descrizione                     |
| ------------ | ------------------------------- |
| ScriviLogMsg | Scrive un evento personalizzato |
| ScriviLog    | Scrive un errore dettagliato    |
| ApriLog      | Apre il file log                |
| ClearLog     | Mantiene solo gli ultimi eventi |

---

# ScriviLogMsg

Permette di registrare eventi dell'applicazione.

Esempio:

```vb
LogLeggiScrivi.ScriviLogMsg(
    "Cliente salvato correttamente.")
```

Esempio reale:

```vb
Dim Modello As String =
    Convert.ToString(
        ODataGrid.CurrentRow.Cells(4).Value)

Dim Materiale As String =
    Convert.ToString(
        ODataGrid.CurrentRow.Cells(5).Value)


LogLeggiScrivi.ScriviLogMsg(
    "Ordine " &
    Modello &
    " " &
    Materiale &
    " salvato correttamente.")
```

---

# ScriviLog

Registra un'eccezione completa.

Esempio:

```vb
Try

    CaricaDati()

Catch ex As Exception

    LogLeggiScrivi.ScriviLog(
        NameOf(CaricaDati),
        ex)

End Try
```

Nel file vengono salvati:

```
================================
Data
Procedura
Messaggio
Dettagli eccezione
================================
```

---

# ApriLog

Apre il file:

```
ItalPascal_Log.txt
```

Esempio:

```vb
LogLeggiScrivi.ApriLog()
```

---

# ClearLog

Permette di ridurre la dimensione del file mantenendo solo gli ultimi eventi.

Esempio:

```vb
LogLeggiScrivi.ClearLog()
```

Mantiene gli ultimi:

```
5 gruppi di eventi
```

È possibile modificare il numero:

```vb
LogLeggiScrivi.ClearLog(10)
```

Mantiene gli ultimi:

```
10 gruppi di eventi
```

---

# LogReader

`LogReader` permette di leggere e gestire direttamente il file log.

Metodi disponibili:

| Metodo   | Descrizione                      |
| -------- | -------------------------------- |
| ReadLog  | Restituisce il contenuto del log |
| OpenLog  | Apre il file con Blocco Note     |
| ClearLog | Cancella il file log             |

---

# Lettura del log

Esempio:

```vb
Dim testo As String =
    LogReader.ReadLog()

MessageBox.Show(testo)
```

---

# Apertura con Blocco Note

```vb
LogReader.OpenLog()
```

---

# Cancellazione completa

```vb
LogReader.ClearLog()
```

---

# Esempio completo gestione errore

```vb
Try

    SalvaOrdine()


    LogLeggiScrivi.ScriviLogMsg(
        "Ordine salvato correttamente.")


Catch ex As Exception


    FrameworkLogger.LogError(
        ex,
        "Salvataggio ordine")


End Try
```

---

# Utilizzo consigliato

Si consiglia di utilizzare:

| Situazione          | Metodo consigliato         |
| ------------------- | -------------------------- |
| Evento normale      | `ScriviLogMsg`             |
| Errore applicazione | `FrameworkLogger.LogError` |
| Errore dettagliato  | `LogLeggiScrivi.ScriviLog` |
| Consultazione log   | `LogReader`                |

---

# Note tecniche

* Il logging non deve mai bloccare l'applicazione.
* Gli errori durante la scrittura del log vengono ignorati per evitare crash.
* Il file log viene creato automaticamente.
* Il sistema è compatibile con applicazioni VB.NET WinForms.

---

# 🎬 Video dedicato

**WinItalPascal #06 - Logging**

📺

Inserire link video

---

# 💻 Repository GitHub

[https://github.com/List051/WinItalPascal](https://github.com/List051/WinItalPascal)

---

# 📦 Pacchetto NuGet

[https://www.nuget.org/packages/WinItalPascal](https://www.nuget.org/packages/WinItalPascal)

---

# 📄 Documentazione

Consulta anche:

* README.md
* README_Database.md
* README_GridUtility.md
* README_Reports.md
* README_Forms.md
* README_Popup.md
* CHANGELOG.md

---

Versione documentazione: 2.0.3

**WinItalPascal – Logging**

```