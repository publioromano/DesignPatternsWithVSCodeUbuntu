using System;

namespace Factory
{

    public class DocumentoTxt : Documento, IDocumentoPlainText
    {
        public override bool ExtensaoValida(string extensao)
        {
            if (string.IsNullOrEmpty(extensao) || string.IsNullOrWhiteSpace(extensao))
                return false;
            return (string.Equals(extensao, "txt", StringComparison.InvariantCultureIgnoreCase));
        }

        public override string GetTipoDocumento()
        {
            return "txt";
        }

        public bool ComConteudo()
        {
            return string.IsNullOrEmpty(this.Conteudo);
        }
    }
}