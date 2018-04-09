namespace Factory
{
    public class FabricaDocumentoHtml5 : FabricaDocumento
    {
        public override Documento CriarDocumento()
        {
            this._doc = new DocumentoHtml5();
            return this._doc;
        }
    }
}