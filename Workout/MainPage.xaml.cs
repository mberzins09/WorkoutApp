namespace Workout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string videoUrl = "https://www.youtube.com/embed/adjftC5oHPM";
            VideoWebView.Source = videoUrl;
        }
    }
}
