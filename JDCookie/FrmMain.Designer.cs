namespace JDCookie
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.wb = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnGet = new System.Windows.Forms.Button();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.RichTextBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.lbPhone = new System.Windows.Forms.ListBox();
            this.lbTips = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 865);
            this.panel1.TabIndex = 0;
            // 
            // wb
            // 
            this.wb.AllowExternalDrop = true;
            this.wb.CreationProperties = null;
            this.wb.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb.Location = new System.Drawing.Point(0, 0);
            this.wb.Margin = new System.Windows.Forms.Padding(5);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(512, 865);
            this.wb.TabIndex = 0;
            this.wb.ZoomFactor = 1D;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(522, 305);
            this.btnGet.Margin = new System.Windows.Forms.Padding(5);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(502, 70);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "获取Cookie";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // tbPin
            // 
            this.tbPin.Location = new System.Drawing.Point(522, 442);
            this.tbPin.Margin = new System.Windows.Forms.Padding(5);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(502, 34);
            this.tbPin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 395);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "pt_pin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 496);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "pt_key";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(522, 771);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(502, 83);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "重新登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // tbKey
            // 
            this.tbKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKey.Location = new System.Drawing.Point(522, 543);
            this.tbKey.Margin = new System.Windows.Forms.Padding(4);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(502, 208);
            this.tbKey.TabIndex = 4;
            this.tbKey.Text = "";
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(522, 215);
            this.btnFill.Margin = new System.Windows.Forms.Padding(5);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(502, 70);
            this.btnFill.TabIndex = 1;
            this.btnFill.Text = "一键填入";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.BtnFill_Click);
            // 
            // lbPhone
            // 
            this.lbPhone.FormattingEnabled = true;
            this.lbPhone.ItemHeight = 27;
            this.lbPhone.Location = new System.Drawing.Point(527, 12);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(497, 193);
            this.lbPhone.TabIndex = 0;
            // 
            // lbTips
            // 
            this.lbTips.AutoSize = true;
            this.lbTips.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lbTips.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbTips.Location = new System.Drawing.Point(603, 499);
            this.lbTips.Name = "lbTips";
            this.lbTips.Size = new System.Drawing.Size(136, 24);
            this.lbTips.TabIndex = 11;
            this.lbTips.Text = "已复制到剪切板";
            this.lbTips.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1042, 865);
            this.Controls.Add(this.lbTips);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPin);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMain";
            this.Text = "获取JDCookie";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 wb;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RichTextBox tbKey;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.ListBox lbPhone;
        private System.Windows.Forms.Label lbTips;
    }
}

