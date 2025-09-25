using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MergeRequestCustomAverageEvaluationDto 
    {

        /// <summary>
        /// **参数解释：** 自定义评价维度id。
        /// </summary>
        [JsonProperty("evaluation_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? EvaluationTypeId { get; set; }

        /// <summary>
        /// **参数解释：** 自定义评价维度名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 自定义评价维度平均分。
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public double? Level { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeRequestCustomAverageEvaluationDto {\n");
            sb.Append("  evaluationTypeId: ").Append(EvaluationTypeId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeRequestCustomAverageEvaluationDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeRequestCustomAverageEvaluationDto input)
        {
            if (input == null) return false;
            if (this.EvaluationTypeId != input.EvaluationTypeId || (this.EvaluationTypeId != null && !this.EvaluationTypeId.Equals(input.EvaluationTypeId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;

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
                if (this.EvaluationTypeId != null) hashCode = hashCode * 59 + this.EvaluationTypeId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                return hashCode;
            }
        }
    }
}
