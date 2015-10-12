using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class Soustraction : Operation
    {
        public Soustraction()
            : base()
        {
        }

        public override decimal calculerOperation()
        {
            base.calculerBranch();

            resultat = (decimal)(operandeA.calculerOperation() - operandeB.calculerOperation());

            return resultat;
        }
    }
}
