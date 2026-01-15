using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ErsterProjekt
{
    public class TaschenRechner
    {
        /*
 * Erstelle viele Taschenrechner Methoden.
 * 1. Eine Methode um 2 Zahlen zu summieren (Addition)
 * 2. Eine Methode um eine Zahl von eine andere abzuziehen (Subtraktion)
 * 3. Division und Multiplikation auch programmieren.
 * Hinweis: Jede Methode brauch 2 parameter zahlen. bspw. zahl1 und zahl2.
 * 
 * Weitere Aufgaben:
 * Erstelle eine Methode Exponent: Diese Methode bekommt als Parameter 2 Zahlen.
 * Einmal das Exponent und einmal die Zahl. Bpsw: (9,2) => 81 => 9*9
 * Eine Methode fuer sinus, cosinus und tangenz auch programmieren.
 * 
 * Letzte Aufgabe, schreibe Methoden fuer Addition, Subtraktion, und Multiplikation die eine Liste von
 * int/double werte bekommt und die gesamt summe/subtraktion/produkt berechnet.
 */
     public static int sum(int a, int b)
        {
            return a + b;
        }

     public static int sub(int a, int b) 
        {
            return a - b;
        }
     public static int multi(int a, int b)
        {
            return a * b;
        }
     public static  int division(int a, int b)
        {
            return a / b;
      
        
        }
   
   
        
        
       
           public static double Exponent(double basisZahl, double exponent)
        {
            return Math.Pow(basisZahl, exponent);
        }
 

        }
        public static double Sinus(double winkel)
        {
            return Math.Sin(winkel);
        }

        public static double Cosinus(double winkel)
        {
            return Math.Cos(winkel);
        }

        public static double Tangens(double winkel)
        {
            return Math.Tan(winkel);
        }

    }

}
