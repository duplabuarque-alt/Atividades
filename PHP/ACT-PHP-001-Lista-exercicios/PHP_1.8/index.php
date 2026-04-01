<?php

$n1 = $_GET["n1"];
function soma($n1){
    $soma = 0;
    for ($i = 0; $i <= $n1; $i++) {
        $soma = $soma + $i;
    }
    return $soma;
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

<p>soma:<?php echo ' '. soma($n1);?></p>

<a href="main.html">Voltar</a>

</body>

</html>