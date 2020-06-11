using System.Collections.Generic;

namespace E2
{
    public abstract class Empresa
    {
        List<string> montruos = new List<string>();
        protected int respeto;
        public Empresa()
        {
        
        }
        public abstract void NocheDeSustos();
        public abstract void NocheDeRisas();
        public int Respeto()
        {
            return respeto;
        }
    }
}