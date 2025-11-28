using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace WpfprodutosApp
{
    /// <summary>
    /// Interaction logic for AddProductWindow.xaml
    /// </summary>
    
    public partial class AddProductWindow : Window
    {
        public Product Model { get; set; }
        public AddProductWindow(Product existing = null)
        {
            InitializeComponent();
            //Work with a copa so Cancel is safe
            Model = existing == null
                ? new Product()
                : new Product
                {
                    Id = existing.Id,
                    Name = existing.Name,
                    Price = existing.Price
                };
            DataContext = Model;


        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Model.Name))
            {
                MessageBox.Show("All frelgs are required.", "Validation", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            DialogResult = true;
        }
        
    }
}
