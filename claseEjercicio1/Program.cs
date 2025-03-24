using System;

namespace claseEjercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class CuentaBanco
    {
        public string nombre;
        public string apellido;
        public string telefono;
        public int dni;
        public int cbu;
        public int saldo;

        public void ingresarDinero()
        {
            Console.WriteLine("Se ingreso dinero");

        }

        public void sacoDinero()
        {
            Console.WriteLine("Se saco dinero");
        }

        public void Transferencia()
        {
            Console.WriteLine("Se transfirio dinero");
        }
        

    }
}
