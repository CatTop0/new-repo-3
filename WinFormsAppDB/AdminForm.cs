using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppDB
{
    public partial class AdminForm : Form
    {
        //SqlCommand cmd;
        //SqlConnection cn;
        //SqlDataReader dr;
        BesprozvannykhDBEntities entities = new BesprozvannykhDBEntities();
        public AdminForm(string us, string un, string up)
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "besprozvannykhDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.besprozvannykhDataSet.Product);
        }
        private void userExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        bool isAdd;
        private void add_Click(object sender, EventArgs e)
        {
            isAdd = true;
            DataDB.Select();
            DataDB.DataSource = entities.Product.ToList();
            AddProductForm addForm = new AddProductForm(null, isAdd);
            addForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DataDB_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DataDB.Columns[e.ColumnIndex].Name == "ProductPhoto")
            {
                var imageValue = e.Value as Image;
                // Если значение ячейки null или не является изображением, то загружаем картинку-заглушку из ресурсов
                if (imageValue == null || imageValue.Size.IsEmpty)
                {
                    var placeholderImage = Properties.Resources.picture;
                    e.Value = placeholderImage;
                    e.FormattingApplied = true;
                }
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            int rowIndex = DataDB.CurrentCell.RowIndex;
            if (rowIndex > 0) DataDB.Rows.RemoveAt(rowIndex);
            else MessageBox.Show("Выберите строку для удаления", "Ошибка");


            //Получаем значение из указанной колонки
            //string productName = selectedRow.Cells["productNameDataGridViewTextBoxColumn"].Value.ToString();
            //var product = entities.Product.Find(productName); //находим товар в базе
            //if (product != null)
            //{
            //    entities.Product.Remove(product); //удаляем товар
            //    entities.SaveChanges(); //сохраняем изменения
            //}
            //// обновляем таблицу
            //DataDB.DataSource = entities.Product.ToList();

        }
        private void update_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(null, isAdd);
            addProductForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductForm productForm = new ProductForm("Администратор", null, null, 1);
            productForm.Show();
        }
    }
}
