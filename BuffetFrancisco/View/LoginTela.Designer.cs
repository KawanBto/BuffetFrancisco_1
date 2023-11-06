namespace BuffetFrancisco.View
{
    partial class LoginTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTela));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_acessar = new Button();
            txt_senha = new TextBox();
            label2 = new Label();
            txt_usuario = new TextBox();
            label3 = new Label();
            btn_sair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._5545071;
            pictureBox1.Location = new Point(23, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(358, 94);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 1;
            label1.Text = "Usuário";
            // 
            // btn_acessar
            // 
            btn_acessar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_acessar.Location = new Point(460, 260);
            btn_acessar.Name = "btn_acessar";
            btn_acessar.Size = new Size(75, 23);
            btn_acessar.TabIndex = 2;
            btn_acessar.Text = "Acessar";
            btn_acessar.UseVisualStyleBackColor = true;
            btn_acessar.Click += btn_acessar_Click;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(358, 216);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(279, 23);
            txt_senha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(358, 187);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(358, 128);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(279, 23);
            txt_usuario.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(358, 27);
            label3.Name = "label3";
            label3.Size = new Size(278, 33);
            label3.TabIndex = 6;
            label3.Text = "Buffet Francisco";
            // 
            // btn_sair
            // 
            btn_sair.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sair.Location = new Point(23, 303);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(46, 23);
            btn_sair.TabIndex = 7;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // LoginTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(688, 338);
            Controls.Add(btn_sair);
            Controls.Add(label3);
            Controls.Add(txt_usuario);
            Controls.Add(label2);
            Controls.Add(txt_senha);
            Controls.Add(btn_acessar);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginTela";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_acessar;
        private TextBox txt_senha;
        private Label label2;
        private TextBox txt_usuario;
        private Label label3;
        private Button btn_sair;
    }
}