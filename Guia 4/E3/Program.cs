using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador();
            PC pc = new PC();
            Ponystatin4 pony4 = new Ponystatin4();
            Ponystation4_pro_SaladaEdition ponysalada = new Ponystation4_pro_SaladaEdition();
            CajaX cajax = new CajaX();

            int opcion1 = 1, horas = 0, año = 0;
            string opcion = "", nomb = "", cons = "", consolita = "";

            do
            {
                Console.WriteLine("Ingrese la opcion que desea elegir\n" +
                "[1]Para Ingresar un juego \n" +
                "[2]Para jugar\n" +
                "[3]Para revisar el puntaje de las consolas\n" +
                "[4]Para saber cual es el juego mas nuevo\n" +
                "[5]Para saber cual es el juego mas viejo\n");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese nombre del juego");
                        nomb = Console.ReadLine();
                        Console.WriteLine("Ingrese el año del juego");
                        año = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la consola del juego");
                        cons = Console.ReadLine();
                        jugador.AgregarJuego(nomb,año,cons);
                    break;
                    case "2":
                        Console.WriteLine("Ingrese la consola en la que jugo\n");
                        consolita = Console.ReadLine();
                        Console.WriteLine("Ingrese la cantidad de horas que jugo\n");
                        horas = Int32.Parse(Console.ReadLine());
                        if(consolita=="PC")
                        {
                            pc.Jugar(horas);
                        }
                        else
                        {
                            if(consolita=="CajaX")
                            {
                                cajax.Jugar(horas);
                            }
                            else
                            {
                                if(consolita=="PonyStation 4")
                                {
                                    pony4.Jugar(horas);
                                }
                                else
                                {
                                    if(consolita=="PonyStation 4: Edicion Salada")
                                    {
                                        ponysalada.Jugar(horas);
                                    }
                                }
                            }
                        }
                    break;
                    case "3":
                        Console.WriteLine("Los puntos de la Pc son: \n" + pc.RevisarPuntaje(), 
                        "Los puntos de la CajaX son: \n" + cajax.RevisarPuntaje(),
                        "Los puntos de la PonyStation 4 son: \n" + pony4.RevisarPuntaje(),
                        "Los puntos de la PonyStation 4: Edicion Salada son: \n" + ponysalada.RevisarPuntaje());
                    break;
                    case "4":
                        Console.WriteLine("Ingrese la consola\n");
                        consolita = Console.ReadLine();
                        Console.WriteLine(jugador.ElMasNuevo(consolita));

                    break;
                    case "5":
                        Console.WriteLine("Ingrese la consola\n");
                        consolita = Console.ReadLine();
                        Console.WriteLine(jugador.ElMasNuevo(consolita));
                    break;
                    default:
                        opcion1=0;
                    break;
                }
            } while (opcion1==1);
        }
    }
}
