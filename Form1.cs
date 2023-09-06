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

namespace SignupScreen
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void KayitOlButton_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;

            string connectionString = @"Server = DESKTOP - 8JADKKL; Database = Northwind; Trusted_Connection = true; TrustServerCertificate = True; Integrated Security = True";
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                string sql = "INSERT INTO LoginUser (Username, Password, RoleId) VALUES (@Username, @Password, 0)";
                using (SqlCommand komut = new SqlCommand(sql, baglanti))
                {
                    komut.Parameters.AddWithValue("@username", kullaniciadi);
                    komut.Parameters.AddWithValue("@password", sifre);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
        }

        private void GirisYapButton_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;

            string connectionString = @"Server = DESKTOP - 8JADKKL; Database = Northwind; Trusted_Connection = true; TrustServerCertificate = True; Integrated Security = True";
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                string sql = "INSERT INTO LoginUser (Username, Password) VALUES (@Username, @Password)";
                using (SqlCommand komut = new SqlCommand(sql, baglanti))
                {
                    komut.Parameters.AddWithValue("@username", kullaniciadi);
                    komut.Parameters.AddWithValue("@password", sifre);
                    int kayitYapildiMi = (int?)komut.ExecuteScalar() ?? 0;

                    if (kayitYapildiMi == 1)
                    {

                        button3.Visible = true;
                    }
                    else
                    {

                        button3.Visible = false;
                    }

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 15;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 15;
            textBox2.PasswordChar = '*';
        }
    }
}
