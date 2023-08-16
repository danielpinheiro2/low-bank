namespace LowBank_Windows
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            pictureBox1 = new PictureBox();
            avatarImage = new PictureBox();
            LoginButton = new CustomButton();
            CadastroButtom = new CustomButton();
            cpfTextBox = new TextBox();
            senhaTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatarImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 210);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // avatarImage
            // 
            avatarImage.Image = (Image)resources.GetObject("avatarImage.Image");
            avatarImage.Location = new Point(204, 232);
            avatarImage.Name = "avatarImage";
            avatarImage.Size = new Size(55, 50);
            avatarImage.TabIndex = 3;
            avatarImage.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Gold;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.Location = new Point(83, 323);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(120, 40);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += customButton1_Click;
            // 
            // CadastroButtom
            // 
            CadastroButtom.BackColor = Color.Gold;
            CadastroButtom.FlatAppearance.BorderSize = 0;
            CadastroButtom.FlatStyle = FlatStyle.Flat;
            CadastroButtom.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CadastroButtom.Location = new Point(254, 323);
            CadastroButtom.Name = "CadastroButtom";
            CadastroButtom.Size = new Size(120, 40);
            CadastroButtom.TabIndex = 5;
            CadastroButtom.Text = "Cadastrar";
            CadastroButtom.UseVisualStyleBackColor = false;
            CadastroButtom.Click += customButton2_Click;
            // 
            // cpfTextBox
            // 
            cpfTextBox.Location = new Point(181, 229);
            cpfTextBox.Name = "cpfTextBox";
            cpfTextBox.PlaceholderText = "CPF";
            cpfTextBox.Size = new Size(122, 23);
            cpfTextBox.TabIndex = 6;
            cpfTextBox.Visible = false;
            // 
            // senhaTextBox
            // 
            senhaTextBox.Location = new Point(181, 265);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.PlaceholderText = "Senha";
            senhaTextBox.Size = new Size(122, 23);
            senhaTextBox.TabIndex = 7;
            senhaTextBox.UseSystemPasswordChar = true;
            senhaTextBox.Visible = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(469, 398);
            Controls.Add(senhaTextBox);
            Controls.Add(cpfTextBox);
            Controls.Add(CadastroButtom);
            Controls.Add(LoginButton);
            Controls.Add(avatarImage);
            Controls.Add(pictureBox1);
            Name = "LoginPage";
            Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)avatarImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox avatarImage;
        private CustomButton LoginButton;
        private CustomButton CadastroButtom;
        private TextBox cpfTextBox;
        private TextBox senhaTextBox;
    }
}