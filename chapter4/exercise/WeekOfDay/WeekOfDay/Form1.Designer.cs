
namespace WeekOfDay
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.labelSeirekiNen = new System.Windows.Forms.Label();
            this.labelTsuki = new System.Windows.Forms.Label();
            this.labelHi = new System.Windows.Forms.Label();
            this.textBoxSeirekiNen = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.labelHantei = new System.Windows.Forms.Label();
            this.buttonYoubiSanshutsu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSeirekiNen
            // 
            this.labelSeirekiNen.AutoSize = true;
            this.labelSeirekiNen.Location = new System.Drawing.Point(16, 16);
            this.labelSeirekiNen.Name = "labelSeirekiNen";
            this.labelSeirekiNen.Size = new System.Drawing.Size(41, 12);
            this.labelSeirekiNen.TabIndex = 0;
            this.labelSeirekiNen.Text = "西暦年";
            // 
            // labelTsuki
            // 
            this.labelTsuki.AutoSize = true;
            this.labelTsuki.Location = new System.Drawing.Point(128, 16);
            this.labelTsuki.Name = "labelTsuki";
            this.labelTsuki.Size = new System.Drawing.Size(17, 12);
            this.labelTsuki.TabIndex = 1;
            this.labelTsuki.Text = "月";
            // 
            // labelHi
            // 
            this.labelHi.AutoSize = true;
            this.labelHi.Location = new System.Drawing.Point(192, 16);
            this.labelHi.Name = "labelHi";
            this.labelHi.Size = new System.Drawing.Size(17, 12);
            this.labelHi.TabIndex = 2;
            this.labelHi.Text = "日";
            // 
            // textBoxSeirekiNen
            // 
            this.textBoxSeirekiNen.Location = new System.Drawing.Point(16, 32);
            this.textBoxSeirekiNen.Name = "textBoxSeirekiNen";
            this.textBoxSeirekiNen.Size = new System.Drawing.Size(100, 19);
            this.textBoxSeirekiNen.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(128, 32);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 19);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(192, 32);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(48, 19);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelHantei
            // 
            this.labelHantei.AutoSize = true;
            this.labelHantei.Location = new System.Drawing.Point(256, 35);
            this.labelHantei.Name = "labelHantei";
            this.labelHantei.Size = new System.Drawing.Size(0, 12);
            this.labelHantei.TabIndex = 6;
            // 
            // buttonYoubiSanshutsu
            // 
            this.buttonYoubiSanshutsu.Location = new System.Drawing.Point(16, 64);
            this.buttonYoubiSanshutsu.Name = "buttonYoubiSanshutsu";
            this.buttonYoubiSanshutsu.Size = new System.Drawing.Size(320, 23);
            this.buttonYoubiSanshutsu.TabIndex = 7;
            this.buttonYoubiSanshutsu.Text = "曜日算出";
            this.buttonYoubiSanshutsu.UseVisualStyleBackColor = true;
            this.buttonYoubiSanshutsu.Click += new System.EventHandler(this.buttonYoubiSanshutsu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 105);
            this.Controls.Add(this.buttonYoubiSanshutsu);
            this.Controls.Add(this.labelHantei);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBoxSeirekiNen);
            this.Controls.Add(this.labelHi);
            this.Controls.Add(this.labelTsuki);
            this.Controls.Add(this.labelSeirekiNen);
            this.Name = "Form1";
            this.Text = "WeekOfDay";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeirekiNen;
        private System.Windows.Forms.Label labelTsuki;
        private System.Windows.Forms.Label labelHi;
        private System.Windows.Forms.TextBox textBoxSeirekiNen;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label labelHantei;
        private System.Windows.Forms.Button buttonYoubiSanshutsu;
    }
}

