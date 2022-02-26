<?php

use Alura\Doctrine\Entity\Aluno;
use Alura\Doctrine\Helper\EntityManagerFactory;

require_once __DIR__ . '/../vendor/autoload.php';

$entityManagerFactory = new EntityManagerFactory();
$entityManager = $entityManagerFactory->getEntityManager();

// $argv é o array de parâmetros, quando lemos algo pela linha de comando
$id = $argv[1];
$nome = $argv[2];

//O EntityManager tbm possui o método find, porém não possui o findAll()
//Ou seja, não podemos buscar mais de um objeto por vez.
$aluno = $entityManager->find(Aluno::class, $id);

$aluno->setNome($nome);

$entityManager->flush();
