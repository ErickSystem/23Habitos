namespace WindowsFormsApplication1
{
    partial class load_tarefa
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
            this.datagrid_ListTarefas = new System.Windows.Forms.DataGridView();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.text_Tarefa = new System.Windows.Forms.TextBox();
            this.num_nivelTarefa = new System.Windows.Forms.NumericUpDown();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mask_data = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ListTarefas = new System.Windows.Forms.Button();
            this.btn_RC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ListTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivelTarefa)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_ListTarefas
            // 
            this.datagrid_ListTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_ListTarefas.Location = new System.Drawing.Point(35, 44);
            this.datagrid_ListTarefas.Name = "datagrid_ListTarefas";
            this.datagrid_ListTarefas.Size = new System.Drawing.Size(870, 328);
            this.datagrid_ListTarefas.TabIndex = 0;
            this.datagrid_ListTarefas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_ListTarefas_CellContentClick);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(400, 507);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(140, 46);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // text_Tarefa
            // 
            this.text_Tarefa.Location = new System.Drawing.Point(122, 394);
            this.text_Tarefa.Name = "text_Tarefa";
            this.text_Tarefa.Size = new System.Drawing.Size(253, 20);
            this.text_Tarefa.TabIndex = 2;
            // 
            // num_nivelTarefa
            // 
            this.num_nivelTarefa.Location = new System.Drawing.Point(122, 440);
            this.num_nivelTarefa.Name = "num_nivelTarefa";
            this.num_nivelTarefa.Size = new System.Drawing.Size(125, 20);
            this.num_nivelTarefa.TabIndex = 3;
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(35, 12);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(98, 26);
            this.btn_Alterar.TabIndex = 4;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(139, 12);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(98, 26);
            this.btn_Excluir.TabIndex = 5;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "TAREFA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "NÍVEL DE\r\nIMPORTANCIA:";
            // 
            // mask_data
            // 
            this.mask_data.Location = new System.Drawing.Point(122, 484);
            this.mask_data.Mask = "00/00/0000";
            this.mask_data.Name = "mask_data";
            this.mask_data.Size = new System.Drawing.Size(125, 20);
            this.mask_data.TabIndex = 8;
            this.mask_data.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "DATA:";
            // 
            // btn_ListTarefas
            // 
            this.btn_ListTarefas.Location = new System.Drawing.Point(546, 507);
            this.btn_ListTarefas.Name = "btn_ListTarefas";
            this.btn_ListTarefas.Size = new System.Drawing.Size(140, 46);
            this.btn_ListTarefas.TabIndex = 10;
            this.btn_ListTarefas.Text = "Listar Tarefas";
            this.btn_ListTarefas.UseVisualStyleBackColor = true;
            this.btn_ListTarefas.Click += new System.EventHandler(this.btn_ListTarefas_Click);
            // 
            // btn_RC
            // 
            this.btn_RC.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_RC.Location = new System.Drawing.Point(692, 507);
            this.btn_RC.Name = "btn_RC";
            this.btn_RC.Size = new System.Drawing.Size(173, 46);
            this.btn_RC.TabIndex = 11;
            this.btn_RC.Text = "Cadastrar \r\nRecompensa/Consequência";
            this.btn_RC.UseVisualStyleBackColor = true;
            this.btn_RC.Click += new System.EventHandler(this.btn_RC_Click);
            // 
            // load_tarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 565);
            this.Controls.Add(this.btn_RC);
            this.Controls.Add(this.btn_ListTarefas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mask_data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.num_nivelTarefa);
            this.Controls.Add(this.text_Tarefa);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.datagrid_ListTarefas);
            this.Name = "load_tarefa";
            this.RightToLeftLayout = true;
            this.Text = "Tarefa";
            this.Load += new System.EventHandler(this.load_tarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ListTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivelTarefa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_ListTarefas;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox text_Tarefa;
        private System.Windows.Forms.NumericUpDown num_nivelTarefa;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mask_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ListTarefas;
        private System.Windows.Forms.Button btn_RC;
    }
}

