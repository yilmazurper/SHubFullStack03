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
        }

        private void btnEKle_Click(object sender, EventArgs e)
        {
            var kategori = new Category
            {
                CreateDate = DateTime.Now,
                Name = txtKategoriAdi.Text,
                Description = txtAciklama.Text,
                IsActive = d.Checked,
            };
        }

        private void d_Click(object sender, EventArgs e)
        {

        }
    }
}
