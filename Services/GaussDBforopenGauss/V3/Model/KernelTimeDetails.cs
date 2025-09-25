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
    /// 内核耗时详细信息
    /// </summary>
    public class KernelTimeDetails 
    {

        /// <summary>
        /// **参数解释**: SQL解析时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("parse_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParseTime { get; set; }

        /// <summary>
        /// **参数解释**: SQL重写时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("rewrite_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RewriteTime { get; set; }

        /// <summary>
        /// **参数解释**: SQL生成计划时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("plan_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanTime { get; set; }

        /// <summary>
        /// **参数解释**: 执行器内执行时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExecutionTime { get; set; }

        /// <summary>
        /// **参数解释**: 其余耗时（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("other_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? OtherTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KernelTimeDetails {\n");
            sb.Append("  parseTime: ").Append(ParseTime).Append("\n");
            sb.Append("  rewriteTime: ").Append(RewriteTime).Append("\n");
            sb.Append("  planTime: ").Append(PlanTime).Append("\n");
            sb.Append("  executionTime: ").Append(ExecutionTime).Append("\n");
            sb.Append("  otherTime: ").Append(OtherTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KernelTimeDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KernelTimeDetails input)
        {
            if (input == null) return false;
            if (this.ParseTime != input.ParseTime || (this.ParseTime != null && !this.ParseTime.Equals(input.ParseTime))) return false;
            if (this.RewriteTime != input.RewriteTime || (this.RewriteTime != null && !this.RewriteTime.Equals(input.RewriteTime))) return false;
            if (this.PlanTime != input.PlanTime || (this.PlanTime != null && !this.PlanTime.Equals(input.PlanTime))) return false;
            if (this.ExecutionTime != input.ExecutionTime || (this.ExecutionTime != null && !this.ExecutionTime.Equals(input.ExecutionTime))) return false;
            if (this.OtherTime != input.OtherTime || (this.OtherTime != null && !this.OtherTime.Equals(input.OtherTime))) return false;

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
                if (this.ParseTime != null) hashCode = hashCode * 59 + this.ParseTime.GetHashCode();
                if (this.RewriteTime != null) hashCode = hashCode * 59 + this.RewriteTime.GetHashCode();
                if (this.PlanTime != null) hashCode = hashCode * 59 + this.PlanTime.GetHashCode();
                if (this.ExecutionTime != null) hashCode = hashCode * 59 + this.ExecutionTime.GetHashCode();
                if (this.OtherTime != null) hashCode = hashCode * 59 + this.OtherTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
