namespace txTabPositions
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
            this.textControl1 = new TXTextControl.TextControl();
            this.rulerBar1 = new TXTextControl.RulerBar();
            this.SuspendLayout();
            // 
            // textControl1
            // 
            this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.textControl1.Location = new System.Drawing.Point(0, 25);
            this.textControl1.Name = "textControl1";
            this.textControl1.RulerBar = this.rulerBar1;
            this.textControl1.Size = new System.Drawing.Size(812, 397);
            this.textControl1.TabIndex = 0;
            this.textControl1.Text = "textControl1";
            this.textControl1.UserNames = null;
            // 
            // rulerBar1
            // 
            this.rulerBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rulerBar1.Location = new System.Drawing.Point(0, 0);
            this.rulerBar1.Name = "rulerBar1";
            this.rulerBar1.Size = new System.Drawing.Size(812, 25);
            this.rulerBar1.TabIndex = 1;
            this.rulerBar1.Text = "rulerBar1";
            this.rulerBar1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rulerBar1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 422);
            this.Controls.Add(this.textControl1);
            this.Controls.Add(this.rulerBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TXTextControl.TextControl textControl1;
        private TXTextControl.RulerBar rulerBar1;
    }
}

