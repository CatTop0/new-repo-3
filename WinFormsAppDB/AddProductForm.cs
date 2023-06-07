using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDB
{
    public partial class AddProductForm : Form
    {
        BesprozvannykhDBEntities dBEntities = new BesprozvannykhDBEntities();
        private bool isAdd;
        Product _product;
        public AddProductForm(Product product, bool isAdd)
        {

            InitializeComponent();
            this.isAdd = isAdd;
            _product = product;
            if (isAdd)
            {
                RegLabel.Text = "Добавление товара";
            }
            else
            {
                RegLabel.Text = "";
                productArticleNumber.Text = _product.ProductArticleNumber;
                productName.Text = _product.ProductName;
                description.Text = _product.ProductDescription;
                productCategory.Text = _product.ProductCategory;
                productManufacturer.Text = _product.ProductManufacturer;
                productCost.Text = _product.ProductCost.ToString();
                productDiscountAmount.Text = _product.ProductDiscountAmount.ToString();
                productQuantityInStock.Text = _product.ProductQuantityInStock.ToString();
                if (_product.ProductPhoto != null && _product.ProductPhoto.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(Convert.ToInt32(_product.ProductPhoto)))
                    {
                        imgProduct.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    //imgProduct.ImageLocation = "C:\\Users\\ДНС\\source\\repos\\WinFormsAppDB\\images";
                    imgProduct.Image = Properties.Resources.picture;
                }

            }
        }
        private void AddImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                Filter = "Image Files(*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg|All files(*.*)|*.*"
            };
            if (file.ShowDialog() == DialogResult.OK)
            {
                imgProduct.ImageLocation = file.FileName;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productArticleNumber.Text) || string.IsNullOrWhiteSpace(productName.Text) ||
                string.IsNullOrWhiteSpace(description.Text) || string.IsNullOrWhiteSpace(productCategory.Text) ||
                string.IsNullOrWhiteSpace(productManufacturer.Text) || string.IsNullOrWhiteSpace(productCost.Text) ||
                string.IsNullOrWhiteSpace(productDiscountAmount.Text) || string.IsNullOrWhiteSpace(productQuantityInStock.Text) ||
                string.IsNullOrWhiteSpace(productMaxDiscoun.Text) || string.IsNullOrWhiteSpace(productProvider.Text)
                )
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }
            if (!decimal.TryParse(productCost.Text, out decimal cost) || cost < 0)
            {
                MessageBox.Show("Введите корректную стоимость товара.");
                return;
            }
            if (!int.TryParse(productQuantityInStock.Text, out int quantityInStock) || quantityInStock < 0)
            {
                MessageBox.Show("Введите корректное количество товара в наличии.");
                return;
            }

            if (isAdd)
            {
                try 
                { 
                    var newProduct = new Product
                    {
                        ProductArticleNumber = productArticleNumber.Text,
                        ProductName = productName.Text,
                        ProductDescription = description.Text,
                        ProductCategory = productCategory.Text,
                        ProductManufacturer = productManufacturer.Text,
                        ProductCost = Convert.ToDecimal(productCost.Text),
                        ProductDiscountAmount = (byte)Math.Round(Convert.ToDecimal(productDiscountAmount.Text)),
                        ProductQuantityInStock = Convert.ToInt32(productQuantityInStock.Text),
                    };
                    if (dBEntities.Product.Any(p => p.ProductArticleNumber == productArticleNumber.Text))
                    {
                        MessageBox.Show("Продукт с таким артикулом уже существует.");
                        return;
                    }
                    string filePath = imgProduct.ImageLocation;
                    if (string.IsNullOrEmpty(filePath))
                    {
                        newProduct.ProductPhoto = null;
                    }
                    else
                    {
                        string[] imagePaths = File.ReadAllLines(filePath);
                        newProduct.ProductPhoto = imagePaths.ToString();
                    }
                    dBEntities.Product.Add(newProduct);
                    dBEntities.SaveChanges();
                    MessageBox.Show("Товар успешно добавлен!");
                    this.Close();
                    AdminForm adminForm = new AdminForm(null,null,null);
                    adminForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении товара: " + ex.Message);
                }
            }
            else
            {
                _product.ProductArticleNumber = productArticleNumber.Text;
                _product.ProductName = productName.Text;
                _product.ProductDescription = description.Text;
                _product.ProductCategory = productCategory.Text;
                _product.ProductManufacturer = productManufacturer.Text;
                _product.ProductCost = Convert.ToDecimal(productCost.Text);
                _product.ProductDiscountAmount = (byte)Math.Round(Convert.ToDecimal(productDiscountAmount.Text));
                _product.ProductQuantityInStock = Convert.ToInt32(productQuantityInStock.Text);

                string filePath = imgProduct.ImageLocation;
                if (!string.IsNullOrEmpty(filePath))
                {
                    string[] imagePaths = File.ReadAllLines(filePath);
                    _product.ProductPhoto = imagePaths.ToString();

                }
                MessageBox.Show("Изменения успешно сохранены!");
                this.Close();
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
