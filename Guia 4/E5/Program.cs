using System.Collections.Generic;
using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Serpensante serpensante=new Robot();
            Humano humano=new Humano();
            int opcion=1;
            string opcion1,estudia,tema="";
            do
            {
                Console.WriteLine("Ingrese la opcion que desea realizar\n"+
                "1)Para que el humano estudie\n"+
                "2)Para que el humano piense\n"+
                "3)Para que el cyborg estudie\n"+
                "4)Para que el cyborg piense\n"+
                "5)Para que el robot estudie\n"+
                "6)Para que el robot piense\n"+
                "Ingrese cualquier otra letra para salir\n"); 
                opcion1=Console.ReadLine();
                switch (opcion1)
                {
                    case "1":
                        serpensante=new Humano();
                        Console.WriteLine("ingrese lo que estudio");
                        estudia=Console.ReadLine();
                        serpensante.estudiar(estudia);
                        break;
                    case "2":
                        serpensante=new Humano();
                        Console.WriteLine("Ingrese el tema a pensar:");
                        tema=Console.ReadLine();
                        Console.WriteLine("Puntos de inteligencia:"+serpensante.pensar(tema));
                        break;
                    case "3":
                        serpensante=new Cyborg();
                        Console.WriteLine("ingrese lo que estudio");
                        estudia=Console.ReadLine();
                        serpensante.estudiar(estudia);
                        break;
                    case "4":
                        serpensante=new Cyborg();
                        Console.WriteLine("Puntos de inteligencia:"+serpensante.pensar(tema));
                        break;
                    case "5":
                        serpensante=new Robot();
                        Console.WriteLine("ingrese lo que estudio");
                        estudia=Console.ReadLine();
                        serpensante.estudiar(estudia);
                        break;
                    case "6":
                        serpensante=new Robot();
                        Console.WriteLine("Puntos de inteligencia:"+serpensante.pensar(tema));
                        break;
                    default:
                        opcion=2;
                        break;
                }
            }
            while(opcion==1);
        }
    }
}
