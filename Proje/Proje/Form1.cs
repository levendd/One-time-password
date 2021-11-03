using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        string onaykodu;        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        static public string sifre;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox1.Text == "E-posta giriniz" || textBox2.Text == "Kullanıcı Adı Giriniz")
            {
                MessageBox.Show("Kullanıcı adı veya E-posta boş geçilemez");
                return;
            }
            Form2 frm2 = new Form2();
            Form1 frm = new Form1();
            onaykodu =rnd.Next(1000,9999).ToString();
            frm2.sifre = onaykodu;
            SmtpClient smtpClient = new SmtpClient();
            MailMessage sms = new MailMessage();
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("yollayacak eposta", "yollayacak epostanın şifresi");
            sms.From = new MailAddress("yollayacak eposta");
            sms.To.Add(textBox1.Text.ToString());
            sms.Subject = "Tek Kullanımlık Şifre";
            sms.IsBodyHtml = true;
            sms.Body = textBox2.Text.ToString()+" Tek Kullanımlık Şifreniz = "+onaykodu.ToString();
            smtpClient.Send(sms);
            MessageBox.Show("işlem başarılı");
            this.Hide();
            frm2.ShowDialog();
        }
    }
}
