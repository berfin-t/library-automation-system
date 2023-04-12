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
using LibraryAutomationSystem.Entity;

namespace LibraryAutomationSystem.Forms
{
    public partial class FrmKitapListesi : Form
    {
        public FrmKitapListesi()
        {
            InitializeComponent();
        }
        DbLibrarySystemEntities db = new DbLibrarySystemEntities();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NBHVRA9\SQLEXPRESS;Initial Catalog=DbLibrarySystem;Integrated Security=True");

        private void FrmKitapListesi_Load(object sender, EventArgs e)
        {
            var kitaplistesi = from x in db.TblKitaplar
                           select new
                           {
                               x.KitapID,
                               x.KitapAd,
                               x.Yazar,
                               x.Yayinevi,
                               x.ISBN,
                               x.SayfaSayisi,
                               x.TblKategoriler.KategoriAd
                           };
            dataGridView1.DataSource = kitaplistesi.ToList();
        }
    }
}
