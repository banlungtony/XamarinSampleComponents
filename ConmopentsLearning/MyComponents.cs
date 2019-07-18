using System;

using Xamarin.Forms;

namespace ConmopentsLearning
{
    public class MyComponents : ContentPage
    {
        public MyComponents()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

