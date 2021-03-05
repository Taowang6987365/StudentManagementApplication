
namespace StudentManagerApp
{
    partial class MenuForm
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
            this.title = new System.Windows.Forms.Label();
            this.AddStuBtn = new System.Windows.Forms.RadioButton();
            this.SearchStuBtn = new System.Windows.Forms.RadioButton();
            this.DelStuBtn = new System.Windows.Forms.RadioButton();
            this.ModiStuBtn = new System.Windows.Forms.RadioButton();
            this.DispAllBtn = new System.Windows.Forms.RadioButton();
            this.DelAllBtn = new System.Windows.Forms.RadioButton();
            this.OkBtn = new System.Windows.Forms.Button();
            this.MainExitBtn = new System.Windows.Forms.Button();
            this.MenuGroupBox = new System.Windows.Forms.GroupBox();
            this.MenuGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(23, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(451, 28);
            this.title.TabIndex = 0;
            this.title.Text = "Welcome to Student Management Application";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddStuBtn
            // 
            this.AddStuBtn.AutoSize = true;
            this.AddStuBtn.Location = new System.Drawing.Point(6, 26);
            this.AddStuBtn.Name = "AddStuBtn";
            this.AddStuBtn.Size = new System.Drawing.Size(117, 24);
            this.AddStuBtn.TabIndex = 8;
            this.AddStuBtn.TabStop = true;
            this.AddStuBtn.Text = "Add Student ";
            this.AddStuBtn.UseVisualStyleBackColor = true;
            // 
            // SearchStuBtn
            // 
            this.SearchStuBtn.AutoSize = true;
            this.SearchStuBtn.Location = new System.Drawing.Point(6, 56);
            this.SearchStuBtn.Name = "SearchStuBtn";
            this.SearchStuBtn.Size = new System.Drawing.Size(129, 24);
            this.SearchStuBtn.TabIndex = 9;
            this.SearchStuBtn.TabStop = true;
            this.SearchStuBtn.Text = "Search Student";
            this.SearchStuBtn.UseVisualStyleBackColor = true;
            // 
            // DelStuBtn
            // 
            this.DelStuBtn.AutoSize = true;
            this.DelStuBtn.Location = new System.Drawing.Point(6, 86);
            this.DelStuBtn.Name = "DelStuBtn";
            this.DelStuBtn.Size = new System.Drawing.Size(129, 24);
            this.DelStuBtn.TabIndex = 10;
            this.DelStuBtn.TabStop = true;
            this.DelStuBtn.Text = "Delete Student";
            this.DelStuBtn.UseVisualStyleBackColor = true;
            // 
            // ModiStuBtn
            // 
            this.ModiStuBtn.AutoSize = true;
            this.ModiStuBtn.Location = new System.Drawing.Point(6, 116);
            this.ModiStuBtn.Name = "ModiStuBtn";
            this.ModiStuBtn.Size = new System.Drawing.Size(132, 24);
            this.ModiStuBtn.TabIndex = 11;
            this.ModiStuBtn.TabStop = true;
            this.ModiStuBtn.Text = "Modify Student";
            this.ModiStuBtn.UseVisualStyleBackColor = true;
            // 
            // DispAllBtn
            // 
            this.DispAllBtn.AutoSize = true;
            this.DispAllBtn.Location = new System.Drawing.Point(6, 146);
            this.DispAllBtn.Name = "DispAllBtn";
            this.DispAllBtn.Size = new System.Drawing.Size(162, 24);
            this.DispAllBtn.TabIndex = 12;
            this.DispAllBtn.TabStop = true;
            this.DispAllBtn.Text = "Display All Students";
            this.DispAllBtn.UseVisualStyleBackColor = true;
            // 
            // DelAllBtn
            // 
            this.DelAllBtn.AutoSize = true;
            this.DelAllBtn.Location = new System.Drawing.Point(6, 176);
            this.DelAllBtn.Name = "DelAllBtn";
            this.DelAllBtn.Size = new System.Drawing.Size(157, 24);
            this.DelAllBtn.TabIndex = 13;
            this.DelAllBtn.TabStop = true;
            this.DelAllBtn.Text = "Delete All Students";
            this.DelAllBtn.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(117, 309);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(94, 29);
            this.OkBtn.TabIndex = 15;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // MainExitBtn
            // 
            this.MainExitBtn.Location = new System.Drawing.Point(314, 309);
            this.MainExitBtn.Name = "MainExitBtn";
            this.MainExitBtn.Size = new System.Drawing.Size(94, 29);
            this.MainExitBtn.TabIndex = 16;
            this.MainExitBtn.Text = "Exit";
            this.MainExitBtn.UseVisualStyleBackColor = true;
            this.MainExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MenuGroupBox
            // 
            this.MenuGroupBox.Controls.Add(this.AddStuBtn);
            this.MenuGroupBox.Controls.Add(this.SearchStuBtn);
            this.MenuGroupBox.Controls.Add(this.DelStuBtn);
            this.MenuGroupBox.Controls.Add(this.DelAllBtn);
            this.MenuGroupBox.Controls.Add(this.ModiStuBtn);
            this.MenuGroupBox.Controls.Add(this.DispAllBtn);
            this.MenuGroupBox.Location = new System.Drawing.Point(117, 61);
            this.MenuGroupBox.Name = "MenuGroupBox";
            this.MenuGroupBox.Size = new System.Drawing.Size(291, 219);
            this.MenuGroupBox.TabIndex = 17;
            this.MenuGroupBox.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 457);
            this.Controls.Add(this.MenuGroupBox);
            this.Controls.Add(this.MainExitBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.title);
            this.Name = "MenuForm";
            this.Text = "StudentManager";
            this.MenuGroupBox.ResumeLayout(false);
            this.MenuGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RadioButton AddStuBtn;
        private System.Windows.Forms.RadioButton SearchStuBtn;
        private System.Windows.Forms.RadioButton DelStuBtn;
        private System.Windows.Forms.RadioButton ModiStuBtn;
        private System.Windows.Forms.RadioButton DispAllBtn;
        private System.Windows.Forms.RadioButton DelAllBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button MainExitBtn;
        private System.Windows.Forms.GroupBox MenuGroupBox;
    }
}