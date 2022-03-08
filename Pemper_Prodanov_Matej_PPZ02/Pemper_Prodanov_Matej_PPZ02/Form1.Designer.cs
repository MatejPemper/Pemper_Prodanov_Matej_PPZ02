namespace Pemper_Prodanov_Matej_PPZ02
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
            this.labelVrsta = new System.Windows.Forms.Label();
            this.radioButtonGazirano = new System.Windows.Forms.RadioButton();
            this.radioButtonNegazirano = new System.Windows.Forms.RadioButton();
            this.radioButtonAlkohol = new System.Windows.Forms.RadioButton();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.labelKolicina = new System.Windows.Forms.Label();
            this.comboBoxKolicina = new System.Windows.Forms.ComboBox();
            this.labelPakiranje = new System.Windows.Forms.Label();
            this.comboBoxPakiranje = new System.Windows.Forms.ComboBox();
            this.labelPostotak = new System.Windows.Forms.Label();
            this.trackBarPostotak = new System.Windows.Forms.TrackBar();
            this.labelcijena = new System.Windows.Forms.Label();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.richTextBoxIspis = new System.Windows.Forms.RichTextBox();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.buttonIspis = new System.Windows.Forms.Button();
            this.panelRadioButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPostotak)).BeginInit();
            this.panelRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelVrsta
            // 
            this.labelVrsta.AutoSize = true;
            this.labelVrsta.Location = new System.Drawing.Point(13, 34);
            this.labelVrsta.Name = "labelVrsta";
            this.labelVrsta.Size = new System.Drawing.Size(54, 13);
            this.labelVrsta.TabIndex = 0;
            this.labelVrsta.Text = "Vrsta pića";
            // 
            // radioButtonGazirano
            // 
            this.radioButtonGazirano.AutoSize = true;
            this.radioButtonGazirano.Location = new System.Drawing.Point(11, 3);
            this.radioButtonGazirano.Name = "radioButtonGazirano";
            this.radioButtonGazirano.Size = new System.Drawing.Size(67, 17);
            this.radioButtonGazirano.TabIndex = 1;
            this.radioButtonGazirano.TabStop = true;
            this.radioButtonGazirano.Text = "Gazirano";
            this.radioButtonGazirano.UseVisualStyleBackColor = true;
            // 
            // radioButtonNegazirano
            // 
            this.radioButtonNegazirano.AutoSize = true;
            this.radioButtonNegazirano.Location = new System.Drawing.Point(11, 26);
            this.radioButtonNegazirano.Name = "radioButtonNegazirano";
            this.radioButtonNegazirano.Size = new System.Drawing.Size(79, 17);
            this.radioButtonNegazirano.TabIndex = 2;
            this.radioButtonNegazirano.TabStop = true;
            this.radioButtonNegazirano.Text = "Negazirano";
            this.radioButtonNegazirano.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlkohol
            // 
            this.radioButtonAlkohol.AutoSize = true;
            this.radioButtonAlkohol.Location = new System.Drawing.Point(11, 49);
            this.radioButtonAlkohol.Name = "radioButtonAlkohol";
            this.radioButtonAlkohol.Size = new System.Drawing.Size(60, 17);
            this.radioButtonAlkohol.TabIndex = 3;
            this.radioButtonAlkohol.TabStop = true;
            this.radioButtonAlkohol.Text = "Alkohol";
            this.radioButtonAlkohol.UseVisualStyleBackColor = true;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(16, 140);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(34, 13);
            this.labelNaziv.TabIndex = 4;
            this.labelNaziv.Text = "Naziv";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(102, 140);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(121, 20);
            this.textBoxNaziv.TabIndex = 5;
            // 
            // labelKolicina
            // 
            this.labelKolicina.AutoSize = true;
            this.labelKolicina.Location = new System.Drawing.Point(13, 180);
            this.labelKolicina.Name = "labelKolicina";
            this.labelKolicina.Size = new System.Drawing.Size(44, 13);
            this.labelKolicina.TabIndex = 6;
            this.labelKolicina.Text = "Količina";
            // 
            // comboBoxKolicina
            // 
            this.comboBoxKolicina.FormattingEnabled = true;
            this.comboBoxKolicina.Items.AddRange(new object[] {
            "0.5L",
            "1.0L",
            "1.5L",
            "2.0L"});
            this.comboBoxKolicina.Location = new System.Drawing.Point(102, 180);
            this.comboBoxKolicina.Name = "comboBoxKolicina";
            this.comboBoxKolicina.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKolicina.TabIndex = 7;
            // 
            // labelPakiranje
            // 
            this.labelPakiranje.AutoSize = true;
            this.labelPakiranje.Location = new System.Drawing.Point(13, 219);
            this.labelPakiranje.Name = "labelPakiranje";
            this.labelPakiranje.Size = new System.Drawing.Size(51, 13);
            this.labelPakiranje.TabIndex = 8;
            this.labelPakiranje.Text = "Pakiranje";
            // 
            // comboBoxPakiranje
            // 
            this.comboBoxPakiranje.FormattingEnabled = true;
            this.comboBoxPakiranje.Items.AddRange(new object[] {
            "Staklo",
            "Plastika",
            "Tetrapak"});
            this.comboBoxPakiranje.Location = new System.Drawing.Point(102, 219);
            this.comboBoxPakiranje.Name = "comboBoxPakiranje";
            this.comboBoxPakiranje.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPakiranje.TabIndex = 9;
            // 
            // labelPostotak
            // 
            this.labelPostotak.AutoSize = true;
            this.labelPostotak.Location = new System.Drawing.Point(12, 258);
            this.labelPostotak.Name = "labelPostotak";
            this.labelPostotak.Size = new System.Drawing.Size(29, 13);
            this.labelPostotak.TabIndex = 10;
            this.labelPostotak.Text = "alk%";
            // 
            // trackBarPostotak
            // 
            this.trackBarPostotak.Location = new System.Drawing.Point(102, 258);
            this.trackBarPostotak.Maximum = 70;
            this.trackBarPostotak.Name = "trackBarPostotak";
            this.trackBarPostotak.Size = new System.Drawing.Size(129, 45);
            this.trackBarPostotak.TabIndex = 11;
            this.trackBarPostotak.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelcijena
            // 
            this.labelcijena.AutoSize = true;
            this.labelcijena.Location = new System.Drawing.Point(13, 307);
            this.labelcijena.Name = "labelcijena";
            this.labelcijena.Size = new System.Drawing.Size(36, 13);
            this.labelcijena.TabIndex = 12;
            this.labelcijena.Text = "Cijena";
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(102, 307);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(121, 20);
            this.textBoxCijena.TabIndex = 13;
            // 
            // richTextBoxIspis
            // 
            this.richTextBoxIspis.Location = new System.Drawing.Point(436, 34);
            this.richTextBoxIspis.Name = "richTextBoxIspis";
            this.richTextBoxIspis.Size = new System.Drawing.Size(301, 308);
            this.richTextBoxIspis.TabIndex = 14;
            this.richTextBoxIspis.Text = "";
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(256, 34);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(158, 119);
            this.buttonUnesi.TabIndex = 15;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // buttonIspis
            // 
            this.buttonIspis.Location = new System.Drawing.Point(256, 169);
            this.buttonIspis.Name = "buttonIspis";
            this.buttonIspis.Size = new System.Drawing.Size(158, 115);
            this.buttonIspis.TabIndex = 16;
            this.buttonIspis.Text = "Ispiši";
            this.buttonIspis.UseVisualStyleBackColor = true;
            this.buttonIspis.Click += new System.EventHandler(this.buttonIspis_Click);
            // 
            // panelRadioButtons
            // 
            this.panelRadioButtons.Controls.Add(this.radioButtonGazirano);
            this.panelRadioButtons.Controls.Add(this.radioButtonNegazirano);
            this.panelRadioButtons.Controls.Add(this.radioButtonAlkohol);
            this.panelRadioButtons.Location = new System.Drawing.Point(102, 34);
            this.panelRadioButtons.Name = "panelRadioButtons";
            this.panelRadioButtons.Size = new System.Drawing.Size(113, 73);
            this.panelRadioButtons.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 370);
            this.Controls.Add(this.panelRadioButtons);
            this.Controls.Add(this.buttonIspis);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.richTextBoxIspis);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.labelcijena);
            this.Controls.Add(this.trackBarPostotak);
            this.Controls.Add(this.labelPostotak);
            this.Controls.Add(this.comboBoxPakiranje);
            this.Controls.Add(this.labelPakiranje);
            this.Controls.Add(this.comboBoxKolicina);
            this.Controls.Add(this.labelKolicina);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.labelVrsta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPostotak)).EndInit();
            this.panelRadioButtons.ResumeLayout(false);
            this.panelRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVrsta;
        private System.Windows.Forms.RadioButton radioButtonGazirano;
        private System.Windows.Forms.RadioButton radioButtonNegazirano;
        private System.Windows.Forms.RadioButton radioButtonAlkohol;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label labelKolicina;
        private System.Windows.Forms.ComboBox comboBoxKolicina;
        private System.Windows.Forms.Label labelPakiranje;
        private System.Windows.Forms.ComboBox comboBoxPakiranje;
        private System.Windows.Forms.Label labelPostotak;
        private System.Windows.Forms.TrackBar trackBarPostotak;
        private System.Windows.Forms.Label labelcijena;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.RichTextBox richTextBoxIspis;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.Button buttonIspis;
        private System.Windows.Forms.Panel panelRadioButtons;
    }
}

