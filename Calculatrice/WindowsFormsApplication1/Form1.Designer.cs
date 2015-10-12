namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.resultat = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.labelOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(255, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "sqrt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.clic_operateur);
            // 
            // resultat
            // 
            this.resultat.BackColor = System.Drawing.SystemColors.Window;
            this.resultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resultat.Location = new System.Drawing.Point(16, 47);
            this.resultat.Multiline = true;
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(313, 28);
            this.resultat.TabIndex = 1;
            this.resultat.Text = "0";
            this.resultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(174, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ret. arr.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.backspace);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(93, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.clear);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(12, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "CE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.clearEnd);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(93, 355);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 45);
            this.button5.TabIndex = 6;
            this.button5.Text = ")";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.clic_operateur);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(12, 355);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 45);
            this.button6.TabIndex = 7;
            this.button6.Text = "(";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.clic_operateur);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(174, 355);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 45);
            this.button7.TabIndex = 8;
            this.button7.Text = "+/-";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.OpposedValue);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(12, 151);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 45);
            this.button8.TabIndex = 11;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.clic_touche);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(93, 151);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 45);
            this.button9.TabIndex = 10;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.clic_touche);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button10.Location = new System.Drawing.Point(174, 151);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 45);
            this.button10.TabIndex = 9;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.clic_touche);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button11.Location = new System.Drawing.Point(12, 202);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 45);
            this.button11.TabIndex = 14;
            this.button11.Text = "4";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.clic_touche);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button12.Location = new System.Drawing.Point(93, 202);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 45);
            this.button12.TabIndex = 13;
            this.button12.Text = "5";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.clic_touche);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button13.Location = new System.Drawing.Point(174, 202);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 45);
            this.button13.TabIndex = 12;
            this.button13.Text = "6";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.clic_touche);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button14.Location = new System.Drawing.Point(12, 253);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 45);
            this.button14.TabIndex = 17;
            this.button14.Text = "1";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.clic_touche);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button15.Location = new System.Drawing.Point(93, 253);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 45);
            this.button15.TabIndex = 16;
            this.button15.Text = "2";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.clic_touche);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button16.Location = new System.Drawing.Point(174, 253);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 45);
            this.button16.TabIndex = 15;
            this.button16.Text = "3";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.clic_touche);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button17.Location = new System.Drawing.Point(174, 304);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 45);
            this.button17.TabIndex = 20;
            this.button17.Text = ".";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.clic_touche);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button18.Location = new System.Drawing.Point(12, 304);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(156, 45);
            this.button18.TabIndex = 19;
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.clic_touche);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.Highlight;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button19.Location = new System.Drawing.Point(257, 355);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 45);
            this.button19.TabIndex = 18;
            this.button19.Text = "=";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.clic_operateur);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button20.Location = new System.Drawing.Point(255, 304);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 45);
            this.button20.TabIndex = 24;
            this.button20.Text = "+";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.clic_operateur);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button21.Location = new System.Drawing.Point(255, 253);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 45);
            this.button21.TabIndex = 23;
            this.button21.Text = "-";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.clic_operateur);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(255, 202);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 45);
            this.button22.TabIndex = 22;
            this.button22.Text = "*";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.clic_operateur);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button23.Location = new System.Drawing.Point(255, 151);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 45);
            this.button23.TabIndex = 21;
            this.button23.Text = "/";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.clic_operateur);
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelOperation.ForeColor = System.Drawing.Color.DarkGray;
            this.labelOperation.Location = new System.Drawing.Point(12, 15);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(0, 24);
            this.labelOperation.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 414);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculatrice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox resultat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Label labelOperation;
    }
}

