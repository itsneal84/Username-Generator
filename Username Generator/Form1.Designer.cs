namespace Username_Generator
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
            this.firstname_txt = new System.Windows.Forms.TextBox();
            this.lastname_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combine_btn = new System.Windows.Forms.Button();
            this.username_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstname_txt
            // 
            this.firstname_txt.Location = new System.Drawing.Point(87, 49);
            this.firstname_txt.Name = "firstname_txt";
            this.firstname_txt.Size = new System.Drawing.Size(100, 20);
            this.firstname_txt.TabIndex = 0;
            this.firstname_txt.TextChanged += new System.EventHandler(this.firstname_txt_TextChanged);
            // 
            // lastname_txt
            // 
            this.lastname_txt.Location = new System.Drawing.Point(299, 49);
            this.lastname_txt.Name = "lastname_txt";
            this.lastname_txt.Size = new System.Drawing.Size(100, 20);
            this.lastname_txt.TabIndex = 1;
            this.lastname_txt.TextChanged += new System.EventHandler(this.lastname_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // combine_btn
            // 
            this.combine_btn.Location = new System.Drawing.Point(87, 107);
            this.combine_btn.Name = "combine_btn";
            this.combine_btn.Size = new System.Drawing.Size(97, 23);
            this.combine_btn.TabIndex = 4;
            this.combine_btn.Text = "Combine";
            this.combine_btn.UseVisualStyleBackColor = true;
            this.combine_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(87, 176);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(0, 13);
            this.username_lbl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 308);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.combine_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastname_txt);
            this.Controls.Add(this.firstname_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstname_txt;
        private System.Windows.Forms.TextBox lastname_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button combine_btn;
        private System.Windows.Forms.Label username_lbl;
    }
}

