using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame_Domain.Arguments.Base
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Message = XGame_Domain.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO;
        }
        public string Message { get; set; }

        //public static explicit operator ResponseBase(Entities.Jogo entidade)
        //{
        //    return new ResponseBase()
        //    {
        //        Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
        //    };
        //}
    }
}
