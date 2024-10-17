using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V1.Model
{
    /// <summary>
    /// EIP异常事件响应体
    /// </summary>
    public class DailyLog 
    {

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 防护状态，可选范围： - 1：表示清洗 - 2：表示黑洞
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 触发时流量
        /// </summary>
        [JsonProperty("trigger_bps", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerBps { get; set; }

        /// <summary>
        /// 触发时报文速率
        /// </summary>
        [JsonProperty("trigger_pps", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerPps { get; set; }

        /// <summary>
        /// 触发时HTTP请求速率
        /// </summary>
        [JsonProperty("trigger_http_pps", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerHttpPps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DailyLog {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  triggerBps: ").Append(TriggerBps).Append("\n");
            sb.Append("  triggerPps: ").Append(TriggerPps).Append("\n");
            sb.Append("  triggerHttpPps: ").Append(TriggerHttpPps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DailyLog);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DailyLog input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TriggerBps != input.TriggerBps || (this.TriggerBps != null && !this.TriggerBps.Equals(input.TriggerBps))) return false;
            if (this.TriggerPps != input.TriggerPps || (this.TriggerPps != null && !this.TriggerPps.Equals(input.TriggerPps))) return false;
            if (this.TriggerHttpPps != input.TriggerHttpPps || (this.TriggerHttpPps != null && !this.TriggerHttpPps.Equals(input.TriggerHttpPps))) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TriggerBps != null) hashCode = hashCode * 59 + this.TriggerBps.GetHashCode();
                if (this.TriggerPps != null) hashCode = hashCode * 59 + this.TriggerPps.GetHashCode();
                if (this.TriggerHttpPps != null) hashCode = hashCode * 59 + this.TriggerHttpPps.GetHashCode();
                return hashCode;
            }
        }
    }
}
