using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado programador = new Programador(0);
            Empleado rrhh = new RRHH(0);
            Empleado admin = new Administrativo(0);

            int opcion=1, plata = 0;
            string opcion1="", tipo = "";
            do
            {
                Console.WriteLine("Ingrese la opcion que desea realizar\n" +
                "[1]Para depositar con un RRHH\n" +
                "[2]Para depositar con un Programador\n" +
                "[3]Para depositar con un Administrativo\n" +
                "[4]Para extraer de RRHH\n" +
                "[5]Para extraer de Programador\n" +
                "[6]Para extraer de Administrativo\n");
                opcion1 = Console.ReadLine();
                switch(opcion1)
                {
                    case "1":
                        Console.WriteLine("Ingrese si la persona es confiable o no\n");
                        tipo = Console.ReadLine();
                        Console.WriteLine("La caja bancaria del RRHH es "+rrhh.Depositar(tipo));
                    break;
                    case "2":
                        Console.WriteLine("Ingrese el rango del programador\n"+
                        "[1]Para junior"+
                        "[2]Para semi-senior" +
                        "[3]Para senior");
                        tipo = Console.ReadLine();
                        Console.WriteLine("La caja bancaria del Programador es " + programador.Depositar(tipo));
                    break;
                    case "3":
                        Console.WriteLine("La caja bancaria del Administrativo es " + admin.Depositar(tipo));
                    break;
                    case "4":
                        Console.WriteLine("Ingrese cuanta plata va a extraer\n");
                        plata = Int32.Parse(Console.ReadLine());
                        rrhh.Extraer(plata);
                    break;
                    case "5":
                        Console.WriteLine("Ingrese cuanta plata va a extraer\n");
                        plata = Int32.Parse(Console.ReadLine());
                        programador.Extraer(plata);
                    break;
                    case "6":
                        Console.WriteLine("Ingrese cuanta plata va a extraer\n");
                        plata = Int32.Parse(Console.ReadLine());
                        admin.Extraer(plata);
                    break;
                    default:
                        opcion = 0;
                    break;
                }
            }
            while(opcion==1);
        }
    }
}
