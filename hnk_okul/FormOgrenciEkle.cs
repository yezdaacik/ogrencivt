using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hnk_okul
{
    public partial class FormOgrenciEkle : Form
    {
        string baglanti = "Server=localhost;Database=hnk_okul;Uid=root;Pwd='';";
        public FormOgrenciEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "INSERT INTO ogrenci VALUES(NULL,@ad,@soyad,@dtarih,@cinsiyet,@mezun_durum)";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@dtarih", dtTarih.Value);
                cmd.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.SelectedValue);
                cmd.Parameters.AddWithValue("@mezun_durum", cbMezun.Checked);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Kayıt Eklendi");
                }

            }
        }

        void CmbDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT DISTINCT cinsiyet FROM ogrenci;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                cmbCinsiyet.DataSource = dt;

                cmbCinsiyet.DisplayMember = "cinsiyet";
                cmbCinsiyet.ValueMember = "cinsiyet";

            }
        }

        private void FormOgrenciEkle_Load(object sender, EventArgs e)
        {
            CmbDoldur();
        }
    }

       
}

