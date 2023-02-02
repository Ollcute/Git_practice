namespace Git_pract
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_Mul = new System.Windows.Forms.Button();
            this.but_Div = new System.Windows.Forms.Button();
            this.but_Sub = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but_Add = new System.Windows.Forms.Button();
            this.tB_result = new System.Windows.Forms.TextBox();
            this.tB_2 = new System.Windows.Forms.TextBox();
            this.tB_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // but_Mul
            // 
            this.but_Mul.Location = new System.Drawing.Point(312, 184);
            this.but_Mul.Name = "but_Mul";
            this.but_Mul.Size = new System.Drawing.Size(64, 27);
            this.but_Mul.TabIndex = 19;
            this.but_Mul.Text = "*";
            this.but_Mul.UseVisualStyleBackColor = true;
            this.but_Mul.Click += new System.EventHandler(this.but_Mul_Click);
            // 
            // but_Div
            // 
            this.but_Div.Location = new System.Drawing.Point(206, 182);
            this.but_Div.Name = "but_Div";
            this.but_Div.Size = new System.Drawing.Size(65, 30);
            this.but_Div.TabIndex = 18;
            this.but_Div.Text = "/";
            this.but_Div.UseVisualStyleBackColor = true;
            // 
            // but_Sub
            // 
            this.but_Sub.Location = new System.Drawing.Point(100, 184);
            this.but_Sub.Name = "but_Sub";
            this.but_Sub.Size = new System.Drawing.Size(71, 27);
            this.but_Sub.TabIndex = 17;
            this.but_Sub.Text = "-";
            this.but_Sub.UseVisualStyleBackColor = true;
            this.but_Sub.Click += new System.EventHandler(this.but_Sub_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Number 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Number 1";
            // 
            // but_Add
            // 
            this.but_Add.Location = new System.Drawing.Point(12, 184);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(59, 29);
            this.but_Add.TabIndex = 13;
            this.but_Add.Text = "+";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // tB_result
            // 
            this.tB_result.Location = new System.Drawing.Point(251, 71);
            this.tB_result.Name = "tB_result";
            this.tB_result.Size = new System.Drawing.Size(125, 27);
            this.tB_result.TabIndex = 12;
            // 
            // tB_2
            // 
            this.tB_2.Location = new System.Drawing.Point(29, 113);
            this.tB_2.Name = "tB_2";
            this.tB_2.Size = new System.Drawing.Size(125, 27);
            this.tB_2.TabIndex = 11;
            // 
            // tB_1
            // 
            this.tB_1.Location = new System.Drawing.Point(29, 50);
            this.tB_1.Name = "tB_1";
            this.tB_1.Size = new System.Drawing.Size(125, 27);
            this.tB_1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 401);
            this.Controls.Add(this.but_Mul);
            this.Controls.Add(this.but_Div);
            this.Controls.Add(this.but_Sub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.tB_result);
            this.Controls.Add(this.tB_2);
            this.Controls.Add(this.tB_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button but_Mul;
        private Button but_Div;
        private Button but_Sub;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button but_Add;
        private TextBox tB_result;
        private TextBox tB_2;
        private TextBox tB_1;
    }
}