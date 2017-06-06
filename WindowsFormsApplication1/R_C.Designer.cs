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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btn_FecharTarefa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivelConsequencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Consequencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivelRecompensa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Recompensa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Listar
            // 
            this.btn_Listar.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listar.Location = new System.Drawing.Point(740, 635);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(140, 57);
            this.btn_Listar.TabIndex = 21;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(137, 635);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "*DATA:";
            // 
            // mask_data
            // 
            this.mask_data.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_data.Location = new System.Drawing.Point(140, 662);
            this.mask_data.Mask = "00/00/0000";
            this.mask_data.Name = "mask_data";
            this.mask_data.Size = new System.Drawing.Size(125, 29);
            this.mask_data.TabIndex = 19;
            this.mask_data.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(136, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 48);
            this.label2.TabIndex = 18;
            this.label2.Text = "NÍVEL DESSA \r\nCONSEQUÊNCIA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(137, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "CONSEQUÊNCIA:";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(244, 12);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(98, 47);
            this.btn_Excluir.TabIndex = 16;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.Location = new System.Drawing.Point(140, 12);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(98, 47);
            this.btn_Alterar.TabIndex = 15;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // num_nivelConsequencia
            // 
            this.num_nivelConsequencia.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_nivelConsequencia.Location = new System.Drawing.Point(140, 603);
            this.num_nivelConsequencia.Name = "num_nivelConsequencia";
            this.num_nivelConsequencia.Size = new System.Drawing.Size(125, 29);
            this.num_nivelConsequencia.TabIndex = 14;
            // 
            // text_Consequencia
            // 
            this.text_Consequencia.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Consequencia.Location = new System.Drawing.Point(140, 514);
            this.text_Consequencia.Name = "text_Consequencia";
            this.text_Consequencia.Size = new System.Drawing.Size(253, 29);
            this.text_Consequencia.TabIndex = 13;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(594, 635);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(140, 57);
            this.btn_Salvar.TabIndex = 12;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // datagrid_Consequencia
            // 
            this.datagrid_Consequencia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Consequencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_Consequencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Consequencia.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_Consequencia.Location = new System.Drawing.Point(140, 65);
            this.datagrid_Consequencia.Name = "datagrid_Consequencia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Consequencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_Consequencia.Size = new System.Drawing.Size(870, 185);
            this.datagrid_Consequencia.TabIndex = 11;
            this.datagrid_Consequencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Consequencia_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(434, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 48);
            this.label4.TabIndex = 25;
            this.label4.Text = "NÍVEL DESSA \r\nRECOMPENSA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(434, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "RECOMPENSA:";
            // 
            // num_nivelRecompensa
            // 
            this.num_nivelRecompensa.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_nivelRecompensa.Location = new System.Drawing.Point(438, 606);
            this.num_nivelRecompensa.Name = "num_nivelRecompensa";
            this.num_nivelRecompensa.Size = new System.Drawing.Size(125, 29);
            this.num_nivelRecompensa.TabIndex = 23;
            // 
            // text_Recompensa
            // 
            this.text_Recompensa.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Recompensa.Location = new System.Drawing.Point(438, 514);
            this.text_Recompensa.Name = "text_Recompensa";
            this.text_Recompensa.Size = new System.Drawing.Size(253, 29);
            this.text_Recompensa.TabIndex = 22;
            // 
            // datagrid_Recompensa
            // 
            this.datagrid_Recompensa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Recompensa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid_Recompensa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Recompensa.DefaultCellStyle = dataGridViewCellStyle5;
            this.datagrid_Recompensa.Location = new System.Drawing.Point(140, 256);
            this.datagrid_Recompensa.Name = "datagrid_Recompensa";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Recompensa.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagrid_Recompensa.Size = new System.Drawing.Size(870, 199);
            this.datagrid_Recompensa.TabIndex = 26;
            this.datagrid_Recompensa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Recompensa_CellContentClick);
            // 
            // btn_SalvaAlter
            // 
            this.btn_SalvaAlter.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvaAlter.Location = new System.Drawing.Point(594, 634);
            this.btn_SalvaAlter.Name = "btn_SalvaAlter";
            this.btn_SalvaAlter.Size = new System.Drawing.Size(140, 56);
            this.btn_SalvaAlter.TabIndex = 27;
            this.btn_SalvaAlter.Text = "Salvar";
            this.btn_SalvaAlter.UseVisualStyleBackColor = true;
            this.btn_SalvaAlter.Visible = false;
            this.btn_SalvaAlter.Click += new System.EventHandler(this.btn_SalvaAlter_Click);
            // 
            // btn_FecharTarefa
            // 
            this.btn_FecharTarefa.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FecharTarefa.Location = new System.Drawing.Point(886, 633);
            this.btn_FecharTarefa.Name = "btn_FecharTarefa";
            this.btn_FecharTarefa.Size = new System.Drawing.Size(124, 57);
            this.btn_FecharTarefa.TabIndex = 28;
            this.btn_FecharTarefa.Text = "Check Tarefa";
            this.btn_FecharTarefa.UseVisualStyleBackColor = true;
            this.btn_FecharTarefa.Click += new System.EventHandler(this.btn_FecharTarefa_Click);
            // 
            // R_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fundo_textuta_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 704);
            this.Controls.Add(this.btn_FecharTarefa);
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
        private System.Windows.Forms.Button btn_FecharTarefa;
    }
}