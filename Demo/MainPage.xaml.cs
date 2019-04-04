using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.ViewModels;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            FlowDirection = FlowDirection.RightToLeft;
            this.BindingContext = new MainViewModel();
            InitializeComponent();
        }
    }
}
