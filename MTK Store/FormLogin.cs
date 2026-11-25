using MySql.Data.MySqlClient;
using System.Drawing;

namespace MTK_Store
{
    public class FormLogin : Form
    {
        private readonly TextBox txtUsuario = new();
        private readonly TextBox txtSenha = new();
        private readonly Button btnEntrar = new();
        private readonly LinkLabel linkCadastro = new();

        public FormLogin()
        {
            Text = "MTK Store - Login";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(430, 480);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            BackColor = Color.FromArgb(248, 245, 247);

            Label titulo = new() { Text = "MTK STORE", Font = new Font("Segoe UI", 23, FontStyle.Bold), ForeColor = Color.FromArgb(166, 77, 121), AutoSize = true, Location = new Point(115, 45) };
            Label subtitulo = new() { Text = "Acesse sua conta", Font = new Font("Segoe UI", 11), ForeColor = Color.DimGray, AutoSize = true, Location = new Point(150, 95) };
            Label lblUsuario = new() { Text = "Usuário ou e-mail", Location = new Point(55, 155), AutoSize = true, Font = new Font("Segoe UI", 10) };
            txtUsuario.SetBounds(55, 180, 305, 36); txtUsuario.Font = new Font("Segoe UI", 11);
            Label lblSenha = new() { Text = "Senha", Location = new Point(55, 235), AutoSize = true, Font = new Font("Segoe UI", 10) };
            txtSenha.SetBounds(55, 260, 305, 36); txtSenha.Font = new Font("Segoe UI", 11); txtSenha.UseSystemPasswordChar = true;
            btnEntrar.Text = "ENTRAR"; btnEntrar.SetBounds(55, 325, 305, 42); btnEntrar.BackColor = Color.FromArgb(166, 77, 121); btnEntrar.ForeColor = Color.White; btnEntrar.FlatStyle = FlatStyle.Flat; btnEntrar.Font = new Font("Segoe UI", 10, FontStyle.Bold); btnEntrar.Click += BtnEntrar_Click;
            linkCadastro.Text = "Ainda não tem conta? Cadastre-se"; linkCadastro.AutoSize = true; linkCadastro.Location = new Point(105, 390); linkCadastro.LinkColor = Color.FromArgb(166, 77, 121); linkCadastro.Click += (_, _) => { using FormCadastro cadastro = new(); cadastro.ShowDialog(this); };
            AcceptButton = btnEntrar;
            Controls.AddRange(new Control[] { titulo, subtitulo, lblUsuario, txtUsuario, lblSenha, txtSenha, btnEntrar, linkCadastro });
        }

        private void BtnEntrar_Click(object? sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;
            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Informe o usuário/e-mail e a senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using MySqlConnection conexao = Conexao.Criar();
                conexao.Open();
                using MySqlCommand comando = new("SELECT senha_hash FROM usuarios WHERE usuario = @usuario OR email = @usuario LIMIT 1", conexao);
                comando.Parameters.AddWithValue("@usuario", usuario);
                object? resultado = comando.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value || !SegurancaSenha.Verificar(senha, Convert.ToString(resultado)!))
                {
                    MessageBox.Show("Usuário/e-mail ou senha incorretos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSenha.Clear(); txtSenha.Focus();
                    return;
                }

                Hide();
                using Form1 sistema = new();
                sistema.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar o login. Verifique a conexão com o banco de dados.\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
