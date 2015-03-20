function laad() {
                document.getElementById('vraag').innerHTML = vragen[0].Beschrijving;
            };

function drawslider(maximum, deel){
	console.log(maximum + " , " + deel);
	var percent = Math.round((deel * 100) / maximum);
	document.getElementById("sliderbar").style.width = percent + '%';
	document.getElementById("percent").innerHTML = percent + '%';
}

function toon(antwoord){
	try{
		var huidige = "button" + antwoord;
		huidige = document.getElementById(huidige);
		switchButtonColour(huidige);

		var vorige = antwoorden[vraag].AntwoordInt;
		vorige = "button" + vorige;
		vorige = document.getElementById(vorige);
		switchButtonColour(vorige);
	}catch(e){
	}
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
	try{
		var huidige = "button" + antwoord;
		huidige = document.getElementById(huidige);
		switchButtonColour(huidige);

		var vorige = antwoorden[vraag].AntwoordInt;
		vorige = "button" + vorige;
		vorige = document.getElementById(vorige);
		switchButtonColour(vorige);
	}catch(e){
	}
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
			var parentNode = document.getElementById('antwoordButtons');
			var extraVraag = document.getElementById('extraVraag');
			var butja = document.getElementById('butja');
			var butnee = document.getElementById('butnee');
			parentNode.removeChild(extraVraag);
			parentNode.removeChild(butja);
			parentNode.removeChild(butnee);
		}
	} else {
		drawslider(aantalvragen, vraag);
		var parentnode = document.getElementById('volgendeVorigeButtons');
		var volgendebutton = document.getElementById('volgende');
		parentno.removeChild(volgendebutton);
	}
}

function back(){
	console.log(antwoorden);
	if (vraag > 1){
		vraag -= 1;
		drawslider(aantalvragen, vraag - 1);
		document.getElementById('vraag').innerHTML = vragen[vraag - 1].Beschrijving;

		if (document.getElementById('butja')){
			var parentNode = document.getElementById('antwoordButtons');
			var extraVraag = document.getElementById('extraVraag');
			var butja = document.getElementById('butja');
			var butnee = document.getElementById('butnee');
			parentNode.removeChild(extraVraag);
			parentNode.removeChild(butja);
			parentNode.removeChild(butnee);
		}

		if (vraag === 1){
			document.getElementById('terug').disabled = true;
		}
	} else {
		document.getElementById('terug').disabled = true;
	}
}

function switchButtonColour(button){
	if(button !== null){
		try{
			var defaultcolor  = "rgb(227, 225, 184)";
			var selectedcolor = "rgb(163, 163, 152)";
			var kleur = button.style.backgroundColor;
			if(kleur == defaultcolor || kleur === ""){
				button.style.backgroundColor = selectedcolor;
			}else{
				button.style.backgroundColor = defaultcolor;
			}
		}catch(e){
			console.log(e);
		}
	}
}
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
