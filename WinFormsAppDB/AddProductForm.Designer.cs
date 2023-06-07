namespace WinFormsAppDB
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productCategory = new System.Windows.Forms.TextBox();
            this.home = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.RegLabel = new System.Windows.Forms.Label();
            this.AddImgBtn = new System.Windows.Forms.Button();
            this.productProvider = new System.Windows.Forms.TextBox();
            this.productUnitlabel = new System.Windows.Forms.Label();
            this.productUnit = new System.Windows.Forms.TextBox();
            this.productMaxDiscoun = new System.Windows.Forms.TextBox();
            this.productQuantityInStock = new System.Windows.Forms.TextBox();
            this.productMaxDiscounlabel = new System.Windows.Forms.Label();
            this.productProviderlabel = new System.Windows.Forms.Label();
            this.productCost = new System.Windows.Forms.TextBox();
            this.productQuantityInStocklabel = new System.Windows.Forms.Label();
            this.productDiscountAmount = new System.Windows.Forms.TextBox();
            this.productDiscountAmountlabel = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.productArticleNumber = new System.Windows.Forms.TextBox();
            this.productCostlabel = new System.Windows.Forms.Label();
            this.productManufacturerlabel = new System.Windows.Forms.Label();
            this.productDescriptionlabel = new System.Windows.Forms.Label();
            this.imgProduct = new System.Windows.Forms.PictureBox();
            this.productCategorylabel = new System.Windows.Forms.Label();
            this.productManufacturer = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.productArticleNumberlabel = new System.Windows.Forms.Label();
            this.productNamelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(624, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(598, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 27);
            this.label1.TabIndex = 32;
            this.label1.Text = "–";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.productCategory);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.RegLabel);
            this.panel1.Controls.Add(this.AddImgBtn);
            this.panel1.Controls.Add(this.productProvider);
            this.panel1.Controls.Add(this.productUnitlabel);
            this.panel1.Controls.Add(this.productUnit);
            this.panel1.Controls.Add(this.productMaxDiscoun);
            this.panel1.Controls.Add(this.productQuantityInStock);
            this.panel1.Controls.Add(this.productMaxDiscounlabel);
            this.panel1.Controls.Add(this.productProviderlabel);
            this.panel1.Controls.Add(this.productCost);
            this.panel1.Controls.Add(this.productQuantityInStocklabel);
            this.panel1.Controls.Add(this.productDiscountAmount);
            this.panel1.Controls.Add(this.productDiscountAmountlabel);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.productArticleNumber);
            this.panel1.Controls.Add(this.productCostlabel);
            this.panel1.Controls.Add(this.productManufacturerlabel);
            this.panel1.Controls.Add(this.productDescriptionlabel);
            this.panel1.Controls.Add(this.imgProduct);
            this.panel1.Controls.Add(this.productCategorylabel);
            this.panel1.Controls.Add(this.productManufacturer);
            this.panel1.Controls.Add(this.productName);
            this.panel1.Controls.Add(this.productArticleNumberlabel);
            this.panel1.Controls.Add(this.productNamelabel);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 469);
            this.panel1.TabIndex = 35;
            // 
            // productCategory
            // 
            this.productCategory.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCategory.Location = new System.Drawing.Point(215, 94);
            this.productCategory.Name = "productCategory";
            this.productCategory.Size = new System.Drawing.Size(196, 30);
            this.productCategory.TabIndex = 59;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Transparent;
            this.home.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.home.ForeColor = System.Drawing.Color.Black;
            this.home.Location = new System.Drawing.Point(533, 419);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(88, 36);
            this.home.TabIndex = 58;
            this.home.Text = "Отмена";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(425, 419);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(88, 36);
            this.saveBtn.TabIndex = 57;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // RegLabel
            // 
            this.RegLabel.AutoSize = true;
            this.RegLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLabel.ForeColor = System.Drawing.Color.Black;
            this.RegLabel.Location = new System.Drawing.Point(3, 4);
            this.RegLabel.Name = "RegLabel";
            this.RegLabel.Size = new System.Drawing.Size(327, 45);
            this.RegLabel.TabIndex = 56;
            this.RegLabel.Text = "Добавление товара";
            // 
            // AddImgBtn
            // 
            this.AddImgBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddImgBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AddImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddImgBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddImgBtn.ForeColor = System.Drawing.Color.Black;
            this.AddImgBtn.Location = new System.Drawing.Point(3, 310);
            this.AddImgBtn.Name = "AddImgBtn";
            this.AddImgBtn.Size = new System.Drawing.Size(200, 36);
            this.AddImgBtn.TabIndex = 55;
            this.AddImgBtn.Text = "Загрузить изображение";
            this.AddImgBtn.UseVisualStyleBackColor = false;
            this.AddImgBtn.Click += new System.EventHandler(this.AddImgBtn_Click);
            // 
            // productProvider
            // 
            this.productProvider.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productProvider.Location = new System.Drawing.Point(425, 383);
            this.productProvider.Name = "productProvider";
            this.productProvider.Size = new System.Drawing.Size(196, 30);
            this.productProvider.TabIndex = 51;
            // 
            // productUnitlabel
            // 
            this.productUnitlabel.AutoSize = true;
            this.productUnitlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productUnitlabel.Location = new System.Drawing.Point(421, 299);
            this.productUnitlabel.Name = "productUnitlabel";
            this.productUnitlabel.Size = new System.Drawing.Size(162, 23);
            this.productUnitlabel.TabIndex = 33;
            this.productUnitlabel.Text = "Единица измерения\r\n";
            // 
            // productUnit
            // 
            this.productUnit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productUnit.Location = new System.Drawing.Point(425, 324);
            this.productUnit.Name = "productUnit";
            this.productUnit.Size = new System.Drawing.Size(196, 30);
            this.productUnit.TabIndex = 50;
            // 
            // productMaxDiscoun
            // 
            this.productMaxDiscoun.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productMaxDiscoun.Location = new System.Drawing.Point(215, 324);
            this.productMaxDiscoun.Name = "productMaxDiscoun";
            this.productMaxDiscoun.Size = new System.Drawing.Size(196, 30);
            this.productMaxDiscoun.TabIndex = 49;
            // 
            // productQuantityInStock
            // 
            this.productQuantityInStock.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productQuantityInStock.Location = new System.Drawing.Point(7, 383);
            this.productQuantityInStock.Name = "productQuantityInStock";
            this.productQuantityInStock.Size = new System.Drawing.Size(196, 30);
            this.productQuantityInStock.TabIndex = 48;
            // 
            // productMaxDiscounlabel
            // 
            this.productMaxDiscounlabel.AutoSize = true;
            this.productMaxDiscounlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productMaxDiscounlabel.Location = new System.Drawing.Point(210, 299);
            this.productMaxDiscounlabel.Name = "productMaxDiscounlabel";
            this.productMaxDiscounlabel.Size = new System.Drawing.Size(178, 23);
            this.productMaxDiscounlabel.TabIndex = 35;
            this.productMaxDiscounlabel.Text = "Максимальная скидка";
            // 
            // productProviderlabel
            // 
            this.productProviderlabel.AutoSize = true;
            this.productProviderlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productProviderlabel.Location = new System.Drawing.Point(421, 357);
            this.productProviderlabel.Name = "productProviderlabel";
            this.productProviderlabel.Size = new System.Drawing.Size(97, 23);
            this.productProviderlabel.TabIndex = 36;
            this.productProviderlabel.Text = "Поставщик";
            // 
            // productCost
            // 
            this.productCost.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCost.Location = new System.Drawing.Point(214, 265);
            this.productCost.Name = "productCost";
            this.productCost.Size = new System.Drawing.Size(196, 30);
            this.productCost.TabIndex = 47;
            // 
            // productQuantityInStocklabel
            // 
            this.productQuantityInStocklabel.AutoSize = true;
            this.productQuantityInStocklabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productQuantityInStocklabel.Location = new System.Drawing.Point(7, 357);
            this.productQuantityInStocklabel.Name = "productQuantityInStocklabel";
            this.productQuantityInStocklabel.Size = new System.Drawing.Size(141, 23);
            this.productQuantityInStocklabel.TabIndex = 38;
            this.productQuantityInStocklabel.Text = "Кол-во на складе";
            // 
            // productDiscountAmount
            // 
            this.productDiscountAmount.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productDiscountAmount.Location = new System.Drawing.Point(425, 265);
            this.productDiscountAmount.Name = "productDiscountAmount";
            this.productDiscountAmount.Size = new System.Drawing.Size(196, 30);
            this.productDiscountAmount.TabIndex = 46;
            // 
            // productDiscountAmountlabel
            // 
            this.productDiscountAmountlabel.AutoSize = true;
            this.productDiscountAmountlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productDiscountAmountlabel.Location = new System.Drawing.Point(421, 241);
            this.productDiscountAmountlabel.Name = "productDiscountAmountlabel";
            this.productDiscountAmountlabel.Size = new System.Drawing.Size(172, 23);
            this.productDiscountAmountlabel.TabIndex = 41;
            this.productDiscountAmountlabel.Text = "Действующая скидка";
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.Location = new System.Drawing.Point(214, 155);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(407, 83);
            this.description.TabIndex = 53;
            this.description.Text = "";
            // 
            // productArticleNumber
            // 
            this.productArticleNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productArticleNumber.Location = new System.Drawing.Point(425, 94);
            this.productArticleNumber.Name = "productArticleNumber";
            this.productArticleNumber.Size = new System.Drawing.Size(196, 30);
            this.productArticleNumber.TabIndex = 52;
            // 
            // productCostlabel
            // 
            this.productCostlabel.AutoSize = true;
            this.productCostlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCostlabel.Location = new System.Drawing.Point(210, 241);
            this.productCostlabel.Name = "productCostlabel";
            this.productCostlabel.Size = new System.Drawing.Size(92, 23);
            this.productCostlabel.TabIndex = 42;
            this.productCostlabel.Text = "Стоимость";
            // 
            // productManufacturerlabel
            // 
            this.productManufacturerlabel.AutoSize = true;
            this.productManufacturerlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productManufacturerlabel.Location = new System.Drawing.Point(210, 358);
            this.productManufacturerlabel.Name = "productManufacturerlabel";
            this.productManufacturerlabel.Size = new System.Drawing.Size(130, 23);
            this.productManufacturerlabel.TabIndex = 39;
            this.productManufacturerlabel.Text = "Производитель";
            // 
            // productDescriptionlabel
            // 
            this.productDescriptionlabel.AutoSize = true;
            this.productDescriptionlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productDescriptionlabel.Location = new System.Drawing.Point(210, 129);
            this.productDescriptionlabel.Name = "productDescriptionlabel";
            this.productDescriptionlabel.Size = new System.Drawing.Size(91, 23);
            this.productDescriptionlabel.TabIndex = 37;
            this.productDescriptionlabel.Text = "Описание ";
            // 
            // imgProduct
            // 
            this.imgProduct.Location = new System.Drawing.Point(3, 130);
            this.imgProduct.Name = "imgProduct";
            this.imgProduct.Size = new System.Drawing.Size(200, 165);
            this.imgProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProduct.TabIndex = 43;
            this.imgProduct.TabStop = false;
            // 
            // productCategorylabel
            // 
            this.productCategorylabel.AutoSize = true;
            this.productCategorylabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCategorylabel.Location = new System.Drawing.Point(210, 67);
            this.productCategorylabel.Name = "productCategorylabel";
            this.productCategorylabel.Size = new System.Drawing.Size(88, 23);
            this.productCategorylabel.TabIndex = 34;
            this.productCategorylabel.Text = "Категория";
            // 
            // productManufacturer
            // 
            this.productManufacturer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productManufacturer.Location = new System.Drawing.Point(214, 383);
            this.productManufacturer.Name = "productManufacturer";
            this.productManufacturer.Size = new System.Drawing.Size(196, 30);
            this.productManufacturer.TabIndex = 45;
            // 
            // productName
            // 
            this.productName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productName.Location = new System.Drawing.Point(7, 94);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(196, 30);
            this.productName.TabIndex = 44;
            // 
            // productArticleNumberlabel
            // 
            this.productArticleNumberlabel.AutoSize = true;
            this.productArticleNumberlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productArticleNumberlabel.Location = new System.Drawing.Point(421, 68);
            this.productArticleNumberlabel.Name = "productArticleNumberlabel";
            this.productArticleNumberlabel.Size = new System.Drawing.Size(76, 23);
            this.productArticleNumberlabel.TabIndex = 40;
            this.productArticleNumberlabel.Text = "Артикул";
            // 
            // productNamelabel
            // 
            this.productNamelabel.AutoSize = true;
            this.productNamelabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNamelabel.Location = new System.Drawing.Point(3, 68);
            this.productNamelabel.Name = "productNamelabel";
            this.productNamelabel.Size = new System.Drawing.Size(121, 23);
            this.productNamelabel.TabIndex = 32;
            this.productNamelabel.Text = "Наименование";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProductForm";
            this.Text = "AddUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddImgBtn;
        private System.Windows.Forms.TextBox productProvider;
        private System.Windows.Forms.Label productUnitlabel;
        private System.Windows.Forms.TextBox productUnit;
        private System.Windows.Forms.TextBox productMaxDiscoun;
        private System.Windows.Forms.TextBox productQuantityInStock;
        private System.Windows.Forms.Label productMaxDiscounlabel;
        private System.Windows.Forms.Label productProviderlabel;
        private System.Windows.Forms.TextBox productCost;
        private System.Windows.Forms.Label productQuantityInStocklabel;
        private System.Windows.Forms.TextBox productDiscountAmount;
        private System.Windows.Forms.Label productDiscountAmountlabel;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.TextBox productArticleNumber;
        private System.Windows.Forms.Label productCostlabel;
        private System.Windows.Forms.Label productManufacturerlabel;
        private System.Windows.Forms.Label productDescriptionlabel;
        private System.Windows.Forms.PictureBox imgProduct;
        private System.Windows.Forms.Label productCategorylabel;
        private System.Windows.Forms.TextBox productManufacturer;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label productArticleNumberlabel;
        private System.Windows.Forms.Label productNamelabel;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label RegLabel;
        private System.Windows.Forms.TextBox productCategory;
    }
}