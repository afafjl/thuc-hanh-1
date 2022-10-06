using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;
using System.Data;//import this namespace


namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();
            render();
        }
        void render()
        {
            for (int i = 0; i < 4; i++)
            {
                aaa.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 4; i++)
            {
                aaa.ColumnDefinitions.Add(new ColumnDefinition());
            }
            string[] listtxtbtn = new string[] {"C","X","%","/","7","8","9","*","4","5","6","-","1","2","3","+","0",".","=",""};
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 4 && j == 3) { break; }
                    if (i != 3 || j != 3)
                    {
                        int a = 4 * i + j;
                        Button n = new Button { Text = listtxtbtn[a], HeightRequest = 100, Margin = 0, BorderWidth = 0.1,  CornerRadius = 0 };
                        aaa.Children.Add(n, j, i);
                        n.Clicked += N_Clicked; ;
                    }
                    else
                    {
                        Button n = new Button { Text = "+", HeightRequest = 100, Margin = 0, BorderWidth = 0.1,  CornerRadius = 0 };
                        aaa.Children.Add(n, j, i);
                        Grid.SetRowSpan(n, 2);
                        n.Clicked += N_Clicked;
                    }
                }


            }
        }

        private void N_Clicked(object sender, EventArgs e)
        {
            if (bbb.Text == "error")
            {
                bbb.Text = "0";
            }
            Button btn = (Button)sender;
            if (btn.Text != "=")
                ccc.Text = "";
            if (btn.Text == "C")
            {
                bbb.Text = "0";

            }
            else if(btn.Text == "X")
            {
                bbb.Text = bbb.Text.Remove(bbb.Text.Length-1);
                if(bbb.Text.Length == 0)
                {
                    bbb.Text = "0";
  
                }

            }
            else if (btn.Text != "=")
            {
                double y = 0;
                double.TryParse(btn.Text, out y);
                if (y != 0)
                {
                    bbb.Text += btn.Text;
                }
                else if (btn.Text == "0")
                {
                    bbb.Text += "0";
                }
                else 
                {
                    bbb.Text += btn.Text;
                    if (bbb.Text[bbb.Text.Length-1]== bbb.Text[bbb.Text.Length - 2])
                    {
                        bbb.Text = bbb.Text.Remove(bbb.Text.Length - 1);
                    }
                    if (btn.Text != "-" && btn.Text != "+")
                        if (bbb.Text[bbb.Text.Length - 2] == '%' || bbb.Text[bbb.Text.Length - 2] =='*' || bbb.Text[bbb.Text.Length - 2] == '/' || bbb.Text[bbb.Text.Length - 2] == '+' || bbb.Text[bbb.Text.Length - 2] == '-')
                        {
                                bbb.Text = bbb.Text.Remove(bbb.Text.Length - 2,1);
                        }
                }
            }
            if (bbb.Text[0]=='0' && bbb.Text.Length > 1 && bbb.Text[1]!='.')
            {
                bbb.Text = bbb.Text.Remove(0, 1);
            }
            if (bbb.Text[0] == '%' || bbb.Text[0] == '*' || bbb.Text[0] == '/' )
            {
                bbb.Text = "0";
            }
            if (btn.Text == "=")
            {
                if (bbb.Text[bbb.Text.Length - 1] == '%' || bbb.Text[bbb.Text.Length - 1] == '*' || bbb.Text[bbb.Text.Length - 1] == '/' || bbb.Text[bbb.Text.Length - 1] == '+' || bbb.Text[bbb.Text.Length - 1] == '-')
                {
                    bbb.Text = bbb.Text.Remove(bbb.Text.Length - 1);
                }
                ccc.Text = bbb.Text + '=';
                string t="error";
                try
                {
                    t = new DataTable().Compute(bbb.Text, null).ToString();
                }
                catch 
                {
                }
                bbb.Text = t;

                
            }

        }
    }
}