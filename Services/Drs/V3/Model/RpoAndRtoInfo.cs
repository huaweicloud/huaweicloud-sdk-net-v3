using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// RPO和RTO信息体
    /// </summary>
    public class RpoAndRtoInfo 
    {

        /// <summary>
        /// **参数解释**：  数据复制的检查点位置，标识已同步数据的Binlog位置。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("check_point", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckPoint { get; set; }

        /// <summary>
        /// **参数解释**：  数据同步延迟时间。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public string Delay { get; set; }

        /// <summary>
        /// **参数解释**：  全局事务ID集合（Global Transaction Identifier），用于标识已执行的事务。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("gtid_set", NullValueHandling = NullValueHandling.Ignore)]
        public string GtidSet { get; set; }

        /// <summary>
        /// **参数解释**：  RPO或RTO的统计时间点，格式为\&quot;yyyy-MM-dd HH:mm:ss\&quot;。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RpoAndRtoInfo {\n");
            sb.Append("  checkPoint: ").Append(CheckPoint).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  gtidSet: ").Append(GtidSet).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RpoAndRtoInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RpoAndRtoInfo input)
        {
            if (input == null) return false;
            if (this.CheckPoint != input.CheckPoint || (this.CheckPoint != null && !this.CheckPoint.Equals(input.CheckPoint))) return false;
            if (this.Delay != input.Delay || (this.Delay != null && !this.Delay.Equals(input.Delay))) return false;
            if (this.GtidSet != input.GtidSet || (this.GtidSet != null && !this.GtidSet.Equals(input.GtidSet))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;

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
                if (this.CheckPoint != null) hashCode = hashCode * 59 + this.CheckPoint.GetHashCode();
                if (this.Delay != null) hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.GtidSet != null) hashCode = hashCode * 59 + this.GtidSet.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }
}
