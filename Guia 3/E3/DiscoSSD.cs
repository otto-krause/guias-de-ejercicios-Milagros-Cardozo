namespace E3
{
    public class DiscoSSD : Componente
    {
        int precio = 0;
        string conector = " ";

        public DiscoSSD(int precio, string conector)
        {
            this.precio = precio;
            this.conector = conector;
        }

        public int Precio()
        {
            return precio;
        }
        public bool EsCompatible(Motherboard mother)
        {
            return conector == mother.Conectores; 
        }
    }
}