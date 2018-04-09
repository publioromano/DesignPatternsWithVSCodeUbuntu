namespace Factory
{
    public class FabricaDocumentoXml : FabricaDocumento
    {
        public override Documento CriarDocumento()
        {
            this._doc = new DocumentoXml();
            return this._doc;
        }
    }
}