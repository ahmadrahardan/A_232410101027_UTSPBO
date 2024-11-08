namespace UTS_PBO.Views
{
    partial class UserControlLogin
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
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(124, 116);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(283, 27);
            UsernameBox.TabIndex = 3;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(124, 234);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(283, 27);
            PasswordBox.TabIndex = 4;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(124, 78);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(75, 20);
            UsernameLabel.TabIndex = 5;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(124, 189);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(70, 20);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(433, 340);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Masuk";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // UserControlLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LoginButton);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Name = "UserControlLogin";
            Size = new Size(700, 500);
            Load += UserControlLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Button LoginButton;
    }
}
