using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RendersExample
{
    public class StartPage: ContentPage
    {
        public StartPage()
        {
            Label lbl = new Label
            {
                Text = "StartPage",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,

            };
            Content = new StackLayout
            {
                Children =
                {lbl

                }
            };
        }
    }
}
