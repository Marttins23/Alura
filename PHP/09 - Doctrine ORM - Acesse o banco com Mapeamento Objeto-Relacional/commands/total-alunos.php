<?php

use Alura\Doctrine\Entity\Aluno;
use Alura\Doctrine\Helper\EntityManagerFactory;

require_once __DIR__ . '/../vendor/autoload.php';

$entityManagerFactory = new EntityManagerFactory();
$entityManager = $entityManagerFactory->getEntityManager();

$classeAluno = Aluno::class;
$dql = "SELECT COUNT(a) FROM $classeAluno a";
// TAMBÉM PODEMOS USAR FUNÇÕES DE AGREGAÇÃO NAS DQL.
// SE TIVÉSSEMOS E QUISÉSSEMOS CALCULAR A MÉDIA DAS IDADES DOA ALUNOS, BASTARIA FAZER:
// $dql = "SELECT AVG(a.idades) FROM $classeAluno a";

$query = $entityManager->createQuery($dql);
$totalAlunos = $query->getSingleScalarResult();

echo "Total de alunos: " . $totalAlunos;