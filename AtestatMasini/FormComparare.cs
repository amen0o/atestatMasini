using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtestatMasini
{
    public partial class FormComparare : Form
    {
        public FormComparare()
        {
            InitializeComponent();
        }


        private void FormComparare_Load(object sender, EventArgs e)
        {
            comboBoxMarcaMasinii.Items.Add("Audi");
            comboBoxMarcaMasinii.Items.Add("Dacia");
            comboBoxMarcaMasinii.Items.Add("Ford");
            comboBoxMarcaMasinii.Items.Add("Jeep");
            comboBoxMarcaMasinii.Items.Add("Mercedes-Benz");
            comboBoxMarcaMasinii.Items.Add("Opel");
            comboBoxMarcaMasinii.Items.Add("Peugeot");
            comboBoxMarcaMasinii.Items.Add("Renault");
            comboBoxMarcaMasinii.Items.Add("Skoda");
            comboBoxMarcaMasinii.Items.Add("Tesla");
            comboBoxMarcaMasinii.Items.Add("Volkswagen");
            comboBoxMarcaMasinii.Items.Add("Volvo");

            comboBox1.Items.Add("Audi");
            comboBox1.Items.Add("Dacia");
            comboBox1.Items.Add("Ford");
            comboBox1.Items.Add("Jeep");
            comboBox1.Items.Add("Mercedes-Benz");
            comboBox1.Items.Add("Opel");
            comboBox1.Items.Add("Peugeot");
            comboBox1.Items.Add("Renault");
            comboBox1.Items.Add("Skoda");
            comboBox1.Items.Add("Tesla");
            comboBox1.Items.Add("Volkswagen");
            comboBox1.Items.Add("Volvo");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            #region Modele Audi
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Add("A3");
                comboBox2.Items.Add("A4");
                comboBox2.Items.Add("A5");
                comboBox2.Items.Add("A6");
                comboBox2.Items.Add("A7");
                comboBox2.Items.Add("A8");
            }
            #endregion
            #region Modele Dacia
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Add("1310");
                comboBox2.Items.Add("Duster");
                comboBox2.Items.Add("Logan");
                comboBox2.Items.Add("Sandero");
            }
            #endregion
            #region Modele Ford
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Add("Fiesta");
                comboBox2.Items.Add("Focus");
                comboBox2.Items.Add("Galaxy");
                comboBox2.Items.Add("Mustang");
            }
            #endregion
            #region Modele Jeep
            if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Items.Add("Cherokee");
                comboBox2.Items.Add("Renegade");
                comboBox2.Items.Add("Wrangler");
            }
            #endregion
            #region Modele Mercedes-Benz
            if (comboBox1.SelectedIndex == 4)
            {
                comboBox2.Items.Add("AMG");
                comboBox2.Items.Add("C Class");
                comboBox2.Items.Add("E Class");
                comboBox2.Items.Add("S Class");
                comboBox2.Items.Add("Sprinter");
            }
            #endregion
            #region Modele Opel
            if (comboBox1.SelectedIndex == 5)
            {
                comboBox2.Items.Add("Astra");
                comboBox2.Items.Add("Corsa");
                comboBox2.Items.Add("Crossland X");
                comboBox2.Items.Add("Insigna");
                comboBox2.Items.Add("Tigra");
            }
            #endregion
            #region Modele Peugeot
            if (comboBox1.SelectedIndex == 6)
            {
                comboBox2.Items.Add("208");
                comboBox2.Items.Add("308");
            }
            #endregion
            #region Modele Renault
            if (comboBox1.SelectedIndex == 7)
            {
                comboBox2.Items.Add("Clio");
                comboBox2.Items.Add("Laguna");
                comboBox2.Items.Add("Megane");
            }
            #endregion
            #region Modele Skoda
            if (comboBox1.SelectedIndex == 8)
            {
                comboBox2.Items.Add("Fabia");
                comboBox2.Items.Add("Octavia");
                comboBox2.Items.Add("Yeti");
            }
            #endregion
            #region Modele Tesla
            if (comboBox1.SelectedIndex == 9)
            {
                comboBox2.Items.Add("Model 3");
                comboBox2.Items.Add("Model S");
                comboBox2.Items.Add("Model X");
                comboBox2.Items.Add("Roadster");
            }
            #endregion
            #region Modele Volkswagen
            if (comboBox1.SelectedIndex == 10)
            {
                comboBox2.Items.Add("Arteon");
                comboBox2.Items.Add("Golf 6");
                comboBox2.Items.Add("Jetta");
                comboBox2.Items.Add("Passat");
                comboBox2.Items.Add("Touareg");
            }
            #endregion
            #region Modele Volvo
            if (comboBox1.SelectedIndex == 11)
            {
                comboBox2.Items.Add("S90");
                comboBox2.Items.Add("V90");
                comboBox2.Items.Add("XC90");
            }
            #endregion
        }

        private void comboMarcaMasinii_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModelulMasinii.Items.Clear();
            #region Modele Audi
            if (comboBoxMarcaMasinii.SelectedIndex == 0)
            {
                comboBoxModelulMasinii.Items.Add("A3");
                comboBoxModelulMasinii.Items.Add("A4");
                comboBoxModelulMasinii.Items.Add("A5");
                comboBoxModelulMasinii.Items.Add("A6");
                comboBoxModelulMasinii.Items.Add("A7");
                comboBoxModelulMasinii.Items.Add("A8");
            }
            #endregion
            #region Modele Dacia
            if (comboBoxMarcaMasinii.SelectedIndex == 1)
            {
                comboBoxModelulMasinii.Items.Add("1310");
                comboBoxModelulMasinii.Items.Add("Duster");
                comboBoxModelulMasinii.Items.Add("Logan");
                comboBoxModelulMasinii.Items.Add("Sandero");
            }
            #endregion
            #region Modele Ford
            if (comboBoxMarcaMasinii.SelectedIndex == 2)
            {
                comboBoxModelulMasinii.Items.Add("Fiesta");
                comboBoxModelulMasinii.Items.Add("Focus");
                comboBoxModelulMasinii.Items.Add("Galaxy");
                comboBoxModelulMasinii.Items.Add("Mustang");
            }
            #endregion
            #region Modele Jeep
            if (comboBoxMarcaMasinii.SelectedIndex == 3)
            {
                comboBoxModelulMasinii.Items.Add("Cherokee");
                comboBoxModelulMasinii.Items.Add("Renegade");
                comboBoxModelulMasinii.Items.Add("Wrangler");
            }
            #endregion
            #region Modele Mercedes-Benz
            if (comboBoxMarcaMasinii.SelectedIndex == 4)
            {
                comboBoxModelulMasinii.Items.Add("AMG");
                comboBoxModelulMasinii.Items.Add("C Class");
                comboBoxModelulMasinii.Items.Add("E Class");
                comboBoxModelulMasinii.Items.Add("S Class");
                comboBoxModelulMasinii.Items.Add("Sprinter");
            }
            #endregion
            #region Modele Opel
            if (comboBoxMarcaMasinii.SelectedIndex == 5)
            {
                comboBoxModelulMasinii.Items.Add("Astra");
                comboBoxModelulMasinii.Items.Add("Corsa");
                comboBoxModelulMasinii.Items.Add("Crossland X");
                comboBoxModelulMasinii.Items.Add("Insigna");
                comboBoxModelulMasinii.Items.Add("Tigra");
            }
            #endregion
            #region Modele Peugeot
            if (comboBoxMarcaMasinii.SelectedIndex == 6)
            {
                comboBoxModelulMasinii.Items.Add("208");
                comboBoxModelulMasinii.Items.Add("308");
            }
            #endregion
            #region Modele Renault
            if (comboBoxMarcaMasinii.SelectedIndex == 7)
            {
                comboBoxModelulMasinii.Items.Add("Clio");
                comboBoxModelulMasinii.Items.Add("Laguna");
                comboBoxModelulMasinii.Items.Add("Megane");
            }
            #endregion
            #region Modele Skoda
            if (comboBoxMarcaMasinii.SelectedIndex == 8)
            {
                comboBoxModelulMasinii.Items.Add("Fabia");
                comboBoxModelulMasinii.Items.Add("Octavia");
                comboBoxModelulMasinii.Items.Add("Yeti");
            }
            #endregion
            #region Modele Tesla
            if (comboBoxMarcaMasinii.SelectedIndex == 9)
            {
                comboBoxModelulMasinii.Items.Add("Model 3");
                comboBoxModelulMasinii.Items.Add("Model S");
                comboBoxModelulMasinii.Items.Add("Model X");
                comboBoxModelulMasinii.Items.Add("Roadster");
            }
            #endregion
            #region Modele Volkswagen
            if (comboBoxMarcaMasinii.SelectedIndex == 10)
            {
                comboBoxModelulMasinii.Items.Add("Arteon");
                comboBoxModelulMasinii.Items.Add("Golf 6");
                comboBoxModelulMasinii.Items.Add("Jetta");
                comboBoxModelulMasinii.Items.Add("Passat");
                comboBoxModelulMasinii.Items.Add("Touareg");
            }
            #endregion
            #region Modele Volvo
            if (comboBoxMarcaMasinii.SelectedIndex == 11)
            {
                comboBoxModelulMasinii.Items.Add("S90");
                comboBoxModelulMasinii.Items.Add("V90");
                comboBoxModelulMasinii.Items.Add("XC90");
            }
            #endregion
        }

        private void ButonComparareOnClick(object sender, EventArgs e)
        {
            //Audi
            #region Audi

            if (comboBoxMarcaMasinii.Text == "Audi")
            {
                if (comboBoxModelulMasinii.Text == "A3")
                {
                    textPutere.Text = "110 HP";
                    textCapacitateCubica.Text = "1.6 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "4.5 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                }

                if (comboBoxModelulMasinii.Text == "A4")
                {
                    textPutere.Text = "190 HP";
                    textCapacitateCubica.Text = "2.0 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "4.7 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                }

                if (comboBoxModelulMasinii.Text == "A5")
                {
                    textPutere.Text = "179 HP";
                    textCapacitateCubica.Text = "2.0 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "6.4 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                }

                if (comboBoxModelulMasinii.Text == "A6")
                {
                    textPutere.Text = "204 HP";
                    textCapacitateCubica.Text = "2.0 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "5.3 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Automatic";
                }

                if (comboBoxModelulMasinii.Text == "A7")
                {
                    textPutere.Text = "252 HP";
                    textCapacitateCubica.Text = "2.0 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "5.9 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                }

                if (comboBoxModelulMasinii.Text == "A8")
                {
                    textPutere.Text = "351 HP";
                    textCapacitateCubica.Text = "4.1 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "7.6 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Automatic";
                }
            }
            #endregion
            //Dacia
            #region Dacia
            if (comboBoxMarcaMasinii.Text == "Dacia")
            {
                if (comboBoxModelulMasinii.Text == "1310")
                {
                    textPutere.Text = "50 HP";
                    radioButonBenzina.PerformClick();
                    textCapacitateCubica.Text = "1.3 L";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "Duster")
                {
                    textPutere.Text = "110 HP";
                    textCapacitateCubica.Text = "1.5 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "5.2 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "Logan")
                {
                    textPutere.Text = "75 HP";
                    textCapacitateCubica.Text = "1.2 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "5.8 L/100 km";
                    textCombustibil.Text = "Euro4";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "Sandero")
                {
                    textPutere.Text = "90 HP";
                    textCapacitateCubica.Text = "0.9 L";
                    radioButonElectric.PerformClick();
                    textClasaEmisii.Text = "5.5 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                }
            }
            #endregion
            //Ford
            #region Ford
            if (comboBoxMarcaMasinii.Text == "Ford")
            {
                if (comboBoxModelulMasinii.Text == "Fiesta")
                {
                    textPutere.Text = "182 HP";
                    textCapacitateCubica.Text = "1.6 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "5.9 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "Focus")
                {
                    textPutere.Text = "250 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "6.2 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "Galaxy")
                {
                    textPutere.Text = "163 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "6.0 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Automatic";
                }
                if (comboBoxModelulMasinii.Text == "Mustang")
                {
                    textPutere.Text = "421 HP";
                    textCapacitateCubica.Text = "5 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "12 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Automatic";
                }
            }
            #endregion
            //Jeep
            #region Jeep
            if (comboBoxMarcaMasinii.Text == "Jeep")
            {
                if (comboBoxModelulMasinii.Text == "Cherokee")
                {
                    textPutere.Text = "170 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "5.8 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Autoamtic";
                }
                if (comboBoxModelulMasinii.Text == "Renegade")
                {
                    textPutere.Text = "150 HP";
                    textCapacitateCubica.Text = "1.3 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "6.4 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                }
                if (comboBoxModelulMasinii.Text == "Wrangler")
                {
                    textPutere.Text = "200 HP";
                    textCapacitateCubica.Text = "2.1 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "7.4 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                }
            }
            #endregion
            //Mercedes-Benz
            #region Mercedes-Benz
            if (comboBoxMarcaMasinii.Text == "Mercedes-Benz")
            {
                if (comboBoxModelulMasinii.Text == "AMG")
                {
                    textPutere.Text = "571 HP";
                    textCapacitateCubica.Text = "6.2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "13.2 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                }
                if (comboBoxModelulMasinii.Text == "C Class")
                {
                    textPutere.Text = "156 HP";
                    textCapacitateCubica.Text = "1.6 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "6.3 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                }
                if (comboBoxModelulMasinii.Text == "E Class")
                {
                    textPutere.Text = "170 HP";
                    textCapacitateCubica.Text = "2.2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "4.9 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Automatic";
                }
                if (comboBoxModelulMasinii.Text == "S Class")
                {
                    textPutere.Text = "455 HP";
                    textCapacitateCubica.Text = "4.7 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "9.2 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                }
                if (comboBoxModelulMasinii.Text == "Sprinter")
                {
                    textPutere.Text = "163 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "8 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                }
            }
            #endregion
            //Opel
            #region Opel
            if (comboBoxMarcaMasinii.Text == "Opel")
            {
                if (comboBoxModelulMasinii.Text == "Astra")
                {
                    textPutere.Text = "280 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "8.1 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "Corsa")
                {
                    textPutere.Text = "90 HP";
                    textCapacitateCubica.Text = "1.4 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "5.2 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "Crossland X")
                {
                    textPutere.Text = "110 HP";
                    textCapacitateCubica.Text = "1.2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "4.9 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "Insigna")
                {
                    textPutere.Text = "260 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "8.6 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                }
                if (comboBoxModelulMasinii.Text == "Tigra")
                {
                    textPutere.Text = "90 HP";
                    textCapacitateCubica.Text = "1.4 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "6.1 L/100 km";
                    textCombustibil.Text = "Euro4";
                    textTransmisie.Text = "Manual";
                }
            }
            #endregion
            //Peugeot
            #region Peugeot
            if (comboBoxMarcaMasinii.Text == "Peugeot")
            {
                if (comboBoxModelulMasinii.Text == "208")
                {
                    textPutere.Text = "156 HP";
                    textCapacitateCubica.Text = "1.6 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "5.8 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "308")
                {
                    textPutere.Text = "156 HP";
                    textCapacitateCubica.Text = "1.6 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "7.7 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Automatic";
                }
            }
            #endregion
            //Renault
            #region Renault
            if (comboBoxMarcaMasinii.Text == "Renault")
            {
                if (comboBoxModelulMasinii.Text == "Clio")
                {
                    textPutere.Text = "118 HP";
                    textCapacitateCubica.Text = "1.2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "5.3 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "Laguna")
                {
                    textPutere.Text = "173 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "5.7 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "Megane")
                {
                    textPutere.Text = "265 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "7.5 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                }
            }
            #endregion
            //Skoda
            #region Skoda
            if (comboBoxMarcaMasinii.Text == "Skoda")
            {
                if (comboBoxModelulMasinii.Text == "Fabia")
                {
                    textPutere.Text = "90 HP";
                    textCapacitateCubica.Text = "1.4 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "3.6 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "Octavia")
                {
                    textPutere.Text = "220 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "6.2 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                }
                if (comboBoxModelulMasinii.Text == "Yeti")
                {
                    textPutere.Text = "122 HP";
                    textCapacitateCubica.Text = "1.4 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "6.8 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                }
            }
            #endregion
            //Tesla
            #region Tesla
            if (comboBoxMarcaMasinii.Text == "Tesla")
            {
                if (comboBoxModelulMasinii.Text == "Model 3")
                {
                    textPutere.Text = "484 HP";
                    textCapacitateCubica.Text = " ";
                    radioButonElectric.PerformClick();
                    textClasaEmisii.Text = " L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                }
                if (comboBoxModelulMasinii.Text == "Model S")
                {
                    textPutere.Text = "306 HP";
                    textCapacitateCubica.Text = " ";
                    radioButonElectric.PerformClick();
                    textClasaEmisii.Text = " L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                }
                if (comboBoxModelulMasinii.Text == "Model X")
                {
                    textPutere.Text = "328 HP";
                    textCapacitateCubica.Text = " ";
                    radioButonElectric.PerformClick();
                    textClasaEmisii.Text = " L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                }
                if (comboBoxModelulMasinii.Text == "Roadster")
                {
                    textPutere.Text = "292 HP";
                    textCapacitateCubica.Text = " ";
                    radioButonElectric.PerformClick();
                    textClasaEmisii.Text = " L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                }
            }
            #endregion
            //Volkswagen
            #region Volkswagen
            if (comboBoxMarcaMasinii.Text == "Volkswagen")
            {
                if (comboBoxModelulMasinii.Text == "Arteon")
                {
                    textPutere.Text = "150 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "4.4 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "Golf 6")
                {
                    textPutere.Text = "160 HP";
                    textCapacitateCubica.Text = "1.4 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "6.3 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "Jetta")
                {
                    textPutere.Text = "192 HP";
                    textCapacitateCubica.Text = "2.4 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "6.4 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "Passat")
                {
                    textPutere.Text = "160 HP";
                    textCapacitateCubica.Text = "1.8 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "7.3 L/100 km";
                    textCombustibil.Text = "Euro4";
                    textTransmisie.Text = "Automatic";
                }
                if (comboBoxModelulMasinii.Text == "Touareg")
                {
                    textPutere.Text = "245 HP";
                    textCapacitateCubica.Text = "3 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "9 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Automatic";
                }
            }
            #endregion
            //Volvo
            #region Volvo
            if (comboBoxMarcaMasinii.Text == "Volvo")
            {
                if (comboBoxModelulMasinii.Text == "S90")
                {
                    textPutere.Text = "320 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "7.2 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                }
                if (comboBoxModelulMasinii.Text == "V90")
                {
                    textPutere.Text = "190 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "4.5 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                }
                if (comboBoxModelulMasinii.Text == "XC90")
                {
                    textPutere.Text = "224 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "5.7 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                }
            }
            #endregion

            //Audi
            #region Audi

            if (comboBox1.Text == "Audi")
            {
                if (comboBox2.Text == "A3")
                {
                    textBox1.Text = "110 HP";
                    textBox2.Text = "1.6 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "4.5 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "A4")
                {
                    textBox1.Text = "190 HP";
                    textBox2.Text = "2.0 L";
                    radioButton2.PerformClick();
                    textBox4.Text = "4.7 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "A5")
                {
                    textBox1.Text = "179 HP";
                    textBox2.Text = "2.0 L";
                    radioButton2.PerformClick();
                    textBox4.Text = "6.4 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "A6")
                {
                    textBox1.Text = "204 HP";
                    textBox2.Text = "2.0 L";
                    radioButton2.PerformClick();
                    textBox4.Text = "5.3 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Automatic";
                }
                if (comboBox2.Text == "A7")
                {
                    textBox1.Text = "252 HP";
                    textBox2.Text = "2.0 L";
                    radioButton2.PerformClick();
                    textBox4.Text = "5.9 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Automatic";
                }
                if (comboBox2.Text == "A8")
                {
                    textBox1.Text = "351 HP";
                    textBox2.Text = "4.1 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "7.6 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Automatic";
                }
            }
            #endregion
            //Dacia
            #region Dacia
            if (comboBox1.Text == "Dacia")
            {
                if (comboBox2.Text == "1310")
                {
                    textBox1.Text = "50 HP";
                    radioButton1.PerformClick();
                    textBox2.Text = "1.3 L";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "Duster")
                {
                    textBox1.Text = "110 HP";
                    textBox2.Text = "1.5 L";
                    radioButton2.PerformClick();
                    textBox4.Text = "5.2 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "Logan")
                {
                    textBox1.Text = "75 HP";
                    textBox2.Text = "1.2 L";
                    radioButton2.PerformClick();
                    textBox4.Text = "5.8 L/100 km";
                    textBox3.Text = "Euro4";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "Sandero")
                {
                    textBox1.Text = "90 HP";
                    textBox2.Text = "0.9 L";
                    radioButton3.PerformClick();
                    textBox4.Text = "5.5 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Automatic";
                }
            }
            #endregion
            //Ford
            #region Ford
            if (comboBox1.Text == "Ford")
            {
                if (comboBox2.Text == "Fiesta")
                {
                    textBox1.Text = "182 HP";
                    textBox2.Text = "1.6 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "5.9 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "Focus")
                {
                    textBox1.Text = "250 HP";
                    textBox2.Text = "2 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "6.2 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "Galaxy")
                {
                    textBox1.Text = "163 HP";
                    textBox2.Text = "2 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "6.0 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Automatic";
                }
                if (comboBox2.Text == "Mustang")
                {
                    textBox1.Text = "421 HP";
                    textBox2.Text = "5 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "12 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Automatic";
                }
            }
            #endregion
            //Jeep
            #region Jeep
            if (comboBox1.Text == "Jeep")
            {
                if (comboBox2.Text == "Cherokee")
                {
                    textBox1.Text = "170 HP";
                    textBox2.Text = "2 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "5.8 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Autoamtic";
                }
                if (comboBox2.Text == "Renegade")
                {
                    textBox1.Text = "150 HP";
                    textBox2.Text = "1.3 L";
                    radioButton2.PerformClick();
                    textBox4.Text = "6.4 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Automatic";
                }
                if (comboBox2.Text == "Wrangler")
                {
                    textBox1.Text = "200 HP";
                    textBox2.Text = "2.1 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "7.4 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Automatic";
                }
            }
            #endregion
            //Mercedes-Benz
            #region Mercedes-Benz
            if (comboBox1.Text == "Mercedes-Benz")
            {
                if (comboBox2.Text == "AMG")
                {
                    textBox1.Text = "571 HP";
                    textBox2.Text = "6.2 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "13.2 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Automatic";
                }
                if (comboBox2.Text == "C Class")
                {
                    textBox1.Text = "156 HP";
                    textBox2.Text = "1.6 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "6.3 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Automatic";
                }
                if (comboBox2.Text == "E Class")
                {
                    textBox1.Text = "170 HP";
                    textBox2.Text = "2.2 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "4.9 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Automatic";
                }
                if (comboBox2.Text == "S Class")
                {
                    textBox1.Text = "455 HP";
                    textBox2.Text = "4.7 L";
                    radioButton2.PerformClick();
                    textBox4.Text = "9.2 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Automatic";
                }
                if (comboBox2.Text == "Sprinter")
                {
                    textBox1.Text = "163 HP";
                    textBox2.Text = "2 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "8 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Manual";
                }
            }
            #endregion
            //Opel
            #region Opel
            if (comboBox1.Text == "Opel")
            {
                if (comboBox2.Text == "Astra")
                {
                    textBox1.Text = "280 HP";
                    textBox2.Text = "2 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "8.1 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "Corsa")
                {
                    textBox1.Text = "90 HP";
                    textBox2.Text = "1.4 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "5.2 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "Crossland X")
                {
                    textBox1.Text = "110 HP";
                    textBox2.Text = "1.2 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "4.9 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "Insigna")
                {
                    textBox1.Text = "260 HP";
                    textBox2.Text = "2 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "8.6 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Automatic";
                }
                if (comboBox2.Text == "Tigra")
                {
                    textBox1.Text = "90 HP";
                    textBox2.Text = "1.4 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "6.1 L/100 km";
                    textBox3.Text = "Euro4";
                    textBox5.Text = "Manual";
                }
            }
            #endregion
            //Peugeot
            #region Peugeot
            if (comboBox1.Text == "Peugeot")
            {
                if (comboBox2.Text == "208")
                {
                    textBox1.Text = "156 HP";
                    textBox2.Text = "1.6 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "5.8 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "308")
                {
                    textBox1.Text = "156 HP";
                    textBox2.Text = "1.6 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "7.7 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Automatic";
                }
            }
            #endregion
            //Renault
            #region Renault
            if (comboBox1.Text == "Renault")
            {
                if (comboBox2.Text == "Clio")
                {
                    textBox1.Text = "118 HP";
                    textBox2.Text = "1.2 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "5.3 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "Laguna")
                {
                    textBox1.Text = "173 HP";
                    textBox2.Text = "2 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "5.7 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "Megane")
                {
                    textBox1.Text = "265 HP";
                    textBox2.Text = "2 L";
                    radioButton2.PerformClick();
                    textBox4.Text = "7.5 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Manual";
                }
            }
            #endregion
            //Skoda
            #region Skoda
            if (comboBox1.Text == "Skoda")
            {
                if (comboBox2.Text == "Fabia")
                {
                    textBox1.Text = "90 HP";
                    textBox2.Text = "1.4 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "3.6 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "Octavia")
                {
                    textBox1.Text = "220 HP";
                    textBox2.Text = "2 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "6.2 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Automatic";
                }
                if (comboBox2.Text == "Yeti")
                {
                    textBox1.Text = "122 HP";
                    textBox2.Text = "1.4 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "6.8 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Manual";
                }
            }
            #endregion
            //Tesla
            #region Tesla
            if (comboBox1.Text == "Tesla")
            {
                if (comboBox2.Text == "Model 3")
                {
                    textBox1.Text = "484 HP";
                    textBox2.Text = " ";
                    radioButton3.PerformClick();
                    textBox4.Text = " L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Automatic";
                }
                if (comboBox2.Text == "Model S")
                {
                    textBox1.Text = "306 HP";
                    textBox2.Text = " ";
                    radioButton3.PerformClick();
                    textBox4.Text = " L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Automatic";
                }
                if (comboBox2.Text == "Model X")
                {
                    textBox1.Text = "328 HP";
                    textBox2.Text = " ";
                    radioButton3.PerformClick();
                    textBox4.Text = " L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Automatic";
                }
                if (comboBox2.Text == "Roadster")
                {
                    textBox1.Text = "292 HP";
                    textBox2.Text = " ";
                    radioButton3.PerformClick();
                    textBox4.Text = " L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Automatic";
                }
            }
            #endregion
            //Volkswagen
            #region Volkswagen
            if (comboBox1.Text == "Volkswagen")
            {
                if (comboBox2.Text == "Arteon")
                {
                    textBox1.Text = "150 HP";
                    textBox2.Text = "2 L";
                    radioButton2.PerformClick();
                    textBox4.Text = "4.4 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "Golf 6")
                {
                    textBox1.Text = "160 HP";
                    textBox2.Text = "1.4 L";
                    radioButton2.PerformClick();
                    textBox4.Text = "6.3 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "Jetta")
                {
                    textBox1.Text = "192 HP";
                    textBox2.Text = "2.4 L";
                    radioButton2.PerformClick();
                    textBox4.Text = "6.4 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "Passat")
                {
                    textBox1.Text = "160 HP";
                    textBox2.Text = "1.8 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "7.3 L/100 km";
                    textBox3.Text = "Euro4";
                    textBox5.Text = "Automatic";
                }
                if (comboBox2.Text == "Touareg")
                {
                    textBox1.Text = "245 HP";
                    textBox2.Text = "3 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "9 L/100 km";
                    textBox3.Text = "Euro5";
                    textBox5.Text = "Automatic";
                }
            }
            #endregion
            //Volvo
            #region Volvo
            if (comboBox1.Text == "Volvo")
            {
                if (comboBox2.Text == "S90")
                {
                    textBox1.Text = "320 HP";
                    textBox2.Text = "2 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "7.2 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Manual";
                }
                if (comboBox2.Text == "V90")
                {
                    textBox1.Text = "190 HP";
                    textBox2.Text = "2 L";
                    radioButton1.PerformClick();
                    textBox4.Text = "4.5 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Automatic";
                }
                if (comboBox2.Text == "XC90")
                {
                    textBox1.Text = "224 HP";
                    textBox2.Text = "2 L";
                    radioButton2.PerformClick();
                    textBox4.Text = "5.7 L/100 km";
                    textBox3.Text = "Euro6";
                    textBox5.Text = "Automatic";
                }
            }
            #endregion
        }
    }
}
