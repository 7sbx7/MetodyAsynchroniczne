using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyAsynchroniczne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void wlasnaMetodaAsynchroniczna()
        {
            string adres = "https://github.com/7sbx7/MetodyAsynchroniczne";
            var client = new HttpClient();
            var result = await client.GetStringAsync(adres);
            wynik_TB.Text = result;
        }


        private void Pobierz_BTN_Click(object sender, EventArgs e)
        {
             wlasnaMetodaAsynchroniczna();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void Pobierz2_BTN_Click(object sender, EventArgs e)
        {
            wynik_TB.Clear();
            var client = new HttpClient();
            var result = await client.GetStringAsync(listBox1.SelectedItem.ToString());
            wynik_TB.Text = result;
            if (listBox1.SelectedIndex == 4)
            {
                listBox1.SelectedIndex = 0;
            }
            else
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
            
        }
    }
}
