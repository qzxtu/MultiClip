namespace MultiClip
{
    partial class ExpandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpandForm));
            this.fullTextBox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullTextBox
            // 
            this.fullTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fullTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullTextBox.Location = new System.Drawing.Point(0, 0);
            this.fullTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fullTextBox.Name = "fullTextBox";
            this.fullTextBox.Size = new System.Drawing.Size(352, 203);
            this.fullTextBox.TabIndex = 1;
            this.fullTextBox.Text = "";
            this.fullTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fullTextBox_KeyPress);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(242, 147);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 45);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ExpandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 203);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.fullTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExpandForm";
            this.Text = "MultiClip (ExpandForm)";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox fullTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}