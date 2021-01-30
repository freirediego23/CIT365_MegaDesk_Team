
namespace MegaDesk_DiegoFreire2
{
    partial class SearchQuotes
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
            this.BackButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton3
            // 
            this.BackButton3.Location = new System.Drawing.Point(76, 345);
            this.BackButton3.Name = "BackButton3";
            this.BackButton3.Size = new System.Drawing.Size(75, 23);
            this.BackButton3.TabIndex = 1;
            this.BackButton3.Text = "Back";
            this.BackButton3.UseVisualStyleBackColor = true;
            this.BackButton3.Click += new System.EventHandler(this.BackButton3_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.BackButton3);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton3;
    }
}