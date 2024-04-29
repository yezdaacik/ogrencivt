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
    public partial class FormOgrenciler : Form
    {
        string baglanti = "Server=localhost;Database=hnk_okul;Uid=root;Pwd='';";
        public FormOgrenciler()
        {
            InitializeComponent();
        }

        private void FormOgrenciler_Load(object sender, EventArgs e)
        {
            DgwDoldur();
            CmbDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgwOgrenciler.SelectedRows[0];

            int satirId = Convert.ToInt32(dr.Cells[0].Value);

            DialogResult cevap = MessageBox.Show("Öğrenciyi silmek istediğinizden emin misiniz?",
                                                 "Öğrenciyi sil", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Error);

            if (cevap == DialogResult.Yes)
            {

                using (MySqlConnection baglan = new MySqlConnection(baglanti))
                {
                    int okul_no = Convert.ToInt32(dgwOgrenciler.SelectedRows[0].Cells["okul_no"].Value);
                    baglan.Open();
                    string sorgu = "DELETE FROM ogrenci WHERE okul_no=@okul_no;";
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                    cmd.Parameters.AddWithValue("@okul_no", okul_no);
                    cmd.ExecuteNonQuery();

                    DgwDoldur();
                }
            }
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "UPDATE ogrenci SET ad=@ad, soyad = @ad, dtarih = @dtarih, cinsiyet=@cinsiyet, mezun_durum= @mezun WHERE okul_no =@okulno;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@dtarih", dtTarih.Value);
                cmd.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.SelectedValue);
                cmd.Parameters.AddWithValue("@mezun", cbMezun.Checked);

                int okulNo = Convert.ToInt32(dgwOgrenciler.SelectedRows[0].Cells["okul_no"].Value);
                cmd.Parameters.AddWithValue("@okulno", okulNo);

                cmd.ExecuteNonQuery();

                DgwDoldur();

            }
        }

        void DgwDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT * FROM ogrenci;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgwOgrenciler.DataSource = dt;

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

        private void dgwOgrenciler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwOgrenciler.SelectedRows.Count > 0)
            {
                txtNo.Text = dgwOgrenciler.SelectedRows[0].Cells["okul_no"].Value.ToString();
                txtAd.Text = dgwOgrenciler.SelectedRows[0].Cells["ad"].Value.ToString();
                txtSoyad.Text = dgwOgrenciler.SelectedRows[0].Cells["soyad"].Value.ToString();
                dtTarih.Text = dgwOgrenciler.SelectedRows[0].Cells["dtarih"].Value.ToString();             
                cbMezun.Checked = Convert.ToBoolean(dgwOgrenciler.SelectedRows[0].Cells["mezun_durum"].Value);
                cmbCinsiyet.SelectedValue = dgwOgrenciler.SelectedRows[0].Cells["cinsiyet"].Value.ToString();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sorgu = " SELECT * FROM ogrenci WHERE ad LIKE @aranan;";

           
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@aranan", "%" + txtArama.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgwOgrenciler.DataSource = dt;
            }
        }
    }
}
