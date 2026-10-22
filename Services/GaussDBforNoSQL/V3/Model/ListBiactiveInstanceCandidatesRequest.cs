using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListBiactiveInstanceCandidatesRequest 
    {

        /// <summary>
        /// **参数解释：** 实例ID。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释：** 目标Region的编码。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("target_region_code", IsQuery = true)]
        [JsonProperty("target_region_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetRegionCode { get; set; }

        /// <summary>
        /// **参数解释：** 按目标实例名称过滤。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("target_instance_name", IsQuery = true)]
        [JsonProperty("target_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceName { get; set; }

        /// <summary>
        /// **参数解释：** 数据同步模式。 **约束限制：** 不涉及。 **取值范围：** - TABLE：表级数据同步模式。 **默认取值：** 不传该参数时表示实例级数据同步模式。
        /// </summary>
        [SDKProperty("data_sync_mode", IsQuery = true)]
        [JsonProperty("data_sync_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string DataSyncMode { get; set; }

        /// <summary>
        /// **参数解释：** 索引位置偏移量，表示从最新一条记录开始偏移offset条数据后查询。 **约束限制：** 取值大于或等于0。 **取值范围：** 不涉及。 **默认取值：** 不传该参数时，查询偏移量默认为0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释：** 查询实例个数上限值。 **约束限制：** 不涉及。 **取值范围：** 1~100。 **默认取值：** 不传该参数时，默认查询前100条实例信息。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBiactiveInstanceCandidatesRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  targetRegionCode: ").Append(TargetRegionCode).Append("\n");
            sb.Append("  targetInstanceName: ").Append(TargetInstanceName).Append("\n");
            sb.Append("  dataSyncMode: ").Append(DataSyncMode).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBiactiveInstanceCandidatesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBiactiveInstanceCandidatesRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.TargetRegionCode != input.TargetRegionCode || (this.TargetRegionCode != null && !this.TargetRegionCode.Equals(input.TargetRegionCode))) return false;
            if (this.TargetInstanceName != input.TargetInstanceName || (this.TargetInstanceName != null && !this.TargetInstanceName.Equals(input.TargetInstanceName))) return false;
            if (this.DataSyncMode != input.DataSyncMode || (this.DataSyncMode != null && !this.DataSyncMode.Equals(input.DataSyncMode))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.TargetRegionCode != null) hashCode = hashCode * 59 + this.TargetRegionCode.GetHashCode();
                if (this.TargetInstanceName != null) hashCode = hashCode * 59 + this.TargetInstanceName.GetHashCode();
                if (this.DataSyncMode != null) hashCode = hashCode * 59 + this.DataSyncMode.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
