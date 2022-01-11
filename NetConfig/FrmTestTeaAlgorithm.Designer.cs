
namespace NetConfig
{
    partial class FrmTestTeaAlgorithm
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
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnOverFlow = new System.Windows.Forms.Button();
            this.btnUnOverFlow = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnHxEn = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnOr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecondKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(230, 58);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(192, 21);
            this.txtEncrypt.TabIndex = 0;
            this.txtEncrypt.Text = "Hell";
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(230, 101);
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(192, 21);
            this.txtDecrypt.TabIndex = 0;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(456, 55);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "加密";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(456, 99);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "解密";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnOverFlow
            // 
            this.btnOverFlow.Location = new System.Drawing.Point(230, 138);
            this.btnOverFlow.Name = "btnOverFlow";
            this.btnOverFlow.Size = new System.Drawing.Size(75, 23);
            this.btnOverFlow.TabIndex = 2;
            this.btnOverFlow.Text = "溢出测试";
            this.btnOverFlow.UseVisualStyleBackColor = true;
            this.btnOverFlow.Click += new System.EventHandler(this.btnOverFlow_Click);
            // 
            // btnUnOverFlow
            // 
            this.btnUnOverFlow.Location = new System.Drawing.Point(337, 138);
            this.btnUnOverFlow.Name = "btnUnOverFlow";
            this.btnUnOverFlow.Size = new System.Drawing.Size(75, 23);
            this.btnUnOverFlow.TabIndex = 2;
            this.btnUnOverFlow.Text = "不溢出测试";
            this.btnUnOverFlow.UseVisualStyleBackColor = true;
            this.btnUnOverFlow.Click += new System.EventHandler(this.btnUnOverFlow_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(437, 178);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "计算sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(437, 208);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "计算长度";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(227, 208);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(183, 21);
            this.txtNum.TabIndex = 5;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(227, 177);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "左移1位";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(318, 178);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = "右移";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnHxEn
            // 
            this.btnHxEn.Location = new System.Drawing.Point(437, 250);
            this.btnHxEn.Name = "btnHxEn";
            this.btnHxEn.Size = new System.Drawing.Size(75, 23);
            this.btnHxEn.TabIndex = 8;
            this.btnHxEn.Text = "加密";
            this.btnHxEn.UseVisualStyleBackColor = true;
            this.btnHxEn.Click += new System.EventHandler(this.btnHxEn_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(227, 253);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(195, 21);
            this.txtContent.TabIndex = 9;
            this.txtContent.Text = "5E5111336F652303";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "内容：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "密钥：";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(227, 278);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(195, 21);
            this.txtKey.TabIndex = 9;
            this.txtKey.Text = "864337058652596";
            // 
            // btnOr
            // 
            this.btnOr.Location = new System.Drawing.Point(437, 275);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(75, 23);
            this.btnOr.TabIndex = 11;
            this.btnOr.Text = "异或";
            this.btnOr.UseVisualStyleBackColor = true;
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "第二次密钥：";
            // 
            // txtSecondKey
            // 
            this.txtSecondKey.Location = new System.Drawing.Point(227, 311);
            this.txtSecondKey.Name = "txtSecondKey";
            this.txtSecondKey.Size = new System.Drawing.Size(195, 21);
            this.txtSecondKey.TabIndex = 9;
            this.txtSecondKey.Text = "UIG00112139R6666";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "第一次加密结果：";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(227, 338);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(195, 21);
            this.txtFirst.TabIndex = 9;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(227, 364);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(195, 21);
            this.txtSecond.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "第二次加密结果：";
            // 
            // FrmTestTeaAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtSecondKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnHxEn);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnUnOverFlow);
            this.Controls.Add(this.btnOverFlow);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.txtEncrypt);
            this.Name = "FrmTestTeaAlgorithm";
            this.Text = "FrmTestTeaAlgorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnOverFlow;
        private System.Windows.Forms.Button btnUnOverFlow;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnHxEn;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnOr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecondKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label label5;
    }
}