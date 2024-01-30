using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double monto,saldoInicialAr; ;
            int opcion;
            string nombreAr, apellidosAr, direccionAr, cedulaAr;

            //Aviso de cuenta
            Console.WriteLine("Para crear una cuenta, presione cualquier tecla: ");
            Console.ReadKey();

            Console.WriteLine("\nIngrese informacion solititada a continuacion: ");


            Console.Write("Escriba su nombre: ");
            nombreAr = Console.ReadLine();

            Console.Write("Escriba sus Apellidos: ");
            apellidosAr = Console.ReadLine();

            Console.Write("Escriba su Direccion: ");
            direccionAr = Console.ReadLine();

            Console.Write("Escriba su Cedula: ");
            cedulaAr = Console.ReadLine();

            Console.Write("Escriba su saldo inicial: $");
            saldoInicialAr = Convert.ToDouble(Console.ReadLine());

            CuentaBancaria cliente1 = new CuentaBancaria(nombreAr,apellidosAr,saldoInicialAr,direccionAr, cedulaAr);
            Console.WriteLine("Felicidades, su cuenta ha sido crada con exito, presione cualquier tecla para continuar :");
            Console.ReadKey();

            Console.WriteLine("\n1.Deposito: ");
            Console.WriteLine("\n2.Retiro: ");
            Console.WriteLine("\n3.Consultar: ");
            Console.WriteLine("\n4.Mostrar la informacion de la cuenta: ");
            Console.WriteLine("\n5.Salir: ");
            Console.Write("\nElige un de las opciones: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el Monto Inicial: ");
                    monto= Convert.ToInt32(Console.ReadLine());
                    cliente1.Deposito(monto);

                    break;

                case 2:
                    Console.WriteLine("Ingrese el mondo a retirar: $");
                    monto = Convert.ToInt32(Console.ReadLine());
                    cliente1.Retiro(monto);
                    break;

                case 3:
                    cliente1.ConsultaSaldo();
                    break;

                case 4:
                    Console.WriteLine(cliente1.ToString());
                    break;
                
                default:
                    Console.WriteLine("Error: Opción inválida: ");
                    break;
            }
            
            if (!(opcion >= 1 && opcion <= 4))
            {
                Console.WriteLine("Saliendo del programa...");
                return; // Salir del método Main y terminar la ejecución del programa
            }
            Console.WriteLine(cliente1.ToString());
            Console.ReadKey();
            Console.WriteLine("Gracias por crear su cuenta con nosotros: ");

        }
    }
    class CuentaBancaria
    {
        // Campos

        private string nombre, apellidos, direccion, cedula;
        private double saldo;

       

        // Constructor
        public CuentaBancaria(string nombrePa, string apellidosPa, double saldoPa, string direccionPa, string ccPa)
        {
            nombre = nombrePa;
            apellidos = apellidosPa;
            saldo = saldoPa;
            direccion = direccionPa;
            cedula = ccPa;

        }
        // Metodos
        public double Deposito(double montoPa)
        {

            saldo += montoPa;
            return saldo;
        }

        public double Retiro(double montoPa)
        {
            if (saldo >= montoPa)
            {
                saldo -= montoPa;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para transaccion: ");
            }
            return saldo;
        }

        public void ConsultaSaldo()
        {
            Console.WriteLine("Su saldo es;{0} ", saldo);
          
        }

        public override string ToString()
        {
            string mensaje;
            mensaje = "\n Titular: " + nombre + "\n Apellidos: " + apellidos + "\n Cedula: " + cedula + "\n Direccion: " + direccion + "\n Saldo; $" + saldo;
            
            return mensaje;

        }
      
    }
  

  


}
