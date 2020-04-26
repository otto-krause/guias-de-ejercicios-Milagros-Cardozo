using System;

namespace E7
{
    public class Celular
    {
        bool NFC,Bluethoot;
        int MB=5000,app=8,disponible=0;
        public Celular(bool NFC,bool Bluethoot)
        {
            this.NFC=NFC;
            this.Bluethoot=Bluethoot;
        }
        public void MemoriaDisponible(int total)
        {
            disponible=MB-(70*app+total);
            Console.WriteLine("Tu memoria es de 5000 MB y tiene disponible: "+disponible);
        }   
        public bool TeCargaLaSUBE()
        {
            return NFC;
        }     
    }
}