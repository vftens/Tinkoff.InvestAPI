using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tinkoff.InvestAPI
{
    [GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Error
    {
        [JsonProperty("trackingId", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string TrackingId { get; set; }

        [JsonProperty("status", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string Status { get; set; } = "Error";

        [JsonProperty("payload", Required = Required.Always)]
        [Required]
        public Payload Payload { get; set; } = new Payload();

        private IDictionary<string, object> additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return additionalProperties; }
            set { additionalProperties = value; }
        }


    }
}