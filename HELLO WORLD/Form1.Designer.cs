namespace HELLO_WORLD
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
            this.button1 = new System.Windows.Forms.Button();
            this.txxtBx1Name = new System.Windows.Forms.TextBox();
            this.txxtBx2Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "HELLO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txxtBx1Name
            // 
            this.txxtBx1Name.Location = new System.Drawing.Point(508, 195);
            this.txxtBx1Name.Name = "txxtBx1Name";
            this.txxtBx1Name.Size = new System.Drawing.Size(191, 20);
            this.txxtBx1Name.TabIndex = 1;
            this.txxtBx1Name.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txxtBx2Name
            // 
            this.txxtBx2Name.Location = new System.Drawing.Point(508, 221);
            this.txxtBx2Name.Name = "txxtBx2Name";
            this.txxtBx2Name.Size = new System.Drawing.Size(191, 20);
            this.txxtBx2Name.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 814);
            this.Controls.Add(this.txxtBx2Name);
            this.Controls.Add(this.txxtBx1Name);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txxtBx1Name;
        private System.Windows.Forms.TextBox txxtBx2Name;
    }
}

