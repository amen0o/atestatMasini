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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        private void butonDetalii_Click(object sender, EventArgs e)
        {
            groupBoxDateCumparare.SendToBack();
            pictureBox.BringToFront();
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
                    pictureBox.ImageLocation =
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/d/db/2018_Audi_A3_Sport_TDi_Saloon_1.5_Front.jpg/280px-2018_Audi_A3_Sport_TDi_Saloon_1.5_Front.jpg";
                }

                if (comboBoxModelulMasinii.Text == "A4")
                {
                    textPutere.Text = "190 HP";
                    textCapacitateCubica.Text = "2.0 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "4.7 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation =
                        "https://i2.wp.com/happywalletadventures.com/wp-content/uploads/2019/04/2017_Audi_A4_8W_sport_quattro_sedan_2018-10-19_01.jpg?fit=4234%2C1982&ssl=1";
                }

                if (comboBoxModelulMasinii.Text == "A5")
                {
                    textPutere.Text = "179 HP";
                    textCapacitateCubica.Text = "2.0 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "6.4 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation =
                        "https://static2.ladnefelgi.pl/eng_pl_ALLOYS-17-5X112-AUDI-A3-S3-A4-A5-A7-A8-Q5-37603_3.jpg";
                }

                if (comboBoxModelulMasinii.Text == "A6")
                {
                    textPutere.Text = "204 HP";
                    textCapacitateCubica.Text = "2.0 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "5.3 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://www.321rentacar.ro/images/cars/audi-a6.png";
                }

                if (comboBoxModelulMasinii.Text == "A7")
                {
                    textPutere.Text = "252 HP";
                    textCapacitateCubica.Text = "2.0 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "5.9 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://www.cars2buy.co.uk/images/car/1200/92234.jpg";
                }

                if (comboBoxModelulMasinii.Text == "A8")
                {
                    textPutere.Text = "351 HP";
                    textCapacitateCubica.Text = "4.1 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "7.6 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://ksassets.timeincuk.net/wp/uploads/sites/54/2017/08/02-8.jpeg";
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
                    pictureBox.ImageLocation = "https://cdn.auto.ro/assets/image/2018-07/24/85546/626x471/224412867_5_1000x700_dacia-1300-de-tranzitie-alba.jpg";
                }
                if (comboBoxModelulMasinii.Text == "Duster")
                {
                    textPutere.Text = "110 HP";
                    textCapacitateCubica.Text = "1.5 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "5.2 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://images-na.ssl-images-amazon.com/images/I/61aw0RcIKfL._SL1500_.jpg";
                }
                if (comboBoxModelulMasinii.Text == "Logan")
                {
                    textPutere.Text = "75 HP";
                    textCapacitateCubica.Text = "1.2 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "5.8 L/100 km";
                    textCombustibil.Text = "Euro4";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://media.autoblog.md/2019/11/Dacia-Logan-Stepway_1.jpg";
                }
                if (comboBoxModelulMasinii.Text == "Sandero")
                {
                    textPutere.Text = "90 HP";
                    textCapacitateCubica.Text = "0.9 L";
                    radioButonElectric.PerformClick();
                    textClasaEmisii.Text = "5.5 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://lh3.googleusercontent.com/proxy/qbEhOiXSFfNwxbZCWBJm35ENrComf4SZNuYiClu65Uy0fiNksPoYvnLLA4jEdS8mve4bA4DpRwYzXjsEkcOFn3vpuvFYs0SdXz9OfW5eKGADPSJmsSpOG1mzx7CdT5mrSnhTnaU82GupjAw67GeRzdYJd3dJJugfzlqx";
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
                    pictureBox.ImageLocation = "http://www.fordfan.de/fotosgallery/ford-fiesta-st-magnetic_642/images/2018FordFiesta_MAGNETIC_ST_02.jpg";
                }
                if (comboBoxModelulMasinii.Text == "Focus")
                {
                    textPutere.Text = "250 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "6.2 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://car-pictures.cars.com/images/?IMG=USC60FOC123B021001.jpg";
                }
                if (comboBoxModelulMasinii.Text == "Galaxy")
                {
                    textPutere.Text = "163 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "6.0 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://cdn.motor1.com/images/mgl/gbkOo/s1/2017-ford-galaxy.jpg";
                }
                if (comboBoxModelulMasinii.Text == "Mustang")
                {
                    textPutere.Text = "421 HP";
                    textCapacitateCubica.Text = "5 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "12 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://images.hdqwalls.com/download/ford-mustang-gt-fastback-2018-4b-3840x2400.jpg";
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
                    pictureBox.ImageLocation = "https://s3.amazonaws.com/drivechicago/inventory/1C4PJMDX2LD591178/1C4PJMDX2LD591178-d.jpg";
                }
                if (comboBoxModelulMasinii.Text == "Renegade")
                {
                    textPutere.Text = "150 HP";
                    textCapacitateCubica.Text = "1.3 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "6.4 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://s.response.jp/imgs/p/XHAW6qEKbkuCIphd0G23SChK-0PFQkNERUZH/1404424.jpg";
                }
                if (comboBoxModelulMasinii.Text == "Wrangler")
                {
                    textPutere.Text = "200 HP";
                    textCapacitateCubica.Text = "2.1 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "7.4 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://tdrvehicles2.azureedge.net/photos/chrome/Expanded/White/2016JES160001/2016JES16000101.jpg?w=1200";
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
                    pictureBox.ImageLocation = "https://images.autotrader.com/hn/c/40a14c26ac934f58956d74874f2fedae.jpg";
                }
                if (comboBoxModelulMasinii.Text == "C Class")
                {
                    textPutere.Text = "156 HP";
                    textCapacitateCubica.Text = "1.6 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "6.3 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://m.atcdn.co.uk/vms/media/w1200/98d98d5f62e647a38bbcb39afb1bccc5.jpg";
                }
                if (comboBoxModelulMasinii.Text == "E Class")
                {
                    textPutere.Text = "170 HP";
                    textCapacitateCubica.Text = "2.2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "4.9 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://www.cars-data.com/pictures/mercedes/mercedes-benz-e-class-coupe_3888_15.jpg";
                }
                if (comboBoxModelulMasinii.Text == "S Class")
                {
                    textPutere.Text = "455 HP";
                    textCapacitateCubica.Text = "4.7 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "9.2 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://blog.clubmercedes.ro/wp-content/uploads/2017/07/Mercedes-Benz-S-Class-S-500_4.jpg";
                }
                if (comboBoxModelulMasinii.Text == "Sprinter")
                {
                    textPutere.Text = "163 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "8 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://http2.mlstatic.com/D_NQ_NP_961432-MLA40353256887_012020-O.webp";
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
                    pictureBox.ImageLocation = "https://cdn2.autocentre.ua/wp-content/uploads/2019/07/opel-astra-2019-8.jpg?resize=770x440";
                }
                if (comboBoxModelulMasinii.Text == "Corsa")
                {
                    textPutere.Text = "90 HP";
                    textCapacitateCubica.Text = "1.4 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "5.2 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://img.chceauto.pl/opel/corsa/opel-corsa-hatchback-5-drzwiowy-4199-44492_head.jpg";
                }
                if (comboBoxModelulMasinii.Text == "Crossland X")
                {
                    textPutere.Text = "110 HP";
                    textCapacitateCubica.Text = "1.2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "4.9 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://www.motori.gr/sites/default/files/styles/sliderview/public/newsartimages/2017/11/30/photon23328f60729.jpg?itok=9A7m2506";
                }
                if (comboBoxModelulMasinii.Text == "Insigna")
                {
                    textPutere.Text = "260 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "8.6 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://dreamcar.ua/wp-content/uploads/2019/12/opel-insignia-2020-1.jpg";
                }
                if (comboBoxModelulMasinii.Text == "Tigra")
                {
                    textPutere.Text = "90 HP";
                    textCapacitateCubica.Text = "1.4 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "6.1 L/100 km";
                    textCombustibil.Text = "Euro4";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://prod.pictures.autoscout24.net/listing-images/30a2344f-d500-4b5a-8b53-e71b842fc525_eb527a2d-e93a-429d-a872-76bb7573e13a.jpg/420x315.jpg";
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
                    pictureBox.ImageLocation = "https://cdn.motor1.com/images/mgl/X94Al/s1/electric-peugeot-e-208-in-detail-specs-images-videos.jpg";
                }
                if (comboBoxModelulMasinii.Text == "308")
                {
                    textPutere.Text = "156 HP";
                    textCapacitateCubica.Text = "1.6 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "7.7 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://testna-voznja.avtohisa-vic.si/assets/images/308SW/exterior.jpg";
                }
            }
            #endregion
            //Renault
            #region Renault
            if (comboBoxMarcaMasinii.Text == "Renault")
            {
                if(comboBoxModelulMasinii.Text == "Clio")
                {
                    textPutere.Text = "118 HP";
                    textCapacitateCubica.Text = "1.2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "5.3 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://i.ebayimg.com/00/s/MTA0N1gxNjAw/z/ytIAAOSwyaNePBYh/$_59.PNG";
                }
                if(comboBoxModelulMasinii.Text == "Laguna")
                {
                    textPutere.Text = "173 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "5.7 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://img.autoplus.fr/picture/renault/laguna/1465058/renault_laguna_2013_bf22a-1200-800.jpg";
                }
                if(comboBoxModelulMasinii.Text == "Megane")
                {
                    textPutere.Text = "265 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "7.5 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://3d-car-shows.com/wp-content/uploads/2015/09/renault-megane-gt.jpg";
                }
            }
            #endregion
            //Skoda
            #region Skoda
            if(comboBoxMarcaMasinii.Text == "Skoda")
            {
                if(comboBoxModelulMasinii.Text =="Fabia")
                {
                    textPutere.Text = "90 HP";
                    textCapacitateCubica.Text = "1.4 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "3.6 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://m.zrkuban.ru/pic/skoda-fabia-combi-scoutline.jpg";
                }
                if(comboBoxModelulMasinii.Text == "Octavia")
                {
                    textPutere.Text = "220 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "6.2 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://i.infocar.ua/i/12/6018/1400x936.jpg";
                }
                if(comboBoxModelulMasinii.Text == "Yeti")
                {
                    textPutere.Text = "122 HP";
                    textCapacitateCubica.Text = "1.4 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "6.8 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://img2.auto.cz/img/29/full/4706786_.jpg";
                }
            }
            #endregion
            //Tesla
            #region Tesla
            if(comboBoxMarcaMasinii.Text == "Tesla")
            {
                if(comboBoxModelulMasinii.Text == "Model 3")
                {
                    textPutere.Text = "484 HP";
                    textCapacitateCubica.Text = " ";
                    radioButonElectric.PerformClick();
                    textClasaEmisii.Text = " L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://www.automobielmanagement.nl/wp-content/uploads/2019/09/Tesla-Model-3.jpg";
                }
                if(comboBoxModelulMasinii.Text == "Model S")
                {
                    textPutere.Text = "306 HP";
                    textCapacitateCubica.Text = " ";
                    radioButonElectric.PerformClick();
                    textClasaEmisii.Text = " L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://i.pinimg.com/originals/c4/1a/7a/c41a7a1da2a7730f707c39aac0af5d89.jpg";
                }
                if(comboBoxModelulMasinii.Text == "Model X")
                {
                    textPutere.Text = "328 HP";
                    textCapacitateCubica.Text = " ";
                    radioButonElectric.PerformClick();
                    textClasaEmisii.Text = " L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://www.leaseaholic.nl/wp-content/uploads/2017/06/Tesla-Model-X-2017-2.jpg";
                }
                if(comboBoxModelulMasinii.Text == "Roadster")
                {
                    textPutere.Text = "292 HP";
                    textCapacitateCubica.Text = " ";
                    radioButonElectric.PerformClick();
                    textClasaEmisii.Text = " L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://image.cnbcfm.com/api/v1/image/104849472-tesla-press-roadster_r.jpg?v=1552570069&w=1400&h=950";
                }
            }
            #endregion
            //Volkswagen
            #region Volkswagen
            if(comboBoxMarcaMasinii.Text == "Volkswagen")
            {
                if(comboBoxModelulMasinii.Text ==  "Arteon")
                {
                    textPutere.Text = "150 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "4.4 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://www.auto-bild.ro/wp-content/uploads/2017/03/2017-volkswagen-arteon-2017-geneva-motor-show-24-1280x720.jpg";
                }
                if(comboBoxModelulMasinii.Text == "Golf 6")
                {
                    textPutere.Text = "160 HP";
                    textCapacitateCubica.Text = "1.4 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "6.3 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://rentacar-cluj-napoca.ro/wp-content/uploads/2019/09/rent-a-car-ieftin-cluj-golf-6-2010-04-600x450.jpg";
                }
                if(comboBoxModelulMasinii.Text == "Jetta")
                {
                    textPutere.Text = "192 HP";
                    textCapacitateCubica.Text = "2.4 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "6.4 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://i0.1616.ro/media/2/2621/33217/17401273/1/vw-jetta.jpg";
                }
                if(comboBoxModelulMasinii.Text == "Passat")
                {
                    textPutere.Text = "160 HP";
                    textCapacitateCubica.Text = "1.8 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "7.3 L/100 km";
                    textCombustibil.Text = "Euro4";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://bordalo.observador.pt/700y,q85/https://s3.observador.pt/wp-content/uploads/2019/04/05221755/2020-volkswagen-passat-grey-sedan-front-3-4.jpg";
                }
                if(comboBoxModelulMasinii.Text == "Touareg")
                {
                    textPutere.Text = "245 HP";
                    textCapacitateCubica.Text = "3 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "9 L/100 km";
                    textCombustibil.Text = "Euro5";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://i.ytimg.com/vi/lI_O0mieivI/maxresdefault.jpg";
                }
            }
            #endregion
            //Volvo
            #region Volvo
            if(comboBoxMarcaMasinii.Text == "Volvo")
            {
                if(comboBoxModelulMasinii.Text == "S90")
                {
                    textPutere.Text = "320 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "7.2 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Manual";
                    pictureBox.ImageLocation = "https://img4.auto.cz/autofun_cz/plakaty/2018-04/bvos9201.jpg";
                }
                if(comboBoxModelulMasinii.Text == "V90")
                {
                    textPutere.Text = "190 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonBenzina.PerformClick();
                    textClasaEmisii.Text = "4.5 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://www.auto-types.com/images/volvo/Volvo_V90_Cross_Country_z9h_4580.jpg";
                }
                if(comboBoxModelulMasinii.Text == "XC90")
                {
                    textPutere.Text = "224 HP";
                    textCapacitateCubica.Text = "2 L";
                    radioButonMotorina.PerformClick();
                    textClasaEmisii.Text = "5.7 L/100 km";
                    textCombustibil.Text = "Euro6";
                    textTransmisie.Text = "Automatic";
                    pictureBox.ImageLocation = "https://www.supersound.si/wp-content/uploads/2018/05/Volvo-XC90.jpg";
                }
            }
            #endregion
        }
        #region Adaug toate modelele
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            if(comboBoxMarcaMasinii.SelectedIndex == 3)
            {
                comboBoxModelulMasinii.Items.Add("Cherokee");
                comboBoxModelulMasinii.Items.Add("Renegade");
                comboBoxModelulMasinii.Items.Add("Wrangler");
            }
            #endregion
            #region Modele Mercedes-Benz
            if(comboBoxMarcaMasinii.SelectedIndex == 4)
            {
                comboBoxModelulMasinii.Items.Add("AMG");
                comboBoxModelulMasinii.Items.Add("C Class");
                comboBoxModelulMasinii.Items.Add("E Class");
                comboBoxModelulMasinii.Items.Add("S Class");
                comboBoxModelulMasinii.Items.Add("Sprinter");
            }
            #endregion
            #region Modele Opel
            if(comboBoxMarcaMasinii.SelectedIndex == 5)
            {
                comboBoxModelulMasinii.Items.Add("Astra");
                comboBoxModelulMasinii.Items.Add("Corsa");
                comboBoxModelulMasinii.Items.Add("Crossland X");
                comboBoxModelulMasinii.Items.Add("Insigna");
                comboBoxModelulMasinii.Items.Add("Tigra");
            }
            #endregion
            #region Modele Peugeot
            if(comboBoxMarcaMasinii.SelectedIndex == 6)
            {
                comboBoxModelulMasinii.Items.Add("208");
                comboBoxModelulMasinii.Items.Add("308");
            }
            #endregion
            #region Modele Renault
            if(comboBoxMarcaMasinii.SelectedIndex == 7)
            {
                comboBoxModelulMasinii.Items.Add("Clio");
                comboBoxModelulMasinii.Items.Add("Laguna");
                comboBoxModelulMasinii.Items.Add("Megane");
            }
            #endregion
            #region Modele Skoda
            if(comboBoxMarcaMasinii.SelectedIndex == 8)
            {
                comboBoxModelulMasinii.Items.Add("Fabia");
                comboBoxModelulMasinii.Items.Add("Octavia");
                comboBoxModelulMasinii.Items.Add("Yeti");
            }
            #endregion
            #region Modele Tesla
            if(comboBoxMarcaMasinii.SelectedIndex == 9)
            {
                comboBoxModelulMasinii.Items.Add("Model 3");
                comboBoxModelulMasinii.Items.Add("Model S");
                comboBoxModelulMasinii.Items.Add("Model X");
                comboBoxModelulMasinii.Items.Add("Roadster");
            }
            #endregion
            #region Modele Volkswagen
            if(comboBoxMarcaMasinii.SelectedIndex == 10)
            {
                comboBoxModelulMasinii.Items.Add("Arteon");
                comboBoxModelulMasinii.Items.Add("Golf 6");
                comboBoxModelulMasinii.Items.Add("Jetta");
                comboBoxModelulMasinii.Items.Add("Passat");
                comboBoxModelulMasinii.Items.Add("Touareg");
            }
            #endregion
            #region Modele Volvo
            if(comboBoxMarcaMasinii.SelectedIndex == 11)
            {
                comboBoxModelulMasinii.Items.Add("S90");
                comboBoxModelulMasinii.Items.Add("V90");
                comboBoxModelulMasinii.Items.Add("XC90");
            }
            #endregion
        }
        #endregion
        #region Adaugare masini
        private void Form1_Load(object sender, EventArgs e)
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


        }
        #endregion
        #region Reset
        private void butonResetare_Click(object sender, EventArgs e)
        {
            textPutere.Text = null;
            textCapacitateCubica.Text = null;
            textCombustibil.Text = null;
            textClasaEmisii.Text = null;
            textTransmisie.Text = null;
            radioButonBenzina.Checked = false;
            pictureBox.Image = null;
        }
        #endregion

        private void butonCumparare_Click(object sender, EventArgs e)
        {
            if (!((string.IsNullOrEmpty(comboBoxMarcaMasinii.Text)
                || comboBoxMarcaMasinii.SelectedIndex == -1)
                || (string.IsNullOrEmpty(comboBoxModelulMasinii.Text)
                || comboBoxModelulMasinii.SelectedIndex == -1)))
            {
                pictureBox.Image = null;
                pictureBox.SendToBack();
            }
            else
            {
                MessageBox.Show("Va rugam selectati marca si modelul masinii.");
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            pictureBox.SendToBack();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButonPlataClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNume.Text) || string.IsNullOrWhiteSpace(textNume.Text))
            {
                MessageBox.Show("Va rugam introduceti numele si prenumele.");
            }
            else if (string.IsNullOrEmpty(textCardNumber.Text)
                     || string.IsNullOrWhiteSpace(textCardNumber.Text)
                     || textCardNumber.TextLength != 12)
            {
                MessageBox.Show("Va rugam introduceti corect numarul cardului. Numarul necesar de cifre este 12.");
            }
            else if (string.IsNullOrEmpty(textCiv.Text)
                     || string.IsNullOrWhiteSpace(textCiv.Text)
                     || textCiv.TextLength != 3)
            {
                MessageBox.Show("Nu ati introdus corect cele 3 cifre de siguranta");
            }
            else
            {
                var text = new StringBuilder();
                text.Append(
                    "Felicitari pentru noua dumneavoastra achizitie! Sa va bucurati de noua dumneavoastra masina, ");
                text.AppendFormat("{0} {1}.", comboBoxMarcaMasinii.Text, comboBoxModelulMasinii.Text);
                MessageBox.Show(text.ToString());
            }
        }

        private void ButonComparareMasiniOnClick(object sender, EventArgs e)
        {
            FormComparare formComparare = new FormComparare();
            formComparare.Show();
        }
    }
}