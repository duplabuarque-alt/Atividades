<?php

$n1 = $_GET["n1"];

?>

<!DOCTYPE html>

<html lang="pt-br">

<head>

    <meta charset="UTF-8">

    <title>Resultado </title>

</head>

<body>

<h1>Resultado</h1>

<p>resultado: <?php
    if (($n1 % 400 == 0) or ($n1 % 4 == 0 and $n1 %100 != 0)){
        echo $n1. ' é bissexto';
    } else {
        echo $n1. ' Não é bissexto';
    }
    ?></p>

<a href="main.html">Voltar</a>

</body>

</html>