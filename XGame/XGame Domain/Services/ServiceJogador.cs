using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Interfaces.Services;
using XGame_Domain.Interfaces.Repositories;

namespace XGame_Domain.Services
{
    public class ServiceJogador : IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            Guid id = _repositoryJogador.AdicionarJogador(request);

            return new AdicionarJogadorResponse() { Id = id, Message = "Operação realizada com sucesso" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
