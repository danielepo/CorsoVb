# Tipi

I tipi sono divisi in due macrocategorie:
- Value types
- Reference types

la distinzione maggiore tra i due è in quale zona di memoria vengono salvati i dati quando una variabile viene inizializzata.
In particolare, quando una variabile viene istanziata viene riservao un'area nello stack, nel caso la Value Type sia di tipo valore questo 
spazio di memoria conterrà il valore della variabile, altrimenti conterrà un indirizzo di memoria che punta allo heap (che è dove vive il valure
delle variabili di tipo Reference type)

## Tipi Primitivi

I tipi primititvi sono i tipi nativi del framework e ce ne sono di diverso tipo a seconda dell'utilizzo e delle dimensioni necessarie

### Tipi Numerici

1 byte, Tipo nativo System.Byte
```vb
Dim v as Byte  ' range da 0 a 2^8
Dim v as SByte ' range da -2^7 a 2^7-1
```

 16 bit,  tipo nativo `System.Int16`
```vb
Dim v as UShort  ' range da 0 a 2^16
Dim v as Short ' range da -2^15 a 2^15-1
```

32 bit,  tipo nativo `System.Int32`
quello piu' comunemente utilizzato
```vb
Dim v as UInteger  ' range da 0 a 2^32
Dim v as Integer ' range da -2^31 a 2^31-1
```

64 bit,  tipo nativo `System.Int64`
```vb
Dim v as ULong  ' range da 0 a 2^64
Dim v as Long ' range da -2^63 a 2^63-1
```

Floating point a singlola e doppia precisione
Rappresentano i numeri decimali come una coppia _mantissa_ ed esponente. La mantissa rappresena il numero scalato ad un'unita' e l'esponene
indica dove spostare la virgola. Ad esempio 54.6 viene rappresentato come 5.46 con mantissa con esponenete 1 in modo che 5.46*10^1 = 54.6


```vb
Dim f as Single ' 32 bit: 1 bit of sign, 23 bits of mantissa, and 8 bits of exponent
Dim d as Double ' 64 bit: 1 bit of sign, 52 bits of mantissa and 11 bits of exponent
```

### Tipi compositi

come tipi compositi abbiamo gli Array, gli Oggetti e le Tuple

### Array 
sono una collezione di lunghezza definita in compilazione di un tipo particolare. Possono contenere solo elementi del tipo definito

Un array si definisce cosi
```vb
Dim numeri(4) As Integer
```

L'array in VB.Net parte dal indice 0 e cresce fino al numero indicato tra parentisi. 
Al contrario di altri linguaggi il numero indicato in definizione non e' la lunguezza dell'array, ma si tratta dell'indice massmio. 
Un array definito come sopra risulta essere di lunghezza 5

una volta definito, i singoli elementi possono essere assegnati o letti accedendovi con il rispettivo indice
```vb
numeri(2) = 65

Console.WriteLine(numeri(4))
```

gli array possono essere definiti come matrici, o come array multidimensionali
```vb
Dim matrice (2,5) As Integer
Dim mult (2)() As Integer
```

la piu grossa limitazione degli Array e' quella di dover conoscere la dimensione dell'array in fase di definizione. 
Un oggetto piu' flessibile e' L'`ArrayList` che si trova nel Namespace `System.Collections`. Questo si comporta come una lista pero' ha il vantaggio di permettere l'accesso attraverso l'indice.
Una volta dichiarato ed inizializzato gli elementi possono essere aggiunti col metodo Add e letti con l'indice corrispondente

```vb
Dim arrayList as ArrayList = new ArrayList
arrayList.Add(2)
arrayList(0) = 1
Console.WriteLine(arrayList(0))
```

L'`ArrayList` accetta qualunque `Object` in Add e quindi puo' contenere valori di tipo indefinito

```vb
Dim arrayList As ArrayList = New ArrayList
arrayList.Add(1)
arrayList.Add("dfs")
arrayList.Add(3.4)
arrayList.Add("A"c)
```

Questo lo rende molto flessibile pero bisogna stare molto attenti quando si vanno ad utilizzare i dati letti perche' le operazioni tra tipi diversi potrebbero non essere compatibili.

Una lista che risolve questo problema e' presente nel namespace `System.Collection.Generic` e sfrutta un meccanismo per parametrizzare li tipo della lista. In questo modo e' possibile definire una lista di un tipo arbitrario ed il compilatore controllera' che non ci siano violazioni di assegnazione

## Widening and Narrowing
Assegnare una variabile di un tipo piu' piccolo ad una di un tipo piu' largo e' detto widening (casting implicito) ed e' permesso dal compilatore in quando siamo sicuri che non si perdono informazioni

L'operazione inversa (Narrowing) e' rischiosa in quanto si rischia di perdere informazioni. Di default il compilatore la permette e al massimo si ottiene un eccezione a runtime. Per far si che il compilatore controlli che non vengano fatti Narrowing impliciti bisogna abilitare l'opzione Strict mettendo in testa al file la dicitura `Option Strict On`. 

Una conversione esplicita di tipo e' sempre permessa perche' si presume che si abbia maggiore controllo di quello che sta succedendo

```vb
Dim by As SByte = -128
Dim shrt As Short = 500
Dim int As Integer  = 2222

int = shrt
' danger
by = shrt 
by = CSByte(shrt)
```

## Reference Type e Value Type

Tutti i tipi primitivi vengono inizializzati quando il cursore passa dalla dichiarazione. Il valore del tipo primitivo viene salvato nello Stack e corrisponde esattamente al valore della variabile, ad esempio `Dim i = 1` conterra' l'intero `1` nello stack. 

Gli oggetti devono essere invece dichiarati ed istanziati. La dichiarazione "prenota" uno spazio nello stack (con valore `Nothing`), l'istanziamento crea l'oggetto nel heap e lo spazio dello stack verra' valorizato con l'indirizzo nel quale si trova l'oggetto. Questo vuol dire che le variabili di tipo Reference Type contengono un puntatore allo heap e non l'oggetto in se. 

# Control Flow

## Cicli
Esistono diversi tipi di ciclo, i piu comunemente utilizzati sono `For`, `For Each` e `While`

```vb
For i = 0 To arrayList.Count
    Console.WriteLine(arrayList(i))
Next

For i = 2 To 0 Step -1
    Console.WriteLine(listSimple(i))
Next

For Each element In arrayList
    Console.WriteLine(element)
Next


i = 0
While i = 0
    Console.WriteLine(listSimple(i))
    i += 1
End While
```

un tipo particolare di ciclo e' il ciclo `Do`, che al contrario del `While` esegue sempre almeno una volta il suo blocco di istruzioni
```vb
i = 0
Do
    Console.WriteLine(listSimple(i))
    i += 1
Loop While i < 0
```

## If e Select

la chiave `If` controlla il risultato di un espressione booleana e se e' `True` allora entra nel blocco di codice altrimenti passa alla condizione `Else` o `ElseIf` se presente e controlla quella. 

```vb
If element.Key = "oggi" Then
    Console.WriteLine("oggi")
ElseIf element.Key = "ieri" Then
    Console.WriteLine($"ieri {element.Value:dd}")
Else
    Console.WriteLine(element.Value)
End If
```

se un certo valore viene controllato piu' volte in una catena di `If` e' piu' elegante ed anche ha migliori prestazioni l'utilizzo del `Select Case`

```vb
Select Case element.Key
    Case "oggi"
        Console.WriteLine("oggi")
    Case "ieri"
        Console.WriteLine($"ieri {element.Value:dd}")
    Case Else
        Console.WriteLine(element.Value)
End Select
```

