using _01_Weather.Core.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Weather.Contracts.User
{
    public interface UserRiposetory
    {
        bool Register(UserEntity obj);
        void ChanghePassword(UserEntity obj);
        bool IsUser(UserEntity obj);
        List<UserEntity> GetUserInformation(string userName);
    }
}
