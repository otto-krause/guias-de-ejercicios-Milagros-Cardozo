using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amigables amigo = new Amigables();
            Peligrosos peligro = new Peligrosos();

            int opcion = 1;
            string opcion1 = "";

            do
            {
                Console.WriteLine("Ingrese la opcion que desea realizar\n"+
                "[1]Hacer que los montruos amigables asusten\n"+
                "[2]Hacer que los montruos amigables hagan reir\n"+
                "[3]Hacer que los montruos peligrosos asusten\n"+
                "[4]Hacer que los montruos peligrosos hagan reir\n"+
                "[5]Ver la energia total de la empresa");
                opcion1 = Console.ReadLine();
                switch (opcion1)
                {
                    case "1":
                        amigo.NocheDeSustos();
                    break;
                    case "2":
                        amigo.NocheDeRisas();
                    break;
                    case "3":
                        peligro.NocheDeSustos();
                    break;
                    case "4":
                        peligro.NocheDeRisas();
                    break;
                    case "5":
                        Console.WriteLine("La energia total de la empresa por parte de los Amigables es: " + amigo.Respeto());
                        Console.WriteLine("Y los Peligrosos es: " + peligro.Respeto());
                    break;
                    default:
                        opcion=0;
                    break;
                }

            } while (opcion==1);
        }
    }
}
