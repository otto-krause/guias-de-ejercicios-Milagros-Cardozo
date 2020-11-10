using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Pandilla
    {
        List<Villano> pandilla;
        public List<Villano> Pandillas { get => pandilla; }

        public Pandilla(List<Villano> pandilla)
        {
            this.pandilla = pandilla;
        }
        public int sumatoriaPoder()
        {
            return pandilla.Sum(v => v.Poder());
        }
    }
}