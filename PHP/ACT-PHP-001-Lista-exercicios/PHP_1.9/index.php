<?php
function media($texto) {
    $soma = 0;
    $qtd = 0;
    $num = "";

    for ($i = 0; $i < strlen($texto); $i++) {
        $c = $texto[$i];
        if ($c == ",") {
            $soma = $soma + (float)$num;
            $qtd++;
            $num = "";
        } else {
            $num = $num . $c;
        }
    }
    if ($num != "") {
        $soma = $soma + (float)$num;
        $qtd++;
    }
    return $soma / $qtd;
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

<p>Média:<?php
    if (isset($_GET["n1"])) {
        $entrada = $_GET["n1"];
        echo " " . media($entrada);
    }?></p>

<a href="main.html">Voltar</a>

</body>

</html>