using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QuotaResource 
    {

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("quotaKey", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaKey { get; set; }

        /// <summary>
        /// 配额值
        /// </summary>
        [JsonProperty("quotaLimit", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotaLimit { get; set; }

        /// <summary>
        /// 已创建的资源个数
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public int? Used { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 局点ID。若资源不涉及此参数，则不返回该参数。
        /// </summary>
        [JsonProperty("regionId", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 可用区ID。若资源不涉及此参数，则不返回该参数。
        /// </summary>
        [JsonProperty("availabilityZoneId", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZoneId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaResource {\n");
            sb.Append("  quotaKey: ").Append(QuotaKey).Append("\n");
            sb.Append("  quotaLimit: ").Append(QuotaLimit).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  availabilityZoneId: ").Append(AvailabilityZoneId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuotaResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuotaResource input)
        {
            if (input == null) return false;
            if (this.QuotaKey != input.QuotaKey || (this.QuotaKey != null && !this.QuotaKey.Equals(input.QuotaKey))) return false;
            if (this.QuotaLimit != input.QuotaLimit || (this.QuotaLimit != null && !this.QuotaLimit.Equals(input.QuotaLimit))) return false;
            if (this.Used != input.Used || (this.Used != null && !this.Used.Equals(input.Used))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.AvailabilityZoneId != input.AvailabilityZoneId || (this.AvailabilityZoneId != null && !this.AvailabilityZoneId.Equals(input.AvailabilityZoneId))) return false;

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
                if (this.QuotaKey != null) hashCode = hashCode * 59 + this.QuotaKey.GetHashCode();
                if (this.QuotaLimit != null) hashCode = hashCode * 59 + this.QuotaLimit.GetHashCode();
                if (this.Used != null) hashCode = hashCode * 59 + this.Used.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.AvailabilityZoneId != null) hashCode = hashCode * 59 + this.AvailabilityZoneId.GetHashCode();
                return hashCode;
            }
        }
    }
}
