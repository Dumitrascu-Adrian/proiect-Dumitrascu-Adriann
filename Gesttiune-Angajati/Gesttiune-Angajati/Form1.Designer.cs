namespace Gesttiune_Angajati
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cnp = new System.Windows.Forms.Label();
            this.functie = new System.Windows.Forms.Label();
            this.Salariu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameT = new System.Windows.Forms.TextBox();
            this.PrenumeT = new System.Windows.Forms.TextBox();
            this.CNPT = new System.Windows.Forms.TextBox();
            this.FunctieT = new System.Windows.Forms.TextBox();
            this.SalariuT = new System.Windows.Forms.TextBox();
            this.ProiectT = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(480, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(30, 355);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "adauga angajat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(510, 93);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(377, 355);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "prenume";
            // 
            // cnp
            // 
            this.cnp.AutoSize = true;
            this.cnp.Location = new System.Drawing.Point(42, 172);
            this.cnp.Name = "cnp";
            this.cnp.Size = new System.Drawing.Size(25, 13);
            this.cnp.TabIndex = 6;
            this.cnp.Text = "cnp";
            // 
            // functie
            // 
            this.functie.AutoSize = true;
            this.functie.Location = new System.Drawing.Point(42, 217);
            this.functie.Name = "functie";
            this.functie.Size = new System.Drawing.Size(39, 13);
            this.functie.TabIndex = 7;
            this.functie.Text = "functie";
            // 
            // Salariu
            // 
            this.Salariu.AutoSize = true;
            this.Salariu.Location = new System.Drawing.Point(42, 255);
            this.Salariu.Name = "Salariu";
            this.Salariu.Size = new System.Drawing.Size(37, 13);
            this.Salariu.TabIndex = 8;
            this.Salariu.Text = "salariu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "proiect";
            // 
            // NameT
            // 
            this.NameT.Location = new System.Drawing.Point(118, 105);
            this.NameT.Name = "NameT";
            this.NameT.Size = new System.Drawing.Size(176, 20);
            this.NameT.TabIndex = 10;
            // 
            // PrenumeT
            // 
            this.PrenumeT.Location = new System.Drawing.Point(118, 138);
            this.PrenumeT.Name = "PrenumeT";
            this.PrenumeT.Size = new System.Drawing.Size(176, 20);
            this.PrenumeT.TabIndex = 11;
            // 
            // CNPT
            // 
            this.CNPT.Location = new System.Drawing.Point(118, 172);
            this.CNPT.Name = "CNPT";
            this.CNPT.Size = new System.Drawing.Size(176, 20);
            this.CNPT.TabIndex = 12;
            // 
            // FunctieT
            // 
            this.FunctieT.Location = new System.Drawing.Point(118, 217);
            this.FunctieT.Name = "FunctieT";
            this.FunctieT.Size = new System.Drawing.Size(176, 20);
            this.FunctieT.TabIndex = 13;
            // 
            // SalariuT
            // 
            this.SalariuT.Location = new System.Drawing.Point(118, 255);
            this.SalariuT.Name = "SalariuT";
            this.SalariuT.Size = new System.Drawing.Size(176, 20);
            this.SalariuT.TabIndex = 14;
            // 
            // ProiectT
            // 
            this.ProiectT.Location = new System.Drawing.Point(118, 289);
            this.ProiectT.Name = "ProiectT";
            this.ProiectT.Size = new System.Drawing.Size(176, 20);
            this.ProiectT.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "sterge angajat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(351, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 18;
            this.button3.Text = "modifica date angajat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(22, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 581);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ProiectT);
            this.Controls.Add(this.SalariuT);
            this.Controls.Add(this.FunctieT);
            this.Controls.Add(this.CNPT);
            this.Controls.Add(this.PrenumeT);
            this.Controls.Add(this.NameT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Salariu);
            this.Controls.Add(this.functie);
            this.Controls.Add(this.cnp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cnp;
        private System.Windows.Forms.Label functie;
        private System.Windows.Forms.Label Salariu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameT;
        private System.Windows.Forms.TextBox PrenumeT;
        private System.Windows.Forms.TextBox CNPT;
        private System.Windows.Forms.TextBox FunctieT;
        private System.Windows.Forms.TextBox SalariuT;
        private System.Windows.Forms.TextBox ProiectT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

