using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSupabaseApplicationApiKeyValueResponse : SdkResponse
    {

        /// <summary>
        /// ApiKey明文。
        /// </summary>
        [JsonProperty("api_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSupabaseApplicationApiKeyValueResponse {\n");
            sb.Append("  apiKey: ").Append(ApiKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSupabaseApplicationApiKeyValueResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSupabaseApplicationApiKeyValueResponse input)
        {
            if (input == null) return false;
            if (this.ApiKey != input.ApiKey || (this.ApiKey != null && !this.ApiKey.Equals(input.ApiKey))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.ApiKey != null) hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
