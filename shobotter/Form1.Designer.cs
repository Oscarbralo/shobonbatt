namespace shobotter
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerbatt = new System.Windows.Forms.Timer(this.components);
            this.cbbatt = new System.Windows.Forms.CheckBox();
            this.tbHardName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbHardName = new System.Windows.Forms.CheckBox();
            this.cbBattStatus = new System.Windows.Forms.CheckBox();
            this.cbBattLife = new System.Windows.Forms.CheckBox();
            this.cbPowerLine = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBattStatus = new System.Windows.Forms.Label();
            this.btnReSign = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(663, 529);
            this.webBrowser1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerbatt
            // 
            this.timerbatt.Interval = 10000;
            this.timerbatt.Tick += new System.EventHandler(this.timerbatt_Tick);
            // 
            // cbbatt
            // 
            this.cbbatt.AutoSize = true;
            this.cbbatt.Location = new System.Drawing.Point(358, 283);
            this.cbbatt.Name = "cbbatt";
            this.cbbatt.Size = new System.Drawing.Size(111, 16);
            this.cbbatt.TabIndex = 1;
            this.cbbatt.Text = "バッテリーをつぶやく";
            this.cbbatt.UseVisualStyleBackColor = true;
            this.cbbatt.CheckedChanged += new System.EventHandler(this.cbbatt_CheckedChanged);
            // 
            // tbHardName
            // 
            this.tbHardName.Location = new System.Drawing.Point(63, 6);
            this.tbHardName.MaxLength = 20;
            this.tbHardName.Name = "tbHardName";
            this.tbHardName.Size = new System.Drawing.Size(386, 19);
            this.tbHardName.TabIndex = 2;
            this.tbHardName.Text = "PC";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(463, 259);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbHardName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(455, 233);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "端末設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "端末名 : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbHardName);
            this.tabPage2.Controls.Add(this.cbBattStatus);
            this.tabPage2.Controls.Add(this.cbBattLife);
            this.tabPage2.Controls.Add(this.cbPowerLine);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(455, 233);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "つぶやく内容";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbHardName
            // 
            this.cbHardName.AutoSize = true;
            this.cbHardName.Checked = true;
            this.cbHardName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHardName.Location = new System.Drawing.Point(6, 6);
            this.cbHardName.Name = "cbHardName";
            this.cbHardName.Size = new System.Drawing.Size(60, 16);
            this.cbHardName.TabIndex = 3;
            this.cbHardName.Text = "端末名";
            this.cbHardName.UseVisualStyleBackColor = true;
            // 
            // cbBattStatus
            // 
            this.cbBattStatus.AutoSize = true;
            this.cbBattStatus.Checked = true;
            this.cbBattStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBattStatus.Location = new System.Drawing.Point(6, 72);
            this.cbBattStatus.Name = "cbBattStatus";
            this.cbBattStatus.Size = new System.Drawing.Size(112, 16);
            this.cbBattStatus.TabIndex = 2;
            this.cbBattStatus.Text = "バッテリーステータス";
            this.cbBattStatus.UseVisualStyleBackColor = true;
            // 
            // cbBattLife
            // 
            this.cbBattLife.AutoSize = true;
            this.cbBattLife.Checked = true;
            this.cbBattLife.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBattLife.Location = new System.Drawing.Point(6, 50);
            this.cbBattLife.Name = "cbBattLife";
            this.cbBattLife.Size = new System.Drawing.Size(101, 16);
            this.cbBattLife.TabIndex = 1;
            this.cbBattLife.Text = "バッテリ残り残量";
            this.cbBattLife.UseVisualStyleBackColor = true;
            // 
            // cbPowerLine
            // 
            this.cbPowerLine.AutoSize = true;
            this.cbPowerLine.Checked = true;
            this.cbPowerLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPowerLine.Location = new System.Drawing.Point(6, 28);
            this.cbPowerLine.Name = "cbPowerLine";
            this.cbPowerLine.Size = new System.Drawing.Size(72, 16);
            this.cbPowerLine.TabIndex = 0;
            this.cbPowerLine.Text = "電源接続";
            this.cbPowerLine.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReSign);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.cbbatt);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 308);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設定";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(0, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 203);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "情報";
            this.groupBox2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblBattStatus);
            this.groupBox3.Location = new System.Drawing.Point(6, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 179);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "バッテリ";
            // 
            // lblBattStatus
            // 
            this.lblBattStatus.AutoSize = true;
            this.lblBattStatus.Location = new System.Drawing.Point(10, 25);
            this.lblBattStatus.Name = "lblBattStatus";
            this.lblBattStatus.Size = new System.Drawing.Size(0, 12);
            this.lblBattStatus.TabIndex = 1;
            // 
            // btnReSign
            // 
            this.btnReSign.Location = new System.Drawing.Point(6, 279);
            this.btnReSign.Name = "btnReSign";
            this.btnReSign.Size = new System.Drawing.Size(346, 23);
            this.btnReSign.TabIndex = 4;
            this.btnReSign.Text = "Sign in with Twitter";
            this.btnReSign.UseVisualStyleBackColor = true;
            this.btnReSign.Click += new System.EventHandler(this.btnReSign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 529);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerbatt;
        private System.Windows.Forms.CheckBox cbbatt;
        private System.Windows.Forms.TextBox tbHardName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbPowerLine;
        private System.Windows.Forms.CheckBox cbBattLife;
        private System.Windows.Forms.CheckBox cbBattStatus;
        private System.Windows.Forms.CheckBox cbHardName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblBattStatus;
        private System.Windows.Forms.Button btnReSign;
    }
}

