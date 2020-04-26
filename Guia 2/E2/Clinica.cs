using System;
using System.Collections.Generic;

namespace E2
{
    public class Clinica
    {
        public void especi(string especialidad)
        {
            List<Medico> medicos = new List<Medico>();
            medicos.Add(new Medico("Milagros", "Cardozo", "Neurologia", 49));
            medicos.Add(new Medico("Elver", "Galarga", "Traumatologia", 53));
            medicos.Add(new Medico("Chachi", "Pistachi", "Psiquiatria", 23));
            medicos.Add(new Medico("Ladi", "Istraida", "Cardiologia", 28));
            medicos.Add(new Medico("Emilia", "Lopez", "Raumotologia", 38));
            medicos.Add(new Medico("Carlito", "Perez", "Radiologia", 58));
            for(int i=0;i<6;i++)
            {
                if(especialidad==medicos[i].especialidad1())
                {
                    if(medicos[i].Estadisponible())
                    {
                        Console.WriteLine("El medico "+medicos[i].nombre1()+" "+medicos[i].apellido1()+" lo atendera");
                    }
                    else
                    {
                        Console.WriteLine("Por el momento no tenemos mas turnos, vuelva mas tarde");
                    }
                }
            }
        }
    }
        
}
  
