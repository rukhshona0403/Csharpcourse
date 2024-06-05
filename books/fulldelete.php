<?php

// Получить идентификатор учителя из формы
$id = $_POST['id'];

// Подключиться к базе данных
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "fakultet";

// Создать соединение
$conn = new mysqli($servername, $username, $password, $dbname);

// Проверить соединение
if ($conn->connect_error) {
  die("Ошибка подключения: " . $conn->connect_error);
}

// Подготовить запрос для удаления учителя
$stmt = $conn->prepare("DELETE FROM uchitelya WHERE Id = ?");

// Связать идентификатор учителя с запросом
$stmt->bind_param("i", $id);

// Выполнить запрос
$stmt->execute();

// Закрыть соединение
$conn->close();

// Перенаправить на главную страницу
header("Location: full.php");

?>
