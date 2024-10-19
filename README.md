# tic-tac-toe

![image](https://github.com/user-attachments/assets/8826ec66-5037-4a65-af0a-1376434967df)

# Documentación del Juego Tic Tac Toe

## Introducción
Este documento describe el desarrollo y funcionamiento de un juego de Tic Tac Toe (también conocido como Triki) utilizando .NET 8 y Visual Studio 2022. El objetivo del juego es que dos jugadores alternen turnos para marcar los espacios en una cuadrícula de 3x3, y el primero en conseguir tres de sus marcas en línea (horizontal, vertical o diagonal) gana.

## Requisitos del Sistema
- Visual Studio 2022
- .NET 8
- Windows 10 o superior

## Diseño de la Interfaz de Usuario
La interfaz de usuario consiste en una cuadrícula de 3x3 de botones que los jugadores utilizarán para marcar sus movimientos. También incluye un label para mostrar mensajes como "Jugador X gana" o "Empate".

## Estructura del Proyecto
- **Form1.cs**: Archivo principal que contiene la lógica del juego y la inicialización de la interfaz de usuario.
- **Form1.Designer.cs**: Archivo generado automáticamente por Visual Studio que define los componentes del formulario.
- **Program.cs**: Archivo de entrada principal que arranca la aplicación.

## Inicialización del Tablero
En el método `InitializeGameBoard()`, los botones se crean y colocan en una cuadrícula de 3x3. Cada botón tiene un controlador de eventos que maneja los clics de los jugadores.

## Manejo de los Clics
El método `Button_Click` maneja la lógica de alternancia entre jugadores y actualiza el estado del botón.

## Verificación del Ganador
El método `CheckForWinner()` verifica si hay un ganador o si el juego termina en empate. Si hay un ganador o un empate, se muestra un mensaje y el tablero se reinicia.

