using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenkronikAsenkronik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            Topla(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        // Task olduğu için await, await olduğu için de tanımda async kullandık.
        private async void btnCarp_Click(object sender, EventArgs e) // async, metodu asenkronik hale getiriyor.
        {
            // await, bu kod bloğu içinde sonrasında gelecek işlemleri durdurup, kendi çalıştıktan sonra başlatıyor.
            await CarpAsync(int.Parse(textBox1.Text), int.Parse(textBox2.Text)); 
        }

        private void Topla(int sayi1, int sayi2)
        {
            MessageBox.Show($"Toplam: {sayi1 + sayi2}");
        }
        private void Carp(int sayi1, int sayi2)
        {
            Thread.Sleep(10000); // Asenkron progrqamlamayı anlamak için işlemlerin farklı sürelerde bitmesi için birini uyuttuk.
            MessageBox.Show($"Çarp: {sayi1 * sayi2}");
        }

        // Tanımında sadece Task varsa void olduğunu gösterir.
        private Task CarpAsync(int sayi1, int sayi2)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(10000);
                MessageBox.Show($"Çarp: {sayi1 * sayi2}");
            });
        }
    }
}
