namespace WindowsFormsApplication1
{
    partial class R_C
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
            this.btn_Listar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mask_data = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.num_nivelConsequencia = new System.Windows.Forms.NumericUpDown();
            this.text_Consequencia = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.datagrid_Consequencia = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num_nivelRecompensa = new System.Windows.Forms.NumericUpDown();
            this.text_Recompensa = new System.Windows.Forms.TextBox();
            this.datagrid_Recompensa = new System.Windows.Forms.DataGridView();
            this.btn_SalvaAlter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivelConsequencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Consequencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivelRecompensa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Recompensa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(870, 653);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(140, 46);
            this.btn_Listar.TabIndex = 21;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 679);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "*DATA:";
            // 
            // mask_data
            // 
            this.mask_data.Location = new System.Drawing.Point(235, 679);
            this.mask_data.Mask = "00/00/0000";
            this.mask_data.Name = "mask_data";
            this.mask_data.Size = new System.Drawing.Size(125, 20);
            this.mask_data.TabIndex = 19;
            this.mask_data.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "NÍVEL DESSA \r\nCONSEQUÊNCIA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "CONSEQUÊNCIA:";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(244, 12);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(98, 26);
            this.btn_Excluir.TabIndex = 16;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(140, 12);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(98, 26);
            this.btn_Alterar.TabIndex = 15;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // num_nivelConsequencia
            // 
            this.num_nivelConsequencia.Location = new System.Drawing.Point(238, 543);
            this.num_nivelConsequencia.Name = "num_nivelConsequencia";
            this.num_nivelConsequencia.Size = new System.Drawing.Size(125, 20);
            this.num_nivelConsequencia.TabIndex = 14;
            // 
            // text_Consequencia
            // 
            this.text_Consequencia.Location = new System.Drawing.Point(238, 492);
            this.text_Consequencia.Name = "text_Consequencia";
            this.text_Consequencia.Size = new System.Drawing.Size(253, 20);
            this.text_Consequencia.TabIndex = 13;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(724, 653);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(140, 46);
            this.btn_Salvar.TabIndex = 12;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // datagrid_Consequencia
            // 
            this.datagrid_Consequencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Consequencia.Location = new System.Drawing.Point(140, 44);
            this.datagrid_Consequencia.Name = "datagrid_Consequencia";
            this.datagrid_Consequencia.Size = new System.Drawing.Size(870, 201);
            this.datagrid_Consequencia.TabIndex = 11;
            this.datagrid_Consequencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Consequencia_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 629);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "NÍVEL DESSA \r\nRECOMPENSA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 584);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "RECOMPENSA:";
            // 
            // num_nivelRecompensa
            // 
            this.num_nivelRecompensa.Location = new System.Drawing.Point(235, 635);
            this.num_nivelRecompensa.Name = "num_nivelRecompensa";
            this.num_nivelRecompensa.Size = new System.Drawing.Size(125, 20);
            this.num_nivelRecompensa.TabIndex = 23;
            // 
            // text_Recompensa
            // 
            this.text_Recompensa.Location = new System.Drawing.Point(235, 584);
            this.text_Recompensa.Name = "text_Recompensa";
            this.text_Recompensa.Size = new System.Drawing.Size(253, 20);
            this.text_Recompensa.TabIndex = 22;
            // 
            // datagrid_Recompensa
            // 
            this.datagrid_Recompensa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Recompensa.Location = new System.Drawing.Point(140, 251);
            this.datagrid_Recompensa.Name = "datagrid_Recompensa";
            this.datagrid_Recompensa.Size = new System.Drawing.Size(870, 219);
            this.datagrid_Recompensa.TabIndex = 26;
            this.datagrid_Recompensa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Recompensa_CellContentClick);
            // 
            // btn_SalvaAlter
            // 
            this.btn_SalvaAlter.Location = new System.Drawing.Point(724, 653);
            this.btn_SalvaAlter.Name = "btn_SalvaAlter";
            this.btn_SalvaAlter.Size = new System.Drawing.Size(140, 46);
            this.btn_SalvaAlter.TabIndex = 27;
            this.btn_SalvaAlter.Text = "Salvar";
            this.btn_SalvaAlter.UseVisualStyleBackColor = true;
            this.btn_SalvaAlter.Visible = false;
            this.btn_SalvaAlter.Click += new System.EventHandler(this.btn_SalvaAlter_Click);
            // 
            // R_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 704);
            this.Controls.Add(this.btn_SalvaAlter);
            this.Controls.Add(this.datagrid_Recompensa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_nivelRecompensa);
            this.Controls.Add(this.text_Recompensa);
            this.Controls.Add(this.btn_Listar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mask_data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.num_nivelConsequencia);
            this.Controls.Add(this.text_Consequencia);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.datagrid_Consequencia);
            this.Name = "R_C";
            this.Text = "R_C";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.R_C_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_nivelConsequencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Consequencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivelRecompensa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Recompensa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mask_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.NumericUpDown num_nivelConsequencia;
        private System.Windows.Forms.TextBox text_Consequencia;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.DataGridView datagrid_Consequencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_nivelRecompensa;
        private System.Windows.Forms.TextBox text_Recompensa;
        private System.Windows.Forms.DataGridView datagrid_Recompensa;
        private System.Windows.Forms.Button btn_SalvaAlter;
    }
}