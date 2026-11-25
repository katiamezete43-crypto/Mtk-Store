using MySql.Data.MySqlClient;
using System.Drawing;

namespace MTK_Store
{
    public class FormCadastro : Form
    {
        private readonly TextBox txtNome = new();
        private readonly TextBox txtEmail = new();
        private readonly TextBox txtUsuario = new();
        private readonly TextBox txtSenha = new();
        private readonly TextBox txtConfirmarSenha = new();

        public FormCadastro()
        {
            Text = "MTK Store - Cadastro";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(450, 620);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            BackColor = Color.FromArgb(248, 245, 247);

            Label titulo = new() { Text = "CRIAR CONTA", Font = new Font("Segoe UI", 21, FontStyle.Bold), ForeColor = Color.FromArgb(166, 77, 121), AutoSize = true, Location = new Point(112, 25) };
            int y = 95;
            AdicionarCampo("Nome completo", txtNome, ref y, false);
            AdicionarCampo("E-mail", txtEmail, ref y, false);
            AdicionarCampo("Nome de usuário", txtUsuario, ref y, false);
            AdicionarCampo("Senha", txtSenha, ref y, true);
            AdicionarCampo("Confirmar senha", txtConfirmarSenha, ref y, true);

            Button btnCadastrar = new() { Text = "CADASTRAR", Bounds = new Rectangle(55, 510, 320, 42), BackColor = Color.FromArgb(166, 77, 121), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            btnCadastrar.Click += BtnCadastrar_Click;
            Controls.Add(titulo);
            Controls.Add(btnCadastrar);
            AcceptButton = btnCadastrar;
        }

        private void AdicionarCampo(string texto, TextBox caixa, ref int y, bool senha)
        {
            Label label = new() { Text = texto, Location = new Point(55, y), AutoSize = true, Font = new Font("Segoe UI", 9) };
            caixa.SetBounds(55, y + 22, 320, 31);
            caixa.Font = new Font("Segoe UI", 10);
            if (senha) caixa.UseSystemPasswordChar = true;
            Controls.Add(label); Controls.Add(caixa);
            y += 82;
        }

        private void BtnCadastrar_Click(object? sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            if (nome == "" || email == "" || usuario == "" || senha == "" || txtConfirmarSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (!email.Contains('@') || !email.Contains('.'))
            {
                MessageBox.Show("Informe um e-mail válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (senha.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (senha != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não conferem.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            try
            {
                using MySqlConnection conexao = Conexao.Criar();
                conexao.Open();
                using MySqlCommand comando = new("INSERT INTO usuarios (nome, email, usuario, senha_hash) VALUES (@nome, @email, @usuario, @senha)", conexao);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", SegurancaSenha.GerarHash(senha));
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso! Agora você já pode entrar.", "MTK Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Este e-mail ou nome de usuário já está cadastrado.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar o cadastro. Verifique a conexão com o banco.\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
