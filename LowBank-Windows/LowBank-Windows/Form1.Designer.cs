namespace LowBank_Windows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PainelFundo = new CustomPanel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            CartaoCredito = new CustomPanel();
            label3 = new Label();
            label2 = new Label();
            button2 = new CustomButton();
            button1 = new CustomButton();
            textoBemVindo = new Label();
            pictureBox1 = new PictureBox();
            PainelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            CartaoCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PainelFundo
            // 
            PainelFundo.ArredondaCantosInferiores = false;
            PainelFundo.BackColor = SystemColors.Window;
            PainelFundo.Controls.Add(label4);
            PainelFundo.Controls.Add(pictureBox2);
            PainelFundo.Controls.Add(CartaoCredito);
            PainelFundo.Controls.Add(button2);
            PainelFundo.Controls.Add(button1);
            PainelFundo.Controls.Add(textoBemVindo);
            PainelFundo.Font = new Font("Cascadia Mono SemiBold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PainelFundo.Location = new Point(0, 125);
            PainelFundo.Name = "PainelFundo";
            PainelFundo.Size = new Size(676, 256);
            PainelFundo.TabIndex = 0;
            PainelFundo.Paint += PainelFundo_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 223);
            label4.Name = "label4";
            label4.Size = new Size(168, 18);
            label4.TabIndex = 4;
            label4.Text = "Criado por Danielzin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // CartaoCredito
            // 
            CartaoCredito.ArredondaCantosInferiores = true;
            CartaoCredito.BackColor = Color.FromArgb(59, 70, 241);
            CartaoCredito.Controls.Add(label3);
            CartaoCredito.Controls.Add(label2);
            CartaoCredito.ForeColor = Color.FromArgb(59, 70, 241);
            CartaoCredito.Location = new Point(364, 56);
            CartaoCredito.Name = "CartaoCredito";
            CartaoCredito.Size = new Size(300, 180);
            CartaoCredito.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Mono SemiBold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 67);
            label3.Name = "label3";
            label3.Size = new Size(207, 35);
            label3.TabIndex = 4;
            label3.Text = "R$ 10.000,00";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 28);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 3;
            label2.Text = "Seu saldo: ";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(199, 80);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 2;
            button2.Text = "Transferir";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(38, 80);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 1;
            button1.Text = "Depositar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textoBemVindo
            // 
            textoBemVindo.AutoSize = true;
            textoBemVindo.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textoBemVindo.Location = new Point(83, 28);
            textoBemVindo.Name = "textoBemVindo";
            textoBemVindo.Size = new Size(152, 18);
            textoBemVindo.TabIndex = 0;
            textoBemVindo.Text = "Bem vindo, Daniel!";
            textoBemVindo.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 92);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(676, 373);
            Controls.Add(pictureBox1);
            Controls.Add(PainelFundo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            PainelFundo.ResumeLayout(false);
            PainelFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            CartaoCredito.ResumeLayout(false);
            CartaoCredito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label textoBemVindo;
        private CustomButton button2;
        private CustomButton button1;
        private CustomPanel PainelFundo;
        private CustomPanel CartaoCredito;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
    }
}