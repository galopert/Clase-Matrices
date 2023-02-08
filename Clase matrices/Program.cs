using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Clase_matrices
{
    internal class Program

    {
        public static float num1, num2;//variables globales
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            float sumatoria = 0; //variable local
            string opcion = "s";  //variable local
            int[,] matrix2 = new[,] { { 1, 20, 3 }, { 50, 4, 6, } };

            Console.WriteLine("********Matrix 1*********");

            for (int f = 0; f < 3; f++) //filas
            {
                for (int c = 0; c < 3; c++) //columnas
                {
                    Console.Write(matrix[f, c] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine("********Matrix 2*********");
            for (int f = 0; f < 2; f++) //filas
            {
                for (int c = 0; c < 3; c++) //columnas
                {
                    Console.Write(matrix2[f, c] + " ");
                    sumatoria += matrix2[f, c];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sumatoria ={0}", sumatoria);
            Console.WriteLine("Promedio {0}", sumatoria /= matrix2.Length);





            int op = 0;

            do
            {
                Console.WriteLine("1-sumar ");
                Console.WriteLine("2-multiplicar ");
                Console.WriteLine("3-restar ");
                Console.WriteLine("4-dividir");
                Console.WriteLine("5-Salir");
                Console.WriteLine("Digite una opcion");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Solicitadatos();
                        Suma();

                        break;

                    case 2:
                        Solicitadatos();
                        Multiplicacion();

                        break;

                    case 3:
                        Solicitadatos();
                        Resta();


                        break;

                    case 4:
                        Solicitadatos();
                        Division();


                        break;

                        
                }

            } while (op != 5);


            while (opcion != "n")
            {


                Console.WriteLine("digite monto para el prestamo");
                float monto = float.Parse(Console.ReadLine());

                Console.WriteLine("digite su salario");
                float salario = float.Parse(Console.ReadLine());

                if ((monto >= 100000) && (salario < 100000))
                {
                    Console.WriteLine("No se le puede prestar a 24 meses");
                }
                else if ((monto >= 100000) && (salario >= 100000))
                {
                    Console.WriteLine("Se le puede prestar a 6 meses ");
                }
                else if ((monto < 100000) && (salario >= 100000))
                {

                    Console.WriteLine("Se le puede prestar a 24 meses ");
                }
                Console.WriteLine("Desea continuar");
                opcion = Console.ReadLine();
            }


            Console.Read();
        }

        private static void Solicitadatos()
        {
            Console.WriteLine("Digite num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Diite num2");
            num2 = int.Parse(Console.ReadLine());

        }
        private static void Suma()
        {
            Console.WriteLine("Total suma: {0}", num1 + num2);
        }

        private static void Multiplicacion()
        {
            Console.WriteLine("Total suma: {0}", num1 * num2);
        }
        private static void Resta()
        {
            Console.WriteLine("Total suma: {0}", num1 - num2);
        }

        private static void Division()
        {
            Console.WriteLine("Total suma: {0}", num1 / num2);
        }
    }
}   