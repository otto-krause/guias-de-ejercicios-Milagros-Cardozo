using System;

namespace E3
{
    class Program
    {
        static void primo(int num)
        {
        int i=0,a=0;
        for(i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    a+=1;
                }
            }
            if(a==2)
            {
                Console.WriteLine("El número es primo");
            }
        }
        static void par(int num)
        {
            if(num%2==0)
            {
                Console.WriteLine("es par");
            }
        }
        static void Main(string[] args)
        {
            int num=0;
            Console.Write("ingresa un numero: ");
            num=Int32.Parse(Console.ReadLine());
            primo(num);
            par(num);
        }
    }
} 
