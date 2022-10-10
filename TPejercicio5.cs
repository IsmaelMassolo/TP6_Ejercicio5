//Solicitar que se ingrese 2 números e indicar mayor, menor o igual.
using System;
using System.Threading;
namespace TpCSharpEjercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0, numero2 = 0;
            string entrada = String.Empty, resultado=String.Empty;
            Console.Clear();
            Console.WriteLine("Ingrese el primer número...");
            entrada = Console.ReadLine();
            numero1 = Convert.ToInt32 (entrada);
            Console.WriteLine("ingrese el segundo número...");
            entrada = Console.ReadLine();
            numero2 = Convert.ToInt32 (entrada);
            Console.Clear();
            resultado = funcionOperacion (numero1, numero2);
            Console.WriteLine(resultado);
            Console.WriteLine ("Saliendo del programa...");
            Thread.Sleep (3000);
            Console.Clear();
        }
        static string funcionOperacion (int n1, int n2)
        {
            string rta =String.Empty;
            if (n1 < n2)
                rta = "el número "+n1+" es menor que el número "+n2;
            else if (n1 > n2)
                rta ="el número "+n1+" es mayor que el número " +n2;
            else
                rta ="el número "+n1+" es igual que el número " +n2;
            return rta;
        }
    }
}