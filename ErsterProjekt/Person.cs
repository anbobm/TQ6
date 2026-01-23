using ErsterProjekt;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class Person
    {
        //Attribute

        private string name;    
        private int alter;




        

        //konstrukture
        public Person(string name, int alter)
        {
            
            this.name = name;
            this .alter = alter;
        }
        //methode 
        public string GetName() 
        {

            return name;
     
        
        }//methode
        public int GetAlter()
        {
            return alter;
        }
    }

}

internal class Schueler : Person
{//Attribute
    private string klasse;
    //konstrukture
    public Schueler(string name, int alter, string klasse) : base(name, alter)
    {
        this.klasse = klasse;

    }
    //methode Getklasse
    public string GetKlasse()
    {
        return klasse;
    }
    //methode ausgabe
    public void Ausgabe()
    {
        Console.WriteLine($"Name: {GetName()}");
        Console.WriteLine($"Alter: {GetAlter()}");
        Console.WriteLine($"Klasse: {GetKlasse()}");
    }
}