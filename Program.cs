using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertirCadena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa calquier texto para invertir sus caracteres");
            string cadenaIngresada = Console.ReadLine();

            Console.WriteLine("El resultado de la cadena invertida es: ");
            Console.WriteLine(InvertirManualmente(cadenaIngresada));
            Console.Read();
        }
        public static string InvertirManualmente(string cadena)
        {
            string cadenaInvertida = "";
            foreach (char letra in cadena)
            {
                cadenaInvertida = letra + cadenaInvertida;
            }
            return cadenaInvertida;
        }
    }
}
