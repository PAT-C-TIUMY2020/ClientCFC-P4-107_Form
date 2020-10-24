using ServiceMtk_P1107;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientCFC_P4_107_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

            BasicHttpBinding bind = new BasicHttpBinding();
            ChannelFactory<IMatematika> objChannel = new ChannelFactory<IMatematika>(bind, "http://localhost:8888/Matematika");
            IMatematika obj = objChannel.CreateChannel();
            double hasilTambah = obj.Tambah(1, 2);
            Console.WriteLine("1 + 2 = " + hasilTambah);
            double hasilKurang = obj.Kurang(3, 2);
            Console.WriteLine("3 - 2 = " + hasilKurang);
            double hasilKali = obj.Kali(2, 2);
            Console.WriteLine("2 x 2 = " + hasilKali);
            double hasilBagi = obj.Bagi(2, 2);
            Console.WriteLine("2 / 2 = " + hasilBagi);
            Console.ReadLine();
            Koordinat objk = new Koordinat();

            textBox1.Text = "1 + 2 = " + hasilTambah;
            textBox2.Text = "3 - 2 = " + hasilKurang;
            textBox3.Text = "2 x 2 = " + hasilKali;
            textBox4.Text = "2 / 2 = " + hasilBagi;

        }
    }
}
