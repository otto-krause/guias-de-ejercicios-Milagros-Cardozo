using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Gotica
    {
       List<Habitantes> personas = new List<Habitantes>();
       List<Villanos> villanos = new List<Villanos>();
       public bool esLujosa()
       {
           return personas.Count(p => p.Clase == "Clase alta") >= personas.Count() / 2;
       }
       public List<Habitantes> sonLosMasTop()
       {
           return personas.OrderByDescending(p => p.Dinero).Take(10).ToList();
       }
       public void hacerMaldades()
       {
           villanos.ForEach(v => v.maldad(personas));
       }
       public List<Villanos> cantProfugos()
       {
           return villanos.Where(v => v.Estado == "Profugo").ToList();
       }
    }
}