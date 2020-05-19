namespace E2
{
    public class Albañiles : Contratista
    {
        private int edad;
        private bool titulo;
        private int horas;

        public Albañiles(int edad, bool titulo)
        {
            this.edad = edad;
            this.titulo = titulo;
        }
        public void Trabajar (int horas)
        {
            this.horas = horas;
        }
        public int Cobrar()
        {
            if (edad>20 && edad<30)
            {
                if(titulo == true)
                {
                    return (horas * 50) + 50;
                }
                else
                {
                    return horas*50;
                }
            }
            else
            {
                if(edad>30 && edad<50)
                {
                    if(titulo == true)
                    {
                        return (horas*90)+50;
                    }
                    else
                    {
                        return horas*90;
                    }
                }
                else
                {
                    if(edad>50)
                    {
                        if(titulo == true)
                        {
                            return (horas*120)+50;
                        }
                        else
                        {
                            return horas*120;
                        }
                    }
                }
            }
            return horas;
        }
    }
}