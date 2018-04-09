namespace Factory
{
    public class FabricaDocumentoDat : FabricaDocumento
    {
        public override Documento CriarDocumento()
        {
            this._doc = new DocumentoDat();
            return this._doc;
        }
    }
}