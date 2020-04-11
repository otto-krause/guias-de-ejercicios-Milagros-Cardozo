using System;

namespace E2
{
    class Matematicas
    {
        static void Main(string[] args)
        {
            int produ = 0, num1= 0, num2 = 0, i = 0, elegir = 0, result = 0, resto = 0;
            Console.WriteLine("Ingrese un numero: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 para multiplicar \n Ingrese 2 para dividir");
            elegir = Int32.Parse(Console.ReadLine());
            if (elegir == 1)
            {
                for (i = 0; i < num2; i++)
                    {
                        produ += num1;
                    }
            }
            Console.WriteLine("El producto entre los dos numeros es: {0}", produ);
            if (elegir == 2)
            {
                while(num1>num2)
                {
                    num1 -= num2;
                    result += 1;
                    resto = num1;
                }
            Console.WriteLine("La division es {0} y el resto {1} ", result, resto);
            }
        }
            
    }
}

