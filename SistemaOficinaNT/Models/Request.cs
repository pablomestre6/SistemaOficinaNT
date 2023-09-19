namespace SistemaOficinaNT.Models
{
    public class Request
    {
        public Guid id { get; set; }

        public string Solicitacao { get; set; }

        public string Placa { get; set; }

        public string Ano { get; set; }

        public string Peca { get; set; }

        public string Solicitante { get; set;}

        public string Quantidade { get; set; }

    }
}
