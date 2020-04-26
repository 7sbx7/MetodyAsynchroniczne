using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyAsynchroniczne
{
    public partial class WykonanieWlasnejMeody : Form
    {
        public WykonanieWlasnejMeody()
        {
            InitializeComponent();
        }

        private void Wykonaj_BTN_Click(object sender, EventArgs e)
        {
            Odpal();
        }


        private async Task Task1()
        {
            task1_TB.Clear();
            await Task.Delay(1500);
            string adres = "https://github.com/7sbx7/MetodyAsynchroniczne";
            var client = new HttpClient();
            var result = await client.GetStringAsync(adres);
            task1_TB.Text = result;
        }

        private async Task Task2()
        {
            task2_TB.Clear();
            await Task.Delay(2000);
            string adres = "https://github.com/7sbx7/MetodyAsynchroniczne";
            var client = new HttpClient();
            var result = await client.GetStringAsync(adres);
            task2_TB.Text = result;
        }

        private async Task Task3()
        {
            task3_TB.Clear();
            await Task.Delay(4000);
            string adres = "https://github.com/7sbx7/MetodyAsynchroniczne";
            var client = new HttpClient();
            var result = await client.GetStringAsync(adres);
            task3_TB.Text = result;
        }

        public async Task Odpal()
        {
            Stopwatch stoper = new Stopwatch();
            stoper.Start();
            await Task.WhenAll(Task1() , Task2() , Task3());
            stoper.Stop();
            czasWykonania_TB.Text = stoper.ElapsedMilliseconds.ToString();
        }

        private void wroc_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
