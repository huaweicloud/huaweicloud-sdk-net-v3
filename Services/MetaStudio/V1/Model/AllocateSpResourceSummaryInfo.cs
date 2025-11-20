using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 分配给租户的资源概览。
    /// </summary>
    public class AllocateSpResourceSummaryInfo 
    {

        /// <summary>
        /// 资源规格编码
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// 资源数量。
        /// </summary>
        [JsonProperty("resource_num", NullValueHandling = NullValueHandling.Ignore)]
        public double? ResourceNum { get; set; }

        /// <summary>
        /// 资源已使用数量。
        /// </summary>
        [JsonProperty("resource_used_num", NullValueHandling = NullValueHandling.Ignore)]
        public double? ResourceUsedNum { get; set; }

        /// <summary>
        /// 资源在TMS上的剩余量
        /// </summary>
        [JsonProperty("resource_remind_quota", NullValueHandling = NullValueHandling.Ignore)]
        public double? ResourceRemindQuota { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllocateSpResourceSummaryInfo {\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  resourceNum: ").Append(ResourceNum).Append("\n");
            sb.Append("  resourceUsedNum: ").Append(ResourceUsedNum).Append("\n");
            sb.Append("  resourceRemindQuota: ").Append(ResourceRemindQuota).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AllocateSpResourceSummaryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AllocateSpResourceSummaryInfo input)
        {
            if (input == null) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode || (this.ResourceSpecCode != null && !this.ResourceSpecCode.Equals(input.ResourceSpecCode))) return false;
            if (this.ResourceNum != input.ResourceNum || (this.ResourceNum != null && !this.ResourceNum.Equals(input.ResourceNum))) return false;
            if (this.ResourceUsedNum != input.ResourceUsedNum || (this.ResourceUsedNum != null && !this.ResourceUsedNum.Equals(input.ResourceUsedNum))) return false;
            if (this.ResourceRemindQuota != input.ResourceRemindQuota || (this.ResourceRemindQuota != null && !this.ResourceRemindQuota.Equals(input.ResourceRemindQuota))) return false;

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
                if (this.ResourceSpecCode != null) hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.ResourceNum != null) hashCode = hashCode * 59 + this.ResourceNum.GetHashCode();
                if (this.ResourceUsedNum != null) hashCode = hashCode * 59 + this.ResourceUsedNum.GetHashCode();
                if (this.ResourceRemindQuota != null) hashCode = hashCode * 59 + this.ResourceRemindQuota.GetHashCode();
                return hashCode;
            }
        }
    }
}
