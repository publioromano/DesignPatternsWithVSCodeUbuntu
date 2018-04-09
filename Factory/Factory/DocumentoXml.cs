using System;

namespace Factory
{

    public class DocumentoXml : Documento, IDocumentoMarkupLanguage
    {
        public override bool ExtensaoValida(string extensao)
        {
            if (string.IsNullOrEmpty(extensao) || string.IsNullOrWhiteSpace(extensao))
                return false;
            return (string.Equals(extensao, "xml", StringComparison.InvariantCultureIgnoreCase));

        }

        public string GerarCabecalho()
        {
            return "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
        }

        public override string GetTipoDocumento()
        {
            return "xml";
        }
    }
}