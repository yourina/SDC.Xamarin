using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSDC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MicroChart1 : ContentPage
    {
        public MicroChart1()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var charts = Data.CreateXamarinSample();
            this.chart1.Chart = charts[0];
        }
    }
}