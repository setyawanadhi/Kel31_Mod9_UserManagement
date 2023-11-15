namespace UserManagement
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UsernameComponent = new Label();
            EditButtonUser = new Button();
            DeleteButtonUser = new Button();
            SuspendLayout();
            // 
            // UsernameComponent
            // 
            UsernameComponent.AutoSize = true;
            UsernameComponent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameComponent.Location = new Point(45, 25);
            UsernameComponent.Name = "UsernameComponent";
            UsernameComponent.Size = new Size(52, 21);
            UsernameComponent.TabIndex = 0;
            UsernameComponent.Text = "label1";
            // 
            // EditButtonUser
            // 
            EditButtonUser.Location = new Point(36, 71);
            EditButtonUser.Name = "EditButtonUser";
            EditButtonUser.Size = new Size(75, 23);
            EditButtonUser.TabIndex = 1;
            EditButtonUser.Text = "Edit";
            EditButtonUser.UseVisualStyleBackColor = true;
            EditButtonUser.Click += EditButtonUser_Click;
            // 
            // DeleteButtonUser
            // 
            DeleteButtonUser.Location = new Point(36, 111);
            DeleteButtonUser.Name = "DeleteButtonUser";
            DeleteButtonUser.Size = new Size(75, 23);
            DeleteButtonUser.TabIndex = 2;
            DeleteButtonUser.Text = "Delete";
            DeleteButtonUser.UseVisualStyleBackColor = true;
            DeleteButtonUser.Click += DeleteButtonUser_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(DeleteButtonUser);
            Controls.Add(EditButtonUser);
            Controls.Add(UsernameComponent);
            Name = "UserControl1";
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsernameComponent;
        private Button EditButtonUser;
        private Button DeleteButtonUser;
    }
}
