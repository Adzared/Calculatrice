using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculatrice;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int nbParentheses;

        //public List<Calculatrice.Operation> operations;
        public Operation OperationEnCours;
        public Operation tronc;
        public Operation troncParentheses;
        public Operation OpParentheses;
        private Valeur val;
        bool enterPressed = false;

        public Form1()
        {
            InitializeComponent();
            nbParentheses = 0;
            val = new Valeur();
        }

        private void clic_touche(object sender, EventArgs e)
        {
            if (enterPressed) { labelOperation.Text = ""; resultat.Clear(); enterPressed = false; }
            String text = ((Button)sender).Text;
            if (resultat.Text == "0")
            {
                resultat.Clear();
            }
            if (resultat.Text.Contains(".") == true && text == ".")
            {
                return;
            }
            resultat.Text += text;
        }

        private void clearEnd(object sender, EventArgs e)
        {
            resultat.Text = "0";
        }

        private void clear(object sender, EventArgs e)
        {
            labelOperation.Text = String.Empty;
            resultat.Text = "0";
            OperationEnCours = null;
            tronc = null;
            enterPressed = false;
        }

        private void backspace(object sender, EventArgs e)
        {
            if (resultat.Text.Length > 0)
            {
                resultat.Text = resultat.Text.Remove(resultat.Text.Length - 1, 1);
            }
        }

        private void clic_operateur(object sender, EventArgs e)
        {
            if (enterPressed)   //SI on a appuyé sur entrée avant de taper sur un opérateur, on veut travailler sur le résultat d'une opération précédente
            {
                labelOperation.Text = "";
                enterPressed = false;
            }

            String text = ((Button)sender).Text; //On récupère le texte de l'opérateur clické

            if (text != "(" && text != ")") //Si ce n'est pas une parenthèses, alors on ajoute dans le libellé de l'opération la valeur saisie dans le champ résultat 
            {
                labelOperation.Text += resultat.Text;
                if (resultat.Text != "")
                {
                    try
                    {
                        val.valeur = Decimal.Parse(resultat.Text, System.Globalization.CultureInfo.InvariantCulture); //On ajoute la valeur saisie dans la variable val, en convertissant la virgule selon la langue du système
                        //Pour éviter les problèmes avec les "." et les ","
                    }
                    catch (FormatException)
                    {
                    }
                }
                if (text != "=")    //Si c'est un opérateur de type + - * /, on l'ajoute également pour avoir "XVal+" 
                {
                    labelOperation.Text += text;
                }
            }

            //if (resultat.Text != "" && resultat.Text != "(" && resultat.Text != ")")    
            //{
            //    try
            //    {
            //        val.valeur = Decimal.Parse(resultat.Text, System.Globalization.CultureInfo.InvariantCulture);
            //    }
            //    catch (FormatException)
            //    {
            //    }
            //}

            if (!val.valeur.HasValue)
            {
                //Si malgré les tests précédents, val n'est pas initialisée, alors elle est nulle
                val.valeur = 0;
            }

            switch (text)   //On commence le traitement de l'opérateur
            {
                case "+":   //Si c'est une addition
                    Operation add = new Addition(); //On crée notre operation tampon

                    if (nbParentheses != 0) //Si on a une parenthèse ouverte
                    {
                        if (OpParentheses != null)  //Si une opération est en cours dans les parenthèses
                        {
                            OpParentheses.setOperandeB((decimal)val.valeur);    //On ajoute ajoute 
                            if (OpParentheses != troncParentheses)
                            {
                                troncParentheses.setOperandeB(OpParentheses.Clone());
                                OpParentheses = troncParentheses;
                            }
                            add.setOperandeA(troncParentheses.Clone());
                            OpParentheses = add;
                            troncParentheses = OpParentheses;
                            if (OperationEnCours.getOperandeA() == null)
                            {
                                OperationEnCours.setOperandeA(troncParentheses);
                            }
                        }
                        else
                        {
                            add.setOperandeA((decimal)val.valeur);
                            troncParentheses = add;
                            OpParentheses = troncParentheses;
                        }
                    }
                    else    //Si on a pas de parenthèse ouverte
                    {

                        if (OperationEnCours != null)   //Si une opération est en cours
                        {
                            OperationEnCours.setOperandeB((decimal)val.valeur); //on ajoute a l'opération en cours l'opérande tapée
                            if (OperationEnCours != tronc)  //Si l'opération en cours est avancée dans l'arbre des opérations
                            {
                                tronc.setOperandeB(OperationEnCours.Clone());   //On ajoute l'opération en cours dans l'arbre
                            }
                            add.setOperandeA(tronc.Clone());    //On ajoute a l'opération tampon l'arbre
                            OperationEnCours = add;             //L'opération en cours devient la dernière opération de l'arbre
                            tronc = OperationEnCours;           //On avance l'opération dans le tronc pour le calcul final
                        }
                        else
                        {
                            add.setOperandeA((decimal)val.valeur);  //Si l'opération est null, on est dans une nouvelle opération
                            OperationEnCours = add; //L'opération en cours devient l'opération tampon
                            tronc = OperationEnCours;   //On avance l'opération dans l'arbre

                        }
                    }

                    break;

                case "-":
                    Operation sub = new Soustraction();

                    if (nbParentheses != 0)
                    {
                        if (OpParentheses != null)
                        {
                            OpParentheses.setOperandeB((decimal)val.valeur);
                            if (OpParentheses != troncParentheses)
                            {
                                troncParentheses.setOperandeB(OpParentheses.Clone());
                                OpParentheses = troncParentheses;
                            }
                            sub.setOperandeA(troncParentheses.Clone());
                            OpParentheses = sub;
                            troncParentheses = OpParentheses;
                        }
                        else
                        {
                            sub.setOperandeA((decimal)val.valeur);
                            OpParentheses = sub;
                            troncParentheses = OpParentheses;
                        }
                    }
                    else
                    {
                        if (OperationEnCours != null)
                        {
                            OperationEnCours.setOperandeB((decimal)val.valeur);
                            if (OperationEnCours != tronc)
                            {
                                tronc.setOperandeB(OperationEnCours.Clone());
                                OperationEnCours = tronc;
                            }
                            sub.setOperandeA(tronc.Clone());
                            OperationEnCours = sub;
                            tronc = OperationEnCours;
                        }
                        else
                        {
                            sub.setOperandeA((decimal)val.valeur);
                            tronc = sub;
                            OperationEnCours = tronc;

                        }
                    }
                    break;

                case "*":
                    Operation mul = new Multiplication();

                    if (nbParentheses != 0)
                    {
                        if (OpParentheses != null)
                        {
                            if (OpParentheses is Addition || OpParentheses is Soustraction)
                            {
                                mul.setOperandeA((decimal)val.valeur);
                                OpParentheses = mul;
                            }
                            else
                            {
                                OpParentheses.setOperandeB((decimal)val.valeur);
                                if (OpParentheses != troncParentheses)
                                {
                                    troncParentheses.setOperandeB(OpParentheses.Clone());
                                    OpParentheses = troncParentheses;
                                }
                                mul.setOperandeA(troncParentheses.Clone());
                                OpParentheses = mul;
                                troncParentheses = OpParentheses;
                            }
                        }
                        else
                        {
                            mul.setOperandeA((decimal)val.valeur);
                            troncParentheses = mul;
                            OpParentheses = troncParentheses;
                        }
                    }
                    else
                    {
                        if (OperationEnCours != null)
                        {
                            if (OperationEnCours is Addition || OperationEnCours is Soustraction)
                            {
                                mul.setOperandeA((decimal)val.valeur);
                                OperationEnCours = mul;
                            }
                            else
                            {
                                OperationEnCours.setOperandeB((decimal)val.valeur);
                                if (OperationEnCours != tronc)
                                {
                                    tronc.setOperandeB(OperationEnCours.Clone());
                                    OperationEnCours = tronc;
                                }
                                mul.setOperandeA(tronc.Clone());
                                OperationEnCours = mul;
                                tronc = OperationEnCours;
                            }
                        }
                        else
                        {
                            mul.setOperandeA((decimal)val.valeur);
                            tronc = mul;
                            OperationEnCours = tronc;
                        }
                    }

                    break;

                case "/":

                    Operation div = new Division();


                    if (nbParentheses != 0) //Une parenthèse est ouverte
                    {
                        if (OpParentheses != null) //Une opération est en cours dans les parenthèses
                        {
                            if (OpParentheses is Addition || OpParentheses is Soustraction) //si l'opération présente dans les parenthèses est une Addition ou Soustraction
                            {
                                div.setOperandeA((decimal)val.valeur);  //On ajoute la division avant, pour qu'elle soit prioritaire
                                OpParentheses = div;    //
                            }
                            else
                            {
                                OpParentheses.setOperandeB((decimal)val.valeur);
                                if (OpParentheses != troncParentheses)
                                {
                                    troncParentheses.setOperandeB(OpParentheses.Clone());
                                    OpParentheses = troncParentheses;
                                }
                                div.setOperandeA(troncParentheses.Clone());
                                OpParentheses = div;
                                troncParentheses = OpParentheses;
                            }
                        }
                        else
                        {
                            div.setOperandeA((decimal)val.valeur);
                            troncParentheses = div;
                            OpParentheses = troncParentheses;
                        }
                    }
                    else
                    {
                        if (OperationEnCours != null)
                        {
                            if (OperationEnCours is Addition || OperationEnCours is Soustraction)
                            {
                                div.setOperandeA((decimal)val.valeur);
                                OperationEnCours = div;
                            }
                            else
                            {
                                OperationEnCours.setOperandeB((decimal)val.valeur);
                                if (OperationEnCours != tronc)
                                {
                                    tronc.setOperandeB(OperationEnCours.Clone());
                                    OperationEnCours = tronc;
                                }
                                div.setOperandeA(tronc.Clone());
                                OperationEnCours = div;
                                tronc = OperationEnCours;
                            }
                        }
                        else
                        {
                            div.setOperandeA((decimal)val.valeur);
                            tronc = div;
                            OperationEnCours = tronc;
                        }
                    }

                    break;

                case "(":

                    nbParentheses++;
                    labelOperation.Text += "(";
                        
                    break;

                case ")":

                    if (nbParentheses > 0)  //Si on a une parenthèse ouverte
                    {
                        nbParentheses--;    //On peut la fermer

                        if (OpParentheses != null)  //Si l'opération entre parenthèses n'est pas null
                        {
                            if ((val != null || val.valeur.HasValue))   //Si on a une valeur en cours de saisie
                            {
                                OpParentheses.setOperandeB((decimal)val.valeur);    //alors on peut la stocker dans l'opérandeB de l'opération en cours
                                labelOperation.Text += resultat.Text;   //Et on l'ajoute au libellé de l'opération
                            }

                            if (troncParentheses != null)   //Si l'arbre existe
                            {

                                if (nbParentheses == 0) //Si on vient de fermer la dernière parenthèse
                                {
                                    
                                    if (troncParentheses.getOperandeB() == null)    //Si l'OperandeB de l'arbre n'est pas définie
                                        troncParentheses.setOperandeB(OpParentheses.Clone());   //On y stock l'opération en cours

                                    //OperationEnCours.setOperandeB(troncParentheses.Clone());
                                    
                                }
                            }
                            else
                            {
                                if (nbParentheses == 0)
                                {
                                    OperationEnCours = OpParentheses.Clone();
                                    if (tronc == null)
                                    {
                                        tronc = OperationEnCours;
                                    }
                                }
                            }
                        }
                        else
                        {
                            OperationEnCours = troncParentheses.Clone();
                            if (tronc == null)
                            {
                                tronc = OperationEnCours;
                            }
                        }
                        troncParentheses = null;
                        OpParentheses = null;

                        labelOperation.Text += ")";
                    }
                
                    break;

                case "sqrt":
                    Operation sqrt = new sqrt();
                    if (OperationEnCours is Addition || OperationEnCours is Soustraction)
                    {

                    }
                    else
                    {
                    
                    }

                    break;
                case "=":
                    if (nbParentheses != 0)
                    {
                        resultat.Text = "Parenthesis!";
                        return;
                    }
                    if (OperationEnCours != null && tronc.getOperandeA() != null)
                    {
                        if (OperationEnCours.getOperandeB() == null)
                        {
                            OperationEnCours.setOperandeB((decimal)val.valeur);
                        }

                        if (OperationEnCours != tronc)
                        {
                            tronc.setOperandeB(OperationEnCours.Clone());
                            OperationEnCours = tronc;
                        }
                        resultat.Text = tronc.calculerOperation().ToString(System.Globalization.CultureInfo.InvariantCulture);
                        val.valeur = null;
                        tronc.setOperandeA(tronc.Clone());
                    }
                    else
                    {
                        if (val.valeur.HasValue)
                            resultat.Text = val.valeur.ToString();
                    }

                    OperationEnCours = null;
                    enterPressed = true;
                    
                    return;
            }
            resultat.Clear();
            val.valeur = null;
        }

        private void OpposedValue(object sender, EventArgs e)
        {
            if (resultat.Text.Contains("-")) {
                resultat.Text = resultat.Text.Replace("-","");
            } else 
            {
                resultat.Text = "-" + resultat.Text;
            }
            val.valeur = decimal.Parse(resultat.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
