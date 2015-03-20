<!DOCTYPE html>

<?php
// request list of vragen from Web API by VragenlijstId
$vragenlijst_Id = 3;
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
<script src="script.js"> </script>

<script>

var vragen = JSON.parse('<?php echo json_encode($vragen) ?>');
var verzorger = <?php echo json_encode($verzorger) ?>;
var rapport_Id = <?php echo json_encode($rapport_Id) ?>;
var aantalvragen = vragen.length;
var antwoorden = new Array();
var vraag = 1;

</script>

</head>
<body onload="drawslider(50, 0);laad();">
<div id="slider">
	<div id="sliderbar">
	</div>
	<div id="percent">
	</div>
</div>

<div id="vraagTabel">
	<h2><div id="vraag"></div></h2>
</div>

<form action="dbScript.php" method="POST" onsubmit="getJson()" style="text-align: center">
	<input type="hidden" name="tabel" value="antwoord"/>
	<input type="hidden" name="json" id="json"/>
	<input type="submit" name="cmdbutton" value="Voltooien" />
</form>

<form>
	<div id="antwoordButtons">
		<input type="button" id="button1"  value="Verloopt naar wensen"           onClick="positiefAntwoord(1)">
		<input type="button" id="button2"  value="Niet hinderlijk"                onClick="positiefAntwoord(2)">
		<input type="button" id="button3"  value="Hinderlijk (voor patiënt)"      onClick="toon(3)">
		<input type="button" id="button4"  value="Hinderlijk (voor mantelzorger)" onClick="toon(4)">
		<input type="button" id="button5"  value="Hinderlijk (voor beide)"        onClick="toon(5)">
	</div>

	<div id="volgendeVorigeButtons">
		<input type="button" id="terug"    value="Vorige vraag"    onclick='back()' disabled>
		<input type="button" id="volgende" value="Volgende vraag"  onclick='next()' disabled>
	</div>
</form>

</body>
</html>
