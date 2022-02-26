<?php

use Alura\Doctrine\Entity\Aluno;
use Alura\Doctrine\Helper\EntityManagerFactory;

require_once __DIR__ . '/../vendor/autoload.php';

$entityManagerFactory = new EntityManagerFactory();
$entityManager = $entityManagerFactory->getEntityManager();

$repository = $entityManager->getRepository(Aluno::class);

$alunosList = $repository->findAll();

foreach($alunosList as $aluno) {
    $telefones = $aluno
        ->getTelefones()
        ->map(function($telefone) {
            return $telefone->getNumero();
        })
        ->toArray();
    echo "ID: {$aluno->getId()} - Nome: {$aluno->getNome()}\n";
    echo "Telefones:" . implode(', ', $telefones) . "\n\n";
}

/*$tatiana = $repository->find(3);
echo "ID da Tatiana: {$tatiana->getId()}" . PHP_EOL;

$mateus = $repository->findOneBy([
    'nome' => 'Mateus Ferreira'
]);

echo "Achamos o {$mateus->getNome()}";*/
