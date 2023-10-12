using System.Threading.Tasks;

namespace AR_Test;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (!await CheckPermission())
        {
			Console.WriteLine("PERMISSION NOT GRANTED!!!");
            //Application.Current.Quit();
        } else
		{
            WebView myWebView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://ar-js-org.github.io/.github/profile/aframe/examples/image-tracking/nft/" // Die URL Ihrer Webseite
                }
            };

            Content = myWebView;

            myWebView.Eval("navigator.mediaDevices.getUserMedia({ video: true })");

            Console.WriteLine("PERMISSION GRANTED!!!");
		}
    }

	private async Task<bool> CheckPermission()
	{
        PermissionStatus status = await Permissions.CheckStatusAsync<Permissions.Camera>();

        if (status != PermissionStatus.Granted)
        {
            status = await Permissions.RequestAsync<Permissions.Camera>();
        }

        return status == PermissionStatus.Granted;
    }
}

