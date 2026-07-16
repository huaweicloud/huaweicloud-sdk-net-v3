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
    /// 作业流程阶段记录。
    /// </summary>
    public class StageRecord 
    {

        /// <summary>
        /// **参数解释**：阶段记录序号，顺序递增，最大序号记录为当前最新记录。  **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("record_order", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordOrder { get; set; }

        /// <summary>
        /// **参数解释**：主阶段信息列表。
        /// </summary>
        [JsonProperty("stages", NullValueHandling = NullValueHandling.Ignore)]
        public List<StageInfoWithSub> Stages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StageRecord {\n");
            sb.Append("  recordOrder: ").Append(RecordOrder).Append("\n");
            sb.Append("  stages: ").Append(Stages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StageRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StageRecord input)
        {
            if (input == null) return false;
            if (this.RecordOrder != input.RecordOrder || (this.RecordOrder != null && !this.RecordOrder.Equals(input.RecordOrder))) return false;
            if (this.Stages != input.Stages || (this.Stages != null && input.Stages != null && !this.Stages.SequenceEqual(input.Stages))) return false;

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
                if (this.RecordOrder != null) hashCode = hashCode * 59 + this.RecordOrder.GetHashCode();
                if (this.Stages != null) hashCode = hashCode * 59 + this.Stages.GetHashCode();
                return hashCode;
            }
        }
    }
}
