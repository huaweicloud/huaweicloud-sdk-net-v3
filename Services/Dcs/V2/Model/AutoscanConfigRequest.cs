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
    /// 设置自动分析配置返回体
    /// </summary>
    public class AutoscanConfigRequest 
    {

        /// <summary>
        /// 是否开启自动分析
        /// </summary>
        [JsonProperty("enable_auto_scan", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoScan { get; set; }

        /// <summary>
        /// 每日分析时间，时间格式为21:00，时间为UTC时间
        /// </summary>
        [JsonProperty("schedule_at", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ScheduleAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoscanConfigRequest {\n");
            sb.Append("  enableAutoScan: ").Append(EnableAutoScan).Append("\n");
            sb.Append("  scheduleAt: ").Append(ScheduleAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoscanConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoscanConfigRequest input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.EnableAutoScan != null)
                    hashCode = hashCode * 59 + this.EnableAutoScan.GetHashCode();
                if (this.ScheduleAt != null)
                    hashCode = hashCode * 59 + this.ScheduleAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
