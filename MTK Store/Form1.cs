using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace MTK_Store
{
    public partial class Form1 : Form
    {
        private readonly CultureInfo cultura =
            CultureInfo.GetCultureInfo("pt-BR");

        private string telefoneClienteSelecionado = "";

        private int? idClienteSelecionado = null;
        private int? idClienteCadastroSelecionado = null;
        private int? idProdutoSelecionado = null;

        public Form1()
        {
            InitializeComponent();
            dgvClientes.CellClick += dgvClientes_CellContentClick;

            pnlInicio.Visible = true;
            pnlProdutos.Visible = false;
            pnlClientes.Visible = false;
            pnlVendas.Visible = false;
            pnlRelatorio.Visible = false;

            pnlInicio.BringToFront();

            // Ligar os botões aos seus métodos
            btnAlterarCliente.Click += btnAlterarCliente_Click;
            btnExcluirCliente.Click += btnExcluirCliente_Click;
            btnLimparCliente.Click += btnLimparCliente_Click;

            btnBuscarCliente.Click += btnBuscarCliente_Click;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            btnRemoverItem.Click += btnRemoverItem_Click;
            btnLimparVenda.Click += btnLimparVenda_Click;

            // Configurações da venda
            dgvItensVenda.AllowUserToAddRows = false;
            dgvItensVenda.ReadOnly = true;
            dgvItensVenda.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvItensVenda.MultiSelect = false;

            mskTelefone.Mask = "(00) 00000-0000";
            mskTelefone.Clear();

            CarregarProdutos();
            CarregarClientes();
            AtualizarListaProdutos();
            AtualizarTotaisVenda();
        }

        // NAVEGAÇÃO

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = true;
            pnlProdutos.Visible = false;
            pnlClientes.Visible = false;
            pnlVendas.Visible = false;

            pnlInicio.BringToFront();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlProdutos.Visible = true;
            pnlClientes.Visible = false;
            pnlVendas.Visible = false;

            pnlProdutos.BringToFront();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlProdutos.Visible = false;
            pnlClientes.Visible = true;
            pnlVendas.Visible = false;

            pnlClientes.BringToFront();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlProdutos.Visible = false;
            pnlClientes.Visible = false;
            pnlVendas.Visible = true;

            pnlVendas.BringToFront();

            AtualizarListaProdutos();
        }

        // CADASTRO DE PRODUTOS

        private void lblQuantidade_Click(object sender, EventArgs e)
        {
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProduto.Text.Trim();
            string categoria = txtCategoria.Text.Trim();

            if (nome == "" || categoria == "" ||
                txtPreco.Text.Trim() == "" ||
                txtQuantidade.Text.Trim() == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            decimal preco;

            if (!decimal.TryParse(
                txtPreco.Text,
                NumberStyles.Number,
                cultura,
                out preco) || preco <= 0)
            {
                MessageBox.Show("Digite um preço válido!");
                txtPreco.Focus();
                return;
            }

            int quantidade;

            if (!int.TryParse(txtQuantidade.Text, out quantidade) ||
                quantidade < 0)
            {
                MessageBox.Show("Digite uma quantidade válida!");
                txtQuantidade.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conexao = Conexao.Criar())
                {
                    conexao.Open();

                    using (MySqlCommand comando =
                           new MySqlCommand("sp_insereProduto", conexao))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@p_nome", nome);
                        comando.Parameters.AddWithValue("@p_categoria", categoria);
                        comando.Parameters.AddWithValue("@p_preco", preco);
                        comando.Parameters.AddWithValue("@p_quantidade", quantidade);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);
                return;
            }

            MessageBox.Show("Produto cadastrado com sucesso!");

            txtNomeProduto.Clear();
            txtCategoria.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            idProdutoSelecionado = null;

            txtNomeProduto.Focus();

            CarregarProdutos();
            AtualizarListaProdutos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (idProdutoSelecionado == null)
            {
                MessageBox.Show("Clique no produto que deseja alterar na tabela!");
                return;
            }

            string nome = txtNomeProduto.Text.Trim();
            string categoria = txtCategoria.Text.Trim();

            if (nome == "" || categoria == "" ||
                txtPreco.Text.Trim() == "" ||
                txtQuantidade.Text.Trim() == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            decimal preco;

            if (!decimal.TryParse(
                txtPreco.Text,
                NumberStyles.Number,
                cultura,
                out preco) || preco <= 0)
            {
                MessageBox.Show("Digite um preço válido!");
                return;
            }

            int quantidade;

            if (!int.TryParse(txtQuantidade.Text, out quantidade) ||
                quantidade < 0)
            {
                MessageBox.Show("Digite uma quantidade válida!");
                return;
            }

            int idProduto = idProdutoSelecionado.Value;

            try
            {
                using (MySqlConnection conexao = Conexao.Criar())
                {
                    conexao.Open();

                    string sql = @"UPDATE produtos
                       SET nome = @nome,
                           categoria = @categoria,
                           preco = @preco,
                           quantidade = @quantidade
                       WHERE id_produto = @id";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@categoria", categoria);
                        comando.Parameters.AddWithValue("@preco", preco);
                        comando.Parameters.AddWithValue("@quantidade", quantidade);
                        comando.Parameters.AddWithValue("@id", idProduto);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar produto: " + ex.Message);
                return;
            }

            MessageBox.Show("Produto alterado com sucesso!");

            txtNomeProduto.Clear();
            txtCategoria.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            idProdutoSelecionado = null;

            CarregarProdutos();
            AtualizarListaProdutos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para excluir!");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Tem certeza que deseja excluir este produto?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                DataGridViewRow linha = dgvProdutos.SelectedRows[0];
                int idProduto = Convert.ToInt32(linha.Tag);

                try
                {
                    using (MySqlConnection conexao = Conexao.Criar())
                    {
                        conexao.Open();

                        string sql = "DELETE FROM produtos WHERE id_produto = @id";

                        using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                        {
                            comando.Parameters.AddWithValue("@id", idProduto);
                            comando.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir produto: " + ex.Message);
                    return;
                }

                MessageBox.Show("Produto excluído com sucesso!");

                txtNomeProduto.Clear();
                txtCategoria.Clear();
                txtPreco.Clear();
                txtQuantidade.Clear();

                CarregarProdutos();
                AtualizarListaProdutos();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Clear();
            txtCategoria.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            idProdutoSelecionado = null;
            btncadastrar.Enabled = true;

            txtNomeProduto.Focus();
        }

        private void PnlProdutos_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dgvProdutos_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow linha = dgvProdutos.Rows[e.RowIndex];
            idProdutoSelecionado = Convert.ToInt32(linha.Tag);

            txtNomeProduto.Text =
                Convert.ToString(linha.Cells["ColNome"].Value);

            txtCategoria.Text =
                Convert.ToString(linha.Cells["ColCategoria"].Value);

            txtQuantidade.Text =
                Convert.ToString(linha.Cells["ColQuantidade"].Value);

            decimal preco;

            if (decimal.TryParse(
                Convert.ToString(linha.Cells["ColPreco"].Value),
                NumberStyles.Currency,
                cultura,
                out preco))
            {
                txtPreco.Text = preco.ToString("0.00", cultura);
            }
        }

        // CADASTRO DE CLIENTES

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCliente.Text.Trim();
            string telefone = txtTelefoneCliente.Text.Trim();
            string email = txtEmailCliente.Text.Trim();
            string endereco = txtEnderecoCliente.Text.Trim();

            if (nome == "" || telefone == "" ||
                email == "" || endereco == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            try
            {
                using (MySqlConnection conexao = Conexao.Criar())
                {
                    conexao.Open();

                    string sql = @"INSERT INTO clientes
                        (nome, telefone, email, endereco)
                        VALUES (@nome, @telefone, @email, @endereco)";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@telefone", telefone);
                        comando.Parameters.AddWithValue("@email", email);
                        comando.Parameters.AddWithValue("@endereco", endereco);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message);
                return;
            }

            MessageBox.Show("Cliente cadastrado com sucesso!");

            LimparCamposCliente();
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            dgvClientes.Rows.Clear();

            try
            {
                using (MySqlConnection conexao = Conexao.Criar())
                {
                    conexao.Open();

                    string sql = @"SELECT id_cliente, nome, telefone, email, endereco
                            FROM clientes
                            ORDER BY nome";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    using (MySqlDataReader leitor = comando.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            int indice = dgvClientes.Rows.Add(
                                leitor["nome"].ToString(),
                                leitor["telefone"].ToString(),
                                leitor["email"].ToString(),
                                leitor["endereco"].ToString()
                            );

                            dgvClientes.Rows[indice].Tag =
                                Convert.ToInt32(leitor["id_cliente"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            if (idClienteCadastroSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente na tabela!");
                return;
            }

            string nome = txtNomeCliente.Text.Trim();
            string telefone = txtTelefoneCliente.Text.Trim();
            string email = txtEmailCliente.Text.Trim();
            string endereco = txtEnderecoCliente.Text.Trim();

            if (nome == "" || telefone == "" ||
                email == "" || endereco == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            int idCliente = idClienteCadastroSelecionado.Value;

            try
            {
                using (MySqlConnection conexao = Conexao.Criar())
                {
                    conexao.Open();

                    string sql = @"UPDATE clientes
                       SET nome = @nome,
                           telefone = @telefone,
                           email = @email,
                           endereco = @endereco
                       WHERE id_cliente = @id";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@telefone", telefone);
                        comando.Parameters.AddWithValue("@email", email);
                        comando.Parameters.AddWithValue("@endereco", endereco);
                        comando.Parameters.AddWithValue("@id", idCliente);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar cliente: " + ex.Message);
                return;
            }

            MessageBox.Show("Cliente alterado com sucesso!");

            LimparCamposCliente();
            idClienteCadastroSelecionado = null;
            CarregarClientes();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente para excluir!");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Tem certeza que deseja excluir este cliente?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                DataGridViewRow linha = dgvClientes.SelectedRows[0];

                if (linha.Tag == null)
                {
                    MessageBox.Show("Não foi possível identificar o cliente selecionado.");
                    return;
                }

                int idCliente = Convert.ToInt32(linha.Tag);

                try
                {
                    using (MySqlConnection conexao = Conexao.Criar())
                    {
                        conexao.Open();

                        string sql = "DELETE FROM clientes WHERE id_cliente = @id";

                        using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                        {
                            comando.Parameters.AddWithValue("@id", idCliente);
                            comando.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
                    return;
                }

                MessageBox.Show("Cliente excluído com sucesso!");

                LimparCamposCliente();
                CarregarClientes();
            }
        }

        private void btnLimparCliente_Click(object sender, EventArgs e)
        {
            LimparCamposCliente();
        }

        private void LimparCamposCliente()
        {
            txtNomeCliente.Clear();
            txtTelefoneCliente.Clear();
            txtEmailCliente.Clear();
            txtEnderecoCliente.Clear();

            txtNomeCliente.Focus();
        }

        private void BtnExcluirCliente_Click_1(object sender, EventArgs e)
        {
        }

        // CARREGAR PRODUTOS
        private void CarregarProdutos()
        {
            dgvProdutos.Rows.Clear();

            try
            {
                using (MySqlConnection conexao = Conexao.Criar())
                {
                    conexao.Open();

                    using (MySqlCommand comando =
                           new MySqlCommand("sp_listaProdutos", conexao))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataReader leitor = comando.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                int indice = dgvProdutos.Rows.Add(
                                    leitor["nome"].ToString(),
                                    leitor["categoria"].ToString(),
                                    Convert.ToDecimal(leitor["preco"])
                                        .ToString("C2", cultura),
                                    Convert.ToInt32(leitor["quantidade"])
                                );

                                dgvProdutos.Rows[indice].Tag =
                                    Convert.ToInt32(leitor["id_produto"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        // VENDAS

        private void AtualizarListaProdutos()
        {
            string produtoSelecionado = cboProdutoVenda.Text;

            cboProdutoVenda.Items.Clear();

            foreach (DataGridViewRow linha in dgvProdutos.Rows)
            {
                if (linha.IsNewRow)
                    continue;

                string nome = Convert.ToString(
                    linha.Cells["ColNome"].Value);

                if (!string.IsNullOrWhiteSpace(nome))
                {
                    cboProdutoVenda.Items.Add(nome);
                }
            }

            if (produtoSelecionado != "")
            {
                int indice = cboProdutoVenda.Items.IndexOf(
                    produtoSelecionado);

                if (indice >= 0)
                    cboProdutoVenda.SelectedIndex = indice;
            }
        }

        private string SomenteNumeros(string texto)
        {
            return new string(
                texto.Where(char.IsDigit).ToArray()
            );
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string telefoneDigitado =
                SomenteNumeros(mskTelefone.Text);

            if (telefoneDigitado.Length != 11)
            {
                MessageBox.Show(
                    "Digite um telefone completo com DDD!");
                mskTelefone.Focus();
                return;
            }

            idClienteSelecionado = null;
            telefoneClienteSelecionado = "";
            lblNomeClienteVenda.Text = "Cliente não selecionado";

            try
            {
                using (MySqlConnection conexao = Conexao.Criar())
                {
                    conexao.Open();

                    using (MySqlCommand comando =
                           new MySqlCommand("sp_buscaClienteTelefone", conexao))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue(
                            "@p_telefone", mskTelefone.Text);

                        using (MySqlDataReader leitor = comando.ExecuteReader())
                        {
                            if (leitor.Read())
                            {
                                idClienteSelecionado =
                                    Convert.ToInt32(leitor["id_cliente"]);

                                telefoneClienteSelecionado = telefoneDigitado;

                                lblNomeClienteVenda.Text =
                                    leitor["nome"].ToString();

                                return;
                            }
                        }
                    }
                }

                MessageBox.Show("Nenhum cliente encontrado com esse telefone.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (cboProdutoVenda.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um produto!");
                return;
            }

            int quantidade;

            if (!int.TryParse(
                txtQuantidadeVenda.Text,
                out quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Digite uma quantidade válida!");
                txtQuantidadeVenda.Focus();
                return;
            }

            string nomeProduto = cboProdutoVenda.Text;

            DataGridViewRow produtoEncontrado = null;

            foreach (DataGridViewRow linha in dgvProdutos.Rows)
            {
                if (linha.IsNewRow)
                    continue;

                string nome = Convert.ToString(
                    linha.Cells["ColNome"].Value);

                if (nome == nomeProduto)
                {
                    produtoEncontrado = linha;
                    break;
                }
            }

            if (produtoEncontrado == null)
            {
                MessageBox.Show("Produto não encontrado!");
                return;
            }

            int estoque;

            if (!int.TryParse(
                Convert.ToString(
                    produtoEncontrado.Cells["ColQuantidade"].Value),
                out estoque))
            {
                MessageBox.Show("Não foi possível consultar o estoque.");
                return;
            }

            int quantidadeJaAdicionada = 0;

            foreach (DataGridViewRow item in dgvItensVenda.Rows)
            {
                if (Convert.ToString(item.Cells["Produto"].Value)
                    == nomeProduto)
                {
                    int qtd;

                    int.TryParse(
                        Convert.ToString(
                            item.Cells["Quantidade"].Value),
                        out qtd);

                    quantidadeJaAdicionada += qtd;
                }
            }

            if (quantidade + quantidadeJaAdicionada > estoque)
            {
                MessageBox.Show(
                    "Quantidade indisponível no estoque!\n" +
                    "Quantidade disponível: " +
                    (estoque - quantidadeJaAdicionada)
                );
                return;
            }

            string textoPreco = Convert.ToString(
                produtoEncontrado.Cells["ColPreco"].Value);

            decimal preco;

            if (!decimal.TryParse(
                textoPreco,
                NumberStyles.Currency,
                cultura,
                out preco))
            {
                MessageBox.Show("Não foi possível consultar o preço.");
                return;
            }

            decimal subtotal = preco * quantidade;

            int idProduto = Convert.ToInt32(produtoEncontrado.Tag);

            int indiceItem = dgvItensVenda.Rows.Add(
                nomeProduto,
                quantidade,
                preco.ToString("C2", cultura),
                subtotal.ToString("C2", cultura)
            );

            dgvItensVenda.Rows[indiceItem].Tag = idProduto;

            AtualizarTotaisVenda();

            txtQuantidadeVenda.Clear();
            cboProdutoVenda.SelectedIndex = -1;

            MessageBox.Show("Produto adicionado à venda!");
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if (dgvItensVenda.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Selecione um produto da venda para remover!");
                return;
            }

            dgvItensVenda.Rows.Remove(
                dgvItensVenda.SelectedRows[0]);

            AtualizarTotaisVenda();

            MessageBox.Show("Item removido da venda!");
        }

        private decimal CalcularTotalVenda()
        {
            decimal total = 0;

            foreach (DataGridViewRow linha in dgvItensVenda.Rows)
            {
                if (linha.IsNewRow)
                    continue;

                string textoSubtotal = Convert.ToString(
                    linha.Cells["Subtotal"].Value);

                decimal subtotal;

                if (decimal.TryParse(
                    textoSubtotal,
                    NumberStyles.Currency,
                    cultura,
                    out subtotal))
                {
                    total += subtotal;
                }
            }

            return total;
        }

        private void AtualizarTotaisVenda()
        {
            decimal total = CalcularTotalVenda();

            lblSubtotalVenda.Text =
                "Subtotal: " + total.ToString("C2", cultura);

            lblTotalVenda.Text =
                "Total: " + total.ToString("C2", cultura);
        }

        // FINALIZAR VENDA

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (idClienteSelecionado == null)
            {
                MessageBox.Show(
                    "Primeiro, pesquise e selecione o cliente pelo telefone!");
                return;
            }

            if (dgvItensVenda.Rows.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um produto à venda!");
                return;
            }

            if (cboFormaPagamento.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a forma de pagamento!");
                return;
            }

            // Conferir novamente o estoque antes de finalizar.
            foreach (DataGridViewRow item in dgvItensVenda.Rows)
            {
                string nomeProduto =
                    Convert.ToString(item.Cells["Produto"].Value);

                int quantidadeVendida;

                int.TryParse(
                    Convert.ToString(item.Cells["Quantidade"].Value),
                    out quantidadeVendida);

                DataGridViewRow produtoEncontrado = null;

                foreach (DataGridViewRow produto in dgvProdutos.Rows)
                {
                    if (produto.IsNewRow)
                        continue;

                    if (Convert.ToString(
                        produto.Cells["ColNome"].Value) == nomeProduto)
                    {
                        produtoEncontrado = produto;
                        break;
                    }
                }

                if (produtoEncontrado == null)
                {
                    MessageBox.Show(
                        "O produto " + nomeProduto +
                        " não foi encontrado!");
                    return;
                }

                int estoque;

                if (!int.TryParse(
                    Convert.ToString(
                        produtoEncontrado.Cells["ColQuantidade"].Value),
                    out estoque) || estoque < quantidadeVendida)
                {
                    MessageBox.Show(
                        "Estoque insuficiente para o produto " +
                        nomeProduto + "!");
                    return;
                }
            }

            decimal total = CalcularTotalVenda();

            DialogResult resposta = MessageBox.Show(
                "Cliente: " + lblNomeClienteVenda.Text +
                "\nForma de pagamento: " + cboFormaPagamento.Text +
                "\nTotal: " + total.ToString("C2", cultura) +
                "\n\nDeseja finalizar a venda?",
                "Confirmar venda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta != DialogResult.Yes)
                return;

            // Salvar a venda e seus itens no banco.
            // A gravação acontece dentro de uma transação.
            try
            {
                using (MySqlConnection conexao = Conexao.Criar())
                {
                    conexao.Open();

                    using (MySqlTransaction transacao =
                           conexao.BeginTransaction())
                    {
                        try
                        {
                            // A tabela vendas não possui
                            // nome_cliente_venda nem telefone_cliente_venda.
                            string sqlVenda = @"INSERT INTO vendas
                            (id_cliente, forma_pagamento, valor_total)
                            VALUES
                            (@id_cliente, @forma_pagamento, @valor_total)";

                            int idVenda;

                            using (MySqlCommand comandoVenda =
                                   new MySqlCommand(sqlVenda, conexao, transacao))
                            {
                                comandoVenda.Parameters.AddWithValue(
                                    "@id_cliente", idClienteSelecionado.Value);

                                comandoVenda.Parameters.AddWithValue(
                                    "@forma_pagamento", cboFormaPagamento.Text);

                                comandoVenda.Parameters.AddWithValue(
                                    "@valor_total", total);

                                comandoVenda.ExecuteNonQuery();

                                idVenda = Convert.ToInt32(
                                    comandoVenda.LastInsertedId);
                            }

                            foreach (DataGridViewRow item in dgvItensVenda.Rows)
                            {
                                int idProduto = Convert.ToInt32(item.Tag);

                                int quantidade = Convert.ToInt32(
                                    item.Cells["Quantidade"].Value);

                                decimal subtotal;

                                if (!decimal.TryParse(
                                    Convert.ToString(
                                        item.Cells["Subtotal"].Value),
                                    NumberStyles.Currency,
                                    cultura,
                                    out subtotal))
                                {
                                    throw new Exception(
                                        "Não foi possível ler o subtotal de um item.");
                                }

                                decimal precoUnitario = subtotal / quantidade;

                                // Baixar quantidade do estoque.
                                string sqlEstoque = @"UPDATE produtos
                                    SET quantidade = quantidade - @quantidade
                                    WHERE id_produto = @id_produto
                                    AND quantidade >= @quantidade";

                                using (MySqlCommand comandoEstoque =
                                       new MySqlCommand(
                                           sqlEstoque, conexao, transacao))
                                {
                                    comandoEstoque.Parameters.AddWithValue(
                                        "@quantidade", quantidade);

                                    comandoEstoque.Parameters.AddWithValue(
                                        "@id_produto", idProduto);

                                    if (comandoEstoque.ExecuteNonQuery() == 0)
                                    {
                                        throw new Exception(
                                            "Estoque insuficiente para um dos produtos.");
                                    }
                                }

                                // A tabela itens_venda também não possui
                                // a coluna nome_produto_venda.
                                string sqlItem = @"INSERT INTO itens_venda
                                    (id_venda, id_produto, quantidade,
                                     preco_unitario, subtotal)
                                    VALUES
                                    (@id_venda, @id_produto, @quantidade,
                                     @preco_unitario, @subtotal)";

                                using (MySqlCommand comandoItem =
                                       new MySqlCommand(
                                           sqlItem, conexao, transacao))
                                {
                                    comandoItem.Parameters.AddWithValue(
                                        "@id_venda", idVenda);

                                    comandoItem.Parameters.AddWithValue(
                                        "@id_produto", idProduto);

                                    comandoItem.Parameters.AddWithValue(
                                        "@quantidade", quantidade);

                                    comandoItem.Parameters.AddWithValue(
                                        "@preco_unitario", precoUnitario);

                                    comandoItem.Parameters.AddWithValue(
                                        "@subtotal", subtotal);

                                    comandoItem.ExecuteNonQuery();
                                }
                            }

                            transacao.Commit();
                        }
                        catch
                        {
                            transacao.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao finalizar venda: " + ex.Message);
                return;
            }

            MessageBox.Show(
                "Venda finalizada com sucesso!\n" +
                "Cliente: " + lblNomeClienteVenda.Text +
                "\nTotal: " + total.ToString("C2", cultura),
                "MTK Store",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LimparVenda();
            CarregarProdutos();
            AtualizarListaProdutos();
        }
        private void btnLimparVenda_Click(object sender, EventArgs e)
        {
            LimparVenda();
        }

        private void LimparVenda()
        {
            dgvItensVenda.Rows.Clear();

            cboProdutoVenda.SelectedIndex = -1;
            txtQuantidadeVenda.Clear();

            cboFormaPagamento.SelectedIndex = -1;

            mskTelefone.Clear();

            telefoneClienteSelecionado = "";
            idClienteSelecionado = null;

            lblNomeClienteVenda.Text = "Cliente não selecionado";

            AtualizarTotaisVenda();
        }

        // MÉTODOS AUXILIARES E EVENTOS DO DESIGNER

        private void pnlVendas_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlProdutos_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dgvClientes_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow linha = dgvClientes.Rows[e.RowIndex];

            if (linha.Tag == null)
                return;

            idClienteCadastroSelecionado = Convert.ToInt32(linha.Tag);

            txtNomeCliente.Text =
                Convert.ToString(linha.Cells["colNomeCliente"].Value);

            txtTelefoneCliente.Text =
                Convert.ToString(linha.Cells["colTelefoneCliente"].Value);

            txtEmailCliente.Text =
                Convert.ToString(linha.Cells["colEmailCliente"].Value);

            txtEnderecoCliente.Text =
                Convert.ToString(linha.Cells["colEnderecoCliente"].Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void btnExcluirCliente_Click_1(object sender, EventArgs e)
        {
        }

        private void pnlEstoque_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {
        }

        private void pnlClientes_Paint(object sender, PaintEventArgs e)
        {
        }

        // RELATÓRIO DE VENDAS

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlProdutos.Visible = false;
            pnlClientes.Visible = false;
            pnlVendas.Visible = false;

            pnlRelatorio.Visible = true;
            pnlRelatorio.BringToFront();

            CarregarRelatorioVendas();
        }

        // Consulta as vendas no banco e preenche a tabela do relatório.
        private void CarregarRelatorioVendas()
        {
            dgvRelatorioVendas.Rows.Clear();

            // Busca o cliente pela tabela clientes
            // e o produto pela tabela produtos.
            string sql = @"
                SELECT
                    v.data_venda,
                    c.nome AS nome_cliente_venda,
                    p.nome AS nome_produto_venda,
                    i.quantidade,
                    i.preco_unitario,
                    i.subtotal,
                    v.forma_pagamento
                FROM vendas v
                INNER JOIN clientes c
                    ON c.id_cliente = v.id_cliente
                INNER JOIN itens_venda i
                    ON i.id_venda = v.id_venda
                INNER JOIN produtos p
                    ON p.id_produto = i.id_produto
                ORDER BY v.data_venda DESC, v.id_venda DESC";

            try
            {
                using (MySqlConnection conexao = Conexao.Criar())
                {
                    conexao.Open();

                    using (MySqlCommand comando =
                           new MySqlCommand(sql, conexao))
                    using (MySqlDataReader leitor = comando.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            dgvRelatorioVendas.Rows.Add(
                                Convert.ToDateTime(leitor["data_venda"])
                                    .ToString("dd/MM/yyyy HH:mm", cultura),

                                Convert.ToString(
                                    leitor["nome_cliente_venda"]),

                                Convert.ToString(
                                    leitor["nome_produto_venda"]),

                                Convert.ToInt32(
                                    leitor["quantidade"]),

                                Convert.ToDecimal(
                                    leitor["preco_unitario"])
                                    .ToString("C2", cultura),

                                Convert.ToDecimal(
                                    leitor["subtotal"])
                                    .ToString("C2", cultura),

                                Convert.ToString(
                                    leitor["forma_pagamento"])
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao carregar o relatório: " + ex.Message);
            }
        }

        private void lnlituloInicio_Click(object sender, EventArgs e)
        {

        }

        private void label1lblMensagemInicio_Click(object sender, EventArgs e)
        {

        }
    }
}