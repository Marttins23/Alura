<?php

use Alura\Pdo\Domain\Model\Student;

require_once 'vendor/autoload.php';

$student = new Student(
    null,
    'Mateus Ferreira',
    new \DateTimeImmutable('1995-05-23')
);

echo $student->age();
