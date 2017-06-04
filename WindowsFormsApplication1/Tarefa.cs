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
        public bool alterarTarefa = false;

        public load_tarefa()
        {
            InitializeComponent();
        }

        public class Tarefa
        {
            public int codigo { get; set; }
            public String tarefa { get; set; }
            public int nivel_prioridade { get; set; }
            public DateTime data { get; set; }
        }

        private List<Tarefa> list = new List<Tarefa>();

        private int codigo = -1;

        private void load_tarefa_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
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
            mask_data.Text = "";
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if(codigo == -1)
            {
                var tarefa = new Tarefa();
                int valueNum = (int)num_nivelTarefa.Value;

                if (alterarTarefa == true)
                {
                    MessageBox.Show("Essa tarefa não pode ser salva, você deve clicar no botão 'ALTERAR'");
                    return;
                }
                int nivelPrio = Convert.ToInt16(num_nivelTarefa.Value);
                if(nivelPrio > 5)
                {
                    MessageBox.Show("Nível de prioridade não pode ser maior que 5");
                }
                else
                {
                    tarefa.codigo = ObterCodigo();
                    tarefa.tarefa = text_Tarefa.Text;
                    tarefa.nivel_prioridade = valueNum;
                    tarefa.data = Convert.ToDateTime(mask_data.Text);
                    list.Add(tarefa);
                    CarregarDataGridView();
                    LimparControle();
                    MessageBox.Show("Tarefa inserida com sucesso!");
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
            int nivelPrio = Convert.ToInt16(num_nivelTarefa.Value);
            if (nivelPrio > 5)
            {
                MessageBox.Show("Nível de prioridade não pode ser maior que 5");
            }
            else if (alterarTarefa == true)
                {
                    int valueNum = (int)num_nivelTarefa.Value;
                    int cod = Convert.ToInt32(datagrid_ListTarefas.CurrentRow.Cells[0].Value);
                    var tarefa = list.SingleOrDefault(x => x.codigo == cod);

                    tarefa.tarefa = text_Tarefa.Text;
                    tarefa.nivel_prioridade = valueNum;
                    tarefa.data = Convert.ToDateTime(mask_data.Text);

                    CarregarDataGridView();
                    LimparControle();
                    codigo = -1;
                    MessageBox.Show("Tarefa Alterada com sucesso");
                }
               
            }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(datagrid_ListTarefas.CurrentRow.Cells[0].Value);
            var tarefa = list.SingleOrDefault(x => x.codigo == cod);

            list.Remove(tarefa);
            MessageBox.Show("Tarefa excluida com sucesso!");

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
    }
}
