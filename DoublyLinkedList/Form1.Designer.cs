namespace DoublyLinkedList
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
            this.Serialization_button = new System.Windows.Forms.Button();
            this.Deserialization_button = new System.Windows.Forms.Button();
            this.path_textBox = new System.Windows.Forms.TextBox();
            this.Save_changes_button = new System.Windows.Forms.Button();
            this.Refresh_window_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNode_button
            // 
            this.addNode_button.Location = new System.Drawing.Point(77, 62);
            this.addNode_button.Name = "addNode_button";
            this.addNode_button.Size = new System.Drawing.Size(90, 90);
            this.addNode_button.TabIndex = 1;
            this.addNode_button.Text = "+";
            this.addNode_button.UseVisualStyleBackColor = true;
            this.addNode_button.Click += new System.EventHandler(this.addNode_button_Click);
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(76, 44);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(38, 15);
            this.count_label.TabIndex = 2;
            this.count_label.Text = "label1";
            // 
            // list_textBox
            // 
            this.list_textBox.Location = new System.Drawing.Point(248, 12);
            this.list_textBox.Multiline = true;
            this.list_textBox.Name = "list_textBox";
            this.list_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.list_textBox.Size = new System.Drawing.Size(223, 406);
            this.list_textBox.TabIndex = 3;
            // 
            // Serialization_button
            // 
            this.Serialization_button.Location = new System.Drawing.Point(12, 375);
            this.Serialization_button.Name = "Serialization_button";
            this.Serialization_button.Size = new System.Drawing.Size(102, 43);
            this.Serialization_button.TabIndex = 4;
            this.Serialization_button.Text = "Serialization";
            this.Serialization_button.UseVisualStyleBackColor = true;
            this.Serialization_button.Click += new System.EventHandler(this.Serialization_button_Click);
            // 
            // Deserialization_button
            // 
            this.Deserialization_button.Location = new System.Drawing.Point(133, 375);
            this.Deserialization_button.Name = "Deserialization_button";
            this.Deserialization_button.Size = new System.Drawing.Size(102, 43);
            this.Deserialization_button.TabIndex = 5;
            this.Deserialization_button.Text = "Deserialization";
            this.Deserialization_button.UseVisualStyleBackColor = true;
            this.Deserialization_button.Click += new System.EventHandler(this.Deserialization_button_Click);
            // 
            // path_textBox
            // 
            this.path_textBox.Location = new System.Drawing.Point(12, 345);
            this.path_textBox.Name = "path_textBox";
            this.path_textBox.Size = new System.Drawing.Size(223, 23);
            this.path_textBox.TabIndex = 6;
            this.path_textBox.Text = "C:\\temp\\MyTest.txt";
            // 
            // Save_changes_button
            // 
            this.Save_changes_button.Location = new System.Drawing.Point(57, 213);
            this.Save_changes_button.Name = "Save_changes_button";
            this.Save_changes_button.Size = new System.Drawing.Size(130, 34);
            this.Save_changes_button.TabIndex = 7;
            this.Save_changes_button.Text = "Save changes";
            this.Save_changes_button.UseVisualStyleBackColor = true;
            this.Save_changes_button.Click += new System.EventHandler(this.Save_changes_button_Click);
            // 
            // Refresh_window_button
            // 
            this.Refresh_window_button.Location = new System.Drawing.Point(57, 253);
            this.Refresh_window_button.Name = "Refresh_window_button";
            this.Refresh_window_button.Size = new System.Drawing.Size(130, 34);
            this.Refresh_window_button.TabIndex = 8;
            this.Refresh_window_button.Text = "Refresh window";
            this.Refresh_window_button.UseVisualStyleBackColor = true;
            this.Refresh_window_button.Click += new System.EventHandler(this.Refresh_window_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 430);
            this.Controls.Add(this.Refresh_window_button);
            this.Controls.Add(this.Save_changes_button);
            this.Controls.Add(this.path_textBox);
            this.Controls.Add(this.Deserialization_button);
            this.Controls.Add(this.Serialization_button);
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
        private Button Serialization_button;
        private Button Deserialization_button;
        private TextBox path_textBox;
        private Button Save_changes_button;
        private Button Refresh_window_button;
    }
}