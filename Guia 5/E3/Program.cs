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

            Armadura armaduraDeMills = new Armadura("Elfo", "Bronce");
            caballeros.Add(new CaballerosDelZodiaco ("Mills", "Hades", armaduraDeMills, "Libra"));

            Armadura armaduraDeMarin = new Armadura ("Aguila", "Plata");
            caballeros.Add(new CaballerosDelZodiaco ("Marin", "Atena", armaduraDeMarin, "Cancer"));

            Armadura armaduraDeToma = new Armadura ("Icaro", "Oro");
            caballeros.Add(new CaballerosDelZodiaco ("Toma", "Artemis", armaduraDeToma, "Capricornio"));

            Armadura armaduraDeAioria = new Armadura ("Leon", "Oro");
            caballeros.Add(new CaballerosDelZodiaco ("Aioria", "Atena", armaduraDeAioria, "Leo"));

            Armadura armaduraDePerseo = new Armadura ("Oceano", "Plata");
            caballeros.Add(new CaballerosDelZodiaco ("Perseo", "Poseidon", armaduraDePerseo, "Acuario"));

            Console.WriteLine("Armaduras que protegen a Athena: ");
            
            List<CaballerosDelZodiaco> armadurasDeAthena = caballeros.Where(caballeros => caballeros.DiosQueProtege == "Atena").ToList();
            armadurasDeAthena.ForEach(armaduras => Console.WriteLine(armaduras.getArmadura()));


            Console.WriteLine("Dioses: ");

            List<string> dioses=new List<string>();
            caballeros.ForEach(i => dioses.Add(i.DiosQueProtege));

            var dioseSinRepetir = dioses.Distinct();

            foreach (var i in dioseSinRepetir) 
            {
                Console.WriteLine(i); 
            }


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
            signosconC.ForEach(i => Console.WriteLine("Signos del zodiaco que comienzan con 'C': " + i));
        }
    }
}