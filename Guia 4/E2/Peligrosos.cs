namespace E2
{
    public class Peligrosos : Empresa
    {
        public override void NocheDeSustos()
        {
           respeto += 5;
        }
        public override void NocheDeRisas()
        {
           respeto -=2;
        }
    }
}