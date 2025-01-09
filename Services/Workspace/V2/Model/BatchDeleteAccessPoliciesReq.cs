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
    /// 
    /// </summary>
    public class BatchDeleteAccessPoliciesReq 
    {

        /// <summary>
        /// 策略ID列表。
        /// </summary>
        [JsonProperty("policy_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PolicyIdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteAccessPoliciesReq {\n");
            sb.Append("  policyIdList: ").Append(PolicyIdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteAccessPoliciesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteAccessPoliciesReq input)
        {
            if (input == null) return false;
            if (this.PolicyIdList != input.PolicyIdList || (this.PolicyIdList != null && input.PolicyIdList != null && !this.PolicyIdList.SequenceEqual(input.PolicyIdList))) return false;

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
                if (this.PolicyIdList != null) hashCode = hashCode * 59 + this.PolicyIdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
