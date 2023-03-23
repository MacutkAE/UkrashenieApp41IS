namespace UkrashenieApp41IS.Forms.Cards
{
    partial class ProductCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.discountAmountLabel = new System.Windows.Forms.Label();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.discountPriceLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(203, 11);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(176, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Наименование товара";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(203, 44);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(56, 23);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "label2";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturerLabel.Location = new System.Drawing.Point(203, 78);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(56, 23);
            this.manufacturerLabel.TabIndex = 3;
            this.manufacturerLabel.Text = "label3";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(203, 112);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(56, 23);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "label4";
            // 
            // discountAmountLabel
            // 
            this.discountAmountLabel.AutoSize = true;
            this.discountAmountLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountAmountLabel.Location = new System.Drawing.Point(723, 60);
            this.discountAmountLabel.Name = "discountAmountLabel";
            this.discountAmountLabel.Size = new System.Drawing.Size(56, 23);
            this.discountAmountLabel.TabIndex = 5;
            this.discountAmountLabel.Text = "label5";
            // 
            // productPictureBox
            // 
            this.productPictureBox.Image = global::UkrashenieApp41IS.Properties.Resources.picture;
            this.productPictureBox.Location = new System.Drawing.Point(3, 13);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(151, 123);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 0;
            this.productPictureBox.TabStop = false;
            // 
            // discountPriceLabel
            // 
            this.discountPriceLabel.AutoSize = true;
            this.discountPriceLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountPriceLabel.Location = new System.Drawing.Point(360, 113);
            this.discountPriceLabel.Name = "discountPriceLabel";
            this.discountPriceLabel.Size = new System.Drawing.Size(63, 23);
            this.discountPriceLabel.TabIndex = 6;
            this.discountPriceLabel.Text = "label41";
            this.discountPriceLabel.Visible = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(744, 123);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(35, 13);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "label1";
            this.idLabel.Visible = false;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.discountPriceLabel);
            this.Controls.Add(this.discountAmountLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.productPictureBox);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(808, 150);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label discountAmountLabel;
        private System.Windows.Forms.Label discountPriceLabel;
        public System.Windows.Forms.Label idLabel;
    }
}
