<?php

    $altura = 1.75;
    $peso = 80.3;

    $imc = $peso / ($altura * $altura);

    echo "O seu IMC é $imc" . PHP_EOL . "A sua classificação é: ";

    if($imc < 18.5) {
        echo "MAGREZA" . PHP_EOL;
    } else if($imc >= 18.5 && $imc < 25) {
        echo "NORMAL" . PHP_EOL;
    } else if($imc >= 25 && $imc < 30) {
        echo "SOBREPESO" . PHP_EOL;
    } else if($imc >= 30 && $imc < 40) {
        echo "OBESIDADE" . PHP_EOL;
    } else {
        echo "OBESIDADE GRAVE" . PHP_EOL;
    }