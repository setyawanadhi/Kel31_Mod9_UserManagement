namespace UserManagement
{
    partial class RegisterForm
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
            UsernameRegister = new TextBox();
            PasswordRegister = new TextBox();
            SubmitRegistration = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(324, 86);
            label1.Name = "label1";
            label1.Size = new Size(112, 37);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(187, 158);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 1;
            label2.Text = "Input Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(187, 223);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 2;
            label3.Text = "Input Password";
            // 
            // UsernameRegister
            // 
            UsernameRegister.Location = new Point(429, 163);
            UsernameRegister.Name = "UsernameRegister";
            UsernameRegister.Size = new Size(100, 23);
            UsernameRegister.TabIndex = 3;
            // 
            // PasswordRegister
            // 
            PasswordRegister.Location = new Point(429, 228);
            PasswordRegister.Name = "PasswordRegister";
            PasswordRegister.Size = new Size(100, 23);
            PasswordRegister.TabIndex = 4;
            // 
            // SubmitRegistration
            // 
            SubmitRegistration.Location = new Point(262, 298);
            SubmitRegistration.Name = "SubmitRegistration";
            SubmitRegistration.Size = new Size(75, 23);
            SubmitRegistration.TabIndex = 5;
            SubmitRegistration.Text = "Submit";
            SubmitRegistration.UseVisualStyleBackColor = true;
            SubmitRegistration.Click += SubmitRegistration_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(415, 298);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 6;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackButton);
            Controls.Add(SubmitRegistration);
            Controls.Add(PasswordRegister);
            Controls.Add(UsernameRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UsernameRegister;
        private TextBox PasswordRegister;
        private Button SubmitRegistration;
        private Button BackButton;
    }
}