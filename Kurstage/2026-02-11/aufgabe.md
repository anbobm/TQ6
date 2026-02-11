# Aufgabe

Lege auf einer Page ein Formular an, welches mit der `GET`-Methode eine Anfrage an die Page `ShowContact` schickt: `asp-page="/ShowContact"`.
In diesem Formular kann der Nutzer eine ID eines `Contact` eintragen.
Mit dieser ID kann die `ShowContact`-Page dann in einem lokalen Dictionary (was unsere Datenbank simuliert), den abgefragten Contact nachschlagen und dann anzeigen. Du kannst dieses Dictionary verwenden, aber auch gern weitere Einträge hinzufügen:

```csharp

    private Dictionary<int, Contact> contacts = new Dictionary<int, Contact>{
        {1, new Contact() {Name = "Max Mustermann", Email = "max@mustermann.com"}},
        {2, new Contact() {Name = "Petra Schuster", Email = "petraschuster@gmail.com"}},
        { 23, new Contact() {Name = "Foo Bar", Email = "foo.bar@einfallslos.org"}},
    };
```

Die Klasse `Contact` musst du noch anlegen.