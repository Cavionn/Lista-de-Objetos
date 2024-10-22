using System.ComponentModel;

namespace listas_de_objeto
{
    public partial class Form1 : Form
    {
        private static List<Produto> produtos = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Instanciar a classe (criar m objeto)
            Produto produto = new Produto(); //Produto(P maiusculo) = Classe || produto(p minusculo) = Objeto || new Produto() = NOvo objeto vazio

            produto.id = Convert.ToInt32(txtId.Text);
            produto.nome = txtNome.Text;
            produto.quantidade = Convert.ToInt32(txtQtd.Text);
            produto.valor = float.Parse(txtValor.Text);

            //Adiconar o objeto na lista
            produtos.Add(produto);

            //Limpar os campos
            txtValor.Clear();
            txtQtd.Clear();
            txtNome.Clear();
            txtId.Clear();

            //Carregar os produtos para o data grind viw
            CarregaProdutos();


        }

        private void CarregaProdutos()
        {
            BindingList<Produto> listaProdutos = new BindingList<Produto>();

            foreach (Produto produto in produtos)
            {
                listaProdutos.Add(produto);
            }

            dgvProdutos.DataSource = listaProdutos;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(txtId.Text);

            Produto produto = produtos.Find(x => x.id == idProduto); //X = Produto (Representa os elementos de uma lista || x.id = Produto.id

            if (produto != null)
            {
                produtos.Remove(produto);
            }

            CarregaProdutos();

            txtId.Clear();
        }
    }
}