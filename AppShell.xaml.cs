namespace ModalThemeBug;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Comment this and use button on main page to see that issue only occurs when doing this
        await Navigation.PushModalAsync(new NewPage1());
    }
}
