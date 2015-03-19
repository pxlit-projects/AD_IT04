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

<script>
var vragen = JSON.parse('<?php echo json_encode($vragen) ?>');
var verzorger = <?php echo json_encode($verzorger) ?>;
var rapport_Id = <?php echo json_encode($rapport_Id) ?>;
var aantalvragen = vragen.length;
var antwoorden = new Array();
var vraag = 1;

window.onload = function (){
	document.getElementById('vraag').innerHTML = vragen[0].Beschrijving;
};

function drawslider(maximum, deel){
	console.log(maximum + " , " + deel);
	var percent = Math.round((deel * 100) / maximum);
	document.getElementById("sliderbar").style.width = percent + '%';
	document.getElementById("percent").innerHTML = percent + '%';
}

function toon(antwoord){
	antwoorden[vraag] = {Vraag_Id: vragen[vraag - 1].Id, Rapport_Id: rapport_Id, 
		AntwoordInt: antwoord, Verzorger: verzorger};

	var para = document.createElement('p');
	para.setAttribute('id', 'extraVraag');
	var node = document.createTextNode('Wil u hier iets aan doen?');
	para.appendChild(node);
	var buttonja = document.createElement('input');
	buttonja.type = 'button';
	buttonja.name = 'ja';
	buttonja.value = 'ja';
	buttonja.id = 'butja';
	var buttonnee = document.createElement('input');
	buttonnee.type = 'button';
	buttonnee.name = 'nee';
	buttonnee.value = 'nee';
	buttonnee.id = 'butnee';
	var element = document.getElementById('antwoordButtons');
	element.appendChild(para);
	element.appendChild(buttonja);
	element.appendChild(buttonnee);
	controleer();
}

function positiefAntwoord(antwoord){
	antwoorden[vraag] = {Vraag_Id: vragen[vraag - 1].Id, Rapport_Id: rapport_Id,
		AntwoordInt: antwoord, AntwoordExtra: 0, Verzorger: verzorger};

	if (vraag <= aantalvragen){
		document.getElementById('volgende').disabled = false;
	}
}

function controleer(){
	document.getElementById('butja').onclick = enable;
	document.getElementById('butnee').onclick = enable;
}

function enable(e){
	if (e.target.id === "butja"){
		antwoorden[vraag].AntwoordExtra = 2;
	} else {
		antwoorden[vraag].AntwoordExtra = 1;
	}
	if (vraag <= aantalvragen){
		var element = document.getElementById('volgende');
		element.disabled = false;
	}
}

function next(){
	console.log(antwoorden);
	document.getElementById('volgende').disabled = true;

	if (vraag < aantalvragen){
		vraag += 1;
		drawslider(aantalvragen, vraag - 1);
		document.getElementById('terug').disabled = false;
		document.getElementById('vraag').innerHTML = vragen[vraag - 1].Beschrijving;

		if (document.getElementById('butja')){
			var parent = document.getElementById('antwoordButtons');
			var extraVraag = document.getElementById('extraVraag');
			var butja = document.getElementById('butja');
			var butnee = document.getElementById('butnee');
			parent.removeChild(extraVraag);
			parent.removeChild(butja);
			parent.removeChild(butnee);
		}
	} else {
		drawslider(aantalvragen, vraag);
		var parent = document.getElementById('volgendeVorigeButtons');
		var volgendebutton = document.getElementById('volgende');
		parent.removeChild(volgendebutton);
	}
}

function back(){
	console.log(antwoorden);
	if (vraag > 1){
		vraag -= 1;
		drawslider(aantalvragen, vraag - 1);
		document.getElementById('vraag').innerHTML = vragen[vraag - 1].Beschrijving;

		if (document.getElementById('butja')){
			var parent = document.getElementById('antwoordButtons');
			var extraVraag = document.getElementById('extraVraag');
			var butja = document.getElementById('butja');
			var butnee = document.getElementById('butnee');
			parent.removeChild(extraVraag);
			parent.removeChild(butja);
			parent.removeChild(butnee);
		}

		if (vraag === 1){
			document.getElementById('terug').disabled = true;
		}
	} else {
		document.getElementById('terug').disabled = true;
	}
}

function test(){
	for (i = 0; i < aantalvragen; i++){
		vraag = 1;
		document.getElementById('#eersteknop').click();
		document.getElementById('volgende').click();
		console.log(antwoorden);
	}
}
</script>

</head>
<body onload="drawslider(50, 0);">
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
		<input type="button" id="button5"  value="Hinderlijk (voor mantelzorger)" onClick="toon(4)">
		<input type="button" id="button6"  value="Hinderlijk (voor beide)"        onClick="toon(5)">
	</div>

	<div id="volgendeVorigeButtons">
		<input type="button" id="terug"    value="Vorige vraag"    onclick='back()' disabled>
		<input type="button" id="volgende" value="Volgende vraag"  onclick='next()' disabled>
	</div>
</form>

<script>
// Method for converting the form's values to a json-object
// and putting this object back in the form
function getJson(){
	var jsonarray = "[";
	for (i = 1; i < antwoorden.length; i++){
		jsonarray += JSON.stringify(antwoorden[i]);
		if (i !== antwoorden.length - 1){
			jsonarray += ",";
		}
	}	
	jsonarray += "]";
	document.getElementById("json").value = jsonarray;
}
</script>

</body>
</html>
