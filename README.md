# AD_IT04
AppDev repo voor AD_IT04

## Groepsleden
Michael Voorjans

Dieter Tuerlinckx

Kristof Spaas

Jeffrey Bosmans

Lander Ghekiere

## Projecten:

## Backend (WebAPI):

### Beschrijving:
De Backend is een Asp.net WebAPI project. Dit project is gemaakt in Visual Studio. De WebAPI heeft connectie met de database en verleend deze aan de andere projecten. Deze database bevat vragenlijsten, vragen, antwoorden, rapporten, patiënten, mantelzorgers, dokters, onderzoekers en alle accounts en rollen die nodig zijn voor een vlotte werking. 

### Instructies:
Het project importeren in Visual Studio.

## MVC Client:

### Beschrijving:
De MVC Client zit in hetzelfde project als de WebAPI. Deze client geeft de admin, dokters, patiënten, mantelzorgers en onderzoekers een manier om in te loggen en hun data te bekijken en te manipuleren.
De admin kan dokters en onderzoekers toevoegen, verwijderen of wijzigen.
De dokter kan patiënten, mantelzorgers en vragenlijsten toevoegen, verwijderen of wijzigen, vragenlijsten versturen, vragenlijsten herhalen en de rapporten bekijken en deze lokaal opslaan.
De patiënt en de mantelzorger kunnen hun eigen rapporten bekijken en lokaal opslaan.
De onderzoeker kan alle rapporten bekijken en deze lokaal opslaan. Hier worden echter de namen van de patiënten en mantelzorgers niet getoond.
Alle accounts hebben de mogelijkheid om hun wachtwoord te veranderen.

### Instructies:
Via volgende link kom je uit op de MVC Client:

http://finahweb.azurewebsites.net/

Hier kan je inloggen met:

(Wachtwoord voor alle accounts: P@ssw0rd)

admin-account: admin@gmail.com

dokter-account: jan.schoefs@gmail.com

patiënt-acount: kristof.spaas@gmail.com

mantelzorger-account: 11307308@student.pxl.be

onderzoeker-account: jef.peeters@gmail.com

### Screenshots:
zie map afbeeldingen/mvc webclient


## Desktop (Java):

### Beschrijving:
De desktop client in Java voor met de Backend to communiceren. Dit project is gemaakt in Eclipse. Met de desktop client kan 
er een overzicht weergeven worden van alle rapporten van de patiënten en mantelzorgers. Er kunnen hiermee ook patiënten en mantelzorgers worden toegevoegd en nieuwe vragenlijsten worden gemaakt.

### Instructies:
1.Project importeren in Eclipse
2.Test.java runnen voor het project uit te voeren

### Screenshots:

Inloggen:

![Image of inloggen]
(/afbeeldingen/desktopclientJava/login.JPG)

Patiënt toevoegen:

![Image of toevoegen]
(/afbeeldingen/desktopclientJava/patienttoevoegen.JPG)

Vragenlijst aanmaken:

![Image of aanmaken]
(/afbeeldingen/desktopclientJava/vragenlijsttoevoegen.JPG)

## Desktop (C#):

### Beschrijving:
De desktop client in C# voor met de Backend to communiceren.  Dit project is gemaakt in Eclipse. Met de desktop client kan 
er een overzicht weergeven worden van alle rapporten van de patiënten en mantelzorgers. Er kunnen hiermee ook patiënten en mantelzorgers worden toegevoegd en nieuwe vragenlijsten worden gemaakt. De dokter kan vragenlijsten versturen naar patiënten en mantelzorgers.

### Instructies:
open het project in Visual Studio
druk op "Start"

### Screenshots:

Inloggen:

![Image of inloggen]
(/afbeeldingen/desktopClientC#/inlog.JPG)

Patiënt toevoegen:

![Image of toevoegen]
(/afbeeldingen/desktopClientC#/patient_toevoegen.JPG)

Vragenlijst aanmaken:

![Image of aanmaken]
(/afbeeldingen/desktopClientC#/vragenlijst_aanmaken.JPG)

## Webclient:

### Beschrijving:
De client die bereikbaar is via een webbrowser (heeft een http server met php mogelijkheid nodig). Met de webclient kunnen de patiënten en mantelzorgers de vragenlijst invullen & doorsturen naar de backend.

### Instructies:
Volgende link is een voorbeeld-link die een patiënt via mail kan aankrijgen:

http://webclientfinah.azurewebsites.net/?verzorger=false&rapportId=83&vragenlijstId=17

### Screenshots:

Beginpagina:

![Image of beginpagina]
(/afbeeldingen/webclient/begin_vragenlijst.jpg)

Vragenlijst:

![Image of vragenlijst]
(/afbeeldingen/webclient/vragenlijst.jpg)

Eindpagina:

![Image of eindpagina]
(/afbeeldingen/webclient/einde_vragenlijst.jpg)
