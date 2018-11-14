namespace ZiboTextureSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button2k = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.Button4k = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button2k
            // 
            this.Button2k.Location = new System.Drawing.Point(77, 80);
            this.Button2k.Margin = new System.Windows.Forms.Padding(2);
            this.Button2k.Name = "Button2k";
            this.Button2k.Size = new System.Drawing.Size(97, 28);
            this.Button2k.TabIndex = 2;
            this.Button2k.Text = "2K";
            this.Button2k.UseVisualStyleBackColor = true;
            this.Button2k.Click += new System.EventHandler(this.Button2k_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(-2, 25);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(388, 26);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.Text = "Select the resolution you want to install";
            // 
            // Button4k
            // 
            this.Button4k.Location = new System.Drawing.Point(211, 80);
            this.Button4k.Margin = new System.Windows.Forms.Padding(2);
            this.Button4k.Name = "Button4k";
            this.Button4k.Size = new System.Drawing.Size(97, 28);
            this.Button4k.TabIndex = 4;
            this.Button4k.Text = "4K";
            this.Button4k.UseVisualStyleBackColor = true;
            this.Button4k.Click += new System.EventHandler(this.Button4k_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.Black;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.outputLabel.Location = new System.Drawing.Point(58, 136);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 20);
            this.outputLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.Button4k);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.Button2k);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Zibo Texture Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button2k;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button Button4k;
        private System.Windows.Forms.Label outputLabel;
    }
}

