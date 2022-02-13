using System.Collections.Generic;
using XGame.Domain.Entities;

namespace XGame_Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador AutenticarJogador(string email, string senha);

        Jogador AdicionarJogador(Jogador jogador);

        IEnumerable<Jogador> ListarJogador();

    }
}
