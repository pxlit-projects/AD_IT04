<!DOCTYPE html>
<html>
    <head>
	<title>Vragenlijst</title>
	<meta charset="UTF-8" />
		<meta charset="UTF-8" />
	<link rel="stylesheet" type="text/css" href="opmaak.css" />

<script>

var antwoorden = new Array();
var vraag = 1;
var aantalvragen=  50;

function drawslider(maximum, deel){
	console.log(maximum + " , " + deel);
	var percent=Math.round((deel*100)/maximum);
	document.getElementById("sliderbar").style.width=percent+'%';
	document.getElementById("percent").innerHTML=percent+'%';
}

function toon(antwoord){
	antwoorden[vraag] = {main: antwoord};
	var element2 = document.getElementById('volgende');
	if (document.getElementById('vraag') && !document.getElementById('butja') && !document.getElementById('butnee')) {
		var para = document.createElement('p');
		var node = document.createTextNode('Wilt u hulp?');
		para.appendChild(node);
		var buttonja= document.createElement('input');
		buttonja.setAttribute('type','button');
		buttonja.setAttribute('name','ja');
		buttonja.setAttribute('value','ja');
		buttonja.setAttribute('id','butja');
		var buttonnee= document.createElement('input');
		buttonnee.setAttribute('type','button');
		buttonnee.setAttribute('name','nee');
		buttonnee.setAttribute('value','nee');
		buttonnee.setAttribute('id','butnee');
		var element = document.getElementById('vraag');
		element.appendChild(para);
		element.appendChild(buttonja);
		element.appendChild(buttonnee);
		element2.disabled = true;
		controleer();
	} else {
		element2.disabled = true;
	}
}

function verberg(antwoord){
	antwoorden[vraag] = {main: antwoord};
	var element = document.getElementById('volgende');
	if (document.getElementById('butja') && document.getElementById('butnee')) {
		document.getElementById('vraag').innerHTML = "";
		element.disabled = false;
	}
	else{
		element.disabled = false;
	}
}

function controleer(){
	document.getElementById('butja').onclick = enable;
	document.getElementById('butnee').onclick = enable;

}

function enable(e){
	if(e.target.id == "butja" ){
		antwoorden[vraag].hinder = true;
	}else{
		
		antwoorden[vraag].hinder = false;
	}
	var element = document.getElementById('volgende');
	element.disabled = false;
	element.onclick = next;
	element=  document.getElementById('terug');
	element.onclick = back;
}

function next(){
	console.log(antwoorden[vraag]);
	if(vraag <= aantalvragen){
		vraag += 1;
		drawslider(aantalvragen,vraag-1);
		document.getElementById('volgende').disabled = true;
		document.getElementById('terug').disabled = false;
		document.getElementById('vraag').innerHTML = "";
	}else{
	
		document.getElementById('volgende').disabled = true;
	}
}
function back(){
	console.log(antwoorden[vraag]);
	if( vraag > 1 && vraag <= aantalvragen){
		vraag -= 1;
		drawslider(aantalvragen,vraag-1);
		document.getElementById('vraag').innerHTML = "";
		if(vraag == 1){
			document.getElementById('terug').disabled = true;
		}
	}else{
		document.getElementById('terug').disabled = true;
	}
}
function test(){
	for( i = 0; i < aantalvragen; i++){
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
	<form>
	     <input type="button" value = "Verloopt naar wensen" id="eersteknop" onClick="verberg(1)">
		 <input type="button" value = "Niet hinderlijk" onClick="verberg(2)">
		 <input type="button" value = "Hinderlijk (voor patiënt)" onClick="toon(3)">
		 <input type="button" value = "Hinderlijk (voor mantelzorger)" onClick="toon(4)">
		 <input type="button" value = "Hinderlijk (voor beide)" onClick="toon(5)">
		 <p id="vraag"></p>
		 <input type="button" value = "Vorige vraag" id="terug" onclick='back()' disabled>
		 <input type="button" value = "Volgende vraag" id="volgende" onclick='next()' disabled>
	</form>
    </body>
</html>
