using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Pandilla
    {
        List<Villanos> pandilla;
        public Pandilla(List<Villanos> pandilla)
        {
            this.pandilla = pandilla;
        }
        public int sumatoriaPoder()
        {
            return pandilla.Sum(v => v.Poder());
        }
    }
}