using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSkullanicigirisi
{
    public partial class frmkullanicigiris : Form
    {
        public frmkullanicigiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnGirisyap_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciadi.Text == "Admin" && TxtSifre.Text == "1234")
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else if (TxtKullaniciadi.Text != "Admin" && TxtSifre.Text == "1234")
            {
                MessageBox.Show("Kullanıcı Adı Hatalı...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtKullaniciadi.Text == "Admin" && TxtSifre.Text!="1234")
            {
                MessageBox.Show("Şifre Hatalı...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Hatalı...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyegirisi frm = new uyegirisi();
            frm.Show();
            this.Hide();
        }
    }
}
