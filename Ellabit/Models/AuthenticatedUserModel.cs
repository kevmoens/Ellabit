using System;
namespace Ellabit.Models
{
    public class AuthenticatedUserModel
    {
        public AuthenticatedUserModel()
        {
        }
        public string Access_Token { get; set; }
        public string UserName { get; set; }
    }
}

