namespace WINUI
{
    partial class ChangePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePwd));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Confirmpwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Newpwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Oldpwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Confirmpwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Newpwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oldpwd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(179, 176);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(76, 34);
            this.simpleButton2.TabIndex = 23;
            this.simpleButton2.Text = "取  消";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(58, 176);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(71, 34);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "确  认";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Confirmpwd
            // 
            this.Confirmpwd.Location = new System.Drawing.Point(96, 128);
            this.Confirmpwd.Name = "Confirmpwd";
            this.Confirmpwd.Properties.PasswordChar = '*';
            this.Confirmpwd.Size = new System.Drawing.Size(176, 20);
            this.Confirmpwd.TabIndex = 21;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(26, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 17);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "密码确认";
            // 
            // Newpwd
            // 
            this.Newpwd.Location = new System.Drawing.Point(96, 79);
            this.Newpwd.Name = "Newpwd";
            this.Newpwd.Properties.PasswordChar = '*';
            this.Newpwd.Size = new System.Drawing.Size(176, 20);
            this.Newpwd.TabIndex = 19;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(26, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 17);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "新 密 码";
            // 
            // Oldpwd
            // 
            this.Oldpwd.EditValue = "";
            this.Oldpwd.Location = new System.Drawing.Point(96, 30);
            this.Oldpwd.Name = "Oldpwd";
            this.Oldpwd.Properties.PasswordChar = '*';
            this.Oldpwd.Size = new System.Drawing.Size(176, 20);
            this.Oldpwd.TabIndex = 17;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 17);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "旧 密 码";
            // 
            // ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 239);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.Confirmpwd);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.Newpwd);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Oldpwd);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ChangePwd.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePwd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            ((System.ComponentModel.ISupportInitialize)(this.Confirmpwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Newpwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oldpwd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit Confirmpwd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Newpwd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Oldpwd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}