namespace BuffetFrancisco.View
{
    partial class PDVTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDVTela));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            btn_pastel = new Button();
            btn_coxinha = new Button();
            btn_esfiha = new Button();
            btn_paodequeijo = new Button();
            btn_suco = new Button();
            btn_refri = new Button();
            btn_cafe = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txt_cod = new TextBox();
            btn_add = new Button();
            dataGridViewPDV = new DataGridView();
            Prod = new DataGridViewTextBoxColumn();
            Qt = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Tot = new DataGridViewTextBoxColumn();
            num_qtde = new NumericUpDown();
            label1 = new Label();
            btn_cancelar = new Button();
            btn_finalizar = new Button();
            lbl_vt = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPDV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_qtde).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._5545071;
            pictureBox1.Location = new Point(41, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(406, 24);
            label2.Name = "label2";
            label2.Size = new Size(247, 32);
            label2.TabIndex = 2;
            label2.Text = "BUFFET FRANCISCO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(501, 121);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 3;
            label3.Text = "Código";
            // 
            // btn_pastel
            // 
            btn_pastel.Image = Properties.Resources.Coxinha;
            btn_pastel.Location = new Point(14, 29);
            btn_pastel.Name = "btn_pastel";
            btn_pastel.Size = new Size(75, 69);
            btn_pastel.TabIndex = 4;
            btn_pastel.UseVisualStyleBackColor = true;
            btn_pastel.Click += btn_pastel_Click;
            // 
            // btn_coxinha
            // 
            btn_coxinha.Image = Properties.Resources.Coxinha__2_;
            btn_coxinha.Location = new Point(126, 29);
            btn_coxinha.Name = "btn_coxinha";
            btn_coxinha.Size = new Size(75, 69);
            btn_coxinha.TabIndex = 5;
            btn_coxinha.UseVisualStyleBackColor = true;
            btn_coxinha.Click += btn_coxinha_Click;
            // 
            // btn_esfiha
            // 
            btn_esfiha.Image = Properties.Resources.esfiha;
            btn_esfiha.Location = new Point(14, 104);
            btn_esfiha.Name = "btn_esfiha";
            btn_esfiha.Size = new Size(75, 69);
            btn_esfiha.TabIndex = 6;
            btn_esfiha.UseVisualStyleBackColor = true;
            btn_esfiha.Click += btn_esfiha_Click;
            // 
            // btn_paodequeijo
            // 
            btn_paodequeijo.Image = Properties.Resources.Pão_de_Queijo__2_;
            btn_paodequeijo.Location = new Point(126, 104);
            btn_paodequeijo.Name = "btn_paodequeijo";
            btn_paodequeijo.Size = new Size(75, 69);
            btn_paodequeijo.TabIndex = 7;
            btn_paodequeijo.UseVisualStyleBackColor = true;
            btn_paodequeijo.Click += btn_paodequeijo_Click;
            // 
            // btn_suco
            // 
            btn_suco.Image = Properties.Resources.Sucos;
            btn_suco.Location = new Point(225, 24);
            btn_suco.Name = "btn_suco";
            btn_suco.Size = new Size(75, 69);
            btn_suco.TabIndex = 8;
            btn_suco.UseVisualStyleBackColor = true;
            btn_suco.Click += btn_suco_Click;
            // 
            // btn_refri
            // 
            btn_refri.Image = Properties.Resources.refri;
            btn_refri.Location = new Point(117, 24);
            btn_refri.Name = "btn_refri";
            btn_refri.Size = new Size(75, 69);
            btn_refri.TabIndex = 9;
            btn_refri.UseVisualStyleBackColor = true;
            btn_refri.Click += btn_refri_Click;
            // 
            // btn_cafe
            // 
            btn_cafe.Image = Properties.Resources.Design_sem_nome;
            btn_cafe.Location = new Point(6, 24);
            btn_cafe.Name = "btn_cafe";
            btn_cafe.Size = new Size(75, 69);
            btn_cafe.TabIndex = 10;
            btn_cafe.UseVisualStyleBackColor = true;
            btn_cafe.Click += btn_cafe_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_pastel);
            groupBox1.Controls.Add(btn_coxinha);
            groupBox1.Controls.Add(btn_paodequeijo);
            groupBox1.Controls.Add(btn_esfiha);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(41, 180);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 187);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "PRODUTOS";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_cafe);
            groupBox2.Controls.Add(btn_refri);
            groupBox2.Controls.Add(btn_suco);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(41, 385);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(310, 100);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "BEBIDAS";
            // 
            // txt_cod
            // 
            txt_cod.Location = new Point(486, 149);
            txt_cod.Name = "txt_cod";
            txt_cod.Size = new Size(100, 25);
            txt_cod.TabIndex = 13;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.Location = new Point(794, 149);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 14;
            btn_add.Text = "Adicionar";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // dataGridViewPDV
            // 
            dataGridViewPDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPDV.Columns.AddRange(new DataGridViewColumn[] { Prod, Qt, Unit, Tot });
            dataGridViewPDV.Location = new Point(486, 209);
            dataGridViewPDV.Name = "dataGridViewPDV";
            dataGridViewPDV.RowHeadersVisible = false;
            dataGridViewPDV.RowTemplate.Height = 25;
            dataGridViewPDV.Size = new Size(402, 150);
            dataGridViewPDV.TabIndex = 15;
            // 
            // Prod
            // 
            Prod.HeaderText = "Produtos";
            Prod.Name = "Prod";
            // 
            // Qt
            // 
            Qt.HeaderText = "Qtde";
            Qt.Name = "Qt";
            // 
            // Unit
            // 
            Unit.HeaderText = "Unitário";
            Unit.Name = "Unit";
            // 
            // Tot
            // 
            Tot.HeaderText = "Total";
            Tot.Name = "Tot";
            // 
            // num_qtde
            // 
            num_qtde.Location = new Point(654, 149);
            num_qtde.Name = "num_qtde";
            num_qtde.Size = new Size(62, 25);
            num_qtde.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(654, 121);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 17;
            label1.Text = "Qtde";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(486, 449);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(94, 29);
            btn_cancelar.TabIndex = 18;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_finalizar
            // 
            btn_finalizar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_finalizar.Location = new Point(736, 449);
            btn_finalizar.Name = "btn_finalizar";
            btn_finalizar.Size = new Size(166, 29);
            btn_finalizar.TabIndex = 19;
            btn_finalizar.Text = "Receber e Finalizar";
            btn_finalizar.UseVisualStyleBackColor = true;
            btn_finalizar.Click += btn_finalizar_Click;
            // 
            // lbl_vt
            // 
            lbl_vt.AutoSize = true;
            lbl_vt.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_vt.Location = new Point(794, 385);
            lbl_vt.Name = "lbl_vt";
            lbl_vt.Size = new Size(0, 21);
            lbl_vt.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(486, 385);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 21;
            label5.Text = "Valor Total";
            // 
            // PDVTela
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(914, 510);
            Controls.Add(label5);
            Controls.Add(lbl_vt);
            Controls.Add(btn_finalizar);
            Controls.Add(btn_cancelar);
            Controls.Add(label1);
            Controls.Add(num_qtde);
            Controls.Add(dataGridViewPDV);
            Controls.Add(btn_add);
            Controls.Add(txt_cod);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PDVTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PDVTela";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPDV).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_qtde).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Button btn_pastel;
        private Button btn_coxinha;
        private Button btn_esfiha;
        private Button btn_paodequeijo;
        private Button btn_suco;
        private Button btn_refri;
        private Button btn_cafe;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txt_cod;
        private Button btn_add;
        private DataGridView dataGridViewPDV;
        private DataGridViewTextBoxColumn Prod;
        private DataGridViewTextBoxColumn Qt;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Tot;
        private NumericUpDown num_qtde;
        private Label label1;
        private Button btn_cancelar;
        private Button btn_finalizar;
        private Label lbl_vt;
        private Label label5;
    }
}