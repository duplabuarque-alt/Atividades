<?php

$n1 = $_GET["n1"];
$n2 = $_GET["n2"];
$n3 = $_GET["n3"];
$n4 = $_GET["n4"];
$n5 = $_GET["n5"];

$i = 1;

$nf1 = 1;
    for($i=1; $i<=$n1; $i++){
        $nf1 = $i * $nf1;
    }
$i = 1;

$nf2 = 1;
    for($i=1; $i<=$n2; $i++){
        $nf2 = $i * $nf2;
    }
$i = 1;

$nf3 = 1;
    for($i=1; $i<=$n3; $i++){
        $nf3 = $i * $nf3;
    }
    $i = 1;

$nf4 = 1;
    for($i=1; $i<=$n4; $i++){
        $nf4 = $i * $nf4;
    }
$i = 1;

$nf5 = 1;
    for($i=1; $i<=$n5; $i++){
        $nf5 = $i * $nf5;
    }
$nfinal = $nf1 + $nf2 + $nf3 + $nf4 + $nf5;

?>

<!DOCTYPE html>

<html lang="pt-br">

<head>

    <meta charset="UTF-8">

    <title>Resultado </title>

</head>

<body>

<h1>Resultado</h1>

<p>resultado: <?php echo $nfinal; ?></p>

<a href="main.html">Voltar</a>

</body>

</html>