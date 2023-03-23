namespace UkrashenieApp41IS.Forms
{
    partial class AddEditProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productArticleNumberLabel;
            System.Windows.Forms.Label productCategoryLabel;
            System.Windows.Forms.Label productCostLabel;
            System.Windows.Forms.Label productDescriptionLabel;
            System.Windows.Forms.Label productDiscountAmountLabel;
            System.Windows.Forms.Label productManufacturerLabel;
            System.Windows.Forms.Label productMaxPossibleDiscountLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label productProviderLabel;
            System.Windows.Forms.Label productQuantityInStockLabel;
            System.Windows.Forms.Label productUnitLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productArticleNumberTextBox = new System.Windows.Forms.TextBox();
            this.productCategoryTextBox = new System.Windows.Forms.TextBox();
            this.productCostTextBox = new System.Windows.Forms.TextBox();
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.productDiscountAmountTextBox = new System.Windows.Forms.TextBox();
            this.productManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.productMaxPossibleDiscountTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productProviderTextBox = new System.Windows.Forms.TextBox();
            this.productQuantityInStockTextBox = new System.Windows.Forms.TextBox();
            this.productUnitTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.changePhotoButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            productArticleNumberLabel = new System.Windows.Forms.Label();
            productCategoryLabel = new System.Windows.Forms.Label();
            productCostLabel = new System.Windows.Forms.Label();
            productDescriptionLabel = new System.Windows.Forms.Label();
            productDiscountAmountLabel = new System.Windows.Forms.Label();
            productManufacturerLabel = new System.Windows.Forms.Label();
            productMaxPossibleDiscountLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            productProviderLabel = new System.Windows.Forms.Label();
            productQuantityInStockLabel = new System.Windows.Forms.Label();
            productUnitLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UkrashenieApp41IS.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.addProductButton);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 1;
            // 
            // productArticleNumberLabel
            // 
            productArticleNumberLabel.AutoSize = true;
            productArticleNumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productArticleNumberLabel.Location = new System.Drawing.Point(38, 146);
            productArticleNumberLabel.Name = "productArticleNumberLabel";
            productArticleNumberLabel.Size = new System.Drawing.Size(70, 20);
            productArticleNumberLabel.TabIndex = 3;
            productArticleNumberLabel.Text = "Артикул";
            // 
            // productArticleNumberTextBox
            // 
            this.productArticleNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductArticleNumber", true));
            this.productArticleNumberTextBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productArticleNumberTextBox.Location = new System.Drawing.Point(219, 146);
            this.productArticleNumberTextBox.Name = "productArticleNumberTextBox";
            this.productArticleNumberTextBox.Size = new System.Drawing.Size(159, 28);
            this.productArticleNumberTextBox.TabIndex = 4;
            // 
            // productCategoryLabel
            // 
            productCategoryLabel.AutoSize = true;
            productCategoryLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productCategoryLabel.Location = new System.Drawing.Point(38, 172);
            productCategoryLabel.Name = "productCategoryLabel";
            productCategoryLabel.Size = new System.Drawing.Size(84, 20);
            productCategoryLabel.TabIndex = 5;
            productCategoryLabel.Text = "Категория";
            // 
            // productCategoryTextBox
            // 
            this.productCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductCategory", true));
            this.productCategoryTextBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCategoryTextBox.Location = new System.Drawing.Point(219, 172);
            this.productCategoryTextBox.Name = "productCategoryTextBox";
            this.productCategoryTextBox.Size = new System.Drawing.Size(159, 28);
            this.productCategoryTextBox.TabIndex = 6;
            this.productCategoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productCategoryTextBox_KeyPress);
            // 
            // productCostLabel
            // 
            productCostLabel.AutoSize = true;
            productCostLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productCostLabel.Location = new System.Drawing.Point(38, 198);
            productCostLabel.Name = "productCostLabel";
            productCostLabel.Size = new System.Drawing.Size(45, 20);
            productCostLabel.TabIndex = 7;
            productCostLabel.Text = "Цена";
            // 
            // productCostTextBox
            // 
            this.productCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductCost", true));
            this.productCostTextBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCostTextBox.Location = new System.Drawing.Point(219, 198);
            this.productCostTextBox.Name = "productCostTextBox";
            this.productCostTextBox.Size = new System.Drawing.Size(159, 28);
            this.productCostTextBox.TabIndex = 8;
            this.productCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productCostTextBox_KeyPress);
            // 
            // productDescriptionLabel
            // 
            productDescriptionLabel.AutoSize = true;
            productDescriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productDescriptionLabel.Location = new System.Drawing.Point(38, 224);
            productDescriptionLabel.Name = "productDescriptionLabel";
            productDescriptionLabel.Size = new System.Drawing.Size(83, 20);
            productDescriptionLabel.TabIndex = 9;
            productDescriptionLabel.Text = "Описание";
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductDescription", true));
            this.productDescriptionTextBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productDescriptionTextBox.Location = new System.Drawing.Point(219, 224);
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(159, 28);
            this.productDescriptionTextBox.TabIndex = 10;
            // 
            // productDiscountAmountLabel
            // 
            productDiscountAmountLabel.AutoSize = true;
            productDiscountAmountLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productDiscountAmountLabel.Location = new System.Drawing.Point(38, 250);
            productDiscountAmountLabel.Name = "productDiscountAmountLabel";
            productDiscountAmountLabel.Size = new System.Drawing.Size(123, 20);
            productDiscountAmountLabel.TabIndex = 11;
            productDiscountAmountLabel.Text = "Текущая скидка";
            // 
            // productDiscountAmountTextBox
            // 
            this.productDiscountAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductDiscountAmount", true));
            this.productDiscountAmountTextBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productDiscountAmountTextBox.Location = new System.Drawing.Point(219, 250);
            this.productDiscountAmountTextBox.Name = "productDiscountAmountTextBox";
            this.productDiscountAmountTextBox.Size = new System.Drawing.Size(159, 28);
            this.productDiscountAmountTextBox.TabIndex = 12;
            // 
            // productManufacturerLabel
            // 
            productManufacturerLabel.AutoSize = true;
            productManufacturerLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productManufacturerLabel.Location = new System.Drawing.Point(38, 276);
            productManufacturerLabel.Name = "productManufacturerLabel";
            productManufacturerLabel.Size = new System.Drawing.Size(125, 20);
            productManufacturerLabel.TabIndex = 13;
            productManufacturerLabel.Text = "Производитель";
            // 
            // productManufacturerTextBox
            // 
            this.productManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductManufacturer", true));
            this.productManufacturerTextBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productManufacturerTextBox.Location = new System.Drawing.Point(219, 276);
            this.productManufacturerTextBox.Name = "productManufacturerTextBox";
            this.productManufacturerTextBox.Size = new System.Drawing.Size(159, 28);
            this.productManufacturerTextBox.TabIndex = 14;
            // 
            // productMaxPossibleDiscountLabel
            // 
            productMaxPossibleDiscountLabel.AutoSize = true;
            productMaxPossibleDiscountLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productMaxPossibleDiscountLabel.Location = new System.Drawing.Point(38, 302);
            productMaxPossibleDiscountLabel.Name = "productMaxPossibleDiscountLabel";
            productMaxPossibleDiscountLabel.Size = new System.Drawing.Size(168, 20);
            productMaxPossibleDiscountLabel.TabIndex = 15;
            productMaxPossibleDiscountLabel.Text = "Максимальная скидка";
            // 
            // productMaxPossibleDiscountTextBox
            // 
            this.productMaxPossibleDiscountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductMaxPossibleDiscount", true));
            this.productMaxPossibleDiscountTextBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productMaxPossibleDiscountTextBox.Location = new System.Drawing.Point(219, 302);
            this.productMaxPossibleDiscountTextBox.Name = "productMaxPossibleDiscountTextBox";
            this.productMaxPossibleDiscountTextBox.Size = new System.Drawing.Size(159, 28);
            this.productMaxPossibleDiscountTextBox.TabIndex = 16;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productNameLabel.Location = new System.Drawing.Point(38, 328);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(117, 20);
            productNameLabel.TabIndex = 17;
            productNameLabel.Text = "Наименование";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameTextBox.Location = new System.Drawing.Point(219, 328);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(159, 28);
            this.productNameTextBox.TabIndex = 18;
            // 
            // productProviderLabel
            // 
            productProviderLabel.AutoSize = true;
            productProviderLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productProviderLabel.Location = new System.Drawing.Point(38, 354);
            productProviderLabel.Name = "productProviderLabel";
            productProviderLabel.Size = new System.Drawing.Size(92, 20);
            productProviderLabel.TabIndex = 19;
            productProviderLabel.Text = "Поставщик";
            // 
            // productProviderTextBox
            // 
            this.productProviderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductProvider", true));
            this.productProviderTextBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productProviderTextBox.Location = new System.Drawing.Point(219, 354);
            this.productProviderTextBox.Name = "productProviderTextBox";
            this.productProviderTextBox.Size = new System.Drawing.Size(159, 28);
            this.productProviderTextBox.TabIndex = 20;
            // 
            // productQuantityInStockLabel
            // 
            productQuantityInStockLabel.AutoSize = true;
            productQuantityInStockLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productQuantityInStockLabel.Location = new System.Drawing.Point(38, 380);
            productQuantityInStockLabel.Name = "productQuantityInStockLabel";
            productQuantityInStockLabel.Size = new System.Drawing.Size(170, 20);
            productQuantityInStockLabel.TabIndex = 21;
            productQuantityInStockLabel.Text = "Количество на складе";
            // 
            // productQuantityInStockTextBox
            // 
            this.productQuantityInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductQuantityInStock", true));
            this.productQuantityInStockTextBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productQuantityInStockTextBox.Location = new System.Drawing.Point(219, 380);
            this.productQuantityInStockTextBox.Name = "productQuantityInStockTextBox";
            this.productQuantityInStockTextBox.Size = new System.Drawing.Size(159, 28);
            this.productQuantityInStockTextBox.TabIndex = 22;
            // 
            // productUnitLabel
            // 
            productUnitLabel.AutoSize = true;
            productUnitLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productUnitLabel.Location = new System.Drawing.Point(38, 406);
            productUnitLabel.Name = "productUnitLabel";
            productUnitLabel.Size = new System.Drawing.Size(154, 20);
            productUnitLabel.TabIndex = 23;
            productUnitLabel.Text = "Единица измерения";
            // 
            // productUnitTextBox
            // 
            this.productUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductUnit", true));
            this.productUnitTextBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productUnitTextBox.Location = new System.Drawing.Point(219, 406);
            this.productUnitTextBox.Name = "productUnitTextBox";
            this.productUnitTextBox.Size = new System.Drawing.Size(159, 28);
            this.productUnitTextBox.TabIndex = 24;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(42, 39);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 41);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Image = global::UkrashenieApp41IS.Properties.Resources.picture;
            this.photoPictureBox.Location = new System.Drawing.Point(521, 142);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(185, 136);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 25;
            this.photoPictureBox.TabStop = false;
            // 
            // changePhotoButton
            // 
            this.changePhotoButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePhotoButton.Location = new System.Drawing.Point(521, 307);
            this.changePhotoButton.Name = "changePhotoButton";
            this.changePhotoButton.Size = new System.Drawing.Size(185, 41);
            this.changePhotoButton.TabIndex = 26;
            this.changePhotoButton.Text = "Выбрать фото";
            this.changePhotoButton.UseVisualStyleBackColor = true;
            this.changePhotoButton.Click += new System.EventHandler(this.changePhotoButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(689, 39);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 41);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Назад";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(210, 51);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(124, 23);
            this.addProductButton.TabIndex = 2;
            this.addProductButton.Text = "Добавить товар";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(UkrashenieApp41IS.ModelEF.Product);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(391, 50);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(124, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AddEditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.changePhotoButton);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(productArticleNumberLabel);
            this.Controls.Add(this.productArticleNumberTextBox);
            this.Controls.Add(productCategoryLabel);
            this.Controls.Add(this.productCategoryTextBox);
            this.Controls.Add(productCostLabel);
            this.Controls.Add(this.productCostTextBox);
            this.Controls.Add(productDescriptionLabel);
            this.Controls.Add(this.productDescriptionTextBox);
            this.Controls.Add(productDiscountAmountLabel);
            this.Controls.Add(this.productDiscountAmountTextBox);
            this.Controls.Add(productManufacturerLabel);
            this.Controls.Add(this.productManufacturerTextBox);
            this.Controls.Add(productMaxPossibleDiscountLabel);
            this.Controls.Add(this.productMaxPossibleDiscountTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(productProviderLabel);
            this.Controls.Add(this.productProviderTextBox);
            this.Controls.Add(productQuantityInStockLabel);
            this.Controls.Add(this.productQuantityInStockTextBox);
            this.Controls.Add(productUnitLabel);
            this.Controls.Add(this.productUnitTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditProductForm";
            this.Text = "ООО Украшение - Добавить/редактировать товар";
            this.Load += new System.EventHandler(this.AddEditProductForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox productArticleNumberTextBox;
        private System.Windows.Forms.TextBox productCategoryTextBox;
        private System.Windows.Forms.TextBox productCostTextBox;
        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.TextBox productDiscountAmountTextBox;
        private System.Windows.Forms.TextBox productManufacturerTextBox;
        private System.Windows.Forms.TextBox productMaxPossibleDiscountTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productProviderTextBox;
        private System.Windows.Forms.TextBox productQuantityInStockTextBox;
        private System.Windows.Forms.TextBox productUnitTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button changePhotoButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteButton;
    }
}