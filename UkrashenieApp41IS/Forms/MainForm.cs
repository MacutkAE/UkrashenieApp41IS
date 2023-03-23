using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UkrashenieApp41IS.Forms.Cards;
using UkrashenieApp41IS.ModelEF;
using UkrashenieApp41IS.Utils;

namespace UkrashenieApp41IS.Forms
{
    public partial class MainForm : Form
    {
        public static List<Product> products = new List<Product>();
        public MainForm()
        {
            InitializeComponent();
            products = DbConnect.db.Product.ToList();
        }
        private void GenerateProductCardList(List<Product> product)
        {
            foreach (var item in product)
            {
                ProductCard card = new ProductCard();
                card.GenerateDataToProductCard(item);
                flowLayoutPanel1.Controls.Add(card);
                card.DoubleClick += Card_DoubleClick;
            }
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            if(AuthorizationForm.staticUser != null && AuthorizationForm.staticUser.UserRole ==2)
            {
                ProductCard card = (ProductCard)sender;
                AddEditProductForm ab = new AddEditProductForm();
                ab.productUpData = products.First(a => a.ProductArticleNumber == card.idLabel.Text);
                ab.Show();
                this.Hide();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sortComboBox.SelectedIndex = 0;
            filtrComboBox.SelectedIndex = 0;

            if(AuthorizationForm.staticUser != null)
            {
                fullNameLabel.Text = AuthorizationForm.staticUser.UserSurname + " " + AuthorizationForm.staticUser.UserName + " " + AuthorizationForm.staticUser.UserPatronymic;
                if(AuthorizationForm.staticUser.UserRole != 2)
                {
                    addProductButton.Visible = false;
                }
            }
            else
            {
                addProductButton.Visible = false;
                fullNameLabel.Text = "Гость";
            }
            
        }
        private void DataPreparation()
        {
            flowLayoutPanel1.Controls.Clear();
            var listUpdate = products;
            if(sortComboBox.Text == "Стоимость")
            {
                if(descendingСheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderByDescending(a => a.ProductCost).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderBy(a => a.ProductCost).ToList();
                }
            }
            if(filtrComboBox.SelectedIndex !=0)
            {
                switch (filtrComboBox.SelectedIndex)
                {
                    case 1:
                        listUpdate = listUpdate.Where(a => a.ProductDiscountAmount <= 9.99).ToList();
                        break;
                    case 2:
                        listUpdate = listUpdate.Where(a => a.ProductDiscountAmount >= 10.00 && a.ProductDiscountAmount <= 14.99).ToList();
                        break ;
                    case 3:
                        listUpdate = listUpdate.Where(a => a.ProductDiscountAmount >= 15.00).ToList();
                        break;
                }
            }
            if(searchTextBox.Text != " ")
            {
                listUpdate = listUpdate.Where(a => a.ProductName.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
            }
            countLabel.Text = listUpdate.Count.ToString() + " из " + products.Count.ToString();
            GenerateProductCardList(listUpdate);
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataPreparation();
        }

        private void descendingСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DataPreparation();
        }

        private void filtrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataPreparation();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataPreparation();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddEditProductForm ab = new AddEditProductForm();
            ab.productUpData = new Product();
            ab.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrdersForm ab = new OrdersForm();
            ab.Show();
            this.Hide();
        }
    }
}