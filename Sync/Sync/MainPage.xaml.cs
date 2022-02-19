using Xamarin.Forms;

namespace Sync
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ToolbarItem toolbar = new ToolbarItem
            {
                Text = "Settings",
                Order = ToolbarItemOrder.Default,
                Priority = 0,
                Icon = new FileImageSource
                {
                    File = "settings.png"
                }
            };
            toolbar.Clicked += async (s, e) =>
            {
                await Navigation.PushAsync(new SettingsPage());
            };

            ToolbarItems.Add(toolbar);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
