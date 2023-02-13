using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2_lavendetta
{
    public class Penne: Cancelleria
    {
        string funzionamento;

        public string Funzionamento
        {
            get
            {
                return funzionamento;
            }
            set
            {
                if ( value != "")
                {
                    funzionamento = value;
                }
            }
        }

        public Penne(string funzionamento,string id, string nome, string prod, string descr, float prezzo): base(id, nome, prod, descr, prezzo)
        {
            Funzionamento = funzionamento;

        }
        public override string ToString()
        {
            return base.ToString() + ";" + Funzionamento;
        }
    }
}
