using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConmopentsLearning
{
    public partial class MyComponents : StackLayout
    {
        public MyComponents(string id, string name, string address)
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(id))
            {
                myId.IsVisible = false;
            }
            else
            {
                myId.Text = id.ToString();
            }


            if (string.IsNullOrEmpty(name))
            {
                myName.IsVisible = false;
            }
            else
            {
                myName.Text = name.ToString();
            }

            if (string.IsNullOrEmpty(address))
            {
                myAddress.IsVisible = false;
            }
            else
            {
                myAddress.Text = address.ToString();
            }
        }
    }
}
