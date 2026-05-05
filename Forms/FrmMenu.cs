using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    
    public partial class FrmMenu : Form
    {
        struct stOrderSummary
        {
            public string Size;
            public string CrustType;
            public string Toppings;
            public string WhereToEat;
        }
        stOrderSummary OrderSummery = new stOrderSummary();

        FrmMainMenu MainForm;
        public FrmMenu(FrmMainMenu F1)
        {
            InitializeComponent();
            
            MainForm = F1;
            MainForm.Visible = false;            
        }
      
        private void BackToMainScreen_Click(object sender, EventArgs e)
        {
            MainForm.Visible = true;
            this.Close();
        }

        float GetSelctedSizePrice()
        {
            if (RbSmallSize.Checked)

                return Convert.ToSingle(RbSmallSize.Tag);

            else if (RbMedSize.Checked)

                return Convert.ToSingle(RbMedSize.Tag);

            else
                return Convert.ToSingle(RbLargeSize.Tag);

        }

        float CalculateToppingsPrice()
        {
            float TotalPrice = 0;

            if(ChkExtraCheese.Checked)
            {
                TotalPrice += Convert.ToSingle(ChkExtraCheese.Tag);
            }

            if(ChkOnion.Checked)
            {
                TotalPrice += Convert.ToSingle(ChkOnion.Tag);
            }

            if(ChkOlive.Checked)
            {
                TotalPrice += Convert.ToSingle(ChkOlive.Tag);
            }

            if(ChkTomatoes.Checked)
            {
                TotalPrice += Convert.ToSingle(ChkTomatoes.Tag);
            }

            if(ChkMashrooms.Checked)
            {
                TotalPrice += Convert.ToSingle(ChkMashrooms.Tag);
            }

            if(ChkGreenPeppers.Checked)
            {
                TotalPrice += Convert.ToSingle(ChkGreenPeppers.Tag);
            }

            return TotalPrice;
        }

        float  GetSelectedCrustPrice()
        {
            if (RbThinCrust.Checked)
            
                return Convert.ToSingle(RbThinCrust.Tag);
            
            else if (RbThickCrust.Checked)

                return Convert.ToSingle(RbThickCrust.Tag);
            else
                return 0;
        }

        float CalculateTotalPrice()
        {
            return GetSelctedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();
        }
        
        void UpdateTotalPrice()
        {

            LbTotalPrice.Text = "$" + CalculateTotalPrice(); 

        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if(RbSmallSize.Checked)
            {
                OrderSummery.Size = "Small";
                return;             
            }

            if(RbMedSize.Checked)
            {
                OrderSummery.Size = "Meduim";
                return;
            }

            if(RbLargeSize.Checked)
            {
                OrderSummery.Size = "Large";
                return;
            }

        }

        private void RbSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        
        private void RbMedSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void RbLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        void UpdateCrustType()
        {
            UpdateTotalPrice();

            if (RbThinCrust.Checked)
            {
                OrderSummery.CrustType = "Thin";
                return;
            }
            else 
                OrderSummery.CrustType = "Thick";
            

        }

        private void RbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void RbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void RbTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        void UpdateWhereToEat()
        {
            if (RbEatIn.Checked)
            
                OrderSummery.WhereToEat = "Eat In";
      
            else
                OrderSummery.WhereToEat = "Take Out";


        }

        private void RbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        
        private void CbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            OrderSummery.Toppings = "";          
            if(ChkExtraCheese.Checked)
            {
                OrderSummery.Toppings += "Extra Cheese\n";
            }

            if(ChkGreenPeppers.Checked)
            {
                OrderSummery.Toppings += "Green Peppers\n";
            }
            
            if(ChkMashrooms.Checked)
            {
                OrderSummery.Toppings += "Mashrooms\n";
            }

            if(ChkOlive.Checked)
            {
                OrderSummery.Toppings += "Olive\n";
            }

            if(ChkOnion.Checked)
            {
                OrderSummery.Toppings += "Onion\n";
            }

            if(ChkTomatoes.Checked)
            {
                OrderSummery.Toppings += "Tomatoes\n";
            }

        }

        private void ChkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void CbGreenPappers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings(); 
        }

        private void CbMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void CbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void CbOlive_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void CbOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        
        void ResetForms()
        {

            //ResetSize
            RbMedSize.Checked = true;

            //ResetCrustType
            RbThinCrust.Checked = true;

            //ResetToppings
            ChkExtraCheese.Checked = false;
            ChkGreenPeppers.Checked = false;
            ChkMashrooms.Checked = false;
            ChkOnion.Checked = false;
            ChkOlive.Checked = false;
            ChkTomatoes.Checked = false;

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetForms();    
        }
       
        
        public void BtnOrder_Click(object sender, EventArgs e)
        {

            Form FinalBill = new FrmFinalBill(this,OrderSummery.Size,OrderSummery.CrustType,OrderSummery.WhereToEat,OrderSummery.Toppings,LbTotalPrice.Text);
            FinalBill.Show();
            
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateCrustType();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Visible = true;
        }
    }
}
