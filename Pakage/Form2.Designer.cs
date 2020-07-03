namespace Pakage
{
    partial class Form2
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
            this.y1 = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.line1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(441, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "line1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(174, 70);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(100, 20);
            this.y1.TabIndex = 1;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(22, 70);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(100, 20);
            this.x1.TabIndex = 2;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(174, 167);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(100, 20);
            this.y2.TabIndex = 3;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(22, 167);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(100, 20);
            this.x2.TabIndex = 4;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Cornsilk;
            this.line1.Location = new System.Drawing.Point(313, 34);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(450, 241);
            this.line1.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.Panel line1;
    }
}