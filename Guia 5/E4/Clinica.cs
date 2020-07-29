using System.Collections.Generic;
using System.Linq;
using System;

namespace E4
{
    public class Clinica
    {
        List <Medico> medicos = new List<Medico>();
        public void Consulta(string especialidad)
        {
            medicos.Add(new Medico("Milagros", "Cardozo", "Neurologia", 3));
            medicos.Add(new Medico("Elver", "Galarga", "Traumatologia", 53));
            medicos.Add(new Medico("Chachi", "Pistachi", "Psiquiatria", 13));
            medicos.Add(new Medico("Ladi", "Istraida", "Cardiologia", 25));
            medicos.Add(new Medico("Emilia", "Lopez", "Raumotologia", 32));
            medicos.Add(new Medico("Carlito", "Perez", "Radiologia", 58));

            medicos.Where(medicos => medicos.Especialidad == especialidad&&true == medicos.EstaDisponible()).ToList().ForEach(medicos => Console.WriteLine("El medico " + medicos.Nombre + "lo atendera"));

            medicos.Where(medicos => medicos.Especialidad == especialidad&&false == medicos.EstaDisponible()).ToList().ForEach(medicos=>Console.WriteLine("intente de nuevo más tarde"));
        }
    }
}