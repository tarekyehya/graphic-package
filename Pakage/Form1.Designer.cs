namespace Pakage
{
    partial class form1
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
            this.DDL = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.elips = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DDL
            // 
            this.DDL.Location = new System.Drawing.Point(411, 111);
            this.DDL.Name = "DDL";
            this.DDL.Size = new System.Drawing.Size(75, 23);
            this.DDL.TabIndex = 0;
            this.DDL.Text = "DDL";
            this.DDL.UseVisualStyleBackColor = true;
            this.DDL.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Bresenham";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // circle
            // 
            this.circle.Location = new System.Drawing.Point(411, 226);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(75, 23);
            this.circle.TabIndex = 2;
            this.circle.Text = "circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // elips
            // 
            this.elips.Location = new System.Drawing.Point(177, 226);
            this.elips.Name = "elips";
            this.elips.Size = new System.Drawing.Size(75, 23);
            this.elips.TabIndex = 3;
            this.elips.Text = "elips";
            this.elips.UseVisualStyleBackColor = true;
            this.elips.Click += new System.EventHandler(this.elips_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elips);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DDL);
            this.Name = "form1";
            this.Text = "Bresenham";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DDL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button elips;
    }
}

