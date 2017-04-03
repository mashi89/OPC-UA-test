using System;

namespace OPC_UA_test
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
            this.connectButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.connStatusLabel = new System.Windows.Forms.Label();
            this.connStatusLabel2 = new System.Windows.Forms.Label();
            this.nodeListBox = new System.Windows.Forms.ListBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.findNodesButton = new System.Windows.Forms.Button();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.nodeToFindLabel = new System.Windows.Forms.Label();
            this.nodeTextBox = new System.Windows.Forms.TextBox();
            this.nodeChildrenLabel = new System.Windows.Forms.Label();
            this.childrenListBox = new System.Windows.Forms.ListBox();
            this.refreshButton2 = new System.Windows.Forms.Button();
            this.grandChildrenListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(251, 38);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(254, 327);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(72, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Select";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // connStatusLabel
            // 
            this.connStatusLabel.AutoSize = true;
            this.connStatusLabel.Location = new System.Drawing.Point(17, 43);
            this.connStatusLabel.Name = "connStatusLabel";
            this.connStatusLabel.Size = new System.Drawing.Size(95, 13);
            this.connStatusLabel.TabIndex = 6;
            this.connStatusLabel.Text = "Connection status:";
            // 
            // connStatusLabel2
            // 
            this.connStatusLabel2.AutoSize = true;
            this.connStatusLabel2.Location = new System.Drawing.Point(118, 43);
            this.connStatusLabel2.Name = "connStatusLabel2";
            this.connStatusLabel2.Size = new System.Drawing.Size(28, 13);
            this.connStatusLabel2.TabIndex = 7;
            this.connStatusLabel2.Text = "###";
            // 
            // nodeListBox
            // 
            this.nodeListBox.FormattingEnabled = true;
            this.nodeListBox.Location = new System.Drawing.Point(20, 135);
            this.nodeListBox.Name = "nodeListBox";
            this.nodeListBox.Size = new System.Drawing.Size(306, 186);
            this.nodeListBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(104, 12);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(222, 20);
            this.addressTextBox.TabIndex = 9;
            this.addressTextBox.Text = "opc.tcp://localhost:49320";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Server address:";
            // 
            // findNodesButton
            // 
            this.findNodesButton.Location = new System.Drawing.Point(631, 38);
            this.findNodesButton.Name = "findNodesButton";
            this.findNodesButton.Size = new System.Drawing.Size(75, 23);
            this.findNodesButton.TabIndex = 11;
            this.findNodesButton.Text = "Find Nodes";
            this.findNodesButton.UseVisualStyleBackColor = true;
            this.findNodesButton.Click += new System.EventHandler(this.findNodesButton_Click);
            // 
            // valuesListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.Location = new System.Drawing.Point(727, 135);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(190, 186);
            this.valuesListBox.TabIndex = 12;
            // 
            // nodeToFindLabel
            // 
            this.nodeToFindLabel.AutoSize = true;
            this.nodeToFindLabel.Location = new System.Drawing.Point(400, 15);
            this.nodeToFindLabel.Name = "nodeToFindLabel";
            this.nodeToFindLabel.Size = new System.Drawing.Size(68, 13);
            this.nodeToFindLabel.TabIndex = 14;
            this.nodeToFindLabel.Text = "Node to find:";
            // 
            // nodeTextBox
            // 
            this.nodeTextBox.Location = new System.Drawing.Point(474, 12);
            this.nodeTextBox.Name = "nodeTextBox";
            this.nodeTextBox.Size = new System.Drawing.Size(232, 20);
            this.nodeTextBox.TabIndex = 13;
            this.nodeTextBox.Text = "MTConnect Device.MTConnect WebDevice";
            // 
            // nodeChildrenLabel
            // 
            this.nodeChildrenLabel.AutoSize = true;
            this.nodeChildrenLabel.Location = new System.Drawing.Point(400, 57);
            this.nodeChildrenLabel.Name = "nodeChildrenLabel";
            this.nodeChildrenLabel.Size = new System.Drawing.Size(73, 13);
            this.nodeChildrenLabel.TabIndex = 15;
            this.nodeChildrenLabel.Text = "Node children";
            // 
            // childrenListBox
            // 
            this.childrenListBox.FormattingEnabled = true;
            this.childrenListBox.Location = new System.Drawing.Point(342, 135);
            this.childrenListBox.Name = "childrenListBox";
            this.childrenListBox.Size = new System.Drawing.Size(164, 186);
            this.childrenListBox.TabIndex = 16;
            // 
            // refreshButton2
            // 
            this.refreshButton2.Location = new System.Drawing.Point(434, 327);
            this.refreshButton2.Name = "refreshButton2";
            this.refreshButton2.Size = new System.Drawing.Size(72, 23);
            this.refreshButton2.TabIndex = 17;
            this.refreshButton2.Text = "Select";
            this.refreshButton2.UseVisualStyleBackColor = true;
            this.refreshButton2.Click += new System.EventHandler(this.refreshButton2_Click);
            // 
            // grandChildrenListBox
            // 
            this.grandChildrenListBox.FormattingEnabled = true;
            this.grandChildrenListBox.Location = new System.Drawing.Point(523, 135);
            this.grandChildrenListBox.Name = "grandChildrenListBox";
            this.grandChildrenListBox.Size = new System.Drawing.Size(183, 186);
            this.grandChildrenListBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grandChildrenListBox);
            this.Controls.Add(this.refreshButton2);
            this.Controls.Add(this.childrenListBox);
            this.Controls.Add(this.nodeChildrenLabel);
            this.Controls.Add(this.nodeToFindLabel);
            this.Controls.Add(this.nodeTextBox);
            this.Controls.Add(this.valuesListBox);
            this.Controls.Add(this.findNodesButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nodeListBox);
            this.Controls.Add(this.connStatusLabel2);
            this.Controls.Add(this.connStatusLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "OPC UA client mock-up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label connStatusLabel;
        private System.Windows.Forms.Label connStatusLabel2;
        private System.Windows.Forms.ListBox nodeListBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button findNodesButton;
        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.Label nodeToFindLabel;
        private System.Windows.Forms.TextBox nodeTextBox;
        private System.Windows.Forms.Label nodeChildrenLabel;
        private System.Windows.Forms.ListBox childrenListBox;
        private System.Windows.Forms.Button refreshButton2;
        private System.Windows.Forms.ListBox grandChildrenListBox;
        private System.Windows.Forms.Button button1;
    }
}

