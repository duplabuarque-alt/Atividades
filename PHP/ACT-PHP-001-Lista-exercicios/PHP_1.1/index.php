<?php

$n1 = $_GET["n1"];
$a = 'a';

if ($n1 > 100 and $n1 < 200) {
    $a = 'O número esta no intervalo de 100 a 200';
} else {
    $a = 'O número está fora do intervalo de 100 a 200';
}
?>

<!DOCTYPE html>

<html lang="pt-br">

<head>

    <meta charset="UTF-8">

    <title>Resultado </title>

</head>

<body>

<h1>Intervalo </h1>

<p>Valor digitado: <?php echo $n1; ?></p>

<p> <?php echo $a; ?></p>



<a href="main.html">Voltar</a>

</body>

</html>


