namespace WINUI
{
    partial class Encryption_and_decryption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encryption_and_decryption));
            this.groupBoxGUID = new System.Windows.Forms.GroupBox();
            this.chkX2 = new System.Windows.Forms.CheckBox();
            this.lblGUIDCount = new System.Windows.Forms.Label();
            this.numericUpDownGUID = new System.Windows.Forms.NumericUpDown();
            this.lblGUID1 = new System.Windows.Forms.Label();
            this.btnGenerateGUID = new System.Windows.Forms.Button();
            this.txtGUID = new System.Windows.Forms.TextBox();
            this.groupBoxMD5 = new System.Windows.Forms.GroupBox();
            this.btnCopyMD5X2 = new System.Windows.Forms.Button();
            this.btnCopyMD5X = new System.Windows.Forms.Button();
            this.btnGenerateMD5 = new System.Windows.Forms.Button();
            this.txtStrForMD5 = new System.Windows.Forms.TextBox();
            this.lblStrForMD5 = new System.Windows.Forms.Label();
            this.txtMD5X2 = new System.Windows.Forms.TextBox();
            this.lblMD5X = new System.Windows.Forms.Label();
            this.txtMD5X = new System.Windows.Forms.TextBox();
            this.lblMD5X2 = new System.Windows.Forms.Label();
            this.groupBoxDES = new System.Windows.Forms.GroupBox();
            this.btnCopyDES = new System.Windows.Forms.Button();
            this.btnCopyStr = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblStr = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtDES = new System.Windows.Forms.TextBox();
            this.lblVI = new System.Windows.Forms.Label();
            this.txtVI = new System.Windows.Forms.TextBox();
            this.lblDES = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.groupBoxGUID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGUID)).BeginInit();
            this.groupBoxMD5.SuspendLayout();
            this.groupBoxDES.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGUID
            // 
            this.groupBoxGUID.Controls.Add(this.chkX2);
            this.groupBoxGUID.Controls.Add(this.lblGUIDCount);
            this.groupBoxGUID.Controls.Add(this.numericUpDownGUID);
            this.groupBoxGUID.Controls.Add(this.lblGUID1);
            this.groupBoxGUID.Controls.Add(this.btnGenerateGUID);
            this.groupBoxGUID.Controls.Add(this.txtGUID);
            this.groupBoxGUID.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGUID.Name = "groupBoxGUID";
            this.groupBoxGUID.Size = new System.Drawing.Size(618, 336);
            this.groupBoxGUID.TabIndex = 1;
            this.groupBoxGUID.TabStop = false;
            this.groupBoxGUID.Text = "生成GUID";
            // 
            // chkX2
            // 
            this.chkX2.AutoSize = true;
            this.chkX2.Checked = true;
            this.chkX2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkX2.Location = new System.Drawing.Point(157, 22);
            this.chkX2.Name = "chkX2";
            this.chkX2.Size = new System.Drawing.Size(86, 18);
            this.chkX2.TabIndex = 8;
            this.chkX2.Text = "去除连字符";
            this.chkX2.UseVisualStyleBackColor = true;
            // 
            // lblGUIDCount
            // 
            this.lblGUIDCount.AutoSize = true;
            this.lblGUIDCount.Location = new System.Drawing.Point(8, 23);
            this.lblGUIDCount.Name = "lblGUIDCount";
            this.lblGUIDCount.Size = new System.Drawing.Size(67, 14);
            this.lblGUIDCount.TabIndex = 7;
            this.lblGUIDCount.Text = "生成数量：";
            // 
            // numericUpDownGUID
            // 
            this.numericUpDownGUID.Location = new System.Drawing.Point(79, 21);
            this.numericUpDownGUID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGUID.Name = "numericUpDownGUID";
            this.numericUpDownGUID.Size = new System.Drawing.Size(57, 22);
            this.numericUpDownGUID.TabIndex = 6;
            this.numericUpDownGUID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGUID1
            // 
            this.lblGUID1.AutoSize = true;
            this.lblGUID1.Location = new System.Drawing.Point(8, 52);
            this.lblGUID1.Name = "lblGUID1";
            this.lblGUID1.Size = new System.Drawing.Size(39, 14);
            this.lblGUID1.TabIndex = 0;
            this.lblGUID1.Text = "GUID:";
            // 
            // btnGenerateGUID
            // 
            this.btnGenerateGUID.Location = new System.Drawing.Point(247, 18);
            this.btnGenerateGUID.Name = "btnGenerateGUID";
            this.btnGenerateGUID.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateGUID.TabIndex = 4;
            this.btnGenerateGUID.Text = "生成GUID";
            this.btnGenerateGUID.UseVisualStyleBackColor = true;
            this.btnGenerateGUID.Click += new System.EventHandler(this.btnGenerateGUID_Click);
            // 
            // txtGUID
            // 
            this.txtGUID.Location = new System.Drawing.Point(6, 67);
            this.txtGUID.Multiline = true;
            this.txtGUID.Name = "txtGUID";
            this.txtGUID.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGUID.Size = new System.Drawing.Size(606, 253);
            this.txtGUID.TabIndex = 1;
            // 
            // groupBoxMD5
            // 
            this.groupBoxMD5.Controls.Add(this.btnCopyMD5X2);
            this.groupBoxMD5.Controls.Add(this.btnCopyMD5X);
            this.groupBoxMD5.Controls.Add(this.btnGenerateMD5);
            this.groupBoxMD5.Controls.Add(this.txtStrForMD5);
            this.groupBoxMD5.Controls.Add(this.lblStrForMD5);
            this.groupBoxMD5.Controls.Add(this.txtMD5X2);
            this.groupBoxMD5.Controls.Add(this.lblMD5X);
            this.groupBoxMD5.Controls.Add(this.txtMD5X);
            this.groupBoxMD5.Controls.Add(this.lblMD5X2);
            this.groupBoxMD5.Location = new System.Drawing.Point(12, 354);
            this.groupBoxMD5.Name = "groupBoxMD5";
            this.groupBoxMD5.Size = new System.Drawing.Size(618, 109);
            this.groupBoxMD5.TabIndex = 2;
            this.groupBoxMD5.TabStop = false;
            this.groupBoxMD5.Text = "MD5";
            // 
            // btnCopyMD5X2
            // 
            this.btnCopyMD5X2.Location = new System.Drawing.Point(537, 72);
            this.btnCopyMD5X2.Name = "btnCopyMD5X2";
            this.btnCopyMD5X2.Size = new System.Drawing.Size(75, 23);
            this.btnCopyMD5X2.TabIndex = 8;
            this.btnCopyMD5X2.Text = "复制";
            this.btnCopyMD5X2.UseVisualStyleBackColor = true;
            this.btnCopyMD5X2.Click += new System.EventHandler(this.btnCopyMD5X2_Click);
            // 
            // btnCopyMD5X
            // 
            this.btnCopyMD5X.Location = new System.Drawing.Point(537, 45);
            this.btnCopyMD5X.Name = "btnCopyMD5X";
            this.btnCopyMD5X.Size = new System.Drawing.Size(75, 23);
            this.btnCopyMD5X.TabIndex = 7;
            this.btnCopyMD5X.Text = "复制";
            this.btnCopyMD5X.UseVisualStyleBackColor = true;
            this.btnCopyMD5X.Click += new System.EventHandler(this.btnCopyMD5X_Click);
            // 
            // btnGenerateMD5
            // 
            this.btnGenerateMD5.Location = new System.Drawing.Point(537, 18);
            this.btnGenerateMD5.Name = "btnGenerateMD5";
            this.btnGenerateMD5.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateMD5.TabIndex = 6;
            this.btnGenerateMD5.Text = "生成MD5";
            this.btnGenerateMD5.UseVisualStyleBackColor = true;
            this.btnGenerateMD5.Click += new System.EventHandler(this.btnGenerateMD5_Click);
            // 
            // txtStrForMD5
            // 
            this.txtStrForMD5.Location = new System.Drawing.Point(67, 20);
            this.txtStrForMD5.Name = "txtStrForMD5";
            this.txtStrForMD5.Size = new System.Drawing.Size(464, 22);
            this.txtStrForMD5.TabIndex = 1;
            // 
            // lblStrForMD5
            // 
            this.lblStrForMD5.AutoSize = true;
            this.lblStrForMD5.Location = new System.Drawing.Point(8, 23);
            this.lblStrForMD5.Name = "lblStrForMD5";
            this.lblStrForMD5.Size = new System.Drawing.Size(55, 14);
            this.lblStrForMD5.TabIndex = 0;
            this.lblStrForMD5.Text = "字符串：";
            // 
            // txtMD5X2
            // 
            this.txtMD5X2.Location = new System.Drawing.Point(67, 74);
            this.txtMD5X2.Name = "txtMD5X2";
            this.txtMD5X2.Size = new System.Drawing.Size(464, 22);
            this.txtMD5X2.TabIndex = 5;
            // 
            // lblMD5X
            // 
            this.lblMD5X.AutoSize = true;
            this.lblMD5X.Location = new System.Drawing.Point(14, 50);
            this.lblMD5X.Name = "lblMD5X";
            this.lblMD5X.Size = new System.Drawing.Size(55, 14);
            this.lblMD5X.TabIndex = 2;
            this.lblMD5X.Text = "MD5值：";
            // 
            // txtMD5X
            // 
            this.txtMD5X.Location = new System.Drawing.Point(67, 47);
            this.txtMD5X.Name = "txtMD5X";
            this.txtMD5X.Size = new System.Drawing.Size(464, 22);
            this.txtMD5X.TabIndex = 3;
            // 
            // lblMD5X2
            // 
            this.lblMD5X2.AutoSize = true;
            this.lblMD5X2.Location = new System.Drawing.Point(14, 77);
            this.lblMD5X2.Name = "lblMD5X2";
            this.lblMD5X2.Size = new System.Drawing.Size(57, 14);
            this.lblMD5X2.TabIndex = 4;
            this.lblMD5X2.Text = "MD5X2：";
            // 
            // groupBoxDES
            // 
            this.groupBoxDES.Controls.Add(this.btnCopyDES);
            this.groupBoxDES.Controls.Add(this.btnCopyStr);
            this.groupBoxDES.Controls.Add(this.btnDecrypt);
            this.groupBoxDES.Controls.Add(this.lblStr);
            this.groupBoxDES.Controls.Add(this.btnEncrypt);
            this.groupBoxDES.Controls.Add(this.lblKey);
            this.groupBoxDES.Controls.Add(this.txtDES);
            this.groupBoxDES.Controls.Add(this.lblVI);
            this.groupBoxDES.Controls.Add(this.txtVI);
            this.groupBoxDES.Controls.Add(this.lblDES);
            this.groupBoxDES.Controls.Add(this.txtKey);
            this.groupBoxDES.Controls.Add(this.txtStr);
            this.groupBoxDES.Location = new System.Drawing.Point(12, 469);
            this.groupBoxDES.Name = "groupBoxDES";
            this.groupBoxDES.Size = new System.Drawing.Size(618, 158);
            this.groupBoxDES.TabIndex = 3;
            this.groupBoxDES.TabStop = false;
            this.groupBoxDES.Text = "DES";
            // 
            // btnCopyDES
            // 
            this.btnCopyDES.Location = new System.Drawing.Point(537, 99);
            this.btnCopyDES.Name = "btnCopyDES";
            this.btnCopyDES.Size = new System.Drawing.Size(75, 23);
            this.btnCopyDES.TabIndex = 11;
            this.btnCopyDES.Text = "复制";
            this.btnCopyDES.UseVisualStyleBackColor = true;
            this.btnCopyDES.Click += new System.EventHandler(this.btnCopyDES_Click);
            // 
            // btnCopyStr
            // 
            this.btnCopyStr.Location = new System.Drawing.Point(537, 18);
            this.btnCopyStr.Name = "btnCopyStr";
            this.btnCopyStr.Size = new System.Drawing.Size(75, 23);
            this.btnCopyStr.TabIndex = 10;
            this.btnCopyStr.Text = "复制";
            this.btnCopyStr.UseVisualStyleBackColor = true;
            this.btnCopyStr.Click += new System.EventHandler(this.btnCopyStr_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(347, 128);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "解密";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(20, 23);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(43, 14);
            this.lblStr.TabIndex = 0;
            this.lblStr.Text = "明文：";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(266, 128);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 8;
            this.btnEncrypt.Text = "加密";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(20, 50);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(43, 14);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "密钥：";
            // 
            // txtDES
            // 
            this.txtDES.Location = new System.Drawing.Point(67, 101);
            this.txtDES.Name = "txtDES";
            this.txtDES.Size = new System.Drawing.Size(464, 22);
            this.txtDES.TabIndex = 7;
            // 
            // lblVI
            // 
            this.lblVI.AutoSize = true;
            this.lblVI.Location = new System.Drawing.Point(20, 77);
            this.lblVI.Name = "lblVI";
            this.lblVI.Size = new System.Drawing.Size(43, 14);
            this.lblVI.TabIndex = 4;
            this.lblVI.Text = "向量：";
            // 
            // txtVI
            // 
            this.txtVI.Location = new System.Drawing.Point(67, 74);
            this.txtVI.Name = "txtVI";
            this.txtVI.Size = new System.Drawing.Size(464, 22);
            this.txtVI.TabIndex = 5;
            // 
            // lblDES
            // 
            this.lblDES.AutoSize = true;
            this.lblDES.Location = new System.Drawing.Point(20, 104);
            this.lblDES.Name = "lblDES";
            this.lblDES.Size = new System.Drawing.Size(43, 14);
            this.lblDES.TabIndex = 6;
            this.lblDES.Text = "密文：";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(67, 47);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(464, 22);
            this.txtKey.TabIndex = 3;
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(67, 20);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(464, 22);
            this.txtStr.TabIndex = 1;
            // 
            // Encryption_and_decryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 636);
            this.Controls.Add(this.groupBoxDES);
            this.Controls.Add(this.groupBoxMD5);
            this.Controls.Add(this.groupBoxGUID);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Encryption_and_decryption.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Encryption_and_decryption";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加密与解密";
            this.groupBoxGUID.ResumeLayout(false);
            this.groupBoxGUID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGUID)).EndInit();
            this.groupBoxMD5.ResumeLayout(false);
            this.groupBoxMD5.PerformLayout();
            this.groupBoxDES.ResumeLayout(false);
            this.groupBoxDES.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGUID;
        private System.Windows.Forms.CheckBox chkX2;
        private System.Windows.Forms.Label lblGUIDCount;
        private System.Windows.Forms.NumericUpDown numericUpDownGUID;
        private System.Windows.Forms.Label lblGUID1;
        private System.Windows.Forms.Button btnGenerateGUID;
        private System.Windows.Forms.TextBox txtGUID;
        private System.Windows.Forms.GroupBox groupBoxMD5;
        private System.Windows.Forms.Button btnCopyMD5X2;
        private System.Windows.Forms.Button btnCopyMD5X;
        private System.Windows.Forms.Button btnGenerateMD5;
        private System.Windows.Forms.TextBox txtStrForMD5;
        private System.Windows.Forms.Label lblStrForMD5;
        private System.Windows.Forms.TextBox txtMD5X2;
        private System.Windows.Forms.Label lblMD5X;
        private System.Windows.Forms.TextBox txtMD5X;
        private System.Windows.Forms.Label lblMD5X2;
        private System.Windows.Forms.GroupBox groupBoxDES;
        private System.Windows.Forms.Button btnCopyDES;
        private System.Windows.Forms.Button btnCopyStr;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtDES;
        private System.Windows.Forms.Label lblVI;
        private System.Windows.Forms.TextBox txtVI;
        private System.Windows.Forms.Label lblDES;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtStr;
    }
}