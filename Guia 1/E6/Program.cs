using System;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=0,num2=0,opcion=0,opcion1=1;
            Matematica mate = new Matematica();
            do
            {
                Console.WriteLine("Que desea hacer?\n 1)Fibonacci\n2)Factorial\n3)Mayor\n4)Menor\n5)Cubo");
                opcion=Int32.Parse(Console.ReadLine());
                if(opcion==1)
                {
                    Console.Write("Cuantos numeros de la secuencia quiere ver?: ");
                    num1=Int32.Parse(Console.ReadLine());
                    mate.Fibonacci(num1);
                }
                if(opcion==2)
                {
                    Console.Write("Cual numero querie saber su factorral?: ");
                    num1=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("La factorial es : "+mate.Factorial(num1));
                }
                if(opcion==3)
                {

                    Console.Write("ingrese un numero: ");
                    num1=Int32.Parse(Console.ReadLine());
                    Console.Write("ingrese otro numero: ");
                    num2=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("El mayor es : "+mate.Mayor(num1,num2));
                }
                if(opcion==4)
                {
                    Console.Write("ingrese un numero: ");
                    num1=Int32.Parse(Console.ReadLine());
                    Console.Write("ingrese otro numero: ");
                    num2=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("El menor es : "+mate.Menor(num1,num2));
                }
                if(opcion==5)
                {
                    Console.Write("ingrese un numero: ");
                    num1=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("El cubo es : "+mate.Cubo(num1));
                }
                Console.Write("¿quiere realizar otra operacion?\n1)Si\n2)No\n");
                opcion1=Int32.Parse(Console.ReadLine());    
            }while(opcion1==1);
        }
    }
}