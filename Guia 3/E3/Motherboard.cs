namespace E3
{
    public class Motherboard
    {
        private string nombre;
        private string zocalo;
        private int frecuenciaMaxima;
        private int frecuenciaMinima;
        private string conectores;

        public Motherboard(string nombre, string zocalo, int frecuenciaMaxima, int frecuenciaMinima, string conectores)
        {
            this.nombre = nombre;
            this.zocalo = zocalo;
            this.frecuenciaMaxima = frecuenciaMaxima;
            this.frecuenciaMinima = frecuenciaMinima;
            this.conectores = conectores;
        }

        public string Nombre { get => nombre; }
        public string Zocalo { get => zocalo; }
        public int FrecuenciaMaxima { get => frecuenciaMaxima; }
        public int FrecuenciaMinima { get => frecuenciaMinima; }
        public string Conectores { get => conectores; }
    }
}