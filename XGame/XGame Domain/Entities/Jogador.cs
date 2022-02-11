using System;
using XGame.Domain.Entities.ValueObjects;
using XGame_Domain.Enum;

namespace XGame.Domain.Entities
{
    public class Jogador
    {
        public Guid Id { get; set; }

        public Nome Nome { get; private set; }

        public Email Email { get; set; }

        public string Senha { get; set; }
        
        public EnumSituacaoJogador Status { get; set; }

    }
}
