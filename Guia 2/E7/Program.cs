using System;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            Argentina argentina = new Argentina();
            string opcion = " ";
            do
            {
                Console.WriteLine("Que desea hacer?: \n"+
                "[1]Bajar el precio del petroleo\n"+
                "[2]Hacer que Millei hable por TV\n"+
                "[3]Coronavairas\n"+
                "[4]Saber el estado de la inflaccion\n"+
                "[5]Saber si Argentina esta en default\n"+
                "[0]Salir");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        argentina.BajarElPrecoiDelPetroleo();
                    break;
                    case "2":
                        argentina.MillaiHablaPorTV();
                    break;
                    case "3":
                        argentina.CoronaVairas();
                    break;
                    case "4":
                        Console.WriteLine("El estado de la inflaccion es: " + argentina.EstadoDeInflaccion());
                    break;
                    case "5":
                        Console.WriteLine("La argentina esta en default? " + argentina.ArgentinaEnDefault());
                    break;
                    case "0":
                        opcion = "0";
                    break;
                }
            }
            while(opcion!="0");
        }
    }
}
