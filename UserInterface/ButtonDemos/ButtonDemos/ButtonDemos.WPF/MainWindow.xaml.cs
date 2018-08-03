using Xamarin.Forms.Platform.WPF;

namespace ButtonDemos.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();
            Xamarin.Forms.Forms.Init();
            LoadApplication(new ButtonDemos.App());
        }
    }
}
