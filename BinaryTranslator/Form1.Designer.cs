namespace BinaryTranslator
{
    partial class Form1
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
            this.btn_engtobin = new System.Windows.Forms.Button();
            this.btn_bintoeng = new System.Windows.Forms.Button();
            this.lbl_englishInput = new System.Windows.Forms.Label();
            this.lbl_binInput = new System.Windows.Forms.Label();
            this.rtb_binText = new System.Windows.Forms.RichTextBox();
            this.rtbEngText = new System.Windows.Forms.RichTextBox();
            this.lblVerNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_engtobin
            // 
            this.btn_engtobin.Location = new System.Drawing.Point(460, 113);
            this.btn_engtobin.Name = "btn_engtobin";
            this.btn_engtobin.Size = new System.Drawing.Size(118, 36);
            this.btn_engtobin.TabIndex = 0;
            this.btn_engtobin.Text = "English --> Binary";
            this.btn_engtobin.UseVisualStyleBackColor = true;
            this.btn_engtobin.Click += new System.EventHandler(this.btn_engtobin_Click);
            // 
            // btn_bintoeng
            // 
            this.btn_bintoeng.Location = new System.Drawing.Point(460, 305);
            this.btn_bintoeng.Name = "btn_bintoeng";
            this.btn_bintoeng.Size = new System.Drawing.Size(117, 35);
            this.btn_bintoeng.TabIndex = 1;
            this.btn_bintoeng.Text = "Binary --> English";
            this.btn_bintoeng.UseVisualStyleBackColor = true;
            // 
            // lbl_englishInput
            // 
            this.lbl_englishInput.AutoSize = true;
            this.lbl_englishInput.Location = new System.Drawing.Point(20, 12);
            this.lbl_englishInput.Name = "lbl_englishInput";
            this.lbl_englishInput.Size = new System.Drawing.Size(41, 13);
            this.lbl_englishInput.TabIndex = 2;
            this.lbl_englishInput.Text = "English";
            // 
            // lbl_binInput
            // 
            this.lbl_binInput.AutoSize = true;
            this.lbl_binInput.Location = new System.Drawing.Point(17, 205);
            this.lbl_binInput.Name = "lbl_binInput";
            this.lbl_binInput.Size = new System.Drawing.Size(36, 13);
            this.lbl_binInput.TabIndex = 3;
            this.lbl_binInput.Text = "Binary";
            // 
            // rtb_binText
            // 
            this.rtb_binText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_binText.Location = new System.Drawing.Point(15, 221);
            this.rtb_binText.Name = "rtb_binText";
            this.rtb_binText.Size = new System.Drawing.Size(562, 69);
            this.rtb_binText.TabIndex = 4;
            this.rtb_binText.Text = "";
            // 
            // rtbEngText
            // 
            this.rtbEngText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbEngText.Location = new System.Drawing.Point(23, 28);
            this.rtbEngText.Name = "rtbEngText";
            this.rtbEngText.Size = new System.Drawing.Size(554, 70);
            this.rtbEngText.TabIndex = 5;
            this.rtbEngText.Text = "";
            // 
            // lblVerNum
            // 
            this.lblVerNum.AutoSize = true;
            this.lblVerNum.Location = new System.Drawing.Point(12, 345);
            this.lblVerNum.Name = "lblVerNum";
            this.lblVerNum.Size = new System.Drawing.Size(35, 13);
            this.lblVerNum.TabIndex = 6;
            this.lblVerNum.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(622, 367);
            this.Controls.Add(this.lblVerNum);
            this.Controls.Add(this.rtbEngText);
            this.Controls.Add(this.rtb_binText);
            this.Controls.Add(this.lbl_binInput);
            this.Controls.Add(this.lbl_englishInput);
            this.Controls.Add(this.btn_bintoeng);
            this.Controls.Add(this.btn_engtobin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "English to Binary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_engtobin;
        private System.Windows.Forms.Button btn_bintoeng;
        private System.Windows.Forms.Label lbl_englishInput;
        private System.Windows.Forms.Label lbl_binInput;
        private System.Windows.Forms.RichTextBox rtb_binText;
        private System.Windows.Forms.RichTextBox rtbEngText;
        private System.Windows.Forms.Label lblVerNum;
    }
}

