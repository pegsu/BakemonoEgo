# BakemonoEgo

## Eine interaktive .NET MAUI App fuer Windows

### Ueber mein Projekt: BakemonoEgo

BakemonoEgo ist eine Fusion aus Persoenlichkeitstest und Text Based Adventure. 
Inspiriert wurde das Thema des Projekts, wie der Titel schon verraet, von Bakemono. 
Bakemono sind Gestalten aus dem japanischen Volksglauben. Es handelt sich hierbei um uebernatuerliche Wesen, spezifischer um Gestaltenwandler.
Meist handelt es sich um Tiergeister, die ihre Gestalt veraendern koennen. Es kann sich aber auch um belebte Objekte handeln. Fuer mein Projekt habe ich mich auf die Tiere konzentriert.
In der App beantwortet der User ueber mehrere interaktive Seiten Fragen. Am Ende des Programms bekommt er/sie ein individuell zugeschnittenes Ergebnis, welches auf den gegebenen Antworten basiert.
Dachs, Vogel, Katze, Hund, Fuchs und Waschbaer sind die sechs moeglichen Persoenlichkeitstypen, die man als Ergebnis bekommen kann.

Inspiriert wurde ich von [IseeJ auf GitHub](https://iseej.github.io/Card/) und deren Projekt [CosmosPersona](https://iseej.github.io/CosmosPersona/), welches in JavaScript umgesetzt wurde. 

Gecoded habe ich mein Programm in Visual Studio 2022 als .NET MAUI App. 
Obwohl .NET MAUI plattformuebergreifend ist, habe ich mich aufgrund der Kuerze der Zeit dazu entschlossen, eine reine Windows App mit entsprechender Benutzteroberflaeche zu gestalten.


### Projektplanung, Recherche und Umsetzung

Begonnen hat das Projekt mit Brainstorming an Tag 1. Fuer die Praesentation meiner Projektidee habe ich ein Moodboard erstellt, welches meine Inspirationen und Ideen darstellt.

![Moodboard von BakemonoEgo](https://github.com/pegsu/BakemonoEgo/blob/main/BakemonoEgo/Resources/Images/bemoodboard.png)

Mein Dozent empfahl mir .NET MAUI, weshalb ich mich fuer dieses Framework entschieden habe. Nach Zulassung des Projekts begann ich mit der Recherche. 
**Schluesselfragen die ich mir gestellt habe waren:**

Was ist .NET MAUI?
Was ist XAML?
Wie sieht die Projektstruktur in .NET MAUI aus?
Wie funktioniert das Erstellen APP mit .NET MAUI?
Was sind Steuerelemente und Layouts in .NET MAUI?
Warum wird XAML und C# verwendet?
Wie funktioniert die Ereignisbehandlung in .NET MAUI mit XAML und der CodeBehind Datei in C#?
Was sind Content-Pages?
Wie style ich in .NET MAUI?

**Weitere tiefgehende Fragen, mit denen ich mich aufgrund meiner Projektstruktur befassen musste, waren:**

Was sind XAML-Namespaces?
Wie registriere ich eine Route?

Allerdings habe ich diese Thematik nur sehr oberflaechlich angeschnitten und nur grob verstanden.

Am zweiten Tag meines Projekts habe ich die Kurse [Erstellen Sie mobile und Desktop-Anwendungen mit .NET MAUI](https://learn.microsoft.com/de-de/training/paths/build-apps-with-dotnet-maui/) und [Erstellen Sie eine Benutzeroberflaeche in einer .NET MAUI-Anwendung mithilfe von XAML](https://learn.microsoft.com/de-de/training/modules/create-user-interface-xaml/) absolviert. Ausserdem habe ich den Videokurs [.NET MAUI for Beginners](https://www.youtube.com/playlist?list=PLdo4fOcmZ0oUBAdL2NwBpDs32zwGqb9DY) von dotnet durchgearbeitet. Zusaetzlich habe ich ein Git Repository angelegt, allerdings kam es bei git add . zu einem Error.

An Tag drei habe ich mit Hilfe eines Dozenten das Git Problem loesen koennen. Nach einigem Hin und Her stellte es sich heraus, dass lediglich meine Windows PowerShell Version veraltet war und geupdated werden musste. Im Anschluss gingen saemtliche adds, commits und pushes problemlos. Im Anschluss habe ich hauptsaechlich die Projektstruktur untersucht und versucht die Zusammenhaenge der verschiedenen Dateien zu verstehen. 

Am vierten Tag begann ich mit dem eigentlichen coden. Ich habe die Content-Pages meines Programs angelegt. Alle Seiten der App, mit Aussnahme der Main-Page, sind in einem Ordner namens "Views" zu finden. Dann habe ich in der Datei AppShell.xaml den Namespace `xmlns:views="clr-namespace:BakemonoEgo.Views"` erstellt und in der Datei AppShell.xmal.cs die entsprechenden Routes der Content-Pages registriert. Fuer diesen kompletten Schritt habe ich das Tutorial [Building Apps with XAML and .NET MAUI: Navigate Between Screens](https://learn.microsoft.com/en-us/shows/building-apps-with-xaml-and-dotnet-maui/navigate-between-screens-building-apps-with-xaml-and-dotnet-maui) befolgt.

Nachdem ich am vierten Tag die Content-Pages angelegt hatte, begann ich am fuenften Tag die Seiten mit Informationen zu befuellen. Neben der Main Page gibt es insgesamt neun "Question-Seiten" und sechs antwortabhaengige "Result-Seiten". Am fuenften Tag begann ich ausserdem mit dem programmieren der Count-Logik, die ich fuer die Auswertung der Fragen benoetige. Ich habe die Auswertung folgendermassen geloest:

Zuerst habe ich eine public static Klasse mit dem Namen "CountTracking" angelegt. In dieser wird eine Property public static int namens MyCount angelegt, welche mit get; und set; Werte ausliest und anpasst.
Im Anschluss habe ich eine Klasse mit dem Namen "Result" angelegt. In dieser befindet sich die Kern-Logik fuer die Auswahl der Benutzerdefinierten Resultate. Die Variable int count = CountTracking.MyCount nimmt den Zaehlwert an, der in CountTracking gespeichert wird.
Dann wird je nach Wert von Count entschieden, welches der if / else if / else statements ausgefuehrt wird.
Fuer count <= 10 ist das Resultat "Bird", fuer <= 20 ist es "Cat", fuer <= 30 ist es "Dog", fuer <= 40 ist es "Racoon", fuer <= 50 ist es "Fox" und fuer alles >= 51 ist es "Badger".

Ein groesseres Problem auf das ich gestossen bin war, dass ich nicht genau wusste, wie man auf einzelne Buttons bzw. Elemente zugreift. Dadurch hat count immer 0 ergeben, da keine Werte uebermittelt wurden, wodurch das Resultat immer "Bird" ergeben hat.
Ein Dozent hat mir am sechsten Tag des Projektes damit geholfen. Die Button Elemente habe ich bereits im Voraus mit xName="" A1 bis A6 genannt.

```ruby
if ((sender as Button).FindByName("A1")) / Der erste Loesungsansatz meines Dozentes /
 {
     CountTracking.MyCount += 1;
     await Shell.Current.GoToAsync(nameof(Views.Question2));
 }
 else if (sender is Button A2) / Mein erster Loesungsansatz /
 {
     CountTracking.MyCount += 2;
     await Shell.Current.GoToAsync(nameof(Views.Question2));
 }
 else if (sender is Button A3)
 {
     CountTracking.MyCount += 3;
     await Shell.Current.GoToAsync(nameof(Views.Question2));
 }
 else if (sender is Button A4)
 {
     CountTracking.MyCount += 4;
     await Shell.Current.GoToAsync(nameof(Views.Question2));
 }
 else if (sender is Button A5)
 {
     CountTracking.MyCount += 5;
     await Shell.Current.GoToAsync(nameof(Views.Question2));
 }
 else
 {
     await Shell.Current.GoToAsync(nameof(Views.ResultError));
 }
```

Es stellte sich heraus, dass es wesentlich einfacher war, als erwartet:

```ruby
if( (sender as Button)  == A1) //Fox, Racoon
{
    CountTracking.MyCount += 5;
    await Shell.Current.GoToAsync(nameof(Views.Question2));
}
else if((sender as Button) == A2) //Cat
{
    CountTracking.MyCount += 2;
    await Shell.Current.GoToAsync(nameof(Views.Question2));
}
else if ((sender as Button) == A3) //Dog
{
    CountTracking.MyCount += 3;
    await Shell.Current.GoToAsync(nameof(Views.Question2));
}
else if ((sender as Button) == A4) //Bird
{
    CountTracking.MyCount += 0;
    await Shell.Current.GoToAsync(nameof(Views.Question2));
}
else if ((sender as Button) == A5)
{
    CountTracking.MyCount += 10; //Badger
    await Shell.Current.GoToAsync(nameof(Views.Question2));
}
else
{
    await Shell.Current.GoToAsync(nameof(Views.ResultError));
}
```

Es war also ganz einfach mit den Operatoren == und as zu loesen.

Die restliche Zeit des sechsten Tages habe ich zum stylen der Benutzeroberflaeche genutzt. Die Standart-Benutzeroberflaeche der Main-Page in .NET MAUI sieht folgendermassen aus:

![Standart .NET MAUI UI](https://github.com/pegsu/BakemonoEgo/blob/main/ReadMeAssets/mainpagestandard.png)

Nach meinem Styling sah die Main Page so aus:

![BakemonoEgo Main Page](https://github.com/pegsu/BakemonoEgo/blob/main/ReadMeAssets/bakemonomainpage.png)

Und die "Question-Seiten" wie folgt:

![BakemonoEgo Question Page](https://github.com/pegsu/BakemonoEgo/blob/main/ReadMeAssets/bakemonoquestionpage.png)



### Was ich in Zukunft anders machen wuerde:

Das anlegen aller Content-Seiten zu Beginn des Projekts hat sich als grosse Huerde fuer das spaetere Coden herausgestellt.
Ich habe damit angefangen, da es fuer mich relativ simpel erschien. Was ich allerdings nicht bedacht hatte war, dass ich die Logik immer wieder ueber alle Seiten hinweg testen musste.
Erst als ein Dozent mir am sechsten Tag der Projektwoche erklaerte, was Breakpoints sind und wie man sie benutzt, konnte ich gezielt debuggen.
Was ich zukuenftig machen wuerde ware zu Beginn eine einzige Question-Seite und mehrere Result-Seiten zu erstellen. Dadurch ware es wesentlich eifnacher zu testen, ob die count-Variable richtig aktualisiert wird und ob die Daten passend uebergeben werden.
Ausserdem koennte ich die Layouts und die seitenspezifischen einfach kopieren und in den folgenden Seiten einfuegen ohne jedes einzelne Element auf jeder Seite immer wieder durchgehen zu muessen. 
Das haette mir wahnsinnig viel Zeit gespart.

### Weitere Quellen, die ich genutzt habe:
1. [Die .NET MAUI Dokumentation](https://learn.microsoft.com/de-de/dotnet/maui/?view=net-maui-9.0)
2. [Die offizielle Seite von .NET MAUI](https://dotnet.microsoft.com/en-us/apps/maui?WT.mc_id=friends-0000-jamont)
3. [Microsoft Learn .NET MAUI](https://learn.microsoft.com/de-de/training/paths/build-apps-with-dotnet-maui/)
4. [Die Serie"Building Apps with XAML and .NET MAUI"](https://learn.microsoft.com/en-us/shows/building-apps-with-xaml-and-dotnet-maui/)
5. [Learn .NET MAUI - Full Course for Beginners von James Montemagno auf Youtube](https://www.youtube.com/watch?v=DuNLR_NJv8U&t=2842s)
6. [Reusable Styles in your app von dotnet auf Youtube](https://www.youtube.com/watch?v=gl9--LlIeyg)
7. [Customizing Borders & corners von dotnet auf Youtube](https://www.youtube.com/watch?v=Qp9_FNS24DU&t=31s)
8. [Grobe Information zu Bakemono auf Wikipedia](https://de.wikipedia.org/wiki/Obake)