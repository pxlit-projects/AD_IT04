<!DOCTYPE html>

<?php
$vragenlijst_Id = @$_POST['vragenlijstId'];
$verzorger = @$_POST['verzorger'];
$rapport_Id = @$_POST['rapportId'];

// request list of vragen from Web API by VragenlijstId
$jsonVragen = file_get_contents('http://finahweb.azurewebsites.net/api/vraag/' . $vragenlijst_Id);

// deserialize data from JSON
$vragen = json_decode($jsonVragen);
?>

<html>
    <head>
        <title>Vragenlijst</title>
        <meta charset="UTF-8" />
        <link rel="stylesheet" type="text/css" href="opmaak.css" />
        <script src="script.js"></script>
        <script src="UnitTests.js"></script>

        <script>
            var vragen = JSON.parse('<?php echo json_encode($vragen) ?>');
            var verzorger = <?php echo json_encode($verzorger) ?>;
            var rapport_Id = <?php echo json_encode($rapport_Id) ?>;
            var vragenlijst_Id = <?php echo json_encode($vragenlijst_Id) ?>;
            var aantalvragen = vragen.length;
            var antwoorden = new Array();
            var vraag = 1;
        </script>

    </head>
    <body onload="drawslider(50, 0);
            laad();">
        <div id="slider">
            <div id="sliderbar"></div>
            <div id="percent"></div>
        </div>

        <div id="afbeeldingdiv"> 
            <img id="afbeelding"> </img>
        </div>

        <div id="vraagBox">
            <h2><div id="vraag"></div></h2>
        </div>

        <div id="antwoordButtons">
            <button type="button" id="button1" onClick="positiefAntwoord(1)">Verloopt</br>naar wensen</button>
            <button type="button" id="button2" onClick="positiefAntwoord(2)">Niet</br>hinderlijk</button>
            <button type="button" id="button3" onClick="negatiefAntwoord(3)">Hinderlijk</br>voor cliënt</button>
            <button type="button" id="button4" onClick="negatiefAntwoord(4)">Hinderlijk</br>voor mantelzorger</button>
            <button type="button" id="button5" onClick="negatiefAntwoord(5)">Hinderlijk</br>voor beide</button>
        </div>

        <div id="antwoordExtraDiv">
            <p id="extraVraag">&nbsp;&nbsp;Wilt u dat hieraan gewerkt wordt?</p>
            <button type="button" id="butja" onClick="saveAntwoordExtra('butja')">Ja</button>
            <button type="button" id="butnee" onClick="saveAntwoordExtra('butnee')">Nee</button>
        </div>

        <div id="volgendeVorigeVoltooiButtons">
            <button type="button" id="vorige"   onclick='back()' disabled="true">Vorige vraag</button>
            <button type="button" id="volgende" onclick='next()' disabled="true">Volgende vraag</button>
            <form action="dbScript.php" method="POST" onsubmit="getJson()" style="display: inline">
                <input type="hidden" name="tabel" value="antwoord"/>
                <input type="hidden" name="jsonArray" id="jsonArray"/>
                <input type="submit" name="cmdbutton" id="cmdbutton" value="Voltooien" />
            </form>
        </div>

        <div id="testButtons">
            <button type="button" id="testbutton1" onclick="crashTest()">Crash</br>test</br> </button>
            <button type="button" id="testbutton2" onclick="testInvullenEnVersturen()">Invullen</br>en versturen</button>
        </div>

    </body>
</html>
