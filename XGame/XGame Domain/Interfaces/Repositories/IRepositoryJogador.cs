using System;
using XGame.Domain.Arguments.Jogador;

namespace XGame_Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        Guid AdicionarJogador(AdicionarJogadorRequest request);

    }
}
