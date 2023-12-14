namespace Client
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
            this.PortInput = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.UsersPanel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GetButton = new System.Windows.Forms.Button();
            this.UserId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PortInput
            // 
            this.PortInput.Location = new System.Drawing.Point(12, 47);
            this.PortInput.Name = "PortInput";
            this.PortInput.Size = new System.Drawing.Size(186, 22);
            this.PortInput.TabIndex = 0;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(215, 41);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(91, 35);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(26, 159);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(113, 22);
            this.NameBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "----------------------Add new Users---------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age";
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(180, 159);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(113, 22);
            this.AgeBox.TabIndex = 5;
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(84, 198);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(154, 32);
            this.SetButton.TabIndex = 7;
            this.SetButton.Text = "Add";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // UsersPanel
            // 
            this.UsersPanel.Location = new System.Drawing.Point(26, 268);
            this.UsersPanel.Multiline = true;
            this.UsersPanel.Name = "UsersPanel";
            this.UsersPanel.Size = new System.Drawing.Size(267, 162);
            this.UsersPanel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "----------------------Get Users---------------------";
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(84, 510);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(154, 32);
            this.GetButton.TabIndex = 10;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // UserId
            // 
            this.UserId.Location = new System.Drawing.Point(26, 472);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(267, 22);
            this.UserId.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "UserId";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 576);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UsersPanel);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PortInput);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PortInput;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.TextBox UsersPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.TextBox UserId;
        private System.Windows.Forms.Label label5;
    }
}

