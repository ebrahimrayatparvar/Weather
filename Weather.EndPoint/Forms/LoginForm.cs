using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather.EndPoint.Forms
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                dxErrorProvider.SetError(txtUsername, "وارد نمودن نام کاربر الزامی می باشد.");
            }
            else
            {
                dxErrorProvider.SetError(txtUsername, null);
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                dxErrorProvider.SetError(txtPassword, "وارد نمودن گذرواژه الزامی می باشد.");
            }
            else
            {
                dxErrorProvider.SetError(txtPassword, null);
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            navigationFrame.SelectedPage = navigationPageRegister;
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            navigationFrame.SelectedPage = navigationPageLogin;
        }
    }
}
