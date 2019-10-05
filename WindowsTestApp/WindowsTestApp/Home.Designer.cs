namespace WindowsTestApp
{
    partial class Home
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
            this.itemInfoButton = new System.Windows.Forms.Button();
            this.customerInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemInfoButton
            // 
            this.itemInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemInfoButton.Location = new System.Drawing.Point(486, 149);
            this.itemInfoButton.Name = "itemInfoButton";
            this.itemInfoButton.Size = new System.Drawing.Size(123, 40);
            this.itemInfoButton.TabIndex = 0;
            this.itemInfoButton.Text = "Item-Info";
            this.itemInfoButton.UseVisualStyleBackColor = true;
            this.itemInfoButton.Click += new System.EventHandler(this.ItemInfoButton_Click);
            // 
            // customerInfoButton
            // 
            this.customerInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfoButton.Location = new System.Drawing.Point(295, 149);
            this.customerInfoButton.Name = "customerInfoButton";
            this.customerInfoButton.Size = new System.Drawing.Size(140, 40);
            this.customerInfoButton.TabIndex = 0;
            this.customerInfoButton.Text = "Customer-Info";
            this.customerInfoButton.UseVisualStyleBackColor = true;
            this.customerInfoButton.Click += new System.EventHandler(this.CustomerInfoButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerInfoButton);
            this.Controls.Add(this.itemInfoButton);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button itemInfoButton;
        private System.Windows.Forms.Button customerInfoButton;
    }
}

