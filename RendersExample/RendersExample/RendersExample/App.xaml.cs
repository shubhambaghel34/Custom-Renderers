using RendersExample.CustomRenderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RendersExample
{
    public partial class App : Application
    {
        public App()
        {
           
           // InitializeComponent();
          
            MainPage = new ContentPage
            {
                Padding = new Thickness(10, 40, 10, 10),
                BackgroundImage = "backg.png",

                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Padding = new Thickness(10, 10, 10, 0),
                   
            Children =
                    {
                      
                        new Label{

                              Text = "Login",
                              TextColor=Color.FromHex("#0034dd"),
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                     Margin = new Thickness(10, 10, 10, 0),
                        },
                         new CustomEntry()
                        {
                            Placeholder="Name",

                            BackgroundColor=Color.FromHex("#0099CC"),
                            VerticalOptions=LayoutOptions.Center,
                            HorizontalOptions=LayoutOptions.FillAndExpand,
                            Margin = new Thickness(10, 10, 10, 0),

        },
                        new CustomEntry2()
                        { Placeholder="Password",
                          IsPassword=true,
                            BackgroundColor=Color.FromHex("#0099CC"),
                            VerticalOptions=LayoutOptions.Center,
                            HorizontalOptions=LayoutOptions.FillAndExpand,
                                Margin = new Thickness(10, 10, 10, 0),
                        },

                        new RoundcornerButton()
                        {
                             Text = "Submit",
                BorderWidth = 2,
                BorderColor = Color.FromHex("#FF4444"),
                BackgroundColor = Color.DarkCyan,
                TextColor = Color.Black,
                HorizontalOptions=LayoutOptions.Center,
                VerticalOptions=LayoutOptions.Center,
                 Margin = new Thickness(10, 10, 10, 0),
                        },
                       
              
                    }

                },

            };
           

        }

      
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        } 
    }
}
