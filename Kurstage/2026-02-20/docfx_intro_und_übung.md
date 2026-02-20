# Entwicklerdokumentation mit XML-Kommentaren und DocFX

## Warum?

Ein wichtiger Aspekt in der Softwareentwicklung ist die Dokumentation. Es gibt viele verschiedene Arten von Dokumentation, und eine davon ist die Entwicklerdokumentation. Sie dokumentiert die Schnittstellen, die öffentliche Typen, Klassen, und deren Properties und Methoden bereitstellen, für andere Entwickler - seien sie im gleichen Team, im gleichen Unternehmen, oder extern.

## Wie?

Eine Möglichkeit diese Schnittstellen zu dokumentieren ist es an öffentliche Klassen, öffentliche Methoden, etc. **XML-Kommentare** dranzuschreiben. Diese sind menschen- und maschinenlesbar und dienen dazu den Zweck und das Verhalten von Klassen/Methoden/etc. strukturiert zu beschreiben.

Diese XML-Kommentare sind aus Sicht des Compilers nichts besonderes, sie werden ignoriert wie ganz normale Kommentare. Sie werden statt mit `//` mit `///` eingeleitet.

Als Beispiel sei eine Klasse `Rectangle` gegeben. Es gibt je einen XML-Kommentar für die Klasse selbst, und einen für die öffentliche Methode `SetDimensions()`:

```c#
/// <summary>
/// Eine Klasse für Rechtecke.
/// </summary>
public class Rectangle
{
    ...

    /// <summary>
    /// Setzt Breite und Höhe des Rechtecks.
    /// </summary>
    /// <param name="width">Breite des Rechtecks</param>
    /// <param name="height">Höhe des Rechtecks</param>
    /// <exception cref="ArgumentException">Wirft
    /// ArgumentException wenn Höhe oder Breite kleiner
    /// als 0 sind.</exception>
    public void SetDimensions(int width, int height)
    {
        if (width < 0 || height < 0)
        {
            throw ArgumentException("Breite und Höhe müssen größer gleich 0 sein.")
        }

        ...
    }
}
```

In den XML-Kommentaren kann man also verschiedene Tags verwenden, wie z.B. `<summary>` für die Zusammenfassung, `<param>` zur Erklärung einzelner Parameter, und andere.

Wenn dann in der `.csproj` Projektdatei die Einstellung `<GenerateDocumentationFile>true</GenerateDocumentationFile>` gesetzt ist:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
  </PropertyGroup>

</Project>
```

dann wird beim `build`-Prozess eine `.xml`-Datei erstellt, in der all diese XML-Kommentare zusammengefasst sind.

Anschließend können Tools diese Datei auswerten. `docfx` kann daraus z.B. eine Webseite erstellen, die die Schnittstellen dokumentiert.

## Übung

### Projekt erstellen

#### Visual Studio

Erstelle ein neues `Console App` Projekt (in einer **neuen** Solution/Projektmappe) mit dem Namen `Bank`.

#### Visual Studio Code

Erstelle einen Ordner `Bank`. Öffne diesen Ordner in Visual Studio Code als Workspace (`File -> Open Folder...`).
Erstelle darin einen Ordner der auch `Bank` heißt. Führe in diesem Ordner, also in `Bank\Bank`, den Befehl `dotnet new console` aus.

### Verzeichnisstruktur

Eure Verzeichnisstruktur sollte jetzt so aussehen:

```
Bank/
│
├── Bank/
│   ├── Bank.csproj
│   ├── Bankkonto.cs
│   └── Program.cs
│
└── Bank.sln
```

### Bankkonto.cs anlegen

Erstelle in `Bank\Bank` `Bankkonto.cs` mit diesem Inhalt: https://github.com/anbobm/TQ6/blob/master/Kurstage/2026-02-20/Bankkonto.cs

Lege jetzt für alle Klassen und Methoden, die `public` sind, XML-Kommentare an (mindestens `summary` und `param` für alle Parameter, und `<returns>` falls die Methode einen Rückgabewert hat).

Das geht am einfachsten, wenn du vor der Klasse/Methode eine leere Zeile einfügst und `///` eingibst, dann fügt Visual Studio (Code) automatisch schon eine Vorlage ein, die du nur noch ausfüllen musst.

## Bank.csproj Datei bearbeiten

Füge der `Bank.csproj` Datei diese Zeile an der richtigen Stelle hinzu (vgl. oben):

```xml
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
```

Das sorgt dafür, dass aus den XML-Kommentaren beim bauen eine `Bank.xml`-Datei erstellt wird (in `Bank\bin\Debug\netXX.X`), die alle Kommentare enthält. Diese Datei wird später von `docfx` ausgewertet.

## Verzeichnisstruktur ändern 

Leg dir nun einen Ordner `docfx` neben deinem Projektordner an:

```
Bank/
│
├── Bank/
│   ├── Bank.csproj
│   ├── Bankkonto.cs
│   └── Program.cs
|
├── docfx
│
└── Bank.sln
```

In diesen Ordner `docfx` kommen nun alle Dateien die von `docfx` erstellt werden.

Falls noch nicht geschehen, **installiere dir das `docfx`-Tool** mit `dotnet tool install -g docfx`.

Navigiere in den `Bank\docfx` Ordner und führe darin aus: `docfx init`. Jetzt wirst du nach Einstellungen gefragt. Du kannst immer ENTER drücken (den Defaultwert akzeptieren), **außer bei `.NET projects location (src):`**, dort antworte mit `.`

Falls du dich vertan hast, lösche einfach alles innerhalb von `docfx` und mach's nochmal.

Anschließend führe aus:
* `docfx metadata`
* `docfx build` 
* `docfx serve _site`

Beim letzten Befehl startet ein lokaler Webserver, den ihr unter der Adresse erreicht, die in der Kommandozeile steht (wahrscheinlich `http://localhost:8080`).

Wenn ihr diese Adresse im Browser aufruft, seht ihr unter **API** alle Klassen, Methoden, usw. und ihre Kommentare.


 