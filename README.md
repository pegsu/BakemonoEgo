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

Mein Dozent empfahl mir .NET MAUI, weshalb ich mich fuer dieses Framework entschieden habe. Nach Zulassung des Projekts begann ich die Recherche. Schluesselfragen die ich mir gestellt habe waren:

Was ist .NET MAUI?
Was ist XAML?
Wie sieht die Projektstruktur in .NET MAUI aus?
Wie funktioniert das Erstellen APP mit .NET MAUI?
Was sind Steuerelemente und Layouts in .NET MAUI?
Warum wird XAML und C# verwendet?
Wie funktioniert die Ereignisbehandlung in .NET MAUI mit XAML und der CodeBehind Datei in C#?
Was sind Content-Pages?
Wie style ich in .NET MAUI?

Weitere tiefgehende Fragen, mit denen ich mich aufgrund meiner Projektstruktur befassen musste, waren:

Was sind XAML-Namespaces?
Wie registriere ich eine Route?

Allerdings habe ich diese Thematik nur sehr oberflaechlich angeschnitten und nur grob verstanden.

Am zweiten Tag meines Projekts habe ich die Kurse [Erstellen Sie mobile und Desktop-Anwendungen mit .NET MAUI](https://learn.microsoft.com/de-de/training/paths/build-apps-with-dotnet-maui/) und [Erstellen Sie eine Benutzeroberflaeche in einer .NET MAUI-Anwendung mithilfe von XAML](https://learn.microsoft.com/de-de/training/modules/create-user-interface-xaml/) absolviert. Ausserdem habe ich den Videokurs [.NET MAUI for Beginners](https://www.youtube.com/playlist?list=PLdo4fOcmZ0oUBAdL2NwBpDs32zwGqb9DY) von dotnet durchgearbeitet. Zusaetzlich habe ich ein Git Repository angelegt, allerdings kam es bei git add . zu einem Error.

An Tag drei habe ich mit Hilfe eines Dozenten das Git Problem loesen koennen. Nach einigem Hin und Her stellte es sich heraus, dass lediglich meine Windows PowerShell Version veraltet war und geupdated werden musste. Im Anschluss gingen saemtliche adds, commits und pushes problemlos. Im Anschluss habe ich hauptsaechlich die Projektstruktur untersucht und versucht die Zusammenhaenge der verschiedenen Dateien zu verstehen. 

Am vierten Tag begann ich mit dem eigentlichen coden. Ich habe die ersten Content-Pages meines Programs angelegt. Ich habe alle Seiten der App, mit Aussnahme der Main-Page, in einen Ordner namens "Views" gelegt. Dann habe ich in der Datei AppShell.xaml den Namespace `xmlns:views="clr-namespace:BakemonoEgo.Views"` erstellt und in der Datei AppShell.xmal.cs die entsprechenden Routes der Content-Pages registriert. 