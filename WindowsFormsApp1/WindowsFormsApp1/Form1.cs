using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client bilgiGetir = new ServiceReference1.Service1Client();
            int sonuc = bilgiGetir.personelEkle("Ayse", "Yilmaz", 2);
            if (sonuc == 0)
            {
                MessageBox.Show("Personel Eklendi.");
            } 
            else
            {
                MessageBox.Show("Ekleme islemi gerceklestirilemedi.");
            }
        }
    }
}
