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
    /// 
    /// </summary>
    public class AlarmLevelStatisticsResult 
    {

        /// <summary>
        /// **参数解释**: 告警数量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// **参数解释**: 告警级别名称。 **取值范围**: - critical - major - minor - notice
        /// </summary>
        [JsonProperty("level_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LevelName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmLevelStatisticsResult {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  levelName: ").Append(LevelName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmLevelStatisticsResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmLevelStatisticsResult input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.LevelName != input.LevelName || (this.LevelName != null && !this.LevelName.Equals(input.LevelName))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.LevelName != null) hashCode = hashCode * 59 + this.LevelName.GetHashCode();
                return hashCode;
            }
        }
    }
}
