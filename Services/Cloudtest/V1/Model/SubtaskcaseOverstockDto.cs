using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SubtaskcaseOverstockDto 
    {

        /// <summary>
        /// 查询时间
        /// </summary>
        [JsonProperty("data_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DataTime { get; set; }

        /// <summary>
        /// 执行机类型
        /// </summary>
        [JsonProperty("executor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorType { get; set; }

        /// <summary>
        /// UUID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 执行机标签
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// 执行机所属区域
        /// </summary>
        [JsonProperty("location_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationId { get; set; }

        /// <summary>
        /// 积压数量
        /// </summary>
        [JsonProperty("subtaskcase_overstock_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubtaskcaseOverstockCount { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [JsonProperty("test_service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestServiceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubtaskcaseOverstockDto {\n");
            sb.Append("  dataTime: ").Append(DataTime).Append("\n");
            sb.Append("  executorType: ").Append(ExecutorType).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("  locationId: ").Append(LocationId).Append("\n");
            sb.Append("  subtaskcaseOverstockCount: ").Append(SubtaskcaseOverstockCount).Append("\n");
            sb.Append("  testServiceId: ").Append(TestServiceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubtaskcaseOverstockDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubtaskcaseOverstockDto input)
        {
            if (input == null) return false;
            if (this.DataTime != input.DataTime || (this.DataTime != null && !this.DataTime.Equals(input.DataTime))) return false;
            if (this.ExecutorType != input.ExecutorType || (this.ExecutorType != null && !this.ExecutorType.Equals(input.ExecutorType))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Label != input.Label || (this.Label != null && !this.Label.Equals(input.Label))) return false;
            if (this.LocationId != input.LocationId || (this.LocationId != null && !this.LocationId.Equals(input.LocationId))) return false;
            if (this.SubtaskcaseOverstockCount != input.SubtaskcaseOverstockCount || (this.SubtaskcaseOverstockCount != null && !this.SubtaskcaseOverstockCount.Equals(input.SubtaskcaseOverstockCount))) return false;
            if (this.TestServiceId != input.TestServiceId || (this.TestServiceId != null && !this.TestServiceId.Equals(input.TestServiceId))) return false;

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
                if (this.DataTime != null) hashCode = hashCode * 59 + this.DataTime.GetHashCode();
                if (this.ExecutorType != null) hashCode = hashCode * 59 + this.ExecutorType.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Label != null) hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.LocationId != null) hashCode = hashCode * 59 + this.LocationId.GetHashCode();
                if (this.SubtaskcaseOverstockCount != null) hashCode = hashCode * 59 + this.SubtaskcaseOverstockCount.GetHashCode();
                if (this.TestServiceId != null) hashCode = hashCode * 59 + this.TestServiceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
