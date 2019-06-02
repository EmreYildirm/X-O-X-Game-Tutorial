namespace UI
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
            this.p2score = new System.Windows.Forms.Label();
            this.p2name = new System.Windows.Forms.Label();
            this.p1score = new System.Windows.Forms.Label();
            this.p1name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p2score
            // 
            this.p2score.AutoSize = true;
            this.p2score.Location = new System.Drawing.Point(668, 72);
            this.p2score.Name = "p2score";
            this.p2score.Size = new System.Drawing.Size(0, 17);
            this.p2score.TabIndex = 1;
            // 
            // p2name
            // 
            this.p2name.AutoSize = true;
            this.p2name.Location = new System.Drawing.Point(534, 72);
            this.p2name.Name = "p2name";
            this.p2name.Size = new System.Drawing.Size(0, 17);
            this.p2name.TabIndex = 2;
            // 
            // p1score
            // 
            this.p1score.AutoSize = true;
            this.p1score.Location = new System.Drawing.Point(668, 38);
            this.p1score.Name = "p1score";
            this.p1score.Size = new System.Drawing.Size(0, 17);
            this.p1score.TabIndex = 3;
            // 
            // p1name
            // 
            this.p1name.AutoSize = true;
            this.p1name.Location = new System.Drawing.Point(534, 38);
            this.p1name.Name = "p1name";
            this.p1name.Size = new System.Drawing.Size(0, 17);
            this.p1name.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.p2score);
            this.Controls.Add(this.p2name);
            this.Controls.Add(this.p1score);
            this.Controls.Add(this.p1name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p2score;
        private System.Windows.Forms.Label p2name;
        private System.Windows.Forms.Label p1score;
        private System.Windows.Forms.Label p1name;
    }
}

