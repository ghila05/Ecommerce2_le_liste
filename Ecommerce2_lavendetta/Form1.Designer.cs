namespace Ecommerce2_lavendetta
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.butnSvuota = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.butnInserisci = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPrezzo = new System.Windows.Forms.TextBox();
            this.TxtDescri = new System.Windows.Forms.TextBox();
            this.TxtProduttore = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIngredienti = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtModello = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txtgrammatura = new System.Windows.Forms.TextBox();
            this.TxtFunzionamento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label_PREZZO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butnSvuota
            // 
            this.butnSvuota.Location = new System.Drawing.Point(220, 582);
            this.butnSvuota.Margin = new System.Windows.Forms.Padding(4);
            this.butnSvuota.Name = "butnSvuota";
            this.butnSvuota.Size = new System.Drawing.Size(271, 66);
            this.butnSvuota.TabIndex = 29;
            this.butnSvuota.Text = "SVUOTA";
            this.butnSvuota.UseVisualStyleBackColor = true;
            this.butnSvuota.Click += new System.EventHandler(this.butnSvuota_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(498, 582);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 66);
            this.button3.TabIndex = 28;
            this.button3.Text = "ELIMINA [SELEZIONANARE]";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(606, 13);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(713, 505);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // butnInserisci
            // 
            this.butnInserisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnInserisci.Location = new System.Drawing.Point(6, 582);
            this.butnInserisci.Margin = new System.Windows.Forms.Padding(4);
            this.butnInserisci.Name = "butnInserisci";
            this.butnInserisci.Size = new System.Drawing.Size(184, 66);
            this.butnInserisci.TabIndex = 25;
            this.butnInserisci.Text = "INSERISCI";
            this.butnInserisci.UseVisualStyleBackColor = true;
            this.butnInserisci.Click += new System.EventHandler(this.butnInserisci_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "PREZZO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "DESCRIZIONE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "PRODUTTORE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "NOME:";
            // 
            // TxtPrezzo
            // 
            this.TxtPrezzo.Location = new System.Drawing.Point(16, 300);
            this.TxtPrezzo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPrezzo.Name = "TxtPrezzo";
            this.TxtPrezzo.Size = new System.Drawing.Size(105, 22);
            this.TxtPrezzo.TabIndex = 19;
            // 
            // TxtDescri
            // 
            this.TxtDescri.Location = new System.Drawing.Point(180, 192);
            this.TxtDescri.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescri.Name = "TxtDescri";
            this.TxtDescri.Size = new System.Drawing.Size(105, 22);
            this.TxtDescri.TabIndex = 18;
            // 
            // TxtProduttore
            // 
            this.TxtProduttore.Location = new System.Drawing.Point(16, 192);
            this.TxtProduttore.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProduttore.Name = "TxtProduttore";
            this.TxtProduttore.Size = new System.Drawing.Size(105, 22);
            this.TxtProduttore.TabIndex = 17;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(180, 90);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(105, 22);
            this.TxtNome.TabIndex = 16;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(20, 90);
            this.TxtID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(105, 22);
            this.TxtID.TabIndex = 15;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(179, 300);
            this.dateTime.Margin = new System.Windows.Forms.Padding(4);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(255, 22);
            this.dateTime.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 256);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "DATA:";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "ALIMENTARE",
            "FOGLI",
            "PENNE",
            "ELETTRONICA"});
            this.comboBox.Location = new System.Drawing.Point(333, 90);
            this.comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(160, 24);
            this.comboBox.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "TIPO:";
            // 
            // txtIngredienti
            // 
            this.txtIngredienti.Location = new System.Drawing.Point(333, 192);
            this.txtIngredienti.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngredienti.Multiline = true;
            this.txtIngredienti.Name = "txtIngredienti";
            this.txtIngredienti.Size = new System.Drawing.Size(215, 54);
            this.txtIngredienti.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "INGREDIENTI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 353);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "MODELLO:";
            // 
            // TxtModello
            // 
            this.TxtModello.Location = new System.Drawing.Point(20, 398);
            this.TxtModello.Margin = new System.Windows.Forms.Padding(4);
            this.TxtModello.Name = "TxtModello";
            this.TxtModello.Size = new System.Drawing.Size(105, 22);
            this.TxtModello.TabIndex = 36;
            this.TxtModello.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 353);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "GRAMMATURA:";
            // 
            // Txtgrammatura
            // 
            this.Txtgrammatura.Location = new System.Drawing.Point(176, 398);
            this.Txtgrammatura.Margin = new System.Windows.Forms.Padding(4);
            this.Txtgrammatura.Name = "Txtgrammatura";
            this.Txtgrammatura.Size = new System.Drawing.Size(105, 22);
            this.Txtgrammatura.TabIndex = 38;
            // 
            // TxtFunzionamento
            // 
            this.TxtFunzionamento.Location = new System.Drawing.Point(352, 398);
            this.TxtFunzionamento.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFunzionamento.Name = "TxtFunzionamento";
            this.TxtFunzionamento.Size = new System.Drawing.Size(99, 22);
            this.TxtFunzionamento.TabIndex = 40;
            this.TxtFunzionamento.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(345, 353);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "FUNZIONAMENTO:";
            // 
            // label_PREZZO
            // 
            this.label_PREZZO.AutoSize = true;
            this.label_PREZZO.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PREZZO.Location = new System.Drawing.Point(1033, 547);
            this.label_PREZZO.Name = "label_PREZZO";
            this.label_PREZZO.Size = new System.Drawing.Size(276, 29);
            this.label_PREZZO.TabIndex = 43;
            this.label_PREZZO.Text = "PREZZO SCONTATO: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 654);
            this.Controls.Add(this.label_PREZZO);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtFunzionamento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txtgrammatura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtModello);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIngredienti);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.butnSvuota);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.butnInserisci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPrezzo);
            this.Controls.Add(this.TxtDescri);
            this.Controls.Add(this.TxtProduttore);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butnSvuota;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button butnInserisci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPrezzo;
        private System.Windows.Forms.TextBox TxtDescri;
        private System.Windows.Forms.TextBox TxtProduttore;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIngredienti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtModello;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txtgrammatura;
        private System.Windows.Forms.TextBox TxtFunzionamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_PREZZO;
    }
}

