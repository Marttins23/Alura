<?php

    $numero = 3;

    echo "Tabuada do $numero" . PHP_EOL;

    for($i = 1; $i <= 10; $i++) {
        $multiplicacao = $numero * $i;
        echo "$numero x $i = $multiplicacao" . PHP_EOL;
    }