<?php

if (@$_POST['cmdbutton'] == 'Voltooien') {
    // Gets the table and the json array from the form
    //and calls the add-method for each json
    $tabel = @$_POST['tabel'];
    $jsonArray = @$_POST['jsonArray'];

    $arr = json_decode($jsonArray);

    foreach ($arr as $json) {
        add(json_encode($json), $tabel);
    }

    header('Location: ./vragenlijstVoltooid.html');
    exit;
}

// Adds an item to a table by using the $json and the $tabel variables we supplied through the form
function add($json, $tabel) {
    var_dump($json);

    $params = array('http' => array(
            'method' => 'POST',
            'header' => array(
                "Content-type: application/json"
            ),
            'content' => $json
    ));
    $url = 'http://finahweb.azurewebsites.net/api/' . $tabel;
    $ctx = stream_context_create($params);
    $fp = fopen($url, 'rb', false, $ctx);

    fclose($fp);
}
