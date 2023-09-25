using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SincronoButton_Click(object sender, EventArgs e)
        {
            HornearPollo();
            MessageBox.Show("Ya esta listo el pollo");
        }

        private void AzincronoButton_Click(object sender, EventArgs e)
        {
            HornearPolloAsync();
            MessageBox.Show("Cocinar Arroz");
        }

        private void HornearPollo()
        {
            Thread.Sleep(8000);
        }

        private Task HornearPolloAsync()
        {
            return Task.Delay(8000);
        }

        private async Task<decimal> SumarAsync(decimal num1, decimal num2)
        {
            decimal suma = await Task.Run(() =>
            {
                return num1 + num2;
            });
            return suma;
        }

        private async void SumarButton_Click(object sender, EventArgs e)
        {
            decimal resultado = await SumarAsync(5, 20);

            MessageBox.Show($"La suma es: {resultado}");
        }
    }
}
