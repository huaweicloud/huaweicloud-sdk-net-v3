using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 批量导出策略组请求。
    /// </summary>
    public class ExportPolicyGroupsReq 
    {

        /// <summary>
        /// 导出策略组的id列表。
        /// </summary>
        [JsonProperty("policy_group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PolicyGroupIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportPolicyGroupsReq {\n");
            sb.Append("  policyGroupIds: ").Append(PolicyGroupIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExportPolicyGroupsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExportPolicyGroupsReq input)
        {
            if (input == null) return false;
            if (this.PolicyGroupIds != input.PolicyGroupIds || (this.PolicyGroupIds != null && input.PolicyGroupIds != null && !this.PolicyGroupIds.SequenceEqual(input.PolicyGroupIds))) return false;

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
                if (this.PolicyGroupIds != null) hashCode = hashCode * 59 + this.PolicyGroupIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
