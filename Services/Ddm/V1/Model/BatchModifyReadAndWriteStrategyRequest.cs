using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchModifyReadAndWriteStrategyRequest 
    {

        /// <summary>
        /// **参数解释**：  读写策略。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("read_weight_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, int?>> ReadWeightList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchModifyReadAndWriteStrategyRequest {\n");
            sb.Append("  readWeightList: ").Append(ReadWeightList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchModifyReadAndWriteStrategyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchModifyReadAndWriteStrategyRequest input)
        {
            if (input == null) return false;
            if (this.ReadWeightList != input.ReadWeightList || (this.ReadWeightList != null && input.ReadWeightList != null && !this.ReadWeightList.SequenceEqual(input.ReadWeightList))) return false;

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
                if (this.ReadWeightList != null) hashCode = hashCode * 59 + this.ReadWeightList.GetHashCode();
                return hashCode;
            }
        }
    }
}
