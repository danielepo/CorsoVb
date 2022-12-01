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