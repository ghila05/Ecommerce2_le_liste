using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2_lavendetta
{
    public abstract class Cancelleria : Prodotto
    {
        public Cancelleria(string id, string nome, string prod, string descr, float prezzo):base(id, nome, prod, descr, prezzo)
        {

        }

        float sconto = 97/100;

        public override float getPrezzo()
        {
            if (DateTime.Now.Day % 2 == 0)
            {
                return this.Prezzo * sconto;
            }
            else
                return this.Prezzo;
        }
    }
}
