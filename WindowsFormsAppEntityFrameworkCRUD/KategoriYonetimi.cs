using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppAdonetCRUD;

namespace WindowsFormsAppEntityFrameworkCRUD
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        DatabaseContext context =new DatabaseContext();
        void Yukle()
        {
            dgvKategoriler.DataSource = context.Categories.ToList();
            //butonlari sifirla
            btnEKle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            //input alanlarii sifirla
            txtAciklama.Text = string.Empty;
            txtKategoriAdi.Text = string.Empty;
            cbDurum.Checked = false;
        }
        private void KategoriYonetimi_Load(object sender, EventArgs e)

        {
            Yukle();
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
            context.Categories.Add(kategori); //ef de kategoriadd metodu ile ekleme yapiyoruz
            var sonuc = context.SaveChanges(); // ef de savecahnges metodu vardir ve bu meot context uzerinde yapilan ekleme guncelleme silme vb islmerli veritabnina isler ve db'den etkilen kayit sayisini getirir
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
            var Id= (int)dgvKategoriler.CurrentRow.Cells[0].Value;//secilen id degerini al
            var kayit = context.Categories.Find(Id); //db'den bu id li kaydi buluan ef metodu find 
            //db'den bulunan kaydin bilgileirni degistir
            kayit.Name = txtKategoriAdi.Text;
            kayit.Description = txtAciklama.Text;
            kayit.IsActive = cbDurum.Checked;
            //degisikleri db ye isle
            var sonuc = context.SaveChanges();
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
            var Id = (int)dgvKategoriler.CurrentRow.Cells["Id"].Value;//secilen kydin id'si
            var kayit = context.Categories.Find(Id); //db'den kaydi bul
            context.Categories.Remove(kayit); //kaydi silincek olarak isaretle
            //degisikleri db'ye isle
            var sonuc = context.SaveChanges();  
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
