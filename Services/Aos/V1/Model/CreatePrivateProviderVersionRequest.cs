using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreatePrivateProviderVersionRequest 
    {

        /// <summary>
        /// 用户指定的，对于此请求的唯一Id，用于定位某个请求，推荐使用UUID
        /// </summary>
        [SDKProperty("Client-Request-Id", IsHeader = true)]
        [JsonProperty("Client-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// 私有provider（private-provider）的名称。此名字在domain_id+region下应唯一，可以使用小写英文、数字、中划线。仅支持以小写英文、数字开头结尾。
        /// </summary>
        [SDKProperty("provider_name", IsPath = true)]
        [JsonProperty("provider_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public CreatePrivateProviderVersionRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePrivateProviderVersionRequest {\n");
            sb.Append("  clientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  providerName: ").Append(ProviderName).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePrivateProviderVersionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePrivateProviderVersionRequest input)
        {
            if (input == null) return false;
            if (this.ClientRequestId != input.ClientRequestId || (this.ClientRequestId != null && !this.ClientRequestId.Equals(input.ClientRequestId))) return false;
            if (this.ProviderName != input.ProviderName || (this.ProviderName != null && !this.ProviderName.Equals(input.ProviderName))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.ClientRequestId != null) hashCode = hashCode * 59 + this.ClientRequestId.GetHashCode();
                if (this.ProviderName != null) hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
