namespace SDM.WinClient
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.UserName = new DevExpress.XtraEditors.TextEdit();
            this.Password = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.LoginButton = new DevExpress.XtraEditors.CheckButton();
            this.Btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(93, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "用户名";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl2.Location = new System.Drawing.Point(93, 115);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 24);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "密码";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(184, 52);
            this.UserName.Name = "UserName";
            this.UserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.UserName.Properties.Appearance.Options.UseFont = true;
            this.UserName.Size = new System.Drawing.Size(186, 24);
            this.UserName.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(184, 112);
            this.Password.Name = "Password";
            this.Password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Password.Properties.Appearance.Options.UseFont = true;
            this.Password.Properties.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(186, 24);
            this.Password.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(83, 174);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(122, 39);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "注册";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(248, 174);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(131, 39);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "登陆";
            this.LoginButton.CheckedChanged += new System.EventHandler(this.LoginButton_CheckedChanged);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.Btn_Close.Location = new System.Drawing.Point(444, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(28, 27);
            this.Btn_Close.TabIndex = 6;
            this.Btn_Close.Text = " ";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(404, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(34, 25);
            this.simpleButton2.TabIndex = 7;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(472, 259);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit UserName;
        private DevExpress.XtraEditors.TextEdit Password;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckButton LoginButton;
        private DevExpress.XtraEditors.SimpleButton Btn_Close;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;



    }
}

