using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 数据过滤对象响应体
    /// </summary>
    public class GeneralDataFilterResp 
    {

        /// <summary>
        /// 源数据库的过滤条件SQL表达式。
        /// </summary>
        [JsonProperty("source_filter_condition", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceFilterCondition { get; set; }

        /// <summary>
        /// 目标数据库的过滤条件SQL表达式。
        /// </summary>
        [JsonProperty("target_filter_condition", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetFilterCondition { get; set; }

        /// <summary>
        /// 标记源库和目标库过滤条件是否分开配置。
        /// </summary>
        [JsonProperty("condition_separated", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionSeparated { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneralDataFilterResp {\n");
            sb.Append("  sourceFilterCondition: ").Append(SourceFilterCondition).Append("\n");
            sb.Append("  targetFilterCondition: ").Append(TargetFilterCondition).Append("\n");
            sb.Append("  conditionSeparated: ").Append(ConditionSeparated).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GeneralDataFilterResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GeneralDataFilterResp input)
        {
            if (input == null) return false;
            if (this.SourceFilterCondition != input.SourceFilterCondition || (this.SourceFilterCondition != null && !this.SourceFilterCondition.Equals(input.SourceFilterCondition))) return false;
            if (this.TargetFilterCondition != input.TargetFilterCondition || (this.TargetFilterCondition != null && !this.TargetFilterCondition.Equals(input.TargetFilterCondition))) return false;
            if (this.ConditionSeparated != input.ConditionSeparated || (this.ConditionSeparated != null && !this.ConditionSeparated.Equals(input.ConditionSeparated))) return false;

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
                if (this.SourceFilterCondition != null) hashCode = hashCode * 59 + this.SourceFilterCondition.GetHashCode();
                if (this.TargetFilterCondition != null) hashCode = hashCode * 59 + this.TargetFilterCondition.GetHashCode();
                if (this.ConditionSeparated != null) hashCode = hashCode * 59 + this.ConditionSeparated.GetHashCode();
                return hashCode;
            }
        }
    }
}
