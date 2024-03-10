namespace ParkingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gradientPanel1 = new gradientPanel();
            label3 = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            loginButton = new Button();
            textBox1 = new TextBox();
            passwordLabel = new Label();
            userTextBox = new TextBox();
            usernameLabel = new Label();
            titleLabel1 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 0F;
            gradientPanel1.BackColor = Color.Silver;
            gradientPanel1.BottomColor = Color.Gray;
            gradientPanel1.Controls.Add(label3);
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(pictureBox4);
            gradientPanel1.Controls.Add(loginButton);
            gradientPanel1.Controls.Add(textBox1);
            gradientPanel1.Controls.Add(passwordLabel);
            gradientPanel1.Controls.Add(userTextBox);
            gradientPanel1.Controls.Add(usernameLabel);
            gradientPanel1.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gradientPanel1.Location = new Point(674, -1);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(592, 683);
            gradientPanel1.TabIndex = 0;
            gradientPanel1.TopColor = Color.Black;
            gradientPanel1.Paint += gradientPanel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(60, 462);
            label3.Name = "label3";
            label3.Size = new Size(0, 16);
            label3.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(60, 354);
            label2.Name = "label2";
            label2.Size = new Size(0, 16);
            label2.TabIndex = 11;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(195, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(217, 203);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginButton.BackColor = Color.FromArgb(0, 0, 0, 1);
            loginButton.Cursor = Cursors.Hand;
            loginButton.Font = new Font("Ebrima", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            loginButton.Location = new Point(255, 521);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(82, 32);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Ebrima", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(60, 429);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '•';
            textBox1.Size = new Size(469, 28);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged_2;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = SystemColors.ControlLight;
            passwordLabel.Location = new Point(60, 401);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(81, 21);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // userTextBox
            // 
            userTextBox.Font = new Font("Ebrima", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTextBox.ForeColor = SystemColors.WindowText;
            userTextBox.Location = new Point(60, 323);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(469, 28);
            userTextBox.TabIndex = 1;
            userTextBox.TextChanged += textBox1_TextChanged_1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = SystemColors.ControlLight;
            usernameLabel.Location = new Point(60, 299);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(87, 21);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            usernameLabel.Click += label1_Click;
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.BackColor = Color.Transparent;
            titleLabel1.Font = new Font("Nirmala UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel1.ForeColor = SystemColors.ButtonFace;
            titleLabel1.Location = new Point(12, 422);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new Size(311, 130);
            titleLabel1.TabIndex = 5;
            titleLabel1.Text = "Welcome to \r\nPark n' Click";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(24, 563);
            label1.Name = "label1";
            label1.Size = new Size(210, 19);
            label1.TabIndex = 6;
            label1.Text = "Your trusted parking spot. ";
            label1.Click += label1_Click_3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(627, 640);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 29);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(579, 640);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 29);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(316, 496);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 56);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(titleLabel1);
            Controls.Add(gradientPanel1);
            Controls.Add(pictureBox3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Park n' Click";
            TopMost = true;
            Load += Form1_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public gradientPanel gradientPanel1;
        public Label usernameLabel;
        public TextBox userTextBox;
        public Button loginButton;
        public TextBox textBox1;
        public Label passwordLabel;
        public Label titleLabel1;
        public Label label1;
        public PictureBox pictureBox1;
        public PictureBox pictureBox2;
        public PictureBox pictureBox3;
        public PictureBox pictureBox4;
        public Label label2;
        public Label label3;
    }
}
