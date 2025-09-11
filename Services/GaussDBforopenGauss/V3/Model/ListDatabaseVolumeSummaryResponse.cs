using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDatabaseVolumeSummaryResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 数据盘总量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("data_disk_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string DataDiskCapacity { get; set; }

        /// <summary>
        /// **参数解释**: 数据盘使用量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("data_disk_usage", NullValueHandling = NullValueHandling.Ignore)]
        public string DataDiskUsage { get; set; }

        /// <summary>
        /// **参数解释**: 空间使用日均增长量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("space_usage_growth_per_day", NullValueHandling = NullValueHandling.Ignore)]
        public string SpaceUsageGrowthPerDay { get; set; }

        /// <summary>
        /// **参数解释**: 预计可用天数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("estimated_remaining_days", NullValueHandling = NullValueHandling.Ignore)]
        public string EstimatedRemainingDays { get; set; }

        /// <summary>
        /// **参数解释**: CN节点信息。
        /// </summary>
        [JsonProperty("cn_components", NullValueHandling = NullValueHandling.Ignore)]
        public List<ComponentInfoResult> CnComponents { get; set; }

        /// <summary>
        /// **参数解释**: DN节点信息。
        /// </summary>
        [JsonProperty("dn_components", NullValueHandling = NullValueHandling.Ignore)]
        public List<ComponentInfoResult> DnComponents { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDatabaseVolumeSummaryResponse {\n");
            sb.Append("  dataDiskCapacity: ").Append(DataDiskCapacity).Append("\n");
            sb.Append("  dataDiskUsage: ").Append(DataDiskUsage).Append("\n");
            sb.Append("  spaceUsageGrowthPerDay: ").Append(SpaceUsageGrowthPerDay).Append("\n");
            sb.Append("  estimatedRemainingDays: ").Append(EstimatedRemainingDays).Append("\n");
            sb.Append("  cnComponents: ").Append(CnComponents).Append("\n");
            sb.Append("  dnComponents: ").Append(DnComponents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDatabaseVolumeSummaryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDatabaseVolumeSummaryResponse input)
        {
            if (input == null) return false;
            if (this.DataDiskCapacity != input.DataDiskCapacity || (this.DataDiskCapacity != null && !this.DataDiskCapacity.Equals(input.DataDiskCapacity))) return false;
            if (this.DataDiskUsage != input.DataDiskUsage || (this.DataDiskUsage != null && !this.DataDiskUsage.Equals(input.DataDiskUsage))) return false;
            if (this.SpaceUsageGrowthPerDay != input.SpaceUsageGrowthPerDay || (this.SpaceUsageGrowthPerDay != null && !this.SpaceUsageGrowthPerDay.Equals(input.SpaceUsageGrowthPerDay))) return false;
            if (this.EstimatedRemainingDays != input.EstimatedRemainingDays || (this.EstimatedRemainingDays != null && !this.EstimatedRemainingDays.Equals(input.EstimatedRemainingDays))) return false;
            if (this.CnComponents != input.CnComponents || (this.CnComponents != null && input.CnComponents != null && !this.CnComponents.SequenceEqual(input.CnComponents))) return false;
            if (this.DnComponents != input.DnComponents || (this.DnComponents != null && input.DnComponents != null && !this.DnComponents.SequenceEqual(input.DnComponents))) return false;

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
                if (this.DataDiskCapacity != null) hashCode = hashCode * 59 + this.DataDiskCapacity.GetHashCode();
                if (this.DataDiskUsage != null) hashCode = hashCode * 59 + this.DataDiskUsage.GetHashCode();
                if (this.SpaceUsageGrowthPerDay != null) hashCode = hashCode * 59 + this.SpaceUsageGrowthPerDay.GetHashCode();
                if (this.EstimatedRemainingDays != null) hashCode = hashCode * 59 + this.EstimatedRemainingDays.GetHashCode();
                if (this.CnComponents != null) hashCode = hashCode * 59 + this.CnComponents.GetHashCode();
                if (this.DnComponents != null) hashCode = hashCode * 59 + this.DnComponents.GetHashCode();
                return hashCode;
            }
        }
    }
}
