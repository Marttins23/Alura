<?php

namespace Alura\Pdo\Infrastructure\Repository;

use Alura\Pdo\Domain\Model\Phone;
use Alura\Pdo\Domain\Model\Student;
use Alura\Pdo\Domain\Repository\StudentRepository;
use Alura\Pdo\Infrastructure\Persistence\ConnectionCreator;
use DateTimeInterface;
use PDO;

class PdoStudentRepository implements StudentRepository
{
    private PDO $connection;

    public function __construct(PDO $connection)
    {
        $this->connection = $connection;
    }

    public function allStudents(): array
    {
        $sqlQuery = "SELECT * FROM students;";
        $statement = $this->connection->query($sqlQuery);

        return $this->hydrateStudentList($statement);
    }

    public function studentsBirthAt(DateTimeInterface $birthday_date): array
    {
        $sqlQuery = "SELECT * FROM students WHERE birthday_date = :bday_date";
        $statement = $this->connection->prepare($sqlQuery);
        $statement->bindValue(':bday_date', $birthday_date->format("Y-m-d"));
        $statement->execute();

        return $this->hydrateStudentList($statement);
    }

    // IMPLEMENTA O PADRÃO HYDRATOR, QUE TRANSFERE DADOS DE UMA CAMADA PARA OUTRA.
    private function hydrateStudentList(\PDOStatement $statement): array
    {
        $studentDataList = $statement->fetchAll();
        $studentList = [];

        foreach($studentDataList as $studentData) {
            $studentList[] = new Student(
                $studentData['id'],
                $studentData['name'],
                new \DateTimeImmutable($studentData['birthday_date'])
            );
        }

        return $studentList;
    }

    private function insert(Student $student): bool
    {
        $sqlQuery = "INSERT INTO students(name, birthday_date) VALUES(:name, :bday_date);";
        $statement = $this->connection->prepare($sqlQuery);

        $success = $statement->execute([
            ':name' => $student->name(),
            ':bday_date' => $student->birthDate()->format('Y-m-d')
        ]);

        $student->defineId($this->connection->lastInsertId());

        return $success;
    }

    private function update(Student $student): bool
    {
        $sqlQuery = "UPDATE students SET name = :name, birthday_date = :bday_date WHERE id = :id;";
        $statement = $this->connection->prepare($sqlQuery);
        $statement->bindValue(':name', $student->name());
        $statement->bindValue(':bday_date', $student->birthDate()->format('Y-m-d'));
        $statement->bindValue(':id', $student->id());

        return $statement->execute();
    }

    public function save(Student $student): bool
    {
        if($student->id() === null) {
            return $this->insert($student);
        }

        return $this->update($student);
    }

    public function remove(Student $student): bool
    {
        $sqlQuery = "DELETE FROM students WHERE id = :id";
        $statement = $this->connection->prepare($sqlQuery);
        $statement->bindValue(':id', $student->id(), PDO::PARAM_INT);
        return $statement->execute();
    }

    private function fillPhonesOf(Student $student): void
    {
        $sqlQuery = 'SELECT id, area_code, number FROM phones WHERE student_id = ?;';
        $stmt = $this->connection->prepare($sqlQuery);
        $stmt->bindValue(1, $student->id(), PDO::PARAM_INT);
        $stmt->execute();

        $phoneDataList = $stmt->fetchAll();

        foreach($phoneDataList as $phoneData) {
            $phone = new Phone(
                $phoneData['id'],
                $phoneData['area_code'],
                $phoneData['number']
            );
            $student->addPhone($phone);
        }
    }

    public function studentsWithPhone(): array
    {
       $sqlQuery = 'SELECT students.id,
                           students.name,
                           students.birthday_date,
                           phones.id AS phone_id,
                           phones.area_code,
                           phones.number
                    FROM students
                    JOIN phones ON students.id = phones.student_id;';
       $stmt = $this->connection->query($sqlQuery);
       $result = $stmt->fetchAll();
       $studentList = [];

       foreach($result as $row) {
           if(!array_key_exists($row['id'], $studentList)) {
               $studentList[$row['id']] = new Student(
                   $row['id'],
                   $row['name'],
                   new \DateTimeImmutable($row['birthday_date'])
               );
           }
           $phone = new Phone($row['phone_id'], $row['area_code'], $row['number']);
           $studentList[$row['id']]->addPhone($phone);
       }

       return $studentList;
    }
}