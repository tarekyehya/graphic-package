namespace Pakage
{
    partial class Bresenham
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
            this.Draw = new System.Windows.Forms.Button();
            this.line2 = new System.Windows.Forms.Panel();
            this.y1 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(495, 318);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(75, 23);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.Cornsilk;
            this.line2.Location = new System.Drawing.Point(304, 12);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(470, 254);
            this.line2.TabIndex = 1;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(182, 92);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(100, 20);
            this.y1.TabIndex = 2;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(182, 215);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(100, 20);
            this.y2.TabIndex = 3;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(34, 215);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(100, 20);
            this.x2.TabIndex = 5;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(34, 92);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(100, 20);
            this.x1.TabIndex = 6;
            // 
            // Bresenham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.Draw);
            this.Name = "Bresenham";
            this.Text = "Bresenham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox x1;
    }
}