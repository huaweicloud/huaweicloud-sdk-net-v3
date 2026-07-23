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
    /// Request Object
    /// </summary>
    public class ListJobSchedulesRequest 
    {

        /// <summary>
        /// 策略类型，snapshot:快照策略, sync:同步策略，默认查询所有类型
        /// </summary>
        [SDKProperty("schedule_type", IsQuery = true)]
        [JsonProperty("schedule_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [SDKProperty("schedule_id", IsQuery = true)]
        [JsonProperty("schedule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduleId { get; set; }

        /// <summary>
        /// 索引位置，偏移量。从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询），必须为数字，不能为负数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询记录数。默认为10，不能为负数，最小值为1，最大值为200。
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
            sb.Append("class ListJobSchedulesRequest {\n");
            sb.Append("  scheduleType: ").Append(ScheduleType).Append("\n");
            sb.Append("  scheduleId: ").Append(ScheduleId).Append("\n");
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
            return this.Equals(input as ListJobSchedulesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListJobSchedulesRequest input)
        {
            if (input == null) return false;
            if (this.ScheduleType != input.ScheduleType || (this.ScheduleType != null && !this.ScheduleType.Equals(input.ScheduleType))) return false;
            if (this.ScheduleId != input.ScheduleId || (this.ScheduleId != null && !this.ScheduleId.Equals(input.ScheduleId))) return false;
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
                if (this.ScheduleType != null) hashCode = hashCode * 59 + this.ScheduleType.GetHashCode();
                if (this.ScheduleId != null) hashCode = hashCode * 59 + this.ScheduleId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
