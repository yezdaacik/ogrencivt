using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hnk_okul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            FormOgrenciEkle formOgrenciEkle = new FormOgrenciEkle();
            formOgrenciEkle.ShowDialog();
        }

        private void btnOgrenciler_Click(object sender, EventArgs e)
        {
            FormOgrenciler formOgrenciler = new FormOgrenciler();
            formOgrenciler.ShowDialog();
        }
    }
}
