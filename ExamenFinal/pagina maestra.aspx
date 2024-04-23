<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Página Maestra</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f1f1f1;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .menu-circle {
            list-style: none;
            padding: 0;
            margin: 0;
            position: relative;
            width: 200px;
            height: 200px;
            border-radius: 50%;
            background-color: #4caf50;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .menu-item {
            position: absolute;
            width: 50px;
            height: 50px;
            background-color: #fff;
            border-radius: 50%;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .menu-item a {
            text-decoration: none;
            color: #333;
            font-weight: bold;
        }

        .item1 { transform: rotate(0deg) translateY(-100px); }
        .item2 { transform: rotate(120deg) translateY(-100px); }
    </style>
</head>
<body>
    <ul class="menu-circle">
        <li class="menu-item item1"><a href="catalogo_agentes.html">Agentes</a></li>
        <li class="menu-item item2"><a href="catalogo_clientes.html">Clientes</a></li>
    </ul>
</body>
</html>
