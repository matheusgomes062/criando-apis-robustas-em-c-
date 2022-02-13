using prmToolkit.NotificationPattern;
using XGame_Domain.Resources;

namespace XGame.Domain.Entities.ValueObjects
{
    public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string ulimoNome)
        {
            PrimeiroNome = primeiroNome;
            UlimoNome = ulimoNome;

            new AddNotifications<Nome>(this)
                .IfNullOrInvalidLength(x => x.PrimeiroNome, 3, 50, string.Format(Message.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES, "Primeiro nome", "3", "50"))
                .IfNullOrInvalidLength(x => x.UlimoNome, 3, 50, string.Format(Message.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES, "Último nome", "3", "50"));
        }

        public string PrimeiroNome { get; private set; }

        public string UlimoNome { get; private set; }
    }
}
