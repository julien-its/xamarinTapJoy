using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JitsXamarinTapjoy
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BtnConnect.Clicked += ConnectAdInt;
            BtnOpen.Clicked += OpenAdInt;
        }

        void ConnectAdInt(object sender, EventArgs args)
        {
            DependencyService.Get<Models.Dependency.IInterstitialAd>().connect();
        }

        void OpenAdInt(object sender, EventArgs args)
        {
            DependencyService.Get<Models.Dependency.IInterstitialAd>().open();
        }
    }
}