using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._1_SingleResponsibility.WrongImplementation
{
    public interface IUser
    {
        /*
         We can say that these are the minimum methods required for a user registration. 
        But when creating a user, we do not need the logeror and senimail methods here. 
        The user class should only register the user.
         */
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
        void LogError(string error);
        bool SendEmail(string emailContent);
    }
}
