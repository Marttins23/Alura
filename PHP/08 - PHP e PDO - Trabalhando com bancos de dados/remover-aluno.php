<?php

use Alura\Pdo\Infrastructure\Persistence\ConnectionCreator;

$pdo = ConnectionCreator::createConnection();

$statement = $pdo->prepare("DELETE FROM students WHERE id = :id");
$statement->bindValue(':id', 3, PDO::PARAM_INT);
var_dump($statement->execute());
