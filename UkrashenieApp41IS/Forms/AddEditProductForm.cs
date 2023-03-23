using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UkrashenieApp41IS.ModelEF;
using UkrashenieApp41IS.Utils;

namespace UkrashenieApp41IS.Forms
{
    public partial class AddEditProductForm : Form
    {
        public Product productUpData { get; set; }
        public AddEditProductForm()
        {
            InitializeComponent();
        }

        private void AddEditProductForm_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = productUpData;
            if (productUpData.ProductPhoto != "" && productUpData.ProductPhoto != null)
            {
                if (productUpData.ProductPhoto.Length < 15)
                {
                    photoPictureBox.ImageLocation = ".\\Товар_import\\" + productUpData.ProductPhoto;
                }
                else
                {
                    photoPictureBox.ImageLocation = productUpData.ProductPhoto;
                }

            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void changePhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // Создание диалогового окна для выбора файла
            openFileDialog.Filter = "Image Files|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    photoPictureBox.ImageLocation = openFileDialog.FileName;
                }
                catch
                {
                    DialogResult result = MessageBox.Show("Не удалось изменить фото", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                productUpData.ProductDescription = productDescriptionTextBox.Text;
                productUpData.ProductCost = Convert.ToDecimal(productCostTextBox.Text);
                productUpData.ProductCategory = productCategoryTextBox.Text;
                productUpData.ProductArticleNumber = productArticleNumberTextBox.Text;
                productUpData.ProductDiscountAmount = Convert.ToByte(productDiscountAmountTextBox.Text);
                productUpData.ProductManufacturer = productManufacturerTextBox.Text;
                productUpData.ProductMaxPossibleDiscount = Convert.ToByte(productMaxPossibleDiscountTextBox.Text);
                productUpData.ProductName = productNameTextBox.Text;
                productUpData.ProductQuantityInStock = Convert.ToInt32(productQuantityInStockTextBox.Text);
                productUpData.ProductUnit = productUnitTextBox.Text;
                productUpData.ProductProvider = productProviderTextBox.Text;
                productUpData.ProductPhoto = photoPictureBox.ImageLocation;

                DbConnect.db.SaveChanges();
                MessageBox.Show("Сохранено");
            }
            catch
            {
                MessageBox.Show("Не удалось изменить продукт");
            }
        }

        private void productCategoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Только буквы
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void productCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Только цифры
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                productUpData.ProductDescription = productDescriptionTextBox.Text;
                productUpData.ProductCost = Convert.ToDecimal(productCostTextBox.Text);
                productUpData.ProductCategory = productCategoryTextBox.Text;
                productUpData.ProductArticleNumber = productArticleNumberTextBox.Text;
                productUpData.ProductDiscountAmount = Convert.ToByte(productDiscountAmountTextBox.Text);
                productUpData.ProductManufacturer = productManufacturerTextBox.Text;
                productUpData.ProductMaxPossibleDiscount = Convert.ToByte(productMaxPossibleDiscountTextBox.Text);
                productUpData.ProductName = productNameTextBox.Text;
                productUpData.ProductQuantityInStock = Convert.ToInt32(productQuantityInStockTextBox.Text);
                productUpData.ProductUnit = productUnitTextBox.Text;
                productUpData.ProductProvider = productProviderTextBox.Text;
                productUpData.ProductPhoto = photoPictureBox.ImageLocation;

                DbConnect.db.Product.Add(productUpData);
                DbConnect.db.SaveChanges();
                MessageBox.Show("Продукт добавлен");
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить товар");
            }
            

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы точно хотите удалить продукт?", "Удаление", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                try
                {
                    DbConnect.db.Product.Remove(productUpData);
                    DbConnect.db.SaveChanges();
                    MessageBox.Show("Успешно удалено");
                    MainForm mf = new MainForm();
                    mf.Show();
                    this.Hide();
                }
                catch 
                {
                    MessageBox.Show("Не удалось удалить продукт!");
                    
                }
            }
        }
    }
}