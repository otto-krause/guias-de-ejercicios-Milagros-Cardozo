using System;
using System.Collections.Generic;

namespace E3
{
    public class Jugador
    {
        Consola pc = new PC();
        Consola cajax = new CajaX();
        Consola ponystatin4 = new Ponystatin4();
        Consola ponystatin4_salada = new Ponystation4_pro_SaladaEdition(); 
        public string nombreJugador;
        public List<Consola> consolas = new List<Consola>();
        public void AgregarJuego(string nomb, int año, string cons)
        {
            switch (cons)
            {
                case "PC":
                    pc.AgregarJuego(nomb, año, cons);
                break;
                case "CajaX":
                    cajax.AgregarJuego(nomb, año, cons);
                break;
                case "Ponystatin4":
                    ponystatin4.AgregarJuego(nomb, año, cons);
                break;
                case "Ponystation4_pro_SaladaEdition":
                    ponystatin4_salada.AgregarJuego(nomb, año, cons);
                break;
                default:

                break;
            }
        }
        public string LaMasUsada()
        {
            if(pc.RevisarPuntaje() > cajax.RevisarPuntaje() && pc.RevisarPuntaje() > ponystatin4.RevisarPuntaje() && pc.RevisarPuntaje() > ponystatin4_salada.RevisarPuntaje())
            {
                return "PC";
            }
            else
            {
                if(cajax.RevisarPuntaje() > ponystatin4_salada.RevisarPuntaje() && cajax.RevisarPuntaje() > ponystatin4.RevisarPuntaje())
                {
                    return "CajaX";
                }
                else
                {
                    if(ponystatin4_salada.RevisarPuntaje() > ponystatin4.RevisarPuntaje())
                    {
                        return "PonyStation 4";
                    }
                    else
                    {
                        return "PonyStation 4 Edicion Salada";
                    }
                }
            }
        }
        public string ElMasNuevo(string consolita)
        {
            Console.WriteLine("F");
            if(consolita=="PC")
            {
                Console.WriteLine("F");
                return "El juego nuevo de la PC es: " + pc.ElMasNuevo();
            }
            else
            {
                if(consolita=="CajaX")
                {
                    return "El juego nuevo de la CajaX es: " + cajax.ElMasNuevo();
                }
                else
                {
                    if(consolita=="PonyStation 4")
                    {
                        return "El juego nuevo de la PonyStation 4 es: " + ponystatin4.ElMasNuevo();
                    }
                    else
                    {
                        if(consolita=="PonyStation 4: Edicion Salada")
                        {
                            return "El juego nuevo de la PonyStation 4: Edicion Salada es: " + ponystatin4_salada.ElMasNuevo();
                        }
                    }
                }
                return consolita;
            }
        }
        public string ElMasViejo(string consolita)
        {
           if(consolita=="PC")
            {
                return "El juego viejo de la PC es: " + pc.ElMasViejo();
            }
            else
            {
                if(consolita=="CajaX")
                {
                    return "El juego viejo de la CajaX es: " + cajax.ElMasViejo();
                }
                else
                {
                    if(consolita=="PonyStation 4")
                    {
                        return "El juego viejo de la PonyStation 4 es: " + ponystatin4.ElMasViejo();
                    }
                    else
                    {
                        if(consolita=="PonyStation 4: Edicion Salada")
                        {
                            return "El juego viejo de la PonyStation 4: Edicion Salada es: " + ponystatin4_salada.ElMasViejo();
                        }
                    }
                }
                return consolita;
            }
        }
    }
}