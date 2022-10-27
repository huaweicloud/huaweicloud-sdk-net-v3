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
    /// 
    /// </summary>
    public class BandwidthInfo 
    {

        /// <summary>
        /// 临时扩容开始时间
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// 临时扩容结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 当前时间
        /// </summary>
        [JsonProperty("current_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CurrentTime { get; set; }

        /// <summary>
        /// 当前带宽，单位为GB
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// 下一个扩容时间
        /// </summary>
        [JsonProperty("next_expand_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? NextExpandTime { get; set; }

        /// <summary>
        /// 扩容数量
        /// </summary>
        [JsonProperty("expand_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpandCount { get; set; }

        /// <summary>
        /// 临时扩容时间间隔
        /// </summary>
        [JsonProperty("expand_effect_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpandEffectTime { get; set; }

        /// <summary>
        /// 下一次可以扩容间隔时间
        /// </summary>
        [JsonProperty("expand_interval_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpandIntervalTime { get; set; }

        /// <summary>
        /// 最大扩容数量
        /// </summary>
        [JsonProperty("max_expand_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxExpandCount { get; set; }

        /// <summary>
        /// 任务是否运行
        /// </summary>
        [JsonProperty("task_running", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaskRunning { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BandwidthInfo {\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  currentTime: ").Append(CurrentTime).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  nextExpandTime: ").Append(NextExpandTime).Append("\n");
            sb.Append("  expandCount: ").Append(ExpandCount).Append("\n");
            sb.Append("  expandEffectTime: ").Append(ExpandEffectTime).Append("\n");
            sb.Append("  expandIntervalTime: ").Append(ExpandIntervalTime).Append("\n");
            sb.Append("  maxExpandCount: ").Append(MaxExpandCount).Append("\n");
            sb.Append("  taskRunning: ").Append(TaskRunning).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BandwidthInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BandwidthInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BeginTime == input.BeginTime ||
                    (this.BeginTime != null &&
                    this.BeginTime.Equals(input.BeginTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.CurrentTime == input.CurrentTime ||
                    (this.CurrentTime != null &&
                    this.CurrentTime.Equals(input.CurrentTime))
                ) && 
                (
                    this.Bandwidth == input.Bandwidth ||
                    (this.Bandwidth != null &&
                    this.Bandwidth.Equals(input.Bandwidth))
                ) && 
                (
                    this.NextExpandTime == input.NextExpandTime ||
                    (this.NextExpandTime != null &&
                    this.NextExpandTime.Equals(input.NextExpandTime))
                ) && 
                (
                    this.ExpandCount == input.ExpandCount ||
                    (this.ExpandCount != null &&
                    this.ExpandCount.Equals(input.ExpandCount))
                ) && 
                (
                    this.ExpandEffectTime == input.ExpandEffectTime ||
                    (this.ExpandEffectTime != null &&
                    this.ExpandEffectTime.Equals(input.ExpandEffectTime))
                ) && 
                (
                    this.ExpandIntervalTime == input.ExpandIntervalTime ||
                    (this.ExpandIntervalTime != null &&
                    this.ExpandIntervalTime.Equals(input.ExpandIntervalTime))
                ) && 
                (
                    this.MaxExpandCount == input.MaxExpandCount ||
                    (this.MaxExpandCount != null &&
                    this.MaxExpandCount.Equals(input.MaxExpandCount))
                ) && 
                (
                    this.TaskRunning == input.TaskRunning ||
                    (this.TaskRunning != null &&
                    this.TaskRunning.Equals(input.TaskRunning))
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
                if (this.BeginTime != null)
                    hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.CurrentTime != null)
                    hashCode = hashCode * 59 + this.CurrentTime.GetHashCode();
                if (this.Bandwidth != null)
                    hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.NextExpandTime != null)
                    hashCode = hashCode * 59 + this.NextExpandTime.GetHashCode();
                if (this.ExpandCount != null)
                    hashCode = hashCode * 59 + this.ExpandCount.GetHashCode();
                if (this.ExpandEffectTime != null)
                    hashCode = hashCode * 59 + this.ExpandEffectTime.GetHashCode();
                if (this.ExpandIntervalTime != null)
                    hashCode = hashCode * 59 + this.ExpandIntervalTime.GetHashCode();
                if (this.MaxExpandCount != null)
                    hashCode = hashCode * 59 + this.MaxExpandCount.GetHashCode();
                if (this.TaskRunning != null)
                    hashCode = hashCode * 59 + this.TaskRunning.GetHashCode();
                return hashCode;
            }
        }
    }
}
