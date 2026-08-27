
### Funzionalità reali di `PopupHelper`

Non è un semplice popup statico, ma un sistema completo:

✅ **Popup automatico al passaggio del mouse**

```vb
PopupHelper.AttachPopup(...)
```

* associa il popup ad un qualsiasi `Control`;
* si attiva con `MouseEnter`;
* si chiude con `MouseLeave`;
* supporta immagini;
* supporta colori personalizzati.

---

✅ **Popup manuale**

Hai anche:

```vb
PopupHelper.ShowPopup(...)
```

quindi si può mostrare un popup da codice in qualsiasi momento.

---

✅ **Gestione automatica posizione**

`PopupForm.ShowNearControl`

gestisce:

* apertura vicino al controllo;
* controllo dei bordi dello schermo;
* spostamento automatico sopra il controllo se non c'è spazio sotto.

---

✅ **Effetto Fade**

Il popup non appare improvvisamente:

```vb
Opacity = 0
```

poi:

```vb
FadeIn()
```

con incremento progressivo.

---

✅ **Chiusura sicura**

La gestione:

```vb
PopupHelper.HidePopup()
```

evita popup sovrapposti.

---

````markdown
# WinItalPascal – Popup e Utility


## Introduzione

La libreria **WinItalPascal** mette a disposizione un sistema semplice e riutilizzabile per creare popup informativi nelle applicazioni **VB.NET WinForms**.

Il modulo permette di associare finestre popup personalizzate ai controlli dell'interfaccia utente senza dover creare manualmente form aggiuntivi.

Le caratteristiche principali sono:

* popup automatici al passaggio del mouse;
* popup manuali;
* immagini personalizzate;
* colori configurabili;
* effetto Fade In;
* posizionamento automatico vicino al controllo.


---

# Classe principale


La gestione dei popup viene effettuata tramite:

```vb
PopupHelper
````

La classe contiene i principali metodi:

| Metodo      | Descrizione                      |
| ----------- | -------------------------------- |
| AttachPopup | Associa un popup ad un controllo |
| ShowPopup   | Visualizza manualmente un popup  |
| HidePopup   | Chiude il popup attivo           |

---

# AttachPopup

## Descrizione

`AttachPopup` permette di associare un popup informativo ad un controllo WinForms.

Il popup viene mostrato automaticamente quando il mouse entra nel controllo.

Sintassi:

```vb
PopupHelper.AttachPopup(
    ctrl,
    message,
    img,
    backgroundColor,
    textColor)
```

Parametri:

| Parametro       | Descrizione                                 |
| --------------- | ------------------------------------------- |
| ctrl            | Controllo WinForms a cui associare il popup |
| message         | Testo visualizzato                          |
| img             | Immagine opzionale                          |
| backgroundColor | Colore sfondo popup                         |
| textColor       | Colore testo popup                          |

---

# Esempio base

Esempio utilizzato nel form `FrmOrdini`:

```vb
Dim imgBeni As Image =
    My.Resources.cheque


PopupHelper.AttachPopup(
    RjCircSalvaBeni,
    vbCrLf &
    "ATTENZIONE" &
    vbCrLf &
    vbCrLf &
    "Salva eventuali modifiche",
    imgBeni)
```

Quando l'utente posiziona il mouse sul pulsante viene visualizzato il popup.

---

# Utilizzo con immagini

Le immagini possono essere caricate direttamente dalle risorse del progetto:

```vb
Dim imgInfo As Image =
    My.Resources.cashier

Dim imgWarning As Image =
    My.Resources.calculator_50
```

Esempio:

```vb
PopupHelper.AttachPopup(
    Button1,
    "Informazioni utili" &
    vbCr &
    "Altre informazioni",
    imgInfo)


PopupHelper.AttachPopup(
    Button2,
    "Attenzione! Controlla i dati",
    imgWarning)
```

---

# Personalizzazione colori

È possibile personalizzare:

* colore dello sfondo;
* colore del testo.

Esempio:

```vb
Dim imgSalva As Image =
    My.Resources.cheque


PopupHelper.AttachPopup(
    RjBtnSalva,
    "Salva tutto",
    imgSalva,
    Color.AliceBlue,
    Color.Blue)
```

Risultato:

```
Sfondo popup = AliceBlue
Testo popup   = Blue
```

---

# Colori predefiniti

Se i colori non vengono indicati, il framework utilizza automaticamente:

```
Sfondo = Yellow
Testo   = Black
```

Esempio:

```vb
PopupHelper.AttachPopup(
    RjBtnSalva,
    "Salva tutto",
    imgSalva)
```

---

# ShowPopup

È possibile visualizzare manualmente un popup.

Esempio:

```vb
PopupHelper.ShowPopup(
    RjBtnSalva,
    "Operazione completata",
    My.Resources.cheque)
```

Il popup viene mostrato immediatamente vicino al controllo indicato.

---

# HidePopup

Chiude il popup attualmente visualizzato.

Esempio:

```vb
PopupHelper.HidePopup()
```

---

# PopupForm

La classe interna utilizzata per la visualizzazione è:

```vb
PopupForm
```

Caratteristiche:

* finestra senza bordi;
* sempre in primo piano;
* ridimensionamento automatico;
* supporto immagini;
* layout dinamico;
* effetto Fade.

---

# Posizionamento automatico

Il popup viene automaticamente posizionato vicino al controllo.

La libreria controlla:

* limite destro dello schermo;
* limite inferiore dello schermo;
* posizione minima visibile.

Se non è possibile mostrarlo sotto il controllo, viene visualizzato sopra.

---

# AutoClose

È disponibile anche la chiusura automatica:

```vb
PopupForm.AutoClose(3000)
```

dove il valore indica i millisecondi prima della chiusura.

---

# Utilizzo consigliato

Associare i popup nel metodo `Load` del form:

```vb
Private Sub FrmMain_Load(
    sender As Object,
    e As EventArgs) Handles MyBase.Load


    PopupHelper.AttachPopup(
        BtnSalva,
        "Salva documento",
        My.Resources.save)


End Sub
```

---

# Vantaggi

L'utilizzo di `PopupHelper` permette di:

* migliorare l'esperienza utente;
* aggiungere informazioni contestuali;
* evitare finestre informative separate;
* mantenere uniforme lo stile dell'applicazione.

---

# Note tecniche

* Compatibile con controlli WinForms standard e personalizzati.
* Le immagini vengono normalmente caricate tramite `My.Resources`.
* La gestione degli errori utilizza `FrameworkLogger`.
* Il popup attivo viene gestito centralmente dalla libreria.

---

# 🎬 Video dedicato

**WinItalPascal #07 - Popup e Utility**

📺

[https://youtu.be/4EyZb3B9hFM?si=kW89BimOeiNbdfmU](https://youtu.be/4EyZb3B9hFM?si=kW89BimOeiNbdfmU)

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
* README_Logging.md
* CHANGELOG.md

---

Versione documentazione: 2.0.3

**WinItalPascal – Popup e Utility**

```
