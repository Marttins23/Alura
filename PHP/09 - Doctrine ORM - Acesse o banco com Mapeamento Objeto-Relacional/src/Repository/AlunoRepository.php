<?php

namespace Alura\Doctrine\Repository;

use Alura\Doctrine\Entity\Aluno;
use Doctrine\Common\Collections\Collection;
use Doctrine\ORM\EntityRepository;

class AlunoRepository extends EntityRepository
{
    public function buscaCursosPorAluno()
    {
        $query = $this->createQueryBuilder('a')
            ->join('a.telefones', 't')
            ->join('a.cursos', 'c')
            ->addSelect('t')
            ->addSelect('c')
            ->getQuery();

        return $query->getResult();
    }

    public function buscaCursosPorAlunoDinamica(bool $exibeCursos)
    {
        $builder = $this->createQueryBuilder('a')
            ->join('a.telefones', 't')
            ->addSelect('t');

        if($exibeCursos) {
            $builder
                ->addSelect('c')
                ->join('a.cursos', 'c');
        }

        $query = $builder->getQuery();

        return $query->getResult();
    }
}