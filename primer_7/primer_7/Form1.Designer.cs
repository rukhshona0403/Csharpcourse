namespace primer_7
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
            MainPanel = new Panel();
            ButtonLogin = new Button();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            CloseButton = new Label();
            label1 = new Label();
            loginField = new TextBox();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainPanel.BackColor = Color.FromArgb(220, 44, 103);
            MainPanel.BackgroundImageLayout = ImageLayout.None;
            MainPanel.Controls.Add(ButtonLogin);
            MainPanel.Controls.Add(passField);
            MainPanel.Controls.Add(pictureBox2);
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Controls.Add(panel2);
            MainPanel.Controls.Add(loginField);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.ForeColor = SystemColors.ButtonHighlight;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(577, 560);
            MainPanel.TabIndex = 0;
            MainPanel.Paint += panel1_Paint;
            MainPanel.MouseDown += MainPanel_MouseDown;
            MainPanel.MouseMove += MainPanel_MouseMove;
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = Color.FromArgb(48, 59, 142);
            ButtonLogin.Cursor = Cursors.Hand;
            ButtonLogin.FlatAppearance.BorderSize = 0;
            ButtonLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 15, 55);
            ButtonLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 80, 23);
            ButtonLogin.FlatStyle = FlatStyle.Flat;
            ButtonLogin.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonLogin.ForeColor = SystemColors.ButtonHighlight;
            ButtonLogin.Location = new Point(185, 448);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(259, 60);
            ButtonLogin.TabIndex = 5;
            ButtonLogin.Text = "Войти";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // passField
            // 
            passField.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passField.Location = new Point(175, 302);
            passField.Name = "passField";
            passField.Size = new Size(317, 45);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(84, 283);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(84, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(139, 203, 231);
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 142);
            panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CloseButton.Location = new Point(540, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(32, 38);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "x";
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(249, 249, 249);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(577, 142);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginField
            // 
            loginField.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginField.Location = new Point(175, 206);
            loginField.Name = "loginField";
            loginField.Size = new Size(317, 45);
            loginField.TabIndex = 2;
            loginField.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 560);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel panel2;
        private Label label1;
        private Label CloseButton;
        private PictureBox pictureBox1;
        private TextBox loginField;
        private TextBox passField;
        private PictureBox pictureBox2;
        private Button ButtonLogin;
    }
}
