using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            new List<string> { "Arhitectura si Urbanism", "Automatica si Calculatoare", "Chimie Industriala si Ingineria Mediului", "Constructii", "Electronica, Telecomunicatii si Tehnologii Informationale", "Inginerie Electrica si Energetica", "Inginerie din Hunedoara", "Management in Productie si Transporturi", "Mecanica", "Stinte ale comunicarii" },
            new List<string> { "Facultatea de Arte si Design", "Facultatea de Chimie, Biologie, Geografie", "Facultatea de Drept", "Facultatea de Economie si de Administrare a Afacerilor", "Facultatea de Educație Fizică si Sport", "Facultatea de Fizica", "Facultatea de Litere, Istorie si Teologie", "Facultatea de Matematica si Informatica", "Facultatea de Muzica si Teatru", "Facultatea de Sociologie si Psihologie", "Facultatea de Științe Politice, Filosofie si Stiinte ale Comunicarii" },
            new List<string> { "Facultatea de Medicina", "Facultatea de Medicina Dentara", "Facultatea de farmacie"}
            
        };
        
        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < universitatiList[Form1.optiune].Count(); i++)
                listBox1.Items.Add(universitatiList[Form1.optiune][i]);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
