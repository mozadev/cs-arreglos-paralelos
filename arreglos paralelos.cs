using System;

namespace pregunta1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayTema = new int[30];
            int[] arrayPuntaje = new int[30];
            GenerarMostrarDatos(arrayTema, arrayPuntaje);
            Lista_encimaDelPromedio(arrayTema, arrayPuntaje);
            devuelve_mayor(arrayTema, arrayPuntaje);

        }

        static void GenerarMostrarDatos(int[] arrayTema, int[] arrayPuntaje)
        {
            Random rnd = new Random();
            Console.WriteLine("tema => puntaje");
            for (int i = 0; i < 30; i++)
            {
                arrayTema[i] = rnd.Next(1, 4);// 1,2...29
                arrayPuntaje[i] = rnd.Next(0, 50);// 1,2...29
                Console.Write(arrayTema[i] + "=>" + arrayPuntaje[i]);
                Console.WriteLine();
            }
          
            Console.WriteLine();
        }


        static void Lista_encimaDelPromedio(int[] arrayTema, int[] arrayPuntaje)
        {
            double promedio;
            double suma = 0;
            for (int i = 0; i < 30; i++)
            {
                suma = suma + arrayPuntaje[i];

            }
            promedio = suma / 30;
            Console.WriteLine("promedio: " + promedio);
            Console.WriteLine("puntajes mayores al promedio:");
            Console.WriteLine("tema => puntaje");

            for (int i = 0; i < 30; i++)
            {
                if (arrayPuntaje[i] > promedio)
                {
                    Console.Write(arrayTema[i] + "=>" + arrayPuntaje[i]);

                    Console.WriteLine();
                }

            }
            Console.WriteLine();

        }

        static void devuelve_mayor(int[] arrayTema, int[] arrayPuntaje)
        {

            int puntajeMayor = 0;
            for (int i = 0; i < 30; i++)
            {
                if (arrayPuntaje[i] > puntajeMayor)
                {
                    puntajeMayor = arrayPuntaje[i];
                }
            }

            Console.Write("el puntaje mayor es: " + puntajeMayor);

        }

    }
}