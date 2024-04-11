namespace RecycleElementBug
{
    public partial class MainPage : ContentPage
    {
        public MainPageViewModel ViewModel { get; set; }


        public MainPage()
        {
            InitializeComponent();
            ViewModel = new MainPageViewModel(this);
            BindingContext = ViewModel;        
        }
    }
}
