using SQLite;

namespace AppBanco.Model
{
    [Table("CREATE_LOGIN")]
    public class CreateLogin
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string? NomeCompleto { get; set; }
        public int Idade { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public string? Email { get; set; }
    }
}
