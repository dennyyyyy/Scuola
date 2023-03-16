using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuolaVerifica
{
    internal class Alunno
    {
        public  string Nome  { get; set; }
        public  string cognome { get; set; }
        public  int eta { get; set; }
        public  string citta { get; set; }
        
        public Alunno(string s, string c, int e , string cit )
        {
            Nome = s;
            cognome = c;
            eta = e;
            citta = cit;
        }
         public override string  ToString()
        {

            return Nome + " " + cognome+" " + eta +" "+ citta;
        }
        public string Verificabiennio(Alunno n)
        {
            if (n.eta < 16)
            {
                return "biennio";
            }
            else
            {
                return "triennio";
            }
        }
    }
}
