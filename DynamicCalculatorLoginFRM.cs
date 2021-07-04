using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DynamicCalculator.Presentation.AuthenticationServiceReference;

namespace DynamicCalculator.Presentation
{
    public partial class DynamicCalculatorLoginFRM :Form
    {
        AuthenticationServiceClient client;
        public DynamicCalculatorLoginFRM() {
            InitializeComponent();
            btn_Cancel.Click += (s, e) => Application.Exit();
            btn_Loginn.Click += async (s, e) => await LoginFunAsync();
         

            client = new AuthenticationServiceClient();
        }

        async Task LoginFunAsync() {
            UserRoles userRoles =await client.LogInAsync(txt_UserName.Text.Trim(), txt_Password.Text.Trim());

            switch(userRoles) {
                case UserRoles.Admin:
                case UserRoles.User:
                    new DynamicCalculatorMainFRM(userRoles).Show();
                    this.Hide();
                    break;

                case UserRoles.Denied:
                default:
                    MessageBox.Show("Invalid username or password", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

      

        private async void DynamicCalculatorLoginFRM_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter)
                await LoginFunAsync();
            if(e.KeyCode == Keys.Escape)
                Application.Exit();
        }
    }
}
