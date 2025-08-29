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

        //Los metodos segun POO deben iniciar en infinitivo
        public void depositar(double MontoPa)
        { Saldo += MontoPa; 
        }

 

        public override string ToString()
        {
            return "Nombre: " + Nombre + "\nApellido: " + Apellido + "\nDireccion: " + Direccion + "\nCedula: " + Cedula + "\nSaldo: " + Saldo;
        }
    }
}
