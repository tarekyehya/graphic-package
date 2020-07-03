namespace Pakage
{
    partial class elips
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
            this.elips1 = new System.Windows.Forms.Panel();
            this.xCenter = new System.Windows.Forms.TextBox();
            this.radius1 = new System.Windows.Forms.TextBox();
            this.yCenter = new System.Windows.Forms.TextBox();
            this.radius2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(531, 317);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(75, 23);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // elips1
            // 
            this.elips1.BackColor = System.Drawing.Color.Cornsilk;
            this.elips1.Location = new System.Drawing.Point(345, 24);
            this.elips1.Name = "elips1";
            this.elips1.Size = new System.Drawing.Size(420, 271);
            this.elips1.TabIndex = 1;
            // 
            // xCenter
            // 
            this.xCenter.Location = new System.Drawing.Point(35, 63);
            this.xCenter.Name = "xCenter";
            this.xCenter.Size = new System.Drawing.Size(100, 20);
            this.xCenter.TabIndex = 2;
            // 
            // radius1
            // 
            this.radius1.Location = new System.Drawing.Point(35, 206);
            this.radius1.Name = "radius1";
            this.radius1.Size = new System.Drawing.Size(100, 20);
            this.radius1.TabIndex = 3;
            // 
            // yCenter
            // 
            this.yCenter.Location = new System.Drawing.Point(191, 63);
            this.yCenter.Name = "yCenter";
            this.yCenter.Size = new System.Drawing.Size(100, 20);
            this.yCenter.TabIndex = 4;
            // 
            // radius2
            // 
            this.radius2.Location = new System.Drawing.Point(191, 206);
            this.radius2.Name = "radius2";
            this.radius2.Size = new System.Drawing.Size(100, 20);
            this.radius2.TabIndex = 5;
            // 
            // elips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radius2);
            this.Controls.Add(this.yCenter);
            this.Controls.Add(this.radius1);
            this.Controls.Add(this.xCenter);
            this.Controls.Add(this.elips1);
            this.Controls.Add(this.Draw);
            this.Name = "elips";
            this.Text = "elips";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Panel elips1;
        private System.Windows.Forms.TextBox xCenter;
        private System.Windows.Forms.TextBox radius1;
        private System.Windows.Forms.TextBox yCenter;
        private System.Windows.Forms.TextBox radius2;
    }
}