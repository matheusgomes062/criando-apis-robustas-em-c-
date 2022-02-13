using prmToolkit.NotificationPattern;
using System;
using XGame.Domain.Entities.ValueObjects;
using XGame.Domain.Enum;
using XGame.Domain.Extensions;
using XGame_Domain.Resources;

namespace XGame.Domain.Entities
{
    public class Jogador : Notifiable
    {

        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;
            Id = Guid.NewGuid();
            Status = EnumSituacaoJogador.EmAnalise;

            new AddNotifications<Jogador>(this)
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, String.Format(Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES, "Senha", 6, 32));

            if (IsValid())
            {
                Senha = Senha.ConvertToMD5();
            }

            AddNotifications(email);
        }

        public Jogador(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Id = Guid.NewGuid();
            Status = EnumSituacaoJogador.EmAnalise;

            new AddNotifications<Jogador>(this)
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, string.Format(Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES, "Senha", "6", "32"));

            if (IsValid())
            {
                Senha = Senha.ConvertToMD5();
            }

            AddNotifications(nome, email);
        }

        public Guid Id { get; private set; }

        public Nome Nome { get; private set; }

        public Email Email { get; private set; }

        public string Senha { get; private set; }
        
        public EnumSituacaoJogador Status { get; set; }

        public override string ToString()
        {
            return this.Nome.PrimeiroNome + " " + this.Nome.UltimoNome;
        }
    }
}
