# Classi ed Oggetti

Una classe e' la definizione dello stato e del comportamento di un oggetto. Si puo pensare ad una classe come uno stampo per biscotti, permettte di creare biscotti tutti con la stessa forma e dimensione, anche se, con impasti differenti. In questo esempio il biscotto corrisponde all'oggetto che in termini piu' tecnici diventa un'istanza di una classe.

Un oggetto viene dichiarato come una qualunque variabile con `Dim` e il tipo di variabile, ma viene inizializzato usando una speciale keyword `New` che si occupera di chiamare un metodo della classe chiamato costruttore

```vb
Dim professor As Professor = new Professor()
```

In questo esempio viene creato un nuovo professor chiamando il costruttore di default della classe qua sotto

```vb
Public Class Professor
    Public Sub New()
    End Sub
End Class
```

Una classe mantiene uno stato con delle variabili speciali dette Campi


```vb
' campi privati
Public Class Professor
    Private _age As Byte
    Private _Name As String

    Public Sub New()
    End Sub
End Class

' campi publici
Public Class Professor
    Public Age As Byte
    Public Name As String

    Public Sub New()
    End Sub
End Class
```

e' buona norma che i campi siano tutti privati e che vengano letti e scritti attraverso metodi in modo da Incapsulare il le regole che permettono di accedere a questo campo. qua sotto ad esempio abbiamo delle regole per impostare l'eta. Se il campo fosse pubblico non si avrebbe alcun controllo sul valore del campo Age, usando invece il metodo speciale `Set` e' possibile demandare ad esso la logica che permette di fornire un'eta' coerente ed ora sappiamo che ogni oggetto Professor avra' un eta' nel range dichirato.

```vb
Public Class Professor
    Private _age As Byte

    Public Sub New()
    End Sub

        Public Property Age As Byte
        Get
            Return _age
        End Get
        Set
            If Value > 100 Then
                Throw New Exception("Age must be below 100")
            End If
            _age = Value
        End Set
    End Property
End Class
```

Questo metodo speciale si chiama `Property` ed e' un metodo per definire in maniera compatta un Getter ed un Setter per i campi privati. Nel caso in cui non sia necessario dichiare nessuna regola particolare e' possibile utilizziare quello che si chiama `Autoproperty` che permette di essere piu' concisi nella scrittura della classe.

```vb
' campi privati
Public Class Professor
    Private _age As Byte
    Private _Name As String
    
    Public Property Courses As List(Of String)

    Public Sub New()
    End Sub
End Class
```


## Ereditarieta'
## Polimorfismo