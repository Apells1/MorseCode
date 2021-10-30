using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Morse1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string Message = "";
        string DotsAndDashs = "";

        protected void onDot(object sender, EventArgs e)
        {
            DotsAndDashs += ".";
            DotsAndDashes.Text = DotsAndDashs;
        }
        protected void onDash(object sender, EventArgs e)
        {
            DotsAndDashs += "-";
            DotsAndDashes.Text = DotsAndDashs;
        }
        protected void onSpace(object sender, EventArgs e)
        {
            Message += Morse.MorseCoder(DotsAndDashs);
            message.Text = Message;
            DotsAndDashs += "";
            DotsAndDashes.Text = DotsAndDashs;
        }
    }
}
