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

    public class Celular
    {
        public string marca;
        public string modelo;
        public int bateria;
        public int camara;
        public int almacenamiento;
        
        public void Llamar()
        {
            Console.WriteLine("Lammando a otro celular");
        }

        public void encenderLinterna()
        {
            Console.WriteLine("Encendiendo Linterna");
        }

        public void Sacarfoto()
        {
            Console.WriteLine("Tomar foto");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando el telefono");
        }
    }
}
