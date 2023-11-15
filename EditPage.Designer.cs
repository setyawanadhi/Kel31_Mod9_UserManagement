namespace UserManagement
{
    partial class EditPage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EditUsername = new TextBox();
            EditPassword = new TextBox();
            SubmitEdit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(322, 68);
            label1.Name = "label1";
            label1.Size = new Size(123, 37);
            label1.TabIndex = 0;
            label1.Text = "Edit User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(226, 153);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(232, 224);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // EditUsername
            // 
            EditUsername.Location = new Point(409, 158);
            EditUsername.Name = "EditUsername";
            EditUsername.Size = new Size(100, 23);
            EditUsername.TabIndex = 3;
            // 
            // EditPassword
            // 
            EditPassword.Location = new Point(409, 229);
            EditPassword.Name = "EditPassword";
            EditPassword.Size = new Size(100, 23);
            EditPassword.TabIndex = 4;
            // 
            // SubmitEdit
            // 
            SubmitEdit.Location = new Point(250, 304);
            SubmitEdit.Name = "SubmitEdit";
            SubmitEdit.Size = new Size(75, 23);
            SubmitEdit.TabIndex = 5;
            SubmitEdit.Text = "Submit";
            SubmitEdit.UseVisualStyleBackColor = true;
            SubmitEdit.Click += SubmitEdit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(409, 304);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(SubmitEdit);
            Controls.Add(EditPassword);
            Controls.Add(EditUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditPage";
            Text = "EditPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EditUsername;
        private TextBox EditPassword;
        private Button SubmitEdit;
        private Button button1;
    }
}