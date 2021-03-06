using ProMama.Components;
using ProMama.Droid.Components;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using WebView = Android.Webkit.WebView;

[assembly: ExportRenderer(typeof(ExtendedWebView), typeof(AndroidExtendedWebViewRenderer))]
namespace ProMama.Droid.Components
{
    public class AndroidExtendedWebViewRenderer : WebViewRenderer
    {
        static ExtendedWebView _xwebView = null;
        WebView _webView;

        class ExtendedWebViewClient : Android.Webkit.WebViewClient
        {
            public override async void OnPageFinished(WebView view, string url)
            {
                if (_xwebView != null)
                {
                    int i = 10;
                    while (view.ContentHeight == 0 && i-- > 0) // wait here till content is rendered
                        await System.Threading.Tasks.Task.Delay(10);
                    _xwebView.HeightRequest = view.ContentHeight;
                }
                base.OnPageFinished(view, url);
            }
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);
            _xwebView = e.NewElement as ExtendedWebView;
            _webView = Control;

            Control.SetBackgroundColor(Android.Graphics.Color.Transparent);

            if (e.OldElement == null)
            {
                _webView.SetWebViewClient(new ExtendedWebViewClient());
            }
        }
    }
}