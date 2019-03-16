namespace BryceGrahamProject4
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
            this.checkMemoryButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.displayDoubleLinkedListButton = new System.Windows.Forms.Button();
            this.prevNodeButton = new System.Windows.Forms.Button();
            this.nextNodeButton = new System.Windows.Forms.Button();
            this.deleteCurrentNodeButton = new System.Windows.Forms.Button();
            this.addNodeButton = new System.Windows.Forms.Button();
            this.addNodeTextBox = new System.Windows.Forms.TextBox();
            this.currentNodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createDllButton = new System.Windows.Forms.Button();
            this.listSizeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkMemoryButton
            // 
            this.checkMemoryButton.Enabled = false;
            this.checkMemoryButton.Location = new System.Drawing.Point(45, 31);
            this.checkMemoryButton.Name = "checkMemoryButton";
            this.checkMemoryButton.Size = new System.Drawing.Size(118, 23);
            this.checkMemoryButton.TabIndex = 7;
            this.checkMemoryButton.Text = "Check Memory";
            this.checkMemoryButton.UseVisualStyleBackColor = true;
            this.checkMemoryButton.Click += new System.EventHandler(this.testMemoryButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(45, 89);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(385, 280);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // displayDoubleLinkedListButton
            // 
            this.displayDoubleLinkedListButton.Enabled = false;
            this.displayDoubleLinkedListButton.Location = new System.Drawing.Point(169, 31);
            this.displayDoubleLinkedListButton.Name = "displayDoubleLinkedListButton";
            this.displayDoubleLinkedListButton.Size = new System.Drawing.Size(186, 23);
            this.displayDoubleLinkedListButton.TabIndex = 8;
            this.displayDoubleLinkedListButton.Text = "Display Double Linked List Values";
            this.displayDoubleLinkedListButton.UseVisualStyleBackColor = true;
            this.displayDoubleLinkedListButton.Click += new System.EventHandler(this.displayDoubleLinkedListButton_Click);
            // 
            // prevNodeButton
            // 
            this.prevNodeButton.Enabled = false;
            this.prevNodeButton.Location = new System.Drawing.Point(582, 244);
            this.prevNodeButton.Name = "prevNodeButton";
            this.prevNodeButton.Size = new System.Drawing.Size(107, 23);
            this.prevNodeButton.TabIndex = 6;
            this.prevNodeButton.Text = "Previous Node";
            this.prevNodeButton.UseVisualStyleBackColor = true;
            this.prevNodeButton.Click += new System.EventHandler(this.prevNodeButton_Click);
            // 
            // nextNodeButton
            // 
            this.nextNodeButton.Enabled = false;
            this.nextNodeButton.Location = new System.Drawing.Point(582, 215);
            this.nextNodeButton.Name = "nextNodeButton";
            this.nextNodeButton.Size = new System.Drawing.Size(75, 23);
            this.nextNodeButton.TabIndex = 5;
            this.nextNodeButton.Text = "Next Node";
            this.nextNodeButton.UseVisualStyleBackColor = true;
            this.nextNodeButton.Click += new System.EventHandler(this.nextNodeButton_Click);
            // 
            // deleteCurrentNodeButton
            // 
            this.deleteCurrentNodeButton.Enabled = false;
            this.deleteCurrentNodeButton.Location = new System.Drawing.Point(582, 186);
            this.deleteCurrentNodeButton.Name = "deleteCurrentNodeButton";
            this.deleteCurrentNodeButton.Size = new System.Drawing.Size(121, 23);
            this.deleteCurrentNodeButton.TabIndex = 4;
            this.deleteCurrentNodeButton.Text = "Delete Current Node";
            this.deleteCurrentNodeButton.UseVisualStyleBackColor = true;
            this.deleteCurrentNodeButton.Click += new System.EventHandler(this.deleteCurrentNodeButton_Click);
            // 
            // addNodeButton
            // 
            this.addNodeButton.Enabled = false;
            this.addNodeButton.Location = new System.Drawing.Point(582, 157);
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Size = new System.Drawing.Size(75, 23);
            this.addNodeButton.TabIndex = 3;
            this.addNodeButton.Text = "Add Node";
            this.addNodeButton.UseVisualStyleBackColor = true;
            this.addNodeButton.Click += new System.EventHandler(this.addNodeButton_Click);
            // 
            // addNodeTextBox
            // 
            this.addNodeTextBox.Location = new System.Drawing.Point(467, 157);
            this.addNodeTextBox.Name = "addNodeTextBox";
            this.addNodeTextBox.Size = new System.Drawing.Size(23, 20);
            this.addNodeTextBox.TabIndex = 2;
            // 
            // currentNodeTextBox
            // 
            this.currentNodeTextBox.Location = new System.Drawing.Point(467, 212);
            this.currentNodeTextBox.Name = "currentNodeTextBox";
            this.currentNodeTextBox.ReadOnly = true;
            this.currentNodeTextBox.Size = new System.Drawing.Size(23, 20);
            this.currentNodeTextBox.TabIndex = 8;
            this.currentNodeTextBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Node";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current Node";
            // 
            // createDllButton
            // 
            this.createDllButton.Location = new System.Drawing.Point(582, 86);
            this.createDllButton.Name = "createDllButton";
            this.createDllButton.Size = new System.Drawing.Size(149, 23);
            this.createDllButton.TabIndex = 1;
            this.createDllButton.Text = "Create Double Linked List";
            this.createDllButton.UseVisualStyleBackColor = true;
            this.createDllButton.Click += new System.EventHandler(this.createDllButton_Click);
            // 
            // listSizeTextBox
            // 
            this.listSizeTextBox.Location = new System.Drawing.Point(467, 89);
            this.listSizeTextBox.Name = "listSizeTextBox";
            this.listSizeTextBox.Size = new System.Drawing.Size(75, 20);
            this.listSizeTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "List size (default 10)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 419);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listSizeTextBox);
            this.Controls.Add(this.createDllButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentNodeTextBox);
            this.Controls.Add(this.addNodeTextBox);
            this.Controls.Add(this.addNodeButton);
            this.Controls.Add(this.deleteCurrentNodeButton);
            this.Controls.Add(this.nextNodeButton);
            this.Controls.Add(this.prevNodeButton);
            this.Controls.Add(this.displayDoubleLinkedListButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkMemoryButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkMemoryButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button displayDoubleLinkedListButton;
        private System.Windows.Forms.Button prevNodeButton;
        private System.Windows.Forms.Button nextNodeButton;
        private System.Windows.Forms.Button deleteCurrentNodeButton;
        private System.Windows.Forms.Button addNodeButton;
        private System.Windows.Forms.TextBox addNodeTextBox;
        private System.Windows.Forms.TextBox currentNodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createDllButton;
        private System.Windows.Forms.TextBox listSizeTextBox;
        private System.Windows.Forms.Label label3;
    }
}

