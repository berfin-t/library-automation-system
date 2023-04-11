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

namespace LibraryAutomationSystem.Forms
{
    public partial class FrmLoginScreen : Form
    {
        public FrmLoginScreen()
        {
            InitializeComponent();
        }
        // Data Source=DESKTOP-NBHVRA9\SQLEXPRESS;Initial Catalog=DbLibrarySystem;Integrated Security=True
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NBHVRA9\SQLEXPRESS;Initial Catalog=DbLibrarySystem;Integrated Security=True");

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From TblKullanici Where Mail=@p1 and Sifre=@p2", conn);
            cmd.Parameters.AddWithValue("@p1", TxtMail.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                FrmAnaSayfa frm = new FrmAnaSayfa();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mail ya da şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LLSifremiUnuttm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şifreni hatırla!","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
