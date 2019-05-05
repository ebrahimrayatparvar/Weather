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
        public EditUser()
        {
            InitializeComponent();
        }
        private int id;
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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

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
    }
}
