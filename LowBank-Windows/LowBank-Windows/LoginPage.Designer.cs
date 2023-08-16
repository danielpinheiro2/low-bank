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
            pictureBox2 = new PictureBox();
            customButton1 = new CustomButton();
            customButton2 = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(204, 232);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 50);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Gold;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.Location = new Point(83, 323);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(120, 40);
            customButton1.TabIndex = 4;
            customButton1.Text = "Login";
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.Gold;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            customButton2.Location = new Point(254, 323);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(120, 40);
            customButton2.TabIndex = 5;
            customButton2.Text = "Cadastrar";
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(469, 398);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "LoginPage";
            Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CustomButton customButton1;
        private CustomButton customButton2;
    }
}