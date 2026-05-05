using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Pizza_Project
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            BtnMenu.BackColor = Color.White;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form FrmMenu = new FrmMenu(this);
            FrmMenu.Show();
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
          
           Application.Exit();
            
        }
    }
}
