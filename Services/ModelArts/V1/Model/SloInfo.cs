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
    /// SLO配置信息
    /// </summary>
    public class SloInfo 
    {

        /// <summary>
        /// **参数解释：** 仿真期望指标。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("slo_objectives", NullValueHandling = NullValueHandling.Ignore)]
        public List<SloObjectives> SloObjectives { get; set; }

        /// <summary>
        /// **参数解释：** 预测时间窗口。 **约束限制：** 60~600。 **取值范围：** 不涉及。 **默认取值：** 60。
        /// </summary>
        [JsonProperty("predict_window_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? PredictWindowSeconds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SloInfo {\n");
            sb.Append("  sloObjectives: ").Append(SloObjectives).Append("\n");
            sb.Append("  predictWindowSeconds: ").Append(PredictWindowSeconds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SloInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SloInfo input)
        {
            if (input == null) return false;
            if (this.SloObjectives != input.SloObjectives || (this.SloObjectives != null && input.SloObjectives != null && !this.SloObjectives.SequenceEqual(input.SloObjectives))) return false;
            if (this.PredictWindowSeconds != input.PredictWindowSeconds || (this.PredictWindowSeconds != null && !this.PredictWindowSeconds.Equals(input.PredictWindowSeconds))) return false;

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
                if (this.SloObjectives != null) hashCode = hashCode * 59 + this.SloObjectives.GetHashCode();
                if (this.PredictWindowSeconds != null) hashCode = hashCode * 59 + this.PredictWindowSeconds.GetHashCode();
                return hashCode;
            }
        }
    }
}
