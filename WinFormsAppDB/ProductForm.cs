using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsAppDB
{
    public partial class ProductForm : Form
    {
        private BesprozvannykhDBEntities dBEntities = new BesprozvannykhDBEntities();
        private List<Product> _allProducts;
        private string _selectedManufacturer = "Все производители";
        private string _selectedSort = "Без сортировки";

        private int currentPage = 1;
        private int _itemsPerPage = 3;
        private int userRole;
        public ProductForm(string us, string un, string up, int ur)
        {
            InitializeComponent();
            if (us != null) FullName.Text = $"{us} {un} {up}";
            else FullName.Text = "Гость";
            this.userRole = ur;
            CenterToScreen();
        }
        private void comboBoxManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            _selectedManufacturer = comboBoxManufacturer.SelectedItem.ToString();
            UpdateProductCards();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            UpdateProductCards();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedSort = comboBox1.SelectedItem.ToString();
            UpdateProductCards();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            _allProducts = dBEntities.Product.ToList();
            GenerateCards(tableLayoutPanel1, _allProducts, userRole);
            comboBox1.Items.Add("Без сортировки");
            comboBox1.Items.Add("По возрастанию");
            comboBox1.Items.Add("по убыванию");
            comboBox1.SelectedIndex = 0;
            comboBoxManufacturer.Items.Clear();
            comboBoxManufacturer.Items.Add("Все производители");
            var manufacturers = dBEntities.Product.Select(p => p.ProductManufacturer).Distinct().ToList();
            foreach (var manufacturer in manufacturers)
            {
                comboBoxManufacturer.Items.Add(manufacturer);
            }
            comboBoxManufacturer.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void GenerateCards(TableLayoutPanel tableLayoutPanel1, List<Product> products, int userRole)
        {
            User user = new User();
            int row = 0;
            foreach (Product product in products)
            {
                Panel productCard = new Panel();
                productCard.BorderStyle = BorderStyle.FixedSingle;
                productCard.Width = tableLayoutPanel1.ClientSize.Width / 1 - 10;
                productCard.Height = 170;

                PictureBox productImage = new PictureBox();
                productImage.SizeMode = PictureBoxSizeMode.StretchImage;
                productImage.Width = 150;
                productImage.Height = 100;
                if (product.ProductPhoto != null && product.ProductPhoto.Length > 0)
                {
                    //using (MemoryStream ms = new MemoryStream(Convert.ToInt32(product.ProductPhoto)))
                    //{
                    //    productImage.Image = Image.FromStream(ms);
                    //}
                    if(product.ProductPhoto== "B111C5.JPEG") productImage.Image = Properties.Resources.B111C5;
                    else if (product.ProductPhoto == "E112C6.JPG") productImage.Image = Properties.Resources.E112C6;
                    else if (product.ProductPhoto == "K839K3.JPG") productImage.Image = Properties.Resources.K839K3;
                    else if (product.ProductPhoto == "L293S9.JPG") productImage.Image = Properties.Resources.L293S9;
                    else if (product.ProductPhoto == "M112C8.JPG") productImage.Image = Properties.Resources.M112C8;
                    else if (product.ProductPhoto == "M294G9.JPG") productImage.Image = Properties.Resources.M294G9;
                    else if (product.ProductPhoto == "M398S9.JPG") productImage.Image = Properties.Resources.M398S9;
                    else if (product.ProductPhoto == "N283K3.JPG") productImage.Image = Properties.Resources.N283K3;
                    else if (product.ProductPhoto == "S384K2.JPG") productImage.Image = Properties.Resources.S384K2;
                    else if (product.ProductPhoto == "T238C7.JPG") productImage.Image = Properties.Resources.T238C7;
                    else productImage.Image = Properties.Resources.picture;
                }
                else
                {
                    productImage.Image = Properties.Resources.picture;
                }
                productImage.Top = (productCard.Height - productImage.Height) / 2;
                productImage.Left = 10;

                Panel separationPanel = new Panel();
                separationPanel.Width = 2;
                separationPanel.Height = productCard.Height - 20;
                separationPanel.BackColor = Color.Black;
                separationPanel.Top = 5;
                separationPanel.Left = productImage.Right + 20;
                productCard.Controls.Add(separationPanel);

                productCard.Controls.Add(productImage);
                System.Windows.Forms.Label productNameLabel = new System.Windows.Forms.Label();
                productNameLabel.Text = "Наименование:";
                productNameLabel.TextAlign = ContentAlignment.MiddleRight;
                productNameLabel.Width = productImage.Width - 10;
                productNameLabel.Top = 5;
                productNameLabel.Left = productImage.Right - 10;
                productCard.Controls.Add(productNameLabel);

                System.Windows.Forms.Label productName = new System.Windows.Forms.Label();
                productName.Text = product.ProductName;
                productName.TextAlign = ContentAlignment.MiddleLeft;
                productName.Width = productCard.Width - productImage.Width - 10;
                productName.Top = 5;
                productName.Left = productNameLabel.Right + 10;
                productCard.Controls.Add(productName);

                System.Windows.Forms.Label productDescriptionLabel = new System.Windows.Forms.Label();
                productDescriptionLabel.Text = "Описание:";
                productDescriptionLabel.TextAlign = ContentAlignment.MiddleRight;
                productDescriptionLabel.Width = productImage.Width - 10;
                productDescriptionLabel.Top = productName.Bottom + 15;
                productDescriptionLabel.Left = productImage.Right - 10;
                productCard.Controls.Add(productDescriptionLabel);

                System.Windows.Forms.Label productDescription = new System.Windows.Forms.Label();
                productDescription.Text = product.ProductDescription;
                productDescription.TextAlign = ContentAlignment.MiddleLeft;
                productDescription.MaximumSize = new Size(productCard.Width - productImage.Width - 250, 0);
                productDescription.AutoSize = true;
                productDescription.Top = productDescriptionLabel.Top;
                productDescription.Left = productDescriptionLabel.Right + 10;
                productCard.Controls.Add(productDescription);

                productName.AutoSize = false;
                productName.Height = productDescription.Height;

                System.Windows.Forms.Label productManufacturerLabel = new System.Windows.Forms.Label();
                productManufacturerLabel.Text = "Производитель:";
                productManufacturerLabel.TextAlign = ContentAlignment.MiddleRight;
                productManufacturerLabel.Width = productImage.Width - 10;
                productManufacturerLabel.Top = productDescription.Bottom + 15;
                productManufacturerLabel.Left = productImage.Right - 10;
                productCard.Controls.Add(productManufacturerLabel);

                System.Windows.Forms.Label productManufacturer = new System.Windows.Forms.Label();
                productManufacturer.Text = product.ProductManufacturer;
                productManufacturer.TextAlign = ContentAlignment.MiddleLeft;
                productManufacturer.Width = productCard.Width - productImage.Width - 40;
                productManufacturer.Top = productManufacturerLabel.Top;
                productManufacturer.Left = productNameLabel.Right + 10;
                productCard.Controls.Add(productManufacturer);

                System.Windows.Forms.Label productPriceLabel = new System.Windows.Forms.Label();
                productPriceLabel.Text = "Цена:";
                productPriceLabel.TextAlign = ContentAlignment.MiddleRight;
                productPriceLabel.Width = productImage.Width - 10;
                productPriceLabel.Top = productManufacturer.Bottom + 5;
                productPriceLabel.Left = productImage.Right - 10;
                productCard.Controls.Add(productPriceLabel);

                System.Windows.Forms.Label productPrice = new System.Windows.Forms.Label();
                productPrice.Text = $"{product.ProductCost} руб.";
                productPrice.TextAlign = ContentAlignment.MiddleLeft;
                productPrice.Width = productCard.Width - productImage.Width - 30;
                productPrice.Top = productPriceLabel.Top;
                productPrice.Left = productNameLabel.Right + 10;
                productCard.Controls.Add(productPrice);

                Panel stockPanel = new Panel();
                stockPanel.BackColor = Color.White;
                stockPanel.Width = 70;
                stockPanel.Height = 60;
                stockPanel.BorderStyle = BorderStyle.FixedSingle;
                stockPanel.Top = productNameLabel.Bottom + 25;
                stockPanel.Left = productImage.Right + 550;
                productCard.Controls.Add(stockPanel);
                stockPanel.BringToFront();

                System.Windows.Forms.Label stockLabel = new System.Windows.Forms.Label();
                stockLabel.Text = $"Наличие на складе: {product.ProductQuantityInStock}";
                stockLabel.TextAlign = ContentAlignment.MiddleCenter;
                stockLabel.Width = stockPanel.Width;
                stockLabel.Height = stockPanel.Height;
                stockPanel.Controls.Add(stockLabel);

                System.Windows.Forms.Button infoButton = new System.Windows.Forms.Button();
                infoButton.Text = "Выбрать товар";
                infoButton.Name = "infoButton";
                infoButton.Size = new Size(100, 30);
                infoButton.Location = new Point(productCard.Width - infoButton.Width - 10, productCard.Height - infoButton.Height - 10);
                infoButton.Top = productNameLabel.Bottom + 80;
                infoButton.BackColor = Color.FromArgb(118, 227, 131);
                infoButton.FlatStyle = FlatStyle.Flat;
                infoButton.FlatAppearance.BorderSize = 1;
                infoButton.FlatAppearance.BorderColor = Color.FromArgb(73, 140, 81);
                productCard.Controls.Add(infoButton);
                infoButton.Click += (sender, args) => {
                    LoginForm infoForm = new LoginForm();
                    infoForm.ShowDialog();
                };
                infoButton.BringToFront();
                tableLayoutPanel1.Controls.Add(productCard, row / 1, row % 1);
                row++;

                if (product.ProductQuantityInStock > 0)
                {
                    productCard.BackColor = Color.White;
                }
                else
                {
                    productCard.BackColor = Color.LightGray;
                    stockPanel.BackColor = Color.Red;
                    stockLabel.ForeColor = Color.White;
                    stockLabel.Font = new Font(stockLabel.Font, FontStyle.Bold);
                    infoButton.Enabled = false;
                }
                if (userRole == 2)
                {
                    infoButton.Visible = false;
                }
                else if (userRole == 3)
                {
                    stockPanel.Visible = false;
                    infoButton.Visible = true;
                }
                else
                {
                    stockPanel.Visible = false;
                    infoButton.Visible = false;
                }
            }
        }
        
        private void UpdateProductCards()
        {
            string searchString = textBox1.Text;
            var products = dBEntities.Product
           .Where(p => p.ProductArticleNumber.Contains(searchString) || p.ProductName.Contains(searchString) ||
               p.ProductDescription.Contains(searchString) || p.ProductManufacturer.Contains(searchString) 
               ).ToList();

            products = dBEntities.Product
                .Where(p => (_selectedManufacturer == "Все производители" || p.ProductManufacturer == _selectedManufacturer) &&
                            (searchString == "" ||
                                p.ProductArticleNumber.Contains(searchString) || p.ProductName.Contains(searchString) ||
                                p.ProductDescription.Contains(searchString) || p.ProductManufacturer.Contains(searchString)
                                )).ToList();

            if (_selectedSort == "По возрастанию")
            {
                products = products.OrderBy(p => p.ProductCost).ToList();
            }
            else if (_selectedSort == "По убыванию")
            {
                products = products.OrderByDescending(p => p.ProductCost).ToList();
            }

            int startIndex = (currentPage - 1) * _itemsPerPage;
            int endIndex = startIndex + _itemsPerPage;

            products = products.Skip(startIndex).Take(_itemsPerPage).ToList();
            tableLayoutPanel1.Controls.Clear();
            GenerateCards(tableLayoutPanel1, products, userRole);
            int count = products.Count;
            label3.Text = $"{count} из {_allProducts.Count}";

        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            
            if (currentPage > 1)
            {
                currentPage--;
                UpdateProductCards();
            }
        }

        private void RightBtn_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_allProducts.Count / _itemsPerPage);
            if (currentPage < totalPages)
            {
                currentPage++;
                UpdateProductCards();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
