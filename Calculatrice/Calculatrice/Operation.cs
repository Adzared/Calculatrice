using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public abstract class Operation : Operande
    {
        protected Operande operandeA;
        protected Operande operandeB;
        
        protected decimal resultat=0;

        public Operation()
        {
        }

        public void setOperandeA(Operande o)
        {
            operandeA = o;
        }

        public void setOperandeB(Operande o)
        {
            operandeB = o;
        }

        public void setOperandeA(decimal o)
        {
            Valeur val = new Valeur(o);
            operandeA = val;
        }

        public void setOperandeB(decimal o)
        {
            Valeur val = new Valeur(o);
            operandeB = val;
        }

        public Operande getOperandeA()
        {
            return operandeA;
        }

        public Operande getOperandeB()
        {
            return operandeB;
        }


        public Operation Clone()
        {
            Operation op;
            if (this is Addition)
            {
                op = new Addition();
            
            } else if (this is Soustraction)
            {
                op = new Soustraction();
            
            }else if (this is Multiplication)
            {
                op = new Multiplication();

            }
            else if (this is Division)
            {
                op = new Division();
            }
            else
            {
                op = new sqrt();
            }

            op.setOperandeA(this.operandeA);
            op.setOperandeB(this.operandeB);
            return op;
        }

        public void calculerBranch()
        {
            if (operandeA is Operation)
            {
                operandeA.calculerOperation();
            }

            if (operandeB is Operation)
            {
                operandeB.calculerOperation();
            }
        }
    }
}
