using _01_Weather.Core.User;
using DevExpress.XtraEditors;
using EfRipositpry.User;
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

namespace Weather.EndPoint.Forms
{
    public partial class EditUser : XtraForm
    {
        private EfUser _db = new EfUser();
        private int id;

        #region Constructor form Edit User
        public EditUser()
        {
            InitializeComponent();
        }
        #endregion

        #region Form load from edit user
        private void EditUser_Load(object sender, EventArgs e)
        {
            try
            {
                var result = _db.GetUserInformation(Properties.Settings.Default.UserName);
                foreach (var item in result)
                {
                    id = item.UserId;
                    txtName.Text = item.Name;
                    txtFamily.Text = item.family;
                    txtUserName.Text = item.Username;
                    txtPassword.Text = item.Password;
                    ComboDob.EditValue = item.Bod;
                    txtMobile.Text = item.Mobile;
                    txtEmail.Text = item.Email;
                    txtFavoritesCity.Text = item.FavoritesCity;
                    txtCommand.Text = item.Command;
                }
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message, "خطا در بانک", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "خطا در برنامه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Save button Edit user
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _db.GetUserInformation(Properties.Settings.Default.UserName);

                result[0].Name = txtName.Text;
                result[0].family = txtFamily.Text;
                result[0].Username = txtUserName.Text;
                result[0].Password = txtPassword.Text;
                result[0].Bod = DateTime.Parse(ComboDob.EditValue.ToString());
                result[0].BodPersion = ComboDob.Text;
                result[0].Email = txtEmail.Text;
                result[0].Mobile = txtMobile.Text;
                result[0].Command = txtCommand.Text;
                result[0].FavoritesCity = txtFavoritesCity.Text;
                result[0].UserId = id;
                    
                _db.Edit(result[0]);
                XtraMessageBox.Show("ویرایش کاربر با موفقیت انجام شد.", "ویرایش موفق",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "خطا در برنامه",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Close button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Event textEdit Control for number input
        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}
