namespace SistemaOficinaNT.Models
{
    public class Compra
    {
        public Guid id { get; set; }

        public string Solicitacao { get; set; }

        public string Placa { get; set; }

        public string Ano { get; set; }

        public string Peca { get; set; }

        public string Solicitante { get; set; }

        public int Quantidade { get; set; }

        public string Tipo { get; set; }
    }
}
