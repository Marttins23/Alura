<?php

namespace Alura\Pdo\Infrastructure\Persistence;

use PDO;

class ConnectionCreator
{

    public static function createConnection(): PDO
    {
        /* PARA CRIAR UMA CONEXÃO COM UM BANCO MYSQL, BASTARIA:
           $connection = new PDO(
                'mysql:host=localhost;dbname=banco',
                'root',
                'senha'
            ); */
        $caminhoBanco = __DIR__ . '/../../../banco.sqlite';
        $connection = new PDO('sqlite:' . $caminhoBanco);
        $connection->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        $connection->setAttribute(PDO::ATTR_DEFAULT_FETCH_MODE, PDO::FETCH_ASSOC);

        return $connection;
    }

}