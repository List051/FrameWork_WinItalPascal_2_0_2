
```markdown
# WinItalPascal - Forms Utility

## Gestione Windows Form

Il modulo **Forms Utility** di WinItalPascal contiene strumenti per semplificare la gestione grafica dei Windows Form.

La libreria permette di:

- creare titoli personalizzati;
- sostituire il bordo standard dei Form;
- aggiungere pulsanti chiudi/minimizza;
- trascinare il Form tramite il titolo;
- adattare automaticamente il Form allo schermo;
- utilizzare modalità FullScreen.

---

# Classi disponibili

Il modulo Forms comprende:

```

FrmTitolo
ScreenUtility

````

---

# FrmTitolo

## Creazione titolo personalizzato

La classe `FrmTitolo` permette di sostituire il titolo standard del Form con un titolo personalizzato.

La funzione principale è:

```vb
FrmTitolo.CTitolo()
````

La funzione:

* elimina il bordo standard Windows;
* crea un pannello titolo;
* inserisce il testo personalizzato;
* aggiunge pulsante chiudi;
* aggiunge pulsante minimizza;
* permette il trascinamento del Form.

---

# Utilizzo base

Esempio:

```vb
Private Sub FrmOrdini_Load(
sender As Object,
e As EventArgs) Handles MyBase.Load

    FrmTitolo.CTitolo(
        Me,
        "Gestione Ordini")

End Sub
```

Risultato:

Il Form avrà un titolo personalizzato:

```
Gestione Ordini
```

con:

* pulsante chiusura;
* pulsante minimizza;
* barra superiore personalizzata.

---

# Caratteristiche del titolo

Il titolo utilizza automaticamente il tema della libreria:

* colori WinItalPascal;
* font configurati;
* gestione colori centralizzata tramite `Colori`.

---

# ScreenUtility

La classe `ScreenUtility` contiene funzioni per la gestione dello schermo.

Funzioni disponibili:

```
FullScreen()
AdattaCentra()
```

---

# FullScreen

Porta il Form a tutto schermo utilizzando il monitor corrente.

Utilizzo:

```vb
ScreenUtility.FullScreen(Me)
```

Esempio:

```vb
Private Sub FrmMain_Load(
sender As Object,
e As EventArgs) Handles MyBase.Load

    ScreenUtility.FullScreen(Me)

End Sub
```

La funzione:

* identifica il monitor utilizzato;
* esclude automaticamente la barra delle applicazioni;
* adatta il Form all'area disponibile.

---

# AdattaCentra

Ridimensiona e centra automaticamente un Form.

Utilizzo:

```vb
ScreenUtility.AdattaCentra(Me)
```

La funzione:

* calcola lo spazio disponibile;
* ridimensiona il Form;
* lo centra nello schermo.

---

# Esempio completo

Esempio di apertura Form con titolo personalizzato e FullScreen:

```vb
Public Class FrmPrincipale

    Private Sub FrmPrincipale_Load(
    sender As Object,
    e As EventArgs) Handles MyBase.Load

        FrmTitolo.CTitolo(
            Me,
            "Gestione Clienti")

        ScreenUtility.FullScreen(Me)

    End Sub

End Class
```

---

# Utilizzo consigliato

Per un'applicazione WinForms è possibile inizializzare ogni Form con:

```vb
FrmTitolo.CTitolo(
    Me,
    "Nome Form")
```

e successivamente scegliere:

Modalità completa:

```vb
ScreenUtility.FullScreen(Me)
```

oppure modalità adattata:

```vb
ScreenUtility.AdattaCentra(Me)
```

---

# Gestione errori

Le classi Forms utilizzano:

```
FrameworkLogger
```

In caso di errore viene registrato automaticamente:

```
ItalPascal_Log.txt
```

---

# Documentazione correlata

```
README.md
README_Database.md
README_GridUtility.md
README_Reports.md
README_Logging.md
README_Popup.md
```

---

# Video Tutorial

Video dedicato al modulo Forms:

```
https://youtu.be/BsjiVc-j8qs?si=_L_G-_f82vs04tNl
```

---

# Repository GitHub

```
https://github.com/List051/WinItalPascal
```

---

# Pacchetto NuGet

```
WinItalPascal
```

---

WinItalPascal

Utility Library for VB.NET WinForms

Versione documentazione: 2.0.3

```