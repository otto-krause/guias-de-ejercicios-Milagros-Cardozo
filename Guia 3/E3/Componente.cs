namespace E3
{
    public interface Componente
    {
        public int Precio();
        public bool EsCompatible(Motherboard mother);
    }
}