using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Мебельная_фабрика
{
    public partial class Avtorizazciya : Form
    {
        public Avtorizazciya()
        {
            InitializeComponent();
        }

        private void btnAvtorizacziya_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G47GL2B\SQLEXPRESS;Initial Catalog=DE_Anoshina;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Пользователи where Логин= '" + tbLogin.Text.Trim() + "' and Пароль='" + tbParol.Text.Trim() + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemValue = cbRol.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Роль"].ToString() == cmbItemValue)
                    {
                        MessageBox.Show("Вы авторизовались как " + dt.Rows[i][2]);
                        if (cbRol.SelectedIndex == 0)
                        {
                            MessageBox.Show("Добро пожаловать, " + dt.Rows[i][3]);
                        }
                        else
                        {
                            MessageBox.Show("Неверные Логин или Пароль");
                        }    
                    }
                }
            }
            else 
            {
                MessageBox.Show("Неверные Логин или Пароль");
            }
        }
    }
}
