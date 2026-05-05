using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class FrmFinalBill : Form
    {

        
        private FrmMenu _MenuForm;
        public FrmFinalBill(FrmMenu MenuForm,string Size, string CrustType, string WhereToEat, string Toppings,string TotalPrice)
        {
            InitializeComponent();

           
            _MenuForm = MenuForm;

            LbToppings.Text = Toppings;
            lbPizzaSize.Text = Size;
            lbCrustType.Text = CrustType;
            LbWhereToEat.Text = WhereToEat;
            lbTotalPrice.Text = TotalPrice;

        }

        private void BackToMainScreen_Click(object sender, EventArgs e)
        {
            _MenuForm.Close();
            this.Close();
        }

        private void FrmFinalBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MenuForm.Close();
        }
    }
}
