<?php

$n1 = $_GET["n1"];
$i = 1;
$j = 1;


?>

<!DOCTYPE html>

<html lang="pt-br">

<head>

    <meta charset="UTF-8">

    <title>Resultado </title>

</head>

<body>

<h1>Resultado</h1>

<?php
for ($i = 1; $i <= $n1; $i++) {
    for ($j = 1; $j <= $i; $j++) {
        echo $j . ' ';
    }
    echo "\n";
}
echo "\n";
?>

<a href="main.html">Voltar</a>

</body>

</html>