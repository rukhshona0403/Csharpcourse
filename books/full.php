<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Full</title>
</head>
<body>
  <h1>Форма добавления и отображения книги</h1>
  

  <h2>Форма добавления книги</h2>
  <form action="fullinsert.php" method="post">
    <label for="imya">Name:</label>
    <input type="text" id="imya" name="imya">
    <br>
    <label for="familiya">Autor:</label>
    <input type="text" id="familiya" name="familiya">
    <br>
    <label for="adress">Text:</label>
    <input type="text" id="adress" name="adress">
    <br>
    <label for="nomer_tel">Price:</label>
    <input type="number" id="nomer_tel" name="nomer_tel">
    <br>
    <br>
    <input type="submit" value="Добавить" onclick="alert('Данные успешно добавлены')">
  </form>

  <h2>Список книге  </h2>

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

  // Подготовить запрос
  $stmt = $conn->prepare("SELECT * FROM uchitelya");

  // Выполнить запрос
  $stmt->execute();

  // Получить результат
  $result = $stmt->get_result();

  // Вывести данные в виде таблицы
  echo "<table border='1'>";
  echo "<tr><th>Id</th><th>Name</th><th>Autor</th><th>Text</th><th>Price</th></tr>";
  while ($row = $result->fetch_assoc()) {
    echo "<tr><td>" . $row['Id'] . "</td><td>" . $row['Imya'] . "</td><td>" . $row['Familiya'] . "</td><td>" . $row['Adress'] . "</td><td>" . $row['Nomer_tel'] . "</td></tr>";
  }
  echo "</table>";

  // Закрыть соединение
  $conn->close();

  ?>
<h1>Форма удаления книге</h1>
  
  <form action="fulldelete.php" method="post">
    <label for="id">Идентификатор книги:</label>
    <input type="number" id="id" name="id">
    <br>
    <input type="submit" value="Удалить" onclick="alert('Данные успешно удалены')">
<br>
    <img src='image.png'><br>
<a href="Azure-Quick-Start-for-NET-Developers.pdf"> <h3> Читать книгу </h3> </a>
  </form>
</body>
</html>