<?php

$n1 = $_GET["n1"];
$n2 = $_GET["n2"];
$n3 = $_GET["n3"];
$n4 = $_GET["n4"];
$n5 = $_GET["n5"];
$n6 = $_GET["n6"];
$n7 = $_GET["n7"];
$n8 = $_GET["n8"];

$num = [$n1, $n2, $n3, $n4, $n5, $n6, $n7, $n8];

$positivos = [];
$negativos = [];

for ($i = 0; $i < 8; $i++) {
    if ($num[$i] >= 0) {
        $positivos[] = $num[$i];
    } else {
        $negativos[] = $num[$i];
    }
}
?>

<!DOCTYPE html>

<html lang="pt-br">

<head>

    <meta charset="UTF-8">

    <title>Resultado </title>

</head>

<body>

<h1>Resultado</h1>

<p>positivos:<?php
    for($a = 0; $a < count($positivos); $a++) {
        echo $positivos[$a]. ' ';
    }
    ?></p>

<p>negativos:<?php
    for($b = 0; $b < count($negativos); $b++) {
        echo $negativos[$b]. ' ';
    }
    ?></p>

<a href="main.html">Voltar</a>

</body>

</html>