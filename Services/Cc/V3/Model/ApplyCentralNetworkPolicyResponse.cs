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
    /// Response Object
    /// </summary>
    public class ApplyCentralNetworkPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 请求ID。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("central_network_policy", NullValueHandling = NullValueHandling.Ignore)]
        public CentralNetworkPolicy CentralNetworkPolicy { get; set; }

        /// <summary>
        /// 网络策略变化列表。
        /// </summary>
        [JsonProperty("central_network_policy_change_set", NullValueHandling = NullValueHandling.Ignore)]
        public List<CentralNetworkElementChange> CentralNetworkPolicyChangeSet { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyCentralNetworkPolicyResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  centralNetworkPolicy: ").Append(CentralNetworkPolicy).Append("\n");
            sb.Append("  centralNetworkPolicyChangeSet: ").Append(CentralNetworkPolicyChangeSet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyCentralNetworkPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyCentralNetworkPolicyResponse input)
        {
            if (input == null) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;
            if (this.CentralNetworkPolicy != input.CentralNetworkPolicy || (this.CentralNetworkPolicy != null && !this.CentralNetworkPolicy.Equals(input.CentralNetworkPolicy))) return false;
            if (this.CentralNetworkPolicyChangeSet != input.CentralNetworkPolicyChangeSet || (this.CentralNetworkPolicyChangeSet != null && input.CentralNetworkPolicyChangeSet != null && !this.CentralNetworkPolicyChangeSet.SequenceEqual(input.CentralNetworkPolicyChangeSet))) return false;

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
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.CentralNetworkPolicy != null) hashCode = hashCode * 59 + this.CentralNetworkPolicy.GetHashCode();
                if (this.CentralNetworkPolicyChangeSet != null) hashCode = hashCode * 59 + this.CentralNetworkPolicyChangeSet.GetHashCode();
                return hashCode;
            }
        }
    }
}
