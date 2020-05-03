namespace E3
{
    public class Figurita
    {
        string nombre;
        private string posicion;
        public string Posicion { get => posicion; }
        string pais;
        private int numfigu;

        public int Numfigu { get => numfigu; }
        public Figurita (string nombre, string posicion, string pais, int numfigu)
        {
            this.nombre =nombre;
            this.posicion = posicion;
            this.pais = pais;
            this.numfigu = numfigu;
        }
    }
}