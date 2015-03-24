<!DOCTYPE html>

<?php
// request list of vragen from Web API by VragenlijstId
//$vragenlijst_Id = @$_GET['vragenlijstId'];
//$verzorger = @$_GET['verzorger'];
//$rapport_Id = @$_GET['rapportId'];

$vragenlijst_Id = 1;
$verzorger = true;
$rapport_Id = 3;

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

        <script>
            var vragen = JSON.parse('<?php echo json_encode($vragen) ?>');
            var verzorger = <?php echo json_encode($verzorger) ?>;
            var rapport_Id = <?php echo json_encode($rapport_Id) ?>;
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

        <div id="vraagBox">
            <h1><div id="vraag"></div></h1>
        </div>

        <div id="antwoordButtons">
            <button type="button" id="button1" onClick="positiefAntwoord(1)">Verloopt</br>naar wensen</button>
            <button type="button" style="margin-left: 25px" id="button2" onClick="positiefAntwoord(2)">Niet</br>hinderlijk</button>
            <button type="button" style="margin-left: 25px" id="button3" onClick="negatiefAntwoord(3)">Hinderlijk</br>(voor cliënt</button>
            <button type="button" style="margin-left: 25px" id="button4" onClick="negatiefAntwoord(4)">Hinderlijk</br>(voor mantelzorger)</button>
            <button type="button" style="margin-left: 25px" id="button5" onClick="negatiefAntwoord(5)">Hinderlijk</br>(voor beide)</button>
        </div>

        <div id="antwoordExtraDiv">
            <p id="extraVraag">&nbsp;&nbsp;Wilt u dat hieraan gewerkt wordt?</p>
            <button type="button" id="butja" onClick="saveAntwoordExtra('butja')">Ja</button>
            <button type="button" style="margin-left: 25px" id="butnee" onClick="saveAntwoordExtra('butnee')">Nee</button>
        </div>

        <div id="volgendeVorigeButtons">
            <button type="button" id="vorige"   value="Vorige vraag"    onclick='back()' disabled="true">Vorige</button>
            <button type="button" id="volgende" value="Volgende vraag"  onclick='next()' disabled="true">Volgende</button>
        </div>

        <form action="dbScript.php" method="POST" onsubmit="getJson()">
            <input type="hidden" name="tabel" value="antwoord"/>
            <input type="hidden" name="jsonArray" id="jsonArray"/>
            <input type="submit" name="cmdbutton" id="cmdbutton" value="Voltooien" />
        </form>

    </body>
</html>
