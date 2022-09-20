namespace WINUI
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.注册 = new DevExpress.XtraEditors.SimpleButton();
            this.用户名 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.密码 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.用户名.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.密码.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkEdit2);
            this.groupBox1.Controls.Add(this.checkEdit1);
            this.groupBox1.Controls.Add(this.注册);
            this.groupBox1.Controls.Add(this.用户名);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.密码);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.textEdit3);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 276);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户登录";
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(183, 197);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "自动登录";
            this.checkEdit2.Size = new System.Drawing.Size(96, 20);
            this.checkEdit2.TabIndex = 13;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(67, 197);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "记住密码";
            this.checkEdit1.Size = new System.Drawing.Size(96, 20);
            this.checkEdit1.TabIndex = 12;
            // 
            // 注册
            // 
            this.注册.Location = new System.Drawing.Point(124, 232);
            this.注册.Name = "注册";
            this.注册.Size = new System.Drawing.Size(75, 23);
            this.注册.TabIndex = 11;
            this.注册.Text = "注册";
            this.注册.Click += new System.EventHandler(this.注册_Click);
            // 
            // 用户名
            // 
            this.用户名.EditValue = "";
            this.用户名.Location = new System.Drawing.Point(124, 106);
            this.用户名.Name = "用户名";
            this.用户名.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.用户名.Size = new System.Drawing.Size(166, 20);
            this.用户名.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(22, 232);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "登录";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 166);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 14);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "密       码：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 14);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "用  户  名：";
            // 
            // 密码
            // 
            this.密码.EditValue = "";
            this.密码.Location = new System.Drawing.Point(124, 160);
            this.密码.Name = "密码";
            this.密码.Properties.PasswordChar = '*';
            this.密码.Size = new System.Drawing.Size(166, 20);
            this.密码.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "服务器地址：";
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(235, 232);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "取消";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "10.200.122.183";
            this.textEdit3.Enabled = false;
            this.textEdit3.Location = new System.Drawing.Point(124, 47);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(166, 20);
            this.textEdit3.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 300);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmLogin.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录窗体";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.用户名.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.密码.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton 注册;
        private DevExpress.XtraEditors.ComboBoxEdit 用户名;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit 密码;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        public DevExpress.XtraEditors.CheckEdit checkEdit2;
    }
}