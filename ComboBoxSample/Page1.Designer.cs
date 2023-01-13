namespace ComboBoxSample
{
    partial class Page1
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sampleComboBox = new Wisej.Web.ComboBox();
            this.label1 = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // sampleComboBox
            // 
            this.sampleComboBox.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.sampleComboBox.AutoCompleteMode = Wisej.Web.AutoCompleteMode.Filter;
            this.sampleComboBox.Location = new System.Drawing.Point(3, 26);
            this.sampleComboBox.Name = "sampleComboBox";
            this.sampleComboBox.Size = new System.Drawing.Size(1043, 22);
            this.sampleComboBox.TabIndex = 0;
            this.sampleComboBox.VirtualScroll = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "AutoCompleteMode = Filter";
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sampleComboBox);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1049, 548);
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.ComboBox sampleComboBox;
        private Wisej.Web.Label label1;
    }
}

