# SOLID

Acronimo che i pricipi cardini per progettare software orientato agli oggetti in modo che il codice sia leggibile, manutenibile ed estensibile.

I principi sono i seguenti

## Single Responsibility Principle
Tutte le classi e metodi devono avere una singola responsabilita'. 
In particolare una classe deve avere un solo motivo per cambiare, per esempio cambia solo se la regola di business che implementa cambia, non cambia se cambia la struttura dati.

## Open/Closed Principle
Tutte le entita' dovrebbero essere tali che il software sia facilmente estensibile con il minimo modifiche al codice esistente 
in particolare l'interfaccia non cambia, mantenendosi stabile agli occhi degli utilizzatori, ma puo' estendersi aggiungendo piu' funzionalita'
un modo tipico di estendere le classi e' attraverso il polimorfismo

## Liskov Substitutition Principle
- if S if a subtype of T then objects of type T can be replaced with objects of type S

Controesempio: 
- (il quadrato non e' un rettangolo)[https://effectivesoftwaredesign.com/2010/09/20/when-a-square-is-not-a-rectangle/]

## Interface Segregation Principle

nessuna lcase deve dipendere da metodi che non usa

l'idea e' quella di rompere interfacce molto grandi in interfacce piu specializzate
## Dependency Inversion Principle

questo principio tende a rendere indipendenti gli elementi dei layer piu' alti da quelli dei' layer piu' bassi. 

le classi non devono dipendere da altre classi ma devono dipendere da astrazioni delle stesse. 

quando si disegnano le classi bisogna pensare ad interazioni astratte 

This dependency upon lower-level components limits the reuse opportunities of the higher-level components

https://devblogs.microsoft.com/vbteam/dependency-injection-with-visual-basic-net-part-1/
https://devblogs.microsoft.com/vbteam/dependency-injection-with-visual-basic-net-part-2-ioc-containers/

https://autofac.org/