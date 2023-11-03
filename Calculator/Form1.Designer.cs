namespace Calculator
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
            this.lbSoA = new System.Windows.Forms.Label();
            this.lbSoB = new System.Windows.Forms.Label();
            this.btCong = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.lbKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSoA
            // 
            this.lbSoA.AutoSize = true;
            this.lbSoA.Location = new System.Drawing.Point(39, 46);
            this.lbSoA.Name = "lbSoA";
            this.lbSoA.Size = new System.Drawing.Size(30, 13);
            this.lbSoA.TabIndex = 0;
            this.lbSoA.Text = "Số A";
            this.lbSoA.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbSoB
            // 
            this.lbSoB.AutoSize = true;
            this.lbSoB.Location = new System.Drawing.Point(39, 97);
            this.lbSoB.Name = "lbSoB";
            this.lbSoB.Size = new System.Drawing.Size(30, 13);
            this.lbSoB.TabIndex = 1;
            this.lbSoB.Text = "Số B";
            this.lbSoB.Click += new System.EventHandler(this.label2_Click);
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(121, 186);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 23);
            this.btCong.TabIndex = 3;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(285, 186);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(75, 23);
            this.btTru.TabIndex = 3;
            this.btTru.Text = " Trừ";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(138, 90);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(137, 20);
            this.txtB.TabIndex = 4;
            this.txtB.Text = " ";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(138, 46);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(137, 20);
            this.txtA.TabIndex = 4;
            this.txtA.Text = " ";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(138, 131);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(137, 20);
            this.txtKQ.TabIndex = 4;
            this.txtKQ.Text = " ";
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Location = new System.Drawing.Point(39, 138);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(44, 13);
            this.lbKQ.TabIndex = 1;
            this.lbKQ.Text = "Kết quả";
            this.lbKQ.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 261);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbSoB);
            this.Controls.Add(this.lbSoA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSoA;
        private System.Windows.Forms.Label lbSoB;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label lbKQ;
    }
}

