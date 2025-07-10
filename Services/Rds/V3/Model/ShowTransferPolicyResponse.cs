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
    public class ShowTransferPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 转储策略列表
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<TransferPolicy> Policies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTransferPolicyResponse {\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTransferPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTransferPolicyResponse input)
        {
            if (input == null) return false;
            if (this.Policies != input.Policies || (this.Policies != null && input.Policies != null && !this.Policies.SequenceEqual(input.Policies))) return false;

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
                if (this.Policies != null) hashCode = hashCode * 59 + this.Policies.GetHashCode();
                return hashCode;
            }
        }
    }
}
