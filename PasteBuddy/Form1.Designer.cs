﻿namespace PasteBuddy
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
            this.boxConnection = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbSerialPorts = new System.Windows.Forms.ComboBox();
            this.boxButton1 = new System.Windows.Forms.GroupBox();
            this.txtButtonPress1 = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.panelButton = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtButtonRelease1 = new System.Windows.Forms.TextBox();
            this.boxConnection.SuspendLayout();
            this.boxButton1.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxConnection
            // 
            this.boxConnection.Controls.Add(this.btnConnect);
            this.boxConnection.Controls.Add(this.cmbSerialPorts);
            this.boxConnection.Location = new System.Drawing.Point(18, 12);
            this.boxConnection.Name = "boxConnection";
            this.boxConnection.Size = new System.Drawing.Size(227, 57);
            this.boxConnection.TabIndex = 0;
            this.boxConnection.TabStop = false;
            this.boxConnection.Text = "Connect to Device";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(134, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbSerialPorts
            // 
            this.cmbSerialPorts.FormattingEnabled = true;
            this.cmbSerialPorts.Location = new System.Drawing.Point(6, 19);
            this.cmbSerialPorts.Name = "cmbSerialPorts";
            this.cmbSerialPorts.Size = new System.Drawing.Size(121, 21);
            this.cmbSerialPorts.TabIndex = 0;
            // 
            // boxButton1
            // 
            this.boxButton1.Controls.Add(this.txtButtonRelease1);
            this.boxButton1.Controls.Add(this.txtButtonPress1);
            this.boxButton1.Location = new System.Drawing.Point(6, 3);
            this.boxButton1.Name = "boxButton1";
            this.boxButton1.Size = new System.Drawing.Size(670, 54);
            this.boxButton1.TabIndex = 1;
            this.boxButton1.TabStop = false;
            this.boxButton1.Text = "Button 1";
            // 
            // txtButtonPress1
            // 
            this.txtButtonPress1.Location = new System.Drawing.Point(7, 19);
            this.txtButtonPress1.Name = "txtButtonPress1";
            this.txtButtonPress1.Size = new System.Drawing.Size(308, 20);
            this.txtButtonPress1.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(601, 140);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.boxButton1);
            this.panelButton.Controls.Add(this.btnApply);
            this.panelButton.Location = new System.Drawing.Point(18, 75);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(679, 169);
            this.panelButton.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelConnectionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 260);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(709, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(129, 17);
            this.labelConnectionStatus.Text = "Status: Not Connected ";
            // 
            // txtButtonRelease1
            // 
            this.txtButtonRelease1.Location = new System.Drawing.Point(356, 19);
            this.txtButtonRelease1.Name = "txtButtonRelease1";
            this.txtButtonRelease1.Size = new System.Drawing.Size(308, 20);
            this.txtButtonRelease1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 282);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.boxConnection);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Paste Buddy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxConnection.ResumeLayout(false);
            this.boxButton1.ResumeLayout(false);
            this.boxButton1.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox boxConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbSerialPorts;
        private System.Windows.Forms.GroupBox boxButton1;
        private System.Windows.Forms.TextBox txtButtonPress1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelConnectionStatus;
        private System.Windows.Forms.TextBox txtButtonRelease1;
    }
}
