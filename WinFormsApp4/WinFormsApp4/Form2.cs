using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<List<string>> universitatiList = new List<List<string>>()
        {
            new List<string> { "Arhitectura si Urbanism", "Automatica si Calculatoare", "Chimie Industriala si Ingineria Mediului", "Constructii", "Electronica, Telecomunicatii si Tehnologii Informationale", "Inginerie Electrica si Energetica", "Management in Productie si Transporturi", "Mecanica", "Stinte ale comunicarii" },
            new List<string> { "Facultatea de Arte si Design", "Facultatea de Chimie, Biologie, Geografie", "Facultatea de Drept", "Facultatea de Economie si de Administrare a Afacerilor", "Facultatea de Educație Fizică si Sport", "Facultatea de Fizica", "Facultatea de Litere, Istorie si Teologie", "Facultatea de Matematica si Informatica", "Facultatea de Muzica si Teatru", "Facultatea de Sociologie si Psihologie", "Facultatea de Științe Politice, Filosofie si Stiinte ale Comunicarii" },
            new List<string> { "Facultatea de Medicina", "Facultatea de Medicina Dentara", "Facultatea de farmacie"}
            
        };
        List<List<string>> locatii = new List<List<string>>()
        {
            new List<string> { "Biblioteca", "Cantina", "Profi", "Medlife - 20% discount", "Loolish gaming - 24% discount", "Tucano - 10% discount", "STTP - transport in comun gratuit in oras", "Banca Transilvania", "LikePub", "Iulius mall"},
            new List<string> { "Cantina", "Profi", "STTP", "Banca Transilvania", "LikePub", "Biblioteca", "Iulius mall"},
            new List<string> { "Profi", "STTP", "Banca Transilvania", "LikePub", "Biblioteca", "Iulius mall"}
        };

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Size = this.Size;
            listBox1.Items.Add("Facultati:");
            for (int i = 0; i < universitatiList[Form1.optiune].Count(); i++)
                listBox1.Items.Add("                " + universitatiList[Form1.optiune][i]);
            listBox1.BackColor = Color.FromArgb(216, 114, 114);
            listBox1.Items.Add("");
            listBox1.Items.Add("Locuri utile!");

            for (int i = 0; i < locatii[Form1.optiune].Count(); i++)
                listBox1.Items.Add("                " + locatii[Form1.optiune][i]);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        private void Form2_Resize(object sender, EventArgs e)
        {
            listBox1.Size = this.Size;
            
        }
        public int x = Form1.optiune, y, z;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            z = listBox1.Items.Count;
            y = listBox1.SelectedIndex - 1;
            if (x == 0)
                switch (y)
                {
                    case 0:
                        this.BackgroundImage = Properties.Resources.Arhitectura;
                        break;
                    case 1:
                        this.BackgroundImage = Properties.Resources.Electro;
                        break;
                    case 2:
                        this.BackgroundImage = Properties.Resources.Chimie;
                        break;
                    case 3:
                        this.BackgroundImage = Properties.Resources.constructii;
                        break;
                    case 4:
                        this.BackgroundImage = Properties.Resources.Electro;
                        break;
                    case 5:
                        this.BackgroundImage = Properties.Resources.Electro;
                        break;
                    case 6:
                        this.BackgroundImage = Properties.Resources.management_si_transporturi;
                        break;
                    case 7:
                        this.BackgroundImage = Properties.Resources.mecanica;
                        break;
                    case 8:
                        this.BackgroundImage = Properties.Resources.constructii;
                        break;
                    case 11: 
                        this.BackgroundImage = Properties.Resources.biblioteca;
                        break;
                    case 12:
                        this.BackgroundImage = Properties.Resources.Cantina_upt;
                        break;
                    case 13:
                        this.BackgroundImage = Properties.Resources.profi;
                        break;
                    case 14:
                        this.BackgroundImage = Properties.Resources.Medlife;
                        break;
                    case 15:
                        this.BackgroundImage = Properties.Resources.Loolish;
                        break;
                    case 16:
                        this.BackgroundImage = Properties.Resources.tucano;
                        break;
                    case 17:
                        this.BackgroundImage = Properties.Resources.sttp;
                        break;
                    case 18:
                        this.BackgroundImage = Properties.Resources.Transilvania;
                        break;
                    case 19:
                        this.BackgroundImage = Properties.Resources.like;
                        break;
                    case 20:
                        this.BackgroundImage = Properties.Resources.Iulius;
                        break;
                    default:
                        listBox1.SelectedIndex = -1;
                        return;
                }
            else if (x == 1)
                switch (y)
                {
                    case 0:
                        this.BackgroundImage = Properties.Resources.Arte_si_design;
                        break;
                    case 1:
                        this.BackgroundImage = Properties.Resources.chimie_si_biologie;
                        break;
                    case 2:
                        this.BackgroundImage = Properties.Resources.Drept;
                        break;
                    case 3:
                        this.BackgroundImage = Properties.Resources.Economie;
                        break;
                    case 4:
                        this.BackgroundImage = Properties.Resources.Educatie_fizica;
                        break;
                    case 5:
                        this.BackgroundImage = Properties.Resources.Fizica;
                        break;
                    case 6:
                        this.BackgroundImage = Properties.Resources.Litere;
                        break;
                    case 7:
                        this.BackgroundImage = Properties.Resources.Mate_info;
                        break;
                    case 8:
                        this.BackgroundImage = Properties.Resources.muzica_;
                        break;
                    case 9:
                        this.BackgroundImage = Properties.Resources.Psihologie;
                        break;
                    case 10:
                        this.BackgroundImage = Properties.Resources.Stinte_politice;
                        break;
                    case 13:
                        this.BackgroundImage = Properties.Resources.cantina_uvt;
                        break;
                    case 14:
                        this.BackgroundImage = Properties.Resources.profi;
                        break;
                    case 15:
                        this.BackgroundImage = Properties.Resources.sttp;
                        break;
                    case 16:
                        this.BackgroundImage = Properties.Resources.Transilvania;
                        break;
                    case 17:
                        this.BackgroundImage = Properties.Resources.like;
                        break;
                    case 18:
                        this.BackgroundImage = Properties.Resources.Biblioteca_Eugen;
                        break;
                    case 19:
                        this.BackgroundImage = Properties.Resources.Iulius;
                        break;
                    default:
                        listBox1.SelectedIndex = -1;
                        return;
                }
            else if(x == 2) 
                switch (y)
                {
                    case 0:
                        this.BackgroundImage = Properties.Resources.Medicina_farmacie;
                        break;
                    case 1:
                        this.BackgroundImage = Properties.Resources.medicina_dentara;
                        break;
                    case 2:
                        this.BackgroundImage = Properties.Resources.Veterinara;
                        break;
                    case 5:
                        this.BackgroundImage = Properties.Resources.profi;
                        break;
                    case 6:
                        this.BackgroundImage = Properties.Resources.sttp;
                        break;
                    case 7:
                        this.BackgroundImage = Properties.Resources.Transilvania;
                        break;
                    case 8:
                        this.BackgroundImage = Properties.Resources.like;
                        break;
                    case 9:
                        this.BackgroundImage = Properties.Resources.Biblioteca_UMFT;
                        break;
                    case 10:
                        this.BackgroundImage = Properties.Resources.Iulius;
                        break;
                    default:
                        listBox1.SelectedIndex = -1;
                        return;
                }

            
            this.BackgroundImageLayout = ImageLayout.Stretch;
            listBox1.Visible = false;
            button1.Visible = true;
            linkLabel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            linkLabel1.Visible = false;
            listBox1.Visible = true;
            listBox1.ClearSelected();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (x == 0)
                switch (y)
                {
                    case 0:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Architecture+and+Urbanism/@45.7454988,21.2276566,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d84b844a325:0x85f1384960286f32!8m2!3d45.7454951!4d21.2298453?hl=en-GB",
                            UseShellExecute = true
                        });
                        break;
                    case 1:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Automation+%26+Computer+Science/@45.7474803,21.2240394,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d831ccc8ff7:0x255d397f5edeea71!8m2!3d45.7474766!4d21.2262281?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 2:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Chemical+and+Environmental+Engineering/@45.7477136,21.2309286,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d844b44f39b:0xbfb71472fc5025a2!8m2!3d45.7477099!4d21.2331173?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 3:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Facultatea+de+Construc%C8%9Bii+Timisoara/@45.7455557,21.2277203,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d84b9a63fa9:0xb9b907df02d88fa6!8m2!3d45.745552!4d21.229909?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 4:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Electronics,+Telecommunications+and+Information+Technology/@45.7472894,21.2241115,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d8303f55439:0xbe8d0248f81cb2a9!8m2!3d45.7472857!4d21.2263002?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 5:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Electronics,+Telecommunications+and+Information+Technology/@45.7472894,21.2241115,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d8303f55439:0xbe8d0248f81cb2a9!8m2!3d45.7472857!4d21.2263002?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 6:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Facultatea+de+Management+%C3%AEn+Produc%C5%A3ie+%C5%9Fi+Transporturi/@45.7457212,21.2205534,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d9d37e29121:0x696b5fa224fb69b4!8m2!3d45.7457175!4d21.2227421?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 7:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Mechanics+-+Polytechnic+University+of+Timi%C8%99oara/@45.7459986,21.2234985,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d834c666b07:0xef164d85ca894b8f!8m2!3d45.7459949!4d21.2256872?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 8:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Communication+Sciences/@45.7455739,21.2276895,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d84b850fb9d:0x8bc606f7255883f3!8m2!3d45.7455702!4d21.2298782?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 11:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/Central+Library+of+the+University+Politehnica+Timisoara/@45.7472551,21.2269008,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d8379426181:0x19ac8b7ef5fffe7c!8m2!3d45.747264!4d21.2290863",
                            UseShellExecute = true
                        }); break;
                    case 12:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/Restaurant+Universitar+Politehnica/@45.7483514,21.2374185,17.33z/data=!4m5!3m4!1s0x47455d88c86bf153:0xf59dd6cf2bf96624!8m2!3d45.7483727!4d21.239718",
                            UseShellExecute = true
                        }); break;
                    case 13:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/Profi/@45.748881,21.2361217,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d88bcc5bb05:0x1deb4b6fa72ed4f7!8m2!3d45.748881!4d21.239458",
                            UseShellExecute = true
                        }); break;
                    case 14:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/Hyperclinica+MedLife+Timisoara+-+Dragalina/@45.7473308,21.2131282,15.18z/data=!4m5!3m4!1s0x47455d65435372b7:0x8018f8ca9fafaf!8m2!3d45.7488466!4d21.2083658",
                            UseShellExecute = true
                        }); break;
                    case 15:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/Loolish+Gaming/@45.7477514,21.2401963,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d893697a3c5:0xe4a715f567f73f86!8m2!3d45.7477514!4d21.242385",
                            UseShellExecute = true
                        }); break;
                    case 16:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/Tucano+Coffee+Thailand/@45.7488801,21.2347181,17z/data=!3m1!4b1!4m5!3m4!1s0x47455da84a50cda7:0x4e17c038fc7af980!8m2!3d45.7488802!4d21.2392028",
                            UseShellExecute = true
                        }); break;
                    case 17:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/R.A.T.T/@45.756559,21.2224434,16.6z/data=!4m5!3m4!1s0x4745678090838b6f:0x2d812c62821c0331!8m2!3d45.7563082!4d21.2243644",
                            UseShellExecute = true
                        }); break;
                    case 18:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/Banca+Transilvania/@45.7499631,21.2339891,17z/data=!3m2!4b1!5s0x47455d8628d5c7c9:0xb5d1372f9345c14a!4m5!3m4!1s0x47455d890e486b95:0x65e9d3dca78349!8m2!3d45.7499632!4d21.2384738",
                            UseShellExecute = true
                        }); break;
                    case 19:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/Like+Pub+Timisoara/@45.7502235,21.2413178,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d89b1c61c9d:0x4199ab4b3a2a0780!8m2!3d45.7502198!4d21.2435065",
                            UseShellExecute = true
                        }); break;
                    case 20:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Iulius+Town/@45.7669375,21.2237868,17z/data=!3m1!4b1!4m5!3m4!1s0x474567c28251367f:0xdad4d0d2dc253876!8m2!3d45.7669338!4d21.2282715?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                }
            
            else if (x == 1)
                switch (y)
                {
                    case 0:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/University+of+Arts+and+Design/@45.7596204,21.227095,17z/data=!3m1!4b1!4m5!3m4!1s0x474567818a2360a1:0x2ed22b1ecd88de54!8m2!3d45.7595213!4d21.2294318?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 1:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Chemistry,+Biology,+Geography/@45.7541612,21.2426459,17z/data=!3m1!4b1!4m5!3m4!1s0x47456762e2e5ff6f:0x130d3bddaab6d590!8m2!3d45.7541575!4d21.2448346?hl=en-GB\r\nFacult",
                            UseShellExecute = true
                        }); break;
                    case 2:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Law+of+the+West+University+of+Timi%C5%9Foara/@45.7468851,21.2365062,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d8f3e582d17:0x108e33d663c76337!8m2!3d45.7468814!4d21.2386949?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 3:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Economics+and+Business+Administration/@45.753799,21.2427188,17z/data=!3m1!4b1!4m5!3m4!1s0x47456762fb115661:0xa51facf2687c5911!8m2!3d45.7537953!4d21.2449075?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 4:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Physical+Education+and+Sport/@45.7466458,21.2276083,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d849acf3259:0xffaca9cf9f697a49!8m2!3d45.7466421!4d21.229797?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 5:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Physics/@45.747092,21.2278275,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d84870ca98b:0x396a011cd5833c7!8m2!3d45.7470883!4d21.2300162?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 6:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Letters,+History+and+Theology/@45.7473316,21.2294122,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d847c90969b:0x5067a87570ba4aac!8m2!3d45.7473279!4d21.2316009?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 7:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/West+University+of+Timi%C8%99oara/@45.7471232,21.2294265,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d84610655bf:0xfd169ff24d29f192!8m2!3d45.7471195!4d21.2316152?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 8:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Music+and+Theater/@45.756056,21.2250207,17z/data=!3m1!4b1!4m5!3m4!1s0x474567800c43ace9:0x3a4093d14859d3df!8m2!3d45.7560523!4d21.2272094?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 9:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Sociology+and+Psychology/@45.7471287,21.2288717,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d84641471d9:0x9e052fe4a932747f!8m2!3d45.747125!4d21.2310604?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 10:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Facultatea+de+%C8%98tiin%C8%9Be+Politice,+Filosofie+%C8%99i+%C8%98tiin%C8%9Be+ale+Comunic%C4%83rii/@45.7475244,21.2293049,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d847c90969b:0xda8eb9d3a5730b77!8m2!3d45.7475207!4d21.2314936?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 13:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/Bulevardul+Vasile+P%C3%A2rvan+4,+Timi%C8%99oara+300222/@45.7473307,21.2291348,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d54949311ab:0x3a74d0271efa99ad!8m2!3d45.7473307!4d21.2313235",
                            UseShellExecute = true
                        }); break;
                    case 14:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/Profi/@45.748881,21.2361217,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d88bcc5bb05:0x1deb4b6fa72ed4f7!8m2!3d45.748881!4d21.239458",
                            UseShellExecute = true
                        }); break;
                    case 15:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/R.A.T.T/@45.756559,21.2224434,16.6z/data=!4m5!3m4!1s0x4745678090838b6f:0x2d812c62821c0331!8m2!3d45.7563082!4d21.2243644",
                            UseShellExecute = true
                        }); break;
                    case 16:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/Banca+Transilvania/@45.7499631,21.2339891,17z/data=!3m2!4b1!5s0x47455d8628d5c7c9:0xb5d1372f9345c14a!4m5!3m4!1s0x47455d890e486b95:0x65e9d3dca78349!8m2!3d45.7499632!4d21.2384738",
                            UseShellExecute = true
                        }); break;
                    case 17:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/Like+Pub+Timisoara/@45.7502235,21.2413178,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d89b1c61c9d:0x4199ab4b3a2a0780!8m2!3d45.7502198!4d21.2435065",
                            UseShellExecute = true
                        }); break;
                    case 18:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Central+University+Library+Eugen+Todoran/@45.7474146,21.2305882,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d844fd33e6b:0xe91b57ba5c4a1c03!8m2!3d45.7474109!4d21.2327769?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 19:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Iulius+Town/@45.7669375,21.2237868,17z/data=!3m1!4b1!4m5!3m4!1s0x474567c28251367f:0xdad4d0d2dc253876!8m2!3d45.7669338!4d21.2282715?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                }
            else if(x == 2)
                switch (y)
                {
                    case 0:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Victor+Babe%C5%9F+University+of+Medicine+and+Pharmacy/@45.756694,21.2345217,17z/data=!3m1!4b1!4m5!3m4!1s0x4745677c271fabc9:0x1d1eac603ba771ca!8m2!3d45.7566903!4d21.2367104?hl=en-GB",
                            UseShellExecute = true
                        }); break; 
                    case 1:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Dentistry+UMFT/@45.7558092,21.2321018,17z/data=!3m1!4b1!4m5!3m4!1s0x4745677e5c438d51:0x274fa0c73ea4a7c0!8m2!3d45.7558055!4d21.2342905?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 2:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Faculty+of+Veterinary+Medicine/@45.7836958,21.2142487,17z/data=!3m1!4b1!4m5!3m4!1s0x474567c6e59aa7b7:0x8aa6ff5fe1fd389a!8m2!3d45.7836921!4d21.2164374?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 5:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/Profi/@45.748881,21.2361217,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d88bcc5bb05:0x1deb4b6fa72ed4f7!8m2!3d45.748881!4d21.239458",
                            UseShellExecute = true
                        }); break;
                    case 6:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/R.A.T.T/@45.756559,21.2224434,16.6z/data=!4m5!3m4!1s0x4745678090838b6f:0x2d812c62821c0331!8m2!3d45.7563082!4d21.2243644",
                            UseShellExecute = true
                        }); break;
                    case 7:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/Banca+Transilvania/@45.7499631,21.2339891,17z/data=!3m2!4b1!5s0x47455d8628d5c7c9:0xb5d1372f9345c14a!4m5!3m4!1s0x47455d890e486b95:0x65e9d3dca78349!8m2!3d45.7499632!4d21.2384738",
                            UseShellExecute = true
                        }); break;  
                    case 8:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.com/maps/place/Like+Pub+Timisoara/@45.7502235,21.2413178,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d89b1c61c9d:0x4199ab4b3a2a0780!8m2!3d45.7502198!4d21.2435065",
                            UseShellExecute = true
                        }); break; 
                    case 9:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Splaiul+Tudor+Vladimirescu+2,+Timi%C8%99oara+300193/@45.7478057,21.222173,17z/data=!3m1!4b1!4m5!3m4!1s0x47455d828d246ee3:0x78ba6c7dd9b7de1a!8m2!3d45.747802!4d21.2243617?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                    case 10:
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.google.ro/maps/place/Iulius+Town/@45.7669375,21.2237868,17z/data=!3m1!4b1!4m5!3m4!1s0x474567c28251367f:0xdad4d0d2dc253876!8m2!3d45.7669338!4d21.2282715?hl=en-GB",
                            UseShellExecute = true
                        }); break;
                }

        }
    }
}
