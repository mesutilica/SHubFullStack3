using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppAdoNetCRUD;

namespace WindowsFormsAppEntityFrameworkCRUD
{
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        DatabaseContext context = new DatabaseContext();
        void Yukle()
        {
            dgvKullanicilar.DataSource = context.Users.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdi.Text))
            {
                MessageBox.Show("Kullanıcı Adı Boş Geçilemez!");
                return;
            }
            var kullanici = new User
            {
                CreateDate = DateTime.Now,
                Name = txtAdi.Text,
                Surname = txtSoyadi.Text,
                IsActive = cbDurum.Checked,
                Email = txtEmail.Text,
                Password = txtSifre.Text
            };
            context.Users.Add(kullanici);
            var sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!");
            }
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdi.Text = dgvKullanicilar.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dgvKullanicilar.CurrentRow.Cells[2].Value.ToString();
            txtSifre.Text = dgvKullanicilar.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvKullanicilar.CurrentRow.Cells[4].Value.ToString();
            cbDurum.Checked = (bool)dgvKullanicilar.CurrentRow.Cells[5].Value;

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdi.Text))
            {
                MessageBox.Show("Kullanıcı Adı Boş Geçilemez!");
                return;
            }
            var id = (int)dgvKullanicilar.CurrentRow.Cells[0].Value;
            var kayit = context.Users.Find(id);

            kayit.Email = txtEmail.Text;
            kayit.Password = txtSifre.Text;
            kayit.Name = txtAdi.Text;
            kayit.Surname = txtSoyadi.Text;
            kayit.IsActive = cbDurum.Checked;

            var sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = (int)dgvKullanicilar.CurrentRow.Cells["Id"].Value; // seçilen kaydın id si
            var kayit = context.Users.Find(id); // db den kaydı bul
            context.Users.Remove(kayit); // kaydı silinecek olarak işaretle
            // değişiklikleri db ye işle
            var sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt Silme Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Silme Başarısız!");
            }
        }
    }
}
