
namespace GradeCheck
{
    partial class FormGrade
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
            this.labelKamoku = new System.Windows.Forms.Label();
            this.labelShussekiRitsu = new System.Windows.Forms.Label();
            this.labelTokuten = new System.Windows.Forms.Label();
            this.labelHanteiKekka = new System.Windows.Forms.Label();
            this.labelHeikinten = new System.Windows.Forms.Label();
            this.labelSugaku = new System.Windows.Forms.Label();
            this.labelButsuri = new System.Windows.Forms.Label();
            this.labelEigo = new System.Windows.Forms.Label();
            this.textBoxAttendanceM = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceP = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceE = new System.Windows.Forms.TextBox();
            this.labelPercent1 = new System.Windows.Forms.Label();
            this.labelPercent2 = new System.Windows.Forms.Label();
            this.labelPercent3 = new System.Windows.Forms.Label();
            this.textBoxScoreE = new System.Windows.Forms.TextBox();
            this.textBoxScoreP = new System.Windows.Forms.TextBox();
            this.textBoxScoreM = new System.Windows.Forms.TextBox();
            this.labelResultM = new System.Windows.Forms.Label();
            this.labelResultP = new System.Windows.Forms.Label();
            this.labelResultE = new System.Windows.Forms.Label();
            this.labelCompAvgE = new System.Windows.Forms.Label();
            this.labelCompAvgP = new System.Windows.Forms.Label();
            this.labelCompAvgM = new System.Windows.Forms.Label();
            this.buttonJudge = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKamoku
            // 
            this.labelKamoku.AutoSize = true;
            this.labelKamoku.Location = new System.Drawing.Point(16, 16);
            this.labelKamoku.Name = "labelKamoku";
            this.labelKamoku.Size = new System.Drawing.Size(29, 12);
            this.labelKamoku.TabIndex = 0;
            this.labelKamoku.Text = "科目";
            // 
            // labelShussekiRitsu
            // 
            this.labelShussekiRitsu.AutoSize = true;
            this.labelShussekiRitsu.Location = new System.Drawing.Point(64, 16);
            this.labelShussekiRitsu.Name = "labelShussekiRitsu";
            this.labelShussekiRitsu.Size = new System.Drawing.Size(41, 12);
            this.labelShussekiRitsu.TabIndex = 1;
            this.labelShussekiRitsu.Text = "出席率";
            // 
            // labelTokuten
            // 
            this.labelTokuten.AutoSize = true;
            this.labelTokuten.Location = new System.Drawing.Point(208, 16);
            this.labelTokuten.Name = "labelTokuten";
            this.labelTokuten.Size = new System.Drawing.Size(29, 12);
            this.labelTokuten.TabIndex = 2;
            this.labelTokuten.Text = "得点";
            // 
            // labelHanteiKekka
            // 
            this.labelHanteiKekka.AutoSize = true;
            this.labelHanteiKekka.Location = new System.Drawing.Point(336, 16);
            this.labelHanteiKekka.Name = "labelHanteiKekka";
            this.labelHanteiKekka.Size = new System.Drawing.Size(53, 12);
            this.labelHanteiKekka.TabIndex = 3;
            this.labelHanteiKekka.Text = "判定結果";
            // 
            // labelHeikinten
            // 
            this.labelHeikinten.AutoSize = true;
            this.labelHeikinten.Location = new System.Drawing.Point(400, 16);
            this.labelHeikinten.Name = "labelHeikinten";
            this.labelHeikinten.Size = new System.Drawing.Size(73, 12);
            this.labelHeikinten.TabIndex = 4;
            this.labelHeikinten.Text = "平均点と比較";
            // 
            // labelSugaku
            // 
            this.labelSugaku.AutoSize = true;
            this.labelSugaku.Location = new System.Drawing.Point(16, 48);
            this.labelSugaku.Name = "labelSugaku";
            this.labelSugaku.Size = new System.Drawing.Size(29, 12);
            this.labelSugaku.TabIndex = 5;
            this.labelSugaku.Text = "数学";
            // 
            // labelButsuri
            // 
            this.labelButsuri.AutoSize = true;
            this.labelButsuri.Location = new System.Drawing.Point(16, 80);
            this.labelButsuri.Name = "labelButsuri";
            this.labelButsuri.Size = new System.Drawing.Size(29, 12);
            this.labelButsuri.TabIndex = 6;
            this.labelButsuri.Text = "物理";
            // 
            // labelEigo
            // 
            this.labelEigo.AutoSize = true;
            this.labelEigo.Location = new System.Drawing.Point(16, 112);
            this.labelEigo.Name = "labelEigo";
            this.labelEigo.Size = new System.Drawing.Size(29, 12);
            this.labelEigo.TabIndex = 7;
            this.labelEigo.Text = "英語";
            // 
            // textBoxAttendanceM
            // 
            this.textBoxAttendanceM.Location = new System.Drawing.Point(64, 45);
            this.textBoxAttendanceM.Name = "textBoxAttendanceM";
            this.textBoxAttendanceM.Size = new System.Drawing.Size(100, 19);
            this.textBoxAttendanceM.TabIndex = 8;
            this.textBoxAttendanceM.Text = "0.0";
            this.textBoxAttendanceM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAttendanceP
            // 
            this.textBoxAttendanceP.Location = new System.Drawing.Point(64, 77);
            this.textBoxAttendanceP.Name = "textBoxAttendanceP";
            this.textBoxAttendanceP.Size = new System.Drawing.Size(100, 19);
            this.textBoxAttendanceP.TabIndex = 9;
            this.textBoxAttendanceP.Text = "0.0";
            this.textBoxAttendanceP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAttendanceE
            // 
            this.textBoxAttendanceE.Location = new System.Drawing.Point(64, 109);
            this.textBoxAttendanceE.Name = "textBoxAttendanceE";
            this.textBoxAttendanceE.Size = new System.Drawing.Size(100, 19);
            this.textBoxAttendanceE.TabIndex = 10;
            this.textBoxAttendanceE.Text = "0.0";
            this.textBoxAttendanceE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPercent1
            // 
            this.labelPercent1.AutoSize = true;
            this.labelPercent1.Location = new System.Drawing.Point(176, 48);
            this.labelPercent1.Name = "labelPercent1";
            this.labelPercent1.Size = new System.Drawing.Size(17, 12);
            this.labelPercent1.TabIndex = 11;
            this.labelPercent1.Text = "％";
            // 
            // labelPercent2
            // 
            this.labelPercent2.AutoSize = true;
            this.labelPercent2.Location = new System.Drawing.Point(176, 80);
            this.labelPercent2.Name = "labelPercent2";
            this.labelPercent2.Size = new System.Drawing.Size(17, 12);
            this.labelPercent2.TabIndex = 12;
            this.labelPercent2.Text = "％";
            // 
            // labelPercent3
            // 
            this.labelPercent3.AutoSize = true;
            this.labelPercent3.Location = new System.Drawing.Point(176, 112);
            this.labelPercent3.Name = "labelPercent3";
            this.labelPercent3.Size = new System.Drawing.Size(17, 12);
            this.labelPercent3.TabIndex = 13;
            this.labelPercent3.Text = "％";
            // 
            // textBoxScoreE
            // 
            this.textBoxScoreE.Location = new System.Drawing.Point(208, 109);
            this.textBoxScoreE.Name = "textBoxScoreE";
            this.textBoxScoreE.Size = new System.Drawing.Size(100, 19);
            this.textBoxScoreE.TabIndex = 16;
            this.textBoxScoreE.Text = "0";
            this.textBoxScoreE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxScoreP
            // 
            this.textBoxScoreP.Location = new System.Drawing.Point(208, 77);
            this.textBoxScoreP.Name = "textBoxScoreP";
            this.textBoxScoreP.Size = new System.Drawing.Size(100, 19);
            this.textBoxScoreP.TabIndex = 15;
            this.textBoxScoreP.Text = "0";
            this.textBoxScoreP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxScoreM
            // 
            this.textBoxScoreM.Location = new System.Drawing.Point(208, 45);
            this.textBoxScoreM.Name = "textBoxScoreM";
            this.textBoxScoreM.Size = new System.Drawing.Size(100, 19);
            this.textBoxScoreM.TabIndex = 14;
            this.textBoxScoreM.Text = "0";
            this.textBoxScoreM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelResultM
            // 
            this.labelResultM.AutoSize = true;
            this.labelResultM.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResultM.Location = new System.Drawing.Point(336, 46);
            this.labelResultM.Name = "labelResultM";
            this.labelResultM.Size = new System.Drawing.Size(42, 16);
            this.labelResultM.TabIndex = 17;
            this.labelResultM.Text = "合格";
            // 
            // labelResultP
            // 
            this.labelResultP.AutoSize = true;
            this.labelResultP.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResultP.Location = new System.Drawing.Point(336, 78);
            this.labelResultP.Name = "labelResultP";
            this.labelResultP.Size = new System.Drawing.Size(42, 16);
            this.labelResultP.TabIndex = 18;
            this.labelResultP.Text = "合格";
            // 
            // labelResultE
            // 
            this.labelResultE.AutoSize = true;
            this.labelResultE.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResultE.Location = new System.Drawing.Point(336, 110);
            this.labelResultE.Name = "labelResultE";
            this.labelResultE.Size = new System.Drawing.Size(42, 16);
            this.labelResultE.TabIndex = 19;
            this.labelResultE.Text = "合格";
            // 
            // labelCompAvgE
            // 
            this.labelCompAvgE.AutoSize = true;
            this.labelCompAvgE.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompAvgE.Location = new System.Drawing.Point(400, 110);
            this.labelCompAvgE.Name = "labelCompAvgE";
            this.labelCompAvgE.Size = new System.Drawing.Size(93, 16);
            this.labelCompAvgE.TabIndex = 22;
            this.labelCompAvgE.Text = "平均点以上";
            // 
            // labelCompAvgP
            // 
            this.labelCompAvgP.AutoSize = true;
            this.labelCompAvgP.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompAvgP.Location = new System.Drawing.Point(400, 78);
            this.labelCompAvgP.Name = "labelCompAvgP";
            this.labelCompAvgP.Size = new System.Drawing.Size(93, 16);
            this.labelCompAvgP.TabIndex = 21;
            this.labelCompAvgP.Text = "平均点以上";
            // 
            // labelCompAvgM
            // 
            this.labelCompAvgM.AutoSize = true;
            this.labelCompAvgM.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompAvgM.Location = new System.Drawing.Point(400, 46);
            this.labelCompAvgM.Name = "labelCompAvgM";
            this.labelCompAvgM.Size = new System.Drawing.Size(93, 16);
            this.labelCompAvgM.TabIndex = 20;
            this.labelCompAvgM.Text = "平均点以上";
            // 
            // buttonJudge
            // 
            this.buttonJudge.Location = new System.Drawing.Point(171, 144);
            this.buttonJudge.Name = "buttonJudge";
            this.buttonJudge.Size = new System.Drawing.Size(75, 23);
            this.buttonJudge.TabIndex = 23;
            this.buttonJudge.Text = "判定";
            this.buttonJudge.UseVisualStyleBackColor = true;
            this.buttonJudge.Click += new System.EventHandler(this.buttonJudge_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(267, 144);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 24;
            this.buttonReset.Text = "リセット";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // FormGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 177);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonJudge);
            this.Controls.Add(this.labelCompAvgE);
            this.Controls.Add(this.labelCompAvgP);
            this.Controls.Add(this.labelCompAvgM);
            this.Controls.Add(this.labelResultE);
            this.Controls.Add(this.labelResultP);
            this.Controls.Add(this.labelResultM);
            this.Controls.Add(this.textBoxScoreE);
            this.Controls.Add(this.textBoxScoreP);
            this.Controls.Add(this.textBoxScoreM);
            this.Controls.Add(this.labelPercent3);
            this.Controls.Add(this.labelPercent2);
            this.Controls.Add(this.labelPercent1);
            this.Controls.Add(this.textBoxAttendanceE);
            this.Controls.Add(this.textBoxAttendanceP);
            this.Controls.Add(this.textBoxAttendanceM);
            this.Controls.Add(this.labelEigo);
            this.Controls.Add(this.labelButsuri);
            this.Controls.Add(this.labelSugaku);
            this.Controls.Add(this.labelHeikinten);
            this.Controls.Add(this.labelHanteiKekka);
            this.Controls.Add(this.labelTokuten);
            this.Controls.Add(this.labelShussekiRitsu);
            this.Controls.Add(this.labelKamoku);
            this.Name = "FormGrade";
            this.Text = "成績判定";
            this.Load += new System.EventHandler(this.FormGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKamoku;
        private System.Windows.Forms.Label labelShussekiRitsu;
        private System.Windows.Forms.Label labelTokuten;
        private System.Windows.Forms.Label labelHanteiKekka;
        private System.Windows.Forms.Label labelHeikinten;
        private System.Windows.Forms.Label labelSugaku;
        private System.Windows.Forms.Label labelButsuri;
        private System.Windows.Forms.Label labelEigo;
        private System.Windows.Forms.TextBox textBoxAttendanceM;
        private System.Windows.Forms.TextBox textBoxAttendanceP;
        private System.Windows.Forms.TextBox textBoxAttendanceE;
        private System.Windows.Forms.Label labelPercent1;
        private System.Windows.Forms.Label labelPercent2;
        private System.Windows.Forms.Label labelPercent3;
        private System.Windows.Forms.TextBox textBoxScoreE;
        private System.Windows.Forms.TextBox textBoxScoreP;
        private System.Windows.Forms.TextBox textBoxScoreM;
        private System.Windows.Forms.Label labelResultM;
        private System.Windows.Forms.Label labelResultP;
        private System.Windows.Forms.Label labelResultE;
        private System.Windows.Forms.Label labelCompAvgE;
        private System.Windows.Forms.Label labelCompAvgP;
        private System.Windows.Forms.Label labelCompAvgM;
        private System.Windows.Forms.Button buttonJudge;
        private System.Windows.Forms.Button buttonReset;
    }
}

