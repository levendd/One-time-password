using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        public string sifre;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            int deneme = 3;
            string tekkullanımllık = textBox1.Text.ToString();
            if (tekkullanımllık == sifre)
            {
                MessageBox.Show("işlem başarılı");
                this.Close();
            }
            else 
            { MessageBox.Show("Giriş Başarısız Lütfen Tekrardan Şifre Alınız");
                this.Hide();
                frm.ShowDialog();
            } 
        }
    }
}
