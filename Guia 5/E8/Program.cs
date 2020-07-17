using System;
using System.Linq;
using System.Collections.Generic;

//Crear la clase Matematicas2, la cual recibe listas de números enteros y devuelve:
//Primos: devuelve solo los números que son primos.
//Pares: devuelve solo los números que son pares.
//Aplanar: muestra la lista sin repetidos.
//Suma: devuelve la sumatoria de todos los números.
//SumaDePrimos: devuelve la sumatoria de todos los números que son primos.
//Máximo: devuelve el número más grande.
//Minimo: Devuelve el número más chico.


namespace E8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Matematicas2 mate = new Matematicas2();
            int num = 1, opcion = 1;

            Console.WriteLine("Ingrese una lista de numeros: ");
            do
            {
                num = Int32.Parse(Console.ReadLine());
                numeros.Add(num);
            }
            while(num != 0);

            numeros.Remove(0);
            
            do
            {
                Console.WriteLine("Que desea hacer con esta lista?\n" +
                "[1]Devolver solamente los numeros primos\n"+
                "[2]Devolver solamente los numeros pares\n"+
                "[3]Mostar la lista sin numeros repetidos\n"+
                "[4]Sumar todos los numeros\n"+
                "[5]Sumar todos los numeros primos\n"+
                "[6]Devolver el numero mas grande\n"+
                "[7]Devolver el numero mas chico\n" +
                "Ingrese 0 para terminar");
                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Numeros primos: ");
                        mate.Primos(numeros, opcion).ForEach(i => Console.WriteLine(i));
                    break;
                    case 2:
                        Console.WriteLine("Numeros Pares: ");
                        mate.ParYDistinto(numeros, opcion).ForEach(i => Console.WriteLine(i));
                    break;
                    case 3:
                        Console.WriteLine("Lista sin numeros repetidos: ");
                        mate.ParYDistinto(numeros, opcion).ForEach(i => Console.WriteLine(i));
                    break;
                    case 4:
                        Console.WriteLine("Suma de todos los numeros: " + mate.Suma(numeros, opcion));
                    break;
                    case 5:
                        Console.WriteLine("Suma de todos los numeros primos: " + mate.SumaPrimos(numeros));
                    break;
                    case 6:
                        Console.WriteLine("Numero mas grande: " + mate.Suma(numeros, opcion));
                    break;
                    case 7:
                        Console.WriteLine("Numero mas chico: " + mate.Suma(numeros, opcion));
                    break;
                    case 0:
                        opcion = 0;
                    break;
                }
            }
            while(opcion != 0);
        }
    }
}
