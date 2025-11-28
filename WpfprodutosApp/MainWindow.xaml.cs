using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace WpfprodutosApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> _products = new ObservableCollection<Product> (); 
        private ICollectionView _view;
      

        public MainWindow()
        {
            InitializeComponent();
            _products.Add (new Product { Id =1,Name ="Keyboard",Price = 199.90m});
            _products.Add(new Product { Id = 2, Name = "Mouse", Price = 99.90m });
            _products.Add(new Product { Id = 3, Name = "Monitor", Price = 1299.00m });

            _view =CollectionViewSource.GetDefaultView(_products);
            dgProducts.ItemsSource = _view;
        }

        private async void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new AddEditProductWindow();
            if (dlg.ShowDialog() ==true)
            {
                //All fields are required ; the dialog already validates empties
                
            }
        }
           
        

      
    }
}
