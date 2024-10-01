namespace WindowsTTS
{
    partial class Mainform
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
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnDoIt = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbLangEn = new System.Windows.Forms.RadioButton();
            this.rbLangKo = new System.Windows.Forms.RadioButton();
            this.rbGenFemale = new System.Windows.Forms.RadioButton();
            this.rbGenMale = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(21, 39);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(739, 199);
            this.tbText.TabIndex = 0;
            this.tbText.Text = "Hello World";
            // 
            // btnDoIt
            // 
            this.btnDoIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDoIt.Location = new System.Drawing.Point(21, 262);
            this.btnDoIt.Name = "btnDoIt";
            this.btnDoIt.Size = new System.Drawing.Size(248, 216);
            this.btnDoIt.TabIndex = 1;
            this.btnDoIt.Text = "SPEAK !!!";
            this.btnDoIt.UseVisualStyleBackColor = true;
            this.btnDoIt.Click += new System.EventHandler(this.btnDoIt_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(631, 262);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 216);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLangKo);
            this.groupBox1.Controls.Add(this.rbLangEn);
            this.groupBox1.Location = new System.Drawing.Point(275, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbGenFemale);
            this.groupBox2.Controls.Add(this.rbGenMale);
            this.groupBox2.Location = new System.Drawing.Point(275, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 103);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // rbLangEn
            // 
            this.rbLangEn.AutoSize = true;
            this.rbLangEn.Checked = true;
            this.rbLangEn.Location = new System.Drawing.Point(32, 45);
            this.rbLangEn.Name = "rbLangEn";
            this.rbLangEn.Size = new System.Drawing.Size(65, 16);
            this.rbLangEn.TabIndex = 0;
            this.rbLangEn.TabStop = true;
            this.rbLangEn.Text = "English";
            this.rbLangEn.UseVisualStyleBackColor = true;
            // 
            // rbLangKo
            // 
            this.rbLangKo.AutoSize = true;
            this.rbLangKo.Location = new System.Drawing.Point(165, 45);
            this.rbLangKo.Name = "rbLangKo";
            this.rbLangKo.Size = new System.Drawing.Size(63, 16);
            this.rbLangKo.TabIndex = 1;
            this.rbLangKo.Text = "Korean";
            this.rbLangKo.UseVisualStyleBackColor = true;
            // 
            // rbGenFemale
            // 
            this.rbGenFemale.AutoSize = true;
            this.rbGenFemale.Checked = true;
            this.rbGenFemale.Location = new System.Drawing.Point(32, 49);
            this.rbGenFemale.Name = "rbGenFemale";
            this.rbGenFemale.Size = new System.Drawing.Size(65, 16);
            this.rbGenFemale.TabIndex = 2;
            this.rbGenFemale.TabStop = true;
            this.rbGenFemale.Text = "Female";
            this.rbGenFemale.UseVisualStyleBackColor = true;
            // 
            // rbGenMale
            // 
            this.rbGenMale.AutoSize = true;
            this.rbGenMale.Location = new System.Drawing.Point(165, 49);
            this.rbGenMale.Name = "rbGenMale";
            this.rbGenMale.Size = new System.Drawing.Size(51, 16);
            this.rbGenMale.TabIndex = 3;
            this.rbGenMale.Text = "Male";
            this.rbGenMale.UseVisualStyleBackColor = true;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDoIt);
            this.Controls.Add(this.tbText);
            this.Name = "Mainform";
            this.Text = "Windows TTS Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnDoIt;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLangKo;
        private System.Windows.Forms.RadioButton rbLangEn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbGenFemale;
        private System.Windows.Forms.RadioButton rbGenMale;
    }
}

