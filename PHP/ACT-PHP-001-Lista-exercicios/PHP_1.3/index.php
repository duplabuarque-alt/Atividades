<?php

$n1 = $_GET["n1"];

$n2 = $_GET["n2"];

$op = $_GET["op"];

$r = 0;
if ($op == "+") {
    $r = $n1 + $n2;
} else if ($op == "-") {
    $r = $n1 - $n2;
} else if ($op == "*") {
    $r = $n1 * $n2;
} else if ($op == "/") {
    $r = $n1 / $n2;
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

<p>Primeiro número: <?php echo $n1; ?></p>

<p><strong>operador: <?php echo $op; ?></strong></p>

<p>Segundo número: <?php echo $n2; ?></p>

<p>resultado: <?php echo $r; ?></p>

<a href="main.html">Voltar</a>

</body>

</html>