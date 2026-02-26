using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAdoNetCRUD
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        CategoryDAL dAL = new CategoryDAL();
        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvKategoriler.DataSource = dAL.GetDataTable("select * from categories");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var kategori = new Category
            {
                CreateDate = DateTime.Now,
                Name = txtKategoriAdi.Text,
                Description = txtAciklama.Text,
                IsActive = cbDurum.Checked,
            };
        }
    }
}
