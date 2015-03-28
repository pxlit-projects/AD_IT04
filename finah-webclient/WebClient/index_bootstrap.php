<!DOCTYPE html>

<?php
$vragenlijst_Id = @$_GET['vragenlijstId'];
$verzorger = @$_GET['verzorger'];
$rapport_Id = @$_GET['rapportId'];
?>

<html>
    <head>
        <title>Welkom</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" type="text/css" href="opmaak.css"/>
    </head>
    <body>

        <div id="welkomtekst">
            <div><h2>Welkom bij je finah-vragenlijst.</h2></div>
            </br>
            <div>
                <h3>
                    Gelieve je browser niet te sluiten tot de vragenlijst voltooid is.
                    </br>
                    </br>
                    Druk op start om te beginnen.
                </h3>
            </div>
        </div>

        <form id="startForm" action="vragenlijst_bootstrap.php" method="POST">
            <input type="hidden" name="vragenlijstId" value="<?php echo $vragenlijst_Id ?>" >
            <input type="hidden" name="verzorger" value="<?php echo $verzorger ?>" >
            <input type="hidden" name="rapportId" value="<?php echo $rapport_Id ?>" >
            <input type="submit" id="buttonStart" value="Start">
        </form>

    </body>
</html>
