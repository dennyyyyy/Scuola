using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace ScuolaVerifica
{
    internal class Scuola
    {
        public  string Nome { get; set; }
        public  string indirizzo { get; set; }
        public string orari   { get; set; }
        public  List<Alunni>  Lista { get; set; }

        public Scuola(string nome, string indirizzo, string orari, List<Alunni> lista)
        {
            Nome = nome;
            this.indirizzo = indirizzo;
            this.orari = orari;
            Lista =lista;
        }
        public void aggiunta(Alunno n )
        {
            Lista.Add(n);
        }
        public List<Alunno> Ricerca(string c)
        {
            List<Alunno> lc =new List<Alunno>(); 
            for(int i=0; i<Lista.Count; i++)
            {
                if (Lista[i].Cognome== c)
                {
                    lc[i].Add(Lista[i].Cognome);
                }
            }
            return lc;
        }
    }
}
