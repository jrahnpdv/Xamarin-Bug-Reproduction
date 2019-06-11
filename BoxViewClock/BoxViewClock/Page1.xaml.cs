using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BoxViewClock
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{

        private Dictionary<object, bool> Counter = new Dictionary<object, bool>();

		public Page1 ()
		{
			InitializeComponent ();
		}

        private void OnClicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var isBlack = Counter.ContainsKey(sender) ? Counter[sender] : true;
            Counter[sender] = !isBlack;
            btn.BackgroundColor = isBlack ? Color.Black : Color.White;
            btn.ImageSource = isBlack ? ImageSource.FromFile("check_white.png") : ImageSource.FromFile("check.png");
        }
    }
}