byId = function (id) {
    return document.getElementById(id);
};

buttons = ['button1', 'button2', 'button3', 'button4',
    'button5', 'butja', 'butnee', 'vorige', 'volgende'];

function crashTest() {
    for (i = 0; i < 500; i++) {
        var random = Math.floor((Math.random() * 9));
        console.log(random);
        byId(buttons[random]).click();
    }
}

function testInvullenEnVersturen() {
    for (i = 0; i <= aantalvragen - 2; i++) {
        var random = Math.floor((Math.random() * 5));
        byId(buttons[random]).click();
        random = Math.floor((Math.random() * 2)) + 5;
        byId(buttons[random]).click();
        byId(buttons[8]).click();
    }
    var random = Math.floor((Math.random() * 5));
    byId(buttons[random]).click();
    random = Math.floor((Math.random() * 2)) + 5;
    byId(buttons[random]).click();
    byId('cmdbutton').click();
}
