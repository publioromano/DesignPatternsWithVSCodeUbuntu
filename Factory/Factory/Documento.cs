namespace Factory
{
    public abstract class Documento
    {
        public string Nome {get;set;}
        public string Conteudo {get;set;}
        public abstract string GetTipoDocumento();
        public abstract bool ExtensaoValida(string extensao);
    }
}