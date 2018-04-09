using System;

namespace Factory
{
    public abstract class FabricaDocumento
    {
        protected Documento _doc;
        public abstract Documento CriarDocumento();

        public string GetNome() => this._doc.Nome;
        public string GetConteudo() => this._doc.Conteudo;
        public string GetTipoDocumento() => this._doc.GetTipoDocumento();
        public bool ExtensaoValida()
        {
            var splitNome = this._doc.Nome.Split('.');
            var len = splitNome.Length;
            return this._doc.ExtensaoValida(splitNome[len - 1]);
        }



    }
}