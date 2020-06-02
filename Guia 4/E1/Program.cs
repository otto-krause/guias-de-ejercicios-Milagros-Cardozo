using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animales perrito = new Perro(30);
            Animales pajarito = new Pajaro(30);

            int opcion = 1;
            string opcion1 = "";

            do
            {
                Console.WriteLine("Ingrese la opcion que desea realizar\n"+
                "[1]Para que el perro coma\n"+
                "[2]Para que el perro juegue\n"+
                "[3]Para que el pajaro coma\n"+
                "[4]Para que el pajaro juegue\n"+
                "[5]Para que el perro duerma\n"+
                "[6]Para que el pajaro duerma\n");
                opcion1 = Console.ReadLine();
                switch(opcion1)
                {
                    case "1":
                        Console.WriteLine("La energia que tiene el perro: " + perrito.Comer());
                    break;
                    case "2":
                        Console.WriteLine("La energia que tiene el perro: " + perrito.Jugar());
                    break;
                    case "3":
                        Console.WriteLine("La energia que tiene el pajaro es: " +pajarito.Comer());
                    break;
                    case "4":
                        Console.WriteLine("La enrgia que tiene el pajaro es: " + pajarito.Jugar());
                    break;
                    case "5":
                        perrito.Dormir();
                        Console.WriteLine("El perro se fue a dormir");
                    break;
                    case "6":
                        pajarito.Dormir();
                        Console.WriteLine("El pajaro se fue a dormir");
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
