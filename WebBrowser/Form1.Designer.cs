namespace WebBrowser
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
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(12, 229);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(196, 20);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.Text = "http://";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(214, 229);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(58, 20);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // WebBrowser1
            // 
            this.WebBrowser1.Location = new System.Drawing.Point(9, 8);
            this.WebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.Size = new System.Drawing.Size(262, 211);
            this.WebBrowser1.TabIndex = 2;
            this.WebBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.WebBrowser1);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.urlTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.WebBrowser WebBrowser1;
    }
}

