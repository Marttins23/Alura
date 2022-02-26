<?php

use Alura\Doctrine\Entity\Aluno;
use Alura\Doctrine\Entity\Telefone;
use Alura\Doctrine\Helper\EntityManagerFactory;
use Doctrine\DBAL\Logging\DebugStack;

require_once __DIR__ . '/../vendor/autoload.php';

$entityManagerFactory = new EntityManagerFactory();
$entityManager = $entityManagerFactory->getEntityManager();

// DQL é a linguagem de queries do doctrine.
$dql = 'SELECT aluno FROM Alura\\Doctrine\Entity\Aluno aluno';
$query = $entityManager->createQuery($dql);
// PODEMOS FAZER FILTROS NA QUERY:
// $dql = 'SELECT aluno FROM Alura\\Doctrine\Entity\Aluno aluno WHERE aluno.id = 2';
// $dql = 'SELECT aluno FROM Alura\\Doctrine\Entity\Aluno aluno WHERE aluno.id = 2 OR
// aluno.nome = "Nico Steppat"';

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

