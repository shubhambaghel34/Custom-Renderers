using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RendersExample
{
   public  class ButtonRenderer:ContentPage
    {
        Label lbl;
        Button btn;
        public ButtonRenderer()
        {
            Padding = 20;
          
            btn = new Button
            {
                Text = "Normal Button",
                BorderWidth = 2,
                BorderColor = Color.Black,
                BackgroundColor = Color.DarkCyan,
                TextColor = Color.Black,

            };
           
            lbl = new Label
            {
                Text = "This is button",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,


            };
            new RoundcornerButton()
            {
                Text = "Rounded corner Button ",
                BorderWidth = 2,
                BorderColor = Color.Black,
                BackgroundColor = Color.Red,
                TextColor = Color.Black,

            };
           
            Content = new StackLayout
            { Padding = 20,
                Children =
                {
                    lbl,
                    btn
                },
            };

        }
       
    
    }
}
