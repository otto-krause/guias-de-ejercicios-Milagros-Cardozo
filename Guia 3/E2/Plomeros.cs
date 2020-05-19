
namespace E2
{
    public class Plomeros : Contratista
    {
        public int horas;
        public Plomeros(){
        }
        public void Trabajar(int horas)
        {
            this.horas = horas;
        }
        public int Cobrar()
        {
            return horas*80;
        }
    }
}