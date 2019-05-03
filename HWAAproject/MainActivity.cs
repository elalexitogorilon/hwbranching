using Android.App;
using Android.Widget;
using Android.OS;
using Xamarin.Android;
using Android.Webkit;

namespace HWAAproject
{
    [Activity(Label = "HWAAproject", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource   
            SetContentView(Resource.Layout.Main);
            WebView webView = FindViewById<WebView>(Resource.Id.LocalWebView);
            webView.SetWebViewClient(new WebViewClient());
            webView.LoadUrl("https://webchat.botframework.com/embed/AALuisBot?s=AodWC_c9L3E.Hsj2kMn-Y_0R1clj3HZKX5voZGESShO7U9cVM5izjpE");
            webView.Settings.JavaScriptEnabled = true;
            webView.Settings.BuiltInZoomControls = true;
            webView.Settings.SetSupportZoom(true);
           // webView.ScrollBarStyle = ScrollbarStyles.OutsideOverlay;
            webView.ScrollbarFadingEnabled = false;
        }
        //protected override void OnCreate(Bundle savedInstanceState)
        //{
        //    base.OnCreate(savedInstanceState);

        //    // Set our view from the "main" layout resource
        //    SetContentView(Resource.Layout.Main);
        //}
    }
}

