
using Bibliothekverwaltungsystemm.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bibliothekverwaltungsystemm.Controllers
{//1. Controller-Klasse.Du erstellst einen Controller, der von Controller erbt
    public class AusleiheController:Controller
    {
        //_bibliothek ist dein Speicher für Bücher, Kunden und Ausleihen.
        private static Bibliothek _bibliothek = new();
        //2. Liste aller Ausleihen anzeigen
        public IActionResult index()
        {
            return Views(_bibliothek.Ausleihen);



         }



        // 3. Formular zum Ausleihen anzeigen
        // „Zeige das Formular zum Erstellen einer neuen Ausleihe.“
        //🟫 _bibliothek.Buecher._bibliothek ist dein Bibliotheks‑Objekt.

       // Buecher ist die Liste aller Bücher, die in der Bibliothek gespeichert sind.
              

      
        public IActionResult Create()
        {
            //FindAll(...) durchsucht die Liste.b => b.IstVerfuegbar() ist eine Lambda‑Funktion.
         //Sie bedeutet: „Gib mir alle Bücher, bei denen IstVerfuegbar() true ist.“
         //Also:

            //👉 „Gib mir alle Bücher, die gerade verfügbar sind.“

            ViewBag.Buecher = _bibliothek.Buecher.FindAll(b => b.IstVerfuegbar());
            //🟦 ViewBag.Kunden = _bibliothek.Kunden
            //Hier passiert:

            //Du holst die Liste aller Kunden
            //Du speicherst sie in ViewBag.Kunden

              //Die View kann sie später anzeigen


                 ViewBag.Kunden = _bibliothek.Kunden;

            return View();//👉 „Zeige die HTML‑Seite Create.cshtml  an.“.ASP.NET sucht automatisch:
            // Views / Ausleihe / Create.cshtml

        }

        // Ausleihe starten
        //[HttpPost]
        
       /* Bedeutung: Diese Methode wird nur aufgerufen, wenn ein POST‑Request kommt.

        In deinem Fall: Wenn der Benutzer im HTML‑Formular auf „Ausleihe starten“ klickt.

        Das Formular schickt Daten (buchId, kundenId) an diese Methode.*/
        public IActionResult Create(int buchId, int kundenId)

        /*       public IActionResult Create(int buchId, int kundenId)
   public: Von außen(Browser) aufrufbar.

   IActionResult: Die Methode gibt ein „Web‑Ergebnis“ zurück(View, Redirect, Fehler, …).

   Create: Name der Action – hier: „Ausleihe anlegen“.

   int buchId, int kundenId:*/

        /*
                    Das sind die Parameter, die aus dem HTML‑Formular kommen.

        Im Formular hast du z. B.:


                        <select name = "buchId" > ...</ select >
                        < select name= "kundenId" > ...</ select >*/
        /*ASP.NET füllt diese Parameter automatisch mit den ausgewählten Werten.
         var buch = _bibliothek.Buecher.FirstOrDefault(b => b.Id == buchId);
_bibliothek.Buecher: Liste aller Bücher in deiner Bibliothek.

FirstOrDefault(...):

durchsucht die Liste

sucht das erste Buch, bei dem b.Id == buchId ist

wenn keins gefunden wird → null

b => b.Id == buchId:

Lambda‑Ausdruck

bedeutet: „nimm das Buch, dessen Id gleich der übergebenen buchId ist“  
        
         */
/*        👉 Ergebnis:
buch ist entweder:

das gefundene Buch

oder null, wenn keins passt*/


        {
            var buch = _bibliothek.Buecher.FirstOrDefault(b => b.Id == buchId);
            var kunde = _bibliothek.Kunden.FirstOrDefault(k => k.Id == kundenId);

            if (buch == null || kunde == null)
                return BadRequest("Ungültige Auswahl");
            /*   if (buch == null || kunde == null)
               Prüft:

                   wurde ein gültiges Buch gefunden?

                   wurde ein gültiger Kunde gefunden?

   || bedeutet: „oder“

   Wenn entweder Buch oder Kunde nicht existiert → Fehler.return BadRequest("Ungültige Auswahl");
            Wenn Buch oder Kunde nicht gefunden wurden:

brich die Methode ab

schicke eine HTTP‑Fehlermeldung (400 Bad Request) zurück

mit Text: „Ungültige Auswahl“

Das ist eine einfache Validierung:

schützt vor falschen IDs

z. B. wenn jemand manuell eine URL manipuliert*/

            var ausleihe = new Ausleihe(buch, kunde, DateOnly.FromDateTime(DateTime.Now));
            ausleihe.starteAusleihe();

            _bibliothek.Ausleihen.Add(ausleihe);

            return RedirectToAction("Index");
            /*  var ausleihe = new Ausleihe(buch, kunde, DateOnly.FromDateTime(DateTime.Now));
              Hier erstellst du ein neues Ausleihe‑Objekt.

  Du übergibst:

  buch → das ausgewählte Buch

  kunde → der ausgewählte Kunde

  DateOnly.FromDateTime(DateTime.Now) → heutiges Datum als Ausleihdatum


             Das passt zu deinem Konstruktor:

  csharp
  public Ausleihe(Buch buch, Kunde kunde, DateOnly ausleihdatum)
            
             👉 Ergebnis:
ausleihe ist jetzt eine konkrete Ausleihe:
„Kunde X leiht Buch Y am Datum Z“.
            
             
             
             ausleihe.starteAusleihe();
Ruft deine Methode in der Klasse Ausleihe auf:
           public void starteAusleihe()
{
    buch.SetzeAusgeliehen();
    kunde.buchAusleihen(this);
}

             
            Das bedeutet:

Das Buch wird als ausgeliehen markiert.

Der Kunde bekommt diese Ausleihe in seine Liste.

👉 Hier passiert die Geschäftslogik.
            _bibliothek.Ausleihen.Add(ausleihe);
Du fügst die neue Ausleihe in die Liste aller Ausleihen der Bibliothek ein.

Ausleihen ist eine List<Ausleihe> in deiner Bibliothek‑Klasse.

Damit ist die Ausleihe im System gespeichert (zumindest im Speicher).
            
             
             return RedirectToAction("Index");
Nach erfolgreicher Ausleihe:

leite den Benutzer weiter zur Index‑Action des gleichen Controllers.
            Index zeigt die Liste aller Ausleihen an:
            public IActionResult Index()
{
    return View(_bibliothek.Ausleihen);
}
👉 Ergebnis:
Der Benutzer sieht sofort die aktualisierte Liste mit der neuen Ausleihe.*/
        }


        // Rückgabe durchführen [HttpPost]
        public IActionResult Return(int ausleiheId)
        {
            var ausleihe = _bibliothek.Ausleihen.FirstOrDefault(a => a.Id == ausleiheId); 
            if (ausleihe == null) 
               return BadRequest("Ausleihe nicht gefunden");
               ausleihe.beendeAusleihe();
               return RedirectToAction("Index");
        }

    }

}
