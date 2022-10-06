using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            render();
        }
        void render()
        {
            for (int i = 0; i < 4; i++)
            {
                aaa.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i < 4; i++)
            {
                aaa.RowDefinitions.Add(new RowDefinition());
            }



            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {


                    int a = i + j;
                    if (a % 2 == 0)
                    {
                        BoxView aa = new BoxView();
                        aa.Color = Color.White;
                        aaa.Children.Add(aa, i, j);
                    }
                    else
                    {
                        BoxView aa = new BoxView();
                        aa.Color = Color.Black;
                        aaa.Children.Add(aa, i, j);
                    }
                }

            }
        }
    }
}