<?php

use Alura\Pdo\Infrastructure\Persistence\ConnectionCreator;

require_once 'vendor/autoload.php';

$pdo = ConnectionCreator::createConnection();

echo 'Conectei';

$pdo->exec("INSERT INTO phones(area_code, number, student_id) VALUES('31', '987654567', 1), ('32', '999999999', 2);");
exit();

$createTableSql = '
    CREATE TABLE IF NOT EXISTS students (
        id INTEGER PRIMARY KEY, 
        name TEXT, 
        birthday_date TEXT
    );

    CREATE TABLE IF NOT EXISTS phones (
        id INTEGER PRIMARY KEY,
        area_code TEXT,
        number TEXT,
        student_id INTEGER,
        FOREIGN KEY(student_id) REFERENCES students(id)  
    );
        
';

$pdo->exec($createTableSql);
