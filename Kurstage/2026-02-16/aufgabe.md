# Aufgabe BiboApp

## Razor Pages Projekt erstellen

### Visual Studio

Fügt der Projektmappe ein neues Projekt hinzu und wählt das `Razor Pages` Template aus.

### Visual Studio Code

Erstellt euch in einem leeren Ordner ein neues Razor Pages Projekt indem ihr innerhalb des Ordners auf der Kommandozeile `dotnet new razor` ausführt.

Anschließend könnt ihr dieses Projekt der `.sln` hinzufügen, indem ihr im Ordner wo die `.sln` liegt ausführt `dotnet solution add <PFAD ZUM RAZOR PAGES PROJEKT>`

## EF Core mit Sqlite installieren

Installiert in diesem Projekt anschließend EF Core für Sqlite mit `dotnet add package Microsoft.EntityFrameworkCore.Sqlite`.

## Klasse für Datenbankzugriff anlegen

Legt euch neben dem `Pages` Ordner einen Ordner `Database` an. In diesen kommen drei Klassen: `BiboContext.cs`, `Buch.cs` und `Nutzer.cs`.

Die `BiboContext` Klasse erbt von `DbContext` (aus dem Entity Framework). Sie ist unsere Verbindung in die Datenbank. Erstellt euch für die Tabellen `Nutzer` und `Bücher` jeweils eine `public` Property vom Typ `DbSet<Nutzer>` bzw. `DbSet<Buch>`. Mit diesen können wir anschließend auf die beiden Tabellen in der Datenbank zugreifen.

Außerdem kommt noch folgender Code in die `BiboContext` Klasse:

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlite("Data Source=bibo.db");
```

Das sorgt dafür, dass das Entity Framework Sqlite verwendet, und die Datenbank in der Datei `bibo.db` sucht.

## Klassen für Datensätze anlegen

Die Klasse `Buch` soll je eine `public` Property enthalten für die Attribute Id (int), Titel (string), Autor (string) und IsAusgeliehen (bool).

Die Klasse `Nutzer` soll enthalten: Id (int) und Email (string).

## Datenbank anlegen

Legt euch nun die `bibo.db` mit dem [SQLite Browser](https://sqlitebrowser.org) an und erstellt die zwei Tabellen Bücher und Nutzer. Die Spalten müssen genau heißen wie die Properties der zugehörigen Klassen. (Die Datentypen sind in SQLite wie folgt: 

| C# | SQLite|
|-----|------|
|`int` | `INTEGER`|
|`string` | `TEXT`|
|`bool` | `INTEGER`|

## Page `/ListBooks` anlegen

Legt euch eine Page `/ListBooks` an, die alle Bücher aus der Datenbank holt und auflistet.

Auf die Datenbank könnt ihr so zugreifen:

```csharp
void Foo()
{
    ...
    var db = new BiboContext();

    .... db.Bücher.ToList() ...
    ...
}
```

Um diese Page anschließend testen zu können, legt euch im DB Browser ein paar Datensätze in der Tabelle Bücher an.

## Page `/AddBook` anlegen

Legt euch eine Page `/AddBook` an. Diese bekommt ein Formular mit allen für den Buch-Typ benötigten Feldern.

Beim Absenden des Formulars (`method="post"`), soll in `OnPost(...)` ein neues Objekt vom Typ `Buch` erzeugt, und der Tabelle `Bücher` hinzugefügt werden (`.Add(..)`).

Um Änderungen in die Datenbank zu schreiben muss wenigstens am Schluss ein `db.SaveChanges()` erfolgen.

Wir wollen den Nutzer nach dem Absenden des Formulars auf die Startseite umleiten. Das gelingt indem wir `return RedirectToPage("/ListBooks");` zurückgeben. Dafür müssen wir auch den Rückgabe-Typ des `OnPost()..)`-Handlers von `void` nach `IActionResult` ändern.

## Page `/ShowBook` anlegen

Legt euch auf der Page `/ListBooks` zu jedem Buch das ihr anzeigt einen Link an, der auf die Page `/ShowBook` führt und den Parameter `id` im Querystring auf die ID des konkreten Buches setzt: `<a asp-page="/ShowBook" asp-route-id="..."> ...`

Die ID des Buches steht im Model.

Auf der Page `/ShowBook` sollen dann alle Felder des angeklickten Buches angezeigt werden.

## Datenbank erweitern

Füge der Tabelle Bücher eine weitere Spalte `AusleihenderId` hinzu, die ein Foreign Key auf `Id` der Tabelle `Nutzer` ist.

Dann füge der Klasse `Buch` eine Property `Ausleihender` hinzu vom Typ `Nutzer?`.  Füge der Klasse `Nutzer` eine Property `List<Buch> AusgelieheneBücher` hinzu.

Anschließend erweitert die `/ShowBook` Page so, dass, sofern das Buch ausgeliehen ist, der Ausleihende Benutzer mit angezeigt wird.

Um das zu testen, solltet ihr euch natürlich in der Datenbank auch Buch-Datensätze entsprechend vorbereiten, sodass manche ausgeliehen sind.

## Page `/ListUsers` und `/ShowUser` anlegen

Legt euch eine Page `/ListUsers` an, die analog zu `/ListBooks` alle Nutzer in der Datenbank auflistet.

Von dieser Page soll es wieder für jeden Nutzer einen Link auf eine `/ShowUser` Page geben, die dann für diesen Nutzer alle Eigenschaften anzeigt. Dort soll man auch eine Liste von ausgeliehenen Büchern sehen können.

## Hinweise

Folgende Dinge tun wir hier nur damit es simpel bleibt:

* Im Normalfall erstellt man im EF nicht Datenbank-Klassen **und** Datenbank manuell, sondern nur eines von beiden und lässt sich das andere daraus generieren. Das nennt sich dann `migrations`(Klassen -> DB) bzw. `scaffolding`(DB -> Klassen).
* Das Datenbankobjekt (`BiboContext`) erstellt man normalerweise nicht selbst, sondern bekommt es vom ASP.NET Core Framework im Konstruktor des Models übergeben. Man überlässt also dem Framework die Verwaltung und anschließende Entsorgung dieses Objekts.