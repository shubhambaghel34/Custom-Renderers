using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using RendersExample.iOS;
using RendersExample;
using Xamarin.Forms;
using CoreGraphics;

[assembly: ExportRenderer(typeof(RoundcornerButton), typeof(RoundcornerbuttonRenderer))]
namespace RendersExample.iOS
{
   public class RoundcornerbuttonRenderer: ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            var mybutton = Control as UIButton;
            mybutton.AllTouchEvents += Mybutton_AllTouchEvents;
            if (Control != null)
            {
                
                Control.BackgroundColor = UIColor.DarkGray;
               // UIImage img = UIImage.FromFile("Androidimage.png");
                Layer.ShadowRadius = 2.0f;
                Layer.ShadowColor = UIColor.Gray.CGColor;
                Layer.ShadowOffset = new CGSize(2, 2);
                Layer.ShadowOpacity = 0.80f;
                Layer.ShadowPath = UIBezierPath.FromRect(Layer.Bounds).CGPath;
                Layer.MasksToBounds = false;
               
            }
           
           
        }

        private void Mybutton_AllTouchEvents(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage = new StartPage();
        }
    }
}