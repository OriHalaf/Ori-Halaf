
namespace Test_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ollPropertis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ollPropertis
            // 
            this.ollPropertis.AutoSize = true;
            this.ollPropertis.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ollPropertis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ollPropertis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ollPropertis.Image = ((System.Drawing.Image)(resources.GetObject("ollPropertis.Image")));
            this.ollPropertis.Location = new System.Drawing.Point(32, 31);
            this.ollPropertis.Name = "ollPropertis";
            this.ollPropertis.Size = new System.Drawing.Size(75, 31);
            this.ollPropertis.TabIndex = 0;
            this.ollPropertis.Text = "User:";
            this.ollPropertis.Click += new System.EventHandler(this.ollPropertis_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.ollPropertis);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ollPropertis;
    }
}