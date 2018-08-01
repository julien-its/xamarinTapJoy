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
using Com.Tapjoy;

namespace JitsXamarinTapjoy.Droid.PlatformSpecific
{
    public class TapjoyPlacementListner : Java.Lang.Object, Com.Tapjoy.ITJPlacementListener
    {
        private Com.Tapjoy.TJPlacement placement;

        public void SetPlacement(Com.Tapjoy.TJPlacement placement)
        {
            this.placement = placement;
        }

        public void OnContentDismiss(TJPlacement p0)
        {
            String test = "test";
        }

        public void OnContentReady(TJPlacement p0)
        {
            this.placement.ShowContent();
            String test = "test";
        }

        public void OnContentShow(TJPlacement p0)
        {
            String test = "test";
        }

        public void OnPurchaseRequest(TJPlacement p0, ITJActionRequest p1, string p2)
        {
            String test = "test";
        }

        public void OnRequestFailure(TJPlacement p0, TJError p1)
        {
            String test = "test";
        }

        public void OnRequestSuccess(TJPlacement p0)
        {
            String test = "test";
        }

        public void OnRewardRequest(TJPlacement p0, ITJActionRequest p1, string p2, int p3)
        {
            String test = "test";
        }
    }
}