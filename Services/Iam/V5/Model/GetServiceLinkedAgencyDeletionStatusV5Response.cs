using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GetServiceLinkedAgencyDeletionStatusV5Response : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public DeletionTaskStatus? Status { get; set; }

        /// <summary>
        /// 删除失败的原因。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// 该服务关联委托正在被使用的场景列表。
        /// </summary>
        [JsonProperty("agency_usage_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AgencyUsage> AgencyUsageList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetServiceLinkedAgencyDeletionStatusV5Response {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  agencyUsageList: ").Append(AgencyUsageList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetServiceLinkedAgencyDeletionStatusV5Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetServiceLinkedAgencyDeletionStatusV5Response input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.AgencyUsageList != input.AgencyUsageList || (this.AgencyUsageList != null && input.AgencyUsageList != null && !this.AgencyUsageList.SequenceEqual(input.AgencyUsageList))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.AgencyUsageList != null) hashCode = hashCode * 59 + this.AgencyUsageList.GetHashCode();
                return hashCode;
            }
        }
    }
}
