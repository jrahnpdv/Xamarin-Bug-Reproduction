using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace BoxViewClock.WPF
{
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();

            Forms.Init();
            LoadApplication(new BoxViewClock.App());
        }
    }
}