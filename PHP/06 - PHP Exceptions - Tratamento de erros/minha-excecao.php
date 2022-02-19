<?php

class MinhaExcecao extends DomainException
{
    public function exibeMateus()
    {
        echo "Mateus";
    }
}

try {
    throw new MinhaExcecao();
} catch (MinhaExcecao $e) {
    $e->exibeMateus();
}
