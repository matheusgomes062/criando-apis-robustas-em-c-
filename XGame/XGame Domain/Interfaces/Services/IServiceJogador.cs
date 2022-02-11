using System;
using XGame.Domain.Arguments.Jogador;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse Autenticar(AutenticarJogadorRequest);

        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);
    }
}
