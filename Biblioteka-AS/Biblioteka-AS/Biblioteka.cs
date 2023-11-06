using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_AS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //upis novog korisnika
            Korisnik korisnik = new Korisnik();
            korisnik.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //upis nove knjige
            Knjiga knjiga = new Knjiga();
            knjiga.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //posudi knjigu
            Posudi posudi = new Posudi();
            posudi.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //vrati knjigu
            Vrati vrati = new Vrati();
            vrati.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //info o korisnicima
            Korisnici korisnici = new Korisnici();
            korisnici.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //info o knjigama
            Knjige knjige = new Knjige();
            knjige.ShowDialog();
        }
    }
}
