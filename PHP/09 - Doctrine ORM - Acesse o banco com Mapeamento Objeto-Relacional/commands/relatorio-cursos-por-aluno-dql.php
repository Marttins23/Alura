<?php

use Alura\Doctrine\Entity\Aluno;
use Alura\Doctrine\Entity\Telefone;
use Alura\Doctrine\Helper\EntityManagerFactory;
use Doctrine\DBAL\Logging\DebugStack;

require_once __DIR__ . '/../vendor/autoload.php';

$entityManagerFactory = new EntityManagerFactory();
$entityManager = $entityManagerFactory->getEntityManager();

$classeAluno = Aluno::class;
$dql = "SELECT a, t, c FROM $classeAluno a JOIN a.telefones t JOIN a.cursos c";
$query = $entityManager->createQuery($dql);
$alunos = $query->getResult();

$debugStack = new DebugStack();
$entityManager->getConfiguration()->setSQLLogger($debugStack);

foreach($alunos as $aluno) {
    $telefones = $aluno
        ->getTelefones()
        ->map(function(Telefone $telefone) {
            return $telefone->getNumero();
        })
        ->toArray();
    echo "ID: {$aluno->getId()}\n";
    echo "Nome: {$aluno->getNome()}\n";
    echo "Telefones: " . implode(', ', $telefones) . "\nCursos:\n";

    $cursos = $aluno->getCursos();

    foreach($cursos as $curso) {
        echo "\tID Curso: {$curso->getId()}\n";
        echo "\tNome Curso: {$curso->getNome()}\n\n\n";
    }

}

foreach($debugStack->queries as $queryInfo) {
    echo $queryInfo['sql'] . PHP_EOL;
}

