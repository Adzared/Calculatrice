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

            if (operandeB == null || operandeB is Valeur)
                resultat = (decimal)Math.Sqrt((double)operandeA.calculerOperation());
            else if (operandeB is Addition)
                resultat = (decimal)Math.Sqrt((double)operandeA.calculerOperation()) + operandeB.calculerOperation();

            else if (operandeB is Soustraction)
                resultat = (decimal)Math.Sqrt((double)operandeA.calculerOperation()) - operandeB.calculerOperation();

            else if (operandeB is Multiplication)
                resultat = (decimal)Math.Sqrt((double)operandeA.calculerOperation()) * operandeB.calculerOperation();

            else if (operandeB is Division)
                try
                {
                    resultat = (decimal)Math.Sqrt((double)operandeA.calculerOperation()) / operandeB.calculerOperation();
                }
                catch (DivideByZeroException)
                {
                    return 0;
                }
            else if (operandeB is sqrt)
                resultat = 0;

            
            return resultat;
        }
    }
}
