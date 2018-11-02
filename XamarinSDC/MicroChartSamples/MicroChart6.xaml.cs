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
	public partial class MicroChart6 : ContentPage
	{
		public MicroChart6 ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var charts = Data.CreateXamarinSample();
            this.chart6.Chart = charts[5];
        }
    }
}