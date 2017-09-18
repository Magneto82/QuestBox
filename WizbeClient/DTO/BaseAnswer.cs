using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizbeClient.DTO
{
    public class TestUserListAnswer : BaseAnswer
    {
        public IList<ShortUser> Data { get; set; }
    }
    public class JoinGameAnswer : BaseAnswer
    {
        public JoinGameViewModel Data { get; set; }
    }
    public class TeamsAnswer : BaseAnswer
    {
        public IList<TeamViewSmallModel> Data { get; set; }
    }

    //{"Data":null,"Errors":[{"Error":"Невозможно подключиться к игре. Игра в статусе: Объявлена.","Code":1012,"NativeErrorDescription":null}],"Success":false}
    public class BaseAnswer
    {
        //public object Data { get; set; }
        public ICollection<WizbeError> Errors { get; set; }
        public bool Success { get; set; }

        public string StringErrors()
        {
            string errorString = "";
            foreach (var wizbeError in Errors)
            {
                errorString += $"ErrorCode: {wizbeError.Code} Message: {wizbeError.Error}\n";
            }
            return errorString;
        }
    }

    //{"Error":"Невозможно подключиться к игре. Игра в статусе: Объявлена.","Code":1012,"NativeErrorDescription":null}
    public class WizbeError
    {
        public string Error { get; set; }
        public string Code { get; set; }
        public string NativeErrorDescription { get; set; }
    }
}
