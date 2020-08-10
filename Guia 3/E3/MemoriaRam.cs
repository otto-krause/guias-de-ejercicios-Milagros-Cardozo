namespace E3
{
    public class MemoriaRam : Componente
    {
        int precio = 0;
        int frecuencia = 0;

        public MemoriaRam(int precio, int frecuencia)
        {
            this.precio = precio;
            this.frecuencia = frecuencia;
        }

        public int Precio()
        {
            return precio;
        }
        public bool EsCompatible(Motherboard mother)
        {
            return frecuencia >= mother.FrecuenciaMaxima && frecuencia <= mother.FrecuenciaMinima;
        }
    }
}