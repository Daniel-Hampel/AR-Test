namespace AR_Test;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private async void WebViewPermissionRequest(object sender, EventArgs e)
    {

        String url = "https://stemkoski.github.io/AR-Examples/hello-cube.html";
        // Überprüfen, ob die Kamera-Berechtigung erteilt wurde
        PermissionStatus status = await Permissions.CheckStatusAsync<Permissions.Camera>();

        if (status != PermissionStatus.Granted)
        {
            // Berechtigung für die Kamera anfordern
            status = await Permissions.RequestAsync<Permissions.Camera>();

            if (status == PermissionStatus.Granted)
            {
                // Kamera-Berechtigung wurde gewährt
                webview.Source = url; // Setzen Sie hier die URL der Webseite ein
            }
            else
            {
                // Kamera-Berechtigung wurde nicht gewährt, zeigen Sie eine Fehlermeldung an oder nehmen Sie andere Maßnahmen
            }
        }
        else
        {
            // Kamera-Berechtigung wurde bereits erteilt
            webview.Source = url; // Setzen Sie hier die URL der Webseite ein
        }
    }
}

