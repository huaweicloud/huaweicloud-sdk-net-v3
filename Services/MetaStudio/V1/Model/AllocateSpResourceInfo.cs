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
    /// 分配给租户的资源。
    /// </summary>
    public class AllocateSpResourceInfo 
    {

        /// <summary>
        /// 资源分配id。
        /// </summary>
        [JsonProperty("assignment_record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignmentRecordId { get; set; }

        /// <summary>
        /// 资源规格编码
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// 资源计费类型。
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargingMode { get; set; }

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
        /// 资源分配时间（UTC时间）,unix时间,精确到秒。
        /// </summary>
        [JsonProperty("resource_allocate_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResourceAllocateTime { get; set; }

        /// <summary>
        /// 资源到期时间(UTC时间),unix时间,精确到秒。
        /// </summary>
        [JsonProperty("resource_expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResourceExpireTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllocateSpResourceInfo {\n");
            sb.Append("  assignmentRecordId: ").Append(AssignmentRecordId).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  resourceNum: ").Append(ResourceNum).Append("\n");
            sb.Append("  resourceUsedNum: ").Append(ResourceUsedNum).Append("\n");
            sb.Append("  resourceAllocateTime: ").Append(ResourceAllocateTime).Append("\n");
            sb.Append("  resourceExpireTime: ").Append(ResourceExpireTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AllocateSpResourceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AllocateSpResourceInfo input)
        {
            if (input == null) return false;
            if (this.AssignmentRecordId != input.AssignmentRecordId || (this.AssignmentRecordId != null && !this.AssignmentRecordId.Equals(input.AssignmentRecordId))) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode || (this.ResourceSpecCode != null && !this.ResourceSpecCode.Equals(input.ResourceSpecCode))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.ResourceNum != input.ResourceNum || (this.ResourceNum != null && !this.ResourceNum.Equals(input.ResourceNum))) return false;
            if (this.ResourceUsedNum != input.ResourceUsedNum || (this.ResourceUsedNum != null && !this.ResourceUsedNum.Equals(input.ResourceUsedNum))) return false;
            if (this.ResourceAllocateTime != input.ResourceAllocateTime || (this.ResourceAllocateTime != null && !this.ResourceAllocateTime.Equals(input.ResourceAllocateTime))) return false;
            if (this.ResourceExpireTime != input.ResourceExpireTime || (this.ResourceExpireTime != null && !this.ResourceExpireTime.Equals(input.ResourceExpireTime))) return false;

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
                if (this.AssignmentRecordId != null) hashCode = hashCode * 59 + this.AssignmentRecordId.GetHashCode();
                if (this.ResourceSpecCode != null) hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.ResourceNum != null) hashCode = hashCode * 59 + this.ResourceNum.GetHashCode();
                if (this.ResourceUsedNum != null) hashCode = hashCode * 59 + this.ResourceUsedNum.GetHashCode();
                if (this.ResourceAllocateTime != null) hashCode = hashCode * 59 + this.ResourceAllocateTime.GetHashCode();
                if (this.ResourceExpireTime != null) hashCode = hashCode * 59 + this.ResourceExpireTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
