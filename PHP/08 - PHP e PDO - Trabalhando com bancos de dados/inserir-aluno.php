<?php

use Alura\Pdo\Domain\Model\Student;

require_once 'vendor/autoload.php';

$pdo = \Alura\Pdo\Infrastructure\Persistence\ConnectionCreator::createConnection();

// INSERÇÃO COMUM
//$aluno = new Student(null,"Mateus Ferreira Martins", new DateTimeImmutable("1995-05-23"));
//$sqlInsert = "INSERT INTO students(name, birthday_date) VALUES ('{$aluno->name()}', '{$aluno->birthDate()->format('Y-m-d')}');";
//var_dump($pdo->exec($sqlInsert));

// INSERÇÃO COM PREPARE STATEMENT, PARA PREVENIR SQL INJECTION
$aluno = new Student(
    null,
    "Fernanda da Silva",
    new DateTimeImmutable("1982-05-24")
);

$sqlInsert = "INSERT INTO students(name, birthday_date) VALUES (:name, :birthday_date)";
$statement = $pdo->prepare($sqlInsert);
$statement->bindValue(':name', $aluno->name());
$statement->bindValue(':birthday_date', $aluno->birthDate()->format('Y-m-d'));

if($statement->execute()) {
    echo "Aluno incluído!" . PHP_EOL;
}
