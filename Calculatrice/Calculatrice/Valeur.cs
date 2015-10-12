using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class Valeur : Operande
    {
        public decimal? valeur { get; set; }

        public Valeur() { valeur = 0; }

        public Valeur(Decimal d)
        {
            valeur = d;
        }

        public override decimal calculerOperation()
        {
            return this.valeur != null ? 
                (decimal)this.valeur :
                0;
        }
    }
}
