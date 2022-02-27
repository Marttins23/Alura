<?php

namespace Alura\Cursos\Controller;

class FormularioInsercao extends ControllerComHtml implements InterfaceControladorRequisicao
{
    public function processaRequisicao(): void
    {
        $html = $this->renderizaHtml("cursos/formulario.php", [
           'titulo' => 'Novo Curso'
        ]);

        echo $html;
    }
}