using MySql.Data.MySqlClient;

namespace MTK_Store
{
    internal static class Conexao
    {
        private const string StringConexao =
            "Server=localhost;Port=3307;Database=mtk_store;User ID=root;Password=;";

        public static MySqlConnection Criar()
        {
            return new MySqlConnection(StringConexao);
        }
    }
}