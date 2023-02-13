using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2_lavendetta
{

    public class Carrello
    {
        
        //private const int MAXCARR = 999;
        private string _id;
        //private int currentLenght;
        //private Prodotto[] _prod = new Prodotto[MAXCARR];
        List<Prodotto> lista = new List<Prodotto>();
        private Prodotto p = new Prodotto();

        public string Id
        {
            get
            {
                return _id;
            }
            private set
            {
                if (value != null)
                    _id = value;
                else
                    throw new Exception("Inserire un id corretto");
            }
        }

        public Prodotto[] Prodotti
        {
            get
            {
                Prodotto[] p = new Prodotto[lista.Count];
                for (int i = 0; i < lista.Count; i++)
                {
                    p[i] = lista[i];
                }
                return p;
            }

        }

        public Carrello(string id)
        {
            this.Id = id;
            Svuota();
        }
        /*

        protected Carrello(Carrello c) : this(c.Id)
        {
            Id = c.Id;
           
            for (int i = 0; i < c.lista.Count; i++)
            {
                if (c.lista[i] != null)
                {
                    lista[i] = c.lista[i].Clone();          CLONE DA IMPLEMENTARE CON LE LISTE 
                }
            }


        }

        public Carrello Clone()
        {
            return new Carrello(this);
        }
        */

        //metodi specifici
        public void Svuota()
        {

            for (int i = 0; i < lista.Count; i++)
                lista[i] = null;
        }
        public void Aggiungi(Prodotto p)
        {

            if (p != null)
            {
                lista.Add(p);
            }
            else
                throw new Exception("Inserire un prodotto valido");
        }

        private int GetNumProdotti()
        {
            return lista.Count;
        }

        public int Esiste(Prodotto q)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Equals(q))
                    return i;
            }
            return -1;
        }

        public Prodotto Rimuovi(Prodotto p)
        {
            if (Esiste(p) != -1)
            {
                for (int i = Esiste(p); i < lista.Count - 1; i++)
                    lista[i] = lista[i + 1];

                lista[lista.Count - 1] = null;



                return p;
            }
            else
                throw new Exception("Inserire un prodotto valido");
        }

        public void Eliminadaid(string id)
        {
            for (int i=0; i<lista.Count; i++)
            {
                if(lista[i].Id == id)
                {
                    Rimuovi(lista[i]);

                }
            }
   

        }

    }
}