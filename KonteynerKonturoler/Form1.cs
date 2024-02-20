using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonteynerKonturoler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            double tabanFiyat = 500;
            //işlemci hesaplama
            double cpuFiyat = 0;
            if (rbcul7.Checked)
                cpuFiyat = 300.8790;
            else if (rbcul5.Checked)
                cpuFiyat = 200.23445;
            else if (rbcul3.Checked)
                cpuFiyat = 100.3457;
            else if (rbcuR5.Checked)
                cpuFiyat = 250.43254;
            else if (rbcuR3.Checked)
                cpuFiyat = 150.25578;
            tabanFiyat += cpuFiyat;
            //ram belek hesaplama
            double ramFiyat = 0;
            if (rbRam16.Checked)
                ramFiyat = 125.999999;
            else if (rbRam8.Checked)
                ramFiyat = 75.45576;
            else if (rbRam4.Checked)
                ramFiyat = 45.45765;
            tabanFiyat += ramFiyat;
            //depolama hesaplama
            double ssdFiyat = 0;
            if (rbhdd1000.Checked)
                ssdFiyat = 1000.888888;
            else if (rbhdd500.Checked)
                ssdFiyat = 500.777777;
            else if (rbhdd320.Checked)
                ssdFiyat = 320.5675;
            tabanFiyat += ssdFiyat;
            //*******************************************
            double ekdonanim = 0;
            if (cvDvd.Checked)
                ekdonanim = 340.1111111;
             if (cbWebcam.Checked)
                ekdonanim = 600.22344;
             if (cbWirelesskart.Checked)
                ekdonanim = 999.455667;
            tabanFiyat += ekdonanim;
            MessageBox.Show(string.Format("Toplam Fiyat ={0:C10}", tabanFiyat));
        }
    }
 }