namespace Pakage
{
    partial class circle
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
            this.y1 = new System.Windows.Forms.TextBox();
            this.radius = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.circle1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(496, 293);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(75, 23);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(179, 71);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(100, 20);
            this.y1.TabIndex = 1;
            this.y1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(97, 184);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(100, 20);
            this.radius.TabIndex = 2;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(31, 71);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(100, 20);
            this.x1.TabIndex = 3;
            // 
            // circle1
            // 
            this.circle1.BackColor = System.Drawing.Color.Cornsilk;
            this.circle1.Location = new System.Drawing.Point(321, 37);
            this.circle1.Name = "circle1";
            this.circle1.Size = new System.Drawing.Size(456, 236);
            this.circle1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "radius";
            // 
            // circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circle1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.Draw);
            this.Name = "circle";
            this.Text = "circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.Panel circle1;
        private System.Windows.Forms.Label label1;
    }
}