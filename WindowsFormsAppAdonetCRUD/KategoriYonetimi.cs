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
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        CategoryDal dAL = new CategoryDal();
        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvKategoriler.DataSource = dAL.GetDataTable("Select*from categories");
            btnEKle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnEKle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Adi bos Gecilmez");
                return;
            }
            var kategori = new Category
            {
                CreateDate = DateTime.Now,
                Name = txtKategoriAdi.Text,
                Description = txtAciklama.Text,
                IsActive = cbDurum.Checked,
            };
            var sonuc = dAL.Add(kategori);
            if (sonuc>0)
            {
                Yukle();
                MessageBox.Show("Kayit Basarili");
            }
            else
            {
                MessageBox.Show("Kayit Basarisiz");
            }
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriAdi.Text = dgvKategoriler.CurrentRow.Cells[1].Value.ToString();
            txtAciklama.Text = dgvKategoriler.CurrentRow.Cells[2].Value.ToString();
            cbDurum.Checked = (bool)dgvKategoriler.CurrentRow.Cells[3].Value;

            btnEKle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true; 
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Adi bos Gecilmez");
                return;
            }
            var kategori = new Category
            {
                Id= (int)dgvKategoriler.CurrentRow.Cells[0].Value,
                CreateDate = DateTime.Now,
                Name = txtKategoriAdi.Text,
                Description = txtAciklama.Text,
                IsActive = cbDurum.Checked,
            };
            var sonuc = dAL.update(kategori); // kaydi Guncelle
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
           
            var kategori = new Category
            {
                Id = (int)dgvKategoriler.CurrentRow.Cells[0].Value,
                
            };
            var sonuc = dAL.Delete(kategori); // kaydi sil
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
