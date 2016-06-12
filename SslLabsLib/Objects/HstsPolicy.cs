using System;
using Newtonsoft.Json;
using SslLabsLib.Enums;

namespace SslLabsLib.Objects
{
    public class HstsPolicy
    {
        /// <summary>
        /// this constant contains what SSL Labs considers to be sufficiently large max-age value
        /// </summary>
        [JsonProperty("LONG_MAX_AGE")]
        public long LongMaxAge { get; set; }
        /// <summary>
        /// the contents of the HSTS response header, if present
        /// </summary>
        [JsonProperty("header")]
        public string Header { get; set; }
        /// <summary>
        /// HSTS status
        /// </summary>
        [JsonProperty("status")]
        public HstsStatus Status { get; set; }
        /// <summary>
        /// Error message when error is encountered, null otherwise
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }
        /// <summary>
        /// the max-age value specified in the policy; null if policy is missing or invalid or on parsing error; the maximum value currently supported is 9223372036854775807
        /// </summary>
        [JsonProperty("maxAge")]
        public long MaxAge { get; set; }
        /// <summary>
        /// true if the includeSubDomains directive is set; null otherwise
        /// </summary>
        [JsonProperty("includeSubdomains")]
        public bool IncludeSubdomains { get; set; }
    }
}