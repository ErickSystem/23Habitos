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
            //
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

                tarefa.codigo = ObterCodigo();
                tarefa.nivel_prioridade = valueNum;
                tarefa.data = Convert.ToDateTime(mask_data.Text);

                list.Add(tarefa);

                CarregarDataGridView();

                LimparControle();

                MessageBox.Show("Tarefa inserida com sucesso!");
            }
            else
            {
                int cod = Convert.ToInt32(datagrid_ListTarefas.CurrentRow.Cells[0].Value);

                var tarefa = list.SingleOrDefault(x => x.codigo == cod);

                tarefa.tarefa = text_Tarefa.Text;
                tarefa.nivel_prioridade = Convert.ToInt16(num_nivelTarefa);
                tarefa.data = Convert.ToDateTime(mask_data);

                CarregarDataGridView();
                LimparControle();
                codigo = -1;
                MessageBox.Show("Tarefa Alterada com sucesso");

            }
        }
    }
}
