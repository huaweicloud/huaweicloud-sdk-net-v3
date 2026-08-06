using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListKeyPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public ListAccessPointResponseBodyPageInfo PageInfo { get; set; }

        /// <summary>
        /// **参数解释：** 密钥策略列表 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("keyspace_policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListKeyPolicyResponseBodyKeyspacePolicies> KeyspacePolicies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListKeyPolicyResponse {\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("  keyspacePolicies: ").Append(KeyspacePolicies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListKeyPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListKeyPolicyResponse input)
        {
            if (input == null) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;
            if (this.KeyspacePolicies != input.KeyspacePolicies || (this.KeyspacePolicies != null && input.KeyspacePolicies != null && !this.KeyspacePolicies.SequenceEqual(input.KeyspacePolicies))) return false;

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
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                if (this.KeyspacePolicies != null) hashCode = hashCode * 59 + this.KeyspacePolicies.GetHashCode();
                return hashCode;
            }
        }
    }
}
