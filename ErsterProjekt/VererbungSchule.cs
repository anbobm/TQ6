using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml.Linq;

namespace ErsterProjekt
{
    // Elternklasse mit dem Namen Person
    internal class Person
    {
        // Attribute: Die Klasse soll zwei Attribute besitzen
        public string Name;
        public int Alter;
            
        // Die Klasse soll einen Konstruktor haben, der beide Werte entgegennimmt

        //Der Konstruktor soll die übergebenen Werte in den Attributen speichern
        public Person(string name, int alter)
        {
            Name = name;
            Alter = alter;
        }

        // Die Klasse soll eine Methode besitzen, die alle Informationen ausgibt
        public virtual void AlleInfosAusgeben()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Alter: {Alter}");
        }
    }

    // Kindklasse erstellen
    internal class Schueler : Person
    {
        // Zusätzliches Attribut
        public string Klasse { get; }

        // Die Klasse soll einen eigenen Konstruktor haben, der Name,Alter und Klasse entgegennimmt
        public Schueler(string name, int alter, string klasse) : base(name, alter)//Mit base weil Person einen Konstruktor hat
        {
            Klasse = klasse;
        }

        // Methode, um alle Infos auszugeben (inklusive Infos aus der Elternklasse)
        public override void AlleInfosAusgeben()
        {
            // Zuerst die Infos aus der Elternklasse ausgeben
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Alter: {Alter}");
            // Dann das zusätzliche Attribut ausgeben
            Console.WriteLine($"Klasse: {Klasse}");
        }
    }





    //Personen in einem Unternehmen:Es gibt allgemeine Mitarbeiter und es gibt Auszubildene!
    //Erstelle eine Elternklasse Mitarbeiter. Die Klasse soll 2 Attribute haben: Name und Gehalt.
    //Die Klasse soll einen Konstruktor haben, der beide Werte entgegennimmt.
    //Die Klasse soll eine Methode besitzen, die alle Informationen ausgibt.
    //Erstelle eine Kindklasse mit dem Namen Azubi, die von Mitarbeiter erbt.
    //Zusätzliches Attribut: Ausbildungsberuf
    //Die Klasse soll einen eigenen Konstruktor haben, er soll folgendes entgegennehmen:
    //Name, Gehalt, Ausbildungsberuf. Name und Gehalt sollen an den Konstruktor der Elternklasse weitergegeben werden.
    //Die Klasse soll eine Methode besitzen, die alle Informationen ausgibt.
    //(inklusive der Informationen aus der Elternklasse).
    //Testprogramm in der Main Methode(program.cs) schreiben:
    //Erstelle ein Objekt der Klasse Azubi.
    //Übergebe Testwerte und gib alle Informationen des Objekts auf der Konsole aus!

    // Elternklasse
    internal class Mitarbeiter
    {
        // Attribute
        public string Name;
        public decimal Gehalt;

        // Konstruktor
        public Mitarbeiter(string name, decimal gehalt)
        {
            Name = name;
            Gehalt = gehalt;
        }

        // Methode zum Ausgeben aller Infos
        public virtual void AlleInfosAusgeben()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gehalt: {Gehalt}");
        }
    }

    // Kindklasse
    internal class Azubi : Mitarbeiter
    {
        // Zusätzliches Attribut
        public string Ausbildungsberuf;

        // Konstruktor
        public Azubi(string name, decimal gehalt, string ausbildungsberuf)
            : base(name, gehalt)// Nötig, weil Mitarbeiter einen Konstruktor hat
        {
            Ausbildungsberuf = ausbildungsberuf;
        }

        // Methode zum Ausgeben aller Infos (inkl. Elternklasse)
        public override void AlleInfosAusgeben()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gehalt: {Gehalt} Euro");
            Console.WriteLine($"Ausbildungsberuf: {Ausbildungsberuf}");
        }
    }



    //Produkte in einem Supermarkt:
    //Es gibt: allgemeine Produkte, Lebensmittel, Getränke und Haushaltsartikel!
    //Erstelle eine Elternklasse mit dem Namen Produkt. Die Klasse soll zwei Attribute besitzen:
    //Name und Preis.
    //Die Klasse soll einen Konstruktor haben, der beide Werte entgegennimmt
    //Der Konstruktor soll die übergebenen Werte in den Attributen speichern
    //Die Klasse soll eine Methode besitzen, die alle Informationen ausgibt.
    //Erstelle eine Kindklasse mit dem Namen Lebensmittel, die von Produkt erbt.
    //Zusätzliches Attribut: HaltbarBis.
    //Eigener Konstruktor: Name, Preis, HaltbarBis.
    //Name und Preis sollen an den Konstruktor der Elternklasse weitergegeben werden
    //Eigene Methode zur Ausgabe aller Informationen!
    //Erstelle eine Kindklasse mit dem Namen Getraenk, die von Produkt erbt.
    //Zusätzliches Attribut: Volumen
    //Eigener Konstruktor: Name, Preis, Volumen.
    //Übergabe von Name und Preis an die Elternklasse
    //Methode zur Ausgabe aller Informationen
    //Erstelle eine Kindklasse mit dem Namen Haushaltsartikel, die von Produkt erbt.
    //Zusätzliches Attribut: Kategorie
    //Eigener Konstruktor: Name, Preis, Kategorie.
    //Übergabe von Name und Preis an die Elternklasse
    //Methode zur Ausgabe aller Informationen!
    //Im Program.cs: Erstelle je ein Objekt von: Lebensmittel, Getraenk und Haushaltsartikel.
    //Übergebe Testwerte und gib jeweils alle Informationen auf der Konsole aus!

    // Elternklasse
    internal class Produkt
    {
        // Attribute
        public string Name;
        public decimal Preis;

        // Konstruktor
        public Produkt(string name, decimal preis)
        {
            Name = name;
            Preis = preis;
        }

        // Methode zur Ausgabe
        public virtual void AlleInfosAusgeben()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Preis: {Preis} EUR");
        }
    }

    // Kindklasse Lebensmittel
    internal class Lebensmittel : Produkt
    {
        // Zusätzliches Attribut
        public string HaltbarBis;

        // Eigener Konstruktor
        public Lebensmittel(string name, decimal preis, string haltbarBis)
            : base(name, preis) // Nötig, weil Produkt einen Konstruktor hat
        {
            HaltbarBis = haltbarBis;
        }

        // Eigene Methode zur Ausgabe
        public override void AlleInfosAusgeben()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Preis: {Preis} EUR");
            Console.WriteLine($"Haltbar bis: {HaltbarBis}");
        }
    }

    
    // Kindklasse: Getränk
    
    internal class Getraenk : Produkt
    {
        // Zusätzliches Attribut
        public double Volumen;

        // Eigener Konstruktor
        public Getraenk(string name, decimal preis, double volumen)
            : base(name, preis)
        {
            Volumen = volumen;
        }

        // Eigene Methode zur Ausgabe
        public override void AlleInfosAusgeben()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Preis: {Preis} EUR");
            Console.WriteLine($"Volumen: {Volumen} Liter");
        }
    }

    
    // Kindklasse: Haushaltsartikel
    
    internal class Haushaltsartikel : Produkt
    {
        // Zusätzliches Attribut
        public string Kategorie;

        // Eigener Konstruktor
        public Haushaltsartikel(string name, decimal preis, string kategorie)
            : base(name, preis)
        {
            Kategorie = kategorie;
        }

        // Eigene Methode zur Ausgabe
        public override void AlleInfosAusgeben()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Preis: {Preis} EUR");
            Console.WriteLine($"Kategorie: {Kategorie}");
        }
    }












}

