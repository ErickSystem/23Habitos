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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbo_Dayweek = new System.Windows.Forms.ComboBox();
            this.btn_Criarnovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ListTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivelTarefa)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_ListTarefas
            // 
            this.datagrid_ListTarefas.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.datagrid_ListTarefas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagrid_ListTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_ListTarefas.GridColor = System.Drawing.SystemColors.Control;
            this.datagrid_ListTarefas.Location = new System.Drawing.Point(190, 84);
            this.datagrid_ListTarefas.Name = "datagrid_ListTarefas";
            this.datagrid_ListTarefas.Size = new System.Drawing.Size(870, 328);
            this.datagrid_ListTarefas.TabIndex = 0;
            this.datagrid_ListTarefas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_ListTarefas_CellContentClick);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(664, 544);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(117, 82);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // text_Tarefa
            // 
            this.text_Tarefa.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Tarefa.Location = new System.Drawing.Point(200, 442);
            this.text_Tarefa.Multiline = true;
            this.text_Tarefa.Name = "text_Tarefa";
            this.text_Tarefa.Size = new System.Drawing.Size(253, 29);
            this.text_Tarefa.TabIndex = 2;
            // 
            // num_nivelTarefa
            // 
            this.num_nivelTarefa.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_nivelTarefa.Location = new System.Drawing.Point(200, 525);
            this.num_nivelTarefa.Name = "num_nivelTarefa";
            this.num_nivelTarefa.Size = new System.Drawing.Size(125, 29);
            this.num_nivelTarefa.TabIndex = 3;
            this.num_nivelTarefa.ValueChanged += new System.EventHandler(this.num_nivelTarefa_ValueChanged);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.Color.Black;
            this.btn_Alterar.Location = new System.Drawing.Point(190, 12);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(98, 66);
            this.btn_Alterar.TabIndex = 4;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(303, 12);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(98, 66);
            this.btn_Excluir.TabIndex = 5;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(196, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "TAREFA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(196, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "NÍVEL DE\r\nIMPORTANCIA:";
            // 
            // mask_data
            // 
            this.mask_data.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_data.Location = new System.Drawing.Point(200, 600);
            this.mask_data.Mask = "00/00/0000";
            this.mask_data.Name = "mask_data";
            this.mask_data.Size = new System.Drawing.Size(125, 29);
            this.mask_data.TabIndex = 8;
            this.mask_data.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(196, 573);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "*DATA:";
            // 
            // btn_ListTarefas
            // 
            this.btn_ListTarefas.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListTarefas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ListTarefas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_ListTarefas.Location = new System.Drawing.Point(787, 544);
            this.btn_ListTarefas.Name = "btn_ListTarefas";
            this.btn_ListTarefas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ListTarefas.Size = new System.Drawing.Size(120, 82);
            this.btn_ListTarefas.TabIndex = 10;
            this.btn_ListTarefas.Text = "Listar Tarefas";
            this.btn_ListTarefas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_ListTarefas.UseVisualStyleBackColor = true;
            this.btn_ListTarefas.Click += new System.EventHandler(this.btn_ListTarefas_Click);
            // 
            // btn_RC
            // 
            this.btn_RC.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RC.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_RC.Location = new System.Drawing.Point(913, 544);
            this.btn_RC.Name = "btn_RC";
            this.btn_RC.Size = new System.Drawing.Size(156, 82);
            this.btn_RC.TabIndex = 11;
            this.btn_RC.Text = "Cadastrar \r\nRecompensa/Consequência";
            this.btn_RC.UseVisualStyleBackColor = true;
            this.btn_RC.Click += new System.EventHandler(this.btn_RC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(499, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "DIA DA SEMANA:";
            // 
            // cmbo_Dayweek
            // 
            this.cmbo_Dayweek.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_Dayweek.FormattingEnabled = true;
            this.cmbo_Dayweek.Items.AddRange(new object[] {
            "segunda",
            "terca",
            "quarta",
            "quinta",
            "sexta"});
            this.cmbo_Dayweek.Location = new System.Drawing.Point(503, 442);
            this.cmbo_Dayweek.Name = "cmbo_Dayweek";
            this.cmbo_Dayweek.Size = new System.Drawing.Size(178, 32);
            this.cmbo_Dayweek.TabIndex = 14;
            // 
            // btn_Criarnovo
            // 
            this.btn_Criarnovo.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Criarnovo.Location = new System.Drawing.Point(664, 544);
            this.btn_Criarnovo.Name = "btn_Criarnovo";
            this.btn_Criarnovo.Size = new System.Drawing.Size(117, 82);
            this.btn_Criarnovo.TabIndex = 15;
            this.btn_Criarnovo.Text = "Cria novo";
            this.btn_Criarnovo.UseVisualStyleBackColor = true;
            this.btn_Criarnovo.Visible = false;
            this.btn_Criarnovo.Click += new System.EventHandler(this.btn_Criarnovo_Click);
            // 
            // load_tarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fundo_textuta_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 641);
            this.Controls.Add(this.btn_Criarnovo);
            this.Controls.Add(this.cmbo_Dayweek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ListTarefas);
            this.Controls.Add(this.btn_RC);
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
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "load_tarefa";
            this.RightToLeftLayout = true;
            this.Text = "Tarefa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbo_Dayweek;
        private System.Windows.Forms.Button btn_Criarnovo;
    }
}

