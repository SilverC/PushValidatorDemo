using System;
namespace PushValidatorDemo.Models
{
    public class PushValidatorSettings
    {
        public string SecretKey { get; set; }
        public string ApplicationId { get; set; }
        public string LoginEndpoint { get; set; }
        public string AuthenticationResultEndpoint { get; set; }
    }
}
