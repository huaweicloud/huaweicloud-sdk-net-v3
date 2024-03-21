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
    /// Response Object
    /// </summary>
    public class ShowAutoEnlargePolicyResponse : SdkResponse
    {

        /// <summary>
        /// 是否已开启自动扩容，true为开启
        /// </summary>
        [JsonProperty("switch_option", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchOption { get; set; }

        /// <summary>
        /// 扩容上限，单位GB
        /// </summary>
        [JsonProperty("limit_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? LimitSize { get; set; }

        /// <summary>
        /// 可用空间百分比，小于等于此值或者10GB时触发扩容
        /// </summary>
        [JsonProperty("trigger_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerThreshold { get; set; }

        /// <summary>
        /// 每次自动扩容的百分比步长，开启自定义步长功能时返回。
        /// </summary>
        [JsonProperty("step_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? StepPercent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAutoEnlargePolicyResponse {\n");
            sb.Append("  switchOption: ").Append(SwitchOption).Append("\n");
            sb.Append("  limitSize: ").Append(LimitSize).Append("\n");
            sb.Append("  triggerThreshold: ").Append(TriggerThreshold).Append("\n");
            sb.Append("  stepPercent: ").Append(StepPercent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAutoEnlargePolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAutoEnlargePolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SwitchOption == input.SwitchOption ||
                    (this.SwitchOption != null &&
                    this.SwitchOption.Equals(input.SwitchOption))
                ) && 
                (
                    this.LimitSize == input.LimitSize ||
                    (this.LimitSize != null &&
                    this.LimitSize.Equals(input.LimitSize))
                ) && 
                (
                    this.TriggerThreshold == input.TriggerThreshold ||
                    (this.TriggerThreshold != null &&
                    this.TriggerThreshold.Equals(input.TriggerThreshold))
                ) && 
                (
                    this.StepPercent == input.StepPercent ||
                    (this.StepPercent != null &&
                    this.StepPercent.Equals(input.StepPercent))
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
                if (this.SwitchOption != null)
                    hashCode = hashCode * 59 + this.SwitchOption.GetHashCode();
                if (this.LimitSize != null)
                    hashCode = hashCode * 59 + this.LimitSize.GetHashCode();
                if (this.TriggerThreshold != null)
                    hashCode = hashCode * 59 + this.TriggerThreshold.GetHashCode();
                if (this.StepPercent != null)
                    hashCode = hashCode * 59 + this.StepPercent.GetHashCode();
                return hashCode;
            }
        }
    }
}
