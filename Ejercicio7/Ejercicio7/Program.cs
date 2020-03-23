using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            int e;
            int i = 0;
            int j = 0;

            Console.WriteLine("Ingrese un numero: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un numero: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un numero: ");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un numero: ");
            e = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[] { a, b, c, d, e };
     
            int mayor = array1[i];
            int medio = array1[i];
            int menor = array1[i];

            for (i = 0; i < 5; i++)
             {
                 for (j = 0; j < 5; j++)
                 {
                     if (array1[i] > array1[j])
                     {
                        if (array1[i] > mayor)
                        {
                            mayor = array1[i];
                        }
                     }
                 }
             }
             Console.WriteLine("El mayor: " + mayor);



            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (array1[i] < array1[j])
                    {
                        if (array1[i] < menor)
                        { 
                            menor = array1[i];
                        }
                    }
                }
            }

            Console.WriteLine("El menor: " + menor);


            Array.Sort(array1);

            medio = array1[2];

            Console.WriteLine("El intermedio: " + medio);


            Console.ReadKey();

        }
    }
}
