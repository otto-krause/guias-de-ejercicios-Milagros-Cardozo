using System;
using System.Linq;
using System.Collections.Generic;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CaballerosDelZodiaco> caballeros = new List<CaballerosDelZodiaco>();

            caballeros.Add(new CaballerosDelZodiaco ("Mills", "Hades", "Elfo", "Bronce", "Libra"));
            caballeros.Add(new CaballerosDelZodiaco ("Marin", "Atena", "Aguila", "Plata", "Cancer"));
            caballeros.Add(new CaballerosDelZodiaco ("Toma", "Artemis", "Icaro", "Oro", "Capricornio"));
            caballeros.Add(new CaballerosDelZodiaco ("Aioria", "Atena", "Leon", "Oro", "Leo"));
            caballeros.Add(new CaballerosDelZodiaco ("Perseo", "Poseidon", "Oceano", "Plata", "Acuario"));

            caballeros.Where(caballero => caballero.DiosQueProtege == "Athena")
            .ToList()
            .ForEach(caballero => Console.WriteLine(caballero.ArmaduraNombre));


            caballeros.ForEach(caballero => Console.WriteLine(caballero.DiosQueProtege
            .Distinct()
            .ToList()));


            List<string> signos = new List<string>();
            caballeros.ForEach(i => signos.Add(i.SignoZodiacal));

            List <string> signosconC = new List<string>();



            foreach (var i in signos)
            {
                if(i.StartsWith("C"))
                {
                    signosconC.Add(i);
                }
            }

            Console.WriteLine("Los signos que empiezan con C son: ");

            foreach (var i in signosconC)
            {
                Console.WriteLine(signosconC);
            }

        }
    }
}