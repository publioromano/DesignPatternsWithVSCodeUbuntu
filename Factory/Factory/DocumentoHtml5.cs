using System;
namespace Factory
{

    public class DocumentoHtml5 : Documento, IDocumentoMarkupLanguage
    {
        public override bool ExtensaoValida(string extensao)
        {
            if (string.IsNullOrEmpty(extensao) || string.IsNullOrWhiteSpace(extensao))
                return false;
            return ((string.Equals(extensao, "html", StringComparison.InvariantCultureIgnoreCase))
                 || (string.Equals(extensao, "htm", StringComparison.InvariantCultureIgnoreCase)));
        }

        public string GerarCabecalho()
        {
            return "<!DOCTYPE html>";
        }

        public override string GetTipoDocumento()
        {
            return "html";
        }
    }
}