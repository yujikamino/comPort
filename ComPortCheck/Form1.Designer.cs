namespace ComPortCheck
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
            this.testStartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Judgelabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TRX1judge = new System.Windows.Forms.Label();
            this.TRX2judge = new System.Windows.Forms.Label();
            this.EXT1judge = new System.Windows.Forms.Label();
            this.EXT2judge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testStartButton
            // 
            this.testStartButton.Location = new System.Drawing.Point(12, 207);
            this.testStartButton.Name = "testStartButton";
            this.testStartButton.Size = new System.Drawing.Size(75, 23);
            this.testStartButton.TabIndex = 0;
            this.testStartButton.Text = "開始";
            this.testStartButton.UseVisualStyleBackColor = true;
            this.testStartButton.Click += new System.EventHandler(this.testStartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRX1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "COMポート";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "TRX2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "EXT1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "EXT2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "判定：";
            // 
            // Judgelabel
            // 
            this.Judgelabel.AutoSize = true;
            this.Judgelabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Judgelabel.Location = new System.Drawing.Point(231, 206);
            this.Judgelabel.Name = "Judgelabel";
            this.Judgelabel.Size = new System.Drawing.Size(22, 24);
            this.Judgelabel.TabIndex = 16;
            this.Judgelabel.Text = "-";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(100, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 18;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(100, 120);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 19;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(100, 158);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 20);
            this.comboBox4.TabIndex = 20;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(100, 207);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "閉じる";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "判定";
            // 
            // TRX1judge
            // 
            this.TRX1judge.AutoSize = true;
            this.TRX1judge.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TRX1judge.Location = new System.Drawing.Point(283, 33);
            this.TRX1judge.Name = "TRX1judge";
            this.TRX1judge.Size = new System.Drawing.Size(22, 24);
            this.TRX1judge.TabIndex = 23;
            this.TRX1judge.Text = "-";
            // 
            // TRX2judge
            // 
            this.TRX2judge.AutoSize = true;
            this.TRX2judge.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TRX2judge.Location = new System.Drawing.Point(283, 81);
            this.TRX2judge.Name = "TRX2judge";
            this.TRX2judge.Size = new System.Drawing.Size(22, 24);
            this.TRX2judge.TabIndex = 24;
            this.TRX2judge.Text = "-";
            // 
            // EXT1judge
            // 
            this.EXT1judge.AutoSize = true;
            this.EXT1judge.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EXT1judge.Location = new System.Drawing.Point(283, 122);
            this.EXT1judge.Name = "EXT1judge";
            this.EXT1judge.Size = new System.Drawing.Size(22, 24);
            this.EXT1judge.TabIndex = 25;
            this.EXT1judge.Text = "-";
            // 
            // EXT2judge
            // 
            this.EXT2judge.AutoSize = true;
            this.EXT2judge.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EXT2judge.Location = new System.Drawing.Point(283, 160);
            this.EXT2judge.Name = "EXT2judge";
            this.EXT2judge.Size = new System.Drawing.Size(22, 24);
            this.EXT2judge.TabIndex = 26;
            this.EXT2judge.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 244);
            this.Controls.Add(this.EXT2judge);
            this.Controls.Add(this.EXT1judge);
            this.Controls.Add(this.TRX2judge);
            this.Controls.Add(this.TRX1judge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Judgelabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testStartButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ComPortCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testStartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Judgelabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TRX1judge;
        private System.Windows.Forms.Label TRX2judge;
        private System.Windows.Forms.Label EXT1judge;
        private System.Windows.Forms.Label EXT2judge;
    }
}

