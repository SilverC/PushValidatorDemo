using System.Collections.Generic;

namespace PushValidatorDemo.Models
{
    public class PushValidatorSettings
    {
        public string SecretKey { get; set; }
        public string ApplicationId { get; set; }
        public string LoginEndpoint { get; set; }
        public string AuthenticationResultEndpoint { get; set; }
        public IEnumerable<string> ServerIPs { get; set; }
        public IEnumerable<string> ServerFingerprints { get; set; }
        public IEnumerable<string> ServerURIs { get; set; }
    }
}
