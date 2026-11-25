namespace MTK_Store
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            pnlMenu = new Panel();
            btnRelatorio = new Button();
            btnVendas = new Button();
            btnClientes = new Button();
            btnProdutos = new Button();
            btnInicio = new Button();
            lblNomeLoja = new Label();
            lblSubtitulo = new Label();
            pnlConteudo = new Panel();
            pnlProdutos = new Panel();
            dgvProdutos = new DataGridView();
            ColNome = new DataGridViewTextBoxColumn();
            ColCategoria = new DataGridViewTextBoxColumn();
            ColPreco = new DataGridViewTextBoxColumn();
            ColQuantidade = new DataGridViewTextBoxColumn();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            btncadastrar = new Button();
            txtQuantidade = new TextBox();
            lblQuantidade = new Label();
            txtPreco = new TextBox();
            lblPreco = new Label();
            txtCategoria = new TextBox();
            lblCategoria = new Label();
            txtNomeProduto = new TextBox();
            lblNomeProduto = new Label();
            lblTituloProdutos = new Label();
            pnlRelatorio = new Panel();
            lblTituloRelatorio = new Label();
            dgvRelatorioVendas = new DataGridView();
            colDataVenda = new DataGridViewTextBoxColumn();
            colClienteVenda = new DataGridViewTextBoxColumn();
            colProdutoVendido = new DataGridViewTextBoxColumn();
            colQuantidadeVendida = new DataGridViewTextBoxColumn();
            colPrecoUnitario = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colFormaPagamento = new DataGridViewTextBoxColumn();
            pnlClientes = new Panel();
            dgvClientes = new DataGridView();
            colNomeCliente = new DataGridViewTextBoxColumn();
            colTelefoneCliente = new DataGridViewTextBoxColumn();
            colEmailCliente = new DataGridViewTextBoxColumn();
            colEnderecoCliente = new DataGridViewTextBoxColumn();
            btnLimparCliente = new Button();
            btnExcluirCliente = new Button();
            btnAlterarCliente = new Button();
            btnCadastrarCliente = new Button();
            txtEnderecoCliente = new TextBox();
            txtNomeCliente = new TextBox();
            txtEmailCliente = new TextBox();
            txtTelefoneCliente = new TextBox();
            lblEnderecoCliente = new Label();
            lblEmailCliente = new Label();
            lblTelefoneCliente = new Label();
            lblNomeCliente = new Label();
            lblTituloClientes = new Label();
            pnlVendas = new Panel();
            lblNomeClienteVenda = new Label();
            btnBuscarCliente = new Button();
            mskTelefone = new MaskedTextBox();
            lbltelefone = new Label();
            btnLimparVenda = new Button();
            btnFinalizarVenda = new Button();
            btnRemoverItem = new Button();
            lblTotalVenda = new Label();
            lblSubtotalVenda = new Label();
            cboFormaPagamento = new ComboBox();
            lblFormaPagamento = new Label();
            dgvItensVenda = new DataGridView();
            Produto = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            PrecoUnitario = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btnAdicionarItem = new Button();
            txtQuantidadeVenda = new TextBox();
            lblQuantidadeVenda = new Label();
            cboProdutoVenda = new ComboBox();
            lblProdutoVenda = new Label();
            lblTituloVendas = new Label();
            pnlInicio = new Panel();
            label1lblMensagemInicio = new Label();
            lnlituloInicio = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pnlMenu.SuspendLayout();
            pnlConteudo.SuspendLayout();
            pnlProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            pnlRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorioVendas).BeginInit();
            pnlClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            pnlVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).BeginInit();
            pnlInicio.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.PaleVioletRed;
            pnlMenu.Controls.Add(btnRelatorio);
            pnlMenu.Controls.Add(btnVendas);
            pnlMenu.Controls.Add(btnClientes);
            pnlMenu.Controls.Add(btnProdutos);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(lblNomeLoja);
            pnlMenu.Controls.Add(lblSubtitulo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(219, 795);
            pnlMenu.TabIndex = 0;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.White;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.ForeColor = Color.PaleVioletRed;
            btnRelatorio.Location = new Point(16, 741);
            btnRelatorio.Margin = new Padding(3, 4, 3, 4);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(179, 41);
            btnRelatorio.TabIndex = 5;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.White;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.ForeColor = Color.PaleVioletRed;
            btnVendas.Location = new Point(16, 573);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(181, 40);
            btnVendas.TabIndex = 4;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.White;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.ForeColor = Color.PaleVioletRed;
            btnClientes.Location = new Point(17, 405);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(181, 40);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.White;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.ForeColor = Color.PaleVioletRed;
            btnProdutos.Location = new Point(16, 248);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(181, 40);
            btnProdutos.TabIndex = 2;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.White;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.ForeColor = Color.PaleVioletRed;
            btnInicio.Location = new Point(17, 109);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(181, 40);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // lblNomeLoja
            // 
            lblNomeLoja.AutoSize = true;
            lblNomeLoja.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeLoja.ForeColor = Color.White;
            lblNomeLoja.Location = new Point(9, 9);
            lblNomeLoja.Name = "lblNomeLoja";
            lblNomeLoja.Size = new Size(208, 46);
            lblNomeLoja.TabIndex = 0;
            lblNomeLoja.Text = "MTK STORE";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.PaleVioletRed;
            lblSubtitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(22, 65);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(175, 20);
            lblSubtitulo.TabIndex = 0;
            lblSubtitulo.Text = "Sistema de loja de roupa";
            // 
            // pnlConteudo
            // 
            pnlConteudo.Controls.Add(pnlInicio);
            pnlConteudo.Controls.Add(pnlProdutos);
            pnlConteudo.Controls.Add(pnlRelatorio);
            pnlConteudo.Controls.Add(pnlClientes);
            pnlConteudo.Controls.Add(pnlVendas);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(0, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(1811, 795);
            pnlConteudo.TabIndex = 1;
            // 
            // pnlProdutos
            // 
            pnlProdutos.Controls.Add(dgvProdutos);
            pnlProdutos.Controls.Add(btnLimpar);
            pnlProdutos.Controls.Add(btnExcluir);
            pnlProdutos.Controls.Add(btnAlterar);
            pnlProdutos.Controls.Add(btncadastrar);
            pnlProdutos.Controls.Add(txtQuantidade);
            pnlProdutos.Controls.Add(lblQuantidade);
            pnlProdutos.Controls.Add(txtPreco);
            pnlProdutos.Controls.Add(lblPreco);
            pnlProdutos.Controls.Add(txtCategoria);
            pnlProdutos.Controls.Add(lblCategoria);
            pnlProdutos.Controls.Add(txtNomeProduto);
            pnlProdutos.Controls.Add(lblNomeProduto);
            pnlProdutos.Controls.Add(lblTituloProdutos);
            pnlProdutos.Dock = DockStyle.Fill;
            pnlProdutos.Location = new Point(0, 0);
            pnlProdutos.Name = "pnlProdutos";
            pnlProdutos.Size = new Size(1811, 795);
            pnlProdutos.TabIndex = 0;
            pnlProdutos.Paint += pnlProdutos_Paint;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.BackgroundColor = Color.White;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { ColNome, ColCategoria, ColPreco, ColQuantidade });
            dgvProdutos.Location = new Point(357, 600);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(1437, 344);
            dgvProdutos.TabIndex = 14;
            dgvProdutos.CellClick += dgvProdutos_CellContentClick;
            // 
            // ColNome
            // 
            ColNome.HeaderText = "Nome";
            ColNome.MinimumWidth = 6;
            ColNome.Name = "ColNome";
            ColNome.ReadOnly = true;
            // 
            // ColCategoria
            // 
            ColCategoria.HeaderText = "Categoria";
            ColCategoria.MinimumWidth = 6;
            ColCategoria.Name = "ColCategoria";
            ColCategoria.ReadOnly = true;
            // 
            // ColPreco
            // 
            ColPreco.HeaderText = "Preço";
            ColPreco.MinimumWidth = 6;
            ColPreco.Name = "ColPreco";
            ColPreco.ReadOnly = true;
            // 
            // ColQuantidade
            // 
            ColQuantidade.HeaderText = "Quantidade";
            ColQuantidade.MinimumWidth = 6;
            ColQuantidade.Name = "ColQuantidade";
            ColQuantidade.ReadOnly = true;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.PaleVioletRed;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(1486, 509);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 40);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.PaleVioletRed;
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(1176, 509);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 40);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.PaleVioletRed;
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(848, 509);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(110, 40);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btncadastrar
            // 
            btncadastrar.BackColor = Color.PaleVioletRed;
            btncadastrar.ForeColor = Color.White;
            btncadastrar.Location = new Point(551, 509);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(110, 40);
            btncadastrar.TabIndex = 10;
            btncadastrar.Text = "Cadastrar";
            btncadastrar.UseVisualStyleBackColor = false;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(1083, 388);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(203, 27);
            txtQuantidade.TabIndex = 9;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(843, 389);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(172, 20);
            lblQuantidade.TabIndex = 8;
            lblQuantidade.Text = "Quantidade em estoque:";
            lblQuantidade.Click += lblQuantidade_Click;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(1083, 308);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(203, 27);
            txtPreco.TabIndex = 7;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(843, 307);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(145, 20);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preço de venda (R$):";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(1083, 229);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(203, 27);
            txtCategoria.TabIndex = 5;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(843, 224);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(1083, 161);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(203, 27);
            txtNomeProduto.TabIndex = 2;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(843, 156);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(111, 20);
            lblNomeProduto.TabIndex = 1;
            lblNomeProduto.Text = "Nome produto:";
            // 
            // lblTituloProdutos
            // 
            lblTituloProdutos.AutoSize = true;
            lblTituloProdutos.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloProdutos.ForeColor = Color.PaleVioletRed;
            lblTituloProdutos.Location = new Point(877, 43);
            lblTituloProdutos.Name = "lblTituloProdutos";
            lblTituloProdutos.Size = new Size(365, 46);
            lblTituloProdutos.TabIndex = 0;
            lblTituloProdutos.Text = "Cadastro de Produtos";
            // 
            // pnlRelatorio
            // 
            pnlRelatorio.Controls.Add(lblTituloRelatorio);
            pnlRelatorio.Controls.Add(dgvRelatorioVendas);
            pnlRelatorio.Location = new Point(0, 0);
            pnlRelatorio.Margin = new Padding(3, 4, 3, 4);
            pnlRelatorio.Name = "pnlRelatorio";
            pnlRelatorio.Size = new Size(1828, 749);
            pnlRelatorio.TabIndex = 16;
            // 
            // lblTituloRelatorio
            // 
            lblTituloRelatorio.AutoSize = true;
            lblTituloRelatorio.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRelatorio.ForeColor = Color.PaleVioletRed;
            lblTituloRelatorio.Location = new Point(895, 55);
            lblTituloRelatorio.Name = "lblTituloRelatorio";
            lblTituloRelatorio.Size = new Size(337, 46);
            lblTituloRelatorio.TabIndex = 1;
            lblTituloRelatorio.Text = "Relatório de Vendas";
            // 
            // dgvRelatorioVendas
            // 
            dgvRelatorioVendas.AllowUserToAddRows = false;
            dgvRelatorioVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRelatorioVendas.BackgroundColor = Color.White;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvRelatorioVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvRelatorioVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorioVendas.Columns.AddRange(new DataGridViewColumn[] { colDataVenda, colClienteVenda, colProdutoVendido, colQuantidadeVendida, colPrecoUnitario, colSubtotal, colFormaPagamento });
            dgvRelatorioVendas.Location = new Point(585, 229);
            dgvRelatorioVendas.Margin = new Padding(3, 4, 3, 4);
            dgvRelatorioVendas.Name = "dgvRelatorioVendas";
            dgvRelatorioVendas.ReadOnly = true;
            dgvRelatorioVendas.RowHeadersWidth = 51;
            dgvRelatorioVendas.ScrollBars = ScrollBars.Vertical;
            dgvRelatorioVendas.Size = new Size(971, 440);
            dgvRelatorioVendas.TabIndex = 0;
            // 
            // colDataVenda
            // 
            colDataVenda.HeaderText = "Data";
            colDataVenda.MinimumWidth = 6;
            colDataVenda.Name = "colDataVenda";
            colDataVenda.ReadOnly = true;
            // 
            // colClienteVenda
            // 
            colClienteVenda.HeaderText = "Cliente";
            colClienteVenda.MinimumWidth = 6;
            colClienteVenda.Name = "colClienteVenda";
            colClienteVenda.ReadOnly = true;
            // 
            // colProdutoVendido
            // 
            colProdutoVendido.HeaderText = "Produto";
            colProdutoVendido.MinimumWidth = 6;
            colProdutoVendido.Name = "colProdutoVendido";
            colProdutoVendido.ReadOnly = true;
            // 
            // colQuantidadeVendida
            // 
            colQuantidadeVendida.HeaderText = "Quantidade";
            colQuantidadeVendida.MinimumWidth = 6;
            colQuantidadeVendida.Name = "colQuantidadeVendida";
            colQuantidadeVendida.ReadOnly = true;
            // 
            // colPrecoUnitario
            // 
            colPrecoUnitario.HeaderText = "Valor Unitário";
            colPrecoUnitario.MinimumWidth = 6;
            colPrecoUnitario.Name = "colPrecoUnitario";
            colPrecoUnitario.ReadOnly = true;
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal do item";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // colFormaPagamento
            // 
            colFormaPagamento.HeaderText = "Pagamento";
            colFormaPagamento.MinimumWidth = 6;
            colFormaPagamento.Name = "colFormaPagamento";
            colFormaPagamento.ReadOnly = true;
            // 
            // pnlClientes
            // 
            pnlClientes.Controls.Add(dgvClientes);
            pnlClientes.Controls.Add(btnLimparCliente);
            pnlClientes.Controls.Add(btnExcluirCliente);
            pnlClientes.Controls.Add(btnAlterarCliente);
            pnlClientes.Controls.Add(btnCadastrarCliente);
            pnlClientes.Controls.Add(txtEnderecoCliente);
            pnlClientes.Controls.Add(txtNomeCliente);
            pnlClientes.Controls.Add(txtEmailCliente);
            pnlClientes.Controls.Add(txtTelefoneCliente);
            pnlClientes.Controls.Add(lblEnderecoCliente);
            pnlClientes.Controls.Add(lblEmailCliente);
            pnlClientes.Controls.Add(lblTelefoneCliente);
            pnlClientes.Controls.Add(lblNomeCliente);
            pnlClientes.Controls.Add(lblTituloClientes);
            pnlClientes.Dock = DockStyle.Fill;
            pnlClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlClientes.Location = new Point(0, 0);
            pnlClientes.Margin = new Padding(3, 4, 3, 4);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(1811, 795);
            pnlClientes.TabIndex = 2;
            pnlClientes.Visible = false;
            pnlClientes.Paint += pnlClientes_Paint;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colNomeCliente, colTelefoneCliente, colEmailCliente, colEnderecoCliente });
            dgvClientes.Location = new Point(357, 600);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1437, 344);
            dgvClientes.TabIndex = 13;
            // 
            // colNomeCliente
            // 
            colNomeCliente.HeaderText = "Nome Completo";
            colNomeCliente.MinimumWidth = 6;
            colNomeCliente.Name = "colNomeCliente";
            colNomeCliente.ReadOnly = true;
            // 
            // colTelefoneCliente
            // 
            colTelefoneCliente.HeaderText = "Telefone";
            colTelefoneCliente.MinimumWidth = 6;
            colTelefoneCliente.Name = "colTelefoneCliente";
            colTelefoneCliente.ReadOnly = true;
            // 
            // colEmailCliente
            // 
            colEmailCliente.HeaderText = "E-mail";
            colEmailCliente.MinimumWidth = 6;
            colEmailCliente.Name = "colEmailCliente";
            colEmailCliente.ReadOnly = true;
            // 
            // colEnderecoCliente
            // 
            colEnderecoCliente.HeaderText = "Endereço";
            colEnderecoCliente.MinimumWidth = 6;
            colEnderecoCliente.Name = "colEnderecoCliente";
            colEnderecoCliente.ReadOnly = true;
            // 
            // btnLimparCliente
            // 
            btnLimparCliente.BackColor = Color.PaleVioletRed;
            btnLimparCliente.Font = new Font("Microsoft Sans Serif", 7.8F);
            btnLimparCliente.ForeColor = Color.White;
            btnLimparCliente.Location = new Point(1486, 509);
            btnLimparCliente.Margin = new Padding(3, 4, 3, 4);
            btnLimparCliente.Name = "btnLimparCliente";
            btnLimparCliente.Size = new Size(110, 40);
            btnLimparCliente.TabIndex = 12;
            btnLimparCliente.Text = "Limpar";
            btnLimparCliente.UseVisualStyleBackColor = false;
            btnLimparCliente.Click += button4_Click;
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.BackColor = Color.PaleVioletRed;
            btnExcluirCliente.Font = new Font("Microsoft Sans Serif", 7.8F);
            btnExcluirCliente.ForeColor = Color.White;
            btnExcluirCliente.Location = new Point(1176, 509);
            btnExcluirCliente.Margin = new Padding(3, 4, 3, 4);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(110, 40);
            btnExcluirCliente.TabIndex = 11;
            btnExcluirCliente.Text = "Excluir";
            btnExcluirCliente.UseVisualStyleBackColor = false;
            btnExcluirCliente.Click += btnExcluirCliente_Click_1;
            // 
            // btnAlterarCliente
            // 
            btnAlterarCliente.BackColor = Color.PaleVioletRed;
            btnAlterarCliente.Font = new Font("Microsoft Sans Serif", 7.8F);
            btnAlterarCliente.ForeColor = Color.White;
            btnAlterarCliente.Location = new Point(848, 509);
            btnAlterarCliente.Margin = new Padding(3, 4, 3, 4);
            btnAlterarCliente.Name = "btnAlterarCliente";
            btnAlterarCliente.Size = new Size(110, 40);
            btnAlterarCliente.TabIndex = 10;
            btnAlterarCliente.Text = "Alterar";
            btnAlterarCliente.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.BackColor = Color.PaleVioletRed;
            btnCadastrarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrarCliente.ForeColor = Color.White;
            btnCadastrarCliente.Location = new Point(551, 509);
            btnCadastrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(110, 40);
            btnCadastrarCliente.TabIndex = 9;
            btnCadastrarCliente.Text = "Cadastrar";
            btnCadastrarCliente.UseVisualStyleBackColor = false;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // txtEnderecoCliente
            // 
            txtEnderecoCliente.Font = new Font("Microsoft Sans Serif", 7.8F);
            txtEnderecoCliente.Location = new Point(987, 351);
            txtEnderecoCliente.Margin = new Padding(3, 4, 3, 4);
            txtEnderecoCliente.Multiline = true;
            txtEnderecoCliente.Name = "txtEnderecoCliente";
            txtEnderecoCliente.Size = new Size(333, 27);
            txtEnderecoCliente.TabIndex = 8;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Microsoft Sans Serif", 7.8F);
            txtNomeCliente.Location = new Point(985, 156);
            txtNomeCliente.Margin = new Padding(3, 4, 3, 4);
            txtNomeCliente.Multiline = true;
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(333, 27);
            txtNomeCliente.TabIndex = 7;
            txtNomeCliente.TextChanged += textBox3_TextChanged;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Font = new Font("Microsoft Sans Serif", 7.8F);
            txtEmailCliente.Location = new Point(987, 284);
            txtEmailCliente.Margin = new Padding(3, 4, 3, 4);
            txtEmailCliente.Multiline = true;
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(333, 27);
            txtEmailCliente.TabIndex = 6;
            // 
            // txtTelefoneCliente
            // 
            txtTelefoneCliente.Font = new Font("Microsoft Sans Serif", 7.8F);
            txtTelefoneCliente.Location = new Point(985, 224);
            txtTelefoneCliente.Margin = new Padding(3, 4, 3, 4);
            txtTelefoneCliente.Multiline = true;
            txtTelefoneCliente.Name = "txtTelefoneCliente";
            txtTelefoneCliente.Size = new Size(333, 27);
            txtTelefoneCliente.TabIndex = 5;
            // 
            // lblEnderecoCliente
            // 
            lblEnderecoCliente.AutoSize = true;
            lblEnderecoCliente.Font = new Font("Microsoft Sans Serif", 7.8F);
            lblEnderecoCliente.Location = new Point(753, 363);
            lblEnderecoCliente.Name = "lblEnderecoCliente";
            lblEnderecoCliente.Size = new Size(69, 16);
            lblEnderecoCliente.TabIndex = 4;
            lblEnderecoCliente.Text = "Endereço:";
            // 
            // lblEmailCliente
            // 
            lblEmailCliente.AutoSize = true;
            lblEmailCliente.Font = new Font("Microsoft Sans Serif", 7.8F);
            lblEmailCliente.Location = new Point(753, 291);
            lblEmailCliente.Name = "lblEmailCliente";
            lblEmailCliente.Size = new Size(48, 16);
            lblEmailCliente.TabIndex = 3;
            lblEmailCliente.Text = "E-mail:";
            // 
            // lblTelefoneCliente
            // 
            lblTelefoneCliente.AutoSize = true;
            lblTelefoneCliente.Font = new Font("Microsoft Sans Serif", 7.8F);
            lblTelefoneCliente.Location = new Point(749, 224);
            lblTelefoneCliente.Name = "lblTelefoneCliente";
            lblTelefoneCliente.Size = new Size(64, 16);
            lblTelefoneCliente.TabIndex = 2;
            lblTelefoneCliente.Text = "Telefone:";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Font = new Font("Microsoft Sans Serif", 7.8F);
            lblNomeCliente.Location = new Point(749, 156);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(106, 16);
            lblNomeCliente.TabIndex = 1;
            lblNomeCliente.Text = "\tNome completo:";
            lblNomeCliente.Click += label1_Click;
            // 
            // lblTituloClientes
            // 
            lblTituloClientes.AutoSize = true;
            lblTituloClientes.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloClientes.ForeColor = Color.PaleVioletRed;
            lblTituloClientes.Location = new Point(877, 43);
            lblTituloClientes.Name = "lblTituloClientes";
            lblTituloClientes.Size = new Size(344, 46);
            lblTituloClientes.TabIndex = 0;
            lblTituloClientes.Text = "Cadastro de Clientes";
            // 
            // pnlVendas
            // 
            pnlVendas.Controls.Add(lblNomeClienteVenda);
            pnlVendas.Controls.Add(btnBuscarCliente);
            pnlVendas.Controls.Add(mskTelefone);
            pnlVendas.Controls.Add(lbltelefone);
            pnlVendas.Controls.Add(btnLimparVenda);
            pnlVendas.Controls.Add(btnFinalizarVenda);
            pnlVendas.Controls.Add(btnRemoverItem);
            pnlVendas.Controls.Add(lblTotalVenda);
            pnlVendas.Controls.Add(lblSubtotalVenda);
            pnlVendas.Controls.Add(cboFormaPagamento);
            pnlVendas.Controls.Add(lblFormaPagamento);
            pnlVendas.Controls.Add(dgvItensVenda);
            pnlVendas.Controls.Add(btnAdicionarItem);
            pnlVendas.Controls.Add(txtQuantidadeVenda);
            pnlVendas.Controls.Add(lblQuantidadeVenda);
            pnlVendas.Controls.Add(cboProdutoVenda);
            pnlVendas.Controls.Add(lblProdutoVenda);
            pnlVendas.Controls.Add(lblTituloVendas);
            pnlVendas.Dock = DockStyle.Fill;
            pnlVendas.Location = new Point(0, 0);
            pnlVendas.Name = "pnlVendas";
            pnlVendas.Size = new Size(1811, 795);
            pnlVendas.TabIndex = 2;
            pnlVendas.Visible = false;
            pnlVendas.Paint += pnlVendas_Paint;
            // 
            // lblNomeClienteVenda
            // 
            lblNomeClienteVenda.AutoSize = true;
            lblNomeClienteVenda.Location = new Point(1303, 152);
            lblNomeClienteVenda.Name = "lblNomeClienteVenda";
            lblNomeClienteVenda.Size = new Size(168, 20);
            lblNomeClienteVenda.TabIndex = 18;
            lblNomeClienteVenda.Text = "Cliente não selecionado";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.BackColor = Color.PaleVioletRed;
            btnBuscarCliente.ForeColor = Color.White;
            btnBuscarCliente.Location = new Point(1107, 139);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(110, 40);
            btnBuscarCliente.TabIndex = 17;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(849, 145);
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(149, 27);
            mskTelefone.TabIndex = 16;
            mskTelefone.Text = "(00) 00000-0000";
            // 
            // lbltelefone
            // 
            lbltelefone.AutoSize = true;
            lbltelefone.Location = new Point(690, 148);
            lbltelefone.Name = "lbltelefone";
            lbltelefone.Size = new Size(69, 20);
            lbltelefone.TabIndex = 14;
            lbltelefone.Text = "Telefone:";
            // 
            // btnLimparVenda
            // 
            btnLimparVenda.BackColor = Color.PaleVioletRed;
            btnLimparVenda.ForeColor = Color.White;
            btnLimparVenda.Location = new Point(1197, 924);
            btnLimparVenda.Name = "btnLimparVenda";
            btnLimparVenda.Size = new Size(110, 40);
            btnLimparVenda.TabIndex = 13;
            btnLimparVenda.Text = "Limpar";
            btnLimparVenda.UseVisualStyleBackColor = false;
            // 
            // btnFinalizarVenda
            // 
            btnFinalizarVenda.BackColor = Color.PaleVioletRed;
            btnFinalizarVenda.ForeColor = Color.White;
            btnFinalizarVenda.Location = new Point(970, 924);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.Size = new Size(110, 40);
            btnFinalizarVenda.TabIndex = 12;
            btnFinalizarVenda.Text = "Finalizar";
            btnFinalizarVenda.UseVisualStyleBackColor = false;
            btnFinalizarVenda.Click += btnFinalizarVenda_Click;
            // 
            // btnRemoverItem
            // 
            btnRemoverItem.BackColor = Color.PaleVioletRed;
            btnRemoverItem.ForeColor = Color.White;
            btnRemoverItem.Location = new Point(737, 924);
            btnRemoverItem.Name = "btnRemoverItem";
            btnRemoverItem.Size = new Size(110, 40);
            btnRemoverItem.TabIndex = 11;
            btnRemoverItem.Text = "Remover";
            btnRemoverItem.UseVisualStyleBackColor = false;
            // 
            // lblTotalVenda
            // 
            lblTotalVenda.AutoSize = true;
            lblTotalVenda.Location = new Point(1128, 809);
            lblTotalVenda.Name = "lblTotalVenda";
            lblTotalVenda.Size = new Size(93, 20);
            lblTotalVenda.TabIndex = 10;
            lblTotalVenda.Text = "Total: R$0,00";
            // 
            // lblSubtotalVenda
            // 
            lblSubtotalVenda.AutoSize = true;
            lblSubtotalVenda.Location = new Point(851, 809);
            lblSubtotalVenda.Name = "lblSubtotalVenda";
            lblSubtotalVenda.Size = new Size(116, 20);
            lblSubtotalVenda.TabIndex = 9;
            lblSubtotalVenda.Text = "Subtotal: R$0,00";
            // 
            // cboFormaPagamento
            // 
            cboFormaPagamento.FormattingEnabled = true;
            cboFormaPagamento.Items.AddRange(new object[] { "Pix", "Dinheiro", "Débito", "Crédito" });
            cboFormaPagamento.Location = new Point(1045, 707);
            cboFormaPagamento.Name = "cboFormaPagamento";
            cboFormaPagamento.Size = new Size(151, 28);
            cboFormaPagamento.TabIndex = 8;
            // 
            // lblFormaPagamento
            // 
            lblFormaPagamento.AutoSize = true;
            lblFormaPagamento.Location = new Point(874, 709);
            lblFormaPagamento.Name = "lblFormaPagamento";
            lblFormaPagamento.Size = new Size(156, 20);
            lblFormaPagamento.TabIndex = 7;
            lblFormaPagamento.Text = "Forma de pagamento:";
            // 
            // dgvItensVenda
            // 
            dgvItensVenda.AllowUserToAddRows = false;
            dataGridViewCellStyle12.BackColor = Color.PaleVioletRed;
            dgvItensVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            dgvItensVenda.BackgroundColor = Color.White;
            dgvItensVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensVenda.Columns.AddRange(new DataGridViewColumn[] { Produto, Quantidade, PrecoUnitario, Subtotal });
            dgvItensVenda.Location = new Point(753, 441);
            dgvItensVenda.Name = "dgvItensVenda";
            dgvItensVenda.RowHeadersWidth = 51;
            dgvItensVenda.Size = new Size(554, 188);
            dgvItensVenda.TabIndex = 6;
            // 
            // Produto
            // 
            Produto.HeaderText = "Produto";
            Produto.MinimumWidth = 6;
            Produto.Name = "Produto";
            Produto.Width = 125;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 6;
            Quantidade.Name = "Quantidade";
            Quantidade.Width = 125;
            // 
            // PrecoUnitario
            // 
            PrecoUnitario.HeaderText = "Preço unitário";
            PrecoUnitario.MinimumWidth = 6;
            PrecoUnitario.Name = "PrecoUnitario";
            PrecoUnitario.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 125;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.BackColor = Color.PaleVioletRed;
            btnAdicionarItem.ForeColor = Color.White;
            btnAdicionarItem.Location = new Point(969, 377);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(110, 40);
            btnAdicionarItem.TabIndex = 5;
            btnAdicionarItem.Text = "Adicionar";
            btnAdicionarItem.UseVisualStyleBackColor = false;
            // 
            // txtQuantidadeVenda
            // 
            txtQuantidadeVenda.Location = new Point(1047, 307);
            txtQuantidadeVenda.Name = "txtQuantidadeVenda";
            txtQuantidadeVenda.Size = new Size(151, 27);
            txtQuantidadeVenda.TabIndex = 4;
            // 
            // lblQuantidadeVenda
            // 
            lblQuantidadeVenda.AutoSize = true;
            lblQuantidadeVenda.Location = new Point(1073, 260);
            lblQuantidadeVenda.Name = "lblQuantidadeVenda";
            lblQuantidadeVenda.Size = new Size(87, 20);
            lblQuantidadeVenda.TabIndex = 3;
            lblQuantidadeVenda.Text = "Quantidade";
            // 
            // cboProdutoVenda
            // 
            cboProdutoVenda.FormattingEnabled = true;
            cboProdutoVenda.Location = new Point(847, 307);
            cboProdutoVenda.Name = "cboProdutoVenda";
            cboProdutoVenda.Size = new Size(151, 28);
            cboProdutoVenda.TabIndex = 2;
            // 
            // lblProdutoVenda
            // 
            lblProdutoVenda.AutoSize = true;
            lblProdutoVenda.Location = new Point(895, 260);
            lblProdutoVenda.Name = "lblProdutoVenda";
            lblProdutoVenda.Size = new Size(62, 20);
            lblProdutoVenda.TabIndex = 1;
            lblProdutoVenda.Text = "Produto";
            // 
            // lblTituloVendas
            // 
            lblTituloVendas.AutoSize = true;
            lblTituloVendas.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloVendas.ForeColor = Color.PaleVioletRed;
            lblTituloVendas.Location = new Point(877, 43);
            lblTituloVendas.Name = "lblTituloVendas";
            lblTituloVendas.Size = new Size(321, 46);
            lblTituloVendas.TabIndex = 0;
            lblTituloVendas.Text = "Registro de vendas";
            // 
            // pnlInicio
            // 
            pnlInicio.Controls.Add(label3);
            pnlInicio.Controls.Add(label2);
            pnlInicio.Controls.Add(label1);
            pnlInicio.Controls.Add(label1lblMensagemInicio);
            pnlInicio.Controls.Add(lnlituloInicio);
            pnlInicio.Dock = DockStyle.Fill;
            pnlInicio.Location = new Point(0, 0);
            pnlInicio.Margin = new Padding(3, 4, 3, 4);
            pnlInicio.Name = "pnlInicio";
            pnlInicio.Size = new Size(1811, 795);
            pnlInicio.TabIndex = 15;
            pnlInicio.Visible = false;
            // 
            // label1lblMensagemInicio
            // 
            label1lblMensagemInicio.AutoSize = true;
            label1lblMensagemInicio.ForeColor = SystemColors.GrayText;
            label1lblMensagemInicio.Location = new Point(919, 248);
            label1lblMensagemInicio.Name = "label1lblMensagemInicio";
            label1lblMensagemInicio.Size = new Size(279, 20);
            label1lblMensagemInicio.TabIndex = 1;
            label1lblMensagemInicio.Text = "Seu espaço de moda, estilo e novidades!";
            label1lblMensagemInicio.Click += label1lblMensagemInicio_Click;
            // 
            // lnlituloInicio
            // 
            lnlituloInicio.AutoSize = true;
            lnlituloInicio.BackColor = Color.Transparent;
            lnlituloInicio.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnlituloInicio.ForeColor = Color.PaleVioletRed;
            lnlituloInicio.Location = new Point(837, 182);
            lnlituloInicio.Name = "lnlituloInicio";
            lnlituloInicio.Size = new Size(449, 54);
            lnlituloInicio.TabIndex = 0;
            lnlituloInicio.Text = "Bem-vinda à MTK Store!";
            lnlituloInicio.Click += lnlituloInicio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PaleVioletRed;
            label1.Location = new Point(341, 495);
            label1.Name = "label1";
            label1.Size = new Size(168, 17);
            label1.TabIndex = 2;
            label1.Text = "Trabalho desenvolvido por:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(341, 529);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 3;
            label2.Text = "Kátia Tamaishi Mezete;";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(341, 562);
            label3.Name = "label3";
            label3.Size = new Size(183, 20);
            label3.TabIndex = 4;
            label3.Text = "Isabelli da SIlva Gonçalves";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1811, 795);
            Controls.Add(pnlMenu);
            Controls.Add(pnlConteudo);
            MinimumSize = new Size(1000, 595);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MTK Store - Sistema de Gerenciamento";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlConteudo.ResumeLayout(false);
            pnlProdutos.ResumeLayout(false);
            pnlProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            pnlRelatorio.ResumeLayout(false);
            pnlRelatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorioVendas).EndInit();
            pnlClientes.ResumeLayout(false);
            pnlClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            pnlVendas.ResumeLayout(false);
            pnlVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).EndInit();
            pnlInicio.ResumeLayout(false);
            pnlInicio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlConteudo;
        private Label lblSubtitulo;
        private Label lblNomeLoja;
        private Button btnInicio;
        private Button btnVendas;
        private Button btnClientes;
        private Button btnProdutos;
        private Panel pnlProdutos;
        private Label lblTituloProdutos;
        private TextBox txtNomeProduto;
        private Label lblNomeProduto;
        private Label lblCategoria;
        private TextBox txtPreco;
        private Label lblPreco;
        private TextBox txtCategoria;
        private TextBox txtQuantidade;
        private Label lblQuantidade;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnAlterar;
        private Button btncadastrar;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn ColNome;
        private DataGridViewTextBoxColumn ColCategoria;
        private DataGridViewTextBoxColumn ColPreco;
        private DataGridViewTextBoxColumn ColQuantidade;
        private Panel pnlInicio;
        private Label lnlituloInicio;
        private Label label1lblMensagemInicio;
        private Panel pnlClientes;
        private Label lblTituloClientes;
        private TextBox txtEnderecoCliente;
        private TextBox txtNomeCliente;
        private TextBox txtEmailCliente;
        private TextBox txtTelefoneCliente;
        private Label lblEnderecoCliente;
        private Label lblEmailCliente;
        private Label lblTelefoneCliente;
        private Label lblNomeCliente;
        private Button btnCadastrarCliente;
        private Button btnLimparCliente;
        private Button btnExcluirCliente;
        private Button btnAlterarCliente;
        private DataGridView dgvClientes;
        private Panel pnlVendas;
        private Label lblQuantidadeVenda;
        private ComboBox cboProdutoVenda;
        private Label lblProdutoVenda;
        private Label lblTituloVendas;
        private Button btnAdicionarItem;
        private TextBox txtQuantidadeVenda;
        private ComboBox cboFormaPagamento;
        private Label lblFormaPagamento;
        private DataGridView dgvItensVenda;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn PrecoUnitario;
        private DataGridViewTextBoxColumn Subtotal;
        private Button btnLimparVenda;
        private Button btnFinalizarVenda;
        private Button btnRemoverItem;
        private Label lblTotalVenda;
        private Label lblSubtotalVenda;
        private DataGridViewTextBoxColumn colNomeCliente;
        private DataGridViewTextBoxColumn colTelefoneCliente;
        private DataGridViewTextBoxColumn colEmailCliente;
        private DataGridViewTextBoxColumn colEnderecoCliente;
        private Label lbltelefone;
        private Button btnBuscarCliente;
        private MaskedTextBox mskTelefone;
        private Label lblNomeClienteVenda;
        private Button btnRelatorio;
        private Panel pnlRelatorio;
        private DataGridView dgvRelatorioVendas;
        private DataGridViewTextBoxColumn colDataVenda;
        private DataGridViewTextBoxColumn colClienteVenda;
        private DataGridViewTextBoxColumn colProdutoVendido;
        private DataGridViewTextBoxColumn colQuantidadeVendida;
        private DataGridViewTextBoxColumn colPrecoUnitario;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewTextBoxColumn colFormaPagamento;
        private Label lblTituloRelatorio;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
