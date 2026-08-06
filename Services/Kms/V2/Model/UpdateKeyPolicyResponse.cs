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
    public class UpdateKeyPolicyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 密钥策略ID **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateKeyPolicyResponseBodyPolicy Policy { get; set; }

        /// <summary>
        /// **参数解释：** 密钥策略描述信息 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 密钥策略最近更新时间 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("last_modify_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifyTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateKeyPolicyResponse {\n");
            sb.Append("  policyId: ").Append(PolicyId).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  lastModifyTime: ").Append(LastModifyTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateKeyPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateKeyPolicyResponse input)
        {
            if (input == null) return false;
            if (this.PolicyId != input.PolicyId || (this.PolicyId != null && !this.PolicyId.Equals(input.PolicyId))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.LastModifyTime != input.LastModifyTime || (this.LastModifyTime != null && !this.LastModifyTime.Equals(input.LastModifyTime))) return false;

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
                if (this.PolicyId != null) hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LastModifyTime != null) hashCode = hashCode * 59 + this.LastModifyTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
