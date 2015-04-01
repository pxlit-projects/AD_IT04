var images = new Array("figuren/1-01.jpg");
var preLoadedImage = "figuren/1-02.jpg";

function laad() {
    document.getElementById('vraag').innerHTML = vragen[0].Beschrijving;
    document.getElementById('afbeelding').src = images[0];
    document.getElementById('cmdbutton').style.display = "none";
}

function drawslider(maximum, deel) {
    percent = Math.round((deel * 100) / maximum);
    document.getElementById("sliderbar").style.width = percent + '%';
    document.getElementById("percent").innerHTML = ' Vraag ' + vraag + ' van ' + aantalvragen + ' (' + percent + '%)';
}

function positiefAntwoord(antwoord) {
    document.getElementById('antwoordExtraDiv').style.visibility = 'hidden';

    try {
        switchButtonColour();
        switchButtonExtraColour();
    } catch (e) {
        console.log(e);
    }

    antwoorden[vraag] = {Vraag_Id: vragen[vraag - 1].Id, Rapport_Id: rapport_Id,
        AntwoordInt: antwoord, AntwoordExtra: 0, Verzorger: verzorger};

    switchButtonColour();

    if (vraag <= aantalvragen) {
        document.getElementById('volgende').disabled = false;
        document.getElementById('cmdbutton').disabled = false;
    }
}

function negatiefAntwoord(antwoord) {
    document.getElementById('antwoordExtraDiv').style.visibility = 'visible';

    antwoordExtra = 0;

    if (antwoorden[vraag] !== undefined) {
        if (antwoorden[vraag].AntwoordInt !== antwoord) {
            document.getElementById('volgende').disabled = true;
            document.getElementById('cmdbutton').disabled = true;
            try {
                switchButtonExtraColour();
            }
            catch (e) {
                console.log(e);
            }
        } else {
            antwoordExtra = antwoorden[vraag].AntwoordExtra;
        }
    }

    try {
        switchButtonColour();
    } catch (e) {
        console.log(e);
    }

    antwoorden[vraag] = {Vraag_Id: vragen[vraag - 1].Id, Rapport_Id: rapport_Id,
        AntwoordInt: antwoord, AntwoordExtra: antwoordExtra, Verzorger: verzorger};

    switchButtonColour();
}

function saveAntwoordExtra(button) {
    try {
        switchButtonExtraColour();
    } catch (e) {
        console.log(e);
    }

    if (button === "butja") {
        antwoorden[vraag].AntwoordExtra = 1;
    } else {
        antwoorden[vraag].AntwoordExtra = 2;
    }

    switchButtonExtraColour();

    if (vraag <= aantalvragen) {
        document.getElementById('volgende').disabled = false;
        document.getElementById('cmdbutton').disabled = false;
    }
}

function setNextImage() {
    if (images.length >= vraag) {
        document.getElementById('afbeelding').src = images[vraag - 1];
    } else {
        document.getElementById('afbeelding').src = preLoadedImage;
        images[vraag - 1] = preLoadedImage;
        if (vraag < 9) {
            hulp = "0" + (vraag + 1);
        } else {
            hulp = vraag + 1;
        }
        preLoadedImage = "figuren/" + vragenlijst_Id + "-" + hulp + ".jpg";
    }
}

function setPreviousImage() {
    document.getElementById('afbeelding').src = images[vraag - 1];
}

function next() {
    console.log(antwoorden);

    document.getElementById('antwoordExtraDiv').style.visibility = 'hidden';

    switchButtonColour();
    switchButtonExtraColour();

    vraag += 1;
    drawslider(aantalvragen, vraag - 1);
    document.getElementById('vorige').disabled = false;
    document.getElementById('vraag').innerHTML = vragen[vraag - 1].Beschrijving;

    setNextImage();

    try {
        switchButtonColour();
    } catch (e) {
        document.getElementById('volgende').disabled = true;
        document.getElementById('cmdbutton').disabled = true;
    }

    if (antwoorden[vraag] !== undefined) {
        if (antwoorden[vraag].AntwoordInt !== 1 && antwoorden[vraag].AntwoordInt !== 2) {
            if (antwoorden[vraag].AntwoordExtra === 0) {
                document.getElementById('volgende').disabled = true;
            }
            document.getElementById('antwoordExtraDiv').style.visibility = 'visible';
            switchButtonExtraColour();
        }
    }

    if (vraag === aantalvragen) {
        document.getElementById('volgende').style.display = "none";
        document.getElementById('cmdbutton').style.display = "";
    }
}

function back() {
    console.log(antwoorden);

    document.getElementById('volgende').style.display = "";
    document.getElementById('cmdbutton').style.display = "none";

    try {
        switchButtonColour();
        switchButtonExtraColour();
    } catch (e) {
        console.log(e);
    }

    vraag -= 1;
    drawslider(aantalvragen, vraag - 1);
    document.getElementById('volgende').disabled = false;
    document.getElementById('vraag').innerHTML = vragen[vraag - 1].Beschrijving;

    setPreviousImage();

    if (antwoorden[vraag].AntwoordExtra !== 0) {
        document.getElementById('antwoordExtraDiv').style.visibility = 'visible';
        switchButtonExtraColour();
    } else {
        document.getElementById('antwoordExtraDiv').style.visibility = 'hidden';
    }

    if (vraag === 1) {
        document.getElementById('vorige').disabled = true;
    }

    switchButtonColour();
}

function switchButtonColour() {
    var buttonNumber = antwoorden[vraag].AntwoordInt;
    var buttonId = "button" + buttonNumber;
    var button = document.getElementById(buttonId);

    if (button !== null) {
        try {
            var border = button.style.border;

            if (border === "") {
                button.style.border = "4px solid";
            } else {
                button.style.border = "";
            }
        } catch (e) {
            console.log(e);
        }
    }
}

function switchButtonExtraColour() {
    var buttonId = "";
    if (antwoorden[vraag].AntwoordExtra === 1) {
        buttonId = "butja";
    } else if (antwoorden[vraag].AntwoordExtra === 2) {
        buttonId = "butnee";
    }

    var button = document.getElementById(buttonId);

    if (button !== null) {
        try {
            var border = button.style.border;

            if (border === "") {
                button.style.border = "4px solid";
            } else {
                button.style.border = "";
            }
        } catch (e) {
            console.log(e);
        }
    }
}

// Method for converting the form's values to a json-array
// and putting this array back in the form
function getJson() {
    drawslider(aantalvragen, vraag);

    var jsonarray = "[";

    for (i = 1; i < antwoorden.length; i++) {
        jsonarray += JSON.stringify(antwoorden[i]);
        if (i !== antwoorden.length - 1) {
            jsonarray += ",";
        }
    }

    jsonarray += "]";

    document.getElementById("jsonArray").value = jsonarray;
}
