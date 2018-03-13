using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinChitare
{
    public partial class Main : Form
    {
        Inventory inv;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            inv = new Inventory();
            lInfo.Text = "Bine ai venit "+Environment.UserName+"!\n"+
                "Avem " + inv.Chitare.Count + " chitare in magazin!";
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            fSearch fCautare = new fSearch();
            fCautare.Inv = inv;
            fCautare.ShowDialog();
        }
    }
}
