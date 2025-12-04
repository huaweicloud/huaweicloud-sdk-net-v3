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
    public class ShowIntelligentKillSessionStatisticResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  不同维度下的统计信息。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<IntelligentKillSessionStatistic> Statistics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIntelligentKillSessionStatisticResponse {\n");
            sb.Append("  statistics: ").Append(Statistics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIntelligentKillSessionStatisticResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIntelligentKillSessionStatisticResponse input)
        {
            if (input == null) return false;
            if (this.Statistics != input.Statistics || (this.Statistics != null && input.Statistics != null && !this.Statistics.SequenceEqual(input.Statistics))) return false;

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
                if (this.Statistics != null) hashCode = hashCode * 59 + this.Statistics.GetHashCode();
                return hashCode;
            }
        }
    }
}
