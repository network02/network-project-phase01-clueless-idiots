namespace CheckPorts
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
            this.IPInput = new System.Windows.Forms.TextBox();
            this.StartPort = new System.Windows.Forms.TextBox();
            this.EndPort = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConsoleLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IPInput
            // 
            this.IPInput.Location = new System.Drawing.Point(28, 48);
            this.IPInput.Name = "IPInput";
            this.IPInput.Size = new System.Drawing.Size(355, 22);
            this.IPInput.TabIndex = 0;
            // 
            // StartPort
            // 
            this.StartPort.Location = new System.Drawing.Point(28, 104);
            this.StartPort.Name = "StartPort";
            this.StartPort.Size = new System.Drawing.Size(162, 22);
            this.StartPort.TabIndex = 1;
            // 
            // EndPort
            // 
            this.EndPort.Location = new System.Drawing.Point(215, 104);
            this.EndPort.Name = "EndPort";
            this.EndPort.Size = new System.Drawing.Size(168, 22);
            this.EndPort.TabIndex = 2;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(117, 153);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(178, 34);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "Check";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Finish";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Console Log";
            // 
            // ConsoleLog
            // 
            this.ConsoleLog.FormattingEnabled = true;
            this.ConsoleLog.ItemHeight = 16;
            this.ConsoleLog.Location = new System.Drawing.Point(28, 234);
            this.ConsoleLog.Name = "ConsoleLog";
            this.ConsoleLog.Size = new System.Drawing.Size(354, 116);
            this.ConsoleLog.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 385);
            this.Controls.Add(this.ConsoleLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.EndPort);
            this.Controls.Add(this.StartPort);
            this.Controls.Add(this.IPInput);
            this.Name = "Form1";
            this.Text = "Check Ports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPInput;
        private System.Windows.Forms.TextBox StartPort;
        private System.Windows.Forms.TextBox EndPort;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ConsoleLog;
    }
}

