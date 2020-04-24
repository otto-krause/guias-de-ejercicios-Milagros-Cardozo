using System;
using System.Collections.Generic;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=1,opcion=1,cant=0,cant50=0; 
            List<int> numeros = new List<int>();
            Console.WriteLine("Ingrese los numeros para crear la lista, si desea termminar la secuencia ingrese 0");    
            do
            {
               num=Int32.Parse(Console.ReadLine());
               if(num!=0)
               {
                   numeros.Add(num);
               }
               else
               {
                   opcion=2;
               }
            }
            while(opcion==1);
            Console.WriteLine("Los numeros son \n");
            foreach (int nume in numeros)
            {
                Console.WriteLine(nume);
                if(nume >= 50)
                {
                    cant50 += 1;
                }
                cant += 1;
            }
            Console.WriteLine("La cantidad de numeros ingresados son: "+numeros.Count);
            Console.WriteLine("El primer numero es: "+numeros[0]+", el ultimo numero es: "+numeros[cant-1]+" y la cantidad de numeros mayores a 50 es: "+cant50);
        }
    }
}
