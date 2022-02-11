using XGame.Domain.Entities.ValueObjects;
using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public Nome Nome { get; private set; }

        public Email Email { get; set; }

        public string Senha { get; set; }
    }
}
