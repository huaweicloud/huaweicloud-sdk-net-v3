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
    public class SearchAutoEnlargePolicyResponse : SdkResponse
    {

        /// <summary>
        /// 磁盘自动扩容开关。
        /// </summary>
        [JsonProperty("switch_option", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchOption { get; set; }

        /// <summary>
        /// 存储自动扩容上限。
        /// </summary>
        [JsonProperty("limit_volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? LimitVolumeSize { get; set; }

        /// <summary>
        /// 最小扩容磁盘容量。
        /// </summary>
        [JsonProperty("min_volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinVolumeSize { get; set; }

        /// <summary>
        /// 最大扩容磁盘容量。
        /// </summary>
        [JsonProperty("max_volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxVolumeSize { get; set; }

        /// <summary>
        /// 可用存储空间率。
        /// </summary>
        [JsonProperty("trigger_available_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerAvailablePercent { get; set; }

        /// <summary>
        /// 空间率集合。
        /// </summary>
        [JsonProperty("percents", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Percents { get; set; }

        /// <summary>
        /// 扩容步长，固定大小扩容方式。
        /// </summary>
        [JsonProperty("step_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? StepSize { get; set; }

        /// <summary>
        /// 扩容步长，百分比扩容方式。
        /// </summary>
        [JsonProperty("step_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? StepPercent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchAutoEnlargePolicyResponse {\n");
            sb.Append("  switchOption: ").Append(SwitchOption).Append("\n");
            sb.Append("  limitVolumeSize: ").Append(LimitVolumeSize).Append("\n");
            sb.Append("  minVolumeSize: ").Append(MinVolumeSize).Append("\n");
            sb.Append("  maxVolumeSize: ").Append(MaxVolumeSize).Append("\n");
            sb.Append("  triggerAvailablePercent: ").Append(TriggerAvailablePercent).Append("\n");
            sb.Append("  percents: ").Append(Percents).Append("\n");
            sb.Append("  stepSize: ").Append(StepSize).Append("\n");
            sb.Append("  stepPercent: ").Append(StepPercent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchAutoEnlargePolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchAutoEnlargePolicyResponse input)
        {
            if (input == null) return false;
            if (this.SwitchOption != input.SwitchOption || (this.SwitchOption != null && !this.SwitchOption.Equals(input.SwitchOption))) return false;
            if (this.LimitVolumeSize != input.LimitVolumeSize || (this.LimitVolumeSize != null && !this.LimitVolumeSize.Equals(input.LimitVolumeSize))) return false;
            if (this.MinVolumeSize != input.MinVolumeSize || (this.MinVolumeSize != null && !this.MinVolumeSize.Equals(input.MinVolumeSize))) return false;
            if (this.MaxVolumeSize != input.MaxVolumeSize || (this.MaxVolumeSize != null && !this.MaxVolumeSize.Equals(input.MaxVolumeSize))) return false;
            if (this.TriggerAvailablePercent != input.TriggerAvailablePercent || (this.TriggerAvailablePercent != null && !this.TriggerAvailablePercent.Equals(input.TriggerAvailablePercent))) return false;
            if (this.Percents != input.Percents || (this.Percents != null && input.Percents != null && !this.Percents.SequenceEqual(input.Percents))) return false;
            if (this.StepSize != input.StepSize || (this.StepSize != null && !this.StepSize.Equals(input.StepSize))) return false;
            if (this.StepPercent != input.StepPercent || (this.StepPercent != null && !this.StepPercent.Equals(input.StepPercent))) return false;

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
                if (this.SwitchOption != null) hashCode = hashCode * 59 + this.SwitchOption.GetHashCode();
                if (this.LimitVolumeSize != null) hashCode = hashCode * 59 + this.LimitVolumeSize.GetHashCode();
                if (this.MinVolumeSize != null) hashCode = hashCode * 59 + this.MinVolumeSize.GetHashCode();
                if (this.MaxVolumeSize != null) hashCode = hashCode * 59 + this.MaxVolumeSize.GetHashCode();
                if (this.TriggerAvailablePercent != null) hashCode = hashCode * 59 + this.TriggerAvailablePercent.GetHashCode();
                if (this.Percents != null) hashCode = hashCode * 59 + this.Percents.GetHashCode();
                if (this.StepSize != null) hashCode = hashCode * 59 + this.StepSize.GetHashCode();
                if (this.StepPercent != null) hashCode = hashCode * 59 + this.StepPercent.GetHashCode();
                return hashCode;
            }
        }
    }
}
