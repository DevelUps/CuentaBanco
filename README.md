# CuentaBanco

Este programa en C# simula una aplicación de gestión de cuentas bancarias.

## Funcionalidades

- Crear una nueva cuenta bancaria proporcionando información personal y saldo inicial.
- Realizar depósitos en la cuenta.
- Realizar retiros de la cuenta.
- Consultar el saldo de la cuenta.
- Mostrar la información completa de la cuenta.
- Salir del programa.

## Uso

1. Ejecuta el programa.
2. Sigue las instrucciones en pantalla para crear una cuenta y realizar operaciones bancarias.

## Ejemplo de Uso

```csharp
// Crear una nueva cuenta bancaria
CuentaBancaria cliente1 = new CuentaBancaria("Juan", "Pérez", 1000, "Calle 123", "123456789");

// Realizar un depósito
cliente1.Deposito(500);

// Realizar un retiro
cliente1.Retiro(200);

// Consultar el saldo
cliente1.ConsultaSaldo();

// Mostrar la información de la cuenta
Console.WriteLine(cliente1.ToString());
