using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class load_tarefa : Form

    {
        public string tarefaSelecionada = "";
        private bool alterarTarefa = false;
        public string criarNovo = null;


        public load_tarefa()
        {
            InitializeComponent();
        }

        public class Tarefa
        {
            public int codigo { get; set; }
            public String tarefa { get; set; }
            public int nivel_prioridade { get; set; }
            public string dayWeek { get; set; }
            public DateTime data { get; set; }
        }

        public List<Tarefa> list = new List<Tarefa>();

        private int codigo = -1;

        private void load_tarefa_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
            cmbo_Dayweek.Text = "Selecione o dia";
        }

        private void CarregarDataGridView()
        {
            datagrid_ListTarefas.DataSource = list.OrderBy(x => x.data);
        }

        public int ObterCodigo()
        {
            int retorno = 0;
            if(list.Count == 0)
            {
                retorno = 1;
                return retorno;
            }
            else
            {
                retorno = list.Max(x => x.codigo) + 1;
                return retorno;
            }
        }

        public void LimparControle()
        {

            text_Tarefa.Text = "";
            num_nivelTarefa.Value = 0;
            cmbo_Dayweek.Text = "Selecione o dia";
            mask_data.Text = "";
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            bool validar = false;

            if (codigo == -1)
            {
                var tarefa = new Tarefa();

                int nivelTarefa = Convert.ToInt16(num_nivelTarefa.Value);
                if (nivelTarefa > 5)
                {
                    MessageBox.Show("Nível não pode ser maior que cinco");
                }
                else if (nivelTarefa == 0)
                {
                    MessageBox.Show("Nível precisa ser maior que zero");
                }
                else
                {
                    mask_data.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
                    if(text_Tarefa.Text != "" && num_nivelTarefa.Value > 0 
                        && cmbo_Dayweek.Text != "Selecione o dia" && mask_data.Text != "")
                    {
                        mask_data.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação

                        tarefa.codigo = ObterCodigo();
                        tarefa.tarefa = text_Tarefa.Text;
                        tarefa.dayWeek = cmbo_Dayweek.Text;
                        tarefa.nivel_prioridade = nivelTarefa;
                        tarefa.data = Convert.ToDateTime(mask_data.Text);
                        list.Add(tarefa);
                        CarregarDataGridView();
                        LimparControle();

                        validar = true;
                        MessageBox.Show("Tarefa inserida com sucesso!");
                    }
                }
                if(validar == false)
                {
                    MessageBox.Show("Campos vazios, favor preenche-los. 'Campo data é obrigatório'");
                }
            }
        }

        private void btn_ListTarefas_Click(object sender, EventArgs e)
        {
            datagrid_ListTarefas.DataSource = null;//limpa o grid;
            datagrid_ListTarefas.DataSource = list;
            datagrid_ListTarefas.Refresh();
        }

        private void datagrid_ListTarefas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            btn_Salvar.Visible = false;
            btn_Criarnovo.Visible = true;
            criarNovo = btn_Criarnovo.Text = "Criar novo";
            //Recuperar linha selecionada
            //tarefaSelecionada = datagrid_ListTarefas.Rows[e.RowIndex].Cells[0].Value.ToString();
            int cod = Convert.ToInt32(datagrid_ListTarefas.CurrentRow.Cells[0].Value);
            var tarefa = list.SingleOrDefault(x => x.codigo == cod);

            text_Tarefa.Text = tarefa.tarefa;
            num_nivelTarefa.Value = tarefa.nivel_prioridade;
            mask_data.Text = Convert.ToString(tarefa.data);
            alterarTarefa = true;
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            bool validar = false;//Criado para saber se os campos foram preenchidos

            int cod = Convert.ToInt32(datagrid_ListTarefas.CurrentRow.Cells[0].Value);
            var tarefa = list.SingleOrDefault(x => x.codigo == cod);

            int nivelPrio = Convert.ToInt16(num_nivelTarefa.Value);
            if (nivelPrio > 5)
            {
                MessageBox.Show("Nível de prioridade não pode ser maior que cinco");
            }
            else if (nivelPrio == 0)
            {
                MessageBox.Show("Nível precisa ser maior que zero");
            }
            else if (alterarTarefa == true)
                {

                     mask_data.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação

                    if (text_Tarefa.Text != "" && num_nivelTarefa.Value > 0
                        && cmbo_Dayweek.Text != "Selecione o dia" && mask_data.Text != "")
                    {
                        mask_data.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação
                        tarefa.tarefa = text_Tarefa.Text;
                        tarefa.dayWeek = cmbo_Dayweek.Text;
                        tarefa.nivel_prioridade = nivelPrio;
                        tarefa.data = Convert.ToDateTime(mask_data.Text);

                        CarregarDataGridView();
                        LimparControle();
                        codigo = -1;
                        validar = true;
                        MessageBox.Show("Tarefa Alterada com sucesso");
                }
                }
            if(validar == false)
            {
                MessageBox.Show("Campos vazios, você precisa preenche-los. 'Campo data é obrigatório");
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(datagrid_ListTarefas.CurrentRow.Cells[0].Value);
            var tarefa = list.SingleOrDefault(x => x.codigo == cod);

            list.Remove(tarefa);
            MessageBox.Show("Tarefa excluida com sucesso!");
            btn_Criarnovo.Visible = false;
            btn_Salvar.Visible = true;
            CarregarDataGridView();
            LimparControle();
            codigo = -1;
        }

        private void btn_RC_Click(object sender, EventArgs e)
        {
            var rc = new R_C();
            this.Hide();
            rc.ShowDialog();
            
        }

        private void num_nivelTarefa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Criarnovo_Click(object sender, EventArgs e)
        {
            if (criarNovo == "Criar novo")
            {
                CarregarDataGridView();
                LimparControle();
                codigo = -1;
            }
            btn_Criarnovo.Visible = false;
            btn_Salvar.Visible = true;
        }
    }
}
