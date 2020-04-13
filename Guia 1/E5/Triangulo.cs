namespace E5
{
    public class Triangulo
    {
        public bool EsEscaleno(int tria)
        {
            return tria==3;
        }
        public bool EsIsosceles(int tria)
        {
            return tria==2;
        }
        public bool EsEquilatero(int tria)
        {
            return tria==1;
        }
        public bool EsTrianguloRectangulo(int estrar)
        {
            return estrar==1;
        }
    }
}