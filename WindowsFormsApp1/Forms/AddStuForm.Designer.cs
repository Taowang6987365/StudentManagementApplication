
namespace StudentManagerApp
{
    partial class AddStuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StuIDTextBox = new System.Windows.Forms.TextBox();
            this.StuNameTextBox = new System.Windows.Forms.TextBox();
            this.MajorTextBox = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.GenderTextBox = new System.Windows.Forms.ComboBox();
            this.groupBoxAdd2 = new System.Windows.Forms.GroupBox();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxAdd2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Major";
            // 
            // StuIDTextBox
            // 
            this.StuIDTextBox.Location = new System.Drawing.Point(179, 20);
            this.StuIDTextBox.Name = "StuIDTextBox";
            this.StuIDTextBox.Size = new System.Drawing.Size(125, 27);
            this.StuIDTextBox.TabIndex = 4;
            // 
            // StuNameTextBox
            // 
            this.StuNameTextBox.Location = new System.Drawing.Point(179, 75);
            this.StuNameTextBox.Name = "StuNameTextBox";
            this.StuNameTextBox.Size = new System.Drawing.Size(125, 27);
            this.StuNameTextBox.TabIndex = 5;
            // 
            // MajorTextBox
            // 
            this.MajorTextBox.Location = new System.Drawing.Point(179, 187);
            this.MajorTextBox.Name = "MajorTextBox";
            this.MajorTextBox.Size = new System.Drawing.Size(125, 27);
            this.MajorTextBox.TabIndex = 7;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(0, 26);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(94, 29);
            this.okBtn.TabIndex = 8;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(127, 26);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(94, 29);
            this.resetBtn.TabIndex = 9;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(245, 26);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(94, 29);
            this.quitBtn.TabIndex = 10;
            this.quitBtn.Text = "Cancel";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.GenderTextBox);
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Controls.Add(this.label2);
            this.groupBoxAdd.Controls.Add(this.label3);
            this.groupBoxAdd.Controls.Add(this.label4);
            this.groupBoxAdd.Controls.Add(this.MajorTextBox);
            this.groupBoxAdd.Controls.Add(this.StuIDTextBox);
            this.groupBoxAdd.Controls.Add(this.StuNameTextBox);
            this.groupBoxAdd.Location = new System.Drawing.Point(75, 21);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(339, 240);
            this.groupBoxAdd.TabIndex = 11;
            this.groupBoxAdd.TabStop = false;
            // 
            // GenderTextBox
            // 
            this.GenderTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderTextBox.FormattingEnabled = true;
            this.GenderTextBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderTextBox.Location = new System.Drawing.Point(179, 130);
            this.GenderTextBox.Name = "GenderTextBox";
            this.GenderTextBox.Size = new System.Drawing.Size(125, 28);
            this.GenderTextBox.TabIndex = 8;
            // 
            // groupBoxAdd2
            // 
            this.groupBoxAdd2.Controls.Add(this.okBtn);
            this.groupBoxAdd2.Controls.Add(this.resetBtn);
            this.groupBoxAdd2.Controls.Add(this.quitBtn);
            this.groupBoxAdd2.Location = new System.Drawing.Point(75, 283);
            this.groupBoxAdd2.Name = "groupBoxAdd2";
            this.groupBoxAdd2.Size = new System.Drawing.Size(339, 85);
            this.groupBoxAdd2.TabIndex = 12;
            this.groupBoxAdd2.TabStop = false;
            // 
            // AddStuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 432);
            this.Controls.Add(this.groupBoxAdd2);
            this.Controls.Add(this.groupBoxAdd);
            this.Name = "AddStuForm";
            this.Text = "AddStudent";
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxAdd2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StuIDTextBox;
        private System.Windows.Forms.TextBox StuNameTextBox;
        private System.Windows.Forms.TextBox MajorTextBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.GroupBox groupBoxAdd2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox GenderTextBox;
    }
}