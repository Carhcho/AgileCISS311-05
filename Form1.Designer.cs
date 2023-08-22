
namespace dropbox05
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
            this.skuComboBox = new System.Windows.Forms.ComboBox();
            this.productDetailsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // skuComboBox
            // 
            this.skuComboBox.FormattingEnabled = true;
            this.skuComboBox.Location = new System.Drawing.Point(323, 56);
            this.skuComboBox.Name = "skuComboBox";
            this.skuComboBox.Size = new System.Drawing.Size(121, 21);
            this.skuComboBox.TabIndex = 0;
            this.skuComboBox.SelectedIndexChanged += new System.EventHandler(this.skuComboBox_SelectedIndexChanged);
            // 
            // productDetailsListBox
            // 
            this.productDetailsListBox.FormattingEnabled = true;
            this.productDetailsListBox.Location = new System.Drawing.Point(104, 98);
            this.productDetailsListBox.Name = "productDetailsListBox";
            this.productDetailsListBox.Size = new System.Drawing.Size(627, 277);
            this.productDetailsListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productDetailsListBox);
            this.Controls.Add(this.skuComboBox);
            this.Name = "Form1";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox skuComboBox;
        private System.Windows.Forms.ListBox productDetailsListBox;
    }
}

