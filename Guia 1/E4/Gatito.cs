namespace E4
{
    public class Gatito
    {
       string nombre;
       bool vacunas;
       int energia; 
       public Gatito(string nombre, bool vacunas, int energia)
       {
           this.nombre = nombre;
           this.vacunas = vacunas;
           this.energia = energia;
       }
       public string nombreGatito()
       {
           return nombre;
       }
       public bool estaVacunado()
       {
           return vacunas;
       }

       public int cuantoJuega(int juega)
       {
           return energia=energia - (2*juega);
       }

       public int Comer()
       {
           return energia=energia + 50;
       }

       public bool estaSaludable()
       {
           return vacunas && energia > 30;
       }
    }
}