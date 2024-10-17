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
    public class ShowOffSiteBackupPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 备份策略对象，包括备份类型、备份保留天数、目标区域ID和目标project ID。
        /// </summary>
        [JsonProperty("policy_para", NullValueHandling = NullValueHandling.Ignore)]
        public List<GetOffSiteBackupPolicy> PolicyPara { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOffSiteBackupPolicyResponse {\n");
            sb.Append("  policyPara: ").Append(PolicyPara).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOffSiteBackupPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOffSiteBackupPolicyResponse input)
        {
            if (input == null) return false;
            if (this.PolicyPara != input.PolicyPara || (this.PolicyPara != null && input.PolicyPara != null && !this.PolicyPara.SequenceEqual(input.PolicyPara))) return false;

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
                if (this.PolicyPara != null) hashCode = hashCode * 59 + this.PolicyPara.GetHashCode();
                return hashCode;
            }
        }
    }
}
