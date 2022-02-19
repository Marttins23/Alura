<?php declare(strict_types=1);

namespace Alura;

require 'autoload.php';

/*$correntistas_e_compras = [
    "Giovanni",
    "João",
    12,
    "Maria",
    25,
    "Luis",
    "Luisa",
    "12",
];

echo "<pre>";

var_dump($correntistas_e_compras);

ArrayUtils::remover(12, $correntistas_e_compras);

var_dump($correntistas_e_compras);

echo "</pre>";*/

$correntistas = [
    "Giovanni",
    "João",
    "Maria",
    "Luis",
    "Luisa",
    "Rafael"
];

$correntistasNaoPagantes = [
    "Luis",
    "Luisa",
    "Rafael",
];

$saldos = [
    2500,
    3000,
    4400,
    1000,
    8700,
    9000
];

//$correntistasPagantes = array_diff($correntistas, $correntistasNaoPagantes);
//$array_merge = array_merge($correntistas, $saldos);
$array_combinado = array_combine($correntistas, $saldos);
/*$array_combinado['Mateus'] = 11000;

echo "<pre>";
//var_dump($correntistasPagantes);
var_dump($array_merge);
var_dump($array_combinado);
echo "{$array_combinado['Giovanni']}";
echo "</pre>";*/

/*if(array_key_exists('João', $array_combinado)) {
    echo "O saldo do João é R$" . "{$array_combinado['João']}";
} else {
    echo "Nome não encontrado";
}*/

//FUNÇÕES: 'exlode' => Tranforma uma string em array
//         'implode' => Transforma um array em string

$maiores = ArrayUtils::retornaPessoasComSalarioMaior(3000, $array_combinado);

echo "<pre>";
var_dump($maiores);
echo "</pre>";
