namespace Server
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
            this.ListenButton = new System.Windows.Forms.Button();
            this.PortInput = new System.Windows.Forms.TextBox();
            this.Names = new System.Windows.Forms.ListBox();
            this.Ages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListenButton
            // 
            this.ListenButton.Location = new System.Drawing.Point(194, 33);
            this.ListenButton.Name = "ListenButton";
            this.ListenButton.Size = new System.Drawing.Size(74, 36);
            this.ListenButton.TabIndex = 0;
            this.ListenButton.Text = "Listen";
            this.ListenButton.UseVisualStyleBackColor = true;
            this.ListenButton.Click += new System.EventHandler(this.ListenButton_Click);
            // 
            // PortInput
            // 
            this.PortInput.Location = new System.Drawing.Point(12, 40);
            this.PortInput.Name = "PortInput";
            this.PortInput.Size = new System.Drawing.Size(171, 22);
            this.PortInput.TabIndex = 1;
            // 
            // Names
            // 
            this.Names.FormattingEnabled = true;
            this.Names.ItemHeight = 16;
            this.Names.Location = new System.Drawing.Point(12, 100);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(113, 180);
            this.Names.TabIndex = 2;
            // 
            // Ages
            // 
            this.Ages.FormattingEnabled = true;
            this.Ages.ItemHeight = 16;
            this.Ages.Location = new System.Drawing.Point(148, 100);
            this.Ages.Name = "Ages";
            this.Ages.Size = new System.Drawing.Size(120, 180);
            this.Ages.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 355);
            this.Controls.Add(this.Ages);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.PortInput);
            this.Controls.Add(this.ListenButton);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListenButton;
        private System.Windows.Forms.TextBox PortInput;
        private System.Windows.Forms.ListBox Names;
        private System.Windows.Forms.ListBox Ages;
    }
}

