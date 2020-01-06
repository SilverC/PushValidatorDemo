using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace PushValidatorDemo.Models.AccountViewModels
{
    public class LoginWithPushValidatorViewModel
    {
        public JObject Request { get; set; }
        public string LoginEndpoint { get; set; }
        public string AuthenticationResultEndpoint { get; set; }
        public IEnumerable<string> ServerIPs { get; set; }
        public IEnumerable<string> ServerFingerprints { get; set; }
        public IEnumerable<string> ServerURIs { get; set; }
    }
}
