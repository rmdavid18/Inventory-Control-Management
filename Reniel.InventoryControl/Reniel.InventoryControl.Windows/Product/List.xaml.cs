using Reniel.InventoryControl.Windows.BLL;
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
using System.Windows.Shapes;

namespace Reniel.InventoryControl.Windows.Product
{
    /// <summary>
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : System.Windows.Window
    {
        public string sortBy = "ProductName";
        public string sortOrder = "asc";
        public List()
        {
            InitializeComponent();
            CboSortBy.ItemsSource = new List<string>() { "Price", "ProductName" };
            CboSortOrder.ItemsSource = new List<string>() { "Ascending", "Descending" };

            ShowData();
        }

        private void CboSortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            sortBy = CboSortBy.SelectedValue.ToString();
            ShowData();

        }
        private void ShowData()
        {
            dgProducts.ItemsSource = ProductBLL.GetList(sortBy, sortOrder);
        }

        private void CboSortOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CboSortOrder.SelectedValue.ToString().ToLower() == "ascending")
            {
                sortOrder = "asc";
               
            }
            else
            {
                sortOrder = "desc";
            }
            ShowData();
        }
    }
}
