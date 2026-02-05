using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEgitimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // bu metot form açılırken çalışır
            for (int i = 0; i < 50; i++)
            {
                domainUpDown1.Items.Add(FontFamily.Families[i].Name);
            }
            comboBox1.DataSource = domainUpDown1.Items;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Butona Tıklandı!";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Admin" && txtSifre.Text == "adm123")
            {
                label1.Text = "Hoşgeldin Admin"; // label1 e bunu yazdır.
                groupBox1.Visible = false; // kullanıcı giriş formunu gizle.
            }
            else
            {
                MessageBox.Show("Giriş Başarısız!"); // kısayolu mbox tab tab: ekrana mesaj vermemizi sağlar.
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) // ekrandaki numericUpDown1 isimli nesnenin değeri değiştiğinde çalışacak olan metot.
        {
            label1.Font = new Font(comboBox1.SelectedValue.ToString(), (float)numericUpDown1.Value); // ekrandaki label1 isimli nesnenin font değerini yeni bir fontla değiştir. Yeni fontu yine ekranda içine sistemdeki fontları yüklediğimiz comboBox1 isimli nesnede seçili olan fontu kulan, 2. parametrede ise bu yazı fontunun boyutunu numericUpDown1 nesnesindeki seçili değerden alarak ayarla dedik.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
