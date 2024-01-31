using demopract2024_2.Model;
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

namespace demopract2024_2.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        ContextClass _context = new ContextClass();
        List<Manufacturer> manufacturers = new List<Manufacturer>(0);
        List<Supplier> suppliers = new List<Supplier>(0);
        List<Category> categories = new List<Category>(0);
        public AddWindow()
        {
            InitializeComponent();
        }
        public void LoadComboBox()
        {
            manufacturers = _context.Manufacturers.ToList();
            suppliers = _context.Suppliers.ToList();
            categories = _context.Categories.ToList();

            ComboBox_Category.ItemsSource = categories;

            ComboBox_Supplier.ItemsSource = suppliers;

            ComboBox_Manufacturer.ItemsSource = manufacturers;

        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            OutViewInfo outViewInfo = new OutViewInfo();
            outViewInfo.Show();
            this.Close();
        }

        private void Button_AddImage_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Name.Text == "" || TextBox_Count.Text == "" || TextBox_Description.Text == ""
            || TextBox_Count.Text == "" || TextBox_DiscountAmount.Text == "" || TextBox_Unit.Text == ""
            || ComboBox_Category.SelectedIndex == -1 || ComboBox_Manufacturer.SelectedIndex == -1 || ComboBox_Supplier.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Product new_product = new Product()
                {
                    ProductName = TextBox_Name.Text,
                    ProductUnit = TextBox_Unit.Text,
                    ProductDescription = TextBox_Description.Text,

                    ProductCategory = int.Parse(ComboBox_Category.SelectedValue.ToString()),
                    ProductManufacturer = int.Parse(ComboBox_Manufacturer.SelectedValue.ToString()),
                    ProductSupplier = int.Parse(ComboBox_Supplier.SelectedValue.ToString()),

                    ProductQuantityInStock = Convert.ToInt32(TextBox_Count.Text),
                    ProductDiscountAmount = Convert.ToSByte(TextBox_DiscountAmount.Text),
                    ProductCost = Convert.ToDecimal(TextBox_Cost.Text),
                };
                _context.Products.Add(new_product);
                _context.SaveChanges();
            }
        }
    }
}
