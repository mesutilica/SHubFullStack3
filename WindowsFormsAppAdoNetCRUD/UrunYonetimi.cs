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
    public partial class UrunYonetimi : Form
    {
        public UrunYonetimi()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        UrunDAL dAL = new UrunDAL();
        void Yukle()
        {
            dgvUrunler.DataSource = dAL.GetDataTable("select * from products");
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

    }
}
