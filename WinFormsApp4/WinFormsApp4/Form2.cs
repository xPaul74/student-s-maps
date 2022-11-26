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
        //string[,] universitati = new string[,] { { } };
        List<List<string>> universitatiList = new List<List<string>>()
        {
            new List<string> { "Arhitectura si Urbanism", "Automatica si Calculatoare", "Chimie Industriala si Ingineria Mediului", "Constructii", "Electronica, Telecomunicatii si Tehnologii Informationale", "Inginerie Electrica si Energetica", "Management in Productie si Transporturi", "Mecanica", "Stinte ale comunicarii" },
            new List<string> { "Facultatea de Arte si Design", "Facultatea de Chimie, Biologie, Geografie", "Facultatea de Drept", "Facultatea de Economie si de Administrare a Afacerilor", "Facultatea de Educație Fizică si Sport", "Facultatea de Fizica", "Facultatea de Litere, Istorie si Teologie", "Facultatea de Matematica si Informatica", "Facultatea de Muzica si Teatru", "Facultatea de Sociologie si Psihologie", "Facultatea de Științe Politice, Filosofie si Stiinte ale Comunicarii" },
            new List<string> { "Facultatea de Medicina", "Facultatea de Medicina Dentara", "Facultatea de farmacie"}
            
        };
        
        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Size = this.Size;
            for (int i = 0; i < universitatiList[Form1.optiune].Count(); i++)
                listBox1.Items.Add(universitatiList[Form1.optiune][i]);
            listBox1.BackColor = Color.FromArgb(216, 114, 114);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        private void Form2_Resize(object sender, EventArgs e)
        {
            listBox1.Size = this.Size;
        }
        public int x = Form1.optiune, y;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            y = listBox1.SelectedIndex;
            if (x == 0)
            {
                
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

                }
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
            {
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

                }
            }
                
        }
    }
}
