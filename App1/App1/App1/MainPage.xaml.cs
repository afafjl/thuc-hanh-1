using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void button1_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());

        }
        private void button5_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page5());

        }
        private void button2_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());

        }
        private void button3_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());

        }
        private void button4_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());

        }
    }
}
