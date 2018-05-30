using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AdminBanda.Entidades;


namespace AdminBanda.MainPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage
    {
        public ObservableCollection<ContentMenuItem> Menu { get; set; } = new ObservableCollection<ContentMenuItem>();

        public MenuPage()
        {
            Menu = new ObservableCollection<ContentMenuItem>();

            InitializeComponent();

            BindingContext = this;
            MenuList.ItemSelected += OnMenuSelected;

        }

        private void OnMenuSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ContentMenuItem;
            item?.Command.Execute(item);
        }
    }    
}