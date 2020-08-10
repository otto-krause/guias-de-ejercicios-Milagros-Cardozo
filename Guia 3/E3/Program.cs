using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            PC pc = new PC();
            string opcion = "", zocalo = " ", conector = "";
            int precio = 0, frecuencia = 0;
            do
            {
                Console.WriteLine("Ingrese los componentes, debe ingresar al menos un componente de cada tipo\n"+
                "[1]Ingresar DiscoSSD\n"+
                "[2]Ingresar DiscoHDD\n"+
                "[3]Lectora de CD\n"+
                "[4]Placa de video\n"+
                "[5]Ingresar Memoria Ram\n"+
                "Ingrese 0 si quiere terminar");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el precio del componente: ");
                        precio = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el conector del componente: ");
                        conector = Console.ReadLine();
                        DiscoSSD discoSSD = new DiscoSSD(precio, conector);
                        pc.NuevoComponente(discoSSD);
                    break;
                    case "2":
                        Console.WriteLine("Ingrese el precio del componente: ");
                        precio = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el tipo de conector del componente: ");
                        conector = Console.ReadLine();
                        DiscoHDD discoHDD = new DiscoHDD(precio, conector);
                        pc.NuevoComponente(discoHDD);
                    break;
                    case "3":
                        Console.WriteLine("Ingrese el precio del componente: ");
                        precio = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el tipo de conector del componente: ");
                        conector = Console.ReadLine();
                        LectoraDeCD lectoraDeCD = new LectoraDeCD(precio, conector);
                        pc.NuevoComponente(lectoraDeCD);
                    break;
                    case "4":
                        Console.WriteLine("Ingrese el precio del componente: ");
                        precio = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el zocalo del componente: ");
                        zocalo = Console.ReadLine();
                        PlacaDeVideo placaDeVideo = new PlacaDeVideo(precio, zocalo);
                        pc.NuevoComponente(placaDeVideo);
                    break;
                    case "5":
                        Console.WriteLine("Ingrese el precio del componente: ");
                        precio = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la frecuencia del componente: ");
                        frecuencia = Int32.Parse(Console.ReadLine());
                        MemoriaRam memoriaRam = new MemoriaRam(precio, frecuencia);
                        pc.NuevoComponente(memoriaRam);
                    break;
                    case "0":
                     opcion = "0";
                    break;
                }
            }
            while(opcion != "0");

            do
            {
                Console.WriteLine("Que desea hacer?\n"+
                "[1]Saber el precio total\n"+
                "[2]Saber si todos los componentes son compatibles\n"+
                "Ingrese 0 para salir");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("El precio total es: " + pc.PrecioTotal());
                    break;
                    case "2":
                        Console.WriteLine("La pc se pudo armar? " + pc.SePuedeArmar());
                    break;
                    case "0":
                     opcion = "0";
                    break;
                }
            }
            while(opcion != "0");
        }
    }
}
