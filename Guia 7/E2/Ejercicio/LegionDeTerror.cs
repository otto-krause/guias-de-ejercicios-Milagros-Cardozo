namespace Ejercicio
{
    public abstract class LegionDeTerror
    {
        protected int caramelos;
        protected int capacidadParaAsustar;
        protected Maquillaje maquillaje;
        protected Traje traje;
        public Maquillaje Maquillaje { get => maquillaje; }
        public Traje Traje { get => traje; }

        public int CapacidadParaAsustar { get => capacidadParaAsustar; }
        public int Caramelos { get => caramelos; set => caramelos = value; }

        public LegionDeTerror()
        {
        }
        public abstract void Asustarlos(Adulto adulto);
        public bool caramelosMas15()
        {
            return caramelos > 15;
        }
        public void CaramelosLider(int cant)
        {
            caramelos += cant;
        }
    }
}