using System;
namespace Factory
{
    public class FabricaDocumentoTxt : FabricaDocumento
    {
        public override  Documento CriarDocumento()
        {
            this._doc = new DocumentoTxt();
            return this._doc;
        }
    }
}