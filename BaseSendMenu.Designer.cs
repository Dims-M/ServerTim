namespace ServerV
{
    partial class BaseSendMenu
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
            this.SendBuuton = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.secondParametr = new System.Windows.Forms.Label();
            this.FirstParametrTextBox = new System.Windows.Forms.TextBox();
            this.SeconParametrTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendBuuton
            // 
            this.SendBuuton.Location = new System.Drawing.Point(97, 218);
            this.SendBuuton.Name = "SendBuuton";
            this.SendBuuton.Size = new System.Drawing.Size(126, 41);
            this.SendBuuton.TabIndex = 0;
            this.SendBuuton.Text = "Send";
            this.SendBuuton.UseVisualStyleBackColor = true;
            this.SendBuuton.Click += new System.EventHandler(this.SendBuuton_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(1, 40);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(99, 13);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "Первый параметр";
            // 
            // secondParametr
            // 
            this.secondParametr.AutoSize = true;
            this.secondParametr.Location = new System.Drawing.Point(1, 111);
            this.secondParametr.Name = "secondParametr";
            this.secondParametr.Size = new System.Drawing.Size(95, 13);
            this.secondParametr.TabIndex = 2;
            this.secondParametr.Text = "Второй параметр";
            // 
            // FirstParametrTextBox
            // 
            this.FirstParametrTextBox.Location = new System.Drawing.Point(97, 37);
            this.FirstParametrTextBox.Name = "FirstParametrTextBox";
            this.FirstParametrTextBox.Size = new System.Drawing.Size(126, 20);
            this.FirstParametrTextBox.TabIndex = 3;
            // 
            // SeconParametrTextBox
            // 
            this.SeconParametrTextBox.Location = new System.Drawing.Point(97, 104);
            this.SeconParametrTextBox.Name = "SeconParametrTextBox";
            this.SeconParametrTextBox.Size = new System.Drawing.Size(126, 20);
            this.SeconParametrTextBox.TabIndex = 4;
            // 
            // BaseSendMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 287);
            this.Controls.Add(this.SeconParametrTextBox);
            this.Controls.Add(this.FirstParametrTextBox);
            this.Controls.Add(this.secondParametr);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.SendBuuton);
            this.Name = "BaseSendMenu";
            this.Text = "BaseSendMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendBuuton;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label secondParametr;
        private System.Windows.Forms.TextBox FirstParametrTextBox;
        private System.Windows.Forms.TextBox SeconParametrTextBox;
    }
}