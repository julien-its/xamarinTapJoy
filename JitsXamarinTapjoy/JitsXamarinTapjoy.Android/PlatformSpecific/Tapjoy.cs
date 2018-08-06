using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using JitsXamarinTapjoy.Models.Dependency;
using JitsXamarinTapjoy.Droid.PlatformSpecific;

[assembly: Xamarin.Forms.Dependency(typeof(Tapjoy))]
namespace JitsXamarinTapjoy.Droid.PlatformSpecific
{
    public class Tapjoy : IInterstitialAd
    {
        public void connect()
        {
            var context = Application.Context;

            Java.Util.Hashtable connectFlags = new Java.Util.Hashtable();
            connectFlags.Put(Com.Tapjoy.TapjoyConnectFlag.EnableLogging, "true");

            var connecttlistener = new TapjoyConnectListner();

            Com.Tapjoy.Tapjoy.Connect(context, "Dv0iKe0ETDCkSQWTM639hAEC2oTgord0QvVlnQRmnwp4Cb6bTD_C2Rc6lkbJ", connectFlags, connecttlistener);
        }

        public void open()
        {
            var placementListener = new TapjoyPlacementListner();

            var context = Application.Context;
            Com.Tapjoy.TJPlacement p = new Com.Tapjoy.TJPlacement(context, "videocado-tapjoy", placementListener);

            placementListener.SetPlacement(p);


            p.RequestContent();
           
        }
    }
}