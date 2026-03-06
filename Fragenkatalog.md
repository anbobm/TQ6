* In welche zwei Kategorien lassen sich Anforderungen unterteilen? Nenne je ein Beispiel.
    * Funktionale Anforderungen: z.B. Benutzer können sich mit Benutzername und Passwort anmelden
    * Nichtfunktionale Anforderungen: z.B. es können mindestens 10.000 Benutzer gleichzeitig angemeldet sein, ohne dass das System überlastet wird

* Was sind Kriterien zur Formulierung von Anforderungen?
    * Korrektheit
    * Eindeutigkeit
    * Prüfbarkeit
    * Nachverfolgbarkeit

* Was ist das Lastenheft?
    * Ein Katalog von Anforderungen: WAS soll entwickelt werden?

* Was ist das Pflichtenheft:
    * Ein Konzept, diese Anforderungen umzusetzen: WIE und WOMIT soll es entwickelt werden?

* Nenne 2 Diagrammtypen, die in der Entwurfsphase zum Einsatz kommen können:
    * Struktogramm
    * Programmablaufplan
    * UML-Klassendiagramm
    * Entity-Relationship-Model

* Was versteht man unter Deployment?
    * Auslieferung der Software: Bereitstellung/Installation/Konfiguration

* Welches Schlüsselwort braucht man in C#, wenn man einen Block von Anweisungen nur unter einer bestimmten Bedingung ausführen will.
    * if

* Welches Schlüsselwort folgt nach einem if-Block, um einen Block von Anweisungen nur dann auszuführen, wenn der vorhergehende if-Block NICHT ausgeführt worden ist?
    * else

* Nenne 3 Schleifenarten in C#:
    * while
    * for
    * foreach

* Was ist der Unterschied zwischen float und double?
    * double ist doppelt so genau wie float
    * double hat 64 bit, float nur 32 bit

* In welcher Richtung kann ich Typen umwandeln, ohne es explizit angeben zu müssen, long nach int oder int nach long?
    * int nach long

* Warum muss ich es in der anderen Richtung explizit angeben?
    * Weil der long-Wert nicht in den Wertebereich von int passt: 64 bit -> 32 bit, es gehen gegebenenfalls höherwertige Bits verloren.

* Was ist der unterschied zwischen einer statischen und einer dynamischen Webseite?
    * Statische Webseite: Der Server liefert fertige HTML-Dateien aus. Inhalt ändert sich nur, wenn die Datei manuell geändert wird.
    * Dynamische Webseite: Inhalte werden beim Aufruf durch serverseitige Skripte/Anwendungen (PHP, Node.js, ASP.NET Core, ...) generiert

* Frage: Wie funktioniert eine typische Client-Server-Kommunikation im Web?
    * Browser sendet eine Anfrage an den Server
    * Server verarbeitet die Anfrage (z. B. Script + Datenbank)
    * Server sendet eine Antwort zurück
    * Browser rendert HTML/CSS/JS

* Was ist HTTP?
    * Ein Protokoll, das für die Client-Server-Kommunikation im Web zum Einsatz kommt.

* Nenne die zwei häufigsten HTTP-Methoden.
    * GET
    * POST

* Was ist der Unterschied zwischen HTTP und HTTPS?
    * HTTP: unverschlüsselt
    * HTTPS: verschlüsselt

* Wofür wird HTML verwendet?
    * HTML (HyperText Markup Language) strukturiert Inhalte einer Webseite.

* Nenne 3 Beispiele für Inhalte:
    * Überschriften, Texte, Bilder, Links, Formulare

* Was ist CSS (Cascading Style Sheets)?
    * bestimmt das Layout und Design einer Webseite: Farben, Abstände, Schriftarten, ...

* Wofür wird JavaScrip im Browser eingesetzt?
    * Interaktive Webseiten: Der Inhalt der Webseite kann auf Nutzereingaben reagieren, ohne dass die komplette Seite neugeladen werden muss

* Was macht ein ORM (Object Relational Mapper) und nenne ein Beispiel:
    * ORM übersetzt zwischen Tabellen einer relationalen Datenbank und den Objekten einer objektorientierten Programmiersprache
    * z.B.: EntityFramework

* Wie kann man die Ladezeiten einer Webanwendung verringern?
    * Caching
    * Komprimierung
    * Datenbank optimieren