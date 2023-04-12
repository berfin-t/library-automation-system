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

namespace LibraryAutomationSystem.Forms
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        
        private void PnlKitaplariListele_Click(object sender, EventArgs e)
        {
            FrmKitapListesi frm = new FrmKitapListesi();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
