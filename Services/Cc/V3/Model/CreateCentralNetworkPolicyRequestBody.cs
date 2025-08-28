using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 创建中心网络策略的请求体。
    /// </summary>
    public class CreateCentralNetworkPolicyRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("central_network_policy_document", NullValueHandling = NullValueHandling.Ignore)]
        public CentralNetworkPolicyDocument CentralNetworkPolicyDocument { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCentralNetworkPolicyRequestBody {\n");
            sb.Append("  centralNetworkPolicyDocument: ").Append(CentralNetworkPolicyDocument).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCentralNetworkPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateCentralNetworkPolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.CentralNetworkPolicyDocument != input.CentralNetworkPolicyDocument || (this.CentralNetworkPolicyDocument != null && !this.CentralNetworkPolicyDocument.Equals(input.CentralNetworkPolicyDocument))) return false;

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
                if (this.CentralNetworkPolicyDocument != null) hashCode = hashCode * 59 + this.CentralNetworkPolicyDocument.GetHashCode();
                return hashCode;
            }
        }
    }
}
