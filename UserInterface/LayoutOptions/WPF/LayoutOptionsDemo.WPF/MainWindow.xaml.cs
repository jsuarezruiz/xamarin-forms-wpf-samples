using Xamarin.Forms.Platform.WPF;

namespace LayoutOptionsDemo.WPF
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
            LoadApplication(new LayoutOptionsDemo.App());
        }
    }
}
