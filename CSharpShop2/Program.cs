﻿// See https://aka.ms/new-console-template for more information


/*
A partire da quanto già fatto con csharp-oop-shop dove vi era stato chiesto di creare una classe Prodotto generica 
per gestire un generico prodotto dello Shop, vi chiedo ora di essere più specifici e di creare le sottoclassi 
opportune di alcuni prodotti che potremmo identificare nel nostro shop.
In particolare immaginiamo che nel nostro shop possiamo commerciare le seguenti tipologie di prodotto:
- Acqua (massimo 1.5L)
- Sacchetto di Frutta a pezzi (al massimo puo contenere 5 pezzi di frutta)
- Elettrodomestico
- Cibo in Scatola (al massimo può contenere 300g di peso su una scatola)
Per ognuno dei seguenti prodotti più specifici vi si chiede di identificare quali potrebbero essere i loro attributi 
e metodi che eventualmente gli riguardano, ereditando i metodi e gli attributi generici dalla classe Prodotto creata 
nell’esercizio precedente.
Un esempio per la classe Acqua che eredità Prodotto è aggiungere i seguenti attributi e metodi:
attributo litri: per indicare quanti litri di acqua ci sono nella bottiglia di acqua
attributo ph: che indica il livello di acidità dell’acqua (sola lettura)
attributo sorgente: che indica la sorgente di provenienza dell’acqua (sola lettura)
... ecc ecc
- metodo bevi (double litriDaBere) che toglie dall’attributo litri una quantità pari a litriDaBere di acqua se presenti.
- metodo riempi(double litri) che riempie la bottiglia di acqua con tot litri di acqua, stando attenti a 
non riempirla troppo.
- metodo svuota() che rimuove tutta l’acqua dalla bottiglia.
- metodo stampaProdotto() che fa l’override del metodo di base StampaProdotto già dichiarato nella superclasse 
Prodotto (se non lo avete già fatto dichiaratelo anche nella classe prodotto è si occupa di stampare 
il “codice - nome”,l lo abbiamo chiamato NomeEsteso), per stampare oltre al codice e al nome dell’acqua, 
anche la sua sorgente, il ph e i litri contenuti.
Ricordatevi di creare questi metodi in maniera responsabile, in modo che non rendono “incoerente” lo stato 
dei vostri oggetti (ad esempio non posso bere più dei litri contenuti nella bottiglia, o non posso riempire più di tot 
una bottiglia!).
E così via per tutti gli altri elementi qui sopra riportati, provate a pensare attributi e metodi che potrebbero 
servire ai vostri prodotti specializzati Acqua, sacchetto di frutta a pezzi, elettrodomestici e cibo in scatola.
Al solito usate opportunamente i livelli di accesso (public, private, protected, internal ecc ecc), i costruttori, 
i metodi getter e setter ed eventuali altri metodi di “utilità”.
Una volta finite più o meno le vostre classi, nel Program.cs, provate a testare un pò i vostri prodotti specializzati, 
osservando come i metodi della classe generica prodotto e quelli più specifici vengono richiamati e 
siano disponibili nel vostro programma principale.
*/

using CSharpShop2;

//creazione nuovo prodotto
Prodotto prodottoNegozio = new Prodotto("shampoo", "per capelli normali", 1.60, 22);

//stampa nome completo del prodotto
prodottoNegozio.StampaProdotto();

//creazione da classe acqua
Acqua acquaNaturale = new Acqua("naturale", "acqua naturale", 0.80, 10, 1.5, 7.0, "fonte");
acquaNaturale.StampaProdotto();



