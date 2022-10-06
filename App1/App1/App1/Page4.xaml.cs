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
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }

 
        string Age1 = "0";
        private void Button_Clicked(object sender, EventArgs e)
        {

            bool gt = Gender.IsToggled;
            string date = Birthday.Date.ToLongDateString();
            string gioitinh = "Nữ";
            if (gt)
            {
                gioitinh = "Nam";
            }
            if (String.IsNullOrEmpty(Name.Text) && String.IsNullOrEmpty(Email.Text))
            {

                DisplayAlert("Cảnh Báo !", "Hãy nhập đầy đủ thông tin!!!", "Đóng");

            }
            else
            {
                string Name1 = Name.Text.ToString();
                string Email1 = Email.Text.ToString();
                DisplayAlert("Thành Công", $"Bạn đã submit thành công!!!\nName:{Name1},\nEmail:{Email1},\nBirthday:{date},\nGender:{gioitinh},\n Age:{Age1}", "Đóng");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Cảnh Báo!", "Bạn có muốn hủy? Những gì bạn nhập sẽ biến mất.", "Có", "Không");
            if (answer)
            {
                Name.Text = "";
                Email.Text = "";
                Gender.IsToggled = false;
                Age.Value = 0;
                AgeValue.Text = "Age:";
            }
        }

        private void Age_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Age1 = ((int)Age.Value).ToString();
            AgeValue.Text = "Age:" + Age1;
        }
    }

}