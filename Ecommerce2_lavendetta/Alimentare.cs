using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2_lavendetta
{
    public class Alimentare: Prodotto
    {
        string[] ingredienti = new string[10];
        float sconto = 5/100;
        DateTime Scadenza;


        public string[] Ingredienti
        {
            get
            {
                return ingredienti;
            }
            private set
            {
                if (value != null)
                {
                    ingredienti = value;
                }
            }
        }



        public Alimentare(string[] ingredienti, DateTime scadenza,string id, string nome,string prod,string descr,float prezzo) :base (id,nome,prod,descr,prezzo) 
        {
            Ingredienti = ingredienti;
            Scadenza = scadenza;
        }
        public override string ToString()
        {
            string uwu = "";
            for (int i = 0; i < Ingredienti.Length; i++)
            {
                uwu += $"{ingredienti[i]}, ";
            }
            return base.ToString() + ";" + uwu + ";" + $"{Scadenza}";
        }

        public float getSconto(float price, DateTime scadenza)
        {
            DateTime s = DateTime.Now;
            s = s.AddDays(7);
            
            int comp = DateTime.Compare(scadenza, s);

            if (comp <= 0)
            {

                return price / 2;
            }
            else
            {

                return price;
            }

        }

        public override float getPrezzo()
        {
           return getSconto(Prezzo, Scadenza);
        }

        
    }
}
