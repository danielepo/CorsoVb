# Design patterns
Soluzioni generali e riutilizabili per problemi comuni.
Aiutano a rispettare la O in SOLID.
Aiutano ad analizzare il codice e capirne il funzionamento.

## Decorator
Come puoi aggiungere stato o metodi ad un oggetto a runtime?

Esempio: come posso creare un oggetto che mi rappresenti un libro inpacchettato con carta regalo?

## Adapter pattern
come faccio a far comunicare tra loro oggetti con interfacce differenti. 

Esempio: Connettere a fonti di dati differenti per salvare i dati

## Singleton
come posso assicurarmi che una sola istanza di un oggettto venga creata dagli sviluppatori?

Esempio: una classe che incapsula la connessione ad unservizio costoso, posso avere una sola connessione per volta

Potrei usare Static, ma ha svantaggi
- non ho controllo sull'inizializzazione
- rende difficile l'estensione di una classe
- non e' possibile utilizzare ereditarieta'

controversial
issue when trying to change the instance refered
- for example for testing

## Factory methods
Come posso separare l'istanziazione di un oggetto dal suo utilizzo?

utile se la creazione richiede 
- l'accesso a risorse che e' bene tenere isolate
- molto codice boilerplate


## State pattern
come possiamo far cambirare il comportamento di un oggetto quando il suo stato cambia?

esempio: tracciare una macchina a stati finiti. controllo ventola

## Strategy pattern
come possiamo selezionare un algorimo a runtime?

le lambda sono un ottimo esempio di strategy patttern


### Observer pattern
when an ojbect changes state, how can any interested parties know
