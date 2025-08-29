using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco1
{
    public class CuentaBancaria
    {
        //campos
        private double Saldo;
        private String Nombre, Apellido, Direccion, Cedula;

        //constructor
        public CuentaBancaria(String NombreAp, String ApellidoAp, String DireccionAp, String CedulaAp, double SaldoPa)
        {
            Nombre = NombreAp;
            Apellido = ApellidoAp;
            Direccion = DireccionAp;
            Cedula = CedulaAp;
            Saldo = SaldoPa;
        }

        //metodos
        public void depositar(double MontoPa)
        {
            Console.WriteLine("Saldo actual: " + Saldo + " pesos.");
        }

        public void retirar(double MontoPa)
        {
            if (MontoPa > Saldo)
            {
                Console.WriteLine("Fondos insuficientes");
            }
            else
            {
                Saldo -= MontoPa;
            }
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine("Su saldo es: " + Saldo);
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "\nApellido: " + Apellido + "\nDireccion: " + Direccion + "\nCedula: " + Cedula + "\nSaldo: " + Saldo;
        }
    }
}
