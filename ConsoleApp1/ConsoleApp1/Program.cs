using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /**
         * Esto es un comentario
         * de varias línes.
         */
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int resu = num1 + num2;

            // Tipos de datos
            // String, int, decimal, double, char, boolean, float

            string str1 = "Andrea";
            string str2 = "Ibánez";
            string strResu = str1 + " " + str2;
            System.Console.Write("El resultado es: " + (num1+num2));
            System.Console.WriteLine("\n\tEl resultado es: " + strResu);
            System.Console.WriteLine("\n\tEl tamaño es: " + strResu.Length);

            System.Console.WriteLine("\n");
            // Trabajo con decimales
            decimal n1 = 2.35M;
            decimal n2 = 3.0M;
            decimal n3 = 6;
            decimal n4 = 7;
            decimal n5 = 8;


            //Operadores + - * / ^
            System.Console.WriteLine("\n\tLa suma es: " + (n1+n2));
            System.Console.WriteLine("\n\tLa resta es: " + (n1 - n2));
            System.Console.WriteLine("\n\tLa multiplicación es: " + (n1 * n2));
            System.Console.WriteLine("\n\tLa división es: " + (n1 / n2));

            //Operadores de comparación
            // > < >= <= == != ===

            //Estructuras condicionales

            if (n1 > n2) {
                if (n1 > n3)
                {
                    System.Console.WriteLine("\n\tEl mayor es: " + n1);
                }
                else {
                    System.Console.WriteLine("\n\tEl mayor es: " + n3);
                }
            }
            else
            {
                if (n2 > n3)
                {
                    System.Console.WriteLine("\n\tEl mayor es: " + n2);
                }
                else
                {
                    System.Console.WriteLine("\n\tEl mayor es: " + n3);
                }
            }

            // Condiciones múltiples

            if (n1 > n2)
            {
                System.Console.WriteLine("\n\tEl mayor es: " + n1);
            }
            else if (n2 > n3)
            {
                System.Console.WriteLine("\n\tEl mayor es: " + n2);
            }
            else if (n3 > n4)
            {
                System.Console.WriteLine("\n\tEl mayor es: " + n3);
            }
            else if (n4 > n5)
            {
                System.Console.WriteLine("\n\tEl mayor es: " + n4);
            }
            else {
                System.Console.WriteLine("\n\tEl mayor es: " + n5);
            }

            // Ciclos

            for (int x = 0; x < strResu.Length; x++) {
                System.Console.Write(strResu[x]);
            }

            System.Console.ReadKey();
        }
    }
}
