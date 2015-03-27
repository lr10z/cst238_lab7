using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI___Lab_7
{
    public partial class Form1 : Form
    {
        private ObjectSource source;

        public Form1()
        {
            InitializeComponent();

            source = new ObjectSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Gets ID from what is selected on the list
            categoryComboBox.ValueMember = "CategoryID";

            // The list of categories that is returned from GetCategories()
            categoryComboBox.DataSource = source.GetCategorys();

            // Displays the name of the categories
            categoryComboBox.DisplayMember = "CategoryName";
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Gets ID from selection 
            int catId = (int)categoryComboBox.SelectedValue;   
            
            // A list of products of the category that was selected in the comboBox
            IList<Product> currentList = source.GetProducts(catId);

            // Populate the listBox
            showProductsListBox.DataSource = currentList;

            // Sets what will actually show/display in the listBox
            showProductsListBox.DisplayMember = "ProductName";
           
            // To remove the bind from the previous selection
            nameTextBox.DataBindings.Clear();
            priceTextBox.DataBindings.Clear();
            saleCheckBox.DataBindings.Clear();

            // To set what the control displays
            nameTextBox.DataBindings.Add("Text", currentList, "ProductName");
            priceTextBox.DataBindings.Add("Text", currentList, "UnitPrice");
            saleCheckBox.DataBindings.Add("Checked", currentList, "OnSale");
        }
    }
}
