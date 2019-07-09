namespace ServerV
{
    partial class SendMenu
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
            this.SeconParametrTextBox = new System.Windows.Forms.TextBox();
            this.FirstParametrTextBox = new System.Windows.Forms.TextBox();
            this.secondParametr = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.SendBuuton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeconParametrTextBox
            // 
            this.SeconParametrTextBox.Location = new System.Drawing.Point(117, 101);
            this.SeconParametrTextBox.Name = "SeconParametrTextBox";
            this.SeconParametrTextBox.Size = new System.Drawing.Size(126, 20);
            this.SeconParametrTextBox.TabIndex = 9;
            // 
            // FirstParametrTextBox
            // 
            this.FirstParametrTextBox.Location = new System.Drawing.Point(117, 30);
            this.FirstParametrTextBox.Name = "FirstParametrTextBox";
            this.FirstParametrTextBox.Size = new System.Drawing.Size(126, 20);
            this.FirstParametrTextBox.TabIndex = 8;
            // 
            // secondParametr
            // 
            this.secondParametr.AutoSize = true;
            this.secondParametr.Location = new System.Drawing.Point(16, 104);
            this.secondParametr.Name = "secondParametr";
            this.secondParametr.Size = new System.Drawing.Size(95, 13);
            this.secondParametr.TabIndex = 7;
            this.secondParametr.Text = "Второй параметр";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(12, 33);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(99, 13);
            this.FirstName.TabIndex = 6;
            this.FirstName.Text = "Первый параметр";
            // 
            // SendBuuton
            // 
            this.SendBuuton.Location = new System.Drawing.Point(117, 217);
            this.SendBuuton.Name = "SendBuuton";
            this.SendBuuton.Size = new System.Drawing.Size(126, 41);
            this.SendBuuton.TabIndex = 5;
            this.SendBuuton.Text = "Send";
            this.SendBuuton.UseVisualStyleBackColor = true;
            this.SendBuuton.Click += new System.EventHandler(this.SendBuuton_Click);
            // 
            // SendMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 284);
            this.Controls.Add(this.SeconParametrTextBox);
            this.Controls.Add(this.FirstParametrTextBox);
            this.Controls.Add(this.secondParametr);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.SendBuuton);
            this.Name = "SendMenu";
            this.Text = "SendMenu";
            this.Load += new System.EventHandler(this.SendMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SeconParametrTextBox;
        private System.Windows.Forms.TextBox FirstParametrTextBox;
        private System.Windows.Forms.Label secondParametr;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Button SendBuuton;
    }
}