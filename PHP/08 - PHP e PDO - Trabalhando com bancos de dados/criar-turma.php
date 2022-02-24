<?php

use Alura\Pdo\Domain\Model\Student;
use Alura\Pdo\Infrastructure\Persistence\ConnectionCreator;
use Alura\Pdo\Infrastructure\Repository\PdoStudentRepository;

require_once 'vendor/autoload.php';

$connection = ConnectionCreator::createConnection();
$studentRepository = new PdoStudentRepository($connection);

$connection->beginTransaction();

try {

    $aStudent = new Student(
        null,
        "João da Silva",
        new DateTimeImmutable('1976-05-12')
    );

    $studentRepository->save($aStudent);

    $anotherStudent = new Student(
        null,
        "Nico Steppat",
        new DateTimeImmutable("1985-05-01")
    );

    $studentRepository->save($anotherStudent);

    // PARA QUE A TRANSAÇÃO NÃO SEJA EFETIVADA, BASTA USAR O MÉTODO 'rollBack' do PDO.
    // $connextion->rollBack();

    $connection->commit();

} catch (PDOException $e) {
    echo $e->getMessage() . PHP_EOL;
    $connection->rollBack();
}

