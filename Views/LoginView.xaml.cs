using System.Globalization;
using V2DO.Resources.Languages;

namespace V2DO.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    private void OnLanguageChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        string selectedLanguage = picker.SelectedItem.ToString();

        CultureInfo culture = new CultureInfo(selectedLanguage);
        CultureInfo.CurrentCulture = culture;
        CultureInfo.CurrentUICulture = culture;

        AppResources.Culture = culture; 
        RefreshUI();
    }

    private void RefreshUI()
    {
        Application.Current.MainPage = new AppShell();
    }
}