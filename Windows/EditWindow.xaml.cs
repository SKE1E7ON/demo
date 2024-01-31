using demopract2024_2.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace demopract2024_2.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        ContextClass _context = new ContextClass();
        public Product selectedProduct;
        List<Manufacturer> manufacturers = new List<Manufacturer>(0);
        List<Supplier> suppliers = new List<Supplier>(0);
        List<Category> categories = new List<Category>(0);
        public EditWindow(Product product)
        {
            selectedProduct = _context.Products.FirstOrDefault(x => x.ProductArticleNumber == product.ProductArticleNumber);
            InitializeComponent();
            Grid_Product.DataContext = selectedProduct;
            LoadComboBox();

        }
        public void LoadComboBox()
        {
            manufacturers = _context.Manufacturers.ToList();
            suppliers = _context.Suppliers.ToList();
            categories = _context.Categories.ToList();

            ComboBox_Category.ItemsSource = categories;
            ComboBox_Category.SelectedValue = selectedProduct.ProductCategory;

            ComboBox_Supplier.ItemsSource = suppliers;
            ComboBox_Supplier.SelectedValue = selectedProduct.ProductSupplier;

            ComboBox_Manufacturer.ItemsSource = manufacturers;
            ComboBox_Manufacturer.SelectedValue = selectedProduct.ProductManufacturer;

        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            OutViewInfo outViewInfo = new OutViewInfo();
            outViewInfo.Show();
            this.Close();
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Name.Text == "" || TextBox_Count.Text == "" || TextBox_Description.Text == ""
                || TextBox_Count.Text == "" || TextBox_DiscountAmount.Text == "" || TextBox_Unit.Text == ""
                || ComboBox_Category.SelectedIndex == -1 || ComboBox_Manufacturer.SelectedIndex == -1 || ComboBox_Supplier.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                selectedProduct.ProductCategory = int.Parse(ComboBox_Category.SelectedValue.ToString());
                selectedProduct.ProductManufacturer = int.Parse(ComboBox_Manufacturer.SelectedValue.ToString());
                selectedProduct.ProductSupplier = int.Parse(ComboBox_Supplier.SelectedValue.ToString());
                _context.SaveChanges();
            }
            
        }

        private void Button_AddImage_Click(object sender, RoutedEventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                string fileName = System.IO.Path.GetFileName(openFileDialog.FileName);
                MessageBox.Show(fileUri.ToString());
            }

        }

        private void ComboBox_Manufacturer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
