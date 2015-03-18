<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<?php
// request list of vragen from Web API
$json = file_get_contents('http://localhost:63624/api/vraag/');
// deserialize data from JSON
$vragen = json_decode($json);

// request vraag by vraagId from Web API
$id = 3;
$json2 = file_get_contents('http://localhost:63624/api/vraag/' . $id);
// deserialize data from JSON
$vraagFromId = json_decode($json2);
?>
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <table>
            <?php
            foreach ($vragen as $vraag) {
                ?>
                <tr>
                    <td valign="top">
                        <?php echo $vraag->Beschrijving ?>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <?php
            }
            ?>
            <tr style="height: 10px"></tr>
            <tr>
                <td>
                    <span><strong>VraagFromId:</strong></span> <?php echo $vraagFromId->Beschrijving ?>
                </td>
            </tr>
        </table>
    </body>
</html>
