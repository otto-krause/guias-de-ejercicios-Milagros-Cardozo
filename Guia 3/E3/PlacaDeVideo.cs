namespace E3
{
    public class PlacaDeVideo : Componente
    {
        int precio = 0;
        string zocalo = " ";

        public PlacaDeVideo(int precio, string zocalo)
        {
            this.precio = precio;
            this.zocalo  = zocalo ;
        }

        public int Precio()
        {
            return precio;
        }
        public bool EsCompatible(Motherboard mother)
        {
            return zocalo == mother.Zocalo; 
        }
    }
}