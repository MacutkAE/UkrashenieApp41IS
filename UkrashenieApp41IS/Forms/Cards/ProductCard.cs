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

namespace UkrashenieApp41IS.Forms.Cards
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }
        public void GenerateDataToProductCard(Product product)
        {
            nameLabel.Text = product.ProductName;
            descriptionLabel.Text = product.ProductDescription;
            manufacturerLabel.Text = product.ProductManufacturer;
            costLabel.Text = product.ProductCost.ToString();
            discountAmountLabel.Text = product.ProductDiscountAmount.ToString();

            if(product.ProductPhoto != "" && product.ProductPhoto != null)
            {
                if(product.ProductPhoto.Length < 15)
                {
                    productPictureBox.ImageLocation = ".\\Товар_import\\" + product.ProductPhoto;
                }
                else
                {
                    productPictureBox.ImageLocation = product.ProductPhoto;
                }
                
            }

            if(product.ProductDiscountAmount > 15)
            {
                BackColor = Color.Chartreuse;
            }
            if(product.ProductDiscountAmount !=0)
            {
                discountPriceLabel.Visible = true;
                decimal cost = product.ProductCost - (product.ProductCost * product.ProductDiscountAmount / 100);
                discountPriceLabel.Text = cost.ToString();
                Font font = new Font("Comic Sans MS", 12, FontStyle.Strikeout);
                costLabel.Font = font;
            }
            idLabel.Text = product.ProductArticleNumber;
        }
    }
}