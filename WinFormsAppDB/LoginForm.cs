using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppDB
{
    public partial class LoginForm : Form
    {
        BesprozvannykhDBEntities entities=new BesprozvannykhDBEntities();
        private string text = String.Empty;
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
            CenterToScreen();

            LoginField.Text = "Введите E-mail";
            LoginField.ForeColor = Color.White;

            PasswordField.Text = "Пароль";
            PasswordField.ForeColor = Color.White;

            capText.Text = "Ввод капчи";
            capText.ForeColor = Color.White;
        }
        Timer timer = new Timer();
        private void LoginForm_Load(object sender, EventArgs e)
        {
            capPicture.Image = this.CreateImage(capPicture.Width, capPicture.Height);
            //cn = new SqlConnection(@"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Besprozvannykh.mdf;integrated security=True");
            cn = new SqlConnection(@"data source=LAPTOP-9SF09P2S\SQLEXPRESS;initial catalog=Besprozvannykh;integrated security=True");
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 10000;
            capPanel.Visible=false;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            auth.Enabled = true;
            timer.Stop();
        }
        private void auth_Click(object sender, EventArgs e)
        {

            if (PasswordField.Text != "" && LoginField.Text != "")
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM [User] WHERE UserLogin = @ul AND UserPassword = @up", cn);
                cmd.Parameters.AddWithValue("@ul", LoginField.Text);
                cmd.Parameters.AddWithValue("@up", PasswordField.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    object urole = dr.GetValue(6);
                    object usurname = dr.GetValue(1);
                    object uname = dr.GetValue(2);
                    object upatronymic = dr.GetValue(3);
                    if (Convert.ToInt32(urole) == 1)
                    {
                        AdminForm adminForm = new AdminForm(usurname.ToString(), uname.ToString(), upatronymic.ToString());
                        adminForm.Show();
                    }
                    else
                    {
                        ProductForm productForm = new ProductForm(usurname.ToString(), uname.ToString(), upatronymic.ToString(), Convert.ToInt32(urole));
                        productForm.Show();
                    }
                    dr.Close();
                    this.Hide();
                    cn.Close();
                }
                else
                { 
                    MessageBox.Show("Пользователя с таким логином и паролем нет. Введите верные данные и captcha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    capPanel.Visible = true;
                    if (capText.Text == this.text && dr.Read())
                        MessageBox.Show("Верно!");
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Ошибка! Блокировка на 10 секунд.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        auth.Enabled = false;
                        timer.Start();
                    }
                    cn.Close();
                    dr.Close();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();
            Bitmap result = new Bitmap(Width, Height);
            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            Brush[] colors = { Brushes.Black,
                     Brushes.Coral,
                     Brushes.RoyalBlue,
                     Brushes.Green, Brushes.Yellow};

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);
            g.Clear(Color.Gray);

            //Генерируем текст
            text = String.Empty;
            string ALF = "1234567890qwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < 4; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Comic Sans MS", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим помехи + линии
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            //Белые точки для шума
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            capPicture.Image = this.CreateImage(capPicture.Width, capPicture.Height);
        }      
        
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите E-mail")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "Введите E-mail";
                LoginField.ForeColor = Color.White;
            }
        }

        private void PasswordField_Enter(object sender, EventArgs e)
        {
            if (PasswordField.Text == "Пароль")
            {
                PasswordField.Text = "";
                PasswordField.ForeColor = Color.Black;
            }
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (PasswordField.Text == "")
            {
                PasswordField.Text = "Пароль";
                PasswordField.ForeColor = Color.White;
            }
        }
        private void capText_Enter(object sender, EventArgs e)
        {
            if (capText.Text == "Ввод капчи")
            {
                capText.Text = "";
                capText.ForeColor = Color.Black;
            }
        }

        private void capText_Leave(object sender, EventArgs e)
        {
            if (capText.Text == "")
            {
                capText.Text = "Ввод капчи";
                capText.ForeColor = Color.White;
            }
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductForm productForm = new ProductForm(null, null, null, 3);
            productForm.Show();
        }
    }
}
