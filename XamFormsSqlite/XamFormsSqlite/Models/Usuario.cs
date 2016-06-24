using SQLite.Net.Attributes;

namespace XamFormsSqlite.Models
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Contador { get; set; }
    }
}
