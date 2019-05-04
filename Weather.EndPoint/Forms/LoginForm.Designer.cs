namespace Weather.EndPoint.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.formAssistant = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPageRegister = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtRegisterPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtFamily = new DevExpress.XtraEditors.TextEdit();
            this.txtRegisterUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnRegisterUser = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.navigationPageLogin = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.lblUsername = new DevExpress.XtraEditors.LabelControl();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.navigationPageRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisterPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFamily.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisterUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.navigationPageLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.navigationPageRegister);
            this.navigationFrame.Controls.Add(this.navigationPageLogin);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageRegister,
            this.navigationPageLogin});
            this.navigationFrame.SelectedPage = this.navigationPageLogin;
            this.navigationFrame.Size = new System.Drawing.Size(436, 440);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame1";
            // 
            // navigationPageRegister
            // 
            this.navigationPageRegister.Controls.Add(this.txtEmail);
            this.navigationPageRegister.Controls.Add(this.labelControl7);
            this.navigationPageRegister.Controls.Add(this.txtRegisterPassword);
            this.navigationPageRegister.Controls.Add(this.labelControl6);
            this.navigationPageRegister.Controls.Add(this.txtFamily);
            this.navigationPageRegister.Controls.Add(this.txtRegisterUsername);
            this.navigationPageRegister.Controls.Add(this.labelControl2);
            this.navigationPageRegister.Controls.Add(this.labelControl5);
            this.navigationPageRegister.Controls.Add(this.txtName);
            this.navigationPageRegister.Controls.Add(this.labelControl3);
            this.navigationPageRegister.Controls.Add(this.btnRegisterUser);
            this.navigationPageRegister.Controls.Add(this.btnCancel);
            this.navigationPageRegister.Controls.Add(this.panelControl2);
            this.navigationPageRegister.Name = "navigationPageRegister";
            this.navigationPageRegister.Size = new System.Drawing.Size(436, 440);
            // 
            // txtEmail
            // 
            this.txtEmail.EditValue = "";
            this.txtEmail.Location = new System.Drawing.Point(34, 267);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Parmida_ActivePlusMultiKeys = false;
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEmail.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtEmail.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtEmail.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtEmail.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtEmail.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtEmail.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtEmail.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtEmail.Size = new System.Drawing.Size(269, 36);
            this.txtEmail.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Location = new System.Drawing.Point(364, 268);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 33);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "ایمیل";
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.EditValue = "";
            this.txtRegisterPassword.Location = new System.Drawing.Point(34, 225);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Parmida_ActivePlusMultiKeys = false;
            this.txtRegisterPassword.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRegisterPassword.Properties.Appearance.Options.UseFont = true;
            this.txtRegisterPassword.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRegisterPassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtRegisterPassword.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtRegisterPassword.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtRegisterPassword.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtRegisterPassword.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtRegisterPassword.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtRegisterPassword.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtRegisterPassword.Properties.PasswordChar = '*';
            this.txtRegisterPassword.Size = new System.Drawing.Size(269, 36);
            this.txtRegisterPassword.TabIndex = 8;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Location = new System.Drawing.Point(342, 226);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(61, 33);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "گذر واژه";
            // 
            // txtFamily
            // 
            this.txtFamily.EditValue = "";
            this.txtFamily.Location = new System.Drawing.Point(34, 144);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Parmida_ActivePlusMultiKeys = false;
            this.txtFamily.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFamily.Properties.Appearance.Options.UseFont = true;
            this.txtFamily.Properties.Appearance.Options.UseTextOptions = true;
            this.txtFamily.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtFamily.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtFamily.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtFamily.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtFamily.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtFamily.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtFamily.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtFamily.Size = new System.Drawing.Size(269, 36);
            this.txtFamily.TabIndex = 8;
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.EditValue = "";
            this.txtRegisterUsername.Location = new System.Drawing.Point(34, 183);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Parmida_ActivePlusMultiKeys = false;
            this.txtRegisterUsername.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRegisterUsername.Properties.Appearance.Options.UseFont = true;
            this.txtRegisterUsername.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRegisterUsername.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtRegisterUsername.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtRegisterUsername.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtRegisterUsername.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtRegisterUsername.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtRegisterUsername.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtRegisterUsername.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtRegisterUsername.Size = new System.Drawing.Size(269, 36);
            this.txtRegisterUsername.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(312, 145);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 33);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "نام خانوادگی";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Location = new System.Drawing.Point(328, 184);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 33);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "نام کاربری";
            // 
            // txtName
            // 
            this.txtName.EditValue = "";
            this.txtName.Location = new System.Drawing.Point(34, 102);
            this.txtName.Name = "txtName";
            this.txtName.Parmida_ActivePlusMultiKeys = false;
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.Appearance.Options.UseTextOptions = true;
            this.txtName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtName.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtName.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtName.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtName.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtName.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtName.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtName.Size = new System.Drawing.Size(269, 36);
            this.txtName.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Location = new System.Drawing.Point(383, 105);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 33);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "نام";
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRegisterUser.Appearance.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRegisterUser.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRegisterUser.Appearance.Options.UseBackColor = true;
            this.btnRegisterUser.Appearance.Options.UseFont = true;
            this.btnRegisterUser.Appearance.Options.UseForeColor = true;
            this.btnRegisterUser.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.btnRegisterUser.AppearanceHovered.Options.UseBackColor = true;
            this.btnRegisterUser.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.btnRegisterUser.AppearancePressed.Options.UseBackColor = true;
            this.btnRegisterUser.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnRegisterUser.Location = new System.Drawing.Point(34, 322);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(269, 40);
            this.btnRegisterUser.TabIndex = 6;
            this.btnRegisterUser.Text = "ثبت نام";
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Appearance.Options.UseForeColor = true;
            this.btnCancel.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.btnCancel.AppearanceHovered.Options.UseBackColor = true;
            this.btnCancel.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.btnCancel.AppearancePressed.Options.UseBackColor = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnCancel.Location = new System.Drawing.Point(34, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(269, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Location = new System.Drawing.Point(3, 22);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(436, 56);
            this.panelControl2.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Location = new System.Drawing.Point(183, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 42);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "ثبت نام";
            // 
            // navigationPageLogin
            // 
            this.navigationPageLogin.Controls.Add(this.txtPassword);
            this.navigationPageLogin.Controls.Add(this.lblPassword);
            this.navigationPageLogin.Controls.Add(this.txtUsername);
            this.navigationPageLogin.Controls.Add(this.lblUsername);
            this.navigationPageLogin.Controls.Add(this.btnRegister);
            this.navigationPageLogin.Controls.Add(this.btnLogin);
            this.navigationPageLogin.Controls.Add(this.panelControl1);
            this.navigationPageLogin.Name = "navigationPageLogin";
            this.navigationPageLogin.Size = new System.Drawing.Size(436, 440);
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.Location = new System.Drawing.Point(53, 205);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Parmida_ActivePlusMultiKeys = false;
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPassword.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtPassword.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPassword.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtPassword.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPassword.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtPassword.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(269, 36);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPassword.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(347, 206);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 33);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "گذر واژه";
            // 
            // txtUsername
            // 
            this.txtUsername.EditValue = "";
            this.txtUsername.Location = new System.Drawing.Point(53, 163);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Parmida_ActivePlusMultiKeys = false;
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Properties.Appearance.Options.UseTextOptions = true;
            this.txtUsername.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtUsername.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtUsername.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtUsername.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtUsername.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtUsername.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtUsername.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtUsername.Size = new System.Drawing.Size(269, 36);
            this.txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.Appearance.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUsername.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(347, 164);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 33);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "نام کاربر";
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRegister.Appearance.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRegister.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Appearance.Options.UseBackColor = true;
            this.btnRegister.Appearance.Options.UseFont = true;
            this.btnRegister.Appearance.Options.UseForeColor = true;
            this.btnRegister.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.btnRegister.AppearanceHovered.Options.UseBackColor = true;
            this.btnRegister.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.btnRegister.AppearancePressed.Options.UseBackColor = true;
            this.btnRegister.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnRegister.Location = new System.Drawing.Point(53, 309);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(269, 40);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "ثبت نام";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLogin.Appearance.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnLogin.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Appearance.Options.UseForeColor = true;
            this.btnLogin.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.btnLogin.AppearanceHovered.Options.UseBackColor = true;
            this.btnLogin.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.btnLogin.AppearancePressed.Options.UseBackColor = true;
            this.btnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLogin.Location = new System.Drawing.Point(53, 263);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(269, 40);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "ورود";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(0, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(436, 56);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(159, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(118, 42);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ورود به برنامه";
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 440);
            this.Controls.Add(this.navigationFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.navigationPageRegister.ResumeLayout(false);
            this.navigationPageRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisterPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFamily.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisterUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.navigationPageLogin.ResumeLayout(false);
            this.navigationPageLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageRegister;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageLogin;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl lblUsername;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.TextEdit txtFamily;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnRegisterUser;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtRegisterPassword;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtRegisterUsername;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}

