﻿using XGame.Domain.Entities.ValueObjects;
using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
    }
}
