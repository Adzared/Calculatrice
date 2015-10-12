using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class sqrt : Operation
    {
        public sqrt() : base() { }

        public override decimal calculerOperation()
        {
            base.calculerBranch();

            resultat = (decimal)Math.Sqrt((double)operandeA.calculerOperation());
            return resultat;
        }
    }
}
