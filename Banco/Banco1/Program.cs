using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //variables
            double MontoAr, saldoInicialAr;
            String NombreAr, ApellidoAr, DireccionAr, CedulaAr;
            int opcion;

            //creacion de la cuenta
            Console.WriteLine("Estas a punto de crear una cuenta bancaria, presiona cualquier tecla: ");
            Console.ReadKey();
            Console.WriteLine("Ingrese su nombre: ");
            NombreAr = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            ApellidoAr = Console.ReadLine();
            Console.WriteLine("Ingrese su direccion: ");
            DireccionAr = Console.ReadLine();
            Console.WriteLine("Ingrese su cedula: ");
            CedulaAr = Console.ReadLine();
            Console.WriteLine("Ingrese su saldo inicial: ");
            saldoInicialAr = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor del deposito inicial: $ ");
            MontoAr = Convert.ToDouble(Console.ReadLine());

            CuentaBancaria cliente = new CuentaBancaria(NombreAr, ApellidoAr, 
                DireccionAr, CedulaAr, saldoInicialAr);

            Console.WriteLine("Cuenta creada exitosamente, presiona cualquier tecla: ");
            Console.ReadKey();

            do {                 //menu
                Console.Clear();
                Console.WriteLine("Bienvenido, " + NombreAr + " " + ApellidoAr + ", seleccione una opcion: ");
                Console.WriteLine("\n1. Depositar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Consultar saldo");
                Console.WriteLine("4. Mostrar datos de la cuenta");
                Console.WriteLine("5. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el valor a depositar: $ ");
                        MontoAr = Convert.ToDouble(Console.ReadLine());
                        cliente.depositar(MontoAr);
                        Console.WriteLine("Deposito exitoso, presiona cualquier tecla para continuar: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("Ingrese el valor a retirar: $ ");
                        MontoAr = Convert.ToDouble(Console.ReadLine());
                        cliente.retirar(MontoAr);
                        Console.WriteLine("Retiro exitoso, presiona cualquier tecla para continuar: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        cliente.ConsultarSaldo();
                        Console.WriteLine("Presiona cualquier tecla para continuar: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine(cliente.ToString());
                        Console.WriteLine("Presiona cualquier tecla para continuar: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar nuestro servicio, presiona cualquier tecla para salir: ");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida, presiona cualquier tecla para continuar: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcion != 5);

        }
    }
}
