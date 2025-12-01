namespace MinimalApi.Dominio.Entidades
{
    public class Administrador
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public bool Ativo { get; set; } = true;
    }
}
