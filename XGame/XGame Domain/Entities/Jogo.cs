using System;

namespace XGame_Domain.Entities
{
    public class Jogo
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Produtor { get; set; }

        public string Distribuicao { get; set; }

        public string Genero { get; set; }
        
        public string Site { get; set; }

    }
}
