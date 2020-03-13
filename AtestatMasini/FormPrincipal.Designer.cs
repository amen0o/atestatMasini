using System;
using System.Windows.Forms;

namespace AtestatMasini
{
    partial class FormPrincipal
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
            this.groupBoxSpecificatii = new System.Windows.Forms.GroupBox();
            this.radioButonElectric = new System.Windows.Forms.RadioButton();
            this.radioButonMotorina = new System.Windows.Forms.RadioButton();
            this.radioButonBenzina = new System.Windows.Forms.RadioButton();
            this.labelTransmisie = new System.Windows.Forms.Label();
            this.labelClasaEmisii = new System.Windows.Forms.Label();
            this.labelConsum = new System.Windows.Forms.Label();
            this.labelCombustibil = new System.Windows.Forms.Label();
            this.labelCapacitateCubica = new System.Windows.Forms.Label();
            this.labelPutere = new System.Windows.Forms.Label();
            this.textTransmisie = new System.Windows.Forms.TextBox();
            this.textClasaEmisii = new System.Windows.Forms.TextBox();
            this.textCombustibil = new System.Windows.Forms.TextBox();
            this.textCapacitateCubica = new System.Windows.Forms.TextBox();
            this.textPutere = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.butonDetalii = new System.Windows.Forms.Button();
            this.butonComparareMasini = new System.Windows.Forms.Button();
            this.butonResetare = new System.Windows.Forms.Button();
            this.butonPlata = new System.Windows.Forms.Button();
            this.labelMarcaMasinii = new System.Windows.Forms.Label();
            this.labelModelulMasinii = new System.Windows.Forms.Label();
            this.comboBoxMarcaMasinii = new System.Windows.Forms.ComboBox();
            this.comboBoxModelulMasinii = new System.Windows.Forms.ComboBox();
            this.groupBoxDateCumparare = new System.Windows.Forms.GroupBox();
            this.textCiv = new System.Windows.Forms.TextBox();
            this.labelCiv = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textCardNumber = new System.Windows.Forms.TextBox();
            this.textPrenume = new System.Windows.Forms.TextBox();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.labelDataExpirare = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.textNume = new System.Windows.Forms.TextBox();
            this.butonCumparare = new System.Windows.Forms.Button();
            this.groupBoxSpecificatii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxDateCumparare.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSpecificatii
            // 
            this.groupBoxSpecificatii.Controls.Add(this.radioButonElectric);
            this.groupBoxSpecificatii.Controls.Add(this.radioButonMotorina);
            this.groupBoxSpecificatii.Controls.Add(this.radioButonBenzina);
            this.groupBoxSpecificatii.Controls.Add(this.labelTransmisie);
            this.groupBoxSpecificatii.Controls.Add(this.labelClasaEmisii);
            this.groupBoxSpecificatii.Controls.Add(this.labelConsum);
            this.groupBoxSpecificatii.Controls.Add(this.labelCombustibil);
            this.groupBoxSpecificatii.Controls.Add(this.labelCapacitateCubica);
            this.groupBoxSpecificatii.Controls.Add(this.labelPutere);
            this.groupBoxSpecificatii.Controls.Add(this.textTransmisie);
            this.groupBoxSpecificatii.Controls.Add(this.textClasaEmisii);
            this.groupBoxSpecificatii.Controls.Add(this.textCombustibil);
            this.groupBoxSpecificatii.Controls.Add(this.textCapacitateCubica);
            this.groupBoxSpecificatii.Controls.Add(this.textPutere);
            this.groupBoxSpecificatii.Location = new System.Drawing.Point(9, 13);
            this.groupBoxSpecificatii.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSpecificatii.Name = "groupBoxSpecificatii";
            this.groupBoxSpecificatii.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSpecificatii.Size = new System.Drawing.Size(481, 354);
            this.groupBoxSpecificatii.TabIndex = 0;
            this.groupBoxSpecificatii.TabStop = false;
            this.groupBoxSpecificatii.Text = "Specificatii";
            // 
            // radioButonElectric
            // 
            this.radioButonElectric.AutoSize = true;
            this.radioButonElectric.Location = new System.Drawing.Point(369, 152);
            this.radioButonElectric.Margin = new System.Windows.Forms.Padding(4);
            this.radioButonElectric.Name = "radioButonElectric";
            this.radioButonElectric.Size = new System.Drawing.Size(75, 21);
            this.radioButonElectric.TabIndex = 14;
            this.radioButonElectric.Text = "Electric";
            this.radioButonElectric.UseVisualStyleBackColor = true;
            // 
            // radioButonMotorina
            // 
            this.radioButonMotorina.AutoSize = true;
            this.radioButonMotorina.Location = new System.Drawing.Point(259, 152);
            this.radioButonMotorina.Margin = new System.Windows.Forms.Padding(4);
            this.radioButonMotorina.Name = "radioButonMotorina";
            this.radioButonMotorina.Size = new System.Drawing.Size(84, 21);
            this.radioButonMotorina.TabIndex = 13;
            this.radioButonMotorina.Text = "Motorina";
            this.radioButonMotorina.UseVisualStyleBackColor = true;
            // 
            // radioButonBenzina
            // 
            this.radioButonBenzina.AutoSize = true;
            this.radioButonBenzina.Location = new System.Drawing.Point(144, 152);
            this.radioButonBenzina.Margin = new System.Windows.Forms.Padding(4);
            this.radioButonBenzina.Name = "radioButonBenzina";
            this.radioButonBenzina.Size = new System.Drawing.Size(80, 21);
            this.radioButonBenzina.TabIndex = 12;
            this.radioButonBenzina.Text = "Benzina";
            this.radioButonBenzina.UseVisualStyleBackColor = true;
            // 
            // labelTransmisie
            // 
            this.labelTransmisie.AutoSize = true;
            this.labelTransmisie.Location = new System.Drawing.Point(40, 312);
            this.labelTransmisie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTransmisie.Name = "labelTransmisie";
            this.labelTransmisie.Size = new System.Drawing.Size(77, 17);
            this.labelTransmisie.TabIndex = 11;
            this.labelTransmisie.Text = "Transmisie";
            // 
            // labelClasaEmisii
            // 
            this.labelClasaEmisii.AutoSize = true;
            this.labelClasaEmisii.Location = new System.Drawing.Point(40, 260);
            this.labelClasaEmisii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClasaEmisii.Name = "labelClasaEmisii";
            this.labelClasaEmisii.Size = new System.Drawing.Size(102, 17);
            this.labelClasaEmisii.TabIndex = 10;
            this.labelClasaEmisii.Text = "Clasa de emisii";
            // 
            // labelConsum
            // 
            this.labelConsum.AutoSize = true;
            this.labelConsum.Location = new System.Drawing.Point(40, 203);
            this.labelConsum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConsum.Name = "labelConsum";
            this.labelConsum.Size = new System.Drawing.Size(133, 17);
            this.labelConsum.TabIndex = 9;
            this.labelConsum.Text = "Consum combustibil";
            // 
            // labelCombustibil
            // 
            this.labelCombustibil.AutoSize = true;
            this.labelCombustibil.Location = new System.Drawing.Point(40, 154);
            this.labelCombustibil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCombustibil.Name = "labelCombustibil";
            this.labelCombustibil.Size = new System.Drawing.Size(80, 17);
            this.labelCombustibil.TabIndex = 8;
            this.labelCombustibil.Text = "Combustibil";
            // 
            // labelCapacitateCubica
            // 
            this.labelCapacitateCubica.AutoSize = true;
            this.labelCapacitateCubica.Location = new System.Drawing.Point(40, 104);
            this.labelCapacitateCubica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCapacitateCubica.Name = "labelCapacitateCubica";
            this.labelCapacitateCubica.Size = new System.Drawing.Size(120, 17);
            this.labelCapacitateCubica.TabIndex = 7;
            this.labelCapacitateCubica.Text = "Capacitate cubica";
            // 
            // labelPutere
            // 
            this.labelPutere.AutoSize = true;
            this.labelPutere.Location = new System.Drawing.Point(40, 48);
            this.labelPutere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPutere.Name = "labelPutere";
            this.labelPutere.Size = new System.Drawing.Size(50, 17);
            this.labelPutere.TabIndex = 6;
            this.labelPutere.Text = "Putere";
            // 
            // textTransmisie
            // 
            this.textTransmisie.Location = new System.Drawing.Point(185, 308);
            this.textTransmisie.Margin = new System.Windows.Forms.Padding(4);
            this.textTransmisie.Name = "textTransmisie";
            this.textTransmisie.Size = new System.Drawing.Size(144, 22);
            this.textTransmisie.TabIndex = 5;
            // 
            // textClasaEmisii
            // 
            this.textClasaEmisii.Location = new System.Drawing.Point(185, 256);
            this.textClasaEmisii.Margin = new System.Windows.Forms.Padding(4);
            this.textClasaEmisii.Name = "textClasaEmisii";
            this.textClasaEmisii.Size = new System.Drawing.Size(144, 22);
            this.textClasaEmisii.TabIndex = 4;
            // 
            // textCombustibil
            // 
            this.textCombustibil.Location = new System.Drawing.Point(185, 200);
            this.textCombustibil.Margin = new System.Windows.Forms.Padding(4);
            this.textCombustibil.Name = "textCombustibil";
            this.textCombustibil.Size = new System.Drawing.Size(144, 22);
            this.textCombustibil.TabIndex = 3;
            // 
            // textCapacitateCubica
            // 
            this.textCapacitateCubica.Location = new System.Drawing.Point(185, 98);
            this.textCapacitateCubica.Margin = new System.Windows.Forms.Padding(4);
            this.textCapacitateCubica.Name = "textCapacitateCubica";
            this.textCapacitateCubica.ReadOnly = true;
            this.textCapacitateCubica.Size = new System.Drawing.Size(144, 22);
            this.textCapacitateCubica.TabIndex = 2;
            // 
            // textPutere
            // 
            this.textPutere.Location = new System.Drawing.Point(185, 45);
            this.textPutere.Margin = new System.Windows.Forms.Padding(4);
            this.textPutere.Name = "textPutere";
            this.textPutere.ReadOnly = true;
            this.textPutere.Size = new System.Drawing.Size(144, 22);
            this.textPutere.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Location = new System.Drawing.Point(0, 1);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(498, 293);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // butonDetalii
            // 
            this.butonDetalii.Location = new System.Drawing.Point(831, 33);
            this.butonDetalii.Margin = new System.Windows.Forms.Padding(4);
            this.butonDetalii.Name = "butonDetalii";
            this.butonDetalii.Size = new System.Drawing.Size(149, 41);
            this.butonDetalii.TabIndex = 0;
            this.butonDetalii.Text = "Detalii";
            this.butonDetalii.UseVisualStyleBackColor = true;
            this.butonDetalii.Click += new System.EventHandler(this.butonDetalii_Click);
            // 
            // butonComparareMasini
            // 
            this.butonComparareMasini.Location = new System.Drawing.Point(25, 388);
            this.butonComparareMasini.Margin = new System.Windows.Forms.Padding(4);
            this.butonComparareMasini.Name = "butonComparareMasini";
            this.butonComparareMasini.Size = new System.Drawing.Size(428, 63);
            this.butonComparareMasini.TabIndex = 1;
            this.butonComparareMasini.Text = "Comparare masini";
            this.butonComparareMasini.UseVisualStyleBackColor = true;
            // 
            // butonResetare
            // 
            this.butonResetare.Location = new System.Drawing.Point(831, 64);
            this.butonResetare.Margin = new System.Windows.Forms.Padding(4);
            this.butonResetare.Name = "butonResetare";
            this.butonResetare.Size = new System.Drawing.Size(149, 57);
            this.butonResetare.TabIndex = 3;
            this.butonResetare.Text = "Resetare";
            this.butonResetare.UseVisualStyleBackColor = true;
            this.butonResetare.Click += new System.EventHandler(this.butonResetare_Click);
            // 
            // butonPlata
            // 
            this.butonPlata.Location = new System.Drawing.Point(831, 119);
            this.butonPlata.Margin = new System.Windows.Forms.Padding(4);
            this.butonPlata.Name = "butonPlata";
            this.butonPlata.Size = new System.Drawing.Size(149, 58);
            this.butonPlata.TabIndex = 4;
            this.butonPlata.Text = "Plata";
            this.butonPlata.UseVisualStyleBackColor = true;
            this.butonPlata.Click += new EventHandler(this.butonCumparare_Click);
            // 
            // labelMarcaMasinii
            // 
            this.labelMarcaMasinii.AutoSize = true;
            this.labelMarcaMasinii.Location = new System.Drawing.Point(620, 13);
            this.labelMarcaMasinii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMarcaMasinii.Name = "labelMarcaMasinii";
            this.labelMarcaMasinii.Size = new System.Drawing.Size(94, 17);
            this.labelMarcaMasinii.TabIndex = 5;
            this.labelMarcaMasinii.Text = "Marca masinii";
            // 
            // labelModelulMasinii
            // 
            this.labelModelulMasinii.AutoSize = true;
            this.labelModelulMasinii.Location = new System.Drawing.Point(607, 102);
            this.labelModelulMasinii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModelulMasinii.Name = "labelModelulMasinii";
            this.labelModelulMasinii.Size = new System.Drawing.Size(104, 17);
            this.labelModelulMasinii.TabIndex = 6;
            this.labelModelulMasinii.Text = "Modelul masinii";
            // 
            // comboBoxMarcaMasinii
            // 
            this.comboBoxMarcaMasinii.FormattingEnabled = true;
            this.comboBoxMarcaMasinii.Location = new System.Drawing.Point(584, 50);
            this.comboBoxMarcaMasinii.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMarcaMasinii.Name = "comboBoxMarcaMasinii";
            this.comboBoxMarcaMasinii.Size = new System.Drawing.Size(160, 24);
            this.comboBoxMarcaMasinii.TabIndex = 7;
            this.comboBoxMarcaMasinii.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxModelulMasinii
            // 
            this.comboBoxModelulMasinii.FormattingEnabled = true;
            this.comboBoxModelulMasinii.Location = new System.Drawing.Point(584, 135);
            this.comboBoxModelulMasinii.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxModelulMasinii.Name = "comboBoxModelulMasinii";
            this.comboBoxModelulMasinii.Size = new System.Drawing.Size(160, 24);
            this.comboBoxModelulMasinii.TabIndex = 8;
            // 
            // groupBoxDateCumparare
            // 
            this.groupBoxDateCumparare.Controls.Add(this.pictureBox);
            this.groupBoxDateCumparare.Controls.Add(this.textCiv);
            this.groupBoxDateCumparare.Controls.Add(this.labelCiv);
            this.groupBoxDateCumparare.Controls.Add(this.dateTimePicker1);
            this.groupBoxDateCumparare.Controls.Add(this.textCardNumber);
            this.groupBoxDateCumparare.Controls.Add(this.textPrenume);
            this.groupBoxDateCumparare.Controls.Add(this.labelCardNumber);
            this.groupBoxDateCumparare.Controls.Add(this.labelDataExpirare);
            this.groupBoxDateCumparare.Controls.Add(this.labelPrenume);
            this.groupBoxDateCumparare.Controls.Add(this.labelNume);
            this.groupBoxDateCumparare.Controls.Add(this.textNume);
            this.groupBoxDateCumparare.Controls.Add(this.butonCumparare);
            this.groupBoxDateCumparare.Location = new System.Drawing.Point(497, 185);
            this.groupBoxDateCumparare.Name = "groupBoxDateCumparare";
            this.groupBoxDateCumparare.Size = new System.Drawing.Size(499, 294);
            this.groupBoxDateCumparare.TabIndex = 9;
            this.groupBoxDateCumparare.TabStop = false;
            this.groupBoxDateCumparare.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textCiv
            // 
            this.textCiv.Location = new System.Drawing.Point(25, 244);
            this.textCiv.Name = "textCiv";
            this.textCiv.Size = new System.Drawing.Size(90, 22);
            this.textCiv.TabIndex = 10;
            // 
            // labelCiv
            // 
            this.labelCiv.AutoSize = true;
            this.labelCiv.Location = new System.Drawing.Point(22, 212);
            this.labelCiv.Name = "labelCiv";
            this.labelCiv.Size = new System.Drawing.Size(29, 17);
            this.labelCiv.TabIndex = 9;
            this.labelCiv.Text = "CIV";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 149);
            this.dateTimePicker1.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 3, 13, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textCardNumber
            // 
            this.textCardNumber.Location = new System.Drawing.Point(247, 149);
            this.textCardNumber.Name = "textCardNumber";
            this.textCardNumber.Size = new System.Drawing.Size(236, 22);
            this.textCardNumber.TabIndex = 7;
            // 
            // textPrenume
            // 
            this.textPrenume.Location = new System.Drawing.Point(247, 55);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(236, 22);
            this.textPrenume.TabIndex = 6;
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Location = new System.Drawing.Point(244, 113);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(92, 17);
            this.labelCardNumber.TabIndex = 5;
            this.labelCardNumber.Text = "Card Number";
            // 
            // labelDataExpirare
            // 
            this.labelDataExpirare.AutoSize = true;
            this.labelDataExpirare.Location = new System.Drawing.Point(22, 113);
            this.labelDataExpirare.Name = "labelDataExpirare";
            this.labelDataExpirare.Size = new System.Drawing.Size(93, 17);
            this.labelDataExpirare.TabIndex = 4;
            this.labelDataExpirare.Text = "Data expirare";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(244, 25);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(65, 17);
            this.labelPrenume.TabIndex = 3;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(22, 25);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(45, 17);
            this.labelNume.TabIndex = 2;
            this.labelNume.Text = "Nume";
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(25, 55);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(214, 22);
            this.textNume.TabIndex = 1;
            this.textNume.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // butonCumparare
            // 
            this.butonCumparare.Location = new System.Drawing.Point(334, 212);
            this.butonCumparare.Name = "butonCumparare";
            this.butonCumparare.Size = new System.Drawing.Size(149, 54);
            this.butonCumparare.TabIndex = 0;
            this.butonCumparare.Text = "Cumparare";
            this.butonCumparare.UseVisualStyleBackColor = true;
            this.butonCumparare.Click += new System.EventHandler(this.ButonPlataClick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 491);
            this.Controls.Add(this.comboBoxModelulMasinii);
            this.Controls.Add(this.comboBoxMarcaMasinii);
            this.Controls.Add(this.labelModelulMasinii);
            this.Controls.Add(this.labelMarcaMasinii);
            this.Controls.Add(this.butonPlata);
            this.Controls.Add(this.butonResetare);
            this.Controls.Add(this.butonComparareMasini);
            this.Controls.Add(this.groupBoxSpecificatii);
            this.Controls.Add(this.butonDetalii);
            this.Controls.Add(this.groupBoxDateCumparare);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSpecificatii.ResumeLayout(false);
            this.groupBoxSpecificatii.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxDateCumparare.ResumeLayout(false);
            this.groupBoxDateCumparare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSpecificatii;
        private System.Windows.Forms.RadioButton radioButonElectric;
        private System.Windows.Forms.RadioButton radioButonMotorina;
        private System.Windows.Forms.RadioButton radioButonBenzina;
        private System.Windows.Forms.Label labelTransmisie;
        private System.Windows.Forms.Label labelClasaEmisii;
        private System.Windows.Forms.Label labelConsum;
        private System.Windows.Forms.Label labelCombustibil;
        private System.Windows.Forms.Label labelCapacitateCubica;
        private System.Windows.Forms.Label labelPutere;
        private System.Windows.Forms.TextBox textTransmisie;
        private System.Windows.Forms.TextBox textClasaEmisii;
        private System.Windows.Forms.TextBox textCombustibil;
        private System.Windows.Forms.TextBox textCapacitateCubica;
        private System.Windows.Forms.TextBox textPutere;
        private System.Windows.Forms.Button butonDetalii;
        private System.Windows.Forms.Button butonComparareMasini;
        private System.Windows.Forms.Button butonResetare;
        private System.Windows.Forms.Button butonPlata;
        private System.Windows.Forms.Label labelMarcaMasinii;
        private System.Windows.Forms.Label labelModelulMasinii;
        private System.Windows.Forms.ComboBox comboBoxMarcaMasinii;
        private System.Windows.Forms.ComboBox comboBoxModelulMasinii;
        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBoxDateCumparare;
        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.Button butonCumparare;
        private TextBox textCiv;
        private Label labelCiv;
        private DateTimePicker dateTimePicker1;
        private TextBox textCardNumber;
        private TextBox textPrenume;
        private Label labelCardNumber;
        private Label labelDataExpirare;
        private Label labelPrenume;
        private Label labelNume;
    }
}

