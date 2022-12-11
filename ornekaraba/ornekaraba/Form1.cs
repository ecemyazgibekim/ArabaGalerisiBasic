using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornekaraba
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public Galeri galeri = new Galeri(); 

        private void button1_Click(object sender, EventArgs e)
        {
            Araba araba = new Araba();
            araba.Marka = txtbxMarka.Text;
            araba.Model = Convert.ToInt16(txtbxModel.Text);
            araba.Renk = txtbxRenk.Text;

            
            galeri.ArabaEkle(araba);
            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
           
            txtListele.Text = galeri.ArabalariListele();
            dgwListe.DataSource = galeri.ArabaListesiniVer();

        }

        private void dgwListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
