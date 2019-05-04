using _01_Weather.Core.User;
using DevExpress.XtraEditors;
using EfRipositpry.User;
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

        private EfUser _obj = new EfUser();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var bl = false;
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                dxErrorProvider.SetError(txtUsername, "وارد نمودن نام کاربر الزامی می باشد.");
                bl = true;
            }
            else
            {
                dxErrorProvider.SetError(txtUsername, null);
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                dxErrorProvider.SetError(txtPassword, "وارد نمودن گذرواژه الزامی می باشد.");
                bl = true;
            }
            else
            {
                dxErrorProvider.SetError(txtPassword, null);
            }

            if (bl) return;

            var obj = new UserEntity
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            if (_obj.IsUser(obj))
            {
                this.Hide();
                var frm = new MainForm();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("چنین نام کاربری در برنامه وجود ندارد.", "خطا در برنامه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            navigationFrame.SelectedPage = navigationPageRegister;
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            var bl = false;
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                dxErrorProvider.SetError(txtName, "وارد نمودن نام الزامی می باشد.");
                bl = true;
            }
            else
            {
                dxErrorProvider.SetError(txtName, null);
            }

            if (string.IsNullOrWhiteSpace(txtFamily.Text))
            {
                dxErrorProvider.SetError(txtFamily, "وارد نمودن نام خانوادگی الزامی می باشد.");
                bl = true;
            }
            else
            {
                dxErrorProvider.SetError(txtFamily, null);
            }

            if (string.IsNullOrWhiteSpace(txtRegisterUsername.Text))
            {
                dxErrorProvider.SetError(txtRegisterUsername, "وارد نمودن نام کاربری الزامی می باشد.");
                bl = true;
            }
            else
            {
                dxErrorProvider.SetError(txtRegisterUsername, null);
            }

            if (string.IsNullOrWhiteSpace(txtRegisterPassword.Text))
            {
                dxErrorProvider.SetError(txtRegisterPassword, "وارد نمودن گذر واژه الزامی می باشد.");
                bl = true;
            }
            else
            {
                dxErrorProvider.SetError(txtRegisterPassword, null);
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                dxErrorProvider.SetError(txtEmail, "وارد نمودن ایمیل الزامی می باشد.");
                bl = true;
            }
            else
            {
                dxErrorProvider.SetError(txtEmail, null);
            }


            if (bl) return;

            var obj = new UserEntity
            {
                Name=txtName.Text,
                family=txtFamily.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Email=txtEmail.Text
            };

            var q = _obj.Register(obj);
            XtraMessageBox.Show("کاربر جدید به درستی درج شد.", "درج با موفقیت",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            navigationFrame.SelectedPage = navigationPageLogin;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            navigationFrame.SelectedPage = navigationPageLogin;
        }
    }
}
