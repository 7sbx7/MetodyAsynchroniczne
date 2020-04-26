using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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

        public static async Task<string> MetodaAsync(string adres)
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync(adres);
                return result;
            }
        }
        private async void Pobierz_BTN_Click(object sender, EventArgs e)
        {
            wynik_TB.Clear();
            string result = await MetodaAsync(link1_TB.Text);
            wynik_TB.Text = result;
        }
        public static async Task<string> stoZnakow(string adres)
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync(adres);
                return "\" " + result.Remove(100) + " \"";
            }
        }
        private async void zad4_BTN_Click(object sender, EventArgs e)
        {
            wynik_TB.Clear();
            string downloaded_result = await stoZnakow(listBox1.SelectedItem.ToString());
            wynik_TB.Text = downloaded_result;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void wlasna_BTN_Click(object sender, EventArgs e)
        {
            WykonanieWlasnejMeody karta = new WykonanieWlasnejMeody();
            karta.Show();
        }

        /* private static async Task DoAsync()
         {
             await AnotherMethodAsync().ConfigureAwait(false);
             // any logic
         }

         private static void AnotherMethod()
         {
             Thread.Sleep(1000);
             // any logic
         }
         private static Task AnotherMethodAsync()
         {
             Task task = Task.Factory.StartNew(AnotherMethod);
             return task;
         }
 */

        



    }
}
