<?php

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

// Получить данные из формы
$imya = $_POST['imya'];
$familiya = $_POST['familiya'];
$adress = $_POST['adress'];
$nomer_tel = $_POST['nomer_tel'];

// Подготовить запрос
$stmt = $conn->prepare("INSERT INTO uchitelya (Imya, Familiya, Adress, Nomer_tel) VALUES (?, ?, ?, ?)");

// Связать параметры с данными
$stmt->bind_param("ssss", $imya, $familiya, $adress, $nomer_tel);

// Выполнить запрос
$stmt->execute();

// Закрыть соединение
$conn->close();

// Перенаправить на главную страницу
header("Location: full.php");

?>
