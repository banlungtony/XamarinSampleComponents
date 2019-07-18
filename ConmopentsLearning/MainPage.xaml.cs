using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConmopentsLearning
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            for (int i = 0; i < 30; i++)
            {
                if (i % 3 == 0)
                {
                    MainStack.Children.Add(new MyComponents(null, "Hello " + i, "Address Naa Jaa " + i));
                }
                else
                {
                    MainStack.Children.Add(new MyComponents(i.ToString(), "Hello " + i, "Address Naa Jaa " + i));
                }
            }
        }
    }
}
