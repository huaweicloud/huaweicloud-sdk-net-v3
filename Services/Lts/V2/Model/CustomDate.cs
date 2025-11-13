using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 告警规则配置的自定义查询区间。
    /// </summary>
    public class CustomDate 
    {

        /// <summary>
        /// **参数解释：** 查询起始时间相对于告警计划执行时间的偏移量数值。 **约束限制：** 根据start_unit字段的单位将有不同的取值范围，根据单位将start换算为时间不超过1天。 **取值范围：** start_unit取值为second，start取值范围为 1-86400； start_unit取值为minute，start取值范围为 1-1440； start_unit取值为hour，start取值范围为 1-24。 **默认取值：** -无。
        /// </summary>
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public int? Start { get; set; }

        /// <summary>
        /// **参数解释：** 查询起始时间相对于告警计划执行时间的偏移量单位。 **约束限制：** 整点时间即is_time_range_relative为false时start_unit不支持second。 **取值范围：** - hour - minute - second **默认取值：** minute
        /// </summary>
        [JsonProperty("start_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string StartUnit { get; set; }

        /// <summary>
        /// **参数解释：** 查询结束时间相对于告警计划执行时间的偏移量数值。 **约束限制：** 根据end_unit字段的单位将有不同的取值范围，根据单位将end换算为时间不超过1天； **取值范围：** end_unit取值为second，endt取值范围为 0-86399； end_unit取值为minute，end取值范围为 0-1439； end_unit取值为hour，end取值范围为 0-23。 **默认取值：** -无。
        /// </summary>
        [JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
        public int? End { get; set; }

        /// <summary>
        /// **参数解释：** 查询结束时间相对于告警计划执行时间的偏移量单位。 **约束限制：** 整点时间即is_time_range_relative为false时end_unit不支持second。 **取值范围：** - hour - minute - second **默认取值：** minute
        /// </summary>
        [JsonProperty("end_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string EndUnit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomDate {\n");
            sb.Append("  start: ").Append(Start).Append("\n");
            sb.Append("  startUnit: ").Append(StartUnit).Append("\n");
            sb.Append("  end: ").Append(End).Append("\n");
            sb.Append("  endUnit: ").Append(EndUnit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomDate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomDate input)
        {
            if (input == null) return false;
            if (this.Start != input.Start || (this.Start != null && !this.Start.Equals(input.Start))) return false;
            if (this.StartUnit != input.StartUnit || (this.StartUnit != null && !this.StartUnit.Equals(input.StartUnit))) return false;
            if (this.End != input.End || (this.End != null && !this.End.Equals(input.End))) return false;
            if (this.EndUnit != input.EndUnit || (this.EndUnit != null && !this.EndUnit.Equals(input.EndUnit))) return false;

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
                if (this.Start != null) hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.StartUnit != null) hashCode = hashCode * 59 + this.StartUnit.GetHashCode();
                if (this.End != null) hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.EndUnit != null) hashCode = hashCode * 59 + this.EndUnit.GetHashCode();
                return hashCode;
            }
        }
    }
}
