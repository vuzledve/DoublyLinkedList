﻿namespace DoublyLinkedList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addNode_button = new System.Windows.Forms.Button();
            this.count_label = new System.Windows.Forms.Label();
            this.list_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addNode_button
            // 
            this.addNode_button.Location = new System.Drawing.Point(82, 290);
            this.addNode_button.Name = "addNode_button";
            this.addNode_button.Size = new System.Drawing.Size(63, 45);
            this.addNode_button.TabIndex = 1;
            this.addNode_button.Text = "+";
            this.addNode_button.UseVisualStyleBackColor = true;
            this.addNode_button.Click += new System.EventHandler(this.addNode_button_Click);
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(163, 276);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(38, 15);
            this.count_label.TabIndex = 2;
            this.count_label.Text = "label1";
            // 
            // list_textBox
            // 
            this.list_textBox.Location = new System.Drawing.Point(12, 12);
            this.list_textBox.Multiline = true;
            this.list_textBox.Name = "list_textBox";
            this.list_textBox.ReadOnly = true;
            this.list_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.list_textBox.Size = new System.Drawing.Size(223, 261);
            this.list_textBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 421);
            this.Controls.Add(this.list_textBox);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.addNode_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button addNode_button;
        private Label count_label;
        private TextBox list_textBox;
    }
}