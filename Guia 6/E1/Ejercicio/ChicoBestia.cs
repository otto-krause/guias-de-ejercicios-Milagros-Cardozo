namespace Ejercicio
{
    public class ChicoBestia : Titan
    {
        public string color;

        public ChicoBestia(string color, int tristeza) : base(tristeza)
        {
            this.color = "Verde";
            this.tristeza = 2;
        }

        public override void LlorarPorRocop()
        {
            if(tristeza > 8)
            {
                tristeza -= 8;
            }
        }
        public override void comerPizza()
        {
            this.color = "Amarillo patito fluorescente de las montañas del himalaya amazónico";
        }
        public override bool estaTriste()
        {
            return tristeza > 5;
        }
        public override int Poder()
        {
            return color.Length * 13;
        }
        public void CambiarDeColor(string color)
        {
            this.color = color;
            tristeza += 4;
        }
        public int NivelDeTristeza()
        {
            return tristeza;
        }
    }
}