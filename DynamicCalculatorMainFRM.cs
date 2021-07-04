using System;
using System.Data;
using System.Windows.Forms;
using DynamicCalculator.Presentation.CalculatorServiceReference;
using DynamicCalculator.Presentation.AuthenticationServiceReference;
namespace DynamicCalculator.Presentation
{
    public partial class DynamicCalculatorMainFRM :Form {

        CalculatorClient calculatorClient;
        public DynamicCalculatorMainFRM(UserRoles userRole) {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
            btn_C.Click += (s, e) => txt_Screen.Text = "";


            calculatorClient = new CalculatorClient();

            if(userRole != UserRoles.Admin)
                btn_Division.Visible = btn_Multiplication.Visible = false;
        }
            
        private void PNumber(object sender, EventArgs e) => txt_Screen.Text += ( sender as Button ).Text;
        private async void btn_Equal_Click(object sender, EventArgs e) =>
            txt_Screen.Text = await calculatorClient.CalculatAsStringAsync(txt_Screen.Text.Trim());
        
    }
}
