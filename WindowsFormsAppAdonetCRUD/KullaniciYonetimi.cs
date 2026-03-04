using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAdonetCRUD
{
    public partial class KullaniciYonetimi : Form
    {

        public KullaniciYonetimi()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        KullanciDal dAL = new KullanciDal();

        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvKullanicilar.DataSource = dAL.GetDataTable("Select*from users");
            btnEKle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        private void btnEKle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdi.Text))
            {
                MessageBox.Show("Kullanici Adi bos Gecilmez");
                return;
            }
            var kullanici = new User
            {
                CreateDate = DateTime.Now,
                Name = txtAdi.Text,
                Surname= txtSoyadi.Text,
                IsActive = cbDurum.Checked,
                Email=txtEmail.Text,
                Password=txtSifre.Text,

            };
            var sonuc = dAL.Add(kullanici);
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayit Basarili");
            }
            else
            {
                MessageBox.Show("Kayit Basarisiz");
            }
        }
       private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdi.Text = dgvKullanicilar.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dgvKullanicilar.CurrentRow.Cells[2].Value.ToString();
            txtSifre.Text = dgvKullanicilar.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvKullanicilar.CurrentRow.Cells[4].Value.ToString();
            cbDurum.Checked = (bool)dgvKullanicilar.CurrentRow.Cells[5].Value;

            btnEKle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdi.Text))
            {
                MessageBox.Show("Kullanici Adi bos Gecilmez");
                return;
            }
            var kullanici = new User
            {
                Id = (int)dgvKullanicilar.CurrentRow.Cells[0].Value,
                CreateDate = DateTime.Now,
                Name = txtAdi.Text,
                Surname= txtSoyadi.Text,
                IsActive= cbDurum.Checked,
                Email= txtEmail.Text,
                Password = txtSifre.Text

            };
            var sonuc = dAL.Update(kullanici); // kaydi Guncelle
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayit Basarili");
            }
            else
            {
                MessageBox.Show("Kayit Basarisiz");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var kayit = new User
            {
                Id = (int)dgvKullanicilar.CurrentRow.Cells[0].Value,

            };
            var sonuc = dAL.Delete(kayit); // kaydi sil
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayit silme Basarili");
            }
            else
            {
                MessageBox.Show("Kayit silme Basarisiz");
            }
        }
    }
}
