using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowHotkeyAutoscanConfigResponse : SdkResponse
    {

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 是否开启自动分析
        /// </summary>
        [JsonProperty("enable_auto_scan", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoScan { get; set; }

        /// <summary>
        /// 每日分析时间，时间格式为21:00
        /// </summary>
        [JsonProperty("schedule_at", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ScheduleAt { get; set; }

        /// <summary>
        /// 配置更新时间，时间格式为2020-06-15T02:21:18.669Z
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowHotkeyAutoscanConfigResponse {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  enableAutoScan: ").Append(EnableAutoScan).Append("\n");
            sb.Append("  scheduleAt: ").Append(ScheduleAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowHotkeyAutoscanConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowHotkeyAutoscanConfigResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.EnableAutoScan == input.EnableAutoScan ||
                    (this.EnableAutoScan != null &&
                    this.EnableAutoScan.Equals(input.EnableAutoScan))
                ) && 
                (
                    this.ScheduleAt == input.ScheduleAt ||
                    this.ScheduleAt != null &&
                    input.ScheduleAt != null &&
                    this.ScheduleAt.SequenceEqual(input.ScheduleAt)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.EnableAutoScan != null)
                    hashCode = hashCode * 59 + this.EnableAutoScan.GetHashCode();
                if (this.ScheduleAt != null)
                    hashCode = hashCode * 59 + this.ScheduleAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
