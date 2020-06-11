namespace E2
{
    public class Amigables : Empresa
    {
        public override void NocheDeSustos()
        {
           respeto += 7;
        }
        public override void NocheDeRisas()
        {
           respeto -= 1;
        }
    }
}