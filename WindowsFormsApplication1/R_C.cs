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
    public partial class R_C : Form
    {
        public string consequenciaSelecionada = "";
        public string recompensaSelecionada = "";
        public bool alterarDados= false;
        public string criarNovo = null;
        public R_C()
        {
            InitializeComponent();
        }

        public class Consequencia
        {
            public int idConsequencia { get; set; }
            public String consequencia { get; set; }
            public int nivel_consequancia { get; set; }
            public DateTime data { get; set; }
        }
        public class Recompensa
        {
            public int idRecompensa { get; set; }
            public String recompensa { get; set; }
            public int nivel_recompensa { get; set; }
            public DateTime data { get; set; }
        }

        private List<Consequencia> listConsequencia = new List<Consequencia>();
        private List<Recompensa> listRecompensa = new List<Recompensa>();

        private int codigoConsequencia = -1;
        private int codigoRecompensa = -1;

        //Bloco abaixo se trata da lista CONSEQUENCIA
        private void R_C_Load(object sender, EventArgs e)
        {
            CarregarDataGridViewConsequencia();
            CarregarDataGridViewRecompensa();
        }

        private void CarregarDataGridViewConsequencia()
        {
            datagrid_Consequencia.DataSource = listConsequencia.OrderBy(x => x.data);
        }
        public int ObterCodigoConsequencia()
        {
            int retorno = 0;
            if (listConsequencia.Count == 0)
            {
                retorno = 1;
                return retorno;
            }
            else
            {
                retorno = listConsequencia.Max(x => x.idConsequencia) + 1;
                return retorno;
            }
        }
        //Bloco abaixo traz dados da lista RECOMPENSA
        private void CarregarDataGridViewRecompensa()
        {
            datagrid_Recompensa.DataSource = listRecompensa.OrderBy(x => x.data);
        }
        public int ObterCodigoRecompensa()
        {
            int retorno = 0;
            if (listRecompensa.Count == 0)
            {
                retorno = 1;
                return retorno;
            }
            else
            {
                retorno = listRecompensa.Max(x => x.idRecompensa) + 1;
                return retorno;
            }
        }

        public void LimparControle()
        {
            text_Consequencia.Text = "";
            text_Recompensa.Text = "";
            num_nivelConsequencia.Value = 0;
            num_nivelRecompensa.Value = 0;
            mask_data.Text = "";
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            
            if (codigoConsequencia == -1 && codigoRecompensa == -1) 
            {
                var consequencia = new Consequencia();
                var recompensa = new Recompensa();

                int nivelC = Convert.ToInt16(num_nivelConsequencia.Value);
                int nivelR = Convert.ToInt16(num_nivelRecompensa.Value);
                if (nivelC > 5 || nivelR > 5)
                {
                    MessageBox.Show("Nível não pode ser maior que 5");
                }
                else
                {

                    mask_data.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
                   

                    int cont = 0;
                    if (text_Consequencia.Text != "" && num_nivelConsequencia.Value > 0 && mask_data.Text != "") 
                    {
                        mask_data.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação

                        //Salvando consequencia
                        consequencia.idConsequencia = ObterCodigoConsequencia();
                        consequencia.consequencia = text_Consequencia.Text;
                        consequencia.nivel_consequancia = nivelC;
                        consequencia.data = Convert.ToDateTime(mask_data.Text);
                        //ADD na lista consequencia
                        listConsequencia.Add(consequencia);
                        MessageBox.Show("Consequência salvo com sucesso!");
                        cont++;

                    }
                   if (text_Recompensa.Text != "" && num_nivelRecompensa.Value > 0 && mask_data.Text != "")
                    {
                        mask_data.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação

                        //Salvando recompensa
                        recompensa.idRecompensa = ObterCodigoConsequencia();
                        recompensa.recompensa = text_Recompensa.Text;
                        recompensa.nivel_recompensa = nivelR;
                        recompensa.data = Convert.ToDateTime(mask_data.Text);
                        //add na lista recompensa
                        listRecompensa.Add(recompensa);
                        MessageBox.Show("Recompensa salvo com sucesso!");
                        cont++;
                    }
                    if(cont == 0)
                    {
                        MessageBox.Show("Campos vazios, você precisa preenche-los. 'CAMPO DATA É OBRIGATÓRIO'");
                    }

                    CarregarDataGridViewConsequencia();
                    CarregarDataGridViewRecompensa();
                    LimparControle();

                }

            }
        }

        private void datagrid_Consequencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //Mudar nome do botão.
            btn_Salvar.Visible = false;
            btn_SalvaAlter.Visible = true;
            criarNovo = btn_SalvaAlter.Text = "Criar novo";
            //Recuperar linha selecionada
            //consequenciaSelecionada = datagrid_Consequencia.Rows[e.RowIndex].Cells[0].Value.ToString();
            int cod = Convert.ToInt32(datagrid_Consequencia.CurrentRow.Cells[0].Value);
            var consequencia = listConsequencia.SingleOrDefault(x => x.idConsequencia == cod);

            text_Consequencia.Text = consequencia.consequencia;
            num_nivelConsequencia.Value = consequencia.nivel_consequancia;
            mask_data.Text = Convert.ToString(consequencia.data);
            //Caso o usuário tenha selecionado algum dado do datagrid, essa variavel será verdadeira. Será utilizada depois para evitar que 
            //seja salvo novamente uma nova linha
            alterarDados = true;
        }

        private void datagrid_Recompensa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            btn_Salvar.Visible = false;
            btn_SalvaAlter.Visible = true;
            criarNovo = btn_SalvaAlter.Text = "Criar novo";

            //Recuperar linha selecionada
            //consequenciaSelecionada = datagrid_Consequencia.Rows[e.RowIndex].Cells[0].Value.ToString();
            int cod = Convert.ToInt32(datagrid_Recompensa.CurrentRow.Cells[0].Value);
            var recompensa = listRecompensa.SingleOrDefault(x => x.idRecompensa == cod);

            text_Recompensa.Text = recompensa.recompensa;
            num_nivelRecompensa.Value = recompensa.nivel_recompensa;
            mask_data.Text = Convert.ToString(recompensa.data);
            //Caso o usuário tenha selecionado algum dado do datagrid, essa variavel será verdadeira. Será utilizada depois para evitar que 
            //seja salvo novamente uma nova linha.
            alterarDados = true;
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            //Datagrid de consequência
            datagrid_Consequencia.DataSource = null;//limpa o grid;
            datagrid_Consequencia.DataSource = listConsequencia;
            datagrid_Consequencia.Refresh();

            //DataGrid de Recompensa
            datagrid_Recompensa.DataSource = null;//limpa o grid;
            datagrid_Recompensa.DataSource = listRecompensa;
            datagrid_Recompensa.Refresh();

        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            int nivelC = (int)num_nivelConsequencia.Value;//transformando em int
            int nivelR = Convert.ToInt16(num_nivelRecompensa.Value);
            if (nivelC > 5 || nivelR > 5)
            {
                MessageBox.Show("Nível de prioridade não pode ser maior que 5");
            }
            else if (alterarDados == true)
            {
                int codConsequencia = Convert.ToInt32(datagrid_Consequencia.CurrentRow.Cells[0].Value);
                int codRecompensa = Convert.ToInt32(datagrid_Recompensa.CurrentRow.Cells[0].Value);

                if (text_Consequencia.Text != "" || num_nivelConsequencia.Value > 0 || mask_data.Text != "")
                {

                    var consequencia = listConsequencia.SingleOrDefault(x => x.idConsequencia == codConsequencia);
                    consequencia.consequencia = text_Consequencia.Text;
                    consequencia.nivel_consequancia = nivelC;
                    consequencia.data = Convert.ToDateTime(mask_data.Text);
                }
                if(text_Recompensa.Text != "" || num_nivelRecompensa.Value > 0 || mask_data.Text != "")
                {

                    var recompensa = listRecompensa.SingleOrDefault(x => x.idRecompensa == codRecompensa);
                    recompensa.recompensa = text_Recompensa.Text;
                    recompensa.nivel_recompensa = nivelR;
                    recompensa.data = Convert.ToDateTime(mask_data.Text);
                }
                CarregarDataGridViewConsequencia();
                CarregarDataGridViewRecompensa();
                LimparControle();
                codigoConsequencia = -1;
                codigoConsequencia = -1;

                MessageBox.Show("Alterado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao alterar");
            }

        }
        private void btn_SalvaAlter_Click(object sender, EventArgs e)
        {
            if (criarNovo == "Criar novo")
            {
                CarregarDataGridViewConsequencia();
                CarregarDataGridViewRecompensa();
                LimparControle();
                codigoConsequencia = -1;
                codigoConsequencia = -1;

            }
            btn_SalvaAlter.Visible = false;
            btn_Salvar.Visible = true;
            

        }
    }
}
