using System;

namespace Factory
{
    public class DocumentoDat : Documento, IDocumentoPlainText
    {
        public override bool ExtensaoValida(string extensao)
        {
            if (string.IsNullOrEmpty(extensao) || string.IsNullOrWhiteSpace(extensao))
                return false;
            return (string.Equals(extensao, "dat", StringComparison.InvariantCultureIgnoreCase));
        }

        public override string GetTipoDocumento()
        {
            return "dat";
        }

        public bool ComConteudo()
        {
            return string.IsNullOrEmpty(this.Conteudo);
        }
    }
}