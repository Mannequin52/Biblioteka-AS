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
    public partial class Knjiga : Form
    {

        List<Knjiga> knjigaList = new List<Knjiga>();

        public class Book
        {
            string autorIme, autorPrezime, naziv, isbn, izdavac;
            int godinaIzd;

            public string Izdavac { get => izdavac; set => izdavac = value; }
            public string AutorIme { get => autorIme; set => autorIme = value; }
            public string AutorPrezime { get => autorPrezime; set => autorPrezime = value; }
            public string Naziv { get => naziv; set => naziv = value; }
            public string Isbn { get => isbn; set => isbn = value; }
            public int GodinaIzd { get => godinaIzd; set => godinaIzd = value; }

            public Book(string autorIme, string autorPrezime, string naziv, string isbn, string izdavac, int godinaIzd)
            {
                AutorIme = autorIme;
                AutorPrezime = autorPrezime;
                Naziv = naziv;
                Isbn = isbn;
                Izdavac = izdavac;
                GodinaIzd = godinaIzd;
            }
        }
        public Knjiga()
        {
            InitializeComponent();
        }

        private void Knjiga_Load(object sender, EventArgs e)
        {

        }
    }
}
