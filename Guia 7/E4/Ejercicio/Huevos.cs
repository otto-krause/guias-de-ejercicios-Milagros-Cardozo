namespace Ejercicio
{
    public class Huevos
    {
        private int peso;

        public Huevos(int peso)
        {
            this.peso = peso;
        }
        public int Fuerza()
        {
            return peso;
        }
        public void seRompio(IslaPajaro isla)
        {
            Pajaros pajaro = new PajarosComunes(0);
            isla.rompioHuevo(pajaro);
        }
    }
}