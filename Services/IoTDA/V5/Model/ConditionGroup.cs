using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 规则条件组
    /// </summary>
    public class ConditionGroup 
    {

        /// <summary>
        /// **参数说明**：规则的条件列表，单个规则最多支持设置10个条件。
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleCondition> Conditions { get; set; }

        /// <summary>
        /// **参数说明**：规则条件列表中多个条件之间的逻辑关系，默认值：and。 **取值范围**： - and：逻辑且。 - or：逻辑或。
        /// </summary>
        [JsonProperty("logic", NullValueHandling = NullValueHandling.Ignore)]
        public string Logic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("time_range", NullValueHandling = NullValueHandling.Ignore)]
        public TimeRange TimeRange { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionGroup {\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
            sb.Append("  logic: ").Append(Logic).Append("\n");
            sb.Append("  timeRange: ").Append(TimeRange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConditionGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConditionGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    input.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
                ) && 
                (
                    this.Logic == input.Logic ||
                    (this.Logic != null &&
                    this.Logic.Equals(input.Logic))
                ) && 
                (
                    this.TimeRange == input.TimeRange ||
                    (this.TimeRange != null &&
                    this.TimeRange.Equals(input.TimeRange))
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
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.Logic != null)
                    hashCode = hashCode * 59 + this.Logic.GetHashCode();
                if (this.TimeRange != null)
                    hashCode = hashCode * 59 + this.TimeRange.GetHashCode();
                return hashCode;
            }
        }
    }
}
