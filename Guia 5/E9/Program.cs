using System;
using System.Linq;
using System.Collections.Generic;

//Crear un programa que le permita al usuario ingresar tantos números como desee hasta que ingrese un 0, lo que se considerará como la finalización del ingreso. Estos números deben ser almacenados en una lista.

//En base al programa anterior, realizar los siguientes ejercicios:

//Mostrar por pantalla todos los números.
//Mostrar cuántos números impares fueron ingresados.
//Mostrar cúal fue el primer número par.
//Mostrar los números que son mayores a 50.
//Mostrar cuántos números son mayores a 50.


namespace E9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int opcion = 1;

            Console.WriteLine("Ingrese una lista de numeros: ");
            do
            {
                opcion = Int32.Parse(Console.ReadLine());
                numeros.Add(opcion);
            }
            while(opcion != 0);

            numeros.Remove(0);

            Console.WriteLine("Lista de numeros: ");
            numeros.ForEach(numero => Console.WriteLine(numero));

            int cantidadDeImpares = numeros.Count(numero => numero%2 != 0);
            Console.WriteLine("Cantidad de numeros impares: " + cantidadDeImpares);

            int PrimerNumeroPar = numeros.OrderByDescending(numero => numero%2 == 0).First();
            Console.WriteLine("Primer numero par: " + PrimerNumeroPar);

            Console.WriteLine("Numeros mayores a 50: ");
            numeros.Where(numero => numero > 50)
            .ToList()
            .ForEach(numero => Console.WriteLine(numero));

            Console.WriteLine("Numeros menores a 50: ");
            numeros.Where(numero => numero < 50)
            .ToList()
            .ForEach(numero => Console.WriteLine(numero));
        }
    }
}
