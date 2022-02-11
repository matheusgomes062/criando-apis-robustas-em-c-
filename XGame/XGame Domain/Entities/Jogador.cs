using System;

namespace XGame_Domain.Entities
{
    public class Jogador
    {
        public Guid Id { get; set; }

        public string PrimeiroNome { get; set; }

        public string LastName {  get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
        
        public string Status { get; set; }

    }
}
