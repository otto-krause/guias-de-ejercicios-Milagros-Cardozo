using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] vector = new int [10];
            int suma = 0;
            int prom = 0;
            int pasada = 0;
            int aux = 0;
            int cambio = 0;
            int i = 0;
            int min = 1000000000;
            for(i = 0; i < 10; i++)
            {
                Console.WriteLine ("Ingrese un numero: ");
                vector[i] = Int32.Parse(Console.ReadLine());
                suma += vector [i];
            }
            do
                {
                    pasada++;
                    cambio = 0;
                    for (i = 0; i<(10 - pasada); i++)
                    {
                        if(vector[i] < vector[i+1])
                        {
                            aux = vector[i];
                            vector[i] = vector[i+1];
                            vector[i+1] = aux;
                            cambio = 1;
                        }
                    }
                }
            while(cambio == 1);
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("\t" + vector[i]);
                if (vector[i] < min)
                    min = vector[i]; 
            }

            prom = suma / 10;
            Console.WriteLine ("El menor numero es " + min);
            Console.WriteLine ("La suma es: " + suma);
            Console.WriteLine ("El promedio de todos los numeros es: " + prom);
        }
    }
}
