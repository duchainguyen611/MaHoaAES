
namespace RSA
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
            this.txt_p = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_q = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.Label();
            this.q = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_p
            // 
            this.txt_p.Location = new System.Drawing.Point(139, 74);
            this.txt_p.Name = "txt_p";
            this.txt_p.Size = new System.Drawing.Size(100, 26);
            this.txt_p.TabIndex = 0;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(139, 156);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 26);
            this.txt_b.TabIndex = 1;
            // 
            // txt_q
            // 
            this.txt_q.Location = new System.Drawing.Point(139, 114);
            this.txt_q.Name = "txt_q";
            this.txt_q.Size = new System.Drawing.Size(100, 26);
            this.txt_q.TabIndex = 2;
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(102, 77);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(18, 20);
            this.p.TabIndex = 3;
            this.p.Text = "p";
            // 
            // q
            // 
            this.q.AutoSize = true;
            this.q.Location = new System.Drawing.Point(102, 117);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(18, 20);
            this.q.TabIndex = 4;
            this.q.Text = "q";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(102, 159);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(18, 20);
            this.b.TabIndex = 5;
            this.b.Text = "b";
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(418, 12);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(353, 178);
            this.rtb.TabIndex = 7;
            this.rtb.Text = "";
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(296, 90);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(87, 30);
            this.btn_run.TabIndex = 8;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(139, 31);
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(100, 26);
            this.txt_msg.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Massage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.b);
            this.Controls.Add(this.q);
            this.Controls.Add(this.p);
            this.Controls.Add(this.txt_q);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_p);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_p;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_q;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label q;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Label label1;
    }
}

