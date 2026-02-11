# Aufgabe

Erstelle eine Page `/Login`. Wenn der Benutzer nicht eingeloggt ist, sieht er dort ein Formular, in dem er Benutzername und Passwort eintragen kann (hier: `method="post"`).

Nach dem Absenden wird dann mit `Response.Cookies.Append()` ein Cookie `username` auf den entsprechenden Benutzernamen gesetzt.

Wenn der Benutzer eingeloggt ist, also beim Aufrufen der Page bereits ein Cookie gesetzt war (`Request.Cookie[...]`), dann wird er auf derselben Page mit "Du bist als {username} eingeloggt" begrüßt.

Hinweis: Da wir für das Einloggen ein Formular mit der `POST` Methode benutzen, müssen wir diesen Request in der `OnPost(...)`-Methode abarbeiten, nicht in `OnGet(...)`.