namespace BuffetFrancisco.View
{
    partial class TelaFecharVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFecharVenda));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_data = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lbl_valorvenda = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(69, 22);
            label1.Name = "label1";
            label1.Size = new Size(279, 32);
            label1.TabIndex = 0;
            label1.Text = "Francisco Evento LTDA.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(106, 95);
            label2.Name = "label2";
            label2.Size = new Size(205, 21);
            label2.TabIndex = 1;
            label2.Text = "CNPJ: 12.321.958/0001 - 00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(103, 65);
            label3.Name = "label3";
            label3.Size = new Size(219, 21);
            label3.TabIndex = 2;
            label3.Text = "Rua da Alegria, 171 - SBC - SP";
            // 
            // lbl_data
            // 
            lbl_data.AutoSize = true;
            lbl_data.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_data.ForeColor = SystemColors.ControlLightLight;
            lbl_data.Location = new Point(12, 126);
            lbl_data.Name = "lbl_data";
            lbl_data.Size = new Size(94, 21);
            lbl_data.TabIndex = 3;
            lbl_data.Text = "00/00/0000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(167, 126);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 4;
            label5.Text = "235959";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(316, 126);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 5;
            label6.Text = "COD 0001";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(237, 126);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 6;
            label7.Text = "CCF 0001";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(115, 175);
            label8.Name = "label8";
            label8.Size = new Size(45, 21);
            label8.TabIndex = 7;
            label8.Text = "Total:";
            // 
            // lbl_valorvenda
            // 
            lbl_valorvenda.AutoSize = true;
            lbl_valorvenda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_valorvenda.ForeColor = SystemColors.ControlLightLight;
            lbl_valorvenda.Location = new Point(239, 175);
            lbl_valorvenda.Name = "lbl_valorvenda";
            lbl_valorvenda.Size = new Size(72, 21);
            lbl_valorvenda.TabIndex = 8;
            lbl_valorvenda.Text = "R$ 00,00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(115, 215);
            label10.Name = "label10";
            label10.Size = new Size(201, 25);
            label10.TabIndex = 9;
            label10.Text = "Pagamento Recebido";
            // 
            // TelaFecharVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(411, 271);
            Controls.Add(label10);
            Controls.Add(lbl_valorvenda);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbl_data);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaFecharVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaFecharVenda";
            Load += TelaFecharVenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_data;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lbl_valorvenda;
        private Label label10;
    }
}