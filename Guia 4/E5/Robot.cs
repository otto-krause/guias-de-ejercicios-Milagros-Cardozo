using System.Collections.Generic;
namespace E5
{
    public class Robot:Serpensante
    {
        public List<string> conocimientos=new List<string>();
        public List<string> intereses=new List<string>();
        public override void estudiar(string estudia)
        {
            conocimientos.Add(estudia);
        }

        public override int pensar(string tema)
        {
            return conocimientos.Count;
        }
    }
}