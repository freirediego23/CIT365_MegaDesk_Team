
namespace MegaDesk_DiegoFreire2
{
    partial class AddMyQuotes
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
            this.label7 = new System.Windows.Forms.Label();
            this.ListMaterial = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RushOrder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Drawer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Depth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Material";
            // 
            // ListMaterial
            // 
            this.ListMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListMaterial.FormattingEnabled = true;
            this.ListMaterial.Location = new System.Drawing.Point(254, 277);
            this.ListMaterial.Name = "ListMaterial";
            this.ListMaterial.Size = new System.Drawing.Size(100, 21);
            this.ListMaterial.TabIndex = 28;
            this.ListMaterial.SelectedIndexChanged += new System.EventHandler(this.ListMaterial_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Save Quote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RushOrder
            // 
            this.RushOrder.Location = new System.Drawing.Point(254, 209);
            this.RushOrder.Name = "RushOrder";
            this.RushOrder.Size = new System.Drawing.Size(100, 20);
            this.RushOrder.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Rush Order";
            // 
            // Drawer
            // 
            this.Drawer.Location = new System.Drawing.Point(63, 277);
            this.Drawer.Name = "Drawer";
            this.Drawer.Size = new System.Drawing.Size(100, 20);
            this.Drawer.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Number of Drawers";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(254, 324);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 22;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Depth
            // 
            this.Depth.Location = new System.Drawing.Point(63, 209);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(100, 20);
            this.Depth.TabIndex = 21;
            this.Depth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Depth_KeyPress);
            this.Depth.Validating += new System.ComponentModel.CancelEventHandler(this.Depth_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Depth";
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(63, 138);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(100, 20);
            this.Width.TabIndex = 19;
            this.Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Width_KeyPress);
            this.Width.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Width";
            // 
            // Customer
            // 
            this.Customer.Location = new System.Drawing.Point(63, 68);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(100, 20);
            this.Customer.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Customer Name";
            // 
            // AddMyQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ListMaterial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RushOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Drawer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.label1);
            this.Name = "AddMyQuotes";
            this.Text = "Add Quote Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ListMaterial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RushOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Drawer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox Depth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Customer;
        private System.Windows.Forms.Label label1;
    }
}