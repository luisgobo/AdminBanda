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
        public ObservableCollection<Entidades.MenuItem> Menu { get; set; } = new ObservableCollection<Entidades.MenuItem>();

        public MenuPage()
        {
            Menu = new ObservableCollection<Entidades.MenuItem>();

            InitializeComponent();

            BindingContext = this;
            MenuList.ItemSelected += OnMenuSelected;

        }

        private void OnMenuSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Entidades.MenuItem;
            item?.Command.Execute(item);
        }
    }    
}