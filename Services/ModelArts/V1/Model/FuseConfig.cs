using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释：** 熔断配置。 **取值范围：** 不涉及。
    /// </summary>
    public class FuseConfig 
    {

        /// <summary>
        /// **参数解释：** 错误率熔断开关。 **约束限制：** 不涉及。 **取值范围：** * true：开启错误率熔断。 * false：不打开错误率熔断。 **默认取值：** false：不打开错误率熔断。
        /// </summary>
        [JsonProperty("error_rate_fuse_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ErrorRateFuseEnable { get; set; }

        /// <summary>
        /// **参数解释：** 错误率熔断阈值。 **约束限制：** 不涉及。 **取值范围：** (0, 1]（最多支持2位小数，小数点后第3位做四舍五入处理）。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("error_rate_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public float? ErrorRateThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuseConfig {\n");
            sb.Append("  errorRateFuseEnable: ").Append(ErrorRateFuseEnable).Append("\n");
            sb.Append("  errorRateThreshold: ").Append(ErrorRateThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FuseConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FuseConfig input)
        {
            if (input == null) return false;
            if (this.ErrorRateFuseEnable != input.ErrorRateFuseEnable || (this.ErrorRateFuseEnable != null && !this.ErrorRateFuseEnable.Equals(input.ErrorRateFuseEnable))) return false;
            if (this.ErrorRateThreshold != input.ErrorRateThreshold || (this.ErrorRateThreshold != null && !this.ErrorRateThreshold.Equals(input.ErrorRateThreshold))) return false;

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
                if (this.ErrorRateFuseEnable != null) hashCode = hashCode * 59 + this.ErrorRateFuseEnable.GetHashCode();
                if (this.ErrorRateThreshold != null) hashCode = hashCode * 59 + this.ErrorRateThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
