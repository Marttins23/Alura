<?php

namespace Alura\Cursos\Controller;

use Alura\Cursos\Entity\Curso;
use Alura\Cursos\Infra\EntityManagerCreator;
use Doctrine\ORM\EntityManagerInterface;

class Persistencia implements InterfaceControladorRequisicao
{
    private EntityManagerInterface $entityManager;

    public function __construct()
    {
        $this->entityManager = (new EntityManagerCreator())->getEntityManager();
    }

    public function processaRequisicao(): void
    {
        // A FUNÇÃO FILTER_INPUT FILTRA DEVOLVE A STRING
        // COM APENAS CARACTERES VÁLIDOS (sem tags, que poderiam
        // ser usadas para fazer um ataque ao nosso sistema, por exemplo).
        $descricao = filter_input(
            INPUT_POST,
            'descricao',
            FILTER_SANITIZE_STRING
        );

        $id = filter_input(
            INPUT_GET,
            'id',
            FILTER_VALIDATE_INT
        );

        if(!is_null($id) && $id !== false) {
            $curso = $this->entityManager->find(Curso::class, $id);
            $curso->setId($id);
        } else {
            $curso = new Curso();
            $this->entityManager->persist($curso);
        }

        $curso->setDescricao($descricao);
        $this->entityManager->flush();
        header('Location: /listar-cursos', true, 302);
    }
}