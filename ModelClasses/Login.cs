using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelClasses
{
    public class Login
    {
        string role;
        string id;
        string password;
        string securityQuestion;
        string answer;

        public string Role { get => role; set => role = value; }
        public string Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
        public string SecurityQuestion { get => securityQuestion; set => securityQuestion = value; }
        public string Answer { get => answer; set => answer = value; }
    }
}