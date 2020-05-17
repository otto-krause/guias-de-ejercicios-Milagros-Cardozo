using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            Homero homero = new Homero(2);
            Lenny lenny = new Lenny();
            PatoBalancin patoBalancin = new PatoBalancin();
            MrBurns burns = new MrBurns();

            Planta planta = new Planta(99951, homero, burns);

            do
            {
                Console.WriteLine("1)Ver si la planta esra en peligro\n"+
                "2)Homero come dona\n"+
                "3)Homero compra donas\n"+
                "4)Lenny toma cerveza\n"+
                "5)Cambiar empleado por Homero\n"+
                "6)Cambiar empleado por Lenny\n"+
                "7)Cambiar empleado por Pato Balancin\n"+
                "8)Despojar a MrBurns de sus riquezas\n"+
                "9)Cargamento de barras de uranio\n");

                opcion = Console.ReadLine();

                switch(opcion)
                {
                    case "1":
                        Console.WriteLine(planta.estaEnPeligro());
                        break;
                    case "2":
                        homero.comer();
                        break;
                    case "3":
                        homero.comprar();
                        break;
                    case "4":
                        lenny.tomarCerveza();
                        break;
                    case "5":
                        planta.cambiarEmpleado(homero);
                        break;
                    case "6":
                        planta.cambiarEmpleado(lenny);
                        break;
                    case "7":
                        planta.cambiarEmpleado(patoBalancin);
                        break;
                    case "8":
                        burns.despojarDeSusRiquezas();
                        break;
                    case "9":
                        planta.masBarrasdeUranio();
                        break;
                    default:
                        opcion = "salir";
                        break;
                }
            }
            while (opcion!="salir");
      
        }
    }
}
