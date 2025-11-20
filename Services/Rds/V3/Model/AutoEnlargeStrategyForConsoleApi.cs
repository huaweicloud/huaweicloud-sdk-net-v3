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
    /// 自动扩容策略
    /// </summary>
    public class AutoEnlargeStrategyForConsoleApi 
    {

        /// <summary>
        /// 是否开启自动扩容。
        /// </summary>
        [JsonProperty("option", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Option { get; set; }

        /// <summary>
        /// 扩容上限，单位GB。“option”为true时，该参数必填。
        /// </summary>
        [JsonProperty("limitSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? LimitSize { get; set; }

        /// <summary>
        /// 可用存储空间百分比，小于等于此值或者为10GB时触发扩容。“option”为true时，该参数必填。
        /// </summary>
        [JsonProperty("triggerAvailablePercent", NullValueHandling = NullValueHandling.Ignore)]
        public long? TriggerAvailablePercent { get; set; }

        /// <summary>
        /// 每次自动扩容的步长，单位为百分比，即每次自动扩容当前存储空间的百分比。取值范围为5%~50%。
        /// </summary>
        [JsonProperty("stepPercent", NullValueHandling = NullValueHandling.Ignore)]
        public long? StepPercent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoEnlargeStrategyForConsoleApi {\n");
            sb.Append("  option: ").Append(Option).Append("\n");
            sb.Append("  limitSize: ").Append(LimitSize).Append("\n");
            sb.Append("  triggerAvailablePercent: ").Append(TriggerAvailablePercent).Append("\n");
            sb.Append("  stepPercent: ").Append(StepPercent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoEnlargeStrategyForConsoleApi);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoEnlargeStrategyForConsoleApi input)
        {
            if (input == null) return false;
            if (this.Option != input.Option || (this.Option != null && !this.Option.Equals(input.Option))) return false;
            if (this.LimitSize != input.LimitSize || (this.LimitSize != null && !this.LimitSize.Equals(input.LimitSize))) return false;
            if (this.TriggerAvailablePercent != input.TriggerAvailablePercent || (this.TriggerAvailablePercent != null && !this.TriggerAvailablePercent.Equals(input.TriggerAvailablePercent))) return false;
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
                if (this.Option != null) hashCode = hashCode * 59 + this.Option.GetHashCode();
                if (this.LimitSize != null) hashCode = hashCode * 59 + this.LimitSize.GetHashCode();
                if (this.TriggerAvailablePercent != null) hashCode = hashCode * 59 + this.TriggerAvailablePercent.GetHashCode();
                if (this.StepPercent != null) hashCode = hashCode * 59 + this.StepPercent.GetHashCode();
                return hashCode;
            }
        }
    }
}
