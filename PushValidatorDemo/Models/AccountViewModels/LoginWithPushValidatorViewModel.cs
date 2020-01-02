using System;
using Newtonsoft.Json.Linq;

namespace PushValidatorDemo.Models.AccountViewModels
{
    public class LoginWithPushValidatorViewModel
    {
        public JObject Request { get; set; }
        public string LoginEndpoint { get; set; }
        public string AuthenticationResultEndpoint { get; set; }
    }
}
