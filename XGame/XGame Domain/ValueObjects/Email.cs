using prmToolkit.NotificationPattern;
using XGame_Domain.Resources;

namespace XGame.Domain.Entities.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this).IfNotEmail(x => x.Endereco, string.Format(Message.X0_INVALIDO, "E-mail"));
        }

        public string Endereco { get; private set; }
    }
}
