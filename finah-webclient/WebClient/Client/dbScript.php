<?php

// Checks if the request came from a delete or from an add button
if (@$_POST['cmdbutton'] == 'Voltooien') {
    // Gets the table and the json object from the form
    //and calls the add-method
    $tabel = @$_POST['tabel'];
    $json = @$_POST['json'];

    $arr = json_decode($json);
    foreach ($arr as $value) {
        add(json_encode($value), $tabel);
    }
} else if (@$_POST['cmdbutton'] == 'Delete') {
    // Gets the table and the ID from the form
    // and calls the delete-method
    $tabel = @$_POST['tabel'];
    $id = @$_POST['id'];
    delete($tabel, $id);
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

// Deletes an item from a table by using the $tabel and the $id variables we supplied through the form
function delete($tabel, $id) {
    $params = array('http' => array(
            'method' => 'DELETE',
            'content' => ""
    ));
    $url = 'http://finahweb.azurewebsites.net/api/' . $tabel . '/' . $id;
    $ctx = stream_context_create($params);
    $fp = fopen($url, 'rb', false, $ctx);

    fclose($fp);
}
